using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace SeleniumAutomation
{
      class Amazon
      {
            //Create a refernce for chrome browser
            IWebDriver driver = new ChromeDriver();

            static void Main(string[] args)
            {
            }
            [SetUp]
            public void Initialize()
            {
                  //Go to google page
                  driver.Navigate().GoToUrl("https://www.amazon.com");
            }
            [Test]
            public void Execute()
            {
                  //Make the browser full screen
                  driver.Manage().Window.Maximize();

                  //Web elements
                  IWebElement SignIn = driver.FindElement(By.Id("nav-link-accountList"));

                  //Operations
                  SignIn.Click();

            }
 }   
}