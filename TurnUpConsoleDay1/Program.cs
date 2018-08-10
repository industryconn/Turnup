using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using TurnUpConsoleDay1.Framework;
using TurnUpConsoleDay1.Pages;

namespace TurnUpConsoleDay1
{
    class Program
    {
        static void Main(string[] args)
        {
            // launch a browser

            DriverBase.driver = new ChromeDriver();

            LoginPage insta = new LoginPage();
            insta.LoginSuccess();

            HomePage hPage = new HomePage();
            hPage.ClickAdminstrationTab();
            hPage.ClickTimeAndMaterials();

            TimeAndMaterialPage tmPage = new TimeAndMaterialPage();
            tmPage.CreateBtn();
            tmPage.EnterValidDetails();

            //Close the browser.
            DriverBase.driver.Close();
        }
    }
}
