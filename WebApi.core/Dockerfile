FROM microsoft/dotnet:latest

COPY ./bin/Debug/netcoreapp1.0/publish /app/

WORKDIR /app

EXPOSE 8001

ENTRYPOINT ["dotnet", "WebApi.core.dll"]
