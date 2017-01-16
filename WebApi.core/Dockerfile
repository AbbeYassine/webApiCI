FROM microsoft/dotnet:latest

WORKDIR /app

COPY . /app

RUN ["dotnet", "restore"]

EXPOSE 8001

ENTRYPOINT ["dotnet", "run"]
