using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using WebDriverManager;
using WebDriverManager.DriverConfigs.Impl;
using SeleniumExtras.PageObjects;

namespace DemoQa.Pages
{
    public class TextBoxPage
    {
         IWebDriver Driver;
        public TextBoxPage(IWebDriver driver)
        {
            this.Driver = driver;
            
        }
       private IWebElement FullName => Driver.FindElement(By.XPath("//input[@id='userName']"));
       private IWebElement Email => Driver.FindElement(By.XPath("//input[@id='userEmail']"));
       private IWebElement AdressTab => Driver.FindElement(By.XPath("//textarea[@id='currentAddress']"));
       private IWebElement PermanentAddTab => Driver.FindElement(By.XPath("//textarea[@id='permanentAddress']"));
       private IWebElement SubmitButton => Driver.FindElement(By.XPath("//button[@id='submit']"));
       public void enterText(string name , string email, string Adress)
       {
            FullName.SendKeys(name);
            Email.SendKeys(email);
            AdressTab.SendKeys(Adress);
            PermanentAddTab.SendKeys(Adress);
            IJavaScriptExecutor js = (IJavaScriptExecutor)Driver;
            js.ExecuteScript("arguments[0].scrollIntoView(true);", SubmitButton);
            Thread.Sleep(5000);
            SubmitButton.Click();

       }


    }
}