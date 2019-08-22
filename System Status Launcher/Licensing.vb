Imports Habanero.Licensing.Validation
Public Class Licensing
    '///LICENSING CODE///
    'create code for applicationsecret
    Public Shared applicationSecret() As Byte = Convert.FromBase64String("c3ZoNKo2mUG1wswVtsHPDQ==")
    'create code for public key
    Public Shared publicKey() As Byte = Convert.FromBase64String("BgIAAACkAABSU0ExAAIAAAEAAQA9uPZd4CiX3PM4ha6kGnhE1EhQqwpraGdlMzZWBEM0L20jG8zpnRnR6IpDXLyyzzBdPEVOk0WFgBsjQQ2O7C/q")

    Public Shared ReadOnly Property Validator As Habanero.Licensing.Validation.LicenseValidator
        Get
            'this version is for file system - Isolated storage is anther option
            Return New Habanero.Licensing.Validation.LicenseValidator(Habanero.Licensing.Validation.LicenseLocation.File, "Path to license file", "IPO Toolbox", Licensing.publicKey, Licensing.applicationSecret, ThisVersion)
        End Get

    End Property

    Private Shared ReadOnly Property ThisVersion As Version
        Get
            'Get the executing files filesversion
            Dim fileversion As FileVersionInfo = System.Diagnostics.FileVersionInfo.GetVersionInfo(System.Reflection.Assembly.GetExecutingAssembly().Location)
            Return New Version(fileversion.FileMajorPart, fileversion.FileMinorPart, fileversion.FileBuildPart, fileversion.FilePrivatePart)

        End Get
    End Property

    Public Shared Sub DoLicenseCheck()
        Dim result As Habanero.Licensing.Validation.LicenseValidationResult = Licensing.Validator.CheckLicense()
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
            result = Licensing.Validator.ActivateTrial(45)
            Main.Enabled = False
            Main.Hide()
            LicensePrompt.Show()

            'or save license
            Dim userLicense As String = ""
            result = Licensing.Validator.CheckLicense(userLicense)
            'decide if you want to save the license...
            Licensing.Validator.SaveLicense(userLicense)
        End If
        If (result.State = LicenseState.Trial) Then
            'activate trial features
        End If
        If (result.State = LicenseState.Valid) Then
            'activate product
            If (Licensing.Validator.IsEdition("Pro")) Then
                'activate pro features...
            End If
        End If
    End Sub
    '////END LICENSING CODE////
End Class
