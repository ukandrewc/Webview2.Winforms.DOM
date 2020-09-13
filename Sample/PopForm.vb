Friend Class PopForm

	Private Sub PopForm_Load(sender As Object, e As EventArgs) Handles Me.Load
		NavView.SetBrowser(WebView2)
	End Sub

	Private Sub WebView2_FaviconChanged() Handles WebView2.FaviconChanged
		Icon = Icon.FromHandle(New Bitmap(WebView2.Favicon).GetHicon)
	End Sub

	Private Sub WebView2_TextChanged(sender As Object, e As EventArgs) Handles WebView2.TextChanged
		Text = WebView2.Text
	End Sub
End Class

