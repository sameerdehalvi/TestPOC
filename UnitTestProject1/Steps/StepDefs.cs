using TechTalk.SpecFlow;
using UnitTestProject1.Core;
using UnitTestProject1.PageObjects;
using System.Configuration;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;
using System;
using OpenQA.Selenium;

namespace UnitTestProject1.Steps
{
    [Binding]
    public class StepDefs : TestBase
    {
        LoginPage _loginPage = new LoginPage();
        LandingPage _landingPage = new LandingPage();
        RoomBookingPage _roomBookingPage = new RoomBookingPage();

        public StepDefs()
        {
            PageFactory.InitElements(Driver, _loginPage);
            PageFactory.InitElements(Driver, _landingPage);
            PageFactory.InitElements(Driver, _roomBookingPage);
        }

        [Given(@"I launch Condeco website")]
        public void GivenILaunchCondecoWebsite()
        {
            Driver.Url = ConfigurationSettings.AppSettings["AppUrl"];
            Driver.Navigate();
            
        }

        [Given(@"I enter my username and Password")]
        public void GivenIEnterMyUsernameAndPassword()
        {
            _loginPage.Username.SendKeys("sameer.dehalvi@rbs.co.uk");
            _loginPage.Password.SendKeys("W!n22ter");
        }

        [When(@"I click Sign in")]
        public void WhenIClickSignIn()
        {
            _loginPage.SignIn.Click();
        }

        [When(@"I click on Go to my apps")]
        public void WhenIClickOnGoToMyApps()
        {
            _landingPage.GoToAppButton.Click();
        }

        [Then(@"I am on Room Booking Page")]
        public void ThenIAmOnRoomBookingPage()
        {
            Assert.IsTrue(_roomBookingPage.PageHeader.Text.Contains("Welcome"));
        }


        [Then(@"I am on landing page")]
        public void ThenIAmOnLandingPage()
        {
            Assert.AreEqual(Driver.Title, "RBS Resource Booking");
        }
    }
}
