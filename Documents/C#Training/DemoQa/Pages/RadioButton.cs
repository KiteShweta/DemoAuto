using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using WebDriverManager;
using WebDriverManager.DriverConfigs.Impl;
using SeleniumExtras.PageObjects;

namespace DemoQa.Pages
{
    public class RadioButton
    {
        IWebDriver Driver;

        public RadioButton(IWebDriver driver)
        {
            this.Driver = driver;
        }

        private IWebElement RdBn => Driver.FindElement(By.XPath("//label[contains(text(),'Yes')]"));
        public void verifyRadioButton()
        {
            RdBn.Click();
        }
    }
}