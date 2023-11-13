using NUnit.Allure.Attributes;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Allure.Core;
using OpenQA.Selenium.Support.UI;

namespace JUSTDEVELOPMENT.Case_System.Cases.Case_Info
{
    [TestFixture]
    [Parallelizable(ParallelScope.Fixtures)]
    [AllureNUnit]
    [AllureSuite("Case Info Page")]
    [AllureFeature("Case Info Page")]
    [AllureEpic("Case System features")]
    public class TestCaseInfoArabic
    {
        public IWebDriver driver;


        [SetUp]
        public void Setup()
        {
            driver = new ChromeDriver();
        }

        [Test]
        [AllureStory("")]
        [AllureStep("")]
        public void CaseInfoPage()
        {
            driver.Manage().Window.Maximize();

            driver.Navigate().GoToUrl("https://app.abuhelwafamily.com/");

            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(60));

            // SignUp >>
            //Thread.Sleep(30000);
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.XPath("//*[@id=\"form3Example3\"]")));
            driver.FindElement(By.XPath("//input[@id='form3Example3']")).SendKeys("admin");
            driver.FindElement(By.XPath("//input[@id='form3Example4']")).SendKeys("123456");
            driver.FindElement(By.XPath("//button[@class='btn btn-primary btn-lg']")).Click();

            // Click on Case System and Cases >>

            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.XPath("//body/div[@id='app']/div[contains(@class,'wrapper')]/aside[contains(@class,'main-sidebar sidebar-bg-dark sidebar-color-primary shadow')]/div[contains(@class,'sidebar')]/nav[contains(@class,'mt-2')]/ul[contains(@role,'menu')]/li[8]/a[1]")));
            driver.FindElement(By.XPath("//body/div[@id='app']/div[contains(@class,'wrapper')]/aside[contains(@class,'main-sidebar sidebar-bg-dark sidebar-color-primary shadow')]/div[contains(@class,'sidebar')]/nav[contains(@class,'mt-2')]/ul[contains(@role,'menu')]/li[8]/a[1]")).Click();
            driver.FindElement(By.XPath("//*[@id=\"app\"]/div[2]/aside/div[2]/nav/ul/li[8]/ul/li/a")).Click();


            // Case Info >>
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.XPath("//*[@id=\"app\"]/div[2]/aside/div[2]/nav/ul/li[8]/ul/li/ul[1]/li/a")));
            Thread.Sleep(5000);
            driver.FindElement(By.XPath("//*[@id=\"app\"]/div[2]/aside/div[2]/nav/ul/li[8]/ul/li/ul[1]/li/a")).Click();
            driver.FindElement(By.XPath("//*[@id=\"app\"]/div[2]/aside/div[2]/nav/ul/li[8]/ul/li/ul[1]/li/a")).Click();
            driver.FindElement(By.XPath("//*[@id=\"app\"]/div[2]/aside/div[2]/nav/ul/li[8]/ul/li/ul[1]/li/a")).Click();

            // ADD >>
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.XPath("//button[@class='e-control e-btn e-lib btn btn-outline-success']")));
            Thread.Sleep(5000);
            driver.FindElement(By.XPath("//button[@class='e-control e-btn e-lib btn btn-outline-success']")).Click();

            //Date >>
            IWebElement RegistrationDateEng = driver.FindElement(By.Id("DELEGATIONDATE"));
            RegistrationDateEng.Clear();
            RegistrationDateEng.Clear();
            RegistrationDateEng.SendKeys("20/12/2023");

            //Court Name
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.XPath("//body[1]/div[3]/div[1]/div[2]/form[1]/div[1]/div[1]/div[2]/span[1]")));
            Thread.Sleep(5000);
            IWebElement courtName = driver.FindElement(By.XPath("//body[1]/div[3]/div[1]/div[2]/form[1]/div[1]/div[1]/div[2]/span[1]"));
            courtName.Click();
            string[] CourtNameText = { "محكمة شمال عمان", "محكمة وسط عمان" };
            if (CourtNameText.Length > 0)
            {
                Random rand = new Random();
                int randNumber = rand.Next(0, CourtNameText.Length);
                courtName.SendKeys(CourtNameText[randNumber] + Keys.Enter);
                Console.WriteLine(CourtNameText[randNumber]);
            }

            // Court Type
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.XPath("//span[@class='e-ddl e-lib valid e-input-group e-control-container e-control-wrapper e-keyboard']")));
            Thread.Sleep(5000);
            IWebElement courtType = driver.FindElement(By.XPath("//span[@class='e-ddl e-lib valid e-input-group e-control-container e-control-wrapper e-keyboard']"));
            courtType.Click();
            string[] courtTypeText = { "صلح الحقوق", "صلح الجزاء", "اعتراض", "ادارة دعوى", "بداية حقوق", "بداية جزاء", "تحقيق", "تنفيذ", "تنفيذ مدعي عام", "استئناف", "التمييز",
                                        "اذونات",
                                        "وساطة",
                                        "الطلبات",
                                        "سلطة اجور",
                                        "وزارة الصناعة والتجارة والتموين",
                                        "علامات تجارية",
                                        "امانة عمان الكبرى",
                                        "جنايات صغرى",
                                        "احوال مدنية",
                                        "اقتصادية"};

            if (courtTypeText.Length > 0)
            {
                Random rand = new Random();
                int randNumber = rand.Next(0, courtTypeText.Length);
                courtType.SendKeys(courtTypeText[randNumber] + Keys.Enter);
                Console.WriteLine(courtTypeText[randNumber]);
            }

            // Case Number
            driver.FindElement(By.Id("CASENUMBER")).SendKeys("32");
            driver.FindElement(By.Id("FOLDERNO")).SendKeys("43");
            driver.FindElement(By.Id("CASEVALUE")).SendKeys("542");

            // Case Status
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.XPath("//span[@class='e-ddl e-lib valid e-input-group e-control-container e-control-wrapper e-keyboard']")));
            Thread.Sleep(5000);
            IWebElement caseStatus = driver.FindElement(By.XPath("//span[@class='e-ddl e-lib valid e-input-group e-control-container e-control-wrapper e-keyboard']"));
            caseStatus.Click();
            string[] caseStatusText = { "منظورة", "موقوفة", "مفصولة", "منتهية", "منفذة", "مستأنفة", "مميزة", "مغلقة" };

            if (caseStatusText.Length > 0)
            {
                Random rand = new Random();
                int randNumber = rand.Next(0, caseStatusText.Length);
                caseStatus.SendKeys(caseStatusText[randNumber] + Keys.Enter);
                Console.WriteLine(caseStatusText[randNumber]);
            }

            driver.FindElement(By.Id("CASESUBJECT")).SendKeys("CASE SUBJECT");

            // client name
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.XPath("//span[@class='e-ddl e-lib valid e-input-group e-control-container e-control-wrapper e-keyboard']")));
            Thread.Sleep(5000);
            IWebElement clientName = driver.FindElement(By.XPath("//span[@class='e-ddl e-lib valid e-input-group e-control-container e-control-wrapper e-keyboard']"));
            clientName.Click();
            string[] clientNameText = { "yazan" };

            if (clientNameText.Length > 0)
            {
                Random rand = new Random();
                int randomNumber = rand.Next(0, clientNameText.Length);
                clientName.SendKeys(clientNameText[randomNumber] + Keys.Enter);
                Console.WriteLine(clientNameText[randomNumber]);
            }

            // Lawyerid 
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.XPath("//span[@class='e-ddl e-lib valid e-input-group e-control-container e-control-wrapper e-keyboard']")));
            Thread.Sleep(5000);
            IWebElement Lawyerid = driver.FindElement(By.XPath("//span[@class='e-ddl e-lib valid e-input-group e-control-container e-control-wrapper e-keyboard']"));
            Lawyerid.Click();
            string[] lawyeridName = { " " };
            if (lawyeridName.Length == 0)
            {
                Random rand = new Random();
                int randomNumber = rand.Next(0, lawyeridName.Length);
                Lawyerid.SendKeys(lawyeridName[randomNumber] + Keys.Enter);
                Console.WriteLine(lawyeridName[randomNumber]);
            }

            driver.FindElement(By.Id("RESPLAWYER")).SendKeys("RESPLAWYER");
            driver.FindElement(By.Id("CLIENTNATIONALNUM")).SendKeys("90921");
            driver.FindElement(By.Id("CLIENTADDRESS")).SendKeys("CLIENTADDRESS");

            // LICENSEOFFICERID
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.XPath("//span[@class='e-ddl e-lib valid e-input-group e-control-container e-control-wrapper e-keyboard']")));
            Thread.Sleep(5000);
            IWebElement licenseOfficeID = driver.FindElement(By.XPath("//span[@class='e-ddl e-lib valid e-input-group e-control-container e-control-wrapper e-keyboard']"));
            licenseOfficeID.Click();
            string[] licenseOfficeIDText = { "tset" };
            if (licenseOfficeIDText.Length > 0)
            {
                Random rand = new Random();
                int randomNumber = rand.Next(0, licenseOfficeIDText.Length);
                licenseOfficeID.SendKeys(licenseOfficeIDText[randomNumber] + Keys.Enter);
                Console.WriteLine(licenseOfficeIDText[randomNumber]);
            }

            // ADJECTIVE CLIENT
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.XPath("//span[@class='e-ddl e-lib valid e-input-group e-control-container e-control-wrapper e-keyboard']")));
            Thread.Sleep(5000);
            IWebElement adjectiveClient = driver.FindElement(By.XPath("//span[@class='e-ddl e-lib valid e-input-group e-control-container e-control-wrapper e-keyboard']"));
            Thread.Sleep(3000);
            adjectiveClient.Click();
            string[] adjectiveClientText = { "مدعي", "مدعي عليه", "مشتكى", "مشتكى عليه", "ظنين", "ظنين بحقه" };
            if (adjectiveClientText.Length > 0)
            {
                Random rand = new Random();
                int randomNumber = rand.Next(0, adjectiveClientText.Length);
                adjectiveClient.SendKeys(adjectiveClientText[randomNumber] + Keys.Enter);
                Console.WriteLine(adjectiveClientText[randomNumber]);
            }

            driver.FindElement(By.Id("OPPONENTNATIONALNUM")).SendKeys("432");
            driver.FindElement(By.Id("OPPONENTNAME")).SendKeys("OPPONENT NAME");
            driver.FindElement(By.XPath("//*[@id=\"OPPONENTNAME\"]")).SendKeys("ADJECTIVE OPPONENT");
            Thread.Sleep(3000);
            driver.FindElement(By.Id("OPPONENTADDRESS")).SendKeys("OPPONENT ADDRESS");
            Thread.Sleep(3000);
            driver.FindElement(By.Id("OPPONENTLAWYERNAME")).SendKeys("231");
            driver.FindElement(By.Id("OPPONENTLAWYERADDRESS")).SendKeys("OPPONENT LAWYER ADDRESS");

            Thread.Sleep(7000);
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.XPath("//button[@type='Syncfusion.Blazor.Popups.ButtonType.Submit']")));
            Thread.Sleep(7000);
            driver.FindElement(By.XPath("//button[@type='Syncfusion.Blazor.Popups.ButtonType.Submit']")).Click();
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.XPath("//div[@class='e-footer-content']//button[@class='e-control e-btn e-lib btn btn-outline-danger'][contains(text(),'إلغاء')]")));
            Thread.Sleep(5000);
            driver.FindElement(By.XPath("//div[@class='e-footer-content']//button[@class='e-control e-btn e-lib btn btn-outline-danger'][contains(text(),'إلغاء')]")).Click();

            // Edit >>
            Thread.Sleep(7000);
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.Id("edit")));
            driver.FindElement(By.Id("edit")).Click();
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.Id("CLIENTNATIONALNUM")));
            Thread.Sleep(3000);
            driver.FindElement(By.Id("CLIENTNATIONALNUM")).Clear();
            driver.FindElement(By.Id("CLIENTNATIONALNUM")).SendKeys("3942");
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.Id("CLIENTADDRESS")));
            Thread.Sleep(3000);
            driver.FindElement(By.Id("CLIENTADDRESS")).Clear();
            driver.FindElement(By.Id("CLIENTADDRESS")).SendKeys("CLIENT nat");
            Thread.Sleep(5000);
            Thread.Sleep(5000);
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.XPath("//button[contains(text(),'تعديل')]")));
            driver.FindElement(By.XPath("//button[contains(text(),'تعديل')]")).Click();
            Thread.Sleep(7000);
            driver.FindElement(By.XPath("//div[@class='e-footer-content']//button[@class='e-control e-btn e-lib btn btn-outline-danger'][contains(text(),'إلغاء')]")).Click();
            Thread.Sleep(7000);
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.XPath("//*[@id=\"Grid_content_table\"]/tbody/tr[1]/td[1]/div")));
            Thread.Sleep(10000);
            driver.FindElement(By.XPath("//*[@id=\"Grid_content_table\"]/tbody/tr[1]/td[1]/div")).Click();
            Thread.Sleep(5000);

            // POST >>
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.XPath("//*[@id=\"Grid_content_table\"]/tbody/tr[1]/td[1]/div")));
            Thread.Sleep(10000);
            driver.FindElement(By.XPath("//*[@id=\"Grid_content_table\"]/tbody/tr[1]/td[1]/div")).Click();
            Thread.Sleep(5000);
            driver.FindElement(By.XPath("//*[@id=\"app\"]/div[2]/main/div[2]/div/div/div[2]/div[1]/div/button[2]")).Click();
            Thread.Sleep(5000);
            driver.FindElement(By.XPath("//button[contains(text(),'حسنا')]")).Click();
            Thread.Sleep(5000);


            // UNPOST >>
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.XPath("//*[@id=\"Grid_content_table\"]/tbody/tr[1]/td[1]/div")));
            Thread.Sleep(7000);
            driver.FindElement(By.XPath("//*[@id=\"Grid_content_table\"]/tbody/tr[1]/td[1]/div")).Click();
            Thread.Sleep(5000);
            driver.FindElement(By.XPath("//*[@id=\"app\"]/div[2]/main/div[2]/div/div/div[2]/div[1]/div/button[3]")).Click();
            Thread.Sleep(5000);
            driver.FindElement(By.XPath("//button[contains(text(),'حسنا')]")).Click();
            Thread.Sleep(5000);

            // POST >>
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.XPath("//*[@id=\"Grid_content_table\"]/tbody/tr[1]/td[1]/div")));
            Thread.Sleep(7000);
            driver.FindElement(By.XPath("//*[@id=\"Grid_content_table\"]/tbody/tr[1]/td[1]/div")).Click();
            Thread.Sleep(5000);
            driver.FindElement(By.XPath("//*[@id=\"app\"]/div[2]/main/div[2]/div/div/div[2]/div[1]/div/button[2]")).Click();
            Thread.Sleep(5000);
            driver.FindElement(By.XPath("//button[contains(text(),'حسنا')]")).Click();
            Thread.Sleep(5000);


            // Delete >>
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.XPath("//*[@id=\"Grid_content_table\"]/tbody/tr[1]/td[1]/div")));
            Thread.Sleep(7000);
            driver.FindElement(By.XPath("//*[@id=\"Grid_content_table\"]/tbody/tr[1]/td[1]/div")).Click();
            Thread.Sleep(5000);
            driver.FindElement(By.XPath("//*[@id=\"app\"]/div[2]/main/div[2]/div/div/div[2]/div[1]/div/button[1]")).Click();
            Thread.Sleep(5000);
            driver.FindElement(By.XPath("//button[contains(text(),'حسنا')]")).Click();
            Thread.Sleep(5000);

            // Edit >>
            driver.FindElement(By.Id("edit")).Click();
            Thread.Sleep(3000);
            driver.FindElement(By.Id("OPPONENTNATIONALNUM")).Clear();
            driver.FindElement(By.Id("OPPONENTNATIONALNUM")).SendKeys("546");
            Thread.Sleep(3000);
            driver.FindElement(By.Id("RESPLAWYER")).Clear();
            driver.FindElement(By.Id("RESPLAWYER")).SendKeys("LAWYER case");
            driver.FindElement(By.XPath("//button[normalize-space()='EDIT']")).Click();
            Thread.Sleep(5000);
            driver.FindElement(By.XPath("//div[@class='e-footer-content']//button[@class='e-control e-btn e-lib btn btn-outline-danger'][contains(text(),'إلغاء')]")).Click();
            Thread.Sleep(5000);

            // UNPOST >>
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.XPath("//*[@id=\"Grid_content_table\"]/tbody/tr[1]/td[1]/div")));
            Thread.Sleep(7000);
            driver.FindElement(By.XPath("//*[@id=\"Grid_content_table\"]/tbody/tr[1]/td[1]/div")).Click();
            Thread.Sleep(5000);
            driver.FindElement(By.XPath("//*[@id=\"app\"]/div[2]/main/div[2]/div/div/div[2]/div[1]/div/button[3]")).Click();
            Thread.Sleep(5000);
            driver.FindElement(By.XPath("//button[contains(text(),'حسنا')]")).Click();


            // Delete >>
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.XPath("//*[@id=\"Grid_content_table\"]/tbody/tr[1]/td[1]/div")));
            Thread.Sleep(7000);
            driver.FindElement(By.XPath("//*[@id=\"Grid_content_table\"]/tbody/tr[1]/td[1]/div")).Click();
            Thread.Sleep(5000);
            driver.FindElement(By.XPath("//*[@id=\"app\"]/div[2]/main/div[2]/div/div/div[2]/div[1]/div/button[1]")).Click();
            Thread.Sleep(5000);
            driver.FindElement(By.XPath("//button[contains(text(),'حسنا')]")).Click();



            // Search Input >>
            Thread.Sleep(5000);
            driver.FindElement(By.Id("Grid_ToolbarSearchBox")).SendKeys("ع" + Keys.Enter);
            Thread.Sleep(5000);
            driver.FindElement(By.XPath("//*[@id=\"Grid_search\"]/div/span/span[1]")).Click();

            // Sorting from lowest to highest
            Thread.Sleep(5000);
            driver.FindElement(By.XPath("//*[@id=\"Grid_header_table\"]/thead/tr/th[4]/div[1]")).Click();

            // Filters Selected
            Thread.Sleep(5000);
            driver.FindElement(By.XPath("//*[@id=\"Grid_header_table\"]/thead/tr/th[5]/div[3]")).Click();
            driver.FindElement(By.XPath("//*[@id=\"Gridstring_CheckBoxList\"]/div[2]")).Click();
            driver.FindElement(By.XPath("//*[@id=\"Gridstring_CheckBoxList\"]/div[3]")).Click();
            driver.FindElement(By.XPath("//button[contains(text(),'حسنا')]")).Click();

            // Clear filter >>
            Thread.Sleep(5000);
            driver.FindElement(By.XPath("//*[@id=\"Grid_header_table\"]/thead/tr/th[5]/div[3]")).Click();
            Thread.Sleep(7000);
            driver.FindElement(By.XPath("//li[@aria-label='مرشح واضح']")).Click();

            // Excel Export >>
            Thread.Sleep(5000);
            driver.FindElement(By.XPath("//*[@id=\"Grid_excelexport\"]/button")).Click();

            // CSV Export >>
            Thread.Sleep(3000);
            driver.FindElement(By.XPath("//*[@id=\"Grid_csvexport\"]/button")).Click();

            // PDF Export >>
            Thread.Sleep(3000);
            driver.FindElement(By.XPath("//*[@id=\"Grid_pdfexport\"]/button")).Click();

            // Print >>
            Thread.Sleep(5000);
            driver.FindElement(By.XPath("//*[@id=\"Grid_print\"]/button")).Click();

            string currentHandle = driver.CurrentWindowHandle;
            foreach (string handle in driver.WindowHandles)
            {
                if (!handle.Equals(currentHandle))
                {
                    Thread.Sleep(5000);
                    driver.SwitchTo().Window(handle).Close();
                }
            }

            driver.SwitchTo().Window(currentHandle);


            // Report >>
            Thread.Sleep(5000);
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.XPath("//button[contains(text(),'تقرير')]")));
            driver.FindElement(By.XPath("//button[contains(text(),'تقرير')]")).Click();

            foreach (string handle in driver.WindowHandles)
            {
                if (!handle.Equals(currentHandle))
                {
                    Thread.Sleep(5000);
                    driver.SwitchTo().Window(handle).Close();
                }
            }

            driver.SwitchTo().Window(currentHandle);


            Assert.Pass();
        }
    }
}
