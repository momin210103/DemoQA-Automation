using OpenQA.Selenium;

namespace DemoQA_Automation.Pages;

public class LoginPage(IWebDriver driver) : BasePage(driver)
{
    private readonly By _username = By.Id("userName");
    private readonly By _password = By.Id("password");
    private readonly By _loginBtn = By.Id("login");
    private readonly By _newUserBtn = By.Id("newUser");
    private readonly IWebDriver _driver1 = driver;

    public void Login(string user, string pass)
    {
        Type(_username, user);
        Type(_password, pass);
        Click(_loginBtn);
    }

    public void NewUser()
    {
        Click(_newUserBtn);
    }
    public void EnterUsername(string username)
    {
        Type(_username, username);
    }

    public string? GetUsernameValue()
    {
        return _driver1.FindElement(_username).GetAttribute("Value");
    }
}