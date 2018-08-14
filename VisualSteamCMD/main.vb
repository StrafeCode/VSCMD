Public Class main
    Public gameid As String = "nul"
    Public installfolder As String = "nul"
    Public steamcmd As String = "C:\steamcmd\steamcmd.exe"
	Private Sub DownloadSteamCMD_Click(sender As Object, e As EventArgs) Handles DownloadSteamCMD.Click



		If (Not System.IO.Directory.Exists("C:\steamcmd")) Then
			System.IO.Directory.CreateDirectory("C:\steamcmd")

			MessageBox.Show("Created SteamCMD Folder at Location: C:\SteamCMD\")
			ToolStripStatus.Text = "Downloading 'steamcmd.exe'"
			ToolStripStatus.ForeColor = Color.OliveDrab
			My.Computer.Network.DownloadFile(
		"http://jyles.pw/steamcmd.exe",
		"C:\steamcmd\steamcmd.exe")
			MessageBox.Show("Downloaded SteamCMD EXE to: C:\SteamCMD\SteamCME.exe")
			ToolStripStatus.ForeColor = Color.Black
			ToolStripStatus.Text = "Downloaded 'steamcmd.exe'"
		Else
			ToolStripStatus.ForeColor = Color.Black
			ToolStripStatus.Text = "Idle"
			MessageBox.Show("File has already been downloaded. Skipping Step")
		End If

		Threading.Thread.Sleep(1000)
	End Sub

	Private Sub FirstRun_Click(sender As Object, e As EventArgs) Handles FirstRun.Click
        Dim proc As New System.Diagnostics.Process()
        MessageBox.Show("A Window will open up, Dont worry! This will install SteamCMD, Do NOT close the window. It will Close itself.")
		ToolStripStatus.Text = "Running 'steamcmd.exe'"
		ToolStripStatus.ForeColor = Color.OliveDrab

		'First Start of SteamCMD to Update'
		Dim firstStart As New ProcessStartInfo
        firstStart.FileName = steamcmd
        firstStart.Arguments = "+quit"
        Process.Start(firstStart)

        MessageBox.Show("SteamCMD has finished installing, it should of installed by now and closed itself. You can now continue to Step 2.")

		ToolStripStatus.ForeColor = Color.Black
		ToolStripStatus.Text = "Idle"
	End Sub

	Private Sub InstallLocation_Click(sender As Object, e As EventArgs) Handles InstallLocation.Click
        Dim folderDlg As New FolderBrowserDialog

        folderDlg.ShowNewFolderButton = True

		If (folderDlg.ShowDialog() = DialogResult.OK) Then

			installfolder = folderDlg.SelectedPath

			Dim root As Environment.SpecialFolder = folderDlg.RootFolder

		End If
		InstallLocationDisplay.Text = installfolder
	End Sub

    Private Sub SetGameID_Click(sender As Object, e As EventArgs) Handles SetGameID.Click
        gameid = InputBox("Enter SteamCMD GameID from the Link", "SteamCMD GameID Input", "Enter GameID From List")

        MessageBox.Show("gameid set to: " & gameid)

    End Sub

	Private Sub Install_Click(sender As Object, e As EventArgs) Handles Install.Click

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

	Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
		ToolStripStatus.Text = "Active"
		ToolStripStatus.ForeColor = Color.OliveDrab

		Dim showWeb As New ProcessStartInfo
		showWeb.FileName = "iexplore.exe"
		showWeb.Arguments = "https://developer.valvesoftware.com/wiki/Dedicated_Servers_List"
		Process.Start(showWeb)

		ToolStripStatus.ForeColor = Color.Orange
		ToolStripStatus.Text = "Idle"
	End Sub

	Private Sub main_Load(sender As Object, e As EventArgs) Handles MyBase.Load
		ToolStripStatus.Text = "Loading"
		ToolStripStatus.ForeColor = Color.OliveDrab

		FormBorderStyle = FormBorderStyle.FixedDialog
		MaximizeBox = False
		MinimizeBox = False

		ToolStripStatus.ForeColor = Color.Black
		ToolStripStatus.Text = "Idle"
	End Sub
End Class
