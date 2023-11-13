using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium;
using System;
using System.Text;
using System.Threading.Tasks;
using NUnit.Allure.Attributes;
using NUnit.Allure.Core;

namespace JUSTDEVELOPMENT.Case_System.Cases.Stages_Law_Suit
{
    [TestFixture]
    [Parallelizable(ParallelScope.Fixtures)]
    [AllureNUnit]
    [AllureSuite("Stage law Suit Page")]
    [AllureFeature("Stage law Suit Page")]
    [AllureEpic("Case System features")]

    public class TestsStagesLawsuitArabic
    {

        public IWebDriver driver; 


        [SetUp]
        public void Setup()
        {

            driver = new ChromeDriver();
        }

        [Test]
        [AllureStory("Valid date in edit page and card title in the page")]
        [AllureStep("valid date in edit page and card title in the page")]
        public void StagesLawSuitPage()
        { 

            driver.Manage().Window.Maximize();

            driver.Navigate().GoToUrl("https://app.abuhelwafamily.com/");

            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(50));

            // SignUp >>
            //Thread.Sleep(30000);
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.XPath("//*[@id=\"form3Example3\"]")));
            driver.FindElement(By.XPath("//input[@id='form3Example3']")).SendKeys("admin");
            driver.FindElement(By.XPath("//input[@id='form3Example4']")).SendKeys("123456");
            driver.FindElement(By.XPath("//button[@class='btn btn-primary btn-lg']")).Click();

            // Click on Case System and Cases >>

            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.XPath("//body/div[@id='app']/div[contains(@class,'wrapper')]/aside[contains(@class,'main-sidebar sidebar-bg-dark sidebar-color-primary shadow')]/div[contains(@class,'sidebar')]/nav[contains(@class,'mt-2')]/ul[contains(@role,'menu')]/li[8]/a[1]")));
            driver.FindElement(By.XPath("//body/div[@id='app']/div[contains(@class,'wrapper')]/aside[contains(@class,'main-sidebar sidebar-bg-dark sidebar-color-primary shadow')]/div[contains(@class,'sidebar')]/nav[contains(@class,'mt-2')]/ul[contains(@role,'menu')]/li[8]/a[1]")).Click();
            Thread.Sleep(5000);
            driver.FindElement(By.XPath("//*[@id=\"app\"]/div[2]/aside/div[2]/nav/ul/li[8]/ul/li/a")).Click();


            // Stages Law Suit >>
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.XPath("//*[@id=\"app\"]/div[2]/aside/div[2]/nav/ul/li[8]/ul/li/ul[2]/li/a")));
            Thread.Sleep(5000);
            driver.FindElement(By.XPath("//*[@id=\"app\"]/div[2]/aside/div[2]/nav/ul/li[8]/ul/li/ul[2]/li/a")).Click();
            driver.FindElement(By.XPath("//*[@id=\"app\"]/div[2]/aside/div[2]/nav/ul/li[8]/ul/li/ul[2]/li/a")).Click();
            driver.FindElement(By.XPath("//*[@id=\"app\"]/div[2]/aside/div[2]/nav/ul/li[8]/ul/li/ul[2]/li/a")).Click();

            // ADD >>
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.XPath("//button[@class='e-control e-btn e-lib btn btn-outline-success']")));
            Thread.Sleep(3000);
            driver.FindElement(By.XPath("//button[@class='e-control e-btn e-lib btn btn-outline-success']")).Click();

            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.XPath("//span[@role='combobox']")));
            IWebElement caseNumber = driver.FindElement(By.XPath("//span[@role='combobox']"));
            caseNumber.Click();

            String[] caseNumberText = { "14444", "1", "4445555566", "هه" };

            if (caseNumberText.Length > 0)
            {
                Random rand = new Random();
                int randNumber = rand.Next(0, caseNumberText.Length);
                caseNumber.SendKeys(caseNumberText[randNumber] + Keys.Enter);
                Console.WriteLine(caseNumberText[randNumber]);
                driver.FindElement(By.Id("STAGENAME")).SendKeys("اسم المرحلة");
                driver.FindElement(By.Id("NAMEJUDGMENT")).SendKeys("٢٠٢");
                driver.FindElement(By.Id("SUMMARYJUDGMENT")).SendKeys("خلاصة الحكم");

                //Date >>
                IWebElement RegistrationDateEng = driver.FindElement(By.Id("RULINGDATE"));
                RegistrationDateEng.Clear();
                RegistrationDateEng.Clear();
                RegistrationDateEng.SendKeys("١١/١١/٢٠٢٣");

                driver.FindElement(By.Id("CASESTAGENO")).SendKeys(caseNumberText[randNumber]);
                driver.FindElement(By.Id("JUDGETYPE")).SendKeys("نوع الحكم");

                Thread.Sleep(5000);
                wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.XPath("//button[@type='Syncfusion.Blazor.Popups.ButtonType.Submit']")));

                driver.FindElement(By.XPath("//button[@type='Syncfusion.Blazor.Popups.ButtonType.Submit']")).Click();
                wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.XPath("//div[@class='e-footer-content']//button[@class='e-control e-btn e-lib btn btn-outline-danger'][contains(text(),'إلغاء')]")));
                Thread.Sleep(5000);
                driver.FindElement(By.XPath("//div[@class='e-footer-content']//button[@class='e-control e-btn e-lib btn btn-outline-danger'][contains(text(),'إلغاء')]")).Click();

                // Edit >>
                Thread.Sleep(5000);
                wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.Id("edit")));
                driver.FindElement(By.Id("edit")).Click();
                wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.Id("NAMEJUDGMENT")));
                Thread.Sleep(3000);
                driver.FindElement(By.Id("NAMEJUDGMENT")).Clear();
                driver.FindElement(By.Id("NAMEJUDGMENT")).SendKeys("١١");
                wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.Id("SUMMARYJUDGMENT")));
                Thread.Sleep(3000);
                driver.FindElement(By.Id("SUMMARYJUDGMENT")).Clear();
                driver.FindElement(By.Id("SUMMARYJUDGMENT")).SendKeys("الحكم");
                Thread.Sleep(5000);

                wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.Id("RULINGDATE")));
                IWebElement RegistrationDateEng1 = driver.FindElement(By.Id("RULINGDATE"));
                string dateTextActual = RegistrationDateEng1.GetAttribute("value");
                Console.WriteLine(dateTextActual);
                string dateTextExpect = "١١/١١/٢٠٢٣";

                string cardTitleActual = driver.FindElement(By.XPath("//h4[@class='card-title']")).Text;
                Console.WriteLine(cardTitleActual);
                string cardTitleExpect = "مراحل الدعوى";

                Thread.Sleep(5000);
                wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.XPath("//button[contains(text(),'تعديل')]")));
                driver.FindElement(By.XPath("//button[contains(text(),'تعديل')]")).Click();
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
                driver.FindElement(By.Id("NAMEJUDGMENT")).Clear();
                driver.FindElement(By.Id("NAMEJUDGMENT")).SendKeys("٢٣");
                Thread.Sleep(3000);
                driver.FindElement(By.Id("SUMMARYJUDGMENT")).Clear();
                driver.FindElement(By.Id("SUMMARYJUDGMENT")).SendKeys("نوع");
                driver.FindElement(By.XPath("//button[contains(text(),'تعديل')]")).Click();
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

                Assert.Multiple(() => {
                    Assert.That(dateTextActual, Is.EqualTo(dateTextExpect));

                    Assert.That(cardTitleActual, Is.EqualTo(cardTitleExpect));
                });

                Assert.Pass();
           
                }
                else
                {
                    Console.WriteLine("Case number is not records");
                }

        }
    }
}