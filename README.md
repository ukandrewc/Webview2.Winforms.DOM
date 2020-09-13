# Webview2.Winforms.DOM
Experimental DOM implementation for [Microsoft.Webview2.Winforms](https://docs.microsoft.com/en-us/microsoft-edge/webview2/reference/winforms/0-9-515/microsoft-web-webview2-winforms-webview2)

An implementation for a WebView2 DOM, that can be accessed from .Net

It implements Window, Document, Element, Attribute, Style and Node.
Also implements QuerySelecte
or/QuerySelectorAll and Evaluate/EvaluateAll (XPath) on WebView2

You can perform most operations on the DOM, e.g:

`Document.GetElementById("elem_id").InsertAdjacentHTML("afterbegin", "<div>Content</div>")`

Event handling to cancel click and dblclick events from .Net

.Net handlers for Click, Mouse, Keyboard, Input, ContextMenu and Custom events.

In JS, the click and dblclick events are cancelled by preventDefault and stopPropogation. After being raised in .Net, they are only dispatched if ReturnValue = True (default).

```
Private Sub WebView2_DOMClickEvent(sender As Object, e As WVEvent) Handles WebView2.DOMClickEvent
	'Click events can be cancelled using ReturnValue
	e.ReturnValue = e.Target.TextContent <> "About"
End Sub

```
Added GetElementsByTagName

Changed EvaluateAll to snapshot type, so elements can be modified from it.

### Started adding support for DevTools Protocol including events
Note: `WebView2.Protocol.GetCookies({"https://google.co.uk"})` needs to supply full url
```
Private Sub WebView2_CoreWebView2Ready(sender As Object, e As EventArgs) Handles WebView2.CoreWebView2Ready
	WebView2.CoreWebView2.Navigate("https://google.co.uk")
	With WebView2.Protocol
		.EnableDomainEvents("Page", True)
		.EnableDomainEvents("Log", True)
		.SubscribeEvent("Page.loadEventFired")
		.SubscribeEvent("Page.windowOpen")
		.SubscribeEvent("Log.entryAdded")
		AddHandler .EventReceived, AddressOf Protocol_EventRaised
	End With
End Sub

Private Sub Protocol_EventRaised(Name As String, Json As String)
	Console.WriteLine(Name)
End Sub

```

Added sample project with tabbed browser

Added download notifications using DevTools Protocol
