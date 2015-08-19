function CheckBrowserButtonClick(event, arguments) {
    var myWindow = window,
        browser = myWindow.navigator.appCodeName,
        isCorrectBrowser = (browser == "Mozilla");
    if (isCorrectBrowser) {
        alert("Yes");
    } else {
        alert("No");
    }
}
