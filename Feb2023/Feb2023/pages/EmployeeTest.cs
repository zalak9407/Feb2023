using Feb2023.utilities;
using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Feb2023.pages
{

    [TestFixture]
    [Parallelizable]
    public class EmployeeTest:Commondriver
    {
        //page objects initialization
        EmployeePage employeepageobj = new EmployeePage();
        HomePage homeobj = new HomePage();
           

        
        [Test, Order(1)]
        public void createemployeetest()
        {
        homeobj.GoToEmployeesPage(driver);
        employeepageobj.createemployee(driver);

        }
        [Test, Order(2)]
        public void editemployeetest()
        {
            homeobj.GoToEmployeesPage(driver);
            employeepageobj.editemployee(driver);

        }
        [Test, Order(3)]
        public void delemployeetest()
        {
            homeobj.GoToEmployeesPage(driver);
            employeepageobj.delemployee(driver);

        }
       
    }
}
