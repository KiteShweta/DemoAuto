using DemoQa.BaseClass;
using DemoQa.Pages;

namespace DemoQa.Test
{
    public class FormPageTest:UtilityClass
    {
        HomePageClass HpObj;
        FormPage Fp;
        [SetUp]
        public void setUp3()
        {
            HpObj = new HomePageClass(Driver);
            Fp = new FormPage(Driver);
        }
        
        [Test,Order(5)]
        public void verifyForm()
        {
            HpObj.ClickOnFormTab();
            Fp.practiceForm();
            logger.Info(message:"Practice form is verified");
            
        }
    }
}