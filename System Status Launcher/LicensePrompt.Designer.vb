﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LicensePrompt
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
        Me.ButtonFullKey = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout
        '
        'TextBoxLicenseKey
        '
        Me.TextBoxLicenseKey.Location = New System.Drawing.Point(46, 107)
        Me.TextBoxLicenseKey.Multiline = true
        Me.TextBoxLicenseKey.Name = "TextBoxLicenseKey"
        Me.TextBoxLicenseKey.Size = New System.Drawing.Size(469, 103)
        Me.TextBoxLicenseKey.TabIndex = 0
        '
        'LabelEnterKey
        '
        Me.LabelEnterKey.AutoSize = true
        Me.LabelEnterKey.Location = New System.Drawing.Point(43, 91)
        Me.LabelEnterKey.Name = "LabelEnterKey"
        Me.LabelEnterKey.Size = New System.Drawing.Size(96, 13)
        Me.LabelEnterKey.TabIndex = 1
        Me.LabelEnterKey.Text = "Enter License Key:"
        '
        'ButtonTrial
        '
        Me.ButtonTrial.Location = New System.Drawing.Point(46, 230)
        Me.ButtonTrial.Name = "ButtonTrial"
        Me.ButtonTrial.Size = New System.Drawing.Size(121, 23)
        Me.ButtonTrial.TabIndex = 2
        Me.ButtonTrial.Text = "Activate 30-Day Trial"
        Me.ButtonTrial.UseVisualStyleBackColor = true
        '
        'ButtonFullKey
        '
        Me.ButtonFullKey.Location = New System.Drawing.Point(379, 230)
        Me.ButtonFullKey.Name = "ButtonFullKey"
        Me.ButtonFullKey.Size = New System.Drawing.Size(136, 23)
        Me.ButtonFullKey.TabIndex = 3
        Me.ButtonFullKey.Text = "Activate Full License Key"
        Me.ButtonFullKey.UseVisualStyleBackColor = true
        '
        'Label1
        '
        Me.Label1.AutoSize = true
        Me.Label1.Location = New System.Drawing.Point(149, 34)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(264, 39)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "IPO Toolbox is unlicensed!"&Global.Microsoft.VisualBasic.ChrW(13)&Global.Microsoft.VisualBasic.ChrW(10)&Global.Microsoft.VisualBasic.ChrW(13)&Global.Microsoft.VisualBasic.ChrW(10)&"Please activate a 30-day trial or enter your licens"& _ 
    "e key!"
        '
        'LicensePrompt
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(587, 265)
        Me.ControlBox = false
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ButtonFullKey)
        Me.Controls.Add(Me.ButtonTrial)
        Me.Controls.Add(Me.LabelEnterKey)
        Me.Controls.Add(Me.TextBoxLicenseKey)
        Me.MaximizeBox = false
        Me.MinimizeBox = false
        Me.Name = "LicensePrompt"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "License Validation"
        Me.ResumeLayout(false)
        Me.PerformLayout

End Sub

    Friend WithEvents TextBoxLicenseKey As TextBox
    Friend WithEvents LabelEnterKey As Label
    Friend WithEvents ButtonTrial As Button
    Friend WithEvents ButtonFullKey As Button
    Friend WithEvents Label1 As Label
End Class