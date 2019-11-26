FROM mcr.microsoft.com/dotnet/core/aspnet:3.0-buster-slim AS base
WORKDIR /app
EXPOSE 80

FROM mcr.microsoft.com/dotnet/core/sdk:3.0-buster AS build
WORKDIR /src
COPY ["MOD.Authenticateservice/MOD.Authenticateservice.csproj", "MOD.Authenticateservice/"]
RUN dotnet restore "MOD.Authenticateservice/MOD.Authenticateservice.csproj"
COPY . .
WORKDIR "/src/MOD.Authenticateservice"
RUN dotnet build "MOD.Authenticateservice.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "MOD.Authenticateservice.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "MOD.Authenticateservice.dll"]