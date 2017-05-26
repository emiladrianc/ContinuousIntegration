Write-Host "Stopping mySql container ..." -foregroundcolor Blue -backgroundcolor White

docker stop mySqlServer

Write-Host "Stopping mySql container ...Done" -foregroundcolor Blue -backgroundcolor White

Write-Host "Deleting mySql container ..." -foregroundcolor Blue -backgroundcolor White

docker rm mySqlServer

Write-Host "Deleting mySql container ...Done" -foregroundcolor Blue -backgroundcolor White
