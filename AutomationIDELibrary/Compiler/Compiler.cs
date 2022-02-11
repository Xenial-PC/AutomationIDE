using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows.Forms;
using AutomationIDELibrary.ReservedKeyWords;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using System.IO;
using OpenQA.Selenium;

namespace AutomationIDELibrary.Compiler
{
    public class Compiler
    {
        public static List<string> Lines = new List<string>();
        public FirefoxDriver FireFoxDriver;
        public ChromeDriver ChromeDriver;
        private bool _dispose = true;

        public void BuildFireFox(string webpage = null)
        {
            new Compiler().StartFireFoxDriversAsync(webpage);
        }

        public void BuildChrome(string webpage = null)
        {
            new Compiler().StartChromeDriversAsync(webpage);
        }

        public void ReadScript()
        {
            if (!Directory.Exists("Project")) return;
            foreach (var file in Directory.GetFiles("Project"))
            {
                if (!file.Contains(".AL")) continue;
                foreach (var line in File.ReadAllLines(file)) Lines.Add(line);
            }
        }

        public Task StartChromeDriversAsync(string webpage = null)
        {
            var options = new ChromeOptions();
            ChromeDriver = new ChromeDriver(options);
            var chromeDriverWait = new WebDriverWait(ChromeDriver, TimeSpan.FromSeconds(15));
            BaseDriversTask(driver:ChromeDriver, webDriverWait:chromeDriverWait, chromeOptions:options, webpage: webpage);
            return Task.CompletedTask;
        }

        public Task StartFireFoxDriversAsync(string webpage = null)
        {
            var options = new FirefoxOptions();
            FireFoxDriver = new FirefoxDriver(options);
            var fireFoxDriverWait = new WebDriverWait(FireFoxDriver, TimeSpan.FromSeconds(15));
            BaseDriversTask(driver:FireFoxDriver, webDriverWait:fireFoxDriverWait, firefoxOptions:options, webpage: webpage);
            return Task.CompletedTask;
        }

        public Task BaseDriversTask(IWebDriver driver, WebDriverWait webDriverWait, FirefoxOptions firefoxOptions = null, ChromeOptions chromeOptions = null, string webpage = null)
        {
            if (webpage == null)
                if (Lines[0].StartsWith("--target", StringComparison.Ordinal)) webpage = Lines[0].Remove(0, 8);
            if (Lines.Contains("--headless"))
            {
                firefoxOptions?.AddArguments("--headless");
                chromeOptions?.AddArguments("--headless");
            }

            if (Lines.Contains("--noDispose")) _dispose = false; 
            driver.Navigate().GoToUrl(webpage);

            var function = new Functions();
            foreach (var line in Lines)
            {
                if (line.Contains("Click")) function.ClickAsync(line, webDriverWait);
                else if (line.Contains("SendKeys")) function.SendKeysAsync(line, webDriverWait);
                else if (line.Contains("Submit")) function.SubmitAsync(line, webDriverWait);
                else if (line.Contains("Redirect")) function.RedirectAsync(line, driver); 
                else if (line.Contains("JScript")) function.InjectJavaScriptAsync(line, driver);
                else if (line.Contains("Sleep")) function.SleepAsync(line);
                else if (line.Contains("Message")) function.MessageBoxAsync(line);
            }

            Lines.RemoveRange(0, Lines.Count);
            if (_dispose) driver.Dispose();
            return Task.CompletedTask;
        }

        public Task ReadTextBoxLinesAsync(TextBox textBox)
        {
            foreach (var line in textBox.Lines) Lines.Add(line);
            return Task.CompletedTask;
        }
    }
}