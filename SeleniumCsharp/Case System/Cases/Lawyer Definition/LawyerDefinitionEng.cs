﻿using FluentAssertions.Execution;
using NUnit.Allure.Attributes;
using NUnit.Allure.Core;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JUSTDEVELOPMENT.Case_System.Cases.Lawyer_Definition_Eng
{
    [TestFixture]
    [Parallelizable(ParallelScope.Fixtures)]
    [AllureNUnit]
    [AllureSuite("Lawyer Definition Page")]
    [AllureFeature("Lawyer Definition Page")]
    [AllureEpic("Case System features")]
    public class TestsLawyerDefinition
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
        public void LawyerDefinitionPage()
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


            // Lawyer Definition >>
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.XPath("//*[@id=\"app\"]/div[2]/aside/div[2]/nav/ul/li[8]/ul/li/ul[10]/li/a")));
            Thread.Sleep(5000);
            driver.FindElement(By.XPath("//*[@id=\"app\"]/div[2]/aside/div[2]/nav/ul/li[8]/ul/li/ul[10]/li/a")).Click();
            driver.FindElement(By.XPath("//*[@id=\"app\"]/div[2]/aside/div[2]/nav/ul/li[8]/ul/li/ul[10]/li/a")).Click();
            driver.FindElement(By.XPath("//*[@id=\"app\"]/div[2]/aside/div[2]/nav/ul/li[8]/ul/li/ul[10]/li/a")).Click();

            // ADD >>
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.XPath("//button[@class='e-control e-btn e-lib btn btn-outline-success']")));
            Thread.Sleep(5000);
            driver.FindElement(By.XPath("//button[@class='e-control e-btn e-lib btn btn-outline-success']")).Click();

            driver.FindElement(By.Id("ARNAME")).SendKeys("Arabic Name");
            driver.FindElement(By.Id("MOBILE")).SendKeys("07xxxxxxxx");
            driver.FindElement(By.Id("EMAIL")).SendKeys("****@yahoo.com");
            driver.FindElement(By.Id("UNIONNUM")).SendKeys("23");
            driver.FindElement(By.Id("USERNAME")).SendKeys("User Name");
            driver.FindElement(By.Id("PASSWORD")).SendKeys("23233");

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
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.Id("UNIONNUM")));
            Thread.Sleep(3000);
            driver.FindElement(By.Id("UNIONNUM")).Clear();
            driver.FindElement(By.Id("UNIONNUM")).SendKeys("54");
            Thread.Sleep(5000);

            Thread.Sleep(5000);
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.XPath("//button[normalize-space()='EDIT']")));
            driver.FindElement(By.XPath("//button[normalize-space()='EDIT']")).Click();
            Thread.Sleep(7000);


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
            driver.FindElement(By.Id("USERNAME")).Clear();
            driver.FindElement(By.Id("USERNAME")).SendKeys("User");
            driver.FindElement(By.XPath("//button[normalize-space()='EDIT']")).Click();
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


            Assert.Pass();

        }
    }
}
