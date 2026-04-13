using OpenQA.Selenium;
using Xunit.Abstractions;

namespace DemoQA_Automation.Pages;

public class RegisterPage(IWebDriver driver) : BasePage(driver)
{
    private readonly By _firstName = By.Id("firstname");
    private readonly By _lastName = By.Id("lastname");
    private readonly By _userName = By.Id("userName");
    private readonly By _password = By.Id("password");
    private readonly By _register = By.Id("register");

    public void Register_Successfully(string firstname, string lastname,string username,string password)
    {
        Type(_firstName,firstname);
        Type(_lastName, lastname);
        Type(_userName, username);
        Type(_password, password);
        Click(_register);
    }

    public string GetCaptchaError()
    {
        return driver.FindElement(By.XPath("//*[contains(text(),'reCaptcha')]")).Text;
    }


}