FROM microsoft/dotnet:latest

WORKDIR /app

COPY . /app

RUN ["dotnet", "restore"]

RUN ["dotnet", "build"]

EXPOSE 8001

ENTRYPOINT ["dotnet", "run"]
