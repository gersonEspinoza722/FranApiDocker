# FranApiDocker
FranApiDocker

dotnet add package Npgsql.EntityFrameworkCore.PostgreSQL --version 5.0
dotnet add package Microsoft.EntityFrameworkCore.Design
dotnet tool install --global dotnet-ef

http://localhost:8080/weatherforecast
http://localhost:8080/swagger/index.html

https://localhost:5001/weatherforecast

postgresql.conf file----> listen_addresses '*'
Connection string for dockerized----> Host=host.docker.internal;Port=5432;Database=FranApi;User Id=postgres;Password=password;



docker build -t franapi20 .
docker run -p 8080:80 franapi20

