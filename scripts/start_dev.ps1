
docker container start mysql_dev

# Start ASP.NET
wt -w 0 new-tab -p "ASP.NET API" -d ./src/API powershell -noExit "dotnet watch"

# Start VueAPP
wt -w 0 new-tab -p "VueAPP" -d ./src/VueApp powershell -noExit "npm run dev"; Start-Process http://localhost:5173/
