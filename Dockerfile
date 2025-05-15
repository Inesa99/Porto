# Կառուցման փուլը՝ .NET 8 SDK
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /app

# Քոփի ենք անում CSPROJ ֆայլը առանձին, restore անելիս cache օգտագործելու համար
COPY *.csproj ./
RUN dotnet restore

# Քոփի ենք անում մնացածը
COPY . ./
RUN dotnet publish -c Release -o out

# Վերջնական փուլը՝ .NET 8 ASP.NET Runtime
FROM mcr.microsoft.com/dotnet/aspnet:8.0
WORKDIR /app
COPY --from=build /app/out .

# Եթե Render-ը օգտագործում է 80 պորտը
EXPOSE 80

# Սկսում ենք հավելվածը
ENTRYPOINT ["dotnet", "Porto.dll"]
