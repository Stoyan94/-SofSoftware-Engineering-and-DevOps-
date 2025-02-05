Какво е REST услуга (REST Service)?
REST (Representational State Transfer) е архитектурен стил за изграждане на уеб услуги, който използва HTTP протокола за комуникация.
REST услугите са известни още като RESTful уеб услуги и са широко използвани при разработката на API-та (Application Programming Interfaces).

🔹 Основни принципи на REST:
Клиент - сървърна архитектура – клиентът (напр. браузър, мобилно приложение) изпраща заявки към сървъра, който връща отговори.
Без състояние (Stateless) – всяка заявка съдържа цялата необходима информация (няма сесии, както при SOAP).
Кеширане – отговорите могат да бъдат кеширани, за да се подобри производителността.
Унифициран интерфейс (Uniform Interface) – използват се стандартни HTTP методи.
Слойна архитектура (Layered System) – различните нива (сървър, база данни, кеш и т.н.) могат да бъдат разположени отделно.

🔹 HTTP методи в REST:
Метод Описание
GET	Извлича ресурс (напр. получаване на списък с потребители).
POST	Създава нов ресурс (напр. добавяне на нов потребител).
PUT	Актуализира съществуващ ресурс (цялостна промяна).
PATCH	Частично актуализира ресурс.
DELETE	Изтрива ресурс.


🔹 Пример за REST API заявка:
📌 Извличане на потребител с ID 5:

GET https://example.com/api/users/5
🔹 Отговор(JSON):


{
    "id": 5,
    "name": "Иван Петров",
    "email": "ivan@example.com"
}

🔹 Разлика между REST и SOAP:

Характеристика  REST	            SOAP
Протокол	    Използва HTTP	    Използва HTTP, SMTP, TCP
Формат	        JSON, XML, YAML	    Само XML
Леснота	        По-лек и бърз	    По-тежък и сложен
Използване	    Подходящ за уеб и 	Подходящ за корпоративни системи
                мобилни приложения
Състояние	    Без състояние	    Състояние (сесии)
Сигурност	    По-слаба	        По-силна

📌 Заключение:
REST е лек, гъвкав и бърз начин за изграждане на уеб услуги, който използва стандартните HTTP методи. 
Поддържа различни формати като JSON и XML, но най-често се използва JSON. REST API-та се прилагат широко в уеб и мобилните приложения, заради простотата и ефективността си.



Представи си REST като меню в ресторант.

Ти (клиентът) влизаш в ресторанта и искаш храна.
Официантът (REST API) приема твоята поръчка и я носи в кухнята (сървъра).
Готвачът (бекендът) приготвя ястието (данните) и официантът ти го донася обратно.

В този случай:

GET е като да попиташ какви ястия има в менюто.
POST е като да поръчаш ново ястие.
PUT е като да смениш гарнитурата на ястието си.
DELETE е като да върнеш ястието и да кажеш „махнете го от сметката“.
Всичко това става през интернет с помощта на HTTP заявки. 
А данните обикновено се връщат във формат JSON (нещо като дигитална касова бележка с информацията, която си поръчал).

Казано още по-просто – REST е начинът, по който приложенията си говорят помежду си.



ENGLISH

What is a REST Service?
REST (Representational State Transfer) is an architectural style for building web services that use the HTTP protocol for communication.
REST services are also known as RESTful web services and are widely used in the development of APIs (Application Programming Interfaces).

🔹 Key Principles of REST:
Client - Server Architecture – The client (e.g., browser, mobile app) sends requests to the server, which returns responses.
Stateless – Each request contains all the necessary information (no sessions, unlike SOAP).
Caching – Responses can be cached to improve performance.
Uniform Interface – Standard HTTP methods are used.
Layered System – Different layers (server, database, cache, etc.) can be deployed separately.

🔹 HTTP Methods in REST:
Method Description
GET	Retrieves a resource (e.g., fetching a list of users).
POST	Creates a new resource(e.g., adding a new user).
PUT Updates an existing resource (complete modification).
PATCH	Partially updates a resource.
DELETE	Deletes a resource.

🔹 Example of a REST API Request:

📌 Retrieving a User with ID 5:

GET https://example.com/api/users/5
🔹 Response(JSON):

{
    "id": 5,
    "name": "Ivan Petrov",
    "email": "ivan@example.com"
}

🔹 Difference Between REST and SOAP:
Feature     REST	            SOAP
Protocol	Uses HTTP	        Uses HTTP, SMTP, TCP
Format	    JSON, XML, YAML	    Only XML
Simplicity	Lightweight & fast	Heavier & complex
Use Case	Suitable for web & 	Suitable for enterprise systems
            mobile applications
State	    Stateless	        Stateful (sessions)
Security	Less secure	        More secure


📌 Conclusion:
REST is a lightweight, flexible, and fast way to build web services that use standard HTTP methods.
It supports multiple formats such as JSON and XML, but JSON is the most commonly used.
REST APIs are widely implemented in web and mobile applications due to their simplicity and efficiency.


Imagine REST as a Restaurant Menu:
You(the client) enter a restaurant and want to order food.
The waiter (REST API) takes your order and delivers it to the kitchen (server).
The chef (backend) prepares the meal (data), and the waiter brings it back to you.
In this case:

GET is like asking what dishes are available on the menu.
POST is like ordering a new dish.
PUT is like changing the side dish of your order.
DELETE is like returning the meal and asking for it to be removed from the bill.
Everything happens over the internet using HTTP requests.
The data is usually returned in JSON format (similar to a digital receipt with your order details).

To put it even more simply – REST is the way applications communicate with each other. 🚀