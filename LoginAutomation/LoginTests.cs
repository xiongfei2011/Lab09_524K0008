using Allure.Xunit.Attributes;
using CsvHelper;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using Xunit;
using Allure.Net.Commons;

namespace LoginAutomation
{
    [AllureSuite("Login Suite")]
    [AllureFeature("Login Feature")]
    public class LoginTests
    {
        public static IEnumerable<object[]> GetTestData()
        {
            using (var reader = new StreamReader("LoginTestData.csv"))
            using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
            {
                foreach (var record in csv.GetRecords<TestData>())
                {
                    yield return new object[] { record.Username, record.Password };
                }
            }
        }

        [Theory]
        [MemberData(nameof(GetTestData))]
        [AllureSeverity(SeverityLevel.critical)]
        [AllureStory("Login with valid credentials")]
        public void LoginTest(string username, string password)
        {
            using (IWebDriver driver = new ChromeDriver())
            {
                driver.Navigate().GoToUrl("file:///F:/SE_Lab/Lab09_524K0008/LoginAutomation/login.html");

                driver.FindElement(By.Id("username")).SendKeys(username);
                driver.FindElement(By.Id("password")).SendKeys(password);
                driver.FindElement(By.Id("loginButton")).Click();

                System.Threading.Thread.Sleep(2000);
            }
        }

        public class TestData
        {
            public string Username { get; set; }
            public string Password { get; set; }
        }
    }
}
