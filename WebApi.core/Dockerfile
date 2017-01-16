FROM microsoft/dotnet:latest

COPY ./bin/Debug/netcoreapp1.0/ubuntu.16.04-x64/publish/* /app/

WORKDIR /app

EXPOSE 8001

ENTRYPOINT ["dotnet", "WebApi.core.dll"]
