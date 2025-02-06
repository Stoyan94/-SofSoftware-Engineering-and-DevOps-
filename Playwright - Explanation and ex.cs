Playwright е мощна библиотека за автоматизирано тестване на уеб приложения, разработена от Microsoft. 
    Позволява ти да симулираш потребителски действия в браузъри като Chrome, Firefox и Edge.

Основни възможности на Playwright:
✅ Тества различни браузъри (Chromium, Firefox, WebKit)
✅ Поддържа няколко езици – JavaScript, Python, C#, Java
✅ Работи с табове, попъпи, iframes
✅ Поддържа мрежови заявки, дебъгване и правене на скрийншоти

Как да го инсталираш (за JavaScript/Node.js)?
Първо, трябва да имаш Node.js. Ако вече го имаш, просто инсталирай Playwright:


npm init -y   # Инициализира нов Node.js проект
npm install playwright  # Инсталира Playwright

След това можеш да инсталираш браузърите (по избор):

npx playwright install
Прост тест с Playwright (JavaScript)
Този код ще отвори Chromium, ще отиде в Google, ще търси „Playwright“ и ще направи скрийншот.

const { chromium } = require('playwright');

(async () => {
    // Стартира браузъра
    const browser = await chromium.launch({ headless: false }); // Ако искаш да виждаш браузъра, сложи false
    const page = await browser.newPage(); // Създава нова страница

    await page.goto('https://google.com'); // Отива в Google
    await page.fill('textarea[name="q"]', 'Playwright'); // Въвежда текст в търсачката
    await page.press('textarea[name="q"]', 'Enter'); // Натиска Enter
    await page.waitForTimeout(3000); // Изчаква резултатите

    await page.screenshot({ path: 'screenshot.png' }); // Прави скрийншот
    await browser.close(); // Затваря браузъра
})();

Как да стартираш кода?
1️⃣ Запази кода в файл, например test.js
2️⃣ В терминала изпълни:


node test.js
3️⃣ Ще видиш как браузърът отваря Google, търси и след 3 секунди прави скрийншот.

Това е само началото – с Playwright можеш да правиш сложни UI тестове, API заявки, дебъгване и още много! 🚀




1. Инсталиране на Playwright за C#
Първо, трябва да инсталираш Microsoft.Playwright с NuGet.

Ако използваш .NET CLI, изпълни:

dotnet add package Microsoft.Playwright

След това инсталирай браузърите:
playwright install
(Може да се наложи да изпълниш npx playwright install, ако има проблеми)

2. Примерен C# код с Playwright
Този код ще отвори браузъра, ще отиде в Google, ще търси „Playwright“ и ще направи скрийншот.

using System;
using System.Threading.Tasks;
using Microsoft.Playwright;

class Program
{
    public static async Task Main()
    {
        // Инициализиране на Playwright
        using var playwright = await Playwright.CreateAsync();

        // Стартиране на браузъра
        await using var browser = await playwright.Chromium.LaunchAsync(new BrowserTypeLaunchOptions
        {
            Headless = false // Ако искаш да виждаш браузъра, сложи false
        });

        // Отваряне на нова страница
        var page = await browser.NewPageAsync();

        // Отиване в Google
        await page.GotoAsync("https://google.com");

        // Въвеждане на "Playwright" в търсачката и натискане на Enter
        await page.FillAsync("textarea[name='q']", "Playwright");
        await page.PressAsync("textarea[name='q']", "Enter");

        // Изчакване на резултатите
        await page.WaitForTimeoutAsync(3000);

        // Правене на скрийншот
        await page.ScreenshotAsync(new PageScreenshotOptions { Path = "screenshot.png" });

        // Затваряне на браузъра
        await browser.CloseAsync();
    }
}

3.Как да стартираш кода?
1️⃣ Запази кода в .cs файл, например Program.cs.
2️⃣ Компилирай и изпълни:

dotnet run
3️⃣ Ще видиш как браузърът отваря Google, търси „Playwright“ и прави скрийншот.

Това е само основата! С Playwright в C# можеш да правиш пълноценни UI тестове, да записваш видеа на тестовете и да автоматизираш сложни процеси. 🚀




ENGLISH


Playwright - Powerful Web Automation Library
Playwright is a powerful library for automated testing of web applications, developed by Microsoft. 
It allows you to simulate user actions in browsers such as Chrome, Firefox, and Edge.

Key Features of Playwright:
✅ Supports multiple browsers (Chromium, Firefox, WebKit)
✅ Works with multiple languages – JavaScript, Python, C#, Java
✅ Handles tabs, pop-ups, and iframes
✅ Supports network requests, debugging, and screenshot capturing

How to Install Playwright (for JavaScript/Node.js)?
First, you need to have Node.js installed. If you already have it, simply install Playwright:


npm init -y   # Initializes a new Node.js project
npm install playwright  # Installs Playwright

Then, install the required browsers (optional):
npx playwright install


Basic Test with Playwright (JavaScript)
This code will open Chromium, navigate to Google, search for "Playwright," and take a screenshot.

const { chromium } = require('playwright');

(async () => {
// Launch the browser
const browser = await chromium.launch({ headless: false }); // Set to false to see the browser
const page = await browser.newPage(); // Create a new page

await page.goto('https://google.com'); // Navigate to Google
await page.fill('textarea[name="q"]', 'Playwright'); // Type in the search bar
await page.press('textarea[name="q"]', 'Enter'); // Press Enter
await page.waitForTimeout(3000); // Wait for results

await page.screenshot({ path: 'screenshot.png' }); // Take a screenshot
await browser.close(); // Close the browser
})();


How to Run the Code?
1️⃣ Save the code in a file, e.g., test.js

2️⃣ Run in the terminal:
node test.js


3️⃣ You'll see the browser opening Google, searching for "Playwright," and taking a screenshot after 3 seconds.

This is just the beginning – with Playwright, you can run advanced UI tests, API requests, debugging, and much more! 🚀

1. Installing Playwright for C#
First, you need to install Microsoft.Playwright via NuGet.

If you're using .NET CLI, run:
dotnet add package Microsoft.Playwright

Then install the required browsers:
playwright install

(If there are issues, try running npx playwright install)


2. Playwright Example Code in C#
This code will open a browser, navigate to Google, search for "Playwright," and take a screenshot.

using System;
using System.Threading.Tasks;
using Microsoft.Playwright;

class Program
{
    public static async Task Main()
    {
        // Initialize Playwright
        using var playwright = await Playwright.CreateAsync();

        // Launch the browser
        await using var browser = await playwright.Chromium.LaunchAsync(new BrowserTypeLaunchOptions
        {
            Headless = false // Set to false to see the browser
        });

        // Open a new page
        var page = await browser.NewPageAsync();

        // Navigate to Google
        await page.GotoAsync("https://google.com");

        // Type "Playwright" in the search bar and press Enter
        await page.FillAsync("textarea[name='q']", "Playwright");
        await page.PressAsync("textarea[name='q']", "Enter");

        // Wait for results
        await page.WaitForTimeoutAsync(3000);

        // Take a screenshot
        await page.ScreenshotAsync(new PageScreenshotOptions { Path = "screenshot.png" });

        // Close the browser
        await browser.CloseAsync();
    }
}

3.How to Run the Code?
1️⃣ Save the code in a .cs file, e.g., Program.cs.
2️⃣ Compile and run it:

dotnet run

3️⃣ You'll see the browser opening Google, searching for "Playwright," and taking a screenshot.

This is just the foundation! With Playwright in C#, you can perform full UI tests, record test videos, and automate complex workflows. 🚀