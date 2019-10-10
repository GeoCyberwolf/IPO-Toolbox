<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddKnown
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AddKnown))
        Me.AddKnownLabel = New System.Windows.Forms.Label()
        Me.TextBoxSystemIP = New System.Windows.Forms.TextBox()
        Me.LabelSystemIP = New System.Windows.Forms.Label()
        Me.ButtonOK = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'AddKnownLabel
        '
        Me.AddKnownLabel.AllowDrop = True
        Me.AddKnownLabel.AutoSize = True
        Me.AddKnownLabel.Location = New System.Drawing.Point(9, 9)
        Me.AddKnownLabel.Name = "AddKnownLabel"
        Me.AddKnownLabel.Size = New System.Drawing.Size(424, 65)
        Me.AddKnownLabel.TabIndex = 0
        Me.AddKnownLabel.Text = resources.GetString("AddKnownLabel.Text")
        '
        'TextBoxSystemIP
        '
        Me.TextBoxSystemIP.Location = New System.Drawing.Point(124, 98)
        Me.TextBoxSystemIP.Name = "TextBoxSystemIP"
        Me.TextBoxSystemIP.Size = New System.Drawing.Size(148, 20)
        Me.TextBoxSystemIP.TabIndex = 1
        '
        'LabelSystemIP
        '
        Me.LabelSystemIP.AutoSize = True
        Me.LabelSystemIP.Location = New System.Drawing.Point(64, 101)
        Me.LabelSystemIP.Name = "LabelSystemIP"
        Me.LabelSystemIP.Size = New System.Drawing.Size(54, 13)
        Me.LabelSystemIP.TabIndex = 2
        Me.LabelSystemIP.Text = "System IP"
        '
        'ButtonOK
        '
        Me.ButtonOK.Location = New System.Drawing.Point(293, 96)
        Me.ButtonOK.Name = "ButtonOK"
        Me.ButtonOK.Size = New System.Drawing.Size(75, 23)
        Me.ButtonOK.TabIndex = 3
        Me.ButtonOK.Text = "OK"
        Me.ButtonOK.UseVisualStyleBackColor = True
        '
        'AddKnown
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(447, 130)
        Me.ControlBox = False
        Me.Controls.Add(Me.ButtonOK)
        Me.Controls.Add(Me.LabelSystemIP)
        Me.Controls.Add(Me.TextBoxSystemIP)
        Me.Controls.Add(Me.AddKnownLabel)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "AddKnown"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.Text = "Add Known Units Entry"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents AddKnownLabel As Label
    Friend WithEvents TextBoxSystemIP As TextBox
    Friend WithEvents LabelSystemIP As Label
    Friend WithEvents ButtonOK As Button
End Class
