Различните видове тестове в софтуерното инженерство помагат да се гарантира, че кодът работи правилно. 
Ето какво представляват:

1️⃣ Unit тестове(Тестове на отделен компонент)
✅ Тестват най-малките части на кода (обикновено една функция или метод).
✅ Изпълняват се бързо и помагат на програмистите да намерят грешки рано.
✅ Обикновено не включват взаимодействие с база данни, мрежа или други услуги.

📌 Пример:
Представи си, че пишеш калкулатор. 
Имаш функция за събиране:

public int Sum(int a, int b)
{
    return a + b;
}
За да провериш дали работи правилно, можеш да създадеш unit тест:


[Test]
public void Sum_TwoNumbers_ReturnsCorrectResult()
{
    int result = Sum(2, 3);
    Assert.AreEqual(5, result);
}
🔹 Ако тестът мине успешно – значи функцията работи.
🔹 Ако не – значи трябва да провериш кода си.


2️⃣ Интеграционни тестове
✅ Тестват взаимодействието между различни части на кода (например как една функция работи с база данни или API).
✅ Тестват реални сценарии, но са по-бавни от unit тестовете.

📌 Пример:
Имаш уеб приложение, което записва потребители в база данни.

Функция за записване:

public void SaveUser(User user)
{
    database.Save(user);
}
Тест за интеграция:
Той проверява дали, когато извикаме SaveUser(), 
    данните наистина се записват в базата.

[Test]
public void SaveUser_ShouldStoreDataInDatabase()
{
    User user = new User("Ivan", "ivan@example.com");
    SaveUser(user);

    User savedUser = database.GetUser("ivan@example.com");
    Assert.AreEqual("Ivan", savedUser.Name);
}
🔹 Тук тестът проверява дали потребителят наистина е записан в базата.


3️⃣ Системни тестове (End-to-End, E2E)
✅ Тестват цялата система, сякаш я използва истински потребител.
✅ Обикновено се изпълняват автоматично чрез софтуер като Selenium, Cypress и др.

📌 Пример:
Тестваш онлайн магазин. 
    Процесът е следният:

1️⃣ Потребител влиза в сайта.
2️⃣ Добавя продукт в количката.
3️⃣ Отива на страницата за плащане.
4️⃣ Завършва поръчката.

Можем да автоматизираме този тест със Selenium:

[Test]
public void UserCanCompletePurchase()
{
    var driver = new ChromeDriver();

    driver.Navigate().GoToUrl("https://myshop.com");
    driver.FindElement(By.Id("product-123")).Click();
    driver.FindElement(By.Id("add-to-cart")).Click();
    driver.FindElement(By.Id("checkout")).Click();
    driver.FindElement(By.Id("confirm")).Click();

    string confirmationMessage = driver.FindElement(By.Id("success-message")).Text;
    Assert.AreEqual("Thank you for your order!", confirmationMessage);

    driver.Quit();
}
🔹 Този тест проверява дали поръчката може да бъде завършена правилно.

Обобщение:

Вид тест	            Какво тества?	                             Пример
Unit тест	            Отделен метод или функция	                 Дали Sum(a, b) връща правилния резултат
Интеграционен тест	    Как работят няколко компонента заедно	     Дали SaveUser() записва потребител в база данни
Системен тест (E2E)	    Целия процес от гледна точка на потребителя	 Дали клиент може да купи продукт в онлайн магазин






Explanation in English:
Different types of software tests ensure that code works correctly. Here’s how they work:

1️⃣ Unit tests
✅ Test the smallest part of the code (usually a single function or method).
✅ They run quickly and help developers find errors early.
✅ They usually don’t interact with databases, networks, or other services.

📌 Example:
Imagine you are building a calculator. 
    You have an addition function:

public int Sum(int a, int b)
{
    return a + b;
}
To check if it works correctly, you create a unit test:


[Test]
public void Sum_TwoNumbers_ReturnsCorrectResult()
{
    int result = Sum(2, 3);
    Assert.AreEqual(5, result);
}
🔹 If the test passes – the function is correct.
🔹 If it fails – you need to fix the code.



2️⃣ Integration tests
✅ Test how different parts of the code work together (e.g., a function interacting with a database or API).
✅ Test real-world scenarios but are slower than unit tests.

📌 Example:
You have a web app that saves users to a database.

Function to save a user:

public void SaveUser(User user)
{
    database.Save(user);
}
Integration test:
Checks if calling SaveUser() actually stores the user in the database.

[Test]
public void SaveUser_ShouldStoreDataInDatabase()
{
    User user = new User("Ivan", "ivan@example.com");
    SaveUser(user);

    User savedUser = database.GetUser("ivan@example.com");
    Assert.AreEqual("Ivan", savedUser.Name);
}
🔹 Here, the test ensures the user is properly stored in the database.



3️⃣ System tests (End-to-End, E2E)
✅ Test the entire system, as if used by a real user.
✅ Usually automated using tools like Selenium, Cypress, etc.

📌 Example:
Testing an online store. The process:

1️⃣ User visits the website.
2️⃣ Adds a product to the cart.
3️⃣ Goes to checkout.
4️⃣ Completes the purchase.

We can automate this with Selenium:

[Test]
public void UserCanCompletePurchase()
{
    var driver = new ChromeDriver();

    driver.Navigate().GoToUrl("https://myshop.com");
    driver.FindElement(By.Id("product-123")).Click();
    driver.FindElement(By.Id("add-to-cart")).Click();
    driver.FindElement(By.Id("checkout")).Click();
    driver.FindElement(By.Id("confirm")).Click();

    string confirmationMessage = driver.FindElement(By.Id("success-message")).Text;
    Assert.AreEqual("Thank you for your order!", confirmationMessage);

    driver.Quit();
}
🔹 This test verifies that a customer can successfully place an order.

Summary:
Test Type	        What it Tests?	                             Example
Unit Test	        A single function or method	                 Checking if Sum(a, b) returns the correct result
Integration Test	How multiple components interact	         Checking if SaveUser() stores a user in the database
System Test (E2E)	The entire system from a user’s perspective  Ensuring a customer can complete a purchase in an online store