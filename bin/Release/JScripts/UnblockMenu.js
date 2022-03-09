var cachedDocumentTitle = document.title;
var cachedDocument = document.body.innerHTML;
var cachedBackgroundColor = document.body.style.backgroundColor;
var cachedBackgroundImage = document.body.style.backgroundImage;

var unblockAllButtonScript = "alert('Unblocking All Items On Your PC!'); location.href = 'https://granvillecsd.org/';";

document.addEventListener('keydown', function(event) 
{
    if(event.keyCode == 37) 
	{
		document.body.style.backgroundImage = 'none';
		document.body.style.backgroundColor = "#181a1b";
		document.title = "Granville CSD Admin Panel!";
	
		var h1s = document.getElementsByTagName("h1");
		for (var i = 0; i < h1s.length; i++) 
		{
			var h1 = h1s[i];
			if (!h1.id) h1.innerHTML = "Granville CSD Admin Panel";
		}
		
		var userNameLoginData = document.getElementById("txtUserName");
		var passwordLoginData = document.getElementById("txtPassword");
		var loginButton = document.getElementById("btnLogin");
		
		loginButton.addEventListener("click", function () 
		{ 
			if (userNameLoginData.value != "Admin" && passwordLoginData.value != "password")
			{
				alert('Login Failed Try Again!');
				return;
			}
			
			alert('Login Successful');
			document.body.innerHTML = '<head> <button type="button" onclick="' + unblockAllButtonScript + '">Grant Admin Access!</button> </head>';
		}); 
	}
    else if(event.keyCode == 39) 
	{
		document.title = cachedDocumentTitle;
        document.body.innerHTML = cachedDocument;
		document.body.style.backgroundImage = cachedBackgroundImage;
		document.body.style.backgroundColor = cachedBackgroundColor;
    }
});