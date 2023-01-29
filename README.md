# BookStore
Dotnet (.NET) CRUD web api application with persistence using MongoDB database and docker to build services (dotnet app and Mongo DB application).

## A. Docker Compose Up 

If you are using 

- Windows

```
docker-compose.exe -f ./docker-compose.yml -p bookstore up --build
```
or 

- Linux

```
sudo docker compose -f ./docker-compose.yml -p bookstore up --build
```
After running the last command open the URL:

- http://localhost:5080/swagger/index.html

# Documentation
- [Creación de una API Web con ASP.NET Core y MongoDB](https://learn.microsoft.com/es-es/aspnet/core/tutorials/first-mongo-app?view=aspnetcore-7.0&tabs=visual-studio#create-the-aspnet-core-web-api-project)