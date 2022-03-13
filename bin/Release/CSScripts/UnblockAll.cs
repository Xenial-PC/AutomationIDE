using System.Timers;
using Timer = System.Timers.Timer;
using System.Collections.Generic;

static Timer _keepScriptActiveTimer;
static string _cachedUrl;
static string _script;
string _injectionUrl = "https://studentportal-neric.eschooldata.com/Login.aspx?ReturnUrl=%2fgranvillecsd";
bool isLoggedIn;
bool isInjected;

public void Main()
{
	_keepScriptActiveTimer = new Timer { Interval = .1, Enabled = true };
    _keepScriptActiveTimer.Elapsed += MainLoopTimer;
    _keepScriptActiveTimer.AutoReset = true;
	
	_script = File.ReadAllText(@$"{Directory.GetCurrentDirectory()}\JScripts\UnblockMenu.js");
}

private void MainLoopTimer(object source, ElapsedEventArgs e) 
{ 
	if (!isLoggedIn && ChromeDriver.WindowHandles.Count > 1) SetLoginTab();
	if (!isLoggedIn && ChromeDriver.Url != _injectionUrl) 
	{
		ChromeDriver.Close();
		return;
	}

	if (ChromeDriver.Url == _injectionUrl)
	{
		if (!isInjected)
			InjectJavaScript(_script);

		LoginSuccessful();
	}
}

private void InjectJavaScript(string script, string[] args = null)
{
	isInjected = true;
	var js = (IJavaScriptExecutor) ChromeDriver;
	js.ExecuteScript(script, args);
}

private void SetLoginTab()
{
	var browserTabs = ChromeDriver.WindowHandles;
    ChromeDriver.SwitchTo().Window(browserTabs[1]);
	ChromeDriver.Close();
	ChromeDriver.SwitchTo().Window(browserTabs[0]);
}

private void LoginSuccessful()
{
	try
	{
		var element = ChromeDriver.FindElement(By.Id("LoggedIn"));
		if (element.Displayed)
			isLoggedIn = true;
	}
	catch(Exception e)
	{
	}
}