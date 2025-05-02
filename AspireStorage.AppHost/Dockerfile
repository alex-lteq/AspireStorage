FROM mcr.microsoft.com/dotnet/aspnet:9.0 AS base

# Install ffmpeg
RUN apt-get update && \
    apt-get install -y ffmpeg && \
    rm -rf /var/lib/apt/lists/*

WORKDIR / 
COPY ./publish .

EXPOSE 5000
ENTRYPOINT ["dotnet", "AspireStorage.AppHost.dll"]