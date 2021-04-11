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
		Me.components = New System.ComponentModel.Container()
		Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(TabForm))
		Me.BtnRefresh = New System.Windows.Forms.ToolStripButton()
		Me.ContextMenu = New System.Windows.Forms.ContextMenuStrip(Me.components)
		Me.ContextBack = New System.Windows.Forms.ToolStripMenuItem()
		Me.ContextForward = New System.Windows.Forms.ToolStripMenuItem()
		Me.ContextRefresh = New System.Windows.Forms.ToolStripMenuItem()
		Me.ContSepInspect = New System.Windows.Forms.ToolStripSeparator()
		Me.ContextInspect = New System.Windows.Forms.ToolStripMenuItem()
		Me.ContextCut = New System.Windows.Forms.ToolStripMenuItem()
		Me.ContextCopy = New System.Windows.Forms.ToolStripMenuItem()
		Me.ContextPaste = New System.Windows.Forms.ToolStripMenuItem()
		Me.NavView = New Aimco.WV2.WVNavStrip()
		Me.Test = New System.Windows.Forms.ToolStripButton()
		Me.TabView = New Aimco.WV2.WVTabStrip()
		Me.ContextMenu.SuspendLayout()
		Me.NavView.SuspendLayout()
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
		'ContextMenu
		'
		Me.ContextMenu.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.ContextMenu.ImageScalingSize = New System.Drawing.Size(24, 24)
		Me.ContextMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ContextBack, Me.ContextForward, Me.ContextRefresh, Me.ContSepInspect, Me.ContextInspect, Me.ContextCut, Me.ContextCopy, Me.ContextPaste})
		Me.ContextMenu.Name = "ContextMenu"
		Me.ContextMenu.Size = New System.Drawing.Size(126, 220)
		'
		'ContextBack
		'
		Me.ContextBack.BackColor = System.Drawing.Color.Transparent
		Me.ContextBack.Name = "ContextBack"
		Me.ContextBack.Padding = New System.Windows.Forms.Padding(0, 5, 0, 5)
		Me.ContextBack.Size = New System.Drawing.Size(125, 30)
		Me.ContextBack.Text = "Back"
		Me.ContextBack.Visible = False
		'
		'ContextForward
		'
		Me.ContextForward.BackColor = System.Drawing.Color.Transparent
		Me.ContextForward.Name = "ContextForward"
		Me.ContextForward.Padding = New System.Windows.Forms.Padding(0, 5, 0, 5)
		Me.ContextForward.Size = New System.Drawing.Size(125, 30)
		Me.ContextForward.Text = "Forward"
		Me.ContextForward.Visible = False
		'
		'ContextRefresh
		'
		Me.ContextRefresh.BackColor = System.Drawing.Color.Transparent
		Me.ContextRefresh.Name = "ContextRefresh"
		Me.ContextRefresh.Padding = New System.Windows.Forms.Padding(0, 5, 0, 5)
		Me.ContextRefresh.Size = New System.Drawing.Size(125, 30)
		Me.ContextRefresh.Text = "Refresh"
		Me.ContextRefresh.Visible = False
		'
		'ContSepInspect
		'
		Me.ContSepInspect.BackColor = System.Drawing.Color.Transparent
		Me.ContSepInspect.Name = "ContSepInspect"
		Me.ContSepInspect.Padding = New System.Windows.Forms.Padding(0, 5, 0, 5)
		Me.ContSepInspect.Size = New System.Drawing.Size(122, 6)
		Me.ContSepInspect.Visible = False
		'
		'ContextInspect
		'
		Me.ContextInspect.BackColor = System.Drawing.Color.Transparent
		Me.ContextInspect.Name = "ContextInspect"
		Me.ContextInspect.Padding = New System.Windows.Forms.Padding(0, 5, 0, 5)
		Me.ContextInspect.Size = New System.Drawing.Size(125, 30)
		Me.ContextInspect.Text = "Inspect"
		Me.ContextInspect.Visible = False
		'
		'ContextCut
		'
		Me.ContextCut.BackColor = System.Drawing.Color.Transparent
		Me.ContextCut.Name = "ContextCut"
		Me.ContextCut.Padding = New System.Windows.Forms.Padding(0, 5, 0, 5)
		Me.ContextCut.Size = New System.Drawing.Size(125, 30)
		Me.ContextCut.Text = "Cut"
		Me.ContextCut.Visible = False
		'
		'ContextCopy
		'
		Me.ContextCopy.BackColor = System.Drawing.Color.Transparent
		Me.ContextCopy.Name = "ContextCopy"
		Me.ContextCopy.Padding = New System.Windows.Forms.Padding(0, 5, 0, 5)
		Me.ContextCopy.Size = New System.Drawing.Size(125, 30)
		Me.ContextCopy.Text = "Copy"
		Me.ContextCopy.Visible = False
		'
		'ContextPaste
		'
		Me.ContextPaste.BackColor = System.Drawing.Color.Transparent
		Me.ContextPaste.Name = "ContextPaste"
		Me.ContextPaste.Padding = New System.Windows.Forms.Padding(0, 5, 0, 5)
		Me.ContextPaste.Size = New System.Drawing.Size(125, 30)
		Me.ContextPaste.Text = "Paste"
		Me.ContextPaste.Visible = False
		'
		'NavView
		'
		Me.NavView.AllowItemReorder = True
		Me.NavView.BackColor = System.Drawing.Color.WhiteSmoke
		Me.NavView.CanOverflow = False
		Me.NavView.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
		Me.NavView.ImageScalingSize = New System.Drawing.Size(24, 24)
		Me.NavView.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Test})
		Me.NavView.Location = New System.Drawing.Point(0, 44)
		Me.NavView.Name = "NavView"
		Me.NavView.Padding = New System.Windows.Forms.Padding(4)
		Me.NavView.Size = New System.Drawing.Size(784, 48)
		Me.NavView.TabIndex = 41
		Me.NavView.Text = "NavStrip1"
		'
		'Test
		'
		Me.Test.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
		Me.Test.Image = CType(resources.GetObject("Test.Image"), System.Drawing.Image)
		Me.Test.ImageTransparentColor = System.Drawing.Color.Magenta
		Me.Test.Name = "Test"
		Me.Test.Size = New System.Drawing.Size(28, 37)
		Me.Test.Text = "Test Navigate and Walk DOM"
		'
		'TabView
		'
		Me.TabView.BackColor = System.Drawing.Color.WhiteSmoke
		Me.TabView.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.TabView.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
		Me.TabView.Location = New System.Drawing.Point(0, 0)
		Me.TabView.MinimumSize = New System.Drawing.Size(0, 44)
		Me.TabView.Name = "TabView"
		Me.TabView.Padding = New System.Windows.Forms.Padding(4, 4, 4, 0)
		Me.TabView.Size = New System.Drawing.Size(784, 44)
		Me.TabView.TabActiveColor = System.Drawing.Color.WhiteSmoke
		Me.TabView.TabBackColor = System.Drawing.Color.Silver
		Me.TabView.TabBorderColor = System.Drawing.Color.Gainsboro
		Me.TabView.TabCornerRadius = 5
		Me.TabView.TabHoverColor = System.Drawing.Color.Gainsboro
		Me.TabView.TabIndex = 42
		Me.TabView.Text = "TabStrip1"
		'
		'TabForm
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.BackColor = System.Drawing.Color.Gainsboro
		Me.ClientSize = New System.Drawing.Size(784, 425)
		Me.Controls.Add(Me.NavView)
		Me.Controls.Add(Me.TabView)
		Me.Name = "TabForm"
		Me.Text = "TabForm"
		Me.ContextMenu.ResumeLayout(False)
		Me.NavView.ResumeLayout(False)
		Me.NavView.PerformLayout()
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub
	Friend WithEvents BtnRefresh As ToolStripButton
	Friend WithEvents AddBtn As AddButton
	Friend WithEvents NavView As WVNavStrip
	Friend WithEvents ContextMenu As ContextMenuStrip
	Friend WithEvents ContextBack As ToolStripMenuItem
	Friend WithEvents ContextForward As ToolStripMenuItem
	Friend WithEvents ContextRefresh As ToolStripMenuItem
	Friend WithEvents ContSepInspect As ToolStripSeparator
	Friend WithEvents ContextInspect As ToolStripMenuItem
	Friend WithEvents ContextCut As ToolStripMenuItem
	Friend WithEvents ContextCopy As ToolStripMenuItem
	Friend WithEvents ContextPaste As ToolStripMenuItem
	Friend WithEvents TabView As WVTabStrip
	Friend WithEvents Test As ToolStripButton
End Class
