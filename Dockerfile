FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /src

COPY Porto/Porto.sln ./Porto/
COPY Porto/Porto.csproj ./Porto/

RUN dotnet restore ./Porto/Porto.csproj

COPY Porto/ ./Porto/

WORKDIR /src/Porto
RUN dotnet publish -c Release -o /app/out

FROM mcr.microsoft.com/dotnet/aspnet:8.0
WORKDIR /app
COPY --from=build /app/out .

ENTRYPOINT ["dotnet", "Porto.dll"]
