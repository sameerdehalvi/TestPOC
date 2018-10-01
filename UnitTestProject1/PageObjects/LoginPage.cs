using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;


namespace UnitTestProject1.PageObjects
{
    public class LoginPage: PageObjectsBase
    { 

        [FindsBy(How = How.Id, Using= "txtUserName")]
        public IWebElement Username { get; set; }

        [FindsBy(How = How.Id, Using = "txtPassword")]
        public IWebElement Password { get; set; }

        [FindsBy(How = How.Id, Using = "btnLogin")]
        public IWebElement SignIn { get; set; }
    }
}
