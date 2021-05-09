using System;
using System.Collections;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.PageObjects;
using SeleniumExtras.WaitHelpers;
using SeleniumLab.pages;

namespace SeleniumLab1.pages
{
    public class MainPage : BasePage
    {
        private Actions actions;

        public MainPage(IWebDriver _driver) : base(_driver)
        {
            actions = new Actions(driver);
        }

        //Contact us button, first scenario
        [FindsBy(How = How.XPath, Using = "//span[contains(text(),'CONTACT US')]")]
        private IWebElement contactUsButton;

        //Language button, 2 scenario
        [FindsBy(How = How.XPath, Using = "//button[contains(@class,'location-selector__button')][ contains(text(),'Global (EN)')]")]
        private IWebElement languageButton;
        [FindsBy(How = How.XPath, Using = "//a[contains(@href, 'https://careers.epam.ua')]")]
        private IWebElement ukraineButton;

        //Infogen button, 3 scenario
        [FindsBy(How = How.XPath, Using = "//a[contains(@href,'https://www.infogen.com/')]")]
        private IWebElement infogenAiButton;

        //We are in button, 4 scenario
        [FindsBy(How = How.XPath, Using = "//a[contains(@href, 'https://www.facebook.com/EPAM.Globa')]")]
        private IWebElement facebookButton;

        //Our work button, 5 scenario
        [FindsBy(How = How.XPath, Using = "//a[contains(@href, 'https://www.epam.com/our-work')]")]
        private IWebElement ourWorkButton;

        //Find you dream job button, 6 scenario
        [FindsBy(How = How.XPath, Using = "//a[contains(@href, 'https://www.epam.com/careers')]")]
        private IWebElement careersButton;

        //Hower, 7 scenario
        [FindsBy(How = How.XPath, Using = "//img[contains(@class, 'rollover-tiles__image')][contains(@src, '/content/dam/epam/what_we_do/Design-Yellow.svg')]")]
        private IWebElement designButton;
        [FindsBy(How = How.XPath, Using = "//strong[contains(@class, 'rollover-tiles__title')][contains(text(), 'Design')]")]
        private IWebElement designHover;

        //Search function, 8 scenario
        [FindsBy(How = How.XPath, Using = "//button[contains(@class, 'header-search__button header__icon')]")]
        private IWebElement searchButton;
        [FindsBy(How = How.Id, Using = "new_form_search")]
        private IWebElement searchField;


        [FindsBy(How = How.XPath,
            Using = "//*[contains(@class,'button-ui bg-color-light-blue cookie-disclaimer__button')]")]
        private IWebElement disclaimerButton;
        public void GoTo()
        {
            driver.Navigate().GoToUrl(url);
            new WebDriverWait(driver, TimeSpan.FromSeconds(10)).Until(driver => driver.Url == url);
        }

        public void EnterSearchText(string searchText)
        {
            searchField.SendKeys(searchText);
            searchField.Submit();
        }

        public void CloseDisclaimer()
        {
            disclaimerButton.Click();
        }

        public void PointToButton(string button)
        {
            actions.MoveToElement(FindButton(button)).Build().Perform();
        }
        private IWebElement FindButton(string name)
        {
            switch (name)
            {
                case "DESIGN":
                    return designButton;
                case "Contact Us":
                    return contactUsButton;
                case "INFOGEN":
                    return infogenAiButton;
                case "FACEBOOK":
                    return facebookButton;
                case "OUR WORK":
                    return ourWorkButton;
                case "language":
                    return languageButton;
                case "search":
                    return searchButton;
                case "careers":
                    return careersButton;
                default:
                    return ukraineButton;
            }
        }

        public void ClickButton(string button)
        {
            IWebElement but = FindButton(button);
            new WebDriverWait(driver, TimeSpan.FromSeconds(10)).Until(ExpectedConditions.ElementToBeClickable(but));
            but.Click();
        }


        public void Redirection(string page)
        {
            RedirectPage(url + page);
        }

        public void DesignHover()
        {
            Assert.AreEqual(designHover.Displayed, true);
        }

        public void OpenInNewPage(string link)
        {
            ArrayList tabs = new ArrayList(driver.WindowHandles);
            driver.SwitchTo().Window((string)tabs[1]);
            Assert.AreEqual(driver.Url, link);
        }
    }
}