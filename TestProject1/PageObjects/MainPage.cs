using Microsoft.Playwright;
using System.Threading.Tasks;

namespace LoginPageTests.PageObjects
{
    public class MainPage
    {
        private readonly IPage _page;
        public MainPage(Hooks.Hooks hooks)
        {
            _page = hooks.User;
        }

        public async Task AssertUserIsRedirectedToMainPage()
        {
            await _page.WaitForURLAsync(url => url.StartsWith(TestData.ZaplifyMainLoginPageUrl));
        }
    }
}
