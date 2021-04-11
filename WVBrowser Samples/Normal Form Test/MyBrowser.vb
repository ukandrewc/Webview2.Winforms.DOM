Public Class MyBrowser : Inherits WVBrowser

	Private Sub MyBrowser_DOMContentLoaded(sender As Object) Handles Me.DOMContentLoaded
		ExecuteScriptAsync("alert('My Browser')")
	End Sub
End Class
