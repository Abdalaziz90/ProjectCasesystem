using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium;
using System;
using System.Text;
using System.Threading.Tasks;
using NUnit.Allure.Attributes;
using NUnit.Allure.Core;

namespace JUSTDEVELOPMENT.Case_System.Cases.Defendant_Arabic
{
    [TestFixture]
    [Parallelizable(ParallelScope.Fixtures)]
    [AllureNUnit]
    [AllureSuite("Defendant Page")]
    [AllureFeature("Defendant Page")]
    [AllureEpic("Case System features")]

    public class TestsDefendantArabic
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
        public void DefendantPage()
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
            Thread.Sleep(5000);
            driver.FindElement(By.XPath("//*[@id=\"app\"]/div[2]/aside/div[2]/nav/ul/li[8]/ul/li/a")).Click();


            // Defendant >>
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.XPath("//*[@id=\"app\"]/div[2]/aside/div[2]/nav/ul/li[8]/ul/li/ul[8]/li/a")));
            Thread.Sleep(5000);
            driver.FindElement(By.XPath("//*[@id=\"app\"]/div[2]/aside/div[2]/nav/ul/li[8]/ul/li/ul[8]/li/a")).Click();

            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.XPath("//*[@id=\"app\"]/div[2]/main/div[2]/div/div/div[2]/p")));
            string addressPageActul = driver.FindElement(By.XPath("//*[@id=\"app\"]/div[2]/main/div[2]/div/div/div[2]/p")).Text;
            Console.WriteLine(addressPageActul);
            Assert.That(addressPageActul, Is.EqualTo("There is exist address page"));

            Assert.Pass();


        }
    }
}