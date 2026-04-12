using DemoQA_Automation.Pages;

namespace DemoQA_Automation.Tests;

public class LoginTests : BaseTest
{
    [Fact]
    public void Valid_Login_Test()
    {
        Driver.Navigate().GoToUrl("https://demoqa.com/login");

        var loginPage = new LoginPage(Driver);
        loginPage.Login("testuser", "Password123!");

        //Driver.Url.Should().Contain("profile");
    }

    [Fact]
    public void NewUser_Test()
    {
        Driver.Navigate().GoToUrl("https://demoqa.com/login");
        var loginPage = new LoginPage(Driver);
        loginPage.NewUser();
    }
    
}