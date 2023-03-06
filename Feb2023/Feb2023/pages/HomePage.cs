using Feb2023.utilities;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Feb2023.pages
{
    public class HomePage
    {
        public void GoToTmPage(IWebDriver driver)
        {
            
            IWebElement administationdropdownlist = driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/a"));
            administationdropdownlist.Click();

            Wait.waitToBeClicable(driver, "XPath", "/html/body/div[3]/div/div/ul/li[5]/ul/li[3]/a", 5);

            IWebElement tmoption = driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/ul/li[3]/a"));
            tmoption.Click();
            Thread.Sleep(1000);
        }
    }
}
