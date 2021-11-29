## ASP.NET Core 3.1 MVC REST API
---


### This is a project created to learn and practice a few concepts:

> - Creating a REST API following the RESTful API guidelines
> - .NET Core
> - MVC (model-view-controller) Architecture
> - C#
> - Dependency Injection
> - SQL Server 
> - Repository Design Pattern
> - Data Transfer Objects
> - HTTP Requests (GET, POST, PUT, PATCH, DELETE)
> - Creating & Testing API Endpoints
> - Deploying project to the web (still WIP)

### Tools used:
> - VSCode
> - SQL Server
> - SQL Server Management Studio
> - Postman (Testing API Endpoints)
> - Swagger & ASP.NET Core (Autogeneration of API Documentation & Endpoint Testing)
> - AutoMapper (To autogenerate API mapping)

### Showcase
Below are some screenshots of the project

#### Documentation Website Commands

![Commands in Documentation Website](https://i.imgur.com/JvccPYP.png)

#### Example of trying out an API endpoint using Swagger (GET command by id 3 in this case - returns 200 Success)

![GET Command by ID](https://i.imgur.com/b3vHgTT.png)

#### Creating a command using Postman with HTTP POST (returns 201 Created)

![POST new command](https://i.imgur.com/H3oUVC2.png)

#### Updating the command with Id '6' using Postman with HTTP PATCH (changes `platform` attribute to new string in `value` - returns 204 No Content)

![PATCH update command](https://i.imgur.com/E2zmn2E.png)