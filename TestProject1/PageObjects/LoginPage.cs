using Microsoft.Playwright;
using System.Threading.Tasks;

namespace LoginPageTests.PageObjects
{
    public class LoginPage
    { 
    private readonly IPage _page;
    public LoginPage(Hooks.Hooks hooks)
        {
            _page = hooks.User;
        }

        public async Task GotoZaplifyLoginPage()
        {
            await _page.GotoAsync(TestData.ZaplifyLoginPageUrl);
        }

        public async Task FillEmailInput(string email)
        {
            await _page.GetByPlaceholder("Email").ClickAsync();

            await _page.GetByPlaceholder("Email").FillAsync(email);
        }

        public async Task FillPasswordInput(string password)
        {
            await _page.GetByPlaceholder("Password").ClickAsync();

            await _page.GetByPlaceholder("Password").FillAsync(password);
        }

        public async Task ClickLoginButton()
        {
            await _page.GetByRole(AriaRole.Button, new() { Name = "Log in" }).ClickAsync();
        }

        public async Task AssertUserSeesMessageThePasswordOrEmailIsIncorrect(string message)
        {
            await Assertions.Expect(_page.Locator("form div")
               .Filter(new() { HasText = "The password or email you entered is incorrect." })
               .Nth(2)).ToContainTextAsync(message, new LocatorAssertionsToContainTextOptions());
        }

        public async Task AssertUserSeesMessageEmailOrPasswordIncorrect(string message)
        {
            await Assertions.Expect(_page.Locator("form div")
               .Filter(new() { HasText = "Email or password incorrect" })
               .Nth(2)).ToContainTextAsync(message, new LocatorAssertionsToContainTextOptions());
        }
    }
}
