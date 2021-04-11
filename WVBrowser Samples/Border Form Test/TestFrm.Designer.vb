<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class TestFrm
	Inherits Aimco.WV2.BorderFrm

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
		Me.NavView = New Aimco.WV2.WVNavStrip()
		Me.TabView = New Aimco.WV2.WVTabStrip()
		Me.SuspendLayout()
		'
		'NavView
		'
		Me.NavView.AllowItemReorder = True
		Me.NavView.BackColor = System.Drawing.Color.WhiteSmoke
		Me.NavView.CanOverflow = False
		Me.NavView.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
		Me.NavView.ImageScalingSize = New System.Drawing.Size(24, 24)
		Me.NavView.Location = New System.Drawing.Point(5, 46)
		Me.NavView.Name = "NavView"
		Me.NavView.Padding = New System.Windows.Forms.Padding(4)
		Me.NavView.Size = New System.Drawing.Size(811, 48)
		Me.NavView.TabIndex = 43
		Me.NavView.Text = "NavStrip1"
		'
		'TabView
		'
		Me.TabView.AllowDrop = True
		Me.TabView.BackColor = System.Drawing.Color.Transparent
		Me.TabView.CanOverflow = False
		Me.TabView.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
		Me.TabView.ImageScalingSize = New System.Drawing.Size(24, 24)
		Me.TabView.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow
		Me.TabView.Location = New System.Drawing.Point(5, 5)
		Me.TabView.MinimumSize = New System.Drawing.Size(0, 41)
		Me.TabView.Name = "TabView"
		Me.TabView.Padding = New System.Windows.Forms.Padding(4, 0, 4, 0)
		Me.TabView.Size = New System.Drawing.Size(811, 41)
		Me.TabView.TabActiveColor = System.Drawing.Color.WhiteSmoke
		Me.TabView.TabBackColor = System.Drawing.Color.Gainsboro
		Me.TabView.TabBorderColor = System.Drawing.Color.LightGray
		Me.TabView.TabCornerRadius = 5
		Me.TabView.TabHoverColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
		Me.TabView.TabIndex = 42
		Me.TabView.Text = "ZoomBar"
		'
		'TestFrm
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.BackColor = System.Drawing.Color.Gainsboro
		Me.BorderCololor = System.Drawing.Color.LightSteelBlue
		Me.ClientSize = New System.Drawing.Size(821, 472)
		Me.ControlDownColor = System.Drawing.Color.LightBlue
		Me.ControlHoverColor = System.Drawing.Color.Gold
		Me.Controls.Add(Me.NavView)
		Me.Controls.Add(Me.TabView)
		Me.Name = "TestFrm"
		Me.TitleHeight = 56
		Me.Controls.SetChildIndex(Me.TabView, 0)
		Me.Controls.SetChildIndex(Me.NavView, 0)
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub

	Friend WithEvents NavView As Aimco.WV2.WVNavStrip
	Friend WithEvents TabView As Aimco.WV2.WVTabStrip
End Class
