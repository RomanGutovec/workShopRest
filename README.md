Web api restful (including swagger)
---
* Создать REST сервис с использованием .NET Core Web API. Достаточно одного контроллера, например, [BoardGamesController](https://github.com/RomanGutovec/workShopRest/blob/master/BoardGamesApi/Controllers/BoardGamesController.cs).
* Сделать эндпоинты [Get и Post](https://github.com/RomanGutovec/workShopRest/blob/master/BoardGamesApi/Controllers/BoardGamesController.cs) 
для получения и добавления данных – например, AddBoardGame, GetBoardGameById, GetAllBoardGames и т.д.
Получение и добавление данных должно происходить через [DB сервис](https://github.com/RomanGutovec/workShopRest/blob/master/BoardGamesApi/Services/DbService.cs). 
Сервис должен инджектиться через DI контейнер.
* Добавить кэширование данных. Перед получением данных из базы проверить, существует ли запрашиваемый объект в кэше. Если да, вернуть его из кэша. Если нет – получить из базы и добавить в кэш.
* Добавить механизм кэширования через Middleware – можно использовать «из коробки» .net core response cache.
* Прикрутить Swagger definition с помощью Swashbuckle.
