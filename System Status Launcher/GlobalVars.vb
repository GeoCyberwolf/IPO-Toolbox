Public Class GlobalVars
    'Define global variables
    Public Shared systemlist As New DataTable
    Public Shared file As String
    Public Shared exception As String
    Public Shared ip As String
    Public Shared keyCombo As New List(Of Keys)({Keys.Shift, Keys.Enter})
    Public Shared currentKeys As New List(Of Keys)
    Public Shared DarkMode As Boolean
    Public Shared CSVLineCount As Integer = 0
    Public Shared MaxCSVSize As Integer
    Public Shared programfiles As String = Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles)
    Public Shared ManagerPath As String = programfiles & "\Avaya\IP Office\Manager\Manager.exe"
    Public Shared username As String
    Public Shared password As String
    Public Shared LicenseKey As String
End Class
