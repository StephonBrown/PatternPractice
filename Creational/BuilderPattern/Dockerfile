FROM mcr.microsoft.com/dotnet/runtime:8.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /src
COPY ["Creational/BuilderPattern/BuilderPattern.csproj", "Creational/BuilderPattern/"]
RUN dotnet restore "Creational/BuilderPattern/BuilderPattern.csproj"
COPY . .
WORKDIR "/src/Creational/BuilderPattern"
RUN dotnet build "BuilderPattern.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "BuilderPattern.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "BuilderPattern.dll"]
