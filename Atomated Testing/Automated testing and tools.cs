📌 Защо автоматизираното тестване е важно?
Автоматизираното тестване е ключова част от софтуерната разработка, защото:
✅ Спестява време – тестовете могат да се изпълняват автоматично, вместо ръчно.
✅ Намалява грешките – хората могат да допуснат грешки, но автоматизираните тестове изпълняват задачите точно.
✅ Улеснява повторното тестване – след всяка промяна тестовете могат да се стартират автоматично, за да се уверим, че всичко работи.

📌 Нива на автоматизирано тестване
Ниво на тестване	    Какво проверява?	                                                    Пример
Unit тестове	        Тестват отделни функции или методи	                                    Проверяваме дали Sum(a, b) връща правилния резултат
Интеграционни тестове   Проверяват как работят различните компоненти заедно	                    Тест за взаимодействие между уеб приложение и база данни
UI тестове	            Симулират действия на потребителя (кликове, въвеждане на текст и т.н.)	Проверяваме дали бутон „Купи“ добавя продукт в количката


📌 Инструменти за автоматизирано тестване
Категория	                             Примери за инструменти	    Какво правят?
Фреймворкове за тестване	             JUnit, NUnit, Mocha	    Използват се за писане на unit тестове
Инструменти за автоматизирано тестване	 Selenium, Appium, Sikuli	Тестват UI, мобилни приложения и уебсайтове
Инструменти за API тестване	             Postman, REST Assured	    Проверяват дали API работи правилно


📌 Примери за автоматизирани тестове
1️⃣ Unit тест (C# - NUnit)
Тества дали функцията за събиране работи правилно.

[Test]
public void Sum_TwoNumbers_ReturnsCorrectResult()
{
    int result = Sum(2, 3);
    Assert.AreEqual(5, result);
}
✅ Този тест се изпълнява автоматично и проверява дали Sum(2,3) връща 5.


2️⃣ Интеграционен тест (C# - NUnit)
Проверява дали потребител се записва в базата.

[Test]
public void SaveUser_ShouldStoreDataInDatabase()
{
    User user = new User("Ivan", "ivan@example.com");
    SaveUser(user);

    User savedUser = database.GetUser("ivan@example.com");
    Assert.AreEqual("Ivan", savedUser.Name);
}
✅ Този тест проверява дали SaveUser() успешно записва данни в базата.


3️⃣ UI тест (Selenium - C#)
Симулира потребител, който кликва върху бутон.

[Test]
public void UserCanClickButton()
{
    var driver = new ChromeDriver();
    driver.Navigate().GoToUrl("https://example.com");
    driver.FindElement(By.Id("login-button")).Click();

    string pageTitle = driver.Title;
    Assert.AreEqual("Dashboard", pageTitle);

    driver.Quit();
}
✅ Този тест проверява дали след натискане на „Login“ потребителят попада в „Dashboard“.

📌 Видове автоматизирано тестване
Вид тестване	    Описание	                                Пример
Уеб тестване	    Проверява дали уебсайтът работи правилно	Selenium тест за бутони и форми
API тестване	    Тества дали API връща правилните резултати	Postman тест за REST API
Мобилно тестване	Тестване на мобилни приложения	            Appium тест за Android и iOS





Explanation in English:

📌 Why is test automation important?
Test automation is a key part of software development because:
✅ Saves time – Tests run automatically instead of manually.
✅ Reduces errors – Humans can make mistakes, but automated tests execute precisely.
✅ Makes retesting easier – After every change, tests can run automatically to ensure everything still works.

📌 Levels of Test Automation
Testing Level	                    What it Checks?	                    Example
Unit Tests	            Test individual functions or methods	        Checking if Sum(a, b) returns the correct result
Integration Tests	    Check how different components work together	Testing interaction between a web app and database
UI Tests	            Simulate user actions (clicks, typing, etc.)	Checking if the "Buy" button adds a product to the cart

📌 Test Automation Tools
Category	                Examples	                What they do?
Testing Frameworks	        JUnit, NUnit, Mocha	        Used for writing unit tests
Automated Testing Tools	    Selenium, Appium, Sikuli	Used for UI, mobile, and web testing
API Testing Tools	        Postman, REST Assured	    Verify if APIs work correctly

📌 Examples of Automated Tests

1️⃣ Unit Test (C# - NUnit)
Tests if an addition function works correctly.

[Test]
public void Sum_TwoNumbers_ReturnsCorrectResult()
{
    int result = Sum(2, 3);
    Assert.AreEqual(5, result);
}
✅ This test automatically checks if Sum(2,3) returns 5.

2️⃣ Integration Test (C# - NUnit)
Verifies if a user is saved in the database.

[Test]
public void SaveUser_ShouldStoreDataInDatabase()
{
    User user = new User("Ivan", "ivan@example.com");
    SaveUser(user);

    User savedUser = database.GetUser("ivan@example.com");
    Assert.AreEqual("Ivan", savedUser.Name);
}
✅ This test checks if SaveUser() successfully stores data in the database.

3️⃣ UI Test (Selenium - C#)
Simulates a user clicking a button.

[Test]
public void UserCanClickButton()
{
    var driver = new ChromeDriver();
    driver.Navigate().GoToUrl("https://example.com");
    driver.FindElement(By.Id("login-button")).Click();

    string pageTitle = driver.Title;
    Assert.AreEqual("Dashboard", pageTitle);

    driver.Quit();
}
✅ This test verifies that after clicking "Login," the user reaches the "Dashboard."

📌 Types of Automated Testing
Type	            Description             	            Example
Web Testing	        Ensures websites function properly	    Selenium test for buttons and forms
API Testing	        Tests if APIs return correct results	Postman test for REST API
Mobile Testing	    Tests mobile applications	            Appium test for Android & iOS
