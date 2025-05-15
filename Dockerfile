# Build Stage
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build

WORKDIR /src

COPY Porto/Porto.csproj ./Porto/
WORKDIR /src/Porto
RUN dotnet restore

WORKDIR /src
COPY . .

WORKDIR /src/Porto
RUN dotnet publish -c Release -o /app/publish

# Runtime Stage with SDK for EF CLI
FROM mcr.microsoft.com/dotnet/sdk:8.0

WORKDIR /app
COPY --from=build /app/publish .

EXPOSE 80

ENTRYPOINT ["sh", "-c", "dotnet ef database update -c ApplicationContext && dotnet Porto.dll"]
