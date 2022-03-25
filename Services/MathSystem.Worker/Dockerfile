#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/runtime:6.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["MathSystem.Consumer/MathSystem.Consumer.csproj", "MathSystem.Consumer/"]
RUN dotnet restore "MathSystem.Consumer/MathSystem.Consumer.csproj"
COPY . .
WORKDIR "/src/MathSystem.Consumer"
RUN dotnet build "MathSystem.Consumer.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "MathSystem.Consumer.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "MathSystem.Consumer.dll"]