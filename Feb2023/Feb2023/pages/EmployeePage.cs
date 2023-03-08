using Feb2023.utilities;
using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Feb2023.pages
{
    public class EmployeePage:Commondriver
    {
        public void createemployee(IWebDriver driver)
        {
            IWebElement empcreatenewbutton = driver.FindElement(By.XPath("//*[@id=\"container\"]/p/a"));
            empcreatenewbutton.Click();
            
            IWebElement nametextbox = driver.FindElement(By.Id("Name"));
            nametextbox.SendKeys("zalak");
            
            IWebElement usernametextbox = driver.FindElement(By.Id("Username"));
            usernametextbox.SendKeys("zalakpatel");

            IWebElement contacttextbox = driver.FindElement(By.Id("ContactDisplay"));
            contacttextbox.SendKeys("12345");

            IWebElement passwordtextbox = driver.FindElement(By.Id("Password"));
            passwordtextbox.SendKeys("zalak123");

            IWebElement retypepwd = driver.FindElement(By.Id("RetypePassword"));
            retypepwd.SendKeys("zalak123");

            IWebElement adminbox = driver.FindElement(By.Id("IsAdmin"));
            adminbox.Click();

            IWebElement vehicletextbox = driver.FindElement(By.XPath("//*[@id=\"UserEditForm\"]/div/div[7]/div/span[1]/span/input"));
            vehicletextbox.SendKeys("nissan");

            IWebElement enterGroup = driver.FindElement(By.XPath("//*[@id=\"UserEditForm\"]/div/div[8]/div/div/div[1]"));
            enterGroup.Click();
            Thread.Sleep(3000); //*[@id="UserEditForm"]/div/div[8]/div/div/div[1]

            IWebElement groupdropdown = driver.FindElement(By.XPath("//*[@id=\"groupList_listbox\"]"));
            groupdropdown.Click();
            Thread.Sleep(3000);
            //*[@id="groupList-list"]

            IWebElement savebtn1 = driver.FindElement(By.Id("SaveButton"));
            savebtn1.Click();

            IWebElement backto = driver.FindElement(By.XPath("//*[@id=\"container\"]/div/a"));
            backto.Click();
            Thread.Sleep(1000);

            IWebElement last = driver.FindElement(By.XPath("//*[@id=\"usersGrid\"]/div[4]/a[4]/span"));
            last.Click();
            Thread.Sleep(1000);
            //*[@id="usersGrid"]/div[4]/a[4]/span

            IWebElement lastaddedrecord = driver.FindElement(By.XPath("//*[@id=\"usersGrid\"]/div[3]/table/tbody/tr[last()]/td[1]"));

            Assert.That(lastaddedrecord.Text == "zalak", "Record is not added");

        }

        public void editemployee(IWebDriver driver)
        {
            Thread.Sleep(2000);
            driver.FindElement(By.XPath("//*[@id=\"usersGrid\"]/div[4]/a[4]/span")).Click();
            Thread.Sleep(2000);

            //click on edit //*[@id="usersGrid"]/div[3]/table/tbody/tr[4]/td[3]/a[1]
            driver.FindElement(By.XPath("//*[@id=\"usersGrid\"]/div[3]/table/tbody/tr[last()]/td[3]/a[1]")).Click();

            IWebElement editname = driver.FindElement(By.Id("Name"));
            editname.Clear();

            driver.FindElement(By.Id("Name")).SendKeys("zeel");

            driver.FindElement(By.Id("SaveButton")).Click();
            Thread.Sleep(3000);

            driver.FindElement(By.XPath("//*[@id=\"container\"]/div/a")).Click();
            Thread.Sleep(3000);

            driver.FindElement(By.XPath("//*[@id=\"usersGrid\"]/div[4]/a[4]/span")).Click();
            Thread.Sleep(3000);

            IWebElement neweditedrecord = driver.FindElement(By.XPath("//*[@id=\"usersGrid\"]/div[3]/table/tbody/tr[last()]/td[1]"));

            Assert.That(neweditedrecord.Text == "zeel", "Record is not edited");

        }

        public void delemployee(IWebDriver driver)
        {
            //*[@id="usersGrid"]/div[4]/a[4]/span
            Thread.Sleep(3000);
            driver.FindElement(By.XPath("//*[@id=\"usersGrid\"]/div[4]/a[4]/span")).Click();
            Thread.Sleep(3000);
           
            driver.FindElement(By.XPath("//*[@id=\"usersGrid\"]/div[3]/table/tbody/tr[last()]/td[3]/a[2]")).Click();
            Thread.Sleep(2000);

            driver.SwitchTo().Alert().Accept();

            Thread.Sleep(4000);

            IWebElement deletedname = driver.FindElement(By.XPath("//*[@id=\"usersGrid\"]/div[3]/table/tbody/tr[last()]/td[1]"));

            Assert.That(deletedname.Text != "zeel", "Record hasn't been deleted");


        }


    }
}
