using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace DemoQA_Automation.Drivers;

public static class WebDriverFactory
{
    public static IWebDriver Create()
    {
        var options = new ChromeOptions();
        options.AddArguments();
        return new ChromeDriver(options);
    }
}