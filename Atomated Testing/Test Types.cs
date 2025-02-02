Софтуерното тестване се разделя на различни видове в зависимост от това какво проверяваме.

1️⃣ Функционални (Functional) vs. Нефункционални (Non-functional) тестове
✅ Функционални тестове проверяват дали софтуерът прави това, което трябва. Тестват конкретни функции спрямо изискванията.
🔹 Пример: Тестваш дали потребител може да се логне със своето име и парола.


✅ Нефункционални тестове проверяват как работи системата – скорост, сигурност, удобство и др.
🔹 Пример: Проверяваш колко време отнема зареждането на страницата при голям трафик.


2️⃣ Черна кутия (Black-box) vs. Бяла кутия (White-box) тестове
✅ Black-box тестове – тестерът не вижда вътрешния код, а тества поведението на системата от гледна точка на потребителя.
🔹 Пример: Натискаш бутон „Регистрация“ и проверяваш дали се появява съобщение „Успешно“.


✅ White-box тестове – тестерът има достъп до кода и проверява как работи логиката отвътре.
🔹 Пример: Програмистът прави unit тест, за да провери дали дадена функция връща правилния резултат.


3️⃣ Регресионни тестове (Regression tests)
✅ Проверяват дали новите промени не са счупили нещо старо.
🔹 Пример: Добавяш нов бутон в приложението, но след това проверяваш дали всички други бутони още работят правилно.


4️⃣ Стрес тестове, тестове за натоварване, UX & Usability тестове, Security тестове
✅ Стрес тестове – проверяват как системата се държи при екстремно натоварване.
🔹 Пример: Проверяваш дали сайтът ще работи, ако 10 000 души се опитат да го отворят едновременно.


✅ Тестове за натоварване (Load tests) – измерват колко добре системата се справя при нормално голям трафик.
🔹 Пример: Тестване дали сървърът може да обработи 500 заявки в секунда.


✅ UX & Usability тестове – проверяват дали сайтът е удобен и лесен за ползване.
🔹 Пример: Група потребители използват приложението и дават обратна връзка кое им е трудно.


✅ Security тестове – проверяват колко сигурна е системата срещу атаки.
🔹 Пример: Опитваш се да влезеш в профил без парола, за да провериш дали сайтът е уязвим.


5️⃣ Ръчни (Manual) vs. Автоматизирани (Automated) тестове
✅ Ръчни тестове – извършват се от човек, който тества ръчно функционалността.
🔹 Пример: Тестер кликва бутони и проверява дали всичко работи.


✅ Автоматизирани тестове – софтуер изпълнява тестовете автоматично чрез скриптове.
🔹 Пример: Selenium тества дали бутоните на уебсайт работят правилно.





    Explanation in English:
Software testing is divided into different types based on what we are verifying.

1️⃣ Functional vs. Non-functional tests
✅ Functional tests check if the software does what it is supposed to do. They test specific features against requirements.
🔹 Example: Testing if a user can log in with a username and password.


✅ Non-functional tests check how the system works – speed, security, usability, etc.
🔹 Example: Checking how long a page takes to load under heavy traffic.


2️⃣ Black-box vs. White-box tests
✅ Black-box tests – the tester does not see the internal code but tests the system's behavior from a user’s perspective.
🔹 Example: Clicking the "Register" button and checking if the message "Success" appears.


✅ White-box tests – the tester has access to the code and checks how the internal logic works.
🔹 Example: A developer writes a unit test to verify if a function returns the correct result.


3️⃣ Regression tests
✅ Check if new changes haven’t broken old functionality.
🔹 Example: You add a new button to the app, but then check if all other buttons still work properly.


4️⃣ Stress tests, Load tests, UX & Usability tests, Security tests
✅ Stress tests – check how the system behaves under extreme load.
🔹 Example: Testing if the website crashes when 10,000 people try to access it at once.


✅ Load tests – measure how well the system handles normal heavy traffic.
🔹 Example: Testing if the server can handle 500 requests per second.


✅ UX & Usability tests – check if the website is easy and convenient to use.
🔹 Example: A group of users test the app and provide feedback on what is confusing.


✅ Security tests – check how secure the system is against attacks.
🔹 Example: Trying to log in without a password to check if the site is vulnerable.


5️⃣ Manual vs. Automated tests
✅ Manual tests – performed by a person who manually verifies the functionality.
🔹 Example: A tester clicks buttons and checks if everything works.


✅ Automated tests – tests are executed automatically using scripts.
🔹 Example: Selenium tests if website buttons work correctly.