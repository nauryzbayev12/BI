# Проект: Управление проектарми

Данный проект представляет собой веб-приложение, разработанное с использованием технологий ASP.NET Core, Entity Framework Core, PostgreSQL, AutoMapper, ASP.NET Core Identity, Serilog и Swagger.

## Инструкция по запуску проекта

Первое скачайте проект

Перейдите в директорию :
cd \BI\BI.API.
Выполните миграцию с помощью следующей команды (в проекте уже есть миграция с конфигурациями):
dotnet ef database update --context DatabaseContext

## Доступ к Swagger
Swagger-документация доступна по следующему адресу: 
https://localhost:44379/swagger

Данные для аутентификации
Для доступа к API и аутентификации используйте следующие данные:

URL для входа: 
https://localhost:44379/api/Account/login

JSON для аутентификации:

{
  "email": "user@bi.kz",
  "password": "Admin123!"
}


![Снимок экрана (1908)](https://github.com/nauryzbayev12/BI/assets/128095819/d1d3fb61-8553-416e-b596-58872ed92ffc)

## Пример использование токена (Не забываем писать bearer) :
Bearer eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJodHRwOi8vc2NoZW1hcy54bWxzb2FwLm9yZy93cy8yMDA1L

![Uploading Снимок экрана (1909).png…]()




## Создание миграции
Перейдите в директорию 
cd C:\BI
Создайте миграцию с помощью следующей команды:  
dotnet ef migrations add Initial -p BI.Database --startup-project BI.API --context DatabaseContext
