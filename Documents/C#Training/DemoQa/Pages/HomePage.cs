using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using WebDriverManager;
using WebDriverManager.DriverConfigs.Impl;
using SeleniumExtras.PageObjects;



namespace DemoQa.Pages
{
    public class HomePageClass
    {
        IWebDriver Driver;

        public HomePageClass(IWebDriver driver)
        {
            this.Driver = driver;
        }

     
       private IWebElement Box1 => Driver.FindElement(By.XPath("//h5[normalize-space()='Elements']"));
       private IWebElement Alert => Driver.FindElement(By.XPath("//h5[contains(text(),'Alerts, Frame & Windows')]"));
       private IWebElement Form => Driver.FindElement(By.XPath("//h5[contains(text(),'Forms')]"));
       public void DoOperations()
       {
         IJavaScriptExecutor js = (IJavaScriptExecutor)Driver;
        js.ExecuteScript("arguments[0].scrollIntoView(true);", Box1);
        Box1.Click();
       }

        public void ClickOnAlertTab()
        {
        IJavaScriptExecutor js = (IJavaScriptExecutor)Driver;
        js.ExecuteScript("arguments[0].scrollIntoView(true);", Alert);
          Alert.Click();
        }
        public void ClickOnFormTab()
        {
          IJavaScriptExecutor js = (IJavaScriptExecutor)Driver;
        js.ExecuteScript("arguments[0].scrollIntoView(true);", Form);
        Form.Click();
        }
    }
}