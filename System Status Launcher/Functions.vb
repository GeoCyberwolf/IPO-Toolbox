Imports IPO_Toolbox.GlobalVars
Public Class Functions
    Public Shared Sub LaunchManager()
        Try
            ip = Main.DataGridView1.CurrentRow.Cells(3).Value
            My.Computer.Registry.SetValue("HKEY_CURRENT_USER\Software\Avaya\IP400\Manager\", "BCASTIPAddr", ip)
            My.Computer.Registry.SetValue("HKEY_CURRENT_USER\Software\Avaya\IP400\Manager\", "LastLoggedInUser", Main.TextBoxUsername.Text)
        Catch ex As Exception
            Exception = ex.Message
            HandleError()
        End Try

        Try
            Process.Start(ManagerPath)
        Catch ex As Exception
            Exception = ex.Message
            HandleError()
        End Try
        Main.WindowState = FormWindowState.Minimized
    End Sub

    'Error handling function. Called in try catch statements to display an error message.
    Public Shared Function HandleError()
        MsgBox(Buttons:=vbCritical, Title:="Error", Prompt:="An error has occurred: " & exception)
        Return True
    End Function
End Class
