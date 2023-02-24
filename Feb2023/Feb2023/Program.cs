// open cHrome browser
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;


        IWebDriver driver = new ChromeDriver();
        driver.Manage().Window.Maximize();


        // Turnup portal
        driver.Navigate().GoToUrl("http://horse.industryconnect.io/Account/Login?ReturnUrl=%2f");

        //Identify Username textbox and enter valid username
        IWebElement usernametextbox = driver.FindElement(By.Id("UserName"));
        usernametextbox.SendKeys("hari");

        //Identify Password textbox and enter valid password
        IWebElement passwordtextbox = driver.FindElement(By.Id("Password"));
        passwordtextbox.SendKeys("123123");

        //Identify login button and click on login button
        IWebElement loginbutton = driver.FindElement(By.XPath("//*[@id=\"loginForm\"]/form/div[3]/input[1]"));
        loginbutton.Click();
        //
        IWebElement hellohari = driver.FindElement(By.XPath("//*[@id=\"logoutForm\"]/ul/li/a"));
        if (hellohari.Text == "Hello hari!")
        { Console.WriteLine("successfully login"); }
        else
        {
            Console.WriteLine("failed login");
        }
    
