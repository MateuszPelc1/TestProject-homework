using LoginPageTests.PageObjects;
using System;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace LoginPageTests.StepDefinitions;

[Binding]
public class LoginSteps
{
    private readonly LoginPage _loginPageObject;

    public LoginSteps(LoginPage loginPageObject)
    {
        _loginPageObject = loginPageObject ?? throw new ArgumentNullException(nameof(loginPageObject));
    }

    [Given(@"User goes to Zaplify login page")]
    public async Task UserGoesToZaplifyLoginPage()
    {
        await _loginPageObject.GotoZaplifyLoginPage();
    }

    [When(@"User fills email")]
    public async Task UserFillsEmail()
    {
        await _loginPageObject.FillEmailInput(TestData.Email);
    }

    [When(@"User fills password")]
    public async Task UserFillsPassword()
    {
        await _loginPageObject.FillPasswordInput(TestData.Password);
    }

    [When(@"User cliks login")]
    public async Task UserCliksLogin()
    {
        await _loginPageObject.ClickLoginButton();
    }

    [When(@"User fills incorrect email")]
    public async Task UserFillsIncorrectEmail()
    {
        await _loginPageObject.FillEmailInput("test@zaplifyy.com");
    }

    [When(@"User fills incorrect password")]
    public async Task UserFillsIncorrectPassword()
    {
        await _loginPageObject.FillPasswordInput("incorrectPassword");
    }

    [Then(@"User sees incorrect email message")]
    public async Task AssertUserSeesIncorrectEmailMessage()
    {
        await _loginPageObject.AssertUserSeesMessageThePasswordOrEmailIsIncorrect(TestData.IncorrectEmailMessage);
    }

    [Then(@"User sees incorrect password message")]
    public async Task AssertUserSeesIncorrectPasswordMessage()
    {
        await _loginPageObject.AssertUserSeesMessageEmailOrPasswordIncorrect(TestData.IncorrectPasswordMessage);
    }
}
