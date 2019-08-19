<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LicenseValidation
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.TextBoxLicenseKey = New System.Windows.Forms.TextBox()
        Me.LabelEnterKey = New System.Windows.Forms.Label()
        Me.ButtonTrial = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'TextBoxLicenseKey
        '
        Me.TextBoxLicenseKey.Location = New System.Drawing.Point(46, 50)
        Me.TextBoxLicenseKey.Multiline = True
        Me.TextBoxLicenseKey.Name = "TextBoxLicenseKey"
        Me.TextBoxLicenseKey.Size = New System.Drawing.Size(469, 103)
        Me.TextBoxLicenseKey.TabIndex = 0
        '
        'LabelEnterKey
        '
        Me.LabelEnterKey.AutoSize = True
        Me.LabelEnterKey.Location = New System.Drawing.Point(46, 31)
        Me.LabelEnterKey.Name = "LabelEnterKey"
        Me.LabelEnterKey.Size = New System.Drawing.Size(93, 13)
        Me.LabelEnterKey.TabIndex = 1
        Me.LabelEnterKey.Text = "Enter License Key"
        '
        'ButtonTrial
        '
        Me.ButtonTrial.Location = New System.Drawing.Point(46, 230)
        Me.ButtonTrial.Name = "ButtonTrial"
        Me.ButtonTrial.Size = New System.Drawing.Size(121, 23)
        Me.ButtonTrial.TabIndex = 2
        Me.ButtonTrial.Text = "Activate 30-Day Trial"
        Me.ButtonTrial.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(379, 230)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(136, 23)
        Me.Button2.TabIndex = 3
        Me.Button2.Text = "Activate Full License Key"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'LicenseValidation
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(587, 265)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.ButtonTrial)
        Me.Controls.Add(Me.LabelEnterKey)
        Me.Controls.Add(Me.TextBoxLicenseKey)
        Me.Name = "LicenseValidation"
        Me.Text = "License Validation"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TextBoxLicenseKey As TextBox
    Friend WithEvents LabelEnterKey As Label
    Friend WithEvents ButtonTrial As Button
    Friend WithEvents Button2 As Button
End Class
