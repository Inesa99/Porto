FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /src

# Սկզբում միայն .sln և .csproj ֆայլերը
COPY Porto/Porto.sln ./
COPY Porto/Porto.csproj ./Porto/

# Restore dependencies
RUN dotnet restore ./Porto/Porto.csproj

# Հիմա ամբողջ լուծումը
COPY Porto/ ./Porto/

WORKDIR /src/Porto
RUN dotnet publish -c Release -o /app/out

# Runtime image
FROM mcr.microsoft.com/dotnet/aspnet:8.0
WORKDIR /app
COPY --from=build /app/out .

ENTRYPOINT ["dotnet", "Porto.dll"]
