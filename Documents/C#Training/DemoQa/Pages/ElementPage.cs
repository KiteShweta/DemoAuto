using OpenQA.Selenium;

namespace DemoQa
{
    public class ElementPage
    {
        IWebDriver Driver;
        public ElementPage(IWebDriver driver)
        {
            this.Driver = driver;
        }

        
       private IWebElement Textbox => Driver.FindElement(By.XPath("//span[contains(text(),'Text Box')]"));
       private IWebElement CheckBox => Driver.FindElement(By.XPath("//span[contains(text(),'Check Box')]"));

       private IWebElement RadioButton => Driver.FindElement(By.XPath("//span[contains(text(),'Radio Button')]"));
       public void DoTaskClick_TextBox()
       {
        Textbox.Click();
       }

       public void doClick_CheckBox()
       {
        CheckBox.Click();
       }

      public void doClick_RadioButton()
      {
        RadioButton.Click();
      }

    
    }
}