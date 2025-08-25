using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace SeleniumAutomation
{
      class Amazon
      {
            //Create a refernce for the browser to be used (chrome browser)
            IWebDriver driver = new ChromeDriver();

            static void Main(string[] args)
            {
            }
            [SetUp]
            public void Initialize()
            {
                  //Go to Amazon page
                  driver.Navigate().GoToUrl("https://www.amazon.com");
            }
            [Test]
            public void Execute()
            {
                  //Make the browser full screen
                  driver.Manage().Window.Maximize();

                  //Web elements and operations
                  IWebElement SignIn = driver.FindElement(By.Id("nav-link-accountList"));
                  SignIn.Click();
                  IWebElement FieldInput = driver.FindElement(By.Id("ap_email_login"));
                  FieldInput.SendKeys("peadsds@uv.te");
                  IWebElement Continue = driver.FindElement(By.ClassName("a-button-input"));
                  Continue.Click();
                  IWebElement Message = driver.FindElement(By.CssSelector("h1.a-size-medium-plus.a-spacing-small"));
                  Console.WriteLine("Error message: " + Message.Text);
                  String Actualresult = Message.Text;
                  String Expectedresult = "Looks like you're new to Amazon";
                  Assert.AreEqual(Actualresult, Expectedresult);

            }
 }   
}