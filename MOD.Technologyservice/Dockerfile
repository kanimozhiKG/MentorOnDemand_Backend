FROM mcr.microsoft.com/dotnet/core/aspnet:3.0-buster-slim AS base
WORKDIR /app
EXPOSE 80

FROM mcr.microsoft.com/dotnet/core/sdk:3.0-buster AS build
WORKDIR /src
COPY ["MOD.Technologyservice/MOD.Technologyservice.csproj", "MOD.Technologyservice/"]
RUN dotnet restore "MOD.Technologyservice/MOD.Technologyservice.csproj"
COPY . .
WORKDIR "/src/MOD.Technologyservice"
RUN dotnet build "MOD.Technologyservice.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "MOD.Technologyservice.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "MOD.Technologyservice.dll"]