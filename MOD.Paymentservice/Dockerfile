FROM mcr.microsoft.com/dotnet/core/aspnet:3.0-buster-slim AS base
WORKDIR /app
EXPOSE 80

FROM mcr.microsoft.com/dotnet/core/sdk:3.0-buster AS build
WORKDIR /src
COPY ["MOD.Paymentservice/MOD.Paymentservice.csproj", "MOD.Paymentservice/"]
RUN dotnet restore "MOD.Paymentservice/MOD.Paymentservice.csproj"
COPY . .
WORKDIR "/src/MOD.Paymentservice"
RUN dotnet build "MOD.Paymentservice.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "MOD.Paymentservice.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "MOD.Paymentservice.dll"]