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
    [Parallelizable]
    public class TM_Test:Commondriver
    {
        //page object initialization
        HomePage homeobj = new HomePage();
        TMPage tmobj = new TMPage();
            
            
        
        [Test,Order(1)]
        public void createsteps()
        {
        homeobj.GoToTmPage(driver);
        tmobj.CreateTm(driver);
        }
        [Test,Order(2)]
        public void Editsteps()
        {
        homeobj.GoToTmPage(driver);
        //tmobj.EditTm(driver);
        }
        [Test,Order(3)]
        public void Deletesteps()  
        {
        homeobj.GoToTmPage(driver);
        tmobj.DeleteTm(driver);
        }
       
       
    }
}
