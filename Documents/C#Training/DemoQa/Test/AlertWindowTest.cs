
using DemoQa.BaseClass;
using DemoQa.Pages;
using AventStack.ExtentReports;


namespace DemoQa.Test
{

    class AlertWindowTest:UtilityClass
    {
         HomePageClass HomepageObj;
         AlertPage ApObj;
         AllAlerts AaObj;
        [SetUp]
        public void setup2()
        {
            HomepageObj = new HomePageClass(Driver);
            ApObj = new AlertPage(Driver);
            AaObj = new AllAlerts(Driver);

        }

        [Test, Order(4)]
        public void AlertVerification()
        {
             LogFilesGeneration();
            HomepageObj.ClickOnAlertTab();
            ApObj.Click_On_Alert();
            AaObj.AcceptAlert();
            logger.Info(message: "Alert Fuction Verified");
            test.Log(Status.Info,"Alert function Verified");
        }
    }
}