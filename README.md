#Инструкция по запуску проекта

#команда для создание миграции
dotnet ef migrations add Initral  -p BI.Database --startup-project BI.API --context DatabaseContext


#Команда для выполнения миграции (в проекте уже есть миграция с конфинурациями)
dotnet ef database update --context DatabaseContext
