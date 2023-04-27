#See https://aka.ms/customizecontainer to learn how to customize your debug container and how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["MicrosoftMicroServiceGuide_1/MicrosoftMicroServiceGuide_1.csproj", "MicrosoftMicroServiceGuide_1/"]
RUN dotnet restore "MicrosoftMicroServiceGuide_1/MicrosoftMicroServiceGuide_1.csproj"
COPY . .
WORKDIR "/src/MicrosoftMicroServiceGuide_1"
RUN dotnet build "MicrosoftMicroServiceGuide_1.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "MicrosoftMicroServiceGuide_1.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "MicrosoftMicroServiceGuide_1.dll"]