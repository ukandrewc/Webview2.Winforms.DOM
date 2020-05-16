Imports Microsoft.Web.WebView2.Core

Friend Class Form1

	Private Sub Form1_Load(sender As Object, e As EventArgs) Handles Me.Load
		WebView2.Source = New Uri("about:blank")
	End Sub

	Private Sub WebView2_DOMMouseEvent(sender As Object, e As WVEvent) Handles WebView2.DOMMouseEvent
		LblMessage.Text = $"{e.Target?.TagName}: {e.Type}"
	End Sub

	Private Sub WebView2_DOMContextMenu(sender As Object, e As WVEvent) Handles WebView2.DOMContextMenu
		LblMessage.Text = $"Context Menu Location: {e.PageX} {e.PageY}"
	End Sub

	Private Sub WebView2_DOMKeyEvent(sender As Object, e As WVEvent) Handles WebView2.DOMKeyEvent
		Console.WriteLine(e)
	End Sub

	Private Sub WebView2_DOMClickEvent(sneder As Object, e As WVEvent) Handles WebView2.DOMClickEvent
		e.ReturnValue = e.Target.TextContent <> "About"
	End Sub

	Private Sub WebView2_DOMInputEvent(sender As Object, e As WVEvent) Handles WebView2.DOMInputEvent
		Console.WriteLine(e.Type)
	End Sub

	Private Sub WebView2_DOMCustomEvent(sender As Object, e As WVEvent) Handles WebView2.DOMCustomEvent
	End Sub

	Private Sub WebView2_CoreWebView2Ready(sender As Object, e As EventArgs) Handles WebView2.CoreWebView2Ready
		WebView2.CoreWebView2.Navigate("https://google.co.uk")
	End Sub

	Private Sub WebView2_DOMDocumentComplete(sender As Object) Handles WebView2.DOMDocumentComplete
		For Each Elem In WebView2.Document.EvaluateAll("//input")
			If Elem.TagName = "INPUT" Then
				Elem.Attribute("value") = "Hello"
			End If
		Next
	End Sub
End Class
