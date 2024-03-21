#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:7.0 AS base
WORKDIR /app
EXPOSE 104
ENV ASPNETCORE_URLS http://+:104

FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
WORKDIR /src
COPY SecondFlightService.csproj SecondFlightService.csproj
RUN dotnet restore SecondFlightService.csproj
COPY . .
WORKDIR /src
RUN dotnet build SecondFlightService.csproj -c Release -o /app/build

FROM build AS publish
RUN dotnet publish SecondFlightService.csproj -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "SecondFlightService.dll"]