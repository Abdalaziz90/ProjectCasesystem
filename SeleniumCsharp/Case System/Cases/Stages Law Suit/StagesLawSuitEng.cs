using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Collections.ObjectModel;
using NUnit.Framework;
using System;
using System.IO;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Interactions;
using NUnit.Allure.Core;
using NUnit.Allure.Attributes;
using FluentAssertions.Execution;
using AventStack.ExtentReports;
using AventStack.ExtentReports.Reporter;
using Microsoft.VisualBasic;

namespace JUSTDEVELOPMENT.Case_System.Cases.Stages_Law_Suit
{

    [TestFixture]
    [Parallelizable(ParallelScope.Fixtures)]
    [AllureNUnit]
    [AllureSuite("Stage law Suit Page")]
    [AllureFeature("Stage law Suit Page")]
    [AllureEpic("Case System features")]
    public class TestsStagesLawSuit
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

            using var _ = new AssertionScope();

            // SignUp >>
            //Thread.Sleep(30000);
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.XPath("//*[@id=\"form3Example3\"]")));
            driver.FindElement(By.XPath("//input[@id='form3Example3']")).SendKeys("admin");
            driver.FindElement(By.XPath("//input[@id='form3Example4']")).SendKeys("123456");
            driver.FindElement(By.XPath("//button[@class='btn btn-primary btn-lg']")).Click();

            // Language >>
            Thread.Sleep(30000);
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.XPath("//*[@id=\"app\"]/div[2]/nav/div/ul[2]/li[3]/a")));
            driver.FindElement(By.XPath("//*[@id=\"app\"]/div[2]/nav/div/ul[2]/li[3]/a")).Click();
            driver.FindElement(By.XPath("//*[@id=\"app\"]/div[2]/nav/div/ul[2]/li[3]/div/a")).Click();


            // Click on Case System and Cases >>

            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.XPath("//body/div[@id='app']/div[contains(@class,'wrapper')]/aside[contains(@class,'main-sidebar sidebar-bg-dark sidebar-color-primary shadow')]/div[contains(@class,'sidebar')]/nav[contains(@class,'mt-2')]/ul[contains(@role,'menu')]/li[8]/a[1]")));
            driver.FindElement(By.XPath("//body/div[@id='app']/div[contains(@class,'wrapper')]/aside[contains(@class,'main-sidebar sidebar-bg-dark sidebar-color-primary shadow')]/div[contains(@class,'sidebar')]/nav[contains(@class,'mt-2')]/ul[contains(@role,'menu')]/li[8]/a[1]")).Click();
            Thread.Sleep(3000);
            driver.FindElement(By.XPath("//*[@id=\"app\"]/div[2]/aside/div[2]/nav/ul/li[8]/ul/li/a")).Click();


            // Stages Law Suit >>
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.XPath("//*[@id=\"app\"]/div[2]/aside/div[2]/nav/ul/li[8]/ul/li/ul[2]/li/a")));
            Thread.Sleep(5000);
            driver.FindElement(By.XPath("//*[@id=\"app\"]/div[2]/aside/div[2]/nav/ul/li[8]/ul/li/ul[2]/li/a")).Click();
            driver.FindElement(By.XPath("//*[@id=\"app\"]/div[2]/aside/div[2]/nav/ul/li[8]/ul/li/ul[2]/li/a")).Click();
            driver.FindElement(By.XPath("//*[@id=\"app\"]/div[2]/aside/div[2]/nav/ul/li[8]/ul/li/ul[2]/li/a")).Click();

            // ADD >>
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.XPath("//button[@class='e-control e-btn e-lib btn btn-outline-success']")));
            Thread.Sleep(5000);
            driver.FindElement(By.XPath("//button[@class='e-control e-btn e-lib btn btn-outline-success']")).Click();

            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.XPath("//span[@role='combobox']")));
            IWebElement caseNumber = driver.FindElement(By.XPath("//span[@role='combobox']"));
            caseNumber.Click();

            String[] caseNumberText = {"14444", "1", "4445555566", "هه" };

            if (caseNumberText.Length > 0)
            {
                Random rand = new Random();
                int randNumber = rand.Next(0, caseNumberText.Length);
                caseNumber.SendKeys(caseNumberText[randNumber] + Keys.Enter);
                Console.WriteLine(caseNumberText[randNumber]);
                driver.FindElement(By.Id("STAGENAME")).SendKeys("case");
                driver.FindElement(By.Id("NAMEJUDGMENT")).SendKeys("324");
                driver.FindElement(By.Id("SUMMARYJUDGMENT")).SendKeys("stages case");

                //Date >>
                IWebElement RegistrationDateEng = driver.FindElement(By.Id("RULINGDATE"));
                RegistrationDateEng.Clear();
                RegistrationDateEng.Clear();
                RegistrationDateEng.SendKeys("11/11/2023");

                driver.FindElement(By.Id("CASESTAGENO")).SendKeys(caseNumberText[randNumber]);
                driver.FindElement(By.Id("JUDGETYPE")).SendKeys("law");

                Thread.Sleep(5000);
                wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.XPath("//button[@type='Syncfusion.Blazor.Popups.ButtonType.Submit']")));
                driver.FindElement(By.XPath("//button[@type='Syncfusion.Blazor.Popups.ButtonType.Submit']")).Click();
                wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.XPath("//button[normalize-space()='CANCEL']")));
                Thread.Sleep(5000);
                driver.FindElement(By.XPath("//button[normalize-space()='CANCEL']")).Click();

                // Edit >>
                Thread.Sleep(5000);
                wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.Id("edit")));
                driver.FindElement(By.Id("edit")).Click();
                wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.Id("NAMEJUDGMENT")));
                Thread.Sleep(3000);
                driver.FindElement(By.Id("NAMEJUDGMENT")).Clear();
                driver.FindElement(By.Id("NAMEJUDGMENT")).SendKeys("554");
                wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.Id("SUMMARYJUDGMENT")));
                Thread.Sleep(3000);
                driver.FindElement(By.Id("SUMMARYJUDGMENT")).Clear();
                driver.FindElement(By.Id("SUMMARYJUDGMENT")).SendKeys("case info");
                Thread.Sleep(5000);

                wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.Id("RULINGDATE")));
                IWebElement RegistrationDateEng1 = driver.FindElement(By.Id("RULINGDATE"));
                string dateTextActual = RegistrationDateEng1.GetAttribute("value");
                Console.WriteLine(dateTextActual);
                string dateTextExpect = "11/11/2023";

                string cardTitleActual = driver.FindElement(By.XPath("//h4[@class='card-title']")).Text;
                Console.WriteLine(cardTitleActual);
                string cardTitleExpect = "StagesLawsuit";



                Thread.Sleep(5000);
                wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.XPath("//button[normalize-space()='EDIT']")));
                driver.FindElement(By.XPath("//button[normalize-space()='EDIT']")).Click();
                Thread.Sleep(5000);


                // POST >>
                wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.XPath("//*[@id=\"Grid_content_table\"]/tbody/tr[1]/td[1]/div")));
                Thread.Sleep(7000);
                driver.FindElement(By.XPath("//*[@id=\"Grid_content_table\"]/tbody/tr[1]/td[1]/div")).Click();
                Thread.Sleep(5000);
                driver.FindElement(By.XPath("//*[@id=\"app\"]/div[2]/main/div[2]/div/div/div[2]/div[1]/div/button[2]")).Click();
                Thread.Sleep(5000);
                driver.FindElement(By.XPath("//button[normalize-space()='OK']")).Click();
                Thread.Sleep(5000);


                // UNPOST >>
                wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.XPath("//*[@id=\"Grid_content_table\"]/tbody/tr[1]/td[1]/div")));
                Thread.Sleep(7000);
                driver.FindElement(By.XPath("//*[@id=\"Grid_content_table\"]/tbody/tr[1]/td[1]/div")).Click();
                Thread.Sleep(5000);
                driver.FindElement(By.XPath("//*[@id=\"app\"]/div[2]/main/div[2]/div/div/div[2]/div[1]/div/button[3]")).Click();
                Thread.Sleep(5000);
                driver.FindElement(By.XPath("//button[normalize-space()='OK']")).Click();
                Thread.Sleep(5000);

                // POST >>
                wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.XPath("//*[@id=\"Grid_content_table\"]/tbody/tr[1]/td[1]/div")));
                Thread.Sleep(7000);
                driver.FindElement(By.XPath("//*[@id=\"Grid_content_table\"]/tbody/tr[1]/td[1]/div")).Click();
                Thread.Sleep(5000);
                driver.FindElement(By.XPath("//*[@id=\"app\"]/div[2]/main/div[2]/div/div/div[2]/div[1]/div/button[2]")).Click();
                Thread.Sleep(5000);
                driver.FindElement(By.XPath("//button[normalize-space()='OK']")).Click();
                Thread.Sleep(5000);


                // Delete >>
                wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.XPath("//*[@id=\"Grid_content_table\"]/tbody/tr[1]/td[1]/div")));
                Thread.Sleep(7000);
                driver.FindElement(By.XPath("//*[@id=\"Grid_content_table\"]/tbody/tr[1]/td[1]/div")).Click();
                Thread.Sleep(5000);
                driver.FindElement(By.XPath("//*[@id=\"app\"]/div[2]/main/div[2]/div/div/div[2]/div[1]/div/button[1]")).Click();
                Thread.Sleep(5000);
                driver.FindElement(By.XPath("//button[normalize-space()='OK']")).Click();
                Thread.Sleep(5000);

                // Edit >>
                driver.FindElement(By.Id("edit")).Click();
                Thread.Sleep(3000);
                driver.FindElement(By.Id("NAMEJUDGMENT")).Clear();
                driver.FindElement(By.Id("NAMEJUDGMENT")).SendKeys("775");
                Thread.Sleep(3000);
                driver.FindElement(By.Id("SUMMARYJUDGMENT")).Clear();
                driver.FindElement(By.Id("SUMMARYJUDGMENT")).SendKeys("case law");
                driver.FindElement(By.XPath("//button[normalize-space()='EDIT']")).Click();
                Thread.Sleep(5000);
                driver.FindElement(By.XPath("//button[normalize-space()='CANCEL']")).Click();
                Thread.Sleep(5000);

                // UNPOST >>
                wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.XPath("//*[@id=\"Grid_content_table\"]/tbody/tr[1]/td[1]/div")));
                Thread.Sleep(7000);
                driver.FindElement(By.XPath("//*[@id=\"Grid_content_table\"]/tbody/tr[1]/td[1]/div")).Click();
                Thread.Sleep(5000);
                driver.FindElement(By.XPath("//*[@id=\"app\"]/div[2]/main/div[2]/div/div/div[2]/div[1]/div/button[3]")).Click();
                Thread.Sleep(5000);
                driver.FindElement(By.XPath("//button[normalize-space()='OK']")).Click();

                // Delete >>
                wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.XPath("//*[@id=\"Grid_content_table\"]/tbody/tr[1]/td[1]/div")));
                Thread.Sleep(7000);
                driver.FindElement(By.XPath("//*[@id=\"Grid_content_table\"]/tbody/tr[1]/td[1]/div")).Click();
                Thread.Sleep(5000);
                driver.FindElement(By.XPath("//*[@id=\"app\"]/div[2]/main/div[2]/div/div/div[2]/div[1]/div/button[1]")).Click();
                Thread.Sleep(5000);
                driver.FindElement(By.XPath("//button[normalize-space()='OK']")).Click();


                // Search Input >>
                Thread.Sleep(3000);
                driver.FindElement(By.Id("Grid_ToolbarSearchBox")).SendKeys("sdad" + Keys.Enter);
                Thread.Sleep(3000);
                driver.FindElement(By.XPath("//*[@id=\"Grid_search\"]/div/span/span[1]")).Click();

                // Sorting from lowest to highest
                Thread.Sleep(5000);
                driver.FindElement(By.XPath("//*[@id=\"Grid_header_table\"]/thead/tr/th[4]/div[1]")).Click();

                // Filters Selected
                Thread.Sleep(5000);
                driver.FindElement(By.XPath("//*[@id=\"Grid_header_table\"]/thead/tr/th[5]/div[3]")).Click();
                driver.FindElement(By.XPath("//*[@id=\"Gridstring_CheckBoxList\"]/div[2]")).Click();
                driver.FindElement(By.XPath("//*[@id=\"Gridstring_CheckBoxList\"]/div[3]")).Click();
                driver.FindElement(By.XPath("//button[normalize-space()='OK']")).Click();

                // Clear filter >>
                Thread.Sleep(5000);
                driver.FindElement(By.XPath("//*[@id=\"Grid_header_table\"]/thead/tr/th[5]/div[3]")).Click();
                Thread.Sleep(7000);
                driver.FindElement(By.XPath("//li[@aria-label='Clear Filter']")).Click();

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
                wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.XPath("//*[@id=\"app\"]/div[2]/main/div[2]/div/div/div[2]/button[2]")));
                driver.FindElement(By.XPath("//*[@id=\"app\"]/div[2]/main/div[2]/div/div/div[2]/button[2]")).Click();

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