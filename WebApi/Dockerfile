#Parent Image
FROM windowsservercore

#Add released core to /app
ADD ./bin/release /app

#Define /app as working directory
WORKDIR /app

#Executed when container starts
ENTRYPOINT["cmd.exe","/k","executable.exe"]
