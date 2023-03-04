using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using Feb2023.pages;

IWebDriver driver = new ChromeDriver();

LoginPage loginobj = new LoginPage();
loginobj.loginmethod(driver);

HomePage homeobj = new HomePage();
homeobj.GoToTmPage(driver);

TMPage tmobj = new TMPage();
tmobj.CreateTm(driver);
tmobj.EditTm(driver);
tmobj.DeleteTm(driver);