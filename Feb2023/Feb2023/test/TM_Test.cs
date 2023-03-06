using Feb2023.pages;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using Feb2023.utilities;

namespace Feb2023.test
{
    [TestFixture]
    public class TM_Test:Commondriver
    {
        [SetUp]
        public void loginsteps()
        {
           driver = new ChromeDriver(@"C:\Users\patel\Desktop\Feb2023");
            LoginPage loginobj = new LoginPage();
            loginobj.loginmethod(driver);

            HomePage homeobj = new HomePage();
            homeobj.GoToTmPage(driver);
        }
        [Test,Order(1)]
        public void createsteps()
        {
            TMPage tmobj = new TMPage();
            tmobj.CreateTm(driver);
        }
        [Test,Order(2)]
        public void Editsteps()
        {
            TMPage tmobj = new TMPage();
            tmobj.EditTm(driver);
        }
        [Test,Order(3)]
        public void Deletesteps()  
        {
            TMPage tmobj = new TMPage();
            tmobj.DeleteTm(driver);
        }
        [TearDown]
        public void closetestrun()
        {
            driver.Quit();
        }
       
    }
}
