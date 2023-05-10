using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium;
using log4net;
using log4net.Config;
using AventStack.ExtentReports;
using AventStack.ExtentReports.Reporter;
using OpenQA.Selenium.Support.UI;

namespace DemoQa.BaseClass
{
    public class UtilityClass
    {
      public ILog logger = LogManager.GetLogger(typeof(UtilityClass));
       public IWebDriver Driver;
       public ExtentTest test;
       public ExtentHtmlReporter htmlReporter;
       public ExtentReports reports;
       public string HomePageUrl = "https://demoqa.com/";
       
        [SetUp]
        public void LaunchBrowser()
        {
            test.Log(Status.Info,"BrowserLaunch");
            logger.Info(message:"BrowserLaunch");
            Driver = Browsers("Chrome");       
            Driver.Manage().Window.Maximize();
            Driver.Manage().Cookies.DeleteAllCookies();
            Driver.Url = HomePageUrl;
        }

        public IWebDriver Browsers(string browser)
        {

            if (browser.Equals("Chrome"))
            {
                Driver = new ChromeDriver(@"C:\Driver");
            }
            else if(browser.Equals("Edge")) {
                Driver = new EdgeDriver();
            }
            else {
                Driver = null;
            }
            return Driver;
        }
        [OneTimeSetUp]
        public void ExtentReporter()
        {
            htmlReporter = 
                 new ExtentHtmlReporter(@"C:\Users\ShwetaT2\Documents\C#Training\DemoQa\ExtentReports\file.html");
             reports = new ExtentReports();
             reports.AttachReporter(htmlReporter);
             test = reports.CreateTest(TestContext.CurrentContext.Test.Name);
            
        }
      

        public static void LogFilesGeneration()
        {
            using(log4net.NDC.Push(Guid.NewGuid().ToString()));
            object value = BasicConfigurator.Configure();
        }
         public static string ScreenShotMethod(IWebDriver driver, string filename)
         {
            ITakesScreenshot screenshot=(ITakesScreenshot)driver;
            Screenshot ss=screenshot.GetScreenshot();
            string path=filename+DateTime.Now.ToString("yyyy-mm-dd-HH_mm_ss");
            string filepath=@"C:\Users\ShwetaT2\Documents\C#Training\DemoQa\Screenshot\test.png";
            ss.SaveAsFile(filepath,ScreenshotImageFormat.Png);
            return filepath;

         }
         [OneTimeTearDown]
        public void ExtentReportClose()
        {
            reports.Flush();
        }

        [TearDown]
       public void endTest()
       {
         test.Log(Status.Info,"End Test");
          logger.Info(message:"Test End");
        Driver.Close();
       }
    }
}