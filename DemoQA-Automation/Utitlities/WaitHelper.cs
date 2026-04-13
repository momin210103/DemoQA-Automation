using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace DemoQA_Automation.Utitlities;

public static class WaitHelper
{
    public static IWebElement WaitForElement(IWebDriver driver, By by)
    {
        WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(5));
        return wait.Until(d => d.FindElement(by));
    }
    
}