Imports System.Text.RegularExpressions
Imports Habanero.Licensing.Validation
Imports IPO_Toolbox.Functions
Imports IPO_Toolbox.GlobalVars
Public Class Main
    '///LICENSING CODE///
    'create code for applicationsecret
    Dim applicationSecret() As Byte = Convert.FromBase64String("c3ZoNKo2mUG1wswVtsHPDQ==")
    'create code for public key
    Dim publicKey() As Byte = Convert.FromBase64String("BgIAAACkAABSU0ExAAIAAAEAAQA9uPZd4CiX3PM4ha6kGnhE1EhQqwpraGdlMzZWBEM0L20jG8zpnRnR6IpDXLyyzzBdPEVOk0WFgBsjQQ2O7C/q")

    Private ReadOnly Property Validator As Habanero.Licensing.Validation.LicenseValidator
        Get
            'this version is for file system - Isolated storage is anther option
            Return New Habanero.Licensing.Validation.LicenseValidator(Habanero.Licensing.Validation.LicenseLocation.File, "Path to license file", "IPO Toolbox", publicKey, applicationSecret, ThisVersion)
        End Get
    End Property

    Private Shared ReadOnly Property ThisVersion As Version
        Get
            'Get the executing files filesversion
            Dim fileversion As FileVersionInfo = System.Diagnostics.FileVersionInfo.GetVersionInfo(System.Reflection.Assembly.GetExecutingAssembly().Location)
            Return New Version(fileversion.FileMajorPart, fileversion.FileMinorPart, fileversion.FileBuildPart, fileversion.FilePrivatePart)

        End Get
    End Property

    Private Sub DoLicenseCheck()
        Dim result As Habanero.Licensing.Validation.LicenseValidationResult = Validator.CheckLicense()
        If (result.State = Habanero.Licensing.Validation.LicenseState.Invalid) Then
            If (result.Issues.Contains(LicenseIssue.NoLicenseInfo)) Then
                'inform user there is no license info
                MsgBox(Prompt:="No valid license found!")
            Else
                If (result.Issues.Contains(LicenseIssue.ExpiredDateSoft)) Then
                    'inform user that their license has expired but
                    'that they may continue using the software for a period
                    MsgBox(Prompt:="License expired1")
                End If
                If (result.Issues.Contains(LicenseIssue.ExpiredDateHard)) Then
                    'inform user that their license has expired
                    MsgBox(Prompt:="License expired2")
                End If
                If (result.Issues.Contains(LicenseIssue.ExpiredVersion)) Then
                    'inform user that their license is for an earlier version
                    MsgBox(Prompt:="License expired3")
                End If
                'other messages
            End If

            'prompt user for trial or to insert license info then decide what to do
            'activate trial
            result = Validator.ActivateTrial(45)
            Me.Enabled = False
            Me.Hide()
            LicensePrompt.Show()
            'or save license
            Dim userLicense As String = ""
            result = Validator.CheckLicense(userLicense)
            'decide if you want to save the license...
            Validator.SaveLicense(userLicense)
        End If
        If (result.State = LicenseState.Trial) Then
            'activate trial features
        End If
        If (result.State = LicenseState.Valid) Then
            'activate product
            If (Validator.IsEdition("Pro")) Then
                'activate pro features...
            End If
        End If
    End Sub
    '////END LICENSING CODE////

    'Function to launch system status with our IP, Username and Password
    Public Sub LaunchSSA()
        Try
            ip = DataGridView1.CurrentRow.Cells(3).Value
            Dim password As String = TextBoxPassword.Text
            Dim username As String = TextBoxUsername.Text
            Dim programfiles As String = Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles)
            Dim arguments As String = "-jar " + """" + programfiles + "\Avaya\IP Office\System Status\ssaviewer.jar"" LogonIPAddr=" + ip + " LogonUser=" + username + " LogonPassword=" + password
            Process.Start("javaw.exe", arguments)
        Catch ex As Exception
            exception = ex.Message
            HandleError()
        End Try
        Me.WindowState = FormWindowState.Minimized
    End Sub

    'Function to read CSV file and load into Datagridview
    Public Sub LoadCsv()
        Try
            ToolStripStatusLabel1.Text = My.Settings.CSVPath
            systemlist.Rows.Clear()
            Dim csvreader As New IO.StreamReader(My.Settings.CSVPath, System.Text.Encoding.Default)
            Dim csvline As String = ""
            Do 'Until CSVLineCount = MaxCSVSize
                CSVLineCount = CSVLineCount + 1
                csvline = csvreader.ReadLine
                If csvline Is Nothing Then Exit Do
                Dim thecolumns() As String = csvline.Split(",")
                Dim newrow As DataRow = systemlist.NewRow
                newrow("System Name") = thecolumns(0)
                newrow("MAC Address") = thecolumns(1)
                newrow("System Type") = thecolumns(2)
                newrow("IP Address") = thecolumns(3)
                newrow("Version") = thecolumns(4)
                newrow("Mode") = thecolumns(5)
                systemlist.Rows.Add(newrow)
            Loop
            csvreader.Close()
            'load data table into the data grid
            DataGridView1.DataSource = systemlist
            DataGridView1.Sort(DataGridView1.Columns("System Name"), ComponentModel.ListSortDirection.Ascending)
            ButtonCopyIP.Visible = True
            ReloadKnownUnitsFileToolStripMenuItem.Enabled = True
        Catch ex As Exception
            exception = ex.Message
            HandleError()
        End Try
    End Sub



    'Function to manually check for updates
    Private Sub ManualCheckForUpdates()
        Try
            Dim updaterequest As System.Net.HttpWebRequest = System.Net.HttpWebRequest.Create("http://dl.ipoffice.tools/version.txt")
            Dim updateresponse As System.Net.HttpWebResponse = updaterequest.GetResponse

            Dim updateSR As System.IO.StreamReader = New System.IO.StreamReader(updateresponse.GetResponseStream)

            Dim newestversion As String = updateSR.ReadToEnd
            Dim currentversion As String = Application.ProductVersion

            If newestversion <= currentversion Then
                MsgBox(Prompt:="This is the latest version!")
                ToolStripStatusLabelUpdate.Text = Nothing
            ElseIf newestversion > currentversion Then
                MsgBox(Prompt:="There is a new version available! Please download version " & newestversion & " from https://ipoffice.tools")
                ToolStripStatusLabelUpdate.Text = "Update Available! (v" & newestversion & ")"
            End If
        Catch ex As Exception
            MsgBox(Buttons:=vbCritical, Title:="Error!", Prompt:="Unable to connect to the update server. Please check your network connection!")
        End Try

    End Sub

    'Function to automatically check for updates
    Private Sub AutoCheckForUpdates()
        Try
            Dim updaterequest As System.Net.HttpWebRequest = System.Net.HttpWebRequest.Create("http://dl.ipoffice.tools/version.txt")
            Dim updateresponse As System.Net.HttpWebResponse = updaterequest.GetResponse

            Dim updateSR As System.IO.StreamReader = New System.IO.StreamReader(updateresponse.GetResponseStream)

            Dim newestversion As String = updateSR.ReadToEnd
            Dim currentversion As String = Application.ProductVersion

            If newestversion > currentversion Then
                ToolStripStatusLabelUpdate.Text = "Update Available! (v" & newestversion & ")"
            End If
        Catch ex As Exception
            ToolStripStatusLabelUpdate.IsLink = False
            ToolStripStatusLabelUpdate.Text = "Cannot connect to update server. Check network connection!"
        End Try

    End Sub

    'Function to minimize to tray
    Private Sub MinimizeToTray()
        NotifyIcon1.Visible = True
        NotifyIcon1.Icon = Me.Icon 'SystemIcons.Application
        NotifyIcon1.Text = Application.ProductName
        NotifyIcon1.BalloonTipIcon = ToolTipIcon.Info
        NotifyIcon1.BalloonTipText = "Please double click the icon to open"
        NotifyIcon1.BalloonTipTitle = Application.ProductName & " is now minimized to the tray."
        NotifyIcon1.ShowBalloonTip(3000)
        Me.Hide()
        ShowInTaskbar = False
    End Sub

    'Function to open from the system tray
    Private Sub OpenFromTray()
        ShowInTaskbar = True
        Me.Show()
        Me.WindowState = FormWindowState.Normal
        NotifyIcon1.Visible = False
        TextBoxSearch.Select()
    End Sub

    Private Sub NotifyIcon1_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles NotifyIcon1.DoubleClick
        OpenFromTray()
    End Sub

    Private Sub ContextMenuStrip1_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles ContextMenuStrip1.LostFocus
        ContextMenuStrip1.Close()
    End Sub

    Private Sub NotifyIcon1_Click(ByVal sender As Object, ByVal e As MouseEventArgs) Handles NotifyIcon1.MouseClick
        If e.Button = Windows.Forms.MouseButtons.Right Then
            ContextMenuStrip1.Show(Cursor.Position)
        Else
            ContextMenuStrip1.Hide()
        End If

    End Sub


    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DoLicenseCheck()
        Me.KeyPreview = True

        If My.Settings.UpgradeRequired = True Then
            My.Settings.Upgrade()
            My.Settings.UpgradeRequired = False
            My.Settings.Save()
        End If
        If My.Settings.SingleCellSelect = True Then
            SingleCellSelectToolStripMenuItem.Checked = True
            DataGridView1.SelectionMode = DataGridViewSelectionMode.RowHeaderSelect
        End If

        Me.Text = Application.ProductName & " BETA - v" & Application.ProductVersion
        TextBoxSearch.Select()
        AutoCheckForUpdates()
        'Set default username
        TextBoxUsername.Text = My.Settings.Username

        'Create columns
        With systemlist
            .Columns.Add("System Name", System.Type.GetType("System.String"))
            .Columns.Add("MAC Address", System.Type.GetType("System.String"))
            .Columns.Add("System Type", System.Type.GetType("System.String"))
            .Columns.Add("IP Address", System.Type.GetType("System.String"))
            .Columns.Add("Version", System.Type.GetType("System.String"))
            .Columns.Add("Mode", System.Type.GetType("System.String"))
        End With
        Try
            If My.Settings.CSVPath = "" Then
                ToolStripStatusLabel1.Text = "No Known Units file set!"
            Else
                LoadCsv()
            End If
        Catch ex As Exception
            ToolStripStatusLabel1.Text = "Something happened!"
        End Try
    End Sub

    'Key C-C-C-C-Combos!
    Private Sub Form1_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        currentKeys.Add(e.KeyCode)
        If currentKeys.Intersect(keyCombo).Count = keyCombo.Count Then
            MessageBox.Show("Shift + Enter pressed!!1")
            currentKeys.Clear()
        End If
    End Sub
    Private Sub Form1_KeyUp(sender As Object, e As KeyEventArgs) Handles Me.KeyUp
        currentKeys.Remove(e.KeyCode)
    End Sub
    'Open file browser when Open Known Units File menu option is clicked
    Private Sub OpenKnownUnitsFileToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OpenKnownUnitsFileToolStripMenuItem.Click
        OpenFileDialog1.ShowDialog()
    End Sub

    Private Sub OpenFileDialog1_FileOk(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles OpenFileDialog1.FileOk
        My.Settings.CSVPath = OpenFileDialog1.FileName
        My.Settings.Save()
        LoadCsv()
    End Sub

    Private Sub ButtonLaunch_Click(sender As Object, e As EventArgs) Handles ButtonLaunch.Click
        LaunchSSA()
    End Sub

    Private Sub TextBoxSearch_TextChanged(sender As Object, e As EventArgs) Handles TextBoxSearch.TextChanged
        Dim search As String = Regex.Replace(TextBoxSearch.Text, "[^A-Za-z0-9-_& ]", "")
        TextBoxSearch.Text = search
        If String.IsNullOrWhiteSpace(search) Then
            systemlist.DefaultView.RowFilter = ""
            DataGridView1.ClearSelection()
            DataGridView1.FirstDisplayedScrollingRowIndex = 0
        Else
            systemlist.DefaultView.RowFilter = "[System Name] LIKE '%" & search & "%'"
        End If
    End Sub


    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click
        'pop up About message box
        MsgBox(Prompt:="Written by George Smith" & vbCrLf & "contact@geosmith.uk" & vbCrLf & "Version " & Application.ProductVersion)
    End Sub

    Private Sub SingleCellSelectToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SingleCellSelectToolStripMenuItem.Click
        If Not SingleCellSelectToolStripMenuItem.Checked Then
            DataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect
            My.Settings.SingleCellSelect = False
        Else
            DataGridView1.SelectionMode = DataGridViewSelectionMode.RowHeaderSelect
            My.Settings.SingleCellSelect = True
        End If
        My.Settings.Save()
    End Sub

    Private Sub OpenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OpenToolStripMenuItem.Click
        OpenFromTray()
    End Sub

    Private Sub ExitToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem1.Click
        End
    End Sub

    Private Sub CheckForUpdatesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CheckForUpdatesToolStripMenuItem.Click
        ManualCheckForUpdates()
    End Sub


    Private Sub ToolStripStatusLabelUpdate_Click(sender As Object, e As EventArgs) Handles ToolStripStatusLabelUpdate.Click
        Process.Start("https://ipoffice.tools")
    End Sub

    Private Sub ReloadKnownUnitsFileToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ReloadKnownUnitsFileToolStripMenuItem.Click
        LoadCsv()
    End Sub

    Private Sub MinimizeToTrayToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MinimizeToTrayToolStripMenuItem.Click
        MinimizeToTray()
    End Sub

    Private Sub TextBoxUsername_TextChanged(sender As Object, e As EventArgs) Handles TextBoxUsername.TextChanged
        My.Settings.Username = TextBoxUsername.Text
        My.Settings.Save()
    End Sub

    Private Sub ResetAllSettingsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ResetAllSettingsToolStripMenuItem.Click
        My.Settings.Reset()
        MsgBox(Buttons:=vbInformation, Title:="Settings reset!", Prompt:="Settings have been successfully reset, the application will now restart!")
        Application.Restart()
    End Sub

    Private Sub ButtonCopyIP_Click(sender As Object, e As EventArgs) Handles ButtonCopyIP.Click
        ButtonCopyIP.Enabled = False
        Try
            ip = DataGridView1.CurrentRow.Cells(3).Value
            Clipboard.SetDataObject(ip, True, 5, 100)
        Catch ex As Exception
            exception = ex.Message
            HandleError()
        End Try
        ButtonCopyIP.Enabled = True
    End Sub

    Private Sub ViewChangelogToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ViewChangelogToolStripMenuItem.Click
        Process.Start("https://ipoffice.tools/#changelog")
    End Sub

    ' A sad piece of code that never gets executed :'(
    Private Sub BuyMeACoffeeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BuyMeACoffeeToolStripMenuItem.Click
        Dim DonateChoice As Integer = MsgBox(Buttons:=vbOKCancel, Title:="Buy me a coffee?",
                                             Prompt:="Like IPO Toolbox? Click OK to buy me a coffee. Or click Cancel if you don't want to.")
        If DonateChoice = DialogResult.OK Then
            Process.Start("https://ipoffice.tools/donate")
        End If
    End Sub



    Public Async Sub CopyPassword()
        Try
            Clipboard.SetDataObject(TextBoxPassword.Text, True, 5, 100)
        Catch ex As Exception
            exception = ex.Message
            MsgBox(Buttons:=vbCritical, Title:="Error!", Prompt:="An error occured while copying the password, though it may still have copied successfully. Are any remote desktop apps running (e.g LogMeIn Rescue, Teamviewer)?")
        End Try
        NotifyIcon1.Visible = True
        NotifyIcon1.Icon = Me.Icon
        NotifyIcon1.Text = Application.ProductName
        NotifyIcon1.BalloonTipIcon = ToolTipIcon.Info
        NotifyIcon1.BalloonTipText = "The password has been copied to the clipboard. It will be removed from the clipboard after 3 minutes."
        NotifyIcon1.BalloonTipTitle = "IPO Toolbox"
        NotifyIcon1.ShowBalloonTip(5000)
        Await Task.Delay(180000)
        Clipboard.Clear()
        NotifyIcon1.BalloonTipText = "The password has been removed from the clipboard for your security!"
        NotifyIcon1.BalloonTipTitle = "IPO Toolbox"
        NotifyIcon1.ShowBalloonTip(5000)
        NotifyIcon1.Visible = False
    End Sub

    Private Sub ButtonLaunchManager_Click(sender As Object, e As EventArgs) Handles ButtonLaunchManager.Click
        LaunchManager()
        CopyPassword()
    End Sub

    Private Sub ButtonCopyPassword_Click(sender As Object, e As EventArgs) Handles ButtonCopyPassword.Click
        CopyPassword()
    End Sub

    Private Sub AddKnownUnitsEntryToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AddKnownUnitsEntryToolStripMenuItem.Click
        AddKnown.Show()
    End Sub

    Private Sub DarkModeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DarkModeToolStripMenuItem.Click
        ToggleDarkMode()
    End Sub

    Public Sub ToggleDarkMode()
        If DarkMode = False Then
            DarkMode = True
            DarkModeToolStripMenuItem.Checked = True
            Me.BackColor = Color.FromArgb(180, 180, 180)
            DataGridView1.DefaultCellStyle.BackColor = Color.FromArgb(100, 100, 100)
            DataGridView1.DefaultCellStyle.ForeColor = Color.White
            DataGridView1.DefaultCellStyle.SelectionBackColor = Color.Black
            DataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(100, 100, 100)
            DataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = Color.White
            DataGridView1.RowHeadersDefaultCellStyle.BackColor = Color.FromArgb(100, 100, 100)
            DataGridView1.RowHeadersDefaultCellStyle.ForeColor = Color.White
            MenuStrip1.BackColor = Color.FromArgb(100, 100, 100)
            MenuStrip1.ForeColor = Color.White
            StatusStrip1.BackColor = Color.FromArgb(100, 100, 100)
            StatusStrip1.ForeColor = Color.White
        ElseIf DarkMode = True Then
            MsgBox(Prompt:="I don't know how to turn off dark mode yet, sorry. :( Will restart.")
            Application.Restart()
        End If

    End Sub

    Private Sub FixVoicemailProClientToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FixVoicemailProClientToolStripMenuItem.Click
        VMProFix.Show()
    End Sub

    Private Sub ReportABugToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ReportABugToolStripMenuItem.Click
        Process.Start("https://ipoffice.tools/bugreport")
    End Sub
End Class
