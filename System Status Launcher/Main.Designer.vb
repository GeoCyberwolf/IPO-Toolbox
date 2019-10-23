<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Main
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Main))
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.TextBoxSearch = New System.Windows.Forms.TextBox()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabelDivider = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabelUpdate = New System.Windows.Forms.ToolStripStatusLabel()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OpenKnownUnitsFileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReloadKnownUnitsFileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.MinimizeToTrayToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AddKnownUnitsEntryToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FixVoicemailProClientToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OptionsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SingleCellSelectToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DarkModeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.ResetAllSettingsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CheckForUpdatesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ViewChangelogToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.ReportABugToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.BuyMeACoffeeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.TextBoxPassword = New System.Windows.Forms.TextBox()
        Me.TextBoxUsername = New System.Windows.Forms.TextBox()
        Me.ButtonLaunch = New System.Windows.Forms.Button()
        Me.LabelUsername = New System.Windows.Forms.Label()
        Me.LabelPassword = New System.Windows.Forms.Label()
        Me.LabelSearch = New System.Windows.Forms.Label()
        Me.NotifyIcon1 = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.OpenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ButtonCopyIP = New System.Windows.Forms.Button()
        Me.ButtonLaunchManager = New System.Windows.Forms.Button()
        Me.ButtonCopyPassword = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ButtonShowPassword = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.StatusStrip1.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(12, 53)
        Me.DataGridView1.MultiSelect = False
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(760, 363)
        Me.DataGridView1.StandardTab = True
        Me.DataGridView1.TabIndex = 1
        '
        'TextBoxSearch
        '
        Me.TextBoxSearch.Location = New System.Drawing.Point(57, 27)
        Me.TextBoxSearch.Name = "TextBoxSearch"
        Me.TextBoxSearch.Size = New System.Drawing.Size(564, 20)
        Me.TextBoxSearch.TabIndex = 0
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel1, Me.ToolStripStatusLabelDivider, Me.ToolStripStatusLabelUpdate})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 479)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.ShowItemToolTips = True
        Me.StatusStrip1.Size = New System.Drawing.Size(784, 22)
        Me.StatusStrip1.TabIndex = 5
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(0, 17)
        '
        'ToolStripStatusLabelDivider
        '
        Me.ToolStripStatusLabelDivider.Name = "ToolStripStatusLabelDivider"
        Me.ToolStripStatusLabelDivider.Size = New System.Drawing.Size(769, 17)
        Me.ToolStripStatusLabelDivider.Spring = True
        '
        'ToolStripStatusLabelUpdate
        '
        Me.ToolStripStatusLabelUpdate.IsLink = True
        Me.ToolStripStatusLabelUpdate.Name = "ToolStripStatusLabelUpdate"
        Me.ToolStripStatusLabelUpdate.Size = New System.Drawing.Size(0, 17)
        Me.ToolStripStatusLabelUpdate.ToolTipText = "Click here to download the latest version!"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.ToolsToolStripMenuItem, Me.OptionsToolStripMenuItem, Me.HelpToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(784, 24)
        Me.MenuStrip1.TabIndex = 3
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.OpenKnownUnitsFileToolStripMenuItem, Me.ReloadKnownUnitsFileToolStripMenuItem, Me.ToolStripSeparator1, Me.MinimizeToTrayToolStripMenuItem, Me.ExitToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'OpenKnownUnitsFileToolStripMenuItem
        '
        Me.OpenKnownUnitsFileToolStripMenuItem.Name = "OpenKnownUnitsFileToolStripMenuItem"
        Me.OpenKnownUnitsFileToolStripMenuItem.Size = New System.Drawing.Size(203, 22)
        Me.OpenKnownUnitsFileToolStripMenuItem.Text = "Open Known Units File..."
        '
        'ReloadKnownUnitsFileToolStripMenuItem
        '
        Me.ReloadKnownUnitsFileToolStripMenuItem.Enabled = False
        Me.ReloadKnownUnitsFileToolStripMenuItem.Name = "ReloadKnownUnitsFileToolStripMenuItem"
        Me.ReloadKnownUnitsFileToolStripMenuItem.Size = New System.Drawing.Size(203, 22)
        Me.ReloadKnownUnitsFileToolStripMenuItem.Text = "Reload Known Units File"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(200, 6)
        '
        'MinimizeToTrayToolStripMenuItem
        '
        Me.MinimizeToTrayToolStripMenuItem.Name = "MinimizeToTrayToolStripMenuItem"
        Me.MinimizeToTrayToolStripMenuItem.Size = New System.Drawing.Size(203, 22)
        Me.MinimizeToTrayToolStripMenuItem.Text = "Minimize to Tray"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(203, 22)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'ToolsToolStripMenuItem
        '
        Me.ToolsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AddKnownUnitsEntryToolStripMenuItem, Me.FixVoicemailProClientToolStripMenuItem})
        Me.ToolsToolStripMenuItem.Name = "ToolsToolStripMenuItem"
        Me.ToolsToolStripMenuItem.Size = New System.Drawing.Size(46, 20)
        Me.ToolsToolStripMenuItem.Text = "Tools"
        '
        'AddKnownUnitsEntryToolStripMenuItem
        '
        Me.AddKnownUnitsEntryToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.AddKnownUnitsEntryToolStripMenuItem.Name = "AddKnownUnitsEntryToolStripMenuItem"
        Me.AddKnownUnitsEntryToolStripMenuItem.Size = New System.Drawing.Size(198, 22)
        Me.AddKnownUnitsEntryToolStripMenuItem.Text = "Add Known Units Entry"
        '
        'FixVoicemailProClientToolStripMenuItem
        '
        Me.FixVoicemailProClientToolStripMenuItem.Name = "FixVoicemailProClientToolStripMenuItem"
        Me.FixVoicemailProClientToolStripMenuItem.Size = New System.Drawing.Size(198, 22)
        Me.FixVoicemailProClientToolStripMenuItem.Text = "Fix Voicemail Pro Client"
        '
        'OptionsToolStripMenuItem
        '
        Me.OptionsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SingleCellSelectToolStripMenuItem, Me.DarkModeToolStripMenuItem, Me.ToolStripSeparator2, Me.ResetAllSettingsToolStripMenuItem})
        Me.OptionsToolStripMenuItem.Name = "OptionsToolStripMenuItem"
        Me.OptionsToolStripMenuItem.Size = New System.Drawing.Size(61, 20)
        Me.OptionsToolStripMenuItem.Text = "Settings"
        '
        'SingleCellSelectToolStripMenuItem
        '
        Me.SingleCellSelectToolStripMenuItem.CheckOnClick = True
        Me.SingleCellSelectToolStripMenuItem.Name = "SingleCellSelectToolStripMenuItem"
        Me.SingleCellSelectToolStripMenuItem.Size = New System.Drawing.Size(164, 22)
        Me.SingleCellSelectToolStripMenuItem.Text = "Single Cell Select"
        '
        'DarkModeToolStripMenuItem
        '
        Me.DarkModeToolStripMenuItem.Name = "DarkModeToolStripMenuItem"
        Me.DarkModeToolStripMenuItem.Size = New System.Drawing.Size(164, 22)
        Me.DarkModeToolStripMenuItem.Text = "Dark Mode"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(161, 6)
        '
        'ResetAllSettingsToolStripMenuItem
        '
        Me.ResetAllSettingsToolStripMenuItem.Name = "ResetAllSettingsToolStripMenuItem"
        Me.ResetAllSettingsToolStripMenuItem.Size = New System.Drawing.Size(164, 22)
        Me.ResetAllSettingsToolStripMenuItem.Text = "Reset All Settings"
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AboutToolStripMenuItem, Me.CheckForUpdatesToolStripMenuItem, Me.ViewChangelogToolStripMenuItem, Me.ToolStripSeparator4, Me.ReportABugToolStripMenuItem, Me.ToolStripSeparator3, Me.BuyMeACoffeeToolStripMenuItem})
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(44, 20)
        Me.HelpToolStripMenuItem.Text = "Help"
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(174, 22)
        Me.AboutToolStripMenuItem.Text = "About"
        '
        'CheckForUpdatesToolStripMenuItem
        '
        Me.CheckForUpdatesToolStripMenuItem.Enabled = False
        Me.CheckForUpdatesToolStripMenuItem.Name = "CheckForUpdatesToolStripMenuItem"
        Me.CheckForUpdatesToolStripMenuItem.Size = New System.Drawing.Size(174, 22)
        Me.CheckForUpdatesToolStripMenuItem.Text = "Check for Updates"
        '
        'ViewChangelogToolStripMenuItem
        '
        Me.ViewChangelogToolStripMenuItem.Enabled = False
        Me.ViewChangelogToolStripMenuItem.Name = "ViewChangelogToolStripMenuItem"
        Me.ViewChangelogToolStripMenuItem.Size = New System.Drawing.Size(174, 22)
        Me.ViewChangelogToolStripMenuItem.Text = "View Changelog"
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(171, 6)
        '
        'ReportABugToolStripMenuItem
        '
        Me.ReportABugToolStripMenuItem.Name = "ReportABugToolStripMenuItem"
        Me.ReportABugToolStripMenuItem.Size = New System.Drawing.Size(174, 22)
        Me.ReportABugToolStripMenuItem.Text = "Report a Bug"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(171, 6)
        '
        'BuyMeACoffeeToolStripMenuItem
        '
        Me.BuyMeACoffeeToolStripMenuItem.Name = "BuyMeACoffeeToolStripMenuItem"
        Me.BuyMeACoffeeToolStripMenuItem.Size = New System.Drawing.Size(174, 22)
        Me.BuyMeACoffeeToolStripMenuItem.Text = "Buy me a coffee? :)"
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.Filter = "CSV Files (.csv)|*.csv"
        '
        'TextBoxPassword
        '
        Me.TextBoxPassword.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.TextBoxPassword.Location = New System.Drawing.Point(436, 427)
        Me.TextBoxPassword.Name = "TextBoxPassword"
        Me.TextBoxPassword.Size = New System.Drawing.Size(155, 20)
        Me.TextBoxPassword.TabIndex = 3
        Me.TextBoxPassword.UseSystemPasswordChar = True
        '
        'TextBoxUsername
        '
        Me.TextBoxUsername.AllowDrop = True
        Me.TextBoxUsername.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.TextBoxUsername.Location = New System.Drawing.Point(216, 427)
        Me.TextBoxUsername.Name = "TextBoxUsername"
        Me.TextBoxUsername.Size = New System.Drawing.Size(155, 20)
        Me.TextBoxUsername.TabIndex = 2
        '
        'ButtonLaunch
        '
        Me.ButtonLaunch.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.ButtonLaunch.Location = New System.Drawing.Point(158, 454)
        Me.ButtonLaunch.Name = "ButtonLaunch"
        Me.ButtonLaunch.Size = New System.Drawing.Size(213, 23)
        Me.ButtonLaunch.TabIndex = 4
        Me.ButtonLaunch.Text = "Launch System Status"
        Me.ButtonLaunch.UseVisualStyleBackColor = True
        '
        'LabelUsername
        '
        Me.LabelUsername.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.LabelUsername.AutoSize = True
        Me.LabelUsername.Location = New System.Drawing.Point(155, 430)
        Me.LabelUsername.Name = "LabelUsername"
        Me.LabelUsername.Size = New System.Drawing.Size(55, 13)
        Me.LabelUsername.TabIndex = 7
        Me.LabelUsername.Text = "Username"
        '
        'LabelPassword
        '
        Me.LabelPassword.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.LabelPassword.AutoSize = True
        Me.LabelPassword.Location = New System.Drawing.Point(377, 431)
        Me.LabelPassword.Name = "LabelPassword"
        Me.LabelPassword.Size = New System.Drawing.Size(53, 13)
        Me.LabelPassword.TabIndex = 8
        Me.LabelPassword.Text = "Password"
        '
        'LabelSearch
        '
        Me.LabelSearch.AutoSize = True
        Me.LabelSearch.Location = New System.Drawing.Point(12, 30)
        Me.LabelSearch.Name = "LabelSearch"
        Me.LabelSearch.Size = New System.Drawing.Size(41, 13)
        Me.LabelSearch.TabIndex = 9
        Me.LabelSearch.Text = "Search"
        '
        'NotifyIcon1
        '
        Me.NotifyIcon1.Text = "NotifyIcon1"
        Me.NotifyIcon1.Visible = True
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.OpenToolStripMenuItem, Me.ExitToolStripMenuItem1})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(105, 48)
        '
        'OpenToolStripMenuItem
        '
        Me.OpenToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OpenToolStripMenuItem.Name = "OpenToolStripMenuItem"
        Me.OpenToolStripMenuItem.Size = New System.Drawing.Size(104, 22)
        Me.OpenToolStripMenuItem.Text = "Open"
        '
        'ExitToolStripMenuItem1
        '
        Me.ExitToolStripMenuItem1.Name = "ExitToolStripMenuItem1"
        Me.ExitToolStripMenuItem1.Size = New System.Drawing.Size(104, 22)
        Me.ExitToolStripMenuItem1.Text = "Exit"
        '
        'ButtonCopyIP
        '
        Me.ButtonCopyIP.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ButtonCopyIP.Location = New System.Drawing.Point(659, 27)
        Me.ButtonCopyIP.Name = "ButtonCopyIP"
        Me.ButtonCopyIP.Size = New System.Drawing.Size(93, 22)
        Me.ButtonCopyIP.TabIndex = 10
        Me.ButtonCopyIP.Text = "Copy System IP"
        Me.ButtonCopyIP.UseVisualStyleBackColor = True
        Me.ButtonCopyIP.Visible = False
        '
        'ButtonLaunchManager
        '
        Me.ButtonLaunchManager.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.ButtonLaunchManager.Location = New System.Drawing.Point(380, 454)
        Me.ButtonLaunchManager.Name = "ButtonLaunchManager"
        Me.ButtonLaunchManager.Size = New System.Drawing.Size(211, 23)
        Me.ButtonLaunchManager.TabIndex = 11
        Me.ButtonLaunchManager.Text = "Launch Manager"
        Me.ButtonLaunchManager.UseVisualStyleBackColor = True
        '
        'ButtonCopyPassword
        '
        Me.ButtonCopyPassword.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ButtonCopyPassword.Location = New System.Drawing.Point(635, 427)
        Me.ButtonCopyPassword.Name = "ButtonCopyPassword"
        Me.ButtonCopyPassword.Size = New System.Drawing.Size(88, 20)
        Me.ButtonCopyPassword.TabIndex = 12
        Me.ButtonCopyPassword.Text = "Copy Password"
        Me.ButtonCopyPassword.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 431)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(0, 13)
        Me.Label1.TabIndex = 13
        Me.Label1.UseMnemonic = False
        '
        'ButtonShowPassword
        '
        Me.ButtonShowPassword.BackColor = System.Drawing.Color.Transparent
        Me.ButtonShowPassword.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ButtonShowPassword.Image = CType(resources.GetObject("ButtonShowPassword.Image"), System.Drawing.Image)
        Me.ButtonShowPassword.Location = New System.Drawing.Point(591, 426)
        Me.ButtonShowPassword.Name = "ButtonShowPassword"
        Me.ButtonShowPassword.Size = New System.Drawing.Size(24, 22)
        Me.ButtonShowPassword.TabIndex = 14
        Me.ButtonShowPassword.UseVisualStyleBackColor = False
        '
        'Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(784, 501)
        Me.Controls.Add(Me.ButtonShowPassword)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ButtonCopyPassword)
        Me.Controls.Add(Me.ButtonLaunchManager)
        Me.Controls.Add(Me.ButtonCopyIP)
        Me.Controls.Add(Me.LabelSearch)
        Me.Controls.Add(Me.LabelPassword)
        Me.Controls.Add(Me.LabelUsername)
        Me.Controls.Add(Me.ButtonLaunch)
        Me.Controls.Add(Me.TextBoxUsername)
        Me.Controls.Add(Me.TextBoxPassword)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.TextBoxSearch)
        Me.Controls.Add(Me.DataGridView1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Main"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents TextBoxSearch As TextBox
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents OpenKnownUnitsFileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents TextBoxPassword As TextBox
    Friend WithEvents TextBoxUsername As TextBox
    Friend WithEvents ButtonLaunch As Button
    Friend WithEvents LabelUsername As Label
    Friend WithEvents LabelPassword As Label
    Friend WithEvents ToolStripStatusLabel1 As ToolStripStatusLabel
    Friend WithEvents LabelSearch As Label
    Friend WithEvents OptionsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SingleCellSelectToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents NotifyIcon1 As NotifyIcon
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents OpenToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents CheckForUpdatesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripStatusLabelUpdate As ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabelDivider As ToolStripStatusLabel
    Friend WithEvents ReloadKnownUnitsFileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MinimizeToTrayToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents ToolStripSeparator2 As ToolStripSeparator
    Friend WithEvents ResetAllSettingsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ButtonCopyIP As Button
    Friend WithEvents ViewChangelogToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator3 As ToolStripSeparator
    Friend WithEvents BuyMeACoffeeToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ButtonLaunchManager As Button
    Friend WithEvents ButtonCopyPassword As Button
    Friend WithEvents ToolsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FixVoicemailProClientToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AddKnownUnitsEntryToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DarkModeToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Label1 As Label
    Friend WithEvents ToolStripSeparator4 As ToolStripSeparator
    Friend WithEvents ReportABugToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ButtonShowPassword As Button
End Class
