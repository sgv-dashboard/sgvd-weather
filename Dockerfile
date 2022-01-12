FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 5000

ENV ASPNETCORE_URLS=http://+:5000

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["sgvd-weather.csproj", "./"]
RUN dotnet restore "sgvd-weather.csproj"
COPY . .
WORKDIR "/src/."
RUN dotnet build "sgvd-weather.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "sgvd-weather.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "sgvd-weather.dll"]
