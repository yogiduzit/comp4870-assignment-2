FROM mcr.microsoft.com/dotnet/sdk:3.1 AS build-env
WORKDIR /app

# Copy API and classlib
COPY StudentAPI ./StudentAPI
COPY StudentLibrary ./StudentLibrary

# Build and publish API
RUN dotnet publish StudentAPI/StudentAPI.csproj -c Release -o out

# Build runtime image
FROM mcr.microsoft.com/dotnet/aspnet:3.1
WORKDIR /app
COPY --from=build-env /app/out .
EXPOSE 80/tcp
EXPOSE 443/tcp
ENTRYPOINT ["dotnet", "StudentAPI.dll"]