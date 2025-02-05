Selenium IDE е инструмент за автоматизирано тестване на уебсайтове. 
Той представлява разширение за браузър (Chrome/Firefox), което ти позволява да записваш действията си в браузъра (като щракания, 
въвеждане на текст и навигация) и след това да ги изпълняваш автоматично.

Как работи Selenium IDE?
Записване на тест – Отваряш Selenium IDE, започваш запис и извършваш действията си в браузъра.
Редактиране на теста – Можеш да коригираш или разшириш теста с команди.
Изпълнение на теста – Когато стартираш теста, Selenium IDE ще повтори стъпките автоматично.
Примерен код (Selenium WebDriver в C#)
Ако искаш по-гъвкав контрол, можеш да използваш Selenium WebDriver в C#. 
Той ти позволява да пишеш тестове с код вместо да разчиташ на записване.

1️⃣ Инсталирай Selenium WebDriver:
Добави NuGet пакетите:

Selenium.WebDriver
Selenium.WebDriver.ChromeDriver

2️⃣ Примерен код:

using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Threading;

class Program
{
    static void Main()
    {
        // Стартиране на Chrome браузъра
        IWebDriver driver = new ChromeDriver();

        // Отваряне на сайт
        driver.Navigate().GoToUrl("https://google.com");

        // Намиране на полето за търсене и въвеждане на текст
        IWebElement searchBox = driver.FindElement(By.Name("q"));
        searchBox.SendKeys("Selenium WebDriver C# пример");

        // Натискане на Enter
        searchBox.SendKeys(Keys.Enter);

        // Изчакване на резултатите (не се препоръчва, но е за демонстрация)
        Thread.Sleep(3000);

        // Затваряне на браузъра
        driver.Quit();
    }
}

Обяснение:
ChromeDriver – стартира Chrome браузъра.
Navigate().GoToUrl() – отваря уеб страница.
FindElement(By.Name("q")) – намира полето за търсене.
SendKeys("Selenium WebDriver C# пример") – въвежда текст.
SendKeys(Keys.Enter) – натиска Enter.
Thread.Sleep(3000) – изчаква 3 секунди (за да видиш резултатите).
Quit() – затваря браузъра.

Ако искаш да използваш само Selenium IDE (без код), можеш да си го инсталираш като разширение в браузъра и да записваш тестовете си директно.


ENGLISH:

Selenium IDE – Automated Website Testing Tool
Selenium IDE is a tool for automated website testing.
It is a browser extension (Chrome/Firefox) that allows you to record your actions in the browser (such as clicks, text input, and navigation) and then replay them automatically.

How does Selenium IDE work?
Recording a test – Open Selenium IDE, start recording, and perform actions in the browser.
Editing the test – You can modify or extend the test with commands.
Running the test – When you run the test, Selenium IDE will repeat the recorded steps automatically.
Example Code (Selenium WebDriver in C#)
If you need more flexibility, you can use Selenium WebDriver in C#.
It allows you to write tests with code instead of relying on recording.

1️⃣ Install Selenium WebDriver:
Add the following NuGet packages:

Selenium.WebDriver
Selenium.WebDriver.ChromeDriver


2️⃣ Example Code:

using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Threading;

class Program
{
    static void Main()
    {
        // Start Chrome browser
        IWebDriver driver = new ChromeDriver();

        // Open a website
        driver.Navigate().GoToUrl("https://google.com");

        // Find the search box and enter text
        IWebElement searchBox = driver.FindElement(By.Name("q"));
        searchBox.SendKeys("Selenium WebDriver C# example");

        // Press Enter
        searchBox.SendKeys(Keys.Enter);

        // Wait for results (not recommended, but for demonstration)
        Thread.Sleep(3000);

        // Close the browser
        driver.Quit();
    }
}

Explanation:
ChromeDriver – Starts the Chrome browser.
Navigate().GoToUrl() – Opens a web page.
FindElement(By.Name("q")) – Finds the search input field.
SendKeys("Selenium WebDriver C# example") – Enters text.
SendKeys(Keys.Enter) – Presses Enter.
Thread.Sleep(3000) – Waits 3 seconds (to see the results).
Quit() – Closes the browser.


If you want to use only Selenium IDE (without writing code), you can install it as a browser extension and record your tests directly.