FROM mcr.microsoft.com/dotnet/aspnet:7.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
WORKDIR /src
COPY ["src/ElectronicAdsBoard/Hosts/ElectronicAdsBoard.Hosts.Api/ElectronicAdsBoard.Hosts.Api.csproj", "src/ElectronicAdsBoard/Hosts/ElectronicAdsBoard.Hosts.Api/"]
RUN dotnet restore "src/ElectronicAdsBoard/Hosts/ElectronicAdsBoard.Hosts.Api/ElectronicAdsBoard.Hosts.Api.csproj"
COPY . .
WORKDIR "/src/src/ElectronicAdsBoard/Hosts/ElectronicAdsBoard.Hosts.Api"
RUN dotnet build "ElectronicAdsBoard.Hosts.Api.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "ElectronicAdsBoard.Hosts.Api.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "ElectronicAdsBoard.Hosts.Api.dll"]
