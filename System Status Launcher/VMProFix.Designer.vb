<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class VMProFix
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(VMProFix))
        Me.ButtonContinue = New System.Windows.Forms.Button()
        Me.LabelInfo = New System.Windows.Forms.Label()
        Me.TextBoxRegkeyPath = New System.Windows.Forms.TextBox()
        Me.ButtonBrowse = New System.Windows.Forms.Button()
        Me.SaveFileDialogRegKey = New System.Windows.Forms.SaveFileDialog()
        Me.ButtonRetry = New System.Windows.Forms.Button()
        Me.ButtonFinish = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'ButtonContinue
        '
        Me.ButtonContinue.Location = New System.Drawing.Point(267, 129)
        Me.ButtonContinue.Name = "ButtonContinue"
        Me.ButtonContinue.Size = New System.Drawing.Size(75, 23)
        Me.ButtonContinue.TabIndex = 1
        Me.ButtonContinue.Text = "Continue"
        Me.ButtonContinue.UseVisualStyleBackColor = True
        '
        'LabelInfo
        '
        Me.LabelInfo.Location = New System.Drawing.Point(12, 9)
        Me.LabelInfo.Name = "LabelInfo"
        Me.LabelInfo.Size = New System.Drawing.Size(323, 104)
        Me.LabelInfo.TabIndex = 9999
        Me.LabelInfo.Text = resources.GetString("LabelInfo.Text")
        Me.LabelInfo.UseMnemonic = False
        '
        'TextBoxRegkeyPath
        '
        Me.TextBoxRegkeyPath.Location = New System.Drawing.Point(15, 72)
        Me.TextBoxRegkeyPath.Name = "TextBoxRegkeyPath"
        Me.TextBoxRegkeyPath.ReadOnly = True
        Me.TextBoxRegkeyPath.Size = New System.Drawing.Size(251, 20)
        Me.TextBoxRegkeyPath.TabIndex = 10000
        Me.TextBoxRegkeyPath.Visible = False
        '
        'ButtonBrowse
        '
        Me.ButtonBrowse.Location = New System.Drawing.Point(272, 70)
        Me.ButtonBrowse.Name = "ButtonBrowse"
        Me.ButtonBrowse.Size = New System.Drawing.Size(75, 23)
        Me.ButtonBrowse.TabIndex = 10001
        Me.ButtonBrowse.Text = "Browse"
        Me.ButtonBrowse.UseVisualStyleBackColor = True
        Me.ButtonBrowse.Visible = False
        '
        'SaveFileDialogRegKey
        '
        Me.SaveFileDialogRegKey.Filter = "Registry Key Files (.reg)|*.reg"
        '
        'ButtonRetry
        '
        Me.ButtonRetry.Location = New System.Drawing.Point(130, 90)
        Me.ButtonRetry.Name = "ButtonRetry"
        Me.ButtonRetry.Size = New System.Drawing.Size(75, 23)
        Me.ButtonRetry.TabIndex = 10002
        Me.ButtonRetry.Text = "Retry"
        Me.ButtonRetry.UseVisualStyleBackColor = True
        Me.ButtonRetry.Visible = False
        '
        'ButtonFinish
        '
        Me.ButtonFinish.Location = New System.Drawing.Point(130, 116)
        Me.ButtonFinish.Name = "ButtonFinish"
        Me.ButtonFinish.Size = New System.Drawing.Size(75, 23)
        Me.ButtonFinish.TabIndex = 10003
        Me.ButtonFinish.Text = "Finish"
        Me.ButtonFinish.UseVisualStyleBackColor = True
        Me.ButtonFinish.Visible = False
        '
        'VMProFix
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(354, 164)
        Me.Controls.Add(Me.ButtonFinish)
        Me.Controls.Add(Me.ButtonRetry)
        Me.Controls.Add(Me.ButtonBrowse)
        Me.Controls.Add(Me.TextBoxRegkeyPath)
        Me.Controls.Add(Me.LabelInfo)
        Me.Controls.Add(Me.ButtonContinue)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "VMProFix"
        Me.Text = "Fix Voicemail Pro Client"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ButtonContinue As Button
    Friend WithEvents LabelInfo As Label
    Friend WithEvents TextBoxRegkeyPath As TextBox
    Friend WithEvents ButtonBrowse As Button
    Friend WithEvents SaveFileDialogRegKey As SaveFileDialog
    Friend WithEvents ButtonRetry As Button
    Friend WithEvents ButtonFinish As Button
End Class
