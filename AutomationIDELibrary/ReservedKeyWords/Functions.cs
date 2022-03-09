using System;
using System.IO;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using AutomationIDELibrary.Compiler;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;

namespace AutomationIDELibrary.ReservedKeyWords
{
    public class Functions
    {
        private IWebElement _element;
        private readonly Format _formatLine = new Format();
        #region BrowserFunctions
        public Task ClickAsync(string elementName, WebDriverWait driverWait)
        {
            ClickFuncAsync(elementName, driverWait).ConfigureAwait(true);
            return Task.CompletedTask;
        }

        public Task SendKeysAsync(string elementName, WebDriverWait driverWait)
        {
            SendKeysFuncAsync(elementName, driverWait).ConfigureAwait(true);
            return Task.CompletedTask;
        }

        public Task SubmitAsync(string elementName, WebDriverWait driverWait)
        {
            SubmitFuncAsync(elementName, driverWait).ConfigureAwait(true);
            return Task.CompletedTask;
        }

        public Task RedirectAsync(string url, IWebDriver driver)
        {
            RedirectFuncAsync(url, driver).ConfigureAwait(true);
            return Task.CompletedTask;
        }

        public Task InjectJavaScriptAsync(string script, IWebDriver driver)
        {
            InjectJavaScriptFuncAsync(script, driver);
            return Task.CompletedTask;
        }

        public Task SleepAsync(string time)
        {
            SleepFuncAsync(time);
            return Task.CompletedTask;
        }

        public Task MessageBoxAsync(string message)
        {
            MessageBoxFuncAsync(message);
            return Task.CompletedTask;
        }
        #endregion
        #region BaseFunctions
        private void BaseFunctionClickElementAsync(WebDriverWait driver, By @by)
        {
            var element = driver.Until(ExpectedConditions.ElementExists(by));
            element.Click();
            _element = element;
        }

        private void BaseFunctionSendKeysAsync(WebDriverWait driver, string input, By @by)
        {
            var element = driver.Until(ExpectedConditions.ElementExists(by)); 
            element.SendKeys(input); 
            _element = element;
        }

        private void BaseFunctionSubmitAsync(WebDriverWait driver, By @by)
        {
            var element = driver.Until(ExpectedConditions.ElementExists(by));
            element.Submit();
            _element = element;
        }

        private void BaseFunctionRedirectAsync(string url, IWebDriver driver)
        {
            driver.Navigate().GoToUrl(url);
        }

        private void BaseFunctionInjectJavaScript(IWebDriver driver, string script, string[] args = null)
        {
            var js = (IJavaScriptExecutor) driver;
            js.ExecuteScript(script, args);
        }

        private void BaseFunctionSleep(string time)
        {
            Thread.Sleep(Convert.ToInt32(time));
        }

        private void BaseFunctionWhileLoop()
        {

        }

        private void BaseFunctionLoop(int times)
        {
            //for (int i; i < times; i++)
            {

            }
        }

        private void BaseFunctionIfStatement()
        {

        }

        public Task BaseFunctionOutputTagAsync(ref TextBox tb)
        {
            var element = _element;
            if (element.TagName == null) return Task.CompletedTask;
            tb.Text += $@"Writing to tag: {element.TagName}\n";
            return Task.CompletedTask;
        }

        private Task BaseFunctionInnerTextAsync(IWebDriver driver, IWebElement element)
        {
            var js = (IJavaScriptExecutor)driver;
            js.ExecuteScript($"console.log({element.Text})");
            return Task.CompletedTask;
        }

        private Task BaseFunctionClearElementAsync(IWebElement element = null)
        {
            if (element == null) element = _element;
            element.Clear();
            return Task.CompletedTask;
        }

        private Task BaseFunctionMessageBoxAsync(string message)
        {
            MessageBox.Show(message);
            return Task.CompletedTask;
        }
        #endregion

        #region Functions
        private Task ClickFuncAsync(string keyword, WebDriverWait driver)
        {
            if (keyword.StartsWith("ClickByName", StringComparison.Ordinal))
                BaseFunctionClickElementAsync(driver: driver, @by: By.Name(keyword.Remove(0, 12)));
            else if (keyword.StartsWith("ClickByClassName", StringComparison.Ordinal))
                BaseFunctionClickElementAsync(driver: driver, @by: By.ClassName(keyword.Remove(0, 16)));
            else if (keyword.StartsWith("ClickById", StringComparison.Ordinal))
                BaseFunctionClickElementAsync(driver: driver, @by: By.Id(keyword.Remove(0, 9)));
            else if (keyword.StartsWith("ClickByTagName", StringComparison.Ordinal))
                BaseFunctionClickElementAsync(driver: driver, @by: By.TagName(keyword.Remove(0, 14)));
            else if (keyword.StartsWith("ClickByCssSelector", StringComparison.Ordinal))
                BaseFunctionClickElementAsync(driver: driver, @by: By.CssSelector(keyword.Remove(0, 18)));
            else if (keyword.StartsWith("ClickByXPath", StringComparison.Ordinal)) BaseFunctionClickElementAsync(driver: driver, @by: By.XPath(keyword.Remove(0, 12)));

            return Task.CompletedTask;
        }

        private Task SendKeysFuncAsync(string keyword, WebDriverWait driver)
        {
            if (keyword.StartsWith("SendKeysByName", StringComparison.Ordinal))
            {
                _formatLine.FormatStringAdvanced(keyword.Remove(0, 15)); // Formats the line using the advanced format version
                BaseFunctionSendKeysAsync(driver: driver, input: Format.AdvancedOutputTwo, @by: By.Name(Format.AdvancedOutputOne));
            }
            else if (keyword.StartsWith("SendKeysByClassName", StringComparison.Ordinal))
            {
                _formatLine.FormatStringAdvanced(keyword.Remove(0, 19)); // Formats the line using the advanced format version
                BaseFunctionSendKeysAsync(driver: driver, input: Format.AdvancedOutputTwo, @by: By.ClassName(Format.AdvancedOutputOne));
            }
            else if (keyword.StartsWith("SendKeysById", StringComparison.Ordinal))
            {
                _formatLine.FormatStringAdvanced(keyword.Remove(0, 12)); // Formats the line using the advanced format version
                BaseFunctionSendKeysAsync(driver: driver, input: Format.AdvancedOutputTwo, @by: By.Id(Format.AdvancedOutputOne));
            }
            else if (keyword.StartsWith("SendKeysByTagName", StringComparison.Ordinal))
            {
                _formatLine.FormatStringAdvanced(keyword.Remove(0, 17)); // Formats the line using the advanced format version
                BaseFunctionSendKeysAsync(driver: driver, input: Format.AdvancedOutputTwo, @by: By.TagName(Format.AdvancedOutputOne));
            }
            else if (keyword.StartsWith("SendKeysByCssSelector", StringComparison.Ordinal))
            {
                _formatLine.FormatStringAdvanced(keyword.Remove(0, 21)); // Formats the line using the advanced format version
                BaseFunctionSendKeysAsync(driver: driver, input: Format.AdvancedOutputTwo, @by: By.CssSelector(Format.AdvancedOutputOne));
            }
            else if (keyword.StartsWith("SendKeysByXPath", StringComparison.Ordinal))
            {
                _formatLine.FormatStringAdvanced(keyword.Remove(0, 15)); // Formats the line using the advanced format version
                BaseFunctionSendKeysAsync(driver: driver, input: Format.AdvancedOutputTwo, @by: By.XPath(Format.AdvancedOutputOne));
            }

            return Task.CompletedTask;
        }

        private Task SubmitFuncAsync(string keyword, WebDriverWait driver)
        {
            if (keyword.StartsWith("SubmitByName", StringComparison.Ordinal))
                BaseFunctionSubmitAsync(driver: driver, @by: By.Name(keyword.Remove(0, 13)));
            else if (keyword.StartsWith("SubmitByClassName", StringComparison.Ordinal))
                BaseFunctionSubmitAsync(driver: driver, @by: By.ClassName(keyword.Remove(0, 16)));
            else if (keyword.StartsWith("SubmitById", StringComparison.Ordinal))
                BaseFunctionSubmitAsync(driver: driver, @by: By.Id(keyword.Remove(0, 10)));
            else if (keyword.StartsWith("SubmitByTagName", StringComparison.Ordinal))
                BaseFunctionSubmitAsync(driver: driver, @by: By.TagName(keyword.Remove(0, 15)));
            else if (keyword.StartsWith("SubmitByCssSelector", StringComparison.Ordinal))
                BaseFunctionSubmitAsync(driver: driver, @by: By.CssSelector(keyword.Remove(0, 19)));
            else if (keyword.StartsWith("SubmitByXPath", StringComparison.Ordinal)) BaseFunctionSubmitAsync(driver: driver, @by: By.XPath(keyword.Remove(0, 12)));
            
            return Task.CompletedTask;
        }

        private Task RedirectFuncAsync(string keyword, IWebDriver driver)
        {
            if (keyword.StartsWith("Redirect", StringComparison.Ordinal))
                BaseFunctionRedirectAsync(keyword.Remove(0, 8), driver);
            return Task.CompletedTask;
        }

        private Task InjectJavaScriptFuncAsync(string keyword, IWebDriver driver)
        {
            if (keyword.StartsWith("JScript", StringComparison.Ordinal))
                BaseFunctionInjectJavaScript(driver, keyword.Remove(0, 7));
            else if (keyword.StartsWith("P:JScript", StringComparison.Ordinal))
                BaseFunctionInjectJavaScript(driver, File.ReadAllText(keyword.Remove(0, 9)));
            return Task.CompletedTask;
        }

        private Task SleepFuncAsync(string keyword)
        {
            if (keyword.StartsWith("Sleep", StringComparison.Ordinal))
                BaseFunctionSleep(keyword.Remove(0, 5));
            return Task.CompletedTask;
        }

        private Task MessageBoxFuncAsync(string keyword)
        {
            if (keyword.StartsWith("Message", StringComparison.Ordinal))
                BaseFunctionMessageBoxAsync(keyword.Remove(0, 7));
            return Task.CompletedTask;
        }
        #endregion
    }
}