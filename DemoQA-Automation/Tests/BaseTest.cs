using DemoQA_Automation.Drivers;
using OpenQA.Selenium;

namespace DemoQA_Automation.Tests;

public class BaseTest : IDisposable
{
    protected readonly IWebDriver Driver;

    protected BaseTest()
    {
        Driver = WebDriverFactory.Create();
    }

    public void Dispose()
    {
        //Driver.Quit();
    }
}