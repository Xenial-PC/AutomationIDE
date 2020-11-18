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
        #endregion
        #region BaseFunctions
        private void BaseFunctionClickElementAsync(WebDriverWait driver, By @by)
        {
            var element = driver.Until(ExpectedConditions.ElementExists(by)); // Waits til the element exists
            element.Click(); // Sends the click 
            _element = element;
        }

        private void BaseFunctionSendKeysAsync(WebDriverWait driver, string input, By @by)
        {
            var element = driver.Until(ExpectedConditions.ElementExists(by)); // Waits til the element exists
            element.SendKeys(input); // Sends the string of keys set by the user
            _element = element;
        }

        private void BaseFunctionSubmitAsync(WebDriverWait driver, By @by)
        {
            var element = driver.Until(ExpectedConditions.ElementExists(by)); // Waits til the element exists
            element.Submit(); // Sends *enter*
            _element = element;
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

        public Task BaseFunctionCOutputTagAsync(ref TextBox tb)
        {
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
        private Task ClickFuncAsync(string keyword, WebDriverWait driver)
        {
            switch (keyword)
            {
                case string l when l.StartsWith("ClickByName", StringComparison.Ordinal): // Checks if the keyword ClickByName is used
                    BaseFunctionClickElementAsync(driver: driver, by: By.Name(keyword.Remove(0, 12))); break; // Removes everything up to the element 
                
                case string l when l.StartsWith("ClickByClassName", StringComparison.Ordinal): // Checks if the keyword ClickByClassName is used
                    BaseFunctionClickElementAsync(driver: driver, by: By.ClassName(keyword.Remove(0, 16))); break;
                
                case string l when l.StartsWith("ClickById", StringComparison.Ordinal): // Checks if the keyword ClickById is used
                    BaseFunctionClickElementAsync(driver: driver, by: By.Id(keyword.Remove(0, 9))); break;
                
                case string l when l.StartsWith("ClickByTagName", StringComparison.Ordinal): // Checks if the keyword ClickByTagName is used
                    BaseFunctionClickElementAsync(driver: driver, by: By.TagName(keyword.Remove(0, 14))); break;
                
                case string l when l.StartsWith("ClickByCssSelector", StringComparison.Ordinal): // Checks if the keyword ClickByCssSelector is used
                    BaseFunctionClickElementAsync(driver: driver, by: By.CssSelector(keyword.Remove(0, 18))); break;
                
                case string l when l.StartsWith("ClickByXPath", StringComparison.Ordinal): // Checks if the keyword ClickByXPath is used
                    BaseFunctionClickElementAsync(driver: driver, by: By.XPath(keyword.Remove(0, 12))); break;
            }
            return Task.CompletedTask;
        }

        private Task SendKeysFuncAsync(string keyword, WebDriverWait driver)
        {
            switch (keyword)
            {
                case string l when l.StartsWith("SendKeysByName", StringComparison.Ordinal): // Checks if the keyword SendKeysByName is used
                    {
                    _formatLine.FormatStringAdvanced(keyword.Remove(0, 15)); // Formats the line using the advanced format version
                    BaseFunctionSendKeysAsync(driver: driver, input: Format.AdvancedOutputTwo, by: By.Name(Format.AdvancedOutputOne));
                }break;
                case string l when l.StartsWith("SendKeysByClassName", StringComparison.Ordinal): // Checks if the keyword SendKeysByClassName is used
                    {
                    _formatLine.FormatStringAdvanced(keyword.Remove(0, 19)); // Formats the line using the advanced format version
                    BaseFunctionSendKeysAsync(driver: driver, input:Format.AdvancedOutputTwo, by: By.ClassName(Format.AdvancedOutputOne));
                }break;
                case string l when l.StartsWith("SendKeysById", StringComparison.Ordinal): // Checks if the keyword SendKeysById is used
                    {
                    _formatLine.FormatStringAdvanced(keyword.Remove(0, 12)); // Formats the line using the advanced format version
                    BaseFunctionSendKeysAsync(driver: driver, input: Format.AdvancedOutputTwo, by: By.Id(Format.AdvancedOutputOne));
                }break;
                case string l when l.StartsWith("SendKeysByTagName", StringComparison.Ordinal): // Checks if the keyword SendKeysByTagName is used
                    {
                    _formatLine.FormatStringAdvanced(keyword.Remove(0, 17)); // Formats the line using the advanced format version
                    BaseFunctionSendKeysAsync(driver: driver, input: Format.AdvancedOutputTwo, by: By.TagName(Format.AdvancedOutputOne));
                }break;
                case string l when l.StartsWith("SendKeysByCssSelector", StringComparison.Ordinal): // Checks if the keyword SendKeysByCssSelector is used
                    {
                    _formatLine.FormatStringAdvanced(keyword.Remove(0, 21)); // Formats the line using the advanced format version
                    BaseFunctionSendKeysAsync(driver: driver, input: Format.AdvancedOutputTwo, by: By.CssSelector(Format.AdvancedOutputOne));
                }break;
                case string l when l.StartsWith("SendKeysByXPath", StringComparison.Ordinal): // Checks if the keyword SendKeysByXPath is used
                    {
                    _formatLine.FormatStringAdvanced(keyword.Remove(0, 15)); // Formats the line using the advanced format version
                    BaseFunctionSendKeysAsync(driver: driver, input: Format.AdvancedOutputTwo, by: By.XPath(Format.AdvancedOutputOne));
                }break;
            }
            return Task.CompletedTask;
        }

        private Task SubmitFuncAsync(string keyword, WebDriverWait driver)
        {
            switch (keyword)
            {
                case string l when l.StartsWith("SubmitByName", StringComparison.Ordinal): // Checks if the keyword SubmitByName is used
                    BaseFunctionSubmitAsync(driver: driver, by: By.Name(keyword.Remove(0, 13))); break;

                case string l when l.StartsWith("SubmitByClassName", StringComparison.Ordinal): // Checks if the keyword SubmitByClassName is used
                    BaseFunctionSubmitAsync(driver: driver, by: By.ClassName(keyword.Remove(0, 16))); break;

                case string l when l.StartsWith("SubmitById", StringComparison.Ordinal): // Checks if the keyword SubmitById is used
                    BaseFunctionSubmitAsync(driver: driver, by: By.Id(keyword.Remove(0, 10))); break;

                case string l when l.StartsWith("SubmitByTagName", StringComparison.Ordinal): // Checks if the keyword SubmitByTagName is used
                    BaseFunctionSubmitAsync(driver: driver, by: By.TagName(keyword.Remove(0, 15))); break;

                case string l when l.StartsWith("SubmitByCssSelector", StringComparison.Ordinal): // Checks if the keyword SubmitByCssSelector is used
                    BaseFunctionSubmitAsync(driver: driver, by: By.CssSelector(keyword.Remove(0, 19))); break;

                case string l when l.StartsWith("SubmitByXPath", StringComparison.Ordinal): // Checks if the keyword SubmitByXPath is used
                    BaseFunctionSubmitAsync(driver: driver, by: By.XPath(keyword.Remove(0, 12))); break;
            }
            return Task.CompletedTask;
        }
        #endregion
    }
}