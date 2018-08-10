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
    class HomePage
    {
        public HomePage()
        {
            PageFactory.InitElements(DriverBase.driver, this);
        }
        [FindsBy(How =How.XPath,Using = "//a[contains(.,'Administration ')]")]
        IWebElement adminTab { get; set; }

        [FindsBy(How = How.XPath, Using = "//a[@href='/TimeMaterial']")]
        IWebElement timeAndMaterial { get; set; }

        //public int MyProperty { get; set; }

        public void ClickAdminstrationTab()
        {
            // Click the Admin. Tab
            //DriverBase.driver.FindElement(By.XPath("//a[contains(.,'Administration ')]")).Click();
            adminTab.Click();
        }

        public void ClickTimeAndMaterials()
        {
            // Click the Time and Material Sub Tab
            //DriverBase.driver.FindElement(By.XPath("//a[@href='/TimeMaterial']")).Click();
            timeAndMaterial.Click();
        }
    }
}
