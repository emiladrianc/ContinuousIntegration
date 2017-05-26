Write-Host "Stopping nexus container ..." -foregroundcolor Blue -backgroundcolor White

docker stop nexusServer

Write-Host "Stopping nexus container ...Done" -foregroundcolor Blue -backgroundcolor White

Write-Host "Deleting nexus container ..." -foregroundcolor Blue -backgroundcolor White

docker rm nexusServer

Write-Host "Deleting nexus container ...Done" -foregroundcolor Blue -backgroundcolor White

