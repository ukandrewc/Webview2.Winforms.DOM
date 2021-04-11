
Public Class TestFrm
	Private Sub TabView_BrowserRequested(Tab As WVTabButton, ByRef NewBrowser As WVBrowser) Handles TabView.BrowserRequested
		NewBrowser = New WVBrowser
		NewBrowser.Dock = DockStyle.Fill
		NewBrowser.Navigate("google.co.uk")
		Controls.Add(NewBrowser)
	End Sub

	Private Sub TestFrm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
		TabView.CreateTab("google.co.uk", True)
	End Sub
End Class
