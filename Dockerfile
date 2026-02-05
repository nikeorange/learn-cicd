# Этап 1: Сборка
FROM mcr.microsoft.com/dotnet/sdk:10.0 AS build
WORKDIR /src

# Копируем проект
COPY SimpleApp/SimpleApp.csproj SimpleApp/
RUN dotnet restore "SimpleApp/SimpleApp.csproj"

# Копируем остальные файлы
COPY . .

# Собираем
WORKDIR "/src/SimpleApp"
RUN dotnet build "SimpleApp.csproj" -c Release -o /app/build

# Этап 2: Публикация
FROM build AS publish
RUN dotnet publish "SimpleApp.csproj" -c Release -o /app/publish

# Этап 3: Финальный образ
FROM mcr.microsoft.com/dotnet/runtime:10.0 AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "SimpleApp.dll"]