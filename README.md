# Webview2.Winforms.DOM
Experimental DOM implementation for [Microsoft.Webview2.Winforms](https://docs.microsoft.com/en-us/microsoft-edge/webview2/reference/winforms/0-9-515/microsoft-web-webview2-winforms-webview2)

An implementation for a WebView2 DOM, that can be accessed from .Net

It implements Window, Document, Element, Attribute, Style and Node.
Also implements QuerySelecter/QuerySelectorAll and Evaluate/EvaluateAll (XPath) on WebView2

You can perform most operations on the DOM, e.g:

`Document.GetElementById("elem_id").InsertAdjacentHTML("afterbegin", "<div>Content</div>")`

Event handling to be cancel click and dblclick events from .Net

.Net handlers for Click, Mouse, Keyboard, Input, ContextMenu and Custom events.

In JS, the click and dblclick events are cancelled by preventDefault and stopPropogation. After being raised in .Net, they are only dispatched if ReturnValue = True (default).

```
Private Sub WebView2_DOMClickEvent(sender As Object, e As WVEvent) Handles WebView2.DOMClickEvent
	'Click events can be cancelled using ReturnValue
	e.ReturnValue = e.Target.TextContent <> "About"
End Sub

```
