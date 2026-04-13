using DemoQA_Automation.Pages;
using FluentAssertions;
using Xunit.Abstractions;

namespace DemoQA_Automation.Tests;

public class LoginTests : BaseTest
{
    private readonly ITestOutputHelper _testOutputHelper;

    public LoginTests(ITestOutputHelper testOutputHelper)
    {
        _testOutputHelper = testOutputHelper;
    }

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

    [Fact]
    public void Username_Should_Be_Set_Correctly()
    {
        // Arrange
        Driver.Navigate().GoToUrl("https://demoqa.com/login");
        var login = new LoginPage(Driver);

        // Act
        login.EnterUsername("momin123");

        // Assert
        var actual = login.GetUsernameValue();

        //Assert.Equal("momin123", actual);
        // Fluent Assertions
        actual.Should().Be("momin123");
        _testOutputHelper.WriteLine($"Actual value: {actual}");
    }
}