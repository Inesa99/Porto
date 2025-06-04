# Build Stage
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build

# Set working directory
WORKDIR /src

# Copy csproj and restore
COPY Porto/Porto.csproj ./Porto/
WORKDIR /src/Porto
RUN dotnet restore

# Copy all project files
WORKDIR /src
COPY . .

# Install EF Core CLI
RUN dotnet tool install --global dotnet-ef
ENV PATH="$PATH:/root/.dotnet/tools"

# Apply EF Core migration
WORKDIR /src/Porto

# Add migration (temporary name like 'AutoMigration')
RUN dotnet ef migrations add AutoMigration -c ApplicationContext

# Update database
RUN dotnet ef database update -c ApplicationContext

# Publish app
RUN dotnet publish -c Release -o /app/publish


# Runtime Stage - lightweight
FROM mcr.microsoft.com/dotnet/aspnet:8.0

WORKDIR /app
COPY --from=build /app/publish .

EXPOSE 80

ENTRYPOINT ["dotnet", "Porto.dll"]

