FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS base
USER $APP_UID
WORKDIR /app
EXPOSE 8080
EXPOSE 8081

FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
ARG BUILD_CONFIGURATION=Release
WORKDIR /src
COPY ["Deps_Consulta.Web/Deps_Consulta.Web.csproj", "Deps_Consulta.Web/"]
RUN dotnet restore "Deps_Consulta.Web/Deps_Consulta.Web.csproj"
COPY . .
WORKDIR "/src/Deps_Consulta.Web"
RUN dotnet build "Deps_Consulta.Web.csproj" -c $BUILD_CONFIGURATION -o /app/build

FROM build AS publish
ARG BUILD_CONFIGURATION=Release
RUN dotnet publish "Deps_Consulta.Web.csproj" -c $BUILD_CONFIGURATION -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Deps_Consulta.Web.dll"]
