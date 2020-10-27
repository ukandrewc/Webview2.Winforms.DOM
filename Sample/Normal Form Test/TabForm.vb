Imports Microsoft.Web.WebView2.Core

Public Class TabForm

	Private WithEvents Web As WVBrowser
	Private WithEvents TestWeb As New WVBrowser
	Private TestCounter = 0

	Private Sub ContextBack_Click(sender As Object, e As EventArgs) Handles ContextBack.Click
		Web.GoBack()
	End Sub

	Private Sub ContextForward_Click(sender As Object, e As EventArgs) Handles ContextForward.Click
		Web.GoForward()
	End Sub

	Private Sub ContextMenu_Opening(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles ContextMenu.Opening
		Dim En = Web.ContextMenuEvent.Target.TagName = "INPUT" Or Web.ContextMenuEvent.Target.TagName = "TEXTAREA"
		ContextCut.Visible = En
		ContextCopy.Visible = En
		ContextPaste.Visible = En

		En = Not En
		ContextBack.Visible = En
		ContextForward.Visible = En
		ContextRefresh.Visible = En
		ContSepInspect.Visible = En
		ContextInspect.Visible = En
		ContextBack.Enabled = Web.CanGoBack
		ContextForward.Enabled = Web.CanGoForward
	End Sub

	Private Sub NavView_BrowserChanged(sender As Object) Handles NavView.BrowserChanged
		Web = NavView.Browser
	End Sub

	Private Sub NavView_TextChanged(sender As Object, e As EventArgs) Handles NavView.TextChanged
		Text = NavView.Text
	End Sub

	Private Sub TabForm_Load(sender As Object, e As EventArgs) Handles Me.Load
		SearchEngineUrl = "https://google.co.uk?q="
		TabView.CreateTab("google.co.uk", True)
		TabView.CreateTab("bing.co.uk", False)
	End Sub

	Private Sub TabView_BrowserRequested(Tab As TabButton, ByRef NewBrowser As WVBrowser) Handles TabView.BrowserRequested
		NewBrowser = New WVBrowser
		NewBrowser.ContextMenuStrip = ContextMenu
		NewBrowser.Dock = DockStyle.Fill
		Controls.Add(NewBrowser)
	End Sub

	Private Sub TabView_WindowRequested(Owner As WVBrowser, e As CoreWebView2NewWindowRequestedEventArgs, ByRef NewBrowser As WVBrowser) Handles TabView.WindowRequested
		With e.WindowFeatures
			If .HasSize Then
				Dim Form As New PopForm
				Form.Width = .Width
				Form.Height = .Height
				If .HasPosition Then
					Form.Left = .Left
					Form.Top = .Top
				Else
					Form.StartPosition = FormStartPosition.CenterParent
				End If
				NewBrowser = Form.Web
				Form.Show(Me)
			End If
		End With
	End Sub

	Private Sub ContextRefresh_Click(sender As Object, e As EventArgs) Handles ContextRefresh.Click
		Web.Reload(My.Computer.Keyboard.ShiftKeyDown)
	End Sub

	Private Sub ContextInspect_Click(sender As Object, e As EventArgs) Handles ContextInspect.Click
		Web.CoreWebView2.OpenDevToolsWindow()
	End Sub

	Private Sub Test_Click(sender As Object, e As EventArgs) Handles Test.Click
		TestCounter = 10
		If TestWeb.AllowResourceContexts.Count = 0 Then
			TestWeb.AllowResourceContexts.Add(CoreWebView2WebResourceContext.Document)
			TestWeb.AllowResourceContexts.Add(CoreWebView2WebResourceContext.Script)
		End If
		TestWeb.Navigate("google.co.uk")
	End Sub

	Private Sub TestWeb_DOMDocumentComplete(sender As Object) Handles TestWeb.DOMDocumentComplete
		Dim Count = 0
		For Each Item In TestWeb.Document.GetElementsByTagName("div")
			Dim Name = Item.ClassName
			Count += Item.TextContent.Length
		Next
		TestCounter -= 1
		Console.WriteLine($"{TestCounter}: {Count}")
		If TestCounter > 0 Then
			TestWeb.Navigate(TestWeb.Source.ToString)
		End If
	End Sub

	Private Sub TestWeb_DOMDocumentCreated(sender As Object) Handles TestWeb.DOMDocumentCreated
		Console.WriteLine(TestCounter & ": " & TestWeb.Source.ToString)
	End Sub

	Private Sub TestWeb_CoreWebView2Ready(sender As Object, e As EventArgs) Handles TestWeb.CoreWebView2Ready
		TestWeb.CoreWebView2.OpenDevToolsWindow()
	End Sub

	Private Sub TabView_NavigationStarting(Browser As WVBrowser, e As CoreWebView2NavigationStartingEventArgs) Handles TabView.NavigationStarting
		'If e.Uri.Contains("google") And Browser.AllowResourceContexts.Count = 0 Then
		'	Browser.AllowResourceContexts.Add(CoreWebView2WebResourceContext.Document)
		'Else
		'	Browser.AllowResourceContexts.Remove(CoreWebView2WebResourceContext.Document)
		'End If
	End Sub
End Class

