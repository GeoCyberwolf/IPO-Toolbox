Imports IPO_Toolbox.Licensing
Public Class LicensePrompt
    Private Sub ButtonFullKey_Click(sender As Object, e As EventArgs) Handles ButtonFullKey.Click

    End Sub

    Private Sub ButtonExit_Click(sender As Object, e As EventArgs) Handles ButtonExit.Click
        Application.Exit()
    End Sub

    Private Sub ButtonTrial_Click(sender As Object, e As EventArgs) Handles ButtonTrial.Click
        ActivateTrial()
        DoLicenseCheck()
        Me.Close()
    End Sub
End Class