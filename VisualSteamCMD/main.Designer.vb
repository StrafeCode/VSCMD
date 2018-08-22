<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class main
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
		Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(main))
		Me.TabControl1 = New System.Windows.Forms.TabControl()
		Me.TabPage1 = New System.Windows.Forms.TabPage()
		Me.PictureBox1 = New System.Windows.Forms.PictureBox()
		Me.TabPage2 = New System.Windows.Forms.TabPage()
		Me.SetupDescriptionLabel = New System.Windows.Forms.Label()
		Me.Label6 = New System.Windows.Forms.Label()
		Me.Label5 = New System.Windows.Forms.Label()
		Me.Label4 = New System.Windows.Forms.Label()
		Me.Label3 = New System.Windows.Forms.Label()
		Me.SetupTitleLabel = New System.Windows.Forms.Label()
		Me.Button4 = New System.Windows.Forms.Button()
		Me.InstallLocationTextBox = New System.Windows.Forms.TextBox()
		Me.Button3 = New System.Windows.Forms.Button()
		Me.Button2 = New System.Windows.Forms.Button()
		Me.GameIDTextBox = New System.Windows.Forms.TextBox()
		Me.Button1 = New System.Windows.Forms.Button()
		Me.TabPage3 = New System.Windows.Forms.TabPage()
		Me.SelectThemeLabel = New System.Windows.Forms.Label()
		Me.DarkThemeRadio = New System.Windows.Forms.RadioButton()
		Me.LightThemeRadio = New System.Windows.Forms.RadioButton()
		Me.TabPage4 = New System.Windows.Forms.TabPage()
		Me.AboutVersionLabel = New System.Windows.Forms.Label()
		Me.PictureBox2 = New System.Windows.Forms.PictureBox()
		Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
		Me.StatusLabel = New System.Windows.Forms.ToolStripStatusLabel()
		Me.ToolStripStatus = New System.Windows.Forms.ToolStripStatusLabel()
		Me.CompanyLabelToolStrip = New System.Windows.Forms.Label()
		Me.TabControl1.SuspendLayout()
		Me.TabPage1.SuspendLayout()
		CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.TabPage2.SuspendLayout()
		Me.TabPage3.SuspendLayout()
		Me.TabPage4.SuspendLayout()
		CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.StatusStrip1.SuspendLayout()
		Me.SuspendLayout()
		'
		'TabControl1
		'
		Me.TabControl1.Controls.Add(Me.TabPage1)
		Me.TabControl1.Controls.Add(Me.TabPage2)
		Me.TabControl1.Controls.Add(Me.TabPage3)
		Me.TabControl1.Controls.Add(Me.TabPage4)
		Me.TabControl1.Location = New System.Drawing.Point(-7, 2)
		Me.TabControl1.Name = "TabControl1"
		Me.TabControl1.SelectedIndex = 0
		Me.TabControl1.Size = New System.Drawing.Size(406, 429)
		Me.TabControl1.TabIndex = 0
		'
		'TabPage1
		'
		Me.TabPage1.Controls.Add(Me.PictureBox1)
		Me.TabPage1.Location = New System.Drawing.Point(4, 22)
		Me.TabPage1.Name = "TabPage1"
		Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
		Me.TabPage1.Size = New System.Drawing.Size(398, 403)
		Me.TabPage1.TabIndex = 0
		Me.TabPage1.Text = "Welcome"
		Me.TabPage1.UseVisualStyleBackColor = True
		'
		'PictureBox1
		'
		Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
		Me.PictureBox1.Image = Global.VisualSteamCMD.My.Resources.Resources.welcome
		Me.PictureBox1.Location = New System.Drawing.Point(3, 0)
		Me.PictureBox1.Name = "PictureBox1"
		Me.PictureBox1.Size = New System.Drawing.Size(395, 406)
		Me.PictureBox1.TabIndex = 0
		Me.PictureBox1.TabStop = False
		'
		'TabPage2
		'
		Me.TabPage2.Controls.Add(Me.SetupDescriptionLabel)
		Me.TabPage2.Controls.Add(Me.Label6)
		Me.TabPage2.Controls.Add(Me.Label5)
		Me.TabPage2.Controls.Add(Me.Label4)
		Me.TabPage2.Controls.Add(Me.Label3)
		Me.TabPage2.Controls.Add(Me.SetupTitleLabel)
		Me.TabPage2.Controls.Add(Me.Button4)
		Me.TabPage2.Controls.Add(Me.InstallLocationTextBox)
		Me.TabPage2.Controls.Add(Me.Button3)
		Me.TabPage2.Controls.Add(Me.Button2)
		Me.TabPage2.Controls.Add(Me.GameIDTextBox)
		Me.TabPage2.Controls.Add(Me.Button1)
		Me.TabPage2.Location = New System.Drawing.Point(4, 22)
		Me.TabPage2.Name = "TabPage2"
		Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
		Me.TabPage2.Size = New System.Drawing.Size(398, 403)
		Me.TabPage2.TabIndex = 1
		Me.TabPage2.Text = "Setup"
		Me.TabPage2.UseVisualStyleBackColor = True
		'
		'SetupDescriptionLabel
		'
		Me.SetupDescriptionLabel.AutoSize = True
		Me.SetupDescriptionLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.SetupDescriptionLabel.Location = New System.Drawing.Point(20, 112)
		Me.SetupDescriptionLabel.Name = "SetupDescriptionLabel"
		Me.SetupDescriptionLabel.Size = New System.Drawing.Size(263, 20)
		Me.SetupDescriptionLabel.TabIndex = 11
		Me.SetupDescriptionLabel.Text = "You can do these steps in any order"
		'
		'Label6
		'
		Me.Label6.AutoSize = True
		Me.Label6.Location = New System.Drawing.Point(265, 119)
		Me.Label6.Name = "Label6"
		Me.Label6.Size = New System.Drawing.Size(16, 13)
		Me.Label6.TabIndex = 10
		Me.Label6.Text = "   "
		'
		'Label5
		'
		Me.Label5.AutoSize = True
		Me.Label5.Location = New System.Drawing.Point(10, 119)
		Me.Label5.Name = "Label5"
		Me.Label5.Size = New System.Drawing.Size(13, 13)
		Me.Label5.TabIndex = 9
		Me.Label5.Text = "  "
		'
		'Label4
		'
		Me.Label4.AutoSize = True
		Me.Label4.Location = New System.Drawing.Point(128, 119)
		Me.Label4.Name = "Label4"
		Me.Label4.Size = New System.Drawing.Size(10, 13)
		Me.Label4.TabIndex = 8
		Me.Label4.Text = " "
		'
		'Label3
		'
		Me.Label3.AutoSize = True
		Me.Label3.Location = New System.Drawing.Point(10, 120)
		Me.Label3.Name = "Label3"
		Me.Label3.Size = New System.Drawing.Size(0, 13)
		Me.Label3.TabIndex = 7
		'
		'SetupTitleLabel
		'
		Me.SetupTitleLabel.AutoSize = True
		Me.SetupTitleLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.SetupTitleLabel.Location = New System.Drawing.Point(18, 29)
		Me.SetupTitleLabel.Name = "SetupTitleLabel"
		Me.SetupTitleLabel.Size = New System.Drawing.Size(353, 31)
		Me.SetupTitleLabel.TabIndex = 6
		Me.SetupTitleLabel.Text = "Installing Your Game Server"
		'
		'Button4
		'
		Me.Button4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Button4.Location = New System.Drawing.Point(128, 192)
		Me.Button4.Name = "Button4"
		Me.Button4.Size = New System.Drawing.Size(146, 23)
		Me.Button4.TabIndex = 5
		Me.Button4.Text = "Download SteamCMD"
		Me.Button4.UseVisualStyleBackColor = True
		'
		'InstallLocationTextBox
		'
		Me.InstallLocationTextBox.Location = New System.Drawing.Point(280, 207)
		Me.InstallLocationTextBox.Name = "InstallLocationTextBox"
		Me.InstallLocationTextBox.Size = New System.Drawing.Size(112, 20)
		Me.InstallLocationTextBox.TabIndex = 4
		Me.InstallLocationTextBox.Text = "Location Not Set"
		'
		'Button3
		'
		Me.Button3.Location = New System.Drawing.Point(280, 178)
		Me.Button3.Name = "Button3"
		Me.Button3.Size = New System.Drawing.Size(112, 23)
		Me.Button3.TabIndex = 3
		Me.Button3.Text = "Set Install Location"
		Me.Button3.UseVisualStyleBackColor = True
		'
		'Button2
		'
		Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Button2.Location = New System.Drawing.Point(10, 338)
		Me.Button2.Name = "Button2"
		Me.Button2.Size = New System.Drawing.Size(370, 56)
		Me.Button2.TabIndex = 2
		Me.Button2.Text = "Complete Setup"
		Me.Button2.UseVisualStyleBackColor = True
		'
		'GameIDTextBox
		'
		Me.GameIDTextBox.Location = New System.Drawing.Point(7, 207)
		Me.GameIDTextBox.Name = "GameIDTextBox"
		Me.GameIDTextBox.Size = New System.Drawing.Size(115, 20)
		Me.GameIDTextBox.TabIndex = 1
		Me.GameIDTextBox.Text = "GameID Not Set"
		'
		'Button1
		'
		Me.Button1.Location = New System.Drawing.Point(6, 178)
		Me.Button1.Name = "Button1"
		Me.Button1.Size = New System.Drawing.Size(116, 23)
		Me.Button1.TabIndex = 0
		Me.Button1.Text = "Set GameID"
		Me.Button1.UseVisualStyleBackColor = True
		'
		'TabPage3
		'
		Me.TabPage3.Controls.Add(Me.SelectThemeLabel)
		Me.TabPage3.Controls.Add(Me.DarkThemeRadio)
		Me.TabPage3.Controls.Add(Me.LightThemeRadio)
		Me.TabPage3.Location = New System.Drawing.Point(4, 22)
		Me.TabPage3.Name = "TabPage3"
		Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
		Me.TabPage3.Size = New System.Drawing.Size(398, 403)
		Me.TabPage3.TabIndex = 2
		Me.TabPage3.Text = "Options"
		Me.TabPage3.UseVisualStyleBackColor = True
		'
		'SelectThemeLabel
		'
		Me.SelectThemeLabel.AutoSize = True
		Me.SelectThemeLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
		Me.SelectThemeLabel.Location = New System.Drawing.Point(9, 34)
		Me.SelectThemeLabel.Name = "SelectThemeLabel"
		Me.SelectThemeLabel.Size = New System.Drawing.Size(95, 17)
		Me.SelectThemeLabel.TabIndex = 2
		Me.SelectThemeLabel.Text = "Select Theme"
		'
		'DarkThemeRadio
		'
		Me.DarkThemeRadio.AutoSize = True
		Me.DarkThemeRadio.Location = New System.Drawing.Point(10, 77)
		Me.DarkThemeRadio.Name = "DarkThemeRadio"
		Me.DarkThemeRadio.Size = New System.Drawing.Size(84, 17)
		Me.DarkThemeRadio.TabIndex = 1
		Me.DarkThemeRadio.Text = "Dark Theme"
		Me.DarkThemeRadio.UseVisualStyleBackColor = True
		'
		'LightThemeRadio
		'
		Me.LightThemeRadio.AutoSize = True
		Me.LightThemeRadio.Checked = True
		Me.LightThemeRadio.Location = New System.Drawing.Point(10, 54)
		Me.LightThemeRadio.Name = "LightThemeRadio"
		Me.LightThemeRadio.Size = New System.Drawing.Size(84, 17)
		Me.LightThemeRadio.TabIndex = 0
		Me.LightThemeRadio.TabStop = True
		Me.LightThemeRadio.Text = "Light Theme"
		Me.LightThemeRadio.UseVisualStyleBackColor = True
		'
		'TabPage4
		'
		Me.TabPage4.Controls.Add(Me.AboutVersionLabel)
		Me.TabPage4.Controls.Add(Me.PictureBox2)
		Me.TabPage4.Location = New System.Drawing.Point(4, 22)
		Me.TabPage4.Name = "TabPage4"
		Me.TabPage4.Padding = New System.Windows.Forms.Padding(3)
		Me.TabPage4.Size = New System.Drawing.Size(398, 403)
		Me.TabPage4.TabIndex = 3
		Me.TabPage4.Text = "About"
		Me.TabPage4.UseVisualStyleBackColor = True
		'
		'AboutVersionLabel
		'
		Me.AboutVersionLabel.AutoSize = True
		Me.AboutVersionLabel.ImageAlign = System.Drawing.ContentAlignment.TopLeft
		Me.AboutVersionLabel.Location = New System.Drawing.Point(312, 374)
		Me.AboutVersionLabel.Name = "AboutVersionLabel"
		Me.AboutVersionLabel.RightToLeft = System.Windows.Forms.RightToLeft.Yes
		Me.AboutVersionLabel.Size = New System.Drawing.Size(80, 26)
		Me.AboutVersionLabel.TabIndex = 1
		Me.AboutVersionLabel.Text = "v1.1" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Github Release"
		'
		'PictureBox2
		'
		Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
		Me.PictureBox2.InitialImage = CType(resources.GetObject("PictureBox2.InitialImage"), System.Drawing.Image)
		Me.PictureBox2.Location = New System.Drawing.Point(6, 6)
		Me.PictureBox2.Name = "PictureBox2"
		Me.PictureBox2.Size = New System.Drawing.Size(389, 394)
		Me.PictureBox2.TabIndex = 0
		Me.PictureBox2.TabStop = False
		'
		'StatusStrip1
		'
		Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.StatusLabel, Me.ToolStripStatus})
		Me.StatusStrip1.Location = New System.Drawing.Point(0, 433)
		Me.StatusStrip1.Name = "StatusStrip1"
		Me.StatusStrip1.Size = New System.Drawing.Size(395, 22)
		Me.StatusStrip1.TabIndex = 1
		Me.StatusStrip1.Text = "StatusStrip"
		'
		'StatusLabel
		'
		Me.StatusLabel.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.StatusLabel.Name = "StatusLabel"
		Me.StatusLabel.Size = New System.Drawing.Size(53, 17)
		Me.StatusLabel.Text = "STATUS:"
		'
		'ToolStripStatus
		'
		Me.ToolStripStatus.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.ToolStripStatus.Name = "ToolStripStatus"
		Me.ToolStripStatus.Size = New System.Drawing.Size(39, 17)
		Me.ToolStripStatus.Text = "status"
		'
		'CompanyLabelToolStrip
		'
		Me.CompanyLabelToolStrip.AutoSize = True
		Me.CompanyLabelToolStrip.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.CompanyLabelToolStrip.Location = New System.Drawing.Point(312, 438)
		Me.CompanyLabelToolStrip.Name = "CompanyLabelToolStrip"
		Me.CompanyLabelToolStrip.Padding = New System.Windows.Forms.Padding(0, 0, 0, 4)
		Me.CompanyLabelToolStrip.Size = New System.Drawing.Size(83, 17)
		Me.CompanyLabelToolStrip.TabIndex = 2
		Me.CompanyLabelToolStrip.Text = "StrafeCode.com"
		'
		'main
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(395, 455)
		Me.Controls.Add(Me.CompanyLabelToolStrip)
		Me.Controls.Add(Me.StatusStrip1)
		Me.Controls.Add(Me.TabControl1)
		Me.Name = "main"
		Me.Text = "Visual SteamCMD // By StrafeCode.com"
		Me.TabControl1.ResumeLayout(False)
		Me.TabPage1.ResumeLayout(False)
		CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
		Me.TabPage2.ResumeLayout(False)
		Me.TabPage2.PerformLayout()
		Me.TabPage3.ResumeLayout(False)
		Me.TabPage3.PerformLayout()
		Me.TabPage4.ResumeLayout(False)
		Me.TabPage4.PerformLayout()
		CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
		Me.StatusStrip1.ResumeLayout(False)
		Me.StatusStrip1.PerformLayout()
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub

	Friend WithEvents TabControl1 As TabControl
	Friend WithEvents TabPage1 As TabPage
	Friend WithEvents TabPage2 As TabPage
	Friend WithEvents TabPage3 As TabPage
	Friend WithEvents TabPage4 As TabPage
	Friend WithEvents PictureBox1 As PictureBox
	Friend WithEvents DarkThemeRadio As RadioButton
	Friend WithEvents LightThemeRadio As RadioButton
	Friend WithEvents SelectThemeLabel As Label
	Friend WithEvents Button1 As Button
	Friend WithEvents GameIDTextBox As TextBox
	Friend WithEvents Label6 As Label
	Friend WithEvents Label5 As Label
	Friend WithEvents Label4 As Label
	Friend WithEvents Label3 As Label
	Friend WithEvents SetupTitleLabel As Label
	Friend WithEvents Button4 As Button
	Friend WithEvents InstallLocationTextBox As TextBox
	Friend WithEvents Button3 As Button
	Friend WithEvents Button2 As Button
	Friend WithEvents StatusStrip1 As StatusStrip
	Friend WithEvents StatusLabel As ToolStripStatusLabel
	Friend WithEvents ToolStripStatus As ToolStripStatusLabel
	Friend WithEvents CompanyLabelToolStrip As Label
	Friend WithEvents SetupDescriptionLabel As Label
	Friend WithEvents PictureBox2 As PictureBox
	Friend WithEvents AboutVersionLabel As Label
End Class
