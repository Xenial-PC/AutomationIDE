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

        public static void BuildFireFox(string webpage = null)
        {
            var compiler = new Compiler();
            compiler.StartFireFoxDriversAsync(webpage);
        }

        public static void BuildChrome(string webpage = null)
        {
            var compiler = new Compiler();
            compiler.StartChromeDriversAsync(webpage);
        }

        public static void Build()
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
            BaseDriversTask(ChromeDriver, chromeDriverWait, chromeOptions: options, webpage: webpage);
            return Task.CompletedTask;
        }

        public Task StartFireFoxDriversAsync(string webpage = null)
        {
            var options = new FirefoxOptions();
            FireFoxDriver = new FirefoxDriver(options);
            var fireFoxDriverWait = new WebDriverWait(FireFoxDriver, TimeSpan.FromSeconds(15));
            BaseDriversTask(FireFoxDriver, fireFoxDriverWait, options, webpage: webpage);
            return Task.CompletedTask;
        }

        public Task BaseDriversTask(IWebDriver driver, WebDriverWait webDriverWait, FirefoxOptions firefoxOptions = null, ChromeOptions chromeOptions = null, string webpage = null)
        {
            Lines.ForEach(line => { if (line.StartsWith("--target", StringComparison.Ordinal)) webpage = line.Remove(0, 8); });
            if (Lines.Contains("--headless")) 
            {
                firefoxOptions?.AddArguments("--headless");
                chromeOptions?.AddArguments("--headless");
            }
            if (Lines.Contains("--noDispose")) _dispose = false;
            var function = new Functions();
            driver.Navigate().GoToUrl(webpage);
            foreach (var line in Lines)
            {
                switch (line)
                {
                    case string l when l.Contains("Click"): function.ClickAsync(line, webDriverWait); break;
                    case string l when l.Contains("SendKeys"): function.SendKeysAsync(line, webDriverWait); break;
                    case string l when l.Contains("Submit"): function.SubmitAsync(line, webDriverWait); break;
                }
            }
            Lines.RemoveRange(0, Lines.Count);
            if (_dispose) driver.Dispose();
            return Task.CompletedTask;
        }

        public static Task ReadTextBoxLinesAsync(TextBox textBox)
        {
            foreach (var line in textBox.Lines) Lines.Add(line);
            return Task.CompletedTask;
        }
    }
}