--target https://www.google.com/
--chrome
--noDispose

ClickByXPath //*[@id="gb"]/div/div[2]/a
ClickByXPath //*[@id="identifierId"]
Sleep 1000

SendKeysByXPath //*[@id="identifierId"]:
ClickByXPath //*[@id="identifierNext"]/div/button
Sleep 1000

SendKeysByXPath //*[@id="password"]/div[1]/div/div[1]/input:
ClickByXPath //*[@id="passwordNext"]/div/button
Sleep 50

Message Unblocking In Progress!
Redirect https://www.google.com/search?q=Unblocking...+Unblocked%21+Downloads+and+Webpages+are+unblocked%21&sxsrf=APq-WBvxrcp-9Gf3SM5DRQNDhyq8sQM8nw%3A1644539287084&source=hp&ei=l60FYoqxAs6wytMPj9mQ6As&iflsig=AHkkrS4AAAAAYgW7pyYwZbrdN6wcNW4fl82acjqKx8qJ&ved=0ahUKEwjK2Jegsvb1AhVOmHIEHY8sBL0Q4dUDCAk&uact=5&oq=Unblocking...+Unblocked%21+Downloads+and+Webpages+are+unblocked%21&gs_lcp=Cgdnd3Mtd2l6EAM6DggAEOoCELQCENkCEOUCOgsIABCABBCxAxCDAToICAAQgAQQsQM6DgguEIAEELEDEMcBEKMCOgUIABCABDoOCC4QgAQQsQMQxwEQ0QM6CwguEIAEEMcBEKMCOg4ILhCABBCxAxCDARDUAjoFCC4QgAQ6EQguEIAEELEDEIMBEMcBENEDOggILhCABBCxAzoLCC4QgAQQsQMQ1AI6CwguEIAEEMcBEK8BOggIABCxAxCDAToICC4QgAQQ1AI6CwguEIAEEMcBENEDOgQIABAKOgQILhAKOgQIABAeOgYIABAWEB46BQgAEIYDOggIIRAWEB0QHjoFCCEQoAE6CggAEAgQDRAKEB46CAgAEAgQDRAeOgYIABANEB46BQghEKsCOgcIIRAKEKABUNAPWIzXAWCO9wFoA3AAeACAAYMCiAH0MJIBBzQwLjIwLjKYAQCgAQGwAQg&sclient=gws-wiz

JScript document.title = "Unblocked By Gravillian"; 
Sleep 1000

JScript document.body.innerHTML = '<body>Unblocked By Gravillian!</body>';
Sleep 100

JScript var ofs = 0; var el = document.body; window.setInterval(function(){ el.style.background = 'rgba(0,255,0,'+Math.abs(Math.sin(ofs))+')'; ofs += 0.01; }, 10);
