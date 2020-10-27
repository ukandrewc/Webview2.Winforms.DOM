Friend Class PopForm

	Private Sub PopForm_Load(sender As Object, e As EventArgs) Handles Me.Load
		NavView.SetBrowser(Web)
	End Sub

	Private Sub WebView2_FaviconChanged() Handles Web.FaviconChanged
		Icon = Icon.FromHandle(New Bitmap(Web.Favicon).GetHicon)
	End Sub

	Private Sub WebView2_TextChanged(sender As Object, e As EventArgs) Handles Web.TextChanged
		Text = Web.Text
	End Sub
End Class

