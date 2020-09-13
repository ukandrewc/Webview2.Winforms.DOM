<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class TabForm
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
		Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(TabForm))
		Me.BtnRefresh = New System.Windows.Forms.ToolStripButton()
		Me.NavView = New Aimco.WV2.NavStrip()
		Me.TabView = New Aimco.WV2.TabStrip()
		Me.SuspendLayout()
		'
		'BtnRefresh
		'
		Me.BtnRefresh.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
		Me.BtnRefresh.Image = CType(resources.GetObject("BtnRefresh.Image"), System.Drawing.Image)
		Me.BtnRefresh.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me.BtnRefresh.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
		Me.BtnRefresh.Name = "BtnRefresh"
		Me.BtnRefresh.Size = New System.Drawing.Size(75, 34)
		Me.BtnRefresh.Text = "Refresh"
		Me.BtnRefresh.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal
		Me.BtnRefresh.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
		'
		'NavView
		'
		Me.NavView.BackColor = System.Drawing.Color.WhiteSmoke
		Me.NavView.CanOverflow = False
		Me.NavView.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
		Me.NavView.ImageScalingSize = New System.Drawing.Size(24, 24)
		Me.NavView.Location = New System.Drawing.Point(0, 41)
		Me.NavView.Name = "NavView"
		Me.NavView.Padding = New System.Windows.Forms.Padding(4)
		Me.NavView.Size = New System.Drawing.Size(844, 48)
		Me.NavView.TabIndex = 41
		Me.NavView.Text = "NavStrip1"
		'
		'TabView
		'
		Me.TabView.AllowItemReorder = True
		Me.TabView.BackColor = System.Drawing.Color.WhiteSmoke
		Me.TabView.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
		Me.TabView.ImageScalingSize = New System.Drawing.Size(24, 24)
		Me.TabView.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow
		Me.TabView.Location = New System.Drawing.Point(0, 0)
		Me.TabView.Name = "TabView"
		Me.TabView.Padding = New System.Windows.Forms.Padding(2)
		Me.TabView.Size = New System.Drawing.Size(844, 41)
		Me.TabView.TabActiveColor = System.Drawing.Color.LightBlue
		Me.TabView.TabBackColor = System.Drawing.Color.WhiteSmoke
		Me.TabView.TabClickColor = System.Drawing.Color.Lavender
		Me.TabView.TabHoverColor = System.Drawing.Color.LightSkyBlue
		Me.TabView.TabIndex = 40
		Me.TabView.Text = "ZoomBar"
		'
		'TabForm
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.BackColor = System.Drawing.Color.Gainsboro
		Me.ClientSize = New System.Drawing.Size(844, 525)
		Me.Controls.Add(Me.NavView)
		Me.Controls.Add(Me.TabView)
		Me.Name = "TabForm"
		Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
		Me.Text = "Form2"
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub

	Friend WithEvents TabView As TabStrip
	Friend WithEvents BtnRefresh As ToolStripButton
	Friend WithEvents AddBtn As AddButton
	Friend WithEvents NavView As NavStrip
End Class
