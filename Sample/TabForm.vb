Imports Microsoft.Web.WebView2.Core

Public Class TabForm

	Private Sub NavView_TextChanged(sender As Object, e As EventArgs) Handles NavView.TextChanged
		Text = NavView.Text
	End Sub

	Private Sub TabForm_Load(sender As Object, e As EventArgs) Handles Me.Load
		TabView.CreateTab(True, "google.co.uk")
		TabView.CreateTab(False, "bing.co.uk")
	End Sub

	Private Sub TabView_WindowRequested(sender As Object, e As CoreWebView2NewWindowRequestedEventArgs, ByRef Browser As WVBrowser) Handles TabView.WindowRequested
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
				Browser = Form.WebView2
				Form.Show(Me)
			End If
		End With
	End Sub
End Class

