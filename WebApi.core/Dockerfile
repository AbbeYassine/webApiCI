FROM microsoft/dotnet:latest

COPY ./bin/Debug/netcoreapp1.0/ubuntu.16.04-x64/WebApi.core /app/

WORKDIR /app

EXPOSE 8001

CMD ["/app/WebApi.core"]