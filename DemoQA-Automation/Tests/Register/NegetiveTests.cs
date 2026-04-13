using DemoQA_Automation.Pages;
using FluentAssertions;

namespace DemoQA_Automation.Tests.Register;

public class NegetiveTests : BaseTest
{
    [Fact]
    public void Register_With_Empty_Fields_Show_Error()
    {
        // Arrange
        Driver.Navigate().GoToUrl("https://demoqa.com/register");
        var register = new RegisterPage(Driver);
        // Act
        register.Register_Successfully("","", "","");
        // Assert
        var error = register.GetErrorMessage();
        error.ToLower().Should().Contain("required!");
    }
    
}