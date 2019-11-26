FROM mcr.microsoft.com/dotnet/core/aspnet:3.0-buster-slim AS base
WORKDIR /app
EXPOSE 80

FROM mcr.microsoft.com/dotnet/core/sdk:3.0-buster AS build
WORKDIR /src
COPY ["MOD.Userservice/MOD.Userservice.csproj", "MOD.Userservice/"]
RUN dotnet restore "MOD.Userservice/MOD.Userservice.csproj"
COPY . .
WORKDIR "/src/MOD.Userservice"
RUN dotnet build "MOD.Userservice.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "MOD.Userservice.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "MOD.Userservice.dll"]