$thisDir = Split-Path $MyInvocation.MyCommand.Path

dotnet test TestProject.csproj `
  --configuration:Debug `
  --property:TestingPlatformCommandLineArguments="--report-trx `--results-directory $thisDir/tests/logs/"

pause