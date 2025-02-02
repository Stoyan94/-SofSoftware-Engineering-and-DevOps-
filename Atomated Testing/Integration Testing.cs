📌 Обяснение на български: Интеграционно тестване
Интеграционното тестване проверява как отделните компоненти (модули) работят заедно. 
Дори ако всеки модул работи самостоятелно, когато ги комбинираме, могат да възникнат грешки.

📌 Основни характеристики на интеграционното тестване
Какво прави?	                    Описание	                                    Пример
Тества няколко компонента заедно	Проверява дали те взаимодействат правилно	    Уеб приложение, което изпраща заявка към база данни
Открива грешки в интеграцията	    Търси проблеми в комуникацията между модулите	API, което не връща очаквания отговор
Използва тестови "заместители"	    Използва стъбове (stubs) и мокове (mocks) за    Симулиране на отговор от база данни, когато реалната още не е готова
                                    симулиране на липсващи модули	                


📌 Методи за интеграционно тестване
Метод	             Как работи?	                                                                    Пример
Top-Down	         Тестовете започват от най-горното ниво на архитектурата и вървят надолу	        Първо тестваш UI, след това API, накрая базата данни
Bottom-Up	         Тестовете започват от най-ниското ниво (например базата данни) и се движат нагоре	Първо тестваш база данни, след това API, накрая UI
Хибриден (Sandwich)	 Комбинация от Top-Down и Bottom-Up                                                 Едновременно тестваш API и база данни, докато UI е все още в разработка
Big Bang	         Всички модули се тестват едновременно след завършване	                            Всички части на софтуера се сглобяват и тестват заедно накрая


📌 Малки примери за интеграционно тестване

1️⃣ Top-Down тест
📍 Пример: Тестваме мобилно приложение стъпка по стъпка от UI към сървъра.

Какво правим?
✔️ Кликваме бутон „Вход“
✔️ Проверяваме дали заявката се изпраща към API
✔️ Проверяваме дали API изпраща заявка към базата данни
✔️ Проверяваме дали базата данни връща правилния потребител


2️⃣ Bottom-Up тест
📍 Пример: Тестваме базата данни първо, после API, накрая UI.

Какво правим?
✔️ Създаваме тестови данни в базата
✔️ Проверяваме дали API ги връща правилно
✔️ Тестваме дали UI показва правилната информация


3️⃣ Hybrid тест
📍 Пример: Тестваме уеб приложение, като едновременно проверяваме API и базата.

Какво правим?
✔️ Проверяваме дали API връща правилни данни
✔️ Проверяваме дали базата данни ги записва коректно
✔️ Тестваме UI, когато е готов


4️⃣ Big Bang тест
📍 Пример: Тестваме цялата система наведнъж.

Какво правим?
✔️ Свързваме всички модули и ги тестваме заедно
✔️ Проверяваме дали API комуникира с базата
✔️ Проверяваме дали UI показва правилните данни



📌 Explanation in English: Integration Testing
Integration testing checks how individual components (modules) work together. 
Even if each module works independently, errors can appear when they are combined.

📌 Key Features of Integration Testing
What it does?	                    Description	                                         Example
Tests multiple components together	Ensures they communicate correctly	                 A web app sending a request to a database
Detects integration errors	        Finds issues in the interaction between modules	     An API returning the wrong response
Uses test substitutes	            Uses stubs and mocks to simulate missing components	 Simulating a database response before the real one is ready

📌 Integration Testing Approaches
Approach	        How it works?	                                                        Example
Top-Down	        Testing starts from the highest-level components and moves downward	    First test UI, then API, then database
Bottom-Up	        Testing starts from the lowest-level components and moves upward	    First test database, then API, then UI
Hybrid (Sandwich)	Combines Top-Down and Bottom-Up	                                        Test API and database at the same time while UI is still in development
Big Bang	        All components are tested together at once	                            The whole system is assembled and tested at the end


📌 Small Examples of Integration Testing
1️⃣ Top-Down Test
📍 Example: Testing a mobile app step by step from UI to server.

✔️ Click "Login" button
✔️ Check if the request is sent to API
✔️ Check if the API sends a request to the database
✔️ Check if the database returns the correct user


2️⃣ Bottom-Up Test
📍 Example: Testing the database first, then the API, and finally the UI.

✔️ Create test data in the database
✔️ Check if the API retrieves the correct data
✔️ Test if the UI displays the correct information


3️⃣ Hybrid Test
📍 Example: Testing a web app by checking API and database simultaneously.

✔️ Check if the API returns the correct data
✔️ Check if the database stores the data correctly
✔️ Test the UI when it becomes available


4️⃣ Big Bang Test
📍 Example: Testing the entire system at once.

✔️ Connect all modules and test them together
✔️ Verify that the API communicates with the database
✔️ Ensure the UI displays the correct information