Public Class VMProFix
    Dim CurrentStep As Integer = 1
    Dim RegKeyPath As String
    Dim RegistryCommand As String
    Dim VMProRunning As Boolean = False

    Private Sub IsVMProRunning()
        Dim p() As Process
        p = Process.GetProcessesByName("VoicemailPro")
        If p.Count > 0 Then
            VMProRunning = True
            MsgBox(Prompt:="VM Pro running")
        Else
            VMProRunning = False
            MsgBox(Prompt:="VM Pro NOT running")
        End If
    End Sub

    Private Sub Step2()
        'Step 2 Choose Regkey Backup Location
        LabelInfo.Text = "The fist step is to backup the Voicemail Pro registry keys. Choose your backup location and click Continue"
        TextBoxRegkeyPath.Visible = True
        ButtonBrowse.Visible = True
        ButtonContinue.Enabled = False
    End Sub

    Private Sub Step3()
        'Step 3 Save regkey backup
        ButtonContinue.Enabled = False
        TextBoxRegkeyPath.Visible = False
        ButtonBrowse.Visible = False
        LabelInfo.Text = "Saving registry key backup to " & RegKeyPath
        RegistryCommand = "/E " & RegKeyPath & " ""HKEY_CURRENT_USER\Software\Avaya\Voicemail Pro"""
        Process.Start("regedit.exe", RegistryCommand)
        LabelInfo.Text = "Saving registry key backup to " & RegKeyPath & vbCrLf & vbCrLf & "Registry key saved OK"
        ButtonContinue.Enabled = True
    End Sub

    Private Sub Step4()
        'Step 4 Check if VMPro is running
        ButtonContinue.Enabled = False
        LabelInfo.Text = "Checking if Voicemail Pro Client is running..."
        IsVMProRunning()
        If VMProRunning = True Then
            ButtonRetry.Visible = True
            LabelInfo.Text = "Voicemail Pro Client is currently running, please close it and click Retry."
        ElseIf VMProRunning = False Then
            ButtonRetry.Visible = False
            ButtonContinue.Enabled = True
            LabelInfo.Text = "Voicemail Pro is not running, click continue to fix it."
        End If
    End Sub

    Private Sub ButtonContinue_Click(sender As Object, e As EventArgs) Handles ButtonContinue.Click
        If CurrentStep = 1 Then
            CurrentStep = 2
            Step2()
        ElseIf CurrentStep = 2 Then
            CurrentStep = 3
            Step3()
        ElseIf CurrentStep = 3 Then
            CurrentStep = 4
            Step4()
        ElseIf CurrentStep = 4 Then
            CurrentStep = 5

        End If
    End Sub

    Private Sub ButtonBrowse_Click(sender As Object, e As EventArgs) Handles ButtonBrowse.Click
        SaveFileDialogRegKey.ShowDialog()
    End Sub

    Private Sub SaveFileDialogRegKey_FileOk(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles SaveFileDialogRegKey.FileOk
        RegKeyPath = SaveFileDialogRegKey.FileName
        TextBoxRegkeyPath.Text = RegKeyPath
        ButtonContinue.Enabled = True
    End Sub

    Private Sub ButtonRetry_Click(sender As Object, e As EventArgs) Handles ButtonRetry.Click
        Step4()
    End Sub
End Class