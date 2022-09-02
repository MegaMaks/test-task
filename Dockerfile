# Base OS layer
FROM mcr.microsoft.com/dotnet/runtime:6.0

# Copy all runtime files from build drop into image.
COPY ./bin/Debug/net6.0/linux-x64/publish/ /opt/app

# Set workdir inside container
WORKDIR /opt/app

# Expose service default port
EXPOSE 5000

ENTRYPOINT ["dotnet", "helloworld.dll"]
