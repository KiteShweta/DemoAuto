using DemoQa.BaseClass;
using DemoQa.Pages;
using AventStack.ExtentReports;

namespace DemoQa.Test
{
     class ElementTestClass : UtilityClass
    {
        HomePageClass HomepageObj;
        ElementPage ElementObj;
        TextBoxPage TextBoxObj;
        CheckBoxPage CheckbxObj;
        RadioButton  RdBnObj;


        [SetUp]
        public void setup()
        {
            
            HomepageObj = new HomePageClass(Driver);
            ElementObj = new ElementPage(Driver);
            TextBoxObj = new TextBoxPage(Driver);
            CheckbxObj = new CheckBoxPage(Driver);
            RdBnObj = new RadioButton(Driver);
        }

       [Test, Order(1)]
        public void ResultTestOne()
        {       
            
              HomepageObj.DoOperations();
              logger.Info(message: "Welcome to home page");
              ElementObj.DoTaskClick_TextBox();
              logger.Info(message: "Element page is open");
              TextBoxObj.enterText("Jonh Daniel", "JonhDaniel@gmail.com", "house no. 230");
             logger.Info(message: "Info is added");
               test.Log(Status.Info,"Verified Info");
         }
       [Test,Order(2)]
         public void ResultTestTwo()
         {
             
            HomepageObj.DoOperations();
           logger.Info(message: "Welcome to home page");
            ElementObj.doClick_CheckBox();
            logger.Info(message: "Element page is opened");
            CheckbxObj.verifyCheckBox();
            logger.Info(message: "Checkbox function is verified");

            test.Log(Status.Info,"CheckBox Verified");
         }

     [Test,Order(3)]
         public void ResultTestThree()
         {
             
             HomepageObj.DoOperations();
            logger.Info(message: "Welcome to home page");
             ElementObj.doClick_RadioButton();
           logger.Info(message: "welcome Element page");
             RdBnObj.verifyRadioButton();
             logger.Info(message: "Radio button is verified");
              test.Log(Status.Info,"RadioButton Verified");
         }

        
    }
}