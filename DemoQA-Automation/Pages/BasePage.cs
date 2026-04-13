

using OpenQA.Selenium;

namespace DemoQA_Automation.Pages;

public class BasePage
{
    private readonly IWebDriver _driver;

    protected BasePage(IWebDriver driver)
    {
        _driver = driver;
        
    }

    protected void Click(By by)
    {
        _driver.FindElement(by).Click();

    }
    protected void Type(By by, string text)
    {
        var element = _driver.FindElement(by);
        element.Clear();
        element.SendKeys(text);
    }
}