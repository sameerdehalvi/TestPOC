using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace UnitTestProject1.PageObjects
{
    public class RoomBookingPage: PageObjectsBase
    {

        [FindsBy(How = How.ClassName, Using = "welcomeMsg")]
        public IWebElement PageHeader { get; set; }
    }
}
