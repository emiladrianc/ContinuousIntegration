Write-Host "Starting postgres ..." -foregroundcolor Blue -backgroundcolor White

$postgresImageVersion = "9.6"
$postgresPort = "5432"
$postgresDatabase = "myDB"
$postgresUser = "myUser"
$postgresPassword = "myPass"

Write-Host "Get postgres image:" $postgresImageVersion " ..." -foregroundcolor Blue -backgroundcolor White

docker pull postgres:$postgresImageVersion

Write-Host "Get postgres image:" $postgresImageVersion " ...Done" -foregroundcolor Blue -backgroundcolor White

Write-Host "Starting postgres container on port:" $postgresPort "..." -foregroundcolor Blue -backgroundcolor White
Write-Host "Using db:" $postgresDatabase "..." -foregroundcolor Blue -backgroundcolor White
Write-Host "Using user:" $postgresUser "..." -foregroundcolor Blue -backgroundcolor White
Write-Host "Using pass:" $postgresPassword "..." -foregroundcolor Blue -backgroundcolor White

$runPostgresInstruction = "docker run -d --name myPostgresServer -p " + $postgresPort + ":5432 "
$runPostgresInstruction += "-e POSTGRES_DB='" + $postgresDatabase +  "' "
$runPostgresInstruction += "-e POSTGRES_USER='" + $postgresUser +  "' "
$runPostgresInstruction += "-e POSTGRES_PASSWORD='" + $postgresPassword +  "' "
$runPostgresInstruction += "postgres:" + $postgresImageVersion
Write-Host "Command:" $runPostgresInstruction 

Invoke-Expression $runPostgresInstruction

Write-Host "Starting postgres container on port:" $postgresPort "...Done" -foregroundcolor Blue -backgroundcolor White
