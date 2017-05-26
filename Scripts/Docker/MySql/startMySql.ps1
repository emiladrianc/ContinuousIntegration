Write-Host "Starting mysql ..." -foregroundcolor Blue -backgroundcolor White

$mySqlImageVersion = "8.0.1"
$mySqlPort = "3306"
$mySqlDatabase = "myDB"
$mySqlUser = "myUser"
$mySqlPassword = "myPass"
$mySqlRootPassword = "mySuperSecretPassword"

Write-Host "Get mySql image:" $mySqlImageVersion " ..." -foregroundcolor Blue -backgroundcolor White

docker pull mysql:$mySqlImageVersion

Write-Host "Get mySql image:" $mySqlImageVersion " ...Done" -foregroundcolor Blue -backgroundcolor White

Write-Host "Starting mySql container on port:" $mySqlPort "..." -foregroundcolor Blue -backgroundcolor White
Write-Host "Using db:" $mysqlDatabase "..." -foregroundcolor Blue -backgroundcolor White
Write-Host "Using user:" $mysqlUser "..." -foregroundcolor Blue -backgroundcolor White
Write-Host "Using pass:" $mysqlPassword "..." -foregroundcolor Blue -backgroundcolor White

$runMySqlInstruction = "docker run -d --name mySqlServer -p " + $mySqlPort + ":3306 "
$runMySqlInstruction += "-e MYSQL_ROOT_PASSWORD='" + $mySqlRootPassword + "' "
$runMySqlInstruction += "-e MYSQL_DATABASE='" + $mySqlDatabase +  "' "
$runMySqlInstruction += "-e MYSQL_USER='" + $mySqlUser +  "' "
$runMySqlInstruction += "-e MYSQL_PASSWORD='" + $mySqlPassword +  "' "
$runMySqlInstruction += "mysql:" + $mySqlImageVersion
Write-Host "Command:" $runMySqlInstruction 

Invoke-Expression $runMySqlInstruction

Write-Host "Starting mysql container on port:" $mySqlPort "...Done" -foregroundcolor Blue -backgroundcolor White
