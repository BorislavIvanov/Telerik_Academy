function OnButtonClickEvent(theEvent, arguments) {
  var myWindow = window;
  var currentBrowser = myWindow.navigator.appCodeName;
  var theBrowserIsMozilla = currentBrowser == "Mozilla";
  
  if(theBrowserIsMozilla){
    alert("Yes");  
	}
  else{
    alert("No");  
	}
}