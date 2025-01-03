
docker container start b76baf51ce1365388fa788fd5fcdad6a3a6de23031a0bd67775f2059f76f0806

# Start ASP.NET
wt -w 0 new-tab -p "ASP.NET API" -d ./src/API powershell -noExit "dotnet watch"

# Start VueAPP
wt -w 0 new-tab -p "VueAPP" -d ./src/VueApp powershell -noExit "npm run dev"; Start-Process http://localhost:5173/
