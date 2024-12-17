FROM mcr.microsoft.com/dotnet/runtime:8.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /src
COPY ["Structural/Structural.csproj", "Structural/"]
RUN dotnet restore "Structural/Structural.csproj"
COPY . .
WORKDIR "/src/Structural"
RUN dotnet build "Structural.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Structural.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Structural.dll"]
