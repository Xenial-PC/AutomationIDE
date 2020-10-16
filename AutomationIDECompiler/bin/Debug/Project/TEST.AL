--target https://www.google.com/
--chrome
--noDispose

ClickByName q
SendKeysByName q:Test
SubmitByName q

ClickByXPath //*[@id="rso"]/div[1]/div/div[1]/a/h3
