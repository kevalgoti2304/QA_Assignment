using System;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;

namespace Assignment04
{
    [TestFixture]
    public class Assignment_04_Tests
    {
        private IWebDriver driver;
        private StringBuilder verificationErrors;
        private string baseURL;
        private bool acceptNextAlert = true;

        [SetUp]
        public void SetupTest()
        {
            driver = new FirefoxDriver();
            baseURL = "https://www.katalon.com/";
            verificationErrors = new StringBuilder();
        }

        [TearDown]
        public void TeardownTest()
        {
            try
            {
                driver.Quit();
            }
            catch (Exception)
            {
                // Ignore errors if unable to close the browser
            }
            Assert.AreEqual("", verificationErrors.ToString());
        }

        [Test]
        public void testForm_inputEnterAllData_outputDisplayData()
        {
            driver.Navigate().GoToUrl("http://localhost:8080/");
            driver.FindElement(By.Name("sellerName")).Click();
            driver.FindElement(By.Name("sellerName")).Clear();
            driver.FindElement(By.Name("sellerName")).SendKeys("Keval");
            driver.FindElement(By.Name("address")).Clear();
            driver.FindElement(By.Name("address")).SendKeys("37, vanier dr");
            driver.FindElement(By.Name("city")).Clear();
            driver.FindElement(By.Name("city")).SendKeys("Kitchener");
            driver.FindElement(By.Name("phoneNumber")).Clear();
            driver.FindElement(By.Name("phoneNumber")).SendKeys("226-339-2056");
            driver.FindElement(By.Name("email")).Clear();
            driver.FindElement(By.Name("email")).SendKeys("kgoti@gmail.com");
            driver.FindElement(By.Name("manufacturer")).Clear();
            driver.FindElement(By.Name("manufacturer")).SendKeys("lamborghini");
            driver.FindElement(By.Name("model")).Clear();
            driver.FindElement(By.Name("model")).SendKeys("aventador");
            driver.FindElement(By.Name("year")).Clear();
            driver.FindElement(By.Name("year")).SendKeys("2018");
            driver.FindElement(By.XPath("(.//*[normalize-space(text()) and normalize-space(.)='Buy or Sell - always get the very Best'])[1]/following::div[3]")).Click();
            driver.FindElement(By.XPath("//div[@id='app']/div/div[2]/div/div/button")).Click();
        }

        [Test]
        public void testForm_inputEnterAllData_outputVisitLinkInDisplayData()
        {
            driver.Navigate().GoToUrl("http://localhost:8080/");
            driver.FindElement(By.Name("sellerName")).Click();
            driver.FindElement(By.Name("sellerName")).Clear();
            driver.FindElement(By.Name("sellerName")).SendKeys("Salman Kahn");
            driver.FindElement(By.Name("address")).Clear();
            driver.FindElement(By.Name("address")).SendKeys("49, Vanier Dr");
            driver.FindElement(By.Name("city")).Clear();
            driver.FindElement(By.Name("city")).SendKeys("Kitchener");
            driver.FindElement(By.Name("phoneNumber")).Clear();
            driver.FindElement(By.Name("phoneNumber")).SendKeys("663-996-5236");
            driver.FindElement(By.Name("email")).Clear();
            driver.FindElement(By.Name("email")).SendKeys("salman@gmail.com");
            driver.FindElement(By.Name("manufacturer")).Clear();
            driver.FindElement(By.Name("manufacturer")).SendKeys("Ferrari");
            driver.FindElement(By.Name("model")).Clear();
            driver.FindElement(By.Name("model")).SendKeys("488-Spider");
            driver.FindElement(By.Name("year")).Clear();
            driver.FindElement(By.Name("year")).SendKeys("2018");
            driver.FindElement(By.XPath("//div[@id='app']/div/div[2]/div/div/button")).Click();
            driver.FindElement(By.LinkText("Visit Site")).Click();
        }


        [Test]
        public void testForm_inputDataWithOneFieldMissing_outputGiveErrorMissingField()
        {
            driver.Navigate().GoToUrl("http://localhost:8080/");
            driver.FindElement(By.Name("sellerName")).Click();
            driver.FindElement(By.Name("sellerName")).Clear();
            driver.FindElement(By.Name("sellerName")).SendKeys("keval");
            driver.FindElement(By.Name("city")).Clear();
            driver.FindElement(By.Name("city")).SendKeys("kitchener");
            driver.FindElement(By.Name("phoneNumber")).Clear();
            driver.FindElement(By.Name("phoneNumber")).SendKeys("226-669-5236");
            driver.FindElement(By.Name("email")).Clear();
            driver.FindElement(By.Name("email")).SendKeys("keval@gmail.com");
            driver.FindElement(By.Name("manufacturer")).Clear();
            driver.FindElement(By.Name("manufacturer")).SendKeys("maruti");
            driver.FindElement(By.Name("model")).Clear();
            driver.FindElement(By.Name("model")).SendKeys("swift");
            driver.FindElement(By.Name("year")).Clear();
            driver.FindElement(By.Name("year")).SendKeys("2018");
            driver.FindElement(By.Name("sellerName")).Click();
            driver.FindElement(By.XPath("(.//*[normalize-space(text()) and normalize-space(.)='Buy or Sell - always get the very Best'])[1]/following::div[3]")).Click();
            driver.FindElement(By.XPath("//div[@id='app']/div/div[2]/div/div/button")).Click();
        }

        [Test]
        public void testForm_inputDataWithInvalidMobileNumber_outputGiveErrorInvalidNumber()
        {
            driver.Navigate().GoToUrl("http://localhost:8080/");
            driver.FindElement(By.Name("sellerName")).Click();
            driver.FindElement(By.Name("sellerName")).Clear();
            driver.FindElement(By.Name("sellerName")).SendKeys("keval goti");
            driver.FindElement(By.Name("address")).Clear();
            driver.FindElement(By.Name("address")).SendKeys("37, vanier");
            driver.FindElement(By.Name("city")).Clear();
            driver.FindElement(By.Name("city")).SendKeys("cambridge");
            driver.FindElement(By.Name("phoneNumber")).Clear();
            driver.FindElement(By.Name("phoneNumber")).SendKeys("5236955874582");
            driver.FindElement(By.Name("email")).Clear();
            driver.FindElement(By.Name("email")).SendKeys("kevalgoti@gmail.com");
            driver.FindElement(By.Name("manufacturer")).Clear();
            driver.FindElement(By.Name("manufacturer")).SendKeys("maruti");
            driver.FindElement(By.Name("model")).Clear();
            driver.FindElement(By.Name("model")).SendKeys("swift");
            driver.FindElement(By.Name("year")).Clear();
            driver.FindElement(By.Name("year")).SendKeys("2018");
            driver.FindElement(By.XPath("//div[@id='app']/div/div[2]/div/div/button")).Click();
        }

        [Test]
        public void testForm_inputLeaveEmptyFields_outputGiveErrorAllFieldRequired()
        {
            driver.Navigate().GoToUrl("http://localhost:8080/");
            driver.FindElement(By.XPath("//div[@id='app']/div/div[2]/div/div/button")).Click();
        }

        private bool IsElementPresent(By by)
        {
            try
            {
                driver.FindElement(by);
                return true;
            }
            catch (NoSuchElementException)
            {
                return false;
            }
        }

        private bool IsAlertPresent()
        {
            try
            {
                driver.SwitchTo().Alert();
                return true;
            }
            catch (NoAlertPresentException)
            {
                return false;
            }
        }

        private string CloseAlertAndGetItsText()
        {
            try
            {
                IAlert alert = driver.SwitchTo().Alert();
                string alertText = alert.Text;
                if (acceptNextAlert)
                {
                    alert.Accept();
                }
                else
                {
                    alert.Dismiss();
                }
                return alertText;
            }
            finally
            {
                acceptNextAlert = true;
            }
        }
    }
}
