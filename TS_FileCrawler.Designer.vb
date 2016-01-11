<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTS_FileCrawler
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
        Me.txtFolder = New System.Windows.Forms.TextBox()
        Me.txtFilter = New System.Windows.Forms.TextBox()
        Me.lblCrawlFolder = New System.Windows.Forms.Label()
        Me.lblFilter = New System.Windows.Forms.Label()
        Me.btnCrawl = New System.Windows.Forms.Button()
        Me.dgvResult = New System.Windows.Forms.DataGridView()
        Me.chkScreen = New System.Windows.Forms.CheckBox()
        Me.chkDatabase = New System.Windows.Forms.CheckBox()
        Me.chkFile = New System.Windows.Forms.CheckBox()
        Me.txtServer = New System.Windows.Forms.TextBox()
        Me.txtDatabase = New System.Windows.Forms.TextBox()
        Me.txtTable = New System.Windows.Forms.TextBox()
        Me.txtUser = New System.Windows.Forms.TextBox()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.txtFileName = New System.Windows.Forms.TextBox()
        Me.lblFileName = New System.Windows.Forms.Label()
        Me.lblDatabaseName = New System.Windows.Forms.Label()
        Me.lblDatabaseServerName = New System.Windows.Forms.Label()
        Me.lblTable = New System.Windows.Forms.Label()
        Me.chkWinAuth = New System.Windows.Forms.CheckBox()
        Me.lblUser = New System.Windows.Forms.Label()
        Me.lblPassword = New System.Windows.Forms.Label()
        Me.chkSubfolders = New System.Windows.Forms.CheckBox()
        Me.btnSaveSettings = New System.Windows.Forms.Button()
        Me.btnCreateTable = New System.Windows.Forms.Button()
        Me.btnResetButtons = New System.Windows.Forms.Button()
        CType(Me.dgvResult, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtFolder
        '
        Me.txtFolder.Location = New System.Drawing.Point(226, 23)
        Me.txtFolder.Margin = New System.Windows.Forms.Padding(2)
        Me.txtFolder.Name = "txtFolder"
        Me.txtFolder.Size = New System.Drawing.Size(274, 20)
        Me.txtFolder.TabIndex = 0
        '
        'txtFilter
        '
        Me.txtFilter.Location = New System.Drawing.Point(226, 50)
        Me.txtFilter.Margin = New System.Windows.Forms.Padding(2)
        Me.txtFilter.Name = "txtFilter"
        Me.txtFilter.Size = New System.Drawing.Size(147, 20)
        Me.txtFilter.TabIndex = 2
        '
        'lblCrawlFolder
        '
        Me.lblCrawlFolder.AutoSize = True
        Me.lblCrawlFolder.Location = New System.Drawing.Point(22, 25)
        Me.lblCrawlFolder.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblCrawlFolder.Name = "lblCrawlFolder"
        Me.lblCrawlFolder.Size = New System.Drawing.Size(189, 13)
        Me.lblCrawlFolder.TabIndex = 3
        Me.lblCrawlFolder.Text = "Folder to Crawl ('C:\data\folder' format)"
        '
        'lblFilter
        '
        Me.lblFilter.AutoSize = True
        Me.lblFilter.Location = New System.Drawing.Point(22, 52)
        Me.lblFilter.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblFilter.Name = "lblFilter"
        Me.lblFilter.Size = New System.Drawing.Size(153, 13)
        Me.lblFilter.TabIndex = 4
        Me.lblFilter.Text = "File Extension Filter ('*.*' format)"
        '
        'btnCrawl
        '
        Me.btnCrawl.Location = New System.Drawing.Point(573, 18)
        Me.btnCrawl.Margin = New System.Windows.Forms.Padding(2)
        Me.btnCrawl.Name = "btnCrawl"
        Me.btnCrawl.Size = New System.Drawing.Size(103, 28)
        Me.btnCrawl.TabIndex = 5
        Me.btnCrawl.Text = "Crawl Now"
        Me.btnCrawl.UseVisualStyleBackColor = True
        '
        'dgvResult
        '
        Me.dgvResult.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvResult.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvResult.Location = New System.Drawing.Point(9, 203)
        Me.dgvResult.Margin = New System.Windows.Forms.Padding(2)
        Me.dgvResult.Name = "dgvResult"
        Me.dgvResult.RowTemplate.Height = 24
        Me.dgvResult.Size = New System.Drawing.Size(874, 449)
        Me.dgvResult.TabIndex = 6
        '
        'chkScreen
        '
        Me.chkScreen.AutoSize = True
        Me.chkScreen.Checked = True
        Me.chkScreen.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkScreen.Location = New System.Drawing.Point(24, 80)
        Me.chkScreen.Margin = New System.Windows.Forms.Padding(2)
        Me.chkScreen.Name = "chkScreen"
        Me.chkScreen.Size = New System.Drawing.Size(107, 17)
        Me.chkScreen.TabIndex = 7
        Me.chkScreen.Text = "Output to Screen"
        Me.chkScreen.UseVisualStyleBackColor = True
        '
        'chkDatabase
        '
        Me.chkDatabase.AutoSize = True
        Me.chkDatabase.Location = New System.Drawing.Point(24, 127)
        Me.chkDatabase.Margin = New System.Windows.Forms.Padding(2)
        Me.chkDatabase.Name = "chkDatabase"
        Me.chkDatabase.Size = New System.Drawing.Size(119, 17)
        Me.chkDatabase.TabIndex = 8
        Me.chkDatabase.Text = "Output to Database"
        Me.chkDatabase.UseVisualStyleBackColor = True
        '
        'chkFile
        '
        Me.chkFile.AutoSize = True
        Me.chkFile.Location = New System.Drawing.Point(24, 102)
        Me.chkFile.Margin = New System.Windows.Forms.Padding(2)
        Me.chkFile.Name = "chkFile"
        Me.chkFile.Size = New System.Drawing.Size(89, 17)
        Me.chkFile.TabIndex = 9
        Me.chkFile.Text = "Output to File"
        Me.chkFile.UseVisualStyleBackColor = True
        '
        'txtServer
        '
        Me.txtServer.Enabled = False
        Me.txtServer.Location = New System.Drawing.Point(346, 125)
        Me.txtServer.Margin = New System.Windows.Forms.Padding(2)
        Me.txtServer.Name = "txtServer"
        Me.txtServer.Size = New System.Drawing.Size(155, 20)
        Me.txtServer.TabIndex = 10
        '
        'txtDatabase
        '
        Me.txtDatabase.Enabled = False
        Me.txtDatabase.Location = New System.Drawing.Point(346, 148)
        Me.txtDatabase.Margin = New System.Windows.Forms.Padding(2)
        Me.txtDatabase.Name = "txtDatabase"
        Me.txtDatabase.Size = New System.Drawing.Size(155, 20)
        Me.txtDatabase.TabIndex = 11
        '
        'txtTable
        '
        Me.txtTable.Enabled = False
        Me.txtTable.Location = New System.Drawing.Point(346, 171)
        Me.txtTable.Margin = New System.Windows.Forms.Padding(2)
        Me.txtTable.Name = "txtTable"
        Me.txtTable.Size = New System.Drawing.Size(155, 20)
        Me.txtTable.TabIndex = 12
        '
        'txtUser
        '
        Me.txtUser.Enabled = False
        Me.txtUser.Location = New System.Drawing.Point(601, 148)
        Me.txtUser.Margin = New System.Windows.Forms.Padding(2)
        Me.txtUser.Name = "txtUser"
        Me.txtUser.Size = New System.Drawing.Size(76, 20)
        Me.txtUser.TabIndex = 13
        '
        'txtPassword
        '
        Me.txtPassword.Enabled = False
        Me.txtPassword.Location = New System.Drawing.Point(601, 171)
        Me.txtPassword.Margin = New System.Windows.Forms.Padding(2)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPassword.Size = New System.Drawing.Size(76, 20)
        Me.txtPassword.TabIndex = 14
        '
        'txtFileName
        '
        Me.txtFileName.Enabled = False
        Me.txtFileName.Location = New System.Drawing.Point(226, 100)
        Me.txtFileName.Margin = New System.Windows.Forms.Padding(2)
        Me.txtFileName.Name = "txtFileName"
        Me.txtFileName.Size = New System.Drawing.Size(274, 20)
        Me.txtFileName.TabIndex = 15
        '
        'lblFileName
        '
        Me.lblFileName.AutoSize = True
        Me.lblFileName.Location = New System.Drawing.Point(169, 102)
        Me.lblFileName.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblFileName.Name = "lblFileName"
        Me.lblFileName.Size = New System.Drawing.Size(54, 13)
        Me.lblFileName.TabIndex = 16
        Me.lblFileName.Text = "File Name"
        '
        'lblDatabaseName
        '
        Me.lblDatabaseName.AutoSize = True
        Me.lblDatabaseName.Location = New System.Drawing.Point(224, 150)
        Me.lblDatabaseName.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblDatabaseName.Name = "lblDatabaseName"
        Me.lblDatabaseName.Size = New System.Drawing.Size(82, 13)
        Me.lblDatabaseName.TabIndex = 17
        Me.lblDatabaseName.Text = "Database name"
        '
        'lblDatabaseServerName
        '
        Me.lblDatabaseServerName.AutoSize = True
        Me.lblDatabaseServerName.Location = New System.Drawing.Point(224, 128)
        Me.lblDatabaseServerName.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblDatabaseServerName.Name = "lblDatabaseServerName"
        Me.lblDatabaseServerName.Size = New System.Drawing.Size(118, 13)
        Me.lblDatabaseServerName.TabIndex = 18
        Me.lblDatabaseServerName.Text = "Database Server Name"
        '
        'lblTable
        '
        Me.lblTable.AutoSize = True
        Me.lblTable.Location = New System.Drawing.Point(224, 173)
        Me.lblTable.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblTable.Name = "lblTable"
        Me.lblTable.Size = New System.Drawing.Size(65, 13)
        Me.lblTable.TabIndex = 19
        Me.lblTable.Text = "Table Name"
        '
        'chkWinAuth
        '
        Me.chkWinAuth.AutoSize = True
        Me.chkWinAuth.Checked = True
        Me.chkWinAuth.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkWinAuth.Enabled = False
        Me.chkWinAuth.Location = New System.Drawing.Point(522, 127)
        Me.chkWinAuth.Margin = New System.Windows.Forms.Padding(2)
        Me.chkWinAuth.Name = "chkWinAuth"
        Me.chkWinAuth.Size = New System.Drawing.Size(160, 17)
        Me.chkWinAuth.TabIndex = 20
        Me.chkWinAuth.Text = "Use windows Authentication"
        Me.chkWinAuth.UseVisualStyleBackColor = True
        '
        'lblUser
        '
        Me.lblUser.AutoSize = True
        Me.lblUser.Location = New System.Drawing.Point(520, 150)
        Me.lblUser.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblUser.Name = "lblUser"
        Me.lblUser.Size = New System.Drawing.Size(60, 13)
        Me.lblUser.TabIndex = 21
        Me.lblUser.Text = "User Name"
        '
        'lblPassword
        '
        Me.lblPassword.AutoSize = True
        Me.lblPassword.Location = New System.Drawing.Point(520, 173)
        Me.lblPassword.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblPassword.Name = "lblPassword"
        Me.lblPassword.Size = New System.Drawing.Size(53, 13)
        Me.lblPassword.TabIndex = 22
        Me.lblPassword.Text = "Password"
        '
        'chkSubfolders
        '
        Me.chkSubfolders.AutoSize = True
        Me.chkSubfolders.Location = New System.Drawing.Point(399, 52)
        Me.chkSubfolders.Margin = New System.Windows.Forms.Padding(2)
        Me.chkSubfolders.Name = "chkSubfolders"
        Me.chkSubfolders.Size = New System.Drawing.Size(105, 17)
        Me.chkSubfolders.TabIndex = 23
        Me.chkSubfolders.Text = "Crawl Subfolders"
        Me.chkSubfolders.UseVisualStyleBackColor = True
        '
        'btnSaveSettings
        '
        Me.btnSaveSettings.Location = New System.Drawing.Point(573, 50)
        Me.btnSaveSettings.Margin = New System.Windows.Forms.Padding(2)
        Me.btnSaveSettings.Name = "btnSaveSettings"
        Me.btnSaveSettings.Size = New System.Drawing.Size(103, 27)
        Me.btnSaveSettings.TabIndex = 24
        Me.btnSaveSettings.Text = "Save Settings"
        Me.btnSaveSettings.UseVisualStyleBackColor = True
        '
        'btnCreateTable
        '
        Me.btnCreateTable.Enabled = False
        Me.btnCreateTable.Location = New System.Drawing.Point(25, 162)
        Me.btnCreateTable.Margin = New System.Windows.Forms.Padding(2)
        Me.btnCreateTable.Name = "btnCreateTable"
        Me.btnCreateTable.Size = New System.Drawing.Size(103, 25)
        Me.btnCreateTable.TabIndex = 25
        Me.btnCreateTable.Text = "Create Table"
        Me.btnCreateTable.UseVisualStyleBackColor = True
        '
        'btnResetButtons
        '
        Me.btnResetButtons.Location = New System.Drawing.Point(573, 81)
        Me.btnResetButtons.Margin = New System.Windows.Forms.Padding(2)
        Me.btnResetButtons.Name = "btnResetButtons"
        Me.btnResetButtons.Size = New System.Drawing.Size(103, 27)
        Me.btnResetButtons.TabIndex = 26
        Me.btnResetButtons.Text = "Reset Buttons"
        Me.btnResetButtons.UseVisualStyleBackColor = True
        '
        'frmTS_FileCrawler
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(892, 662)
        Me.Controls.Add(Me.btnResetButtons)
        Me.Controls.Add(Me.btnCreateTable)
        Me.Controls.Add(Me.btnSaveSettings)
        Me.Controls.Add(Me.chkSubfolders)
        Me.Controls.Add(Me.lblPassword)
        Me.Controls.Add(Me.lblUser)
        Me.Controls.Add(Me.chkWinAuth)
        Me.Controls.Add(Me.lblTable)
        Me.Controls.Add(Me.lblDatabaseServerName)
        Me.Controls.Add(Me.lblDatabaseName)
        Me.Controls.Add(Me.lblFileName)
        Me.Controls.Add(Me.txtFileName)
        Me.Controls.Add(Me.txtPassword)
        Me.Controls.Add(Me.txtUser)
        Me.Controls.Add(Me.txtTable)
        Me.Controls.Add(Me.txtDatabase)
        Me.Controls.Add(Me.txtServer)
        Me.Controls.Add(Me.chkFile)
        Me.Controls.Add(Me.chkDatabase)
        Me.Controls.Add(Me.chkScreen)
        Me.Controls.Add(Me.dgvResult)
        Me.Controls.Add(Me.btnCrawl)
        Me.Controls.Add(Me.lblFilter)
        Me.Controls.Add(Me.lblCrawlFolder)
        Me.Controls.Add(Me.txtFilter)
        Me.Controls.Add(Me.txtFolder)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "frmTS_FileCrawler"
        Me.Text = "Thicor Services File Crawler"
        CType(Me.dgvResult, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtFolder As System.Windows.Forms.TextBox
    Friend WithEvents txtFilter As System.Windows.Forms.TextBox
    Friend WithEvents lblCrawlFolder As System.Windows.Forms.Label
    Friend WithEvents lblFilter As System.Windows.Forms.Label
    Friend WithEvents btnCrawl As System.Windows.Forms.Button
    Friend WithEvents dgvResult As System.Windows.Forms.DataGridView
    Friend WithEvents chkScreen As System.Windows.Forms.CheckBox
    Friend WithEvents chkDatabase As System.Windows.Forms.CheckBox
    Friend WithEvents chkFile As System.Windows.Forms.CheckBox
    Friend WithEvents txtServer As System.Windows.Forms.TextBox
    Friend WithEvents txtDatabase As System.Windows.Forms.TextBox
    Friend WithEvents txtTable As System.Windows.Forms.TextBox
    Friend WithEvents txtUser As System.Windows.Forms.TextBox
    Friend WithEvents txtPassword As System.Windows.Forms.TextBox
    Friend WithEvents txtFileName As System.Windows.Forms.TextBox
    Friend WithEvents lblFileName As System.Windows.Forms.Label
    Friend WithEvents lblDatabaseName As System.Windows.Forms.Label
    Friend WithEvents lblDatabaseServerName As System.Windows.Forms.Label
    Friend WithEvents lblTable As System.Windows.Forms.Label
    Friend WithEvents chkWinAuth As System.Windows.Forms.CheckBox
    Friend WithEvents lblUser As System.Windows.Forms.Label
    Friend WithEvents lblPassword As System.Windows.Forms.Label
    Friend WithEvents chkSubfolders As System.Windows.Forms.CheckBox
    Friend WithEvents btnSaveSettings As System.Windows.Forms.Button
    Friend WithEvents btnCreateTable As System.Windows.Forms.Button
    Friend WithEvents btnResetButtons As System.Windows.Forms.Button

End Class
