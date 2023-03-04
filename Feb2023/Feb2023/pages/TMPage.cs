using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
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
            descriptiontextbox.SendKeys("feb2023");


            //Input price per unit into priceperunit textbox
            IWebElement priceperunittextbox = driver.FindElement(By.XPath("//*[@id=\"TimeMaterialEditForm\"]/div/div[4]/div/span[1]/span/input[1]"));
            priceperunittextbox.SendKeys("12");

            //click on save button
            IWebElement savebutton = driver.FindElement(By.Id("SaveButton"));
            savebutton.Click();
            Thread.Sleep(2000);
            // click on goto last
            IWebElement gotolast = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[4]/a[4]/span"));
            gotolast.Click();
            Thread.Sleep(5000);

            IWebElement newcode = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr[last()]/td[1]"));
            //Thread.Sleep(1000);
            if (newcode.Text == "feb2023")
            {
                Console.WriteLine("Recored created successfully");
            }
            else
            {
                Console.WriteLine("Not added");
            }

        }
        public void EditTm(IWebDriver driver)
        {
            IWebElement editbtn = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr[last()]/td[5]/a[1]"));
            editbtn.Click();

            //clear record from code textbox
            IWebElement clrcode = driver.FindElement(By.Id("Code"));
            clrcode.Clear();
            IWebElement edttextbox = driver.FindElement(By.Id("Code"));
            edttextbox.SendKeys("march2023");

            //Click on save button to edit the record
            IWebElement savebtn = driver.FindElement(By.Id("SaveButton"));
            savebtn.Click();
            Thread.Sleep(2000);

            IWebElement lastbtnclick = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[4]/a[4]/span"));
            lastbtnclick.Click();
            Thread.Sleep(3000);

            IWebElement editedrecored = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr[last()]/td[1]"));
            //*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr[last()]/td[1]
            if (editedrecored.Text == "march2023")
            {
            Console.WriteLine("Record in code textbox edited successfully");

            }
            else
            {
            Console.WriteLine("record not edited");
            }
        }
        public void DeleteTm(IWebDriver driver)
        {
            IWebElement delrecord = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr[last()]/td[5]/a[2]"));
            delrecord.Click();
            Thread.Sleep(1000);

            // Click on ok button
            IAlert al = driver.SwitchTo().Alert();
            al.Accept();
            Thread.Sleep(1000);

            IWebElement delre = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr[last()]/td[3]"));
            if (delre.Text == "june2023")
            {
                Console.WriteLine("Record not deleted successfully");
            }
            else
            {
                Console.WriteLine("Record deleted successfully");
            }
            driver.Quit();
        }
    }
}

