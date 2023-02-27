// open cHrome browser
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.Events;

IWebDriver driver = new ChromeDriver();
        driver.Manage().Window.Maximize();


        // Turnup portal
        driver.Navigate().GoToUrl("http://horse.industryconnect.io/Account/Login?ReturnUrl=%2f");
        Thread.Sleep(1000);
        //Identify Username textbox and enter valid username
        IWebElement usernametextbox = driver.FindElement(By.Id("UserName"));
        usernametextbox.SendKeys("hari");

        //Identify Password textbox and enter valid password
        IWebElement passwordtextbox = driver.FindElement(By.Id("Password"));
        passwordtextbox.SendKeys("123123");

        //Identify login button and click on login button
        IWebElement loginbutton = driver.FindElement(By.XPath("//*[@id=\"loginForm\"]/form/div[3]/input[1]"));
        loginbutton.Click();
        Thread.Sleep(1000);
        //
        IWebElement hellohari = driver.FindElement(By.XPath("//*[@id=\"logoutForm\"]/ul/li/a"));
        if (hellohari.Text == "Hello hari!")
        { Console.WriteLine("successfully login"); }
        else
        {
            Console.WriteLine("failed login");
        }

//create a new time record
//navigate to time and material page
IWebElement administationdropdownlist = driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/a"));
administationdropdownlist.Click();
IWebElement tmoption = driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/ul/li[3]/a"));
tmoption.Click();
Thread.Sleep(1000);


//click on create new
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
if(newcode.Text == "feb2023")
{
    Console.WriteLine("Recored created successfully");
     }
else
{
    Console.WriteLine("Not added");
}
//click on edit button to edit record

IWebElement editbtn = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr[last()]/td[5]/a[1]"));
editbtn.Click();

//clear record from code textbox
IWebElement clrcode = driver.FindElement(By.Id("Code"));
clrcode.Clear();
IWebElement edttextbox = driver.FindElement(By.Id("Code"));
edttextbox.SendKeys("march2023");

//clear record from description textbox
IWebElement clrdescription = driver.FindElement(By.Id("Description"));
clrdescription.Clear();
IWebElement detextbox = driver.FindElement(By.Id("Description"));
detextbox.SendKeys("june2023");

//clear record from priceperunit textbox
//driver.FindElement(By.XPath("//*[@id=\"TimeMaterialEditForm\"]/div/div[4]/div/span[1]/span/input[1]")).Clear();
//Thread.Sleep(2000);

//driver.FindElement(By.XPath("//*[@id=\"TimeMaterialEditForm\"]/div/div[4]/div/span[1]/span/input[1]")).SendKeys("13");
////*[@id="TimeMaterialEditForm"]/div/div[4]/div/span[1]/span/input[1]
//*[@id="TimeMaterialEditForm"]/div/div[4]/div/span[1]/span
//*
//*[@id="TimeMaterialEditForm"]/div/div[4]/div/span[1]/span
////*[@id="Price"]

//IWebElement pputextbox = driver.FindElement(By.Id("Price"));


//Click on save button to edit the record
IWebElement savebtn = driver.FindElement(By.Id("SaveButton"));
savebtn.Click();
Thread.Sleep(2000);

//gotolats page to check record edited successfully
IWebElement lastbtnclick = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[4]/a[4]/span"));
lastbtnclick.Click();
Thread.Sleep(3000);

IWebElement editedrecored = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr[last()]/td[1]"));

if(editedrecored.Text == "march2023")
{
    Console.WriteLine("Record in code textbox edited successfully");

}
else
{
    Console.WriteLine("record not edited");

}

//check record edited successfully in description textbox
IWebElement editde = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr[last()]/td[3]"));
//*[@id="tmsGrid"]/div[3]/table/tbody/tr[3]/td[3]
if (editde.Text == "june2023")
{
    Console.WriteLine("Record in description textbox edited successfully");

}
else
{
    Console.WriteLine("Record in description textbox not edited");
}


//delete record
IWebElement delrecord = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr[last()]/td[5]/a[2]"));
delrecord.Click();
Thread.Sleep(1000);

// Click on ok button
IAlert al = driver.SwitchTo().Alert();
al.Accept();
Thread.Sleep(1000);

IWebElement delre = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr[last()]/td[3]"));
if(delre.Text== "june2023")
{
    Console.WriteLine("Record not deleted successfully");
}
else
{
    Console.WriteLine("Record deleted successfully");
}
driver.Quit();