<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
	Inherits System.Windows.Forms.Form

	'Form overrides dispose to clean up the component list.
	<System.Diagnostics.DebuggerNonUserCode()>
	Protected Overrides Sub Dispose(ByVal disposing As Boolean)
		Try
			If disposing AndAlso components IsNot Nothing Then
				components.Dispose()
			End If
		Finally
			MyBase.Dispose(disposing)
		End Try
	End Sub

	'Required by the Windows Form Designer
	Private components As System.ComponentModel.IContainer

	'NOTE: The following procedure is required by the Windows Form Designer
	'It can be modified using the Windows Form Designer.  
	'Do not modify it using the code editor.
	<System.Diagnostics.DebuggerStepThrough()>
	Private Sub InitializeComponent()
		Me.LblMessage = New System.Windows.Forms.Label()
		Me.TxtAddress = New System.Windows.Forms.TextBox()
		Me.WebView2 = New Aimco.DOMWebView2.WVBrowser
		'
		'LblMessage
		'
		Me.LblMessage.Dock = System.Windows.Forms.DockStyle.Bottom
		Me.LblMessage.Location = New System.Drawing.Point(0, 430)
		Me.LblMessage.Name = "LblMessage"
		Me.LblMessage.Padding = New System.Windows.Forms.Padding(2)
		Me.LblMessage.Size = New System.Drawing.Size(800, 20)
		Me.LblMessage.TabIndex = 1
		Me.LblMessage.Text = "Label1"
		Me.LblMessage.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		'
		'TxtAddress
		'
		Me.TxtAddress.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.TxtAddress.Dock = System.Windows.Forms.DockStyle.Top
		Me.TxtAddress.Location = New System.Drawing.Point(0, 0)
		Me.TxtAddress.Name = "TxtAddress"
		Me.TxtAddress.Size = New System.Drawing.Size(800, 20)
		Me.TxtAddress.TabIndex = 2
		'
		'WebView2
		'
		Me.WebView2.CustomEventsToRaise = "scroll"
		Me.WebView2.Dock = System.Windows.Forms.DockStyle.Fill
		Me.WebView2.Location = New System.Drawing.Point(0, 20)
		Me.WebView2.Name = "WebView2"
		Me.WebView2.RaiseClickEvents = True
		Me.WebView2.RaiseContextMenu = False
		Me.WebView2.RaiseInputEvents = True
		Me.WebView2.RaiseKeyEvents = False
		Me.WebView2.RaiseMouseEvents = True
		Me.WebView2.Size = New System.Drawing.Size(800, 410)
		Me.WebView2.TabIndex = 0
		'
		'Form1
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(800, 450)
		Me.Controls.Add(Me.WebView2)
		Me.Controls.Add(Me.TxtAddress)
		Me.Controls.Add(Me.LblMessage)
		Me.Name = "Form1"
		Me.Text = "Form1"
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub

	Friend WithEvents WebView2 As Aimco.DOMWebView2.WVBrowser
	Friend WithEvents LblMessage As Label
	Friend WithEvents TxtAddress As TextBox
End Class
