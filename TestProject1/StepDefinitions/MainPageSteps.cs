using LoginPageTests.PageObjects;
using System;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace LoginPageTests.StepDefinitions
{
    [Binding]
    public class MainPageSteps
    {
        private readonly MainPage _mainPageObject;

        public MainPageSteps(MainPage mainPageObject)
        {
            _mainPageObject = mainPageObject ?? throw new ArgumentNullException(nameof(mainPageObject));
        }

        [Then(@"User is redirected to Zaplify main page")]
        public async Task UserIsRedirectedToZaplifyMainPage()
        {
            await _mainPageObject.AssertUserIsRedirectedToMainPage();
        }


    }
}
