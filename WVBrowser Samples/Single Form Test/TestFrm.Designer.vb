<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TestFrm
	Inherits System.Windows.Forms.Form

	'Form overrides dispose to clean up the component list.
	<System.Diagnostics.DebuggerNonUserCode()> _
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
	<System.Diagnostics.DebuggerStepThrough()> _
	Private Sub InitializeComponent()
		Dim WvCertificate1 As Aimco.WV2.WVCertificate = New Aimco.WV2.WVCertificate()
		Me.WvBrowser1 = New Aimco.WV2.WVBrowser()
		Me.NavStrip1 = New Aimco.WV2.WVNavStrip()
		Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
		Me.ElemLabel = New System.Windows.Forms.ToolStripStatusLabel()
		CType(Me.WvBrowser1, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.StatusStrip1.SuspendLayout()
		Me.SuspendLayout()
		'
		'WvBrowser1
		'
		Me.WvBrowser1.Certificate = WvCertificate1
		Me.WvBrowser1.CreationProperties = Nothing
		Me.WvBrowser1.DefaultBackgroundColor = System.Drawing.Color.White
		Me.WvBrowser1.Dock = System.Windows.Forms.DockStyle.Fill
		Me.WvBrowser1.Favicon = Nothing
		Me.WvBrowser1.Location = New System.Drawing.Point(0, 44)
		Me.WvBrowser1.Name = "WvBrowser1"
		Me.WvBrowser1.ObserveAttributes = False
		Me.WvBrowser1.ObserveEnabled = True
		Me.WvBrowser1.ObserveTimeOut = 1000
		Me.WvBrowser1.Size = New System.Drawing.Size(800, 384)
		Me.WvBrowser1.Source = New System.Uri("https://google.co.uk", System.UriKind.Absolute)
		Me.WvBrowser1.TabIndex = 0
		Me.WvBrowser1.Url = "https://google.co.uk/"
		Me.WvBrowser1.ZoomFactor = 1.0R
		'
		'NavStrip1
		'
		Me.NavStrip1.BackColor = System.Drawing.Color.WhiteSmoke
		Me.NavStrip1.CanOverflow = False
		Me.NavStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
		Me.NavStrip1.ImageScalingSize = New System.Drawing.Size(24, 24)
		Me.NavStrip1.Location = New System.Drawing.Point(0, 0)
		Me.NavStrip1.Name = "NavStrip1"
		Me.NavStrip1.Padding = New System.Windows.Forms.Padding(2)
		Me.NavStrip1.Size = New System.Drawing.Size(800, 44)
		Me.NavStrip1.TabIndex = 1
		Me.NavStrip1.Text = "NavStrip1"
		'
		'StatusStrip1
		'
		Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ElemLabel})
		Me.StatusStrip1.Location = New System.Drawing.Point(0, 428)
		Me.StatusStrip1.Name = "StatusStrip1"
		Me.StatusStrip1.Size = New System.Drawing.Size(800, 22)
		Me.StatusStrip1.TabIndex = 2
		Me.StatusStrip1.Text = "StatusStrip1"
		'
		'ElemLabel
		'
		Me.ElemLabel.Name = "ElemLabel"
		Me.ElemLabel.Size = New System.Drawing.Size(27, 17)
		Me.ElemLabel.Text = "FPS"
		'
		'TestFrm
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(800, 450)
		Me.Controls.Add(Me.WvBrowser1)
		Me.Controls.Add(Me.StatusStrip1)
		Me.Controls.Add(Me.NavStrip1)
		Me.Name = "TestFrm"
		Me.Text = "Form1"
		CType(Me.WvBrowser1, System.ComponentModel.ISupportInitialize).EndInit()
		Me.StatusStrip1.ResumeLayout(False)
		Me.StatusStrip1.PerformLayout()
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub

	Friend WithEvents WvBrowser1 As Aimco.WV2.WVBrowser
	Friend WithEvents NavStrip1 As Aimco.WV2.WVNavStrip
	Friend WithEvents StatusStrip1 As StatusStrip
	Friend WithEvents ElemLabel As ToolStripStatusLabel
End Class
