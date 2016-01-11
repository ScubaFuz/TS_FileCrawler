Imports System.IO

Public Class frmTS_FileCrawler

    Private Sub frmFileCrawler_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'ParseCommands()
        'If txtHandle.InputFile = Nothing Then
        '    txtHandle.InputFile = "FileCrawlerData.xml"
        'End If
        'LoadXmlSettings()
        'If CurSet.Folder = Not Nothing Then
        '    txtHandle.FileRoot = CurSet.Folder
        'End If
        SetFields()
    End Sub

    Private Sub btnCrawl_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCrawl.Click
        btnCrawl.Enabled = False
        btnSaveSettings.Enabled = False
        btnCreateTable.Enabled = False
        SaveFields()
        CrawlNow()
        btnCrawl.Enabled = True
        btnSaveSettings.Enabled = True
        Checkfields()
    End Sub

    Private Sub btnSaveSettings_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSaveSettings.Click
        SaveFields()
        SaveXmlFile()
    End Sub

    Private Sub CrawlNow()
        If dhdText.CheckDir(txtFolder.Text) Then
            Dim objData As DataSet
            objData = dhdText.GetFilesInfo(txtFolder.Text, txtFilter.Text)
            If chkScreen.Checked = True Then
                dgvResult.DataSource = objData.Tables(0)
            End If
            If chkFile.Checked = True Then
                ExportFile(objData)
            End If
            If chkDatabase.Checked = True Then
                ExportDataBase(objData)
            End If
        Else
            MessageBox.Show("No valid Folder Selected")
        End If
    End Sub

    Private Sub SetFields()
        txtServer.Text = dhdDB.DataLocation
        txtDatabase.Text = dhdDB.DatabaseName
        txtTable.Text = dhdDB.DataTableName
        If dhdDB.LoginMethod = "WINDOWS" Then
            chkWinAuth.Checked = True
        Else
            chkWinAuth.Checked = False
        End If
        txtUser.Text = dhdDB.LoginName
        txtPassword.Text = dhdDB.Password

        chkScreen.Checked = CurSet.OutputScreen
        chkFile.Checked = CurSet.OutputFile
        chkDatabase.Checked = CurSet.OutputDatabase
        chkSubfolders.Checked = dhdText.SubFolders
        txtFolder.Text = dhdText.FileRoot
        txtFilter.Text = dhdText.FileFilter
        'txtFileName.Text = txtHandle.InputFile
        txtFileName.Text = dhdText.ExportFile
        Checkfields()
    End Sub

    Private Sub SaveFields()
        dhdDB.DataLocation = txtServer.Text
        dhdDB.DatabaseName = txtDatabase.Text
        dhdDB.DataTableName = txtTable.Text

        If chkWinAuth.Checked = True Then
            dhdDB.LoginMethod = "WINDOWS"
        Else
            dhdDB.LoginMethod = "SQL"
        End If
        dhdDB.LoginName = txtUser.Text
        dhdDB.Password = txtPassword.Text

        CurSet.OutputScreen = chkScreen.Checked
        CurSet.OutputFile = chkFile.Checked
        CurSet.OutputDatabase = chkDatabase.Checked
        dhdText.SubFolders = chkSubfolders.Checked
        dhdText.FileRoot = txtFolder.Text
        dhdText.FileFilter = txtFilter.Text
        'txtHandle.InputFile = txtFileName.Text
        dhdText.ExportFile = txtFileName.Text

    End Sub

    Private Sub Checkfields()
        If chkDatabase.Checked = True Then
            txtServer.Enabled = True
            txtDatabase.Enabled = True
            txtTable.Enabled = True
            chkWinAuth.Enabled = True
            btnCreateTable.Enabled = True
            If chkWinAuth.Checked = False Then
                txtUser.Enabled = True
                txtPassword.Enabled = True
            Else
                txtUser.Enabled = False
                txtPassword.Enabled = False
            End If
        Else
            txtServer.Enabled = False
            txtDatabase.Enabled = False
            txtTable.Enabled = False
            chkWinAuth.Enabled = False
            txtUser.Enabled = False
            txtPassword.Enabled = False
            btnCreateTable.Enabled = False
        End If
        If chkFile.Checked = True Then
            txtFileName.Enabled = True
        Else
            txtFileName.Enabled = False
        End If
    End Sub

    Private Sub chkDatabase_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkDatabase.CheckedChanged
        Checkfields()
    End Sub

    Private Sub chkFile_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkFile.CheckedChanged
        Checkfields()
    End Sub

    Private Sub chkWinAuth_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkWinAuth.CheckedChanged
        Checkfields()
    End Sub

    Private Sub btnCreateTable_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCreateTable.Click
        If txtTable.Text.Length < 1 Then
            MessageBox.Show("Please enter a tablename first")
            Exit Sub
        End If
        SaveFields()
        CreateTable(txtTable.Text)
    End Sub

    Private Sub chkSubfolders_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkSubfolders.CheckedChanged
        If chkSubfolders.Checked = True Then
            dhdText.SubFolders = True
        Else
            dhdText.SubFolders = False
        End If
    End Sub

    Private Sub btnResetButtons_Click(sender As Object, e As EventArgs) Handles btnResetButtons.Click
        btnCrawl.Enabled = True
        btnSaveSettings.Enabled = True
        btnCreateTable.Enabled = True
    End Sub
End Class
