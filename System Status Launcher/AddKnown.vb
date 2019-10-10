Imports IPO_Toolbox.Functions
Imports IPO_Toolbox.GlobalVars
Public Class AddKnown
    Private Sub ButtonOK_Click(sender As Object, e As EventArgs) Handles ButtonOK.Click
        ip = TextBoxSystemIP.Text
        LaunchManager()
        Me.Close()
    End Sub

    Private Sub AddKnown_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class