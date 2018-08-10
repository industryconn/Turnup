using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Threading;
using TurnUpConsoleDay1.Framework;

namespace TurnUpConsoleDay1.Pages
{
    class TimeAndMaterialPage
    {
        public TimeAndMaterialPage()
        {
            PageFactory.InitElements(DriverBase.driver, this);
        }
        [FindsBy(How = How.XPath, Using = "//a[@href='/TimeMaterial/Create']")]
        IWebElement createBtn { get; set; }

        [FindsBy(How = How.XPath, Using = "//span[@class='k-input']")]
        IWebElement typCodeDdl { get; set; }

        //[FindsBy(How = How.XPath, Using = "")]
        //IWebElement createBtn { get; set; }
        //[FindsBy(How = How.XPath, Using = "")]
        //IWebElement createBtn { get; set; }
        //[FindsBy(How = How.XPath, Using = "")]
        //IWebElement createBtn { get; set; }

        public void CreateBtn()
        {
            //Click the Create Button 
            //DriverBase.driver.FindElement(By.XPath("//a[@href='/TimeMaterial/Create']")).Click();
            createBtn.Click();
        }

        public void EnterValidDetails()
        {
            //Chose Type Code from Dropdown list
            //home work

            for (int i = 1; i <= 2; i++)
            {
                Thread.Sleep(2000);
                //DriverBase.driver.FindElement(By.XPath("//span[@class='k-input']")).Click();
                typCodeDdl.Click();

                Thread.Sleep(2000);
                string dropDownText = DriverBase.driver.FindElement(By.XPath(".//*[@id='TypeCode_listbox']/li[" + i + "]")).Text;
                if(dropDownText=="Time")
                {
                    DriverBase.driver.FindElement(By.XPath(".//*[@id='TypeCode_listbox']/li[" + i + "]")).Click();
                }
                //DriverBase.driver.FindElement(By.XPath("//span[@class='k-input']")).Click();

                typCodeDdl.Click();
            }



            //Enter Code
            DriverBase.driver.FindElement(By.XPath("//input[@id='Code']")).SendKeys("Code321");

            //Enter Desc.
            DriverBase.driver.FindElement(By.Id("Description")).SendKeys("Descr");

            try
            {
                DriverBase.driver.FindElement(By.XPath(".//*[@id='TimeMaterialEditForm']/div/div[4]/div/span[1]/span/input[1]")).SendKeys("8");
            }
            catch (Exception) { }
            //Enter Price Per Unit.

            //Click Save Button
            DriverBase.driver.FindElement(By.XPath("//input[@id='SaveButton']")).Click();
        }
            
    }
}
