📌 Автоматизирано тестване на Web UI

🔹 Какво е тестване на Web UI?
Тестването на Web UI се фокусира върху тестовете на компонентите, с които потребителите взаимодействат. 
Целта е да се уверим, че уеб приложението отговаря на следните изисквания:

📌 Проверка на / Verification of  📌 Проверява се / Ensures
✅ Потребителско изживяване	       UI е първата точка на контакт за потребителите с приложението
✅ Функционалност	               Осигурява, че всички визуални компоненти работят както се очаква
✅ Съвместимост	                   Проверява дали всички устройства правилно показват уеб приложението
✅ Производителност	               Тества как UI се представя при различни условия

🔹 Видове тестове за Web UI
🏷️ Вид / Type	                            🔍 Описание / Description
✅ Функционални тестове                     Проверява дали всеки елемент на UI работи както трябва при взаимодействие с него
✅ Тестове за съвместимост между браузъри	Проверява дали UI правилно се визуализира в различни браузъри
✅ Отзивчиво тестване	                    Осигурява, че UI се адаптира правилно към различни размери на екрана
✅ Тестове за достъпност	                Тестване на достъпността на UI за хора с увреждания
✅ Визуални регресионни тестове          	Проверява за визуални разлики в UI при промени в кода


🔹 Playwright
Playwright е широко използвана Node.js библиотека за end-to-end тестове на уеб приложения. 
Тя позволява автоматизиране на задачи в браузъра и поддържа всички модерни браузъри.

Ключови характеристики:

Автоматизиране на браузър задачи: Автоматизира попълване на форми, взаимодействия с UI, въвеждане от клавиатурата и др.
Поддръжка на всички модерни браузъри.
Режим без UI: Изпълнява тестове без UI за по-бързо изпълнение.
Тестване на сложни UI: Поддържа тестване на динамични и сложни потребителски интерфейси.

Пример с код на JavaScript (Playwright):

const { test, expect } = require('@playwright/test');

test('тест, че UI се визуализира правилно', async({ page }) => {
    await page.goto('https://example.com');
    const title = await page.title();
    expect(title).toBe('Example Domain');
});


🔹 Обзор на Selenium Family
Selenium е набор от инструменти за автоматизиране на браузъри. 
Той е широко използван за крос-браузър тестване и автоматизиране на взаимодействия с браузъри.

Инструменти в семейството на Selenium:

Selenium IDE: Позволява записване и възпроизвеждане на тестове.
Selenium WebDriver: Автоматизира задачи в браузърите с различни програмни езици.
Selenium Grid: Позволява паралелно тестване на различни машини.



На английски:

📌 Web UI Test Automation
🔹 What is Web UI Testing?
Web UI testing focuses on testing the components with which users interact. It aims to ensure that the web application meets the following requirements:

📌 Verification of	📌 Ensures
✅ User Experience	UI is the first point of contact with the app for users
✅ Functionality	Ensures all visual components work as expected
✅ Compatibility	Checks whether all devices display the web app correctly
✅ Performance	    Tests how UI performs under different conditions


🔹 Types of Web UI Tests
🏷️ Type	                        🔍 Description
✅ Functional Testing	        Ensures that each element on the UI works as expected when interacted with
✅ Cross-Browser Testing	    Validates that the UI renders and functions correctly across different browsers
✅ Responsive Testing	        Ensures UI adapts correctly to various screen sizes
✅ Accessibility Testing	    Tests the UI accessibility for users with disabilities
✅ Visual Regression Testing	Tests for visual differences in the UI when code changes occur


🔹 Playwright
Playwright is a widely used Node.js library for end-to-end testing of web applications. 
    It allows automating browser tasks and supports all modern browsers.

Key Features:

Automation of browser tasks: Automates form submissions, UI interactions, keyboard input, etc.
Cross-browser support: Supports all modern browsers.
Headless mode: Runs tests without UI for faster execution.
Complex UI testing: Supports testing of dynamic, complex UI elements.

Code Example in JavaScript (Playwright):

const { test, expect } = require('@playwright/test');

test('test that UI renders correctly', async({ page }) => {
    await page.goto('https://example.com');
    const title = await page.title();
    expect(title).toBe('Example Domain');
});


🔹 Overview of Selenium Family
Selenium is a suite of tools for automating web browsers. 
It is widely used for cross-browser testing and automating interactions with browsers.

Selenium Tools:
Selenium IDE: Allows for recording and playing back tests.
Selenium WebDriver: Automates browser tasks using different programming languages.
Selenium Grid: Enables parallel testing across multiple machines.
