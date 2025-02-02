📌 API Testing – Тестване на API
🔹 Какво представлява API тестването?
API тестването включва проверка на API-та директно или като част от интеграционното тестване. 
    То е критично за:

📌 Проверка на	                📌 Проверява се
✅ Бизнес логика	            Дали API-то работи според бизнес изискванията
✅ Взаимодействие между услуги	Как комуникират различните системи
✅ Микросървиси	                Проверка на отделните микросървиси
✅ Външни API-та	            Тестване на интеграция с трети страни


🔹 Основни цели на API тестването

📌 Цел	                📌 Описание
✅ Функционалност	    Проверява заявки, отговори, грешки
✅ Надеждност	        Тестове за стабилна връзка
✅ Производителност	    Проверява време за отговор при различни условия
✅ Сигурност	        Тестване на автентикация, права за достъп


🔹 Видове API тестове
🏷️ Вид	                                            🔍 Описание
✅ Функционални тестове	                            Дали API-то работи според очакванията
✅ Нагрузочно и производителностно тестване	Как     API-то се държи под натоварване
✅ Сигурностно тестване                          	Дали API-то е защитено от атаки
✅ Негативно тестване	                            Проверява как API-то се справя с грешни входни данни

🔹 Предимства на API тестването
✅ Предимство	                    🔍 Описание
🐞 Ранно откриване на бъгове	    Откриване на проблеми на ниво бизнес логика
🔄 Лесна интеграция	                Компонентите комуникират гладко
🎯 Подобрен обхват на тестовете	    По-добро покритие в сравнение с UI тестовете
⚡ По-бързо тестване	            Не зависи от потребителския интерфейс
🌍 Независим от езика	            Използва JSON/XML и HTTP заявки
🔐 Подобрена сигурност	            API тестовете гарантират защита на данните
🚀 Подходящо за Agile и CI/CD	    Автоматизирано тестване в DevOps процеси


🔹 Инструменти за API тестване
🛠️ Инструмент	        📌 Описание
🏆 Postman	            Ръчно и автоматизирано тестване на API
📜 Swagger / OpenAPI	Генериране на документация и тестове
🔬 RestAssured	        API тестване с Java
⚡ Newman	            CLI инструмент за изпълнение на Postman тестове в CI/CD


🔹 Примери с код
📍 Пример за API заявка с Postman (JavaScript)
Заявка към публично API с fetch()

🔹 JavaScript:

fetch('https://jsonplaceholder.typicode.com/posts/1')
  .then(response => response.json())
  .then(data => console.log(data))
  .catch(error => console.error('Error:', error));

🔹 Отговор:
{
  "userId": 1,
  "id": 1,
  "title": "Test Title",
  "body": "This is a test post."
}


📍 API тест с RestAssured (Java)
🔹 Java (RestAssured + JUnit)

import io.restassured.RestAssured;
import io.restassured.response.Response;
import org.junit.jupiter.api.Test;

import static org.junit.jupiter.api.Assertions.assertEquals;

public class ApiTest
{
    @Test
    public void testGetRequest()
    {
        Response response = RestAssured.get("https://jsonplaceholder.typicode.com/posts/1");
        assertEquals(200, response.getStatusCode());
    }
}


📍 Автоматизирано тестване с Newman (Postman CLI)
Изпълнение на Postman тестове в CI/CD

newman run my_collection.json


📌 Заключение
API тестването е критична част от осигуряването на качеството на софтуера. 
Чрез автоматизиране и използване на мощни инструменти като Postman, RestAssured и Newman можем да осигурим по-бързи, по-ефективни и по-сигурни системи. 🚀




ENGLISH

 API Testing
🔹 What is API Testing?
API testing involves verifying APIs directly or as part of integration testing. 
It is crucial for:

📌 Verification of	            📌 Ensures
✅ Business logic            	Whether the API works as expected
✅ Service interactions	        How different systems communicate
✅ Microservices	            Testing individual microservices
✅ Third-party APIs	Verifying   integration with external services


🔹 Key Goals of API Testing
📌 Goal	            📌 Description
✅ Functionality	Checks requests, responses, endpoints, error codes
✅ Reliability	    Tests stable connection
✅ Performance	    Measures response time under various conditions
✅ Security	        Tests authentication, permissions, access control

🔹 Types of API Tests
🏷️ Type	🔍 Description
✅ Functional Testing	Ensures API works as expected
✅ Load & Performance Testing	Checks API under high traffic
✅ Security Testing	Ensures API is protected from attacks
✅ Negative Testing	Tests invalid inputs and errors


🔹 Advantages of API Testing
✅ Advantage	            🔍 Description
🐞 Early bug detection	    Finds issues at the business logic level
🔄 Easy integration	        Ensures smooth communication between components
🎯 Better test coverage	    Higher coverage compared to UI tests
⚡ Faster testing	        Does not depend on UI
🌍 Language-independent  	Uses JSON/XML and HTTP requests
🔐 Enhanced security	    Ensures data protection
🚀 Supports Agile & CI/CD	Automated testing in DevOps pipelines

🔹 Tools for API Testing
🛠️ Tool	                📌 Description
🏆 Postman	            Used for manual and automated API testing
📜 Swagger / OpenAPI	Generates documentation and tests
🔬 RestAssured	        API testing with Java
⚡ Newman	            CLI tool for running Postman tests in CI/CD


🔹 Code Examples

📍 API Request with Postman (JavaScript)
Request to a public API using fetch()

fetch('https://jsonplaceholder.typicode.com/posts/1')
  .then(response => response.json())
  .then(data => console.log(data))
  .catch(error => console.error('Error:', error));
Response

{
  "userId": 1,
  "id": 1,
  "title": "Test Title",
  "body": "This is a test post."
}


📍 API Test with RestAssured (Java)
Java (RestAssured + JUnit):

import io.restassured.RestAssured;
import io.restassured.response.Response;
import org.junit.jupiter.api.Test;

import static org.junit.jupiter.api.Assertions.assertEquals;

public class ApiTest
{
    @Test
    public void testGetRequest()
    {
        Response response = RestAssured.get("https://jsonplaceholder.typicode.com/posts/1");
        assertEquals(200, response.getStatusCode());
    }
}


📍 Automated API Testing with Newman (Postman CLI)
Running Postman tests in CI/CD pipeline

newman run my_collection.json


📌 Conclusion
API testing is essential for ensuring software quality. 
    By automating tests and using powerful tools like Postman, RestAssured, and Newman, 
    we can ensure faster, more efficient, and more secure systems. 🚀