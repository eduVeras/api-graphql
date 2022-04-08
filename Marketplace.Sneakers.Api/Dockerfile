#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["Marketplace.Sneakers.Api/Marketplace.Sneakers.Api.csproj", "Marketplace.Sneakers.Api/"]
RUN dotnet restore "Marketplace.Sneakers.Api/Marketplace.Sneakers.Api.csproj"
COPY . .
WORKDIR "/src/Marketplace.Sneakers.Api"
RUN dotnet build "Marketplace.Sneakers.Api.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Marketplace.Sneakers.Api.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Marketplace.Sneakers.Api.dll"]