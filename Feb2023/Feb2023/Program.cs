// open cHrome browser
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;


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

IWebElement newcode = driver.FindElement(By.XPath("//*[@id=\" tmsGrid \"]/div[3]/table/tbody/tr[last()]/td[1]"));

if(newcode.Text == "feb2023")
{
    Console.WriteLine("Recored created successfully");
     }
else
{
    Console.WriteLine("Not added");
}

