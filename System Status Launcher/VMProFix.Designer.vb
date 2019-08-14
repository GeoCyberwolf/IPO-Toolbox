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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout
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
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(323, 104)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = resources.GetString("Label1.Text")
        Me.Label1.UseMnemonic = False
        '
        'VMProFix
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(354, 164)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ButtonContinue)
        Me.Name = "VMProFix"
        Me.Text = "VMPro_Fix"
        Me.ResumeLayout(False)
        Me.PerformLayout

    End Sub
    Friend WithEvents ButtonContinue As Button
    Friend WithEvents Label1 As Label
End Class
