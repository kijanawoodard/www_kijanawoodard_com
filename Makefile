build: 
	dotnet build ./src/www_kijana_woodard_com.sln
run: 
	dotnet run --project ./src/Engine/Engine.csproj ./src/site
benchmark:
	dotnet run --project ./src/Benchmarks/Benchmarks.csproj