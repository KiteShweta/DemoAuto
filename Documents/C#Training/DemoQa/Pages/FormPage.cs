using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
namespace DemoQa.Pages
{
    public class FormPage
    {
        IWebDriver Driver;
        public FormPage(IWebDriver driver)
        {
            this.Driver = driver;
        }

        private IWebElement FormTab => Driver.FindElement(By.XPath("//span[contains(text(),'Practice Form')]"));
        private IWebElement Name => Driver.FindElement(By.XPath("//input[@id='firstName']"));
        private IWebElement LastName => Driver.FindElement(By.XPath("//input[@id='lastName']"));
        private IWebElement Email => Driver.FindElement(By.XPath("//input[@id='userEmail']"));

        private IWebElement Gender => Driver.FindElement(By.XPath("//label[contains(text(),'Male')]"));
        private IWebElement Number => Driver.FindElement(By.XPath("//input[@id='userNumber']"));
        private IWebElement DOB => Driver.FindElement(By.XPath("//input[@id='dateOfBirthInput']"));

        private IWebElement Month => Driver.FindElement(By.XPath("//body/div[@id='app']/div[1]/div[1]/div[2]/div[2]/div[2]/form[1]/div[5]/div[2]/div[2]/div[2]/div[1]/div[1]/div[2]/div[1]/div[2]/div[1]/select[1]"));

        public void practiceForm()
        {
            FormTab.Click();
            Name.SendKeys("Jonh");
            LastName.SendKeys("Dizzy");
            Email.SendKeys("JonhDizzy@gmail.com");
            Gender.Click();
            Number.SendKeys("9564734879");
            DOB.Click();

            SelectElement select = new SelectElement(Month);
            select.SelectByValue("1");
            
        }
    }
}