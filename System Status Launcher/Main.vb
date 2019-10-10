Imports System.Text.RegularExpressions
Imports IPO_Toolbox.Licensing
Imports IPO_Toolbox.Functions
Imports IPO_Toolbox.GlobalVars
Public Class Main
    '///Do stuff on load
    Private Sub Main_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Text = Application.ProductName & " BETA 1" '& Application.ProductVersion
        'DoLicenseCheck()
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
        TextBoxSearch.Select()
        AutoCheckForUpdates()
        'Set default username
        TextBoxUsername.Text = My.Settings.Username

        BetaCheck()
        CheckDQ()
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

    Private Sub ButtonLaunchManager_Click(sender As Object, e As EventArgs) Handles ButtonLaunchManager.Click
        ip = DataGridView1.CurrentRow.Cells(3).Value
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

    Private Sub FixVoicemailProClientToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FixVoicemailProClientToolStripMenuItem.Click
        VMProFix.Show()
    End Sub

    Private Sub ReportABugToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ReportABugToolStripMenuItem.Click
        Process.Start("https://ipoffice.tools/bugreport")
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

End Class
