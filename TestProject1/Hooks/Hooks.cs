using BoDi;
using Microsoft.Playwright;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace LoginPageTests.Hooks
{
    [Binding]
    public class Hooks
    {
        public IPage User { get; private set; } = null!;

        [BeforeScenario]
        public async Task RegisterSingleInstancePractitioner()
        {
            
            var playwright = await Playwright.CreateAsync();
            
            var browser = await playwright.Chromium.LaunchAsync(new BrowserTypeLaunchOptions
            {
                Headless = false
            });
            
            var context1 = await browser.NewContextAsync();

            User = await context1.NewPageAsync();
        }


    }
}