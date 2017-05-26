Write-Host "Stopping postgres container ..." -foregroundcolor Blue -backgroundcolor White

docker stop myPostgresServer

Write-Host "Stopping postgres container ...Done" -foregroundcolor Blue -backgroundcolor White

Write-Host "Deleting postgres container ..." -foregroundcolor Blue -backgroundcolor White

docker rm myPostgresServer

Write-Host "Deleting postgres container ...Done" -foregroundcolor Blue -backgroundcolor White
