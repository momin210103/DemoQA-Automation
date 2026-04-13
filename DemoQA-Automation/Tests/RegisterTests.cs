using DemoQA_Automation.Pages;
using FluentAssertions;
using Xunit.Abstractions;

namespace DemoQA_Automation.Tests;

public class RegisterTests(ITestOutputHelper output) : BaseTest
{
    private readonly ITestOutputHelper _output = output;

    [Fact]
    public void Valid_Register_Test()
    {
        // Arrange
        Driver.Navigate().GoToUrl("https://demoqa.com/register");
        var registerPage = new RegisterPage(Driver);
        // Act
        registerPage.Register_Successfully("Mom-in","sheikh","momin123","momin1234");
        
        //Assert
        var error = registerPage.GetCaptchaError();
        error.Should().Contain("reCaptcha");


    }
}