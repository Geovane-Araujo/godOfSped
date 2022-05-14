FROM mcr.microsoft.com/dotnet/runtime:6.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["GodOfSped/GodOfSped.csproj", "GodOfSped/"]
RUN dotnet restore "GodOfSped/GodOfSped.csproj"
COPY . .
WORKDIR "/src/GodOfSped"
RUN dotnet build "GodOfSped.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "GodOfSped.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "GodOfSped.dll"]
