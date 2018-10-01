using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using UnitTestProject1.Core;

namespace UnitTestProject1.PageObjects
{
    public class LandingPage : PageObjectsBase
    {
        [FindsBy(How = How.CssSelector, Using = "#bs-example-navbar-collapse-1 > ul > li.nav-item.btn-ent-app > a")]
        public IWebElement GoToAppButton { get; set; }
    }
}
