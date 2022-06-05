#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["WebAPI_UT/WebAPI_UT.csproj", "WebAPI_UT/"]
RUN dotnet restore "WebAPI_UT/WebAPI_UT.csproj"
COPY . .
WORKDIR "/src/WebAPI_UT"
RUN dotnet build "WebAPI_UT.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "WebAPI_UT.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "WebAPI_UT.dll"]