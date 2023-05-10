using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace DemoQa.Pages
{
    public class AllAlerts
    {

        IWebDriver Driver;

        public AllAlerts(IWebDriver driver)
        {
            this.Driver = driver;
        }

        private IWebElement AlertPopUp1 => Driver.FindElement(By.XPath("//button[@id='alertButton']"));
        
        private IWebElement AlertPopUp2 => Driver.FindElement(By.XPath("//button[@id='timerAlertButton']"));
        
        private IWebElement AlertPopUp3 => Driver.FindElement(By.XPath("//button[@id='confirmButton']"));

        private IWebElement AlertPopUp4 => Driver.FindElement(By.XPath("//button[@id='promtButton']"));

        public void AcceptAlert()
        {
            AlertPopUp1.Click();
            Driver.SwitchTo().Alert().Accept();
            AlertPopUp2.Click();
            Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(7000);
            Driver.SwitchTo().Alert().Accept();
            AlertPopUp3.Click();
            Driver.SwitchTo().Alert().Dismiss();
            AlertPopUp4.Click();
            Driver.SwitchTo().Alert().SendKeys("Shweta");
            Driver.SwitchTo().Alert().Accept();            
           
             
        }
    }
}