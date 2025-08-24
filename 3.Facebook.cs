using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

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
            driver.Navigate().GoToUrl("https://facebook.com");
        }
        [Test]
        public void Execute()
        {
            
        }
        

 }   
}