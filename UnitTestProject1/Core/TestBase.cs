using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.PageObjects;
using TechTalk.SpecFlow;

namespace UnitTestProject1.Core
{
    public class TestBase
    {
        public IWebDriver Driver = null;
        public TestBase()
        {
            Driver = new ChromeDriver();
        }

        [AfterScenario()]
        public void CloseDriver()
        {
            Driver.Close();
            Driver.Dispose();
        }
    }
}
