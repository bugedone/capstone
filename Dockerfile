FROM mcr.microsoft.com/dotnet/aspnet:7.0
WORKDIR /app
COPY App/* /app/
ENTRYPOINT ["dotnet", "Capstone.dll"]
