FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /src

COPY Porto/Porto.sln .

COPY Porto/ ./Porto/
COPY Porto.App/ ./Porto.App/
COPY Porto.Common/ ./Porto.Common/
COPY Porto.Data/ ./Porto.Data/

RUN dotnet restore Porto.sln

RUN dotnet publish ./Porto/Porto.csproj -c Release -o /app/out

FROM mcr.microsoft.com/dotnet/aspnet:8.0
WORKDIR /app
COPY --from=build /app/out .

ENTRYPOINT ["dotnet", "Porto.dll"]
