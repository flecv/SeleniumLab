using OpenQA.Selenium;
using SeleniumLab.pages;

namespace SeleniumLab1.pages
{
    public class SearchPage : BasePage
    {
        public SearchPage(IWebDriver driver) : base(driver)
        {
            url += "search";
        }

        public void SeeCloudSearch()
        {
            RedirectPage(url + "?q=Cloud");
        }
    }
}