# Բազային պատկեր՝ .NET 8 SDK
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /src

# Քոփի ենք անում .csproj ֆայլը
COPY Porto/Porto.csproj ./Porto/
WORKDIR /src/Porto
RUN dotnet restore

# Քոփի ենք անում մնացած ֆայլերը
WORKDIR /src
COPY . .

# Կառուցում ենք ու publish անում
WORKDIR /src/Porto
RUN dotnet publish -c Release -o /app/publish

# Runtime image՝ ASP.NET 8
FROM mcr.microsoft.com/dotnet/aspnet:8.0
WORKDIR /app
COPY --from=build /app/publish .

EXPOSE 80
ENTRYPOINT ["dotnet", "Porto.dll"]

