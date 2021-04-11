# Webview2.Winforms.DOM
Experimental DOM implementation for [Microsoft.Webview2.Winforms](https://docs.microsoft.com/en-us/microsoft-edge/webview2/reference/winforms/0-9-515/microsoft-web-webview2-winforms-webview2)

An implementation for a WebView2 DOM, that can be accessed from .Net

### DOM access
It implements Window, Document, Element, Attribute, Style and Node.
Also implements QuerySelector/QuerySelectorAll and Evaluate/EvaluateAll (XPath) on WebView2

You can perform most operations on the DOM, e.g:

```
Document.GetElementById("elem_id").InsertAdjacentHTML("afterbegin", "<div>Content</div>")
Dim x = Document.Evaluate("//input[@id='form_input']")
```

### Event handling
Because script cannot be executed during a synchronous event, two events are raised, one Sync, and one Async.
The Sync event is raised first. It can prevent default handling in javascript and the Async event in WVBrowser.

To make the decision to cancel, an array of script to evaluate, is passed into AddEventHandler, and the results passed to the Sync event.

#### Add the event handler to browser
```
Private Sub Web_DOMDocumentComplete(sender As Object) Handles Web.DOMDocumentComplete
	'Add click event handler, pass script to return: e.target.tagName, e.x, e.y to Sync event
	Web.AddEventHandler("document.body", "click", "e.target.tagName", "e.x", "e.y")
End Sub

'Can't execute script or use DOM in Sync event
Private Sub Web_DOMEventSync(Type As String, ByRef e As WVEventHost.SyncEventArgs) Handles Web.DOMEventSync
	'Prevent default if BODY
	e.PreventDefault = e.Values(0) = "BODY"
	
	'Prevent Async if not BODY
	e.PreventAsync = e.Values(0) <> "BODY"
End Sub

'Can execute script and call DOM here
Private Sub Web_DOMEventAsync(Type As String, e As WVEvent) Handles Web.DOMEventAsync
	'Get BODY InnerHTML
	If Type = "click" Then
		Dim h = Web.Document.Body.InnerHTML
	End If
End Sub

```
#### Add the event handler to element
```
Private WithEvents Div as WVElement

Private Sub Web_DOMDocumentComplete(sender As Object) Handles Web.DOMDocumentComplete
	Div = Web.Document.GetElementById("myElement")
	'Add click event handler
	Div.AddEventHandler("click")
End Sub

Private Sub Div_DOMEventAsync(Type As String, e As WVEvent) Handles Div.DOMEventAsync
'Process event
End Sub

```

### Support for DevTools Protocol with events
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

### Updated for pre-release 0.9.628
Added sample project with tabbed browser

Added download notifications using DevTools Protocol

Added ability to use CorewebView2Environment that doesn't require Async
```
Dim Environment = WVUtils.CreateEnvironment("", "My Folder", MyOptions)
WVBrowser.EnsureWebView2(Environment)
```
### Major update with breaking changes
Default DOM events have changed and now need to be added using AddEventHandler as described above

Added support for accessing iFrames, including FrameLoaded and FrameCompleted events

### Updated for pre-release 1.0.674.0

Added specific WVIFrameElement class for iFrames
Any function that returns a WVElement, will now return a WVIFrameElement, when the element is an iFrame

### Updated for pre-release 1.0.707.0

Added more specific types for TABLE, FORM and elements that have special functionality

WVTable, WVTableSection, WVTableRow, WVTableCell | WVForm, WVinput | WVAnchor

Added DeferReflow() and ApplyReflow() to defer page reflow when updating:

```
Dim Table = Web.Document.Evaluate("//table")
'Defer reflow
Table.DeferReflow()
For Each Row in Table.TBodies(0).Rows
	For Each Cel in Row.Cells
		Cel.Style("borderLeft") = $"4px solid {Choose(1 + Rnd() * 5, "red", "green", "yellow", "blue", "orange")}"
	Next
Next
'Apply update
Table.ApplyReflow()

```

### Updated for pre-release 1.0.824.0

Started adding support for Selection and Range

Removed internal Autofill implementation pending WebView2 API.

## Breaking Changes

Updated DOM structure to more closely follow JS DOM.

WVDOMBase renamed WVElement, WVElement renamed WVHTMLElement

TabStrip renamed WVTabstrip, NavStrip renamed WVNavstrip
