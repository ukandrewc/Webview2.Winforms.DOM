<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class PopForm
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
		Me.components = New System.ComponentModel.Container()
		Dim WvCertificate2 As Aimco.WV2.WVCertificate = New Aimco.WV2.WVCertificate()
		Me.ConMenu = New System.Windows.Forms.ContextMenuStrip(Me.components)
		Me.TestToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.NavView = New Aimco.WV2.NavStrip()
		Me.Web = New Aimco.WV2.WVBrowser()
		Me.ConMenu.SuspendLayout()
		Me.SuspendLayout()
		'
		'ConMenu
		'
		Me.ConMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TestToolStripMenuItem})
		Me.ConMenu.Name = "ConMenu"
		Me.ConMenu.Size = New System.Drawing.Size(97, 26)
		'
		'TestToolStripMenuItem
		'
		Me.TestToolStripMenuItem.Name = "TestToolStripMenuItem"
		Me.TestToolStripMenuItem.Size = New System.Drawing.Size(96, 22)
		Me.TestToolStripMenuItem.Text = "Test"
		'
		'NavView
		'
		Me.NavView.BackColor = System.Drawing.Color.WhiteSmoke
		Me.NavView.CanOverflow = False
		Me.NavView.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
		Me.NavView.ImageScalingSize = New System.Drawing.Size(24, 24)
		Me.NavView.Location = New System.Drawing.Point(0, 0)
		Me.NavView.Name = "NavView"
		Me.NavView.Padding = New System.Windows.Forms.Padding(2)
		Me.NavView.Size = New System.Drawing.Size(800, 44)
		Me.NavView.TabIndex = 2
		Me.NavView.Text = "NavStrip1"
		'
		'Web
		'
		Me.Web.Certificate = WvCertificate2
		Me.Web.Dock = System.Windows.Forms.DockStyle.Fill
		Me.Web.Favicon = Nothing
		Me.Web.Location = New System.Drawing.Point(0, 44)
		Me.Web.Name = "Web"
		Me.Web.Size = New System.Drawing.Size(800, 406)
		Me.Web.Source = New System.Uri("about:blank", System.UriKind.Absolute)
		Me.Web.TabIndex = 0
		Me.Web.ZoomFactor = 1.0R
		'
		'PopForm
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(800, 450)
		Me.Controls.Add(Me.Web)
		Me.Controls.Add(Me.NavView)
		Me.Name = "PopForm"
		Me.Text = "PopForm"
		Me.ConMenu.ResumeLayout(False)
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub
	Friend WithEvents NavView As NavStrip
	Friend WithEvents ConMenu As ContextMenuStrip
	Friend WithEvents TestToolStripMenuItem As ToolStripMenuItem
	Friend WithEvents Web As WVBrowser
End Class
