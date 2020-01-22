using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;


namespace seleniumAutomatizacion
{
    class Program
    {
        static void Main(string[] args)
        {
            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://www.choucairtesting.com/servicio/");
            driver.Manage().Window.Maximize();
            //search-field
            IWebElement svg = driver.FindElement(By.ClassName("search-icon"));
            svg.Click();

            IWebElement label = driver.FindElement(By.ClassName("search-field"));
            label.SendKeys("servicios");
            label.SendKeys(Keys.Enter);

            IWebElement img = driver.FindElement(By.ClassName("site-logo"));
            img.Click();

            driver.Manage().Window.Maximize();
            driver.Close();
        }
    }
}
