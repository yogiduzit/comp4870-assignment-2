FROM mcr.microsoft.com/dotnet/sdk:3.1 AS build-env
WORKDIR /app

COPY BlazorClient ./BlazorClient
COPY StudentLibrary ./StudentLibrary

RUN dotnet publish BlazorClient/BlazorClient.csproj -c Release -o output

FROM nginx:alpine
WORKDIR /var/www/web
COPY --from=build-env /app/output/wwwroot .
COPY --from=build-env /app/BlazorClient/nginx.conf /etc/nginx/nginx.conf
EXPOSE 80