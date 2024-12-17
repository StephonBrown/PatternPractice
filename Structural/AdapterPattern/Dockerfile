FROM mcr.microsoft.com/dotnet/runtime:8.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /src
COPY ["CreationPatterns/CreationPatterns.csproj", "CreationPatterns/"]
RUN dotnet restore "CreationPatterns/CreationPatterns.csproj"
COPY . .
WORKDIR "/src/CreationPatterns"
RUN dotnet build "CreationPatterns.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "CreationPatterns.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "CreationPatterns.dll"]
