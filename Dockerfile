FROM mcr.microsoft.com/dotnet/sdk:9.0 AS builder

WORKDIR /app

COPY Program.cs .
COPY MyCharpBC.csproj .

RUN dotnet publish -c Release -o out

FROM mcr.microsoft.com/dotnet/runtime:9.0

WORKDIR /app

COPY --from=builder /app/out .

ENTRYPOINT ["dotnet", "MyCharpBC.dll"]
