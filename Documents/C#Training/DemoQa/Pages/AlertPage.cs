using OpenQA.Selenium;

namespace DemoQa.Pages
{
    public class AlertPage
    {
        IWebDriver Driver;
        public AlertPage(IWebDriver driver)
        {
            this.Driver = driver;
        }

        private IWebElement AlertT => Driver.FindElement(By.XPath("//span[contains(text(),'Alerts')]"));

        public void Click_On_Alert()
        {
            AlertT.Click();
        }
    }
}