Imports Aimco.WV2

Public Class TestFrm

	Private WithEvents Body As WVElement

	Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
		NavStrip1.SetBrowser(WvBrowser1)
	End Sub

	Private Sub WvBrowser1_DOMTitleChanged(Sender As Object, Title As String) Handles WvBrowser1.DOMTitleChanged
		Text = Title
	End Sub

	Private Sub WvBrowser1_DOMDocumentComplete(sender As Object) Handles WvBrowser1.DOMDocumentComplete
		Body = WvBrowser1.Document.body
		Body.AddEventHandler("mouseover")
		Body.AddEventHandler("mouseup")
	End Sub

	Private Sub Body_DOMEventAsync(Type As String, e As WVEvent) Handles Body.DOMEventAsync
		If Type = "mouseover" Then
			ElemLabel.Text = WvBrowser1.document.elementFromPoint(New Point(e.pageX, e.pageY)).tagName
		ElseIf Type = "mouseup" Then
			ElemLabel.Text = WvBrowser1.document.getSelection.toString
		End If
	End Sub
End Class
