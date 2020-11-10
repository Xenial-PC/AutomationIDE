using System;
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
        #region BrowserFunctions

        public Task ClickAsync(string name, WebDriverWait driverWait)
        {
            ClickFuncAsync(name, driverWait).ConfigureAwait(true);
            return Task.CompletedTask;
        }

        public Task SendKeysAsync(string name, WebDriverWait driverWait)
        {
            SendKeysFuncAsync(name, driverWait).ConfigureAwait(true);
            return Task.CompletedTask;
        }

        public Task SubmitAsync(string name, WebDriverWait driverWait)
        {
            SubmitFuncAsync(name, driverWait).ConfigureAwait(true);
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

        private void BaseFunctionWhileLoop()
        {

        }

        private void BaseFunctionForLoop()
        {

        }

        private void BaseFunctionIfStatement()
        {

        }

        public Task BaseFunctionCheckTagAsync(out TextBox tb)
        {
            tb = new TextBox();
            var element = _element;
            if (element.TagName == null) return Task.CompletedTask;
            tb.Text += $"Writing to tag: {element.TagName}\n";
            return Task.CompletedTask;
        }

        private Task BaseFunctionInnerTextAsync(IWebElement element)
        {
            Console.WriteLine(element.Text);
            return Task.CompletedTask;
        }

        private Task BaseFunctionClearElementAsync(IWebElement element = null)
        {
            if (element == null) element = _element;
            element.Clear();
            return Task.CompletedTask;
        }
        #endregion
        #region Functions
        private Task ClickFuncAsync(string name, WebDriverWait driver)
        {
            switch (name)
            {
                case string n when n.StartsWith("ClickByName", StringComparison.Ordinal):
                    BaseFunctionClickElementAsync(driver, By.Name(name.Remove(0, 12))); break;
                case string n when n.StartsWith("ClickByClassName", StringComparison.Ordinal):
                    BaseFunctionClickElementAsync(driver, By.ClassName(name.Remove(0, 16))); break;
                case string n when n.StartsWith("ClickById", StringComparison.Ordinal):
                    BaseFunctionClickElementAsync(driver, By.Id(name.Remove(0, 9))); break;
                case string n when n.StartsWith("ClickByTagName", StringComparison.Ordinal):
                    BaseFunctionClickElementAsync(driver, By.TagName(name.Remove(0, 14))); break;
                case string n when n.StartsWith("ClickByCssSelector", StringComparison.Ordinal):
                    BaseFunctionClickElementAsync(driver, By.CssSelector(name.Remove(0, 18))); break;
                case string n when n.StartsWith("ClickByXPath", StringComparison.Ordinal):
                    BaseFunctionClickElementAsync(driver, By.XPath(name.Remove(0, 12))); break;
            }
            return Task.CompletedTask;
        }

        private Task SendKeysFuncAsync(string name, WebDriverWait driver)
        {
            switch (name)
            {
                case string n when n.StartsWith("SendKeysByName", StringComparison.Ordinal):
                {
                    FormatMessage.FormatStringAdvanced(name.Remove(0, 15));
                    BaseFunctionSendKeysAsync(driver, FormatMessage.AdvancedOutputTwo, By.Name(FormatMessage.AdvancedOutputOne));
                }break;
                case string n when n.StartsWith("SendKeysByClassName", StringComparison.Ordinal):
                {
                    FormatMessage.FormatStringAdvanced(name.Remove(0, 19));
                    BaseFunctionSendKeysAsync(driver, FormatMessage.AdvancedOutputTwo, By.ClassName(FormatMessage.AdvancedOutputOne));
                }break;
                case string n when n.StartsWith("SendKeysById", StringComparison.Ordinal):
                {
                    FormatMessage.FormatStringAdvanced(name.Remove(0, 12));
                    BaseFunctionSendKeysAsync(driver, FormatMessage.AdvancedOutputTwo, By.Id(FormatMessage.AdvancedOutputOne));
                }break;
                case string n when n.StartsWith("SendKeysByTagName", StringComparison.Ordinal):
                {
                    FormatMessage.FormatStringAdvanced(name.Remove(0, 17));
                    BaseFunctionSendKeysAsync(driver, FormatMessage.AdvancedOutputTwo, By.TagName(FormatMessage.AdvancedOutputOne));
                }break;
                case string n when n.StartsWith("SendKeysByCssSelector", StringComparison.Ordinal):
                {
                    FormatMessage.FormatStringAdvanced(name.Remove(0, 21));
                    BaseFunctionSendKeysAsync(driver, FormatMessage.AdvancedOutputTwo, By.CssSelector(FormatMessage.AdvancedOutputOne));
                }break;
                case string n when n.StartsWith("SendKeysByXPath", StringComparison.Ordinal):
                {
                    FormatMessage.FormatStringAdvanced(name.Remove(0, 15));
                    BaseFunctionSendKeysAsync(driver, FormatMessage.AdvancedOutputTwo, By.XPath(FormatMessage.AdvancedOutputOne));
                }break;
            }
            return Task.CompletedTask;
        }

        private Task SubmitFuncAsync(string name, WebDriverWait driver)
        {
            switch (name)
            {
                case string n when n.StartsWith("SubmitByName", StringComparison.Ordinal):
                    BaseFunctionSubmitAsync(driver, By.Name(name.Remove(0, 13))); break;
                case string n when n.StartsWith("SubmitByClassName", StringComparison.Ordinal):
                    BaseFunctionSubmitAsync(driver, By.ClassName(name.Remove(0, 16))); break;
                case string n when n.StartsWith("SubmitById", StringComparison.Ordinal):
                    BaseFunctionSubmitAsync(driver, By.Id(name.Remove(0, 10))); break;
                case string n when n.StartsWith("SubmitByTagName", StringComparison.Ordinal):
                    BaseFunctionSubmitAsync(driver, By.TagName(name.Remove(0, 15))); break;
                case string n when n.StartsWith("SubmitByCssSelector", StringComparison.Ordinal):
                    BaseFunctionSubmitAsync(driver, By.CssSelector(name.Remove(0, 19))); break;
                case string n when n.StartsWith("SubmitByXPath", StringComparison.Ordinal):
                    BaseFunctionSubmitAsync(driver, By.XPath(name.Remove(0, 12))); break;
            }
            return Task.CompletedTask;
        }
        #endregion
    }
}