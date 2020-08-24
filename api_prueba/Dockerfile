FROM microsoft/dotnet:2.2-aspnetcore-runtime AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM microsoft/dotnet:2.2-sdk AS build
WORKDIR /src
COPY ["api_prueba/api_prueba.csproj", "api_prueba/"]
RUN dotnet restore "api_prueba/api_prueba.csproj"
COPY . .
WORKDIR "/src/api_prueba"
RUN dotnet build "api_prueba.csproj" -c Release -o /app

FROM build AS publish
RUN dotnet publish "api_prueba.csproj" -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "api_prueba.dll"]