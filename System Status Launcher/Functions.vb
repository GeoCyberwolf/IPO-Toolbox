Imports IPO_Toolbox.GlobalVars
Public Class Functions

    Public Shared Sub BetaCheck()
        Try
            Dim betarequest As System.Net.HttpWebRequest = System.Net.HttpWebRequest.Create("https://dl.ipoffice.tools/beta.txt")
            Dim betaresponse As System.Net.HttpWebResponse = betarequest.GetResponse

            Dim betaSR As System.IO.StreamReader = New System.IO.StreamReader(betaresponse.GetResponseStream)


            Dim betaresult As String = betaSR.ReadToEnd

            If betaresult = "BetaOver" Then
                Main.Enabled = False
                Dim betamessage As String = "The Beta is now over. Please buy the full version from https://ipoffice.tools"
                MsgBox(Buttons:=MsgBoxStyle.Critical, Prompt:=betamessage)
                Main.Close()
            ElseIf betaresult <> "1" Then
                Main.Enabled = False
                Dim betamessage As String = "This Beta version is no longer valid."
                MsgBox(Buttons:=MsgBoxStyle.Critical, Prompt:=betamessage)
                Main.Close()
                End
            End If
        Catch ex As Exception
            Main.Enabled = False
            MsgBox(Prompt:="Unable to validate the Beta version. Please start the application again with a working internet connection.", MsgBoxStyle.SystemModal)
            Main.Close()
        End Try
    End Sub

    Public Shared Sub LaunchManager()
        Try
            My.Computer.Registry.SetValue("HKEY_CURRENT_USER\Software\Avaya\IP400\Manager\", "BCASTIPAddr", ip)
            My.Computer.Registry.SetValue("HKEY_CURRENT_USER\Software\Avaya\IP400\Manager\", "LastLoggedInUser", Main.TextBoxUsername.Text)
        Catch ex As Exception
            exception = ex.Message
            HandleError()
        End Try

        Try
            Process.Start(ManagerPath)
        Catch ex As Exception
            exception = ex.Message
            HandleError()
        End Try
        Main.WindowState = FormWindowState.Minimized
    End Sub

    'Error handling function. Called in try catch statements to display an error message.
    Public Shared Function HandleError()
        MsgBox(Buttons:=vbCritical, Title:="Error", Prompt:="An error has occurred: " & exception)
        Return True
    End Function


    'Function to launch system status with our IP, Username and Password
    Public Shared Sub LaunchSSA()
        Try
            ip = Main.DataGridView1.CurrentRow.Cells(3).Value
            password = Main.TextBoxPassword.Text
            username = Main.TextBoxUsername.Text
            Dim arguments As String = "-jar " + """" + programfiles + "\Avaya\IP Office\System Status\ssaviewer.jar"" LogonIPAddr=" + ip + " LogonUser=" + username + " LogonPassword=" + password
            Process.Start("javaw.exe", arguments)
        Catch ex As Exception
            exception = ex.Message
            HandleError()
        End Try
        Main.WindowState = FormWindowState.Minimized
    End Sub

    'Function to read CSV file and load into Datagridview
    Public Shared Sub LoadCsv()
        Try
            Main.ToolStripStatusLabel1.Text = My.Settings.CSVPath
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
            Main.DataGridView1.DataSource = systemlist
            Main.DataGridView1.Sort(Main.DataGridView1.Columns("System Name"), ComponentModel.ListSortDirection.Ascending)
            Main.ButtonCopyIP.Visible = True
            Main.ReloadKnownUnitsFileToolStripMenuItem.Enabled = True
        Catch ex As Exception
            exception = ex.Message
            HandleError()
        End Try
    End Sub



    'Function to manually check for updates
    Public Shared Sub ManualCheckForUpdates()
        Try
            Dim updaterequest As System.Net.HttpWebRequest = System.Net.HttpWebRequest.Create("http://dl.ipoffice.tools/version.txt")
            Dim updateresponse As System.Net.HttpWebResponse = updaterequest.GetResponse

            Dim updateSR As System.IO.StreamReader = New System.IO.StreamReader(updateresponse.GetResponseStream)

            Dim newestversion As String = updateSR.ReadToEnd
            Dim currentversion As String = Application.ProductVersion

            If newestversion <= currentversion Then
                MsgBox(Prompt:="This is the latest version!")
                Main.ToolStripStatusLabelUpdate.Text = Nothing
            ElseIf newestversion > currentversion Then
                MsgBox(Prompt:="There is a new version available! Please download version " & newestversion & " from https://ipoffice.tools")
                Main.ToolStripStatusLabelUpdate.Text = "Update Available! (v" & newestversion & ")"
            End If
        Catch ex As Exception
            MsgBox(Buttons:=vbCritical, Title:="Error!", Prompt:="Unable to connect to the update server. Please check your network connection!")
        End Try

    End Sub

    'Function to automatically check for updates
    Public Shared Sub AutoCheckForUpdates()
        Try
            Dim updaterequest As System.Net.HttpWebRequest = System.Net.HttpWebRequest.Create("http://dl.ipoffice.tools/version.txt")
            Dim updateresponse As System.Net.HttpWebResponse = updaterequest.GetResponse

            Dim updateSR As System.IO.StreamReader = New System.IO.StreamReader(updateresponse.GetResponseStream)

            Dim newestversion As String = updateSR.ReadToEnd
            Dim currentversion As String = Application.ProductVersion

            If newestversion > currentversion Then
                Main.ToolStripStatusLabelUpdate.Text = "Update Available! (v" & newestversion & ")"
            End If
        Catch ex As Exception
            Main.ToolStripStatusLabelUpdate.IsLink = False
            Main.ToolStripStatusLabelUpdate.Text = "Cannot connect to update server. Check network connection!"
        End Try

    End Sub

    'Function to minimize to tray
    Public Shared Sub MinimizeToTray()
        Main.NotifyIcon1.Visible = True
        Main.NotifyIcon1.Icon = Main.Icon 'SystemIcons.Application
        Main.NotifyIcon1.Text = Application.ProductName
        Main.NotifyIcon1.BalloonTipIcon = ToolTipIcon.Info
        Main.NotifyIcon1.BalloonTipText = "Please double click the icon to open"
        Main.NotifyIcon1.BalloonTipTitle = Application.ProductName & " is now minimized to the tray."
        Main.NotifyIcon1.ShowBalloonTip(3000)
        Main.Hide()
        Main.ShowInTaskbar = False
    End Sub

    'Function to open from the system tray
    Public Shared Sub OpenFromTray()
        Main.ShowInTaskbar = True
        Main.Show()
        Main.WindowState = FormWindowState.Normal
        Main.Visible = False
        Main.TextBoxSearch.Select()
    End Sub

    Public Shared Async Sub CopyPassword()
        Try
            Clipboard.SetDataObject(Main.TextBoxPassword.Text, True, 5, 100)
        Catch ex As Exception
            exception = ex.Message
            MsgBox(Buttons:=vbCritical, Title:="Error!", Prompt:="An error occured while copying the password, though it may still have copied successfully. Are any remote desktop apps running (e.g LogMeIn Rescue, Teamviewer)?")
        End Try
        Main.NotifyIcon1.Visible = True
        Main.NotifyIcon1.Icon = Main.Icon
        Main.NotifyIcon1.Text = Application.ProductName
        Main.NotifyIcon1.BalloonTipIcon = ToolTipIcon.Info
        Main.NotifyIcon1.BalloonTipText = "The password has been copied to the clipboard. It will be removed from the clipboard after 3 minutes."
        Main.NotifyIcon1.BalloonTipTitle = "IPO Toolbox"
        Main.NotifyIcon1.ShowBalloonTip(5000)
        Await Task.Delay(180000)
        Clipboard.Clear()
        Main.NotifyIcon1.BalloonTipText = "The password has been removed from the clipboard for your security!"
        Main.NotifyIcon1.BalloonTipTitle = "IPO Toolbox"
        Main.NotifyIcon1.ShowBalloonTip(5000)
        Main.NotifyIcon1.Visible = False
    End Sub

    Public Shared Sub ToggleDarkMode()
        If DarkMode = False Then
            DarkMode = True
            Main.DarkModeToolStripMenuItem.Checked = True
            Main.BackColor = Color.FromArgb(180, 180, 180)
            Main.DataGridView1.DefaultCellStyle.BackColor = Color.FromArgb(100, 100, 100)
            Main.DataGridView1.DefaultCellStyle.ForeColor = Color.White
            Main.DataGridView1.DefaultCellStyle.SelectionBackColor = Color.Black
            Main.DataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(100, 100, 100)
            Main.DataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = Color.White
            Main.DataGridView1.RowHeadersDefaultCellStyle.BackColor = Color.FromArgb(100, 100, 100)
            Main.DataGridView1.RowHeadersDefaultCellStyle.ForeColor = Color.White
            Main.MenuStrip1.BackColor = Color.FromArgb(100, 100, 100)
            Main.MenuStrip1.ForeColor = Color.White
            Main.StatusStrip1.BackColor = Color.FromArgb(100, 100, 100)
            Main.StatusStrip1.ForeColor = Color.White
        ElseIf DarkMode = True Then
            MsgBox(Prompt:="Application will now restart to turn off Dark Mode.")
            Application.Restart()
        End If

    End Sub
End Class
