# Проект: Управление проектарми данными с использованием ASP.NET Core, Entity Framework Core, PostgreSQL, AutoMapper, ASP.NET Core Identity, Serilog и Swagger

Данный проект представляет собой веб-приложение, разработанное с использованием технологий ASP.NET Core, Entity Framework Core, PostgreSQL, AutoMapper, ASP.NET Core Identity, Serilog и Swagger.

## Инструкция по запуску проекта

Перейдите в директорию :
##  cd \BI\BI.API.
Выполните миграцию с помощью следующей команды (в проекте уже есть миграция с конфигурациями):
## dotnet ef database update --context DatabaseContext

## Создание миграции
Перейдите в директорию 
## cd C:\BI
Создайте миграцию с помощью следующей команды:  
## dotnet ef migrations add Initial -p BI.Database --startup-project BI.API --context DatabaseContext


## Доступ к Swagger
Swagger-документация доступна по следующему адресу: 
## https://localhost:44379/swagger

Данные для аутентификации
Для доступа к API и аутентификации используйте следующие данные:

URL для входа: 
## https://localhost:44379/api/Account/login

JSON для аутентификации:

{
  "email": "user@bi.kz",
  "password": "Admin123!"
}

