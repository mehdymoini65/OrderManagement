FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS base
WORKDIR /app


USER app
FROM --platform=$BUILDPLATFORM mcr.microsoft.com/dotnet/sdk:8.0 AS build
ARG configuration=Release
WORKDIR /src
COPY ["src/OrderManagement.HttpApi.Host/OrderManagement.HttpApi.Host.csproj", "src/OrderManagement.HttpApi.Host/"]
RUN dotnet restore "src/OrderManagement.HttpApi.Host/OrderManagement.HttpApi.Host.csproj"
COPY . .
WORKDIR "/src/src/OrderManagement.HttpApi.Host"
RUN dotnet build "OrderManagement.HttpApi.Host.csproj" -c $configuration -o /app/build

FROM build AS publish
ARG configuration=Release
RUN dotnet publish "OrderManagement.HttpApi.Host.csproj" -c $configuration -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
EXPOSE 443
EXPOSE 80
ENTRYPOINT ["dotnet", "OrderManagement.HttpApi.Host.dll"]
