Imports Aimco.WV2

Public Class TestFrm
	Private Sub TabView_BrowserRequested(Tab As TabButton, ByRef NewBrowser As WVBrowser) Handles TabView.BrowserRequested
		NewBrowser = New WVBrowser
		NewBrowser.Navigate("google.co.uk")
		NewBrowser.Dock = DockStyle.Fill
		Controls.Add(NewBrowser)
	End Sub

	Private Sub TestFrm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
		TabView.CreateTab("bing.co.uk", True)
		TabView.CreateTab("google.co.uk", True)
		TabView.CreateTab("yahoo.co.uk", True)
	End Sub
End Class
