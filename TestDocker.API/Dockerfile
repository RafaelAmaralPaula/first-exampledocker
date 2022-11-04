

FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80

ENV ASPNETCORE_URLS=http://+:8000;http://+:80;
ENV ASPNETCORE_ENVIRONMENT=Development

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["TestDocker.API/TestDocker.API.csproj", "TestDocker.API/"]
COPY ["TestDocker.Application/TestDocker.Application.csproj", "TestDocker.Application/"]
COPY ["TestDocker.Domain/TestDocker.Domain.csproj", "TestDocker.Domain/"]
RUN dotnet restore "TestDocker.API/TestDocker.API.csproj"
COPY . .
WORKDIR "/src/TestDocker.API"
RUN dotnet build "TestDocker.API.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "TestDocker.API.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "TestDocker.API.dll"]