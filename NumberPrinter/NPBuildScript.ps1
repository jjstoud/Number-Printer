function buildVS
{
    param
    (
        [parameter(Mandatory=$true)]
        [String] $path,

        [parameter(Mandatory=$false)]
        [bool] $nuget = $true,
        
        [parameter(Mandatory=$false)]
        [bool] $clean = $true
    )
    process
    {
        $msBuildExe = 'C:\Program Files (x86)\Microsoft Visual Studio\2017\Community\MSBuild\15.0\Bin\MSBuild.exe'
		$nugetExe = '.\nuget.exe'
		$nunitConsole = '.\packages\NUnit.ConsoleRunner.3.7.0\tools\nunit3-console.exe'

        if ($nuget) {
            Write-Host "Restoring NuGet Packages" -foregroundcolor green
            & "$($nugetExe)" restore "$($path)"
        }

        if ($clean) {
            Write-Host "Cleaning $($path)" -foregroundcolor green
            & "$($msBuildExe)" "$($path)" /t:Clean /m
        }

        Write-Host "Building $($path)" -foregroundcolor green
        & "$($msBuildExe)" "$($path)" /t:Build /m
		
		Write-Host "Running Tests" -foregroundcolor green
		& "$($nunitConsole)" ".\Tests\bin\Debug\NumberTests.dll"
    }
}

buildVS .\NumberPrinter.sln