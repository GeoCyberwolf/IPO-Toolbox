Imports IPO_Toolbox.Functions
Imports IPO_Toolbox.GlobalVars
Public Class AddKnown
    Private Sub ButtonOK_Click(sender As Object, e As EventArgs) Handles ButtonOK.Click
        Dim IPAddr As Net.IPAddress
        Dim IPCheck As String = TextBoxSystemIP.Text
        Dim ValidIP As Boolean = Net.IPAddress.TryParse(IPCheck, IPAddr)

        If ValidIP = True Then
            ip = IPCheck
            LaunchManager()
            Me.Close()
        Else
            MsgBox(Prompt:="IP address is not valid. Please enter a valid IP address.", Buttons:=vbExclamation)
        End If

    End Sub

    Private Sub AddKnown_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub TextBoxSystemIP_TextChanged(sender As Object, e As EventArgs) Handles TextBoxSystemIP.TextChanged

    End Sub
End Class