﻿if (chrome === undefined) {
    const chromeNotLoaded = await GetLang("Toast_ChromeNotLoaded");

	window.notification.new({
		type: "error",
		title: "",
        message: chromeNotLoaded,
		renderTo: "toastarea",
		duration: 10000
	});
	chrome = null;
}


const d = new Date();
var monthDay = "";

function getDate() {
    if (monthDay === "") monthDay = d.getMonth().toString() + d.getDate().toString();
    return monthDay;
}

const SysCommandSize = { // Reverses for april fools
    ScSizeHtLeft: (getDate() !== "31" ? 0xA : 0xB), // 1 + 9
    ScSizeHtRight: (getDate() !== "31" ? 0xB : 0xA),
    ScSizeHtTop: (getDate() !== "31" ? 0xC : 0xF),
    ScSizeHtTopLeft: (getDate() !== "31" ? 0xD : 0x11),
    ScSizeHtTopRight: (getDate() !== "31" ? 0xE : 0x10),
    ScSizeHtBottom: (getDate() !== "31" ? 0xF : 0xC),
    ScSizeHtBottomLeft: (getDate() !== "31" ? 0x10 : 0xE),
    ScSizeHtBottomRight: (getDate() !== "31" ? 0x11 : 0xD),

    ScMinimise: 0xF020,
    ScMaximise: 0xF030,
    ScRestore: 0xF120
};
const WindowNotifications = {
    WmClose: 0x0010
};

var possibleAnimations = [
    "rotateY",
    "rotateX",
    "rotateZ"
];
var lastDeg = 360;

function randomAni(e) {
    lastDeg = -lastDeg;

    $({ deg: 0 }).animate(
        {
            deg: lastDeg,
            easing: "swing"
        }, {
            duration: 500,
            step: (now) => {
                $(e).css({
                    transform: possibleAnimations[Math.floor(Math.random() * possibleAnimations.length)] + "(" + now + "deg)"
                });
            }
    });
}

function btnBack_Click() {
    if (window.location.pathname === "/") randomAni("#btnBack .icon");
    else {
	    const tempUri = document.location.href.split("?")[0];
	    document.location.href = tempUri + (tempUri.endsWith("/") ? "../" : "/../");
    }
}

function handleWindowControls() {
    document.getElementById("btnMin").addEventListener("click", () => {
        chrome.webview.hostObjects.sync.eventForwarder.WindowAction(SysCommandSize.ScMinimise);
    });

    document.getElementById("btnBack").addEventListener("click", () => {
        btnBack_Click();
    });

    document.getElementById("btnMax").addEventListener("click", () => {
        chrome.webview.hostObjects.sync.eventForwarder.WindowAction(SysCommandSize.ScMaximise);
    });

    document.getElementById("btnRestore").addEventListener("click", () => {
        chrome.webview.hostObjects.sync.eventForwarder.WindowAction(SysCommandSize.ScRestore);
    });

    document.getElementById("btnClose").addEventListener("click", () => {
        DotNet.invokeMethodAsync("TcNo-Acc-Switcher-Server", "GetTrayMinimizeNotExit").then((r) => {
            if (r && !event.ctrlKey) { // If enabled, and NOT control held
                chrome.webview.hostObjects.sync.eventForwarder.HideWindow();
            } else {
                chrome.webview.hostObjects.sync.eventForwarder.WindowAction(WindowNotifications.WmClose);
            }
        });
    });

    // For draggable regions:
    // https://github.com/MicrosoftEdge/WebView2Feedback/issues/200
    document.body.addEventListener("mousedown", (evt) => {
        // ES is actually 11, set in project file. This error can be ignored (if you see one about ES5)
        const {
            target
        } = evt;
        const appRegion = getComputedStyle(target)["-webkit-app-region"];
        if (evt.button === 0 && appRegion === "drag") {
            if (target.classList.length !== 0) {
                const c = target.classList[0];
                chrome.webview.hostObjects.sync.eventForwarder.MouseResizeDrag(
                    (c === "resizeTopLeft" ? SysCommandSize.ScSizeHtTopLeft : (
                        c === "resizeTop" ? SysCommandSize.ScSizeHtTop : (
                            c === "resizeTopRight" ? SysCommandSize.ScSizeHtTopRight : (
                                c === "resizeRight" ? SysCommandSize.ScSizeHtRight : (
                                    c === "resizeBottomRight" ? SysCommandSize.ScSizeHtBottomRight : (
                                        c === "resizeBottom" ? SysCommandSize.ScSizeHtBottom : (
                                            c === "resizeBottomLeft" ? SysCommandSize.ScSizeHtBottomLeft : (
                                                c === "resizeLeft" ? SysCommandSize.ScSizeHtLeft : 0)))))))));
            }

            chrome.webview.hostObjects.sync.eventForwarder.MouseDownDrag();

            evt.preventDefault();
            evt.stopPropagation();
        }
    });
}