using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace SeleniumAutomation
{
    class Program
    {
        //Create a reference for chrome browser
        IWebDriver driver = new ChromeDriver();

        string Actualresults;
        string Expectesresults="Google";
        static void Main(string[] args)
        {
        }
        [SetUp]
        public void Initialise()
        {
            //Go to google page
            driver.Navigate().GoToUrl("https://google.com");

        }
        [Test]
        public void ExecuteTest()
        {
            //Make the browser full screen
            driver.Manage().Window.Maximize();

            //Find the element
            IWebElement Searchbox = driver.FindElement(By.Name("q"));

            //Type smth in the search bar
            Searchbox.SendKeys("This is the best automation test startup!!");

            //Get the page title
            Actualresults = driver.Title;

            //Assert
            Assert.AreEqual(Expectesresults,Actualresults);
            //Assert.That(Equals(Expectesresults, Actualresults));
        }
        [TearDown]
        public void CloseTest()
        {
            //close the browser
            driver.Quit();
        }
 }   
}