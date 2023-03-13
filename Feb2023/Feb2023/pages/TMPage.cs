using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Feb2023.pages
{
    public class TMPage
    {
        public void CreateTm(IWebDriver driver)
        {
            IWebElement createnewbutton = driver.FindElement(By.XPath("//*[@id=\"container\"]/p/a"));
            createnewbutton.Click();



            //select time option from typecode dropdownlist
            IWebElement typecodedropdown = driver.FindElement(By.XPath("//*[@id=\"TimeMaterialEditForm\"]/div/div[1]/div/span[1]/span/span[2]/span"));
            typecodedropdown.Click();
            IWebElement tm = driver.FindElement(By.XPath("//*[@id=\"TypeCode_listbox\"]/li[2]"));
            tm.Click();


            //Input code into code textbox
            IWebElement codetextbox = driver.FindElement(By.Id("Code"));
            codetextbox.SendKeys("feb2023");


            //input description into description textbox
            IWebElement descriptiontextbox = driver.FindElement(By.Id("Description"));
            descriptiontextbox.SendKeys("june2023");


            //Input price per unit into priceperunit textbox
            IWebElement priceperunittextbox = driver.FindElement(By.XPath("//*[@id=\"TimeMaterialEditForm\"]/div/div[4]/div/span[1]/span/input[1]"));
            priceperunittextbox.SendKeys("12");

            //click on save button
            IWebElement savebutton = driver.FindElement(By.Id("SaveButton"));
            savebutton.Click();
            Thread.Sleep(3000);

            // click on goto last
            IWebElement gotolast = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[4]/a[4]/span"));
            gotolast.Click();
            Thread.Sleep(1000);


            //IWebElement newcode = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr[last()]/td[1]"));
            ////Thread.Sleep(1000);
            //IWebElement newdes = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr[last()]/td[3]"));
            //Assert.That(newcode.Text == "feb2023", "Actual code and exxpected code do not match");
            //Assert.That(newdes.Text == "june2023", "Actual code and expected code do not match");
            ////if (newcode.Text == "feb2023")
            //{
            //    Console.WriteLine("Recored created successfully");
            //}
            //else
            //{
            //    Console.WriteLine("Not added");
            //}
        }
            public string getcode(IWebDriver driver)
            {
                IWebElement actualcode = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr[last()]/td[1]"));
                return actualcode.Text;
            }
        public string getdescription(IWebDriver driver)
        {
            IWebElement actualdescription = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr[last()]/td[3]"));
            return actualdescription.Text;
        }
        public string getprice(IWebDriver driver)
        {
            IWebElement actualprice = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr[last()]/td[4]"));
            return actualprice.Text;
        }

        public void EditTm(IWebDriver driver)
        {
            IWebElement last = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[4]/a[4]"));
            last.Click();
            
            
            //*[@id="tmsGrid"]/div[3]/table/tbody/tr[3]/td[1]
            //*[@id="tmsGrid"]/div[3]/table/tbody/tr[7]/td[5]/a[1]
            IWebElement recoredtobeedit = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr[last()]/td[1]"));
            if (recoredtobeedit.Text == "feb2023") 
            {
                IWebElement editbtn = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr[last()]/td[5]/a[1]"));
                editbtn.Click();
            }
            else
            {
                Assert.Fail("record to be edited not found");
            }
            //clear record from code textbox
            IWebElement clrcode = driver.FindElement(By.XPath("//*[@id=\"Code\"]"));
            clrcode.Clear();
            
            IWebElement edttextbox = driver.FindElement(By.XPath("//*[@id=\"Code\"]"));
            edttextbox.SendKeys("march2023");

            //Click on save button to edit the record
            IWebElement savebtn = driver.FindElement(By.Id("SaveButton"));
            savebtn.Click();
            

            Thread.Sleep(2000);
            IWebElement lastbtnclick = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[4]/a[4]/span"));
            lastbtnclick.Click();
            Thread.Sleep(3000);
            //*[@id="tmsGrid"]/div[4]/a[4]/span

            IWebElement editedrecored = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr[last()]/td[1]"));
            //*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr[last()]/td[1]
            Assert.That(editedrecored.Text == "march2023", "Actual code and exxpected code do not match");
            //if (editedrecored.Text == "march2023")
            //{
            //Console.WriteLine("Record in code textbox edited successfully");

            //}
            //else
            //{
            //Console.WriteLine("record not edited");
            //}
        }
        public void DeleteTm(IWebDriver driver)
        {
            IWebElement last = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[4]/a[4]"));
            last.Click();
            IWebElement recoredtobedel = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr[last()]/td[1]"));
            if (recoredtobedel.Text == "march2023")
            {
                IWebElement delrecord = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr[last()]/td[5]/a[2]"));
                delrecord.Click();
                Thread.Sleep(1000);
            }
            else
            {
                Assert.Fail("record to be delet not found");
            }

            // Click on ok button
            IAlert al = driver.SwitchTo().Alert();
            al.Accept();
            Thread.Sleep(1000);

            IWebElement delre = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr[last()]/td[3]"));
            Assert.That(delre.Text != "march2023", "record hasn't been deleted");

            //if (delre.Text == "march2023")
            //{
            //    Console.WriteLine("Record not deleted successfully");
            //}
            //else
            //{
            //    Console.WriteLine("Record deleted successfully");
            //}
            driver.Quit();
        }
    }
}

