using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TurnUpConsoleDay1.Framework;

namespace TurnUpConsoleDay1.Pages
{
    class LoginPage
    {
        public LoginPage()
        {
            PageFactory.InitElements(DriverBase.driver, this );
        }
        [FindsBy(How = How.Id, Using = "UserName")]
        private IWebElement userName { get; set; }

        [FindsBy(How = How.Id, Using = "Password")]
        private IWebElement password { get; set; }

        //private int i { get; set; }
        [FindsBy(How = How.XPath, Using = ".//*[@id='loginForm']/form/div[3]/input[1]")]
        private IWebElement loginBtn { get; set; }

        public void LoginSuccess()
        {
            // open the turn up login page. 
            DriverBase.driver.Navigate().GoToUrl("http://horse-dev.azurewebsites.net/Account/Login?ReturnUrl=%2f");

            // Identify username and password.
            //var username = DriverBase.driver.FindElement(By.Id("UserName"));
            //username.SendKeys("ray");
            userName.SendKeys("ray");

            //DriverBase.driver.FindElement(By.Id("Password")).SendKeys("123123");
            password.SendKeys("123123");

            //Click the Login Btn
            //DriverBase.driver.FindElement(By.XPath(".//*[@id='loginForm']/form/div[3]/input[1]")).Click();
            loginBtn.Click();
        }

        public void Randon()
        {
            userName.SendKeys("Resusability of web elements");
          
        }
        
    }
}
