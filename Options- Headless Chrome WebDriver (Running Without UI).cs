Headless Chrome WebDriver (без отваряне на графичния интерфейс на браузъра), 
трябва да добавиш ChromeOptions и да включиш --headless флага.


    [SetUp]
public void SetUp()
{
    ChromeOptions options = new ChromeOptions();
    options.AddArgument("--headless"); // Работи без UI
    options.AddArgument("--disable-gpu"); // Полезно за стабилност в някои случаи
    options.AddArgument("--window-size=1920,1080"); // Симулира голям екран, за да се избегнат проблеми с responsive UI

    driver = new ChromeDriver(options);
    js = (IJavaScriptExecutor)driver;
    vars = new Dictionary<string, object>();
}

Обяснение:
--headless → Стартира браузъра без UI.
    --disable-gpu → Понякога е необходимо за правилна работа в headless режим.
    --window-size=1920,1080 → Задава фиксиран размер на прозореца (нужно е, защото понякога headless работи с много малък прозорец по подразбиране).
    Това ще позволи тестовете да работят във фонов режим, без да отварят Chrome визуално. 🚀




Headless Chrome WebDriver (Running Without UI)
To run Chrome WebDriver in headless mode (without opening the browser UI), you need to configure ChromeOptions and enable the --headless flag.

    Example Code:

    [SetUp]
public void SetUp()
{
    ChromeOptions options = new ChromeOptions();
    options.AddArgument("--headless"); // Runs Chrome without UI
    options.AddArgument("--disable-gpu"); // Useful for stability in some cases
    options.AddArgument("--window-size=1920,1080"); // Simulates a large screen to avoid responsive UI issues

    driver = new ChromeDriver(options);
    js = (IJavaScriptExecutor)driver;
    vars = new Dictionary<string, object>();
}

Explanation:
--headless → Runs the browser without a UI.
    --disable-gpu → Sometimes required for proper functioning in headless mode.
    --window-size=1920,1080 → Sets a fixed window size (necessary because headless mode sometimes defaults to a very small viewport).
This setup allows your tests to run in the background without opening Chrome visually. 🚀