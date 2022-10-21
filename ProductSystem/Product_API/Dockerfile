#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:3.1 AS base
WORKDIR /app
EXPOSE 80

FROM mcr.microsoft.com/dotnet/sdk:3.1 AS build
WORKDIR /src
COPY ["Product_API/Product_API.csproj", "Product_API/"]
COPY ["Entity_Layer/Entity_Layer.csproj", "Entity_Layer/"]
COPY ["Product_Business/Product_Business.csproj", "Product_Business/"]
COPY ["Product_Data/Product_Data.csproj", "Product_Data/"]
RUN dotnet restore "Product_API/Product_API.csproj"
COPY . .
WORKDIR "/src/Product_API"
RUN dotnet build "Product_API.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Product_API.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Product_API.dll"]