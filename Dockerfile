FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /src

COPY Porto/Porto.sln ./Porto.sln

# Պատճենել բոլոր ենթապրոյեկտները, որոնք դու ունես ֆայլային կառուցվածքում՝ Porto.App, Porto.Common, Porto.Data, Porto (և այլն)
COPY Porto.App/ ./Porto.App/
COPY Porto.Common/ ./Porto.Common/
COPY Porto.Data/ ./Porto.Data/
COPY Porto/ ./Porto/

RUN dotnet restore ./Porto.sln

WORKDIR /src/Porto
RUN dotnet publish -c Release -o /app/out

FROM mcr.microsoft.com/dotnet/aspnet:8.0
WORKDIR /app
COPY --from=build /app/out .

ENTRYPOINT ["dotnet", "Porto.dll"]
