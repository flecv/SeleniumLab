using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using SeleniumLab1.pages;
using TechTalk.SpecFlow;

namespace SeleniumLab1
{
    [Binding]
    public class Steps
    {
        private static IWebDriver driver;
        private static MainPage mainPage;
        private static CareersPage careersPage;
        private static SearchPage searchPage;

        [Before]
        public static void Begin()
        {
            var options = new ChromeOptions();
            options.AddArgument("start-maximized");

            driver = new ChromeDriver("D:\testing", options);

            mainPage = new MainPage(driver);
            searchPage = new SearchPage(driver);
            careersPage = new CareersPage(driver);
        }

        [After]
        public static void End()
        {
            driver.Quit();
        }

        [Given(@"User has opened the main page")]
        public void OpenMain()
        {
            mainPage.GoTo();
            mainPage.CloseDisclaimer();
        }

        [When(@"User click on (.+) button")]
        public void ClickButton(string arg0)
        {
            mainPage.ClickButton(arg0);
        }

        [Then(@"User see that page changed language")]
        public void ChangeCareersRegion()
        {
            careersPage.SeeCareersPage();
        }

        [Then(@"User check that he come to (.+) page")]
        public void RedirectToPage(string arg0)
        {
            mainPage.Redirection(arg0);
        }

        [When(@"User enter 'Cloud'")]
        public void EnterCloud()
        {
            mainPage.EnterSearchText("Cloud");
        }

        [Then(@"User check that page changed to search result")]
        public void ChangedToSearchCloud()
        {
            searchPage.SeeCloudSearch();
        }

        [When(@"User point cursor to (.+)")]
        public void PointCursorToButton(string arg0)
        {
            mainPage.PointToButton(arg0);
        }

        [Then(@"User check that it is hovered by text")]
        public void CheckIsHovered()
        {
            mainPage.DesignHover();
        }

        [Then(@"User is redirected on (.+) page")]
        public void GoToNewPage(string arg0)
        {
            mainPage.OpenInNewPage(arg0);
        }

    }
}

