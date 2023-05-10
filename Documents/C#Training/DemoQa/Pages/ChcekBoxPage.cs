using OpenQA.Selenium;
using DemoQa.BaseClass;


namespace DemoQa.Pages
{
    public class CheckBoxPage
    {
        IWebDriver Driver;

        public CheckBoxPage(IWebDriver driver)
        {
            this.Driver = driver;
        }

        private IWebElement AddMore => Driver.FindElement(By.XPath("//body[1]/div[2]/div[1]/div[1]/div[2]/div[2]/div[2]/div[1]/ol[1]/li[1]/span[1]/button[1]"));
        private IWebElement Checkbox => Driver.FindElement(By.XPath("//body/div[@id='app']/div[1]/div[1]/div[2]/div[2]/div[2]/div[1]/ol[1]/li[1]/span[1]/label[1]/span[1]/*[1]"));
        private IWebElement result => Driver.FindElement(By.XPath("//div[@id='result']"));
        public void verifyCheckBox()
        {
            AddMore.Click();
            Checkbox.Click();
            Thread.Sleep(3000);
            var message = "You have selected";
            var message1=result.Text;
            Assert.IsTrue(message1.Contains(message));
            UtilityClass.ScreenShotMethod(Driver,"test2");

        }
    }
}