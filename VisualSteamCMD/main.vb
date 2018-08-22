Public Class main

	'Public Variables
	Public gameid As String = ""

	Public installfolder As String = ""
	Public hasfirstrun As String = ""
	Public steamcmd As String = "C:\steamcmd\steamcmd.exe"
	Public vscmddebug As String = "No"
	Public debugpassword As String = "succmywigglydicknigga"
	Public vscmdversion As String = "v1.1"
	Public vscmdrelease As String = "Github Release"
	Public stepscomplete As String = "0,0,0"
	'End Public Variables

	'Commands that load as soon the program opens.
	Private Sub main_Load(sender As Object, e As EventArgs) Handles MyBase.Load
		FormBorderStyle = FormBorderStyle.FixedDialog
		MaximizeBox = False
		MinimizeBox = False
		AboutVersionLabel.Text = vscmdversion + vbCrLf + vscmdrelease

		If System.IO.File.Exists("C:\steamcmd\firstrun-complete.txt") Then
			hasfirstrun = "Yes"
		Else
			hasfirstrun = "No"
		End If

	End Sub

	'Setting the GameID
	Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
		gameid = InputBox("Enter SteamCMD GameID from the Link", "SteamCMD GameID Input", "Enter GameID From List")

		GameIDTextBox.Text = gameid
	End Sub

	'Download SteamCMD
	Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click

		If (Not System.IO.Directory.Exists("C:\steamcmd")) Then
			System.IO.Directory.CreateDirectory("C:\steamcmd")

			MessageBox.Show("Created SteamCMD Folder at Location: C:\SteamCMD\")
			ToolStripStatus.Text = "Downloading 'steamcmd.exe'"
			ToolStripStatus.ForeColor = Color.OliveDrab
			My.Computer.Network.DownloadFile(
		"http://jyles.pw/steamcmd.exe",
		"C:\steamcmd\steamcmd.exe")
			MessageBox.Show("Downloaded SteamCMD EXE to: C:\SteamCMD\SteamCMD.exe")
			ToolStripStatus.ForeColor = Color.Black
			ToolStripStatus.Text = "Downloaded 'steamcmd.exe'"
		Else
			ToolStripStatus.ForeColor = Color.Black
			ToolStripStatus.Text = "Idle"
			MessageBox.Show("File has already been downloaded. Skipping Step")
		End If

		If System.IO.File.Exists("C:\steamcmd\firstrun-complete.txt") Then
			MessageBox.Show("You have already done a first run. Skipping Step.")
		Else

			'First Start of SteamCMD to Update'
			Dim firstStart As New ProcessStartInfo
			firstStart.FileName = steamcmd
			firstStart.Arguments = "+quit"
			Process.Start(firstStart)

			System.IO.File.Create("C:\steamcmd\firstrun-complete.txt").Dispose()
		End If

	End Sub

	'Set Install Location
	Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
		Dim folderDlg As New FolderBrowserDialog

		folderDlg.ShowNewFolderButton = True

		If (folderDlg.ShowDialog() = DialogResult.OK) Then

			installfolder = folderDlg.SelectedPath

			Dim root As Environment.SpecialFolder = folderDlg.RootFolder

		End If
		InstallLocationTextBox.Text = installfolder
	End Sub

	'Start Game Server Install
	Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

		ToolStripStatus.Text = "Installing Dedicated Server"
		ToolStripStatus.ForeColor = Color.OliveDrab

		Threading.Thread.Sleep(1000)

		Dim startInfo As New ProcessStartInfo
		startInfo.FileName = "C:\steamcmd\steamcmd.exe"
		startInfo.Arguments = "+login anonymous +force_install_dir " & installfolder & " +app_update " & gameid & " validate +quit"
		Process.Start(startInfo)

		Dim p() As Process = Process.GetProcessesByName("steamcmd.exe")

		Threading.Thread.Sleep(5000)

		If p.Count > 0 Then
			MessageBox.Show("Dedicated Server Installed!")

			ToolStripStatus.ForeColor = Color.Black
			ToolStripStatus.Text = "Idle"
		End If
	End Sub

	'When the Dark Theme Radio is enabled
	Private Sub DarkThemeRadio_CheckedChanged(sender As Object, e As EventArgs) Handles DarkThemeRadio.CheckedChanged
		SelectThemeLabel.ForeColor = Color.White
		SelectThemeLabel.BackColor = Color.Black

		PictureBox1.Image = VisualSteamCMD.My.Resources.Resources.welcome_dark
		PictureBox2.Image = VisualSteamCMD.My.Resources.Resources.about_dark

		LightThemeRadio.ForeColor = Color.White
		LightThemeRadio.BackColor = Color.Black

		DarkThemeRadio.ForeColor = Color.White
		DarkThemeRadio.BackColor = Color.Black

		SetupTitleLabel.ForeColor = Color.White
		SetupTitleLabel.BackColor = Color.Black

		SetupDescriptionLabel.ForeColor = Color.White
		SetupDescriptionLabel.BackColor = Color.Black

		BackColor = Color.Black

		StatusLabel.ForeColor = Color.White
		StatusLabel.BackColor = Color.Black

		CompanyLabelToolStrip.ForeColor = Color.White
		CompanyLabelToolStrip.BackColor = Color.Black

		StatusStrip1.ForeColor = Color.White
		StatusStrip1.BackColor = Color.Black

		TabPage1.BackColor = Color.Black
		TabPage2.BackColor = Color.Black
		TabPage3.BackColor = Color.Black
		TabPage4.BackColor = Color.Black

		AboutVersionLabel.ForeColor = Color.White

	End Sub

	Private Sub LightThemeRadio_CheckedChanged(sender As Object, e As EventArgs) Handles LightThemeRadio.CheckedChanged
		SelectThemeLabel.ForeColor = Color.Black
		SelectThemeLabel.BackColor = Color.White

		PictureBox1.Image = VisualSteamCMD.My.Resources.Resources.welcome
		PictureBox2.Image = VisualSteamCMD.My.Resources.Resources.about_light

		LightThemeRadio.ForeColor = Color.Black
		LightThemeRadio.BackColor = Color.White

		DarkThemeRadio.ForeColor = Color.Black
		DarkThemeRadio.BackColor = Color.White

		SetupTitleLabel.ForeColor = Color.Black
		SetupTitleLabel.BackColor = Color.White

		SetupDescriptionLabel.ForeColor = Color.Black
		SetupDescriptionLabel.BackColor = Color.White

		BackColor = Color.White

		StatusLabel.ForeColor = Color.Black
		StatusLabel.BackColor = Color.White

		CompanyLabelToolStrip.ForeColor = Color.Black
		CompanyLabelToolStrip.BackColor = Color.White

		StatusStrip1.ForeColor = Color.Black
		StatusStrip1.BackColor = Color.White

		TabPage1.BackColor = Color.White
		TabPage2.BackColor = Color.White
		TabPage3.BackColor = Color.White
		TabPage4.BackColor = Color.White

		AboutVersionLabel.ForeColor = Color.Black
	End Sub

End Class