using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;

namespace SeleniumAutomation
{
    class Facebook
    {
        //Creating reference for chromedriver
        IWebDriver driver = new ChromeDriver();

        static void Main(string[] args)
        {
        }
        [SetUp]
        public void Initialisation()
        {
            //Go to facebook page
            driver.Navigate().GoToUrl("https://www.facebook.com/r.php?entry_point=login");
        }
        [Test]
        public void Execution()
        {
            //Make browser full screen
            driver.Manage().Window.Maximize();

            //Web elements and operations
            IWebElement Firstname = driver.FindElement(By.Name("firstname"));
            Firstname.SendKeys("sinderijya");

            IWebElement Secondname = driver.FindElement(By.Name("lastname"));
            Secondname.SendKeys("damuserajya");

            IWebElement Email = driver.FindElement(By.Name("reg_email__"));
            Email.SendKeys("adsdadsd30@gmail.com");

            IWebElement Password = driver.FindElement(By.Id("password_step_input"));
            Password.SendKeys("Adsdadsd30!");

            IWebElement Month = driver.FindElement(By.Id("month"));
            var selectmonth = new SelectElement(Month);
            selectmonth.SelectByValue("10");

            IWebElement Day = driver.FindElement(By.Id("day"));
            var selectday = new SelectElement(Day);
            selectday.SelectByValue("26");

            IWebElement Year = driver.FindElement(By.Id("year"));
            var selectyear = new SelectElement(Year);
            selectyear.SelectByValue("2005");

            IWebElement Gender = driver.FindElement(By.XPath("/html/body/div[1]/div[1]/div[1]/div[2]/div/div[2]/div/div/div[1]/form/div[1]/div[4]/span/span[2]/label/input"));
            Gender.Click();

            IWebElement Signup = driver.FindElement(By.Name("websubmit"));
            Signup.Click();

            //After clicking the signin button it is going to wait for 4 sec to capture the error msg
            Thread.Sleep(4000);

            IWebElement Error = driver.FindElement(By.Id("reg_error_inner"));
            Console.WriteLine("Error message: " + Error.Text);
            Assert.That(Error.Text.Contains("There was an error with your registration. Please try registering again."));
        }
        [TearDown]
        public void CloseTest()
        {
            //close the browser
            driver.Quit();
        }
        

 }   
}
