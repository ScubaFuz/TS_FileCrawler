Imports System.IO
Imports System.Xml
Imports System.Xml.Serialization

Module Common
    Friend dhdDB As New DataHandler.db
    Friend dhdText As New DataHandler.txt
    Friend xmlDoc As New XmlDocument
    Friend DebugMode As Boolean = False
    Friend CurSet As New Settings

    Private Declare Auto Function AllocConsole Lib "kernel32.dll" () As Boolean

    Public Sub Main()
        '--- Check if command line arguments were specified
        ParseCommands()
        If dhdText.InputFile = Nothing Then
            dhdText.InputFile = "TS_FileCrawlerData.xml"
        End If
        LoadXmlSettings()
        If CurSet.Folder = Not Nothing Then
            dhdText.FileRoot = CurSet.Folder
        End If

        'Dim args() As String = Environment.GetCommandLineArgs()
        'If args.Length > 1 Then
        If CurSet.SilentMode = True Then
            '--- Yep, create the console window and run the console mode logic
            AllocConsole()
            ConsoleMain()
        Else
            '--- Nope, run the normal Windows Forms startup code
            Application.EnableVisualStyles()
            Application.SetCompatibleTextRenderingDefault(False)
            Application.Run(New frmTS_FileCrawler)
        End If
    End Sub

    Private Sub ConsoleMain()
        '--- This code runs when command line arguments were given
        Console.WriteLine("Processing InputFile: " & dhdText.InputFile)
        Console.WriteLine("Processing Folder: " & dhdText.FileRoot)

        Crawl()
        Application.Exit()

        'Console.WriteLine("Command line = {0}", Environment.CommandLine)
        'Console.WriteLine("Exe path = {0}", args(0))
        'For ix As Integer = 1 To args.Length - 1
        '    Console.WriteLine("  Argument({0}) = {1}", ix, args(ix))
        'Next
        'Console.Write("Press ENTER to continue")
        'Dim s As String = Console.ReadLine()
    End Sub

    Friend Sub ParseCommands()
        Dim intLength As Integer = 0
        If My.Application.CommandLineArgs.Contains("/debug") Then DebugMode = True
        For i As Integer = 0 To My.Application.CommandLineArgs.Count - 1
            intLength = My.Application.CommandLineArgs.Item(i).ToString.Length
            If intLength > 0 Then
                If My.Application.CommandLineArgs.Item(i).ToString.Substring(1, 1).ToLower = "s" Then
                    CurSet.SilentMode = True
                End If
            End If
            If intLength > 7 Then
                If My.Application.CommandLineArgs.Item(i).ToString.Substring(1, 6).ToLower = "input:" Then
                    dhdText.InputFile = My.Application.CommandLineArgs.Item(i).ToString.Substring(7, intLength - 7)
                End If
                If My.Application.CommandLineArgs.Item(i).ToString.Substring(1, 6).ToLower = "silent" Then
                    CurSet.SilentMode = True
                End If
                If My.Application.CommandLineArgs.Item(i).ToString.Substring(1, 7).ToLower = "folder:" Then
                    CurSet.Folder = My.Application.CommandLineArgs.Item(i).ToString.Substring(8, intLength - 8)
                End If
            End If
        Next
    End Sub

    Friend Sub LoadXmlSettings()
        If dhdText.CheckFile(Application.StartupPath & "\" & dhdText.InputFile) = True Then
            'LoadXmlFile
            xmlDoc.Load(Application.StartupPath & "\" & dhdText.InputFile)
            dhdDB.DataLocation = xmlDoc.Item("FileCrawler").Item("DataBase").Item("DataLocation").InnerText
            dhdDB.DatabaseName = xmlDoc.Item("FileCrawler").Item("DataBase").Item("DatabaseName").InnerText
            dhdDB.DataTableName = xmlDoc.Item("FileCrawler").Item("DataBase").Item("DataTableName").InnerText
            dhdDB.DataProvider = xmlDoc.Item("FileCrawler").Item("DataBase").Item("DataProvider").InnerText
            dhdDB.LoginMethod = xmlDoc.Item("FileCrawler").Item("DataBase").Item("LoginMethod").InnerText
            dhdDB.LoginName = xmlDoc.Item("FileCrawler").Item("DataBase").Item("LoginName").InnerText
            dhdDB.Password = xmlDoc.Item("FileCrawler").Item("DataBase").Item("Password").InnerText

            CurSet.OutputScreen = xmlDoc.Item("FileCrawler").Item("Settings").Item("OutputScreen").InnerText
            CurSet.OutputFile = xmlDoc.Item("FileCrawler").Item("Settings").Item("OutputFile").InnerText
            CurSet.OutputDatabase = xmlDoc.Item("FileCrawler").Item("Settings").Item("OutputDatabase").InnerText
            dhdText.SubFolders = xmlDoc.Item("FileCrawler").Item("Settings").Item("CrawlSubfolders").InnerText
            dhdText.FileRoot = xmlDoc.Item("FileCrawler").Item("Settings").Item("FileRoot").InnerText
            dhdText.FileFilter = xmlDoc.Item("FileCrawler").Item("Settings").Item("FileFilter").InnerText
            'txtHandle.InputFile = xmlDoc.Item("FileCrawler").Item("Settings").Item("InputFile").InnerText
            dhdText.ExportFile = xmlDoc.Item("FileCrawler").Item("Settings").Item("ExportFile").InnerText
        End If
    End Sub

    Friend Function SaveXmlFile() As Boolean
        '** Create or update the xml inputdata.
        Dim strXmlText As String
        strXmlText = "<?xml version=""1.0"" standalone=""yes""?>" & vbCrLf
        strXmlText &= "<FileCrawler>" & vbCrLf
        strXmlText &= "	<DataBase>" & vbCrLf
        strXmlText &= "		<DataLocation>" & dhdDB.DataLocation & "</DataLocation>" & vbCrLf
        strXmlText &= "		<DatabaseName>" & dhdDB.DatabaseName & "</DatabaseName>" & vbCrLf
        strXmlText &= "		<DataTableName>" & dhdDB.DataTableName & "</DataTableName>" & vbCrLf
        strXmlText &= "		<DataProvider>" & dhdDB.DataProvider & "</DataProvider>" & vbCrLf
        strXmlText &= "		<LoginMethod>" & dhdDB.LoginMethod & "</LoginMethod>" & vbCrLf
        strXmlText &= "		<LoginName>" & dhdDB.LoginName & "</LoginName>" & vbCrLf
        strXmlText &= "		<Password>" & dhdDB.Password & "</Password>" & vbCrLf
        strXmlText &= "	</DataBase>" & vbCrLf
        strXmlText &= "	<Settings>" & vbCrLf
        strXmlText &= "		<OutputScreen>" & CurSet.OutputScreen & "</OutputScreen>" & vbCrLf
        strXmlText &= "		<OutputFile>" & CurSet.OutputFile & "</OutputFile>" & vbCrLf
        strXmlText &= "		<OutputDatabase>" & CurSet.OutputDatabase & "</OutputDatabase>" & vbCrLf
        strXmlText &= "		<CrawlSubfolders>" & dhdText.SubFolders & "</CrawlSubfolders>" & vbCrLf
        strXmlText &= "		<FileRoot>" & dhdText.FileRoot & "</FileRoot>" & vbCrLf
        strXmlText &= "		<FileFilter>" & dhdText.FileFilter & "</FileFilter>" & vbCrLf
        'strXmlText &= "		<InputFile>" & txtHandle.InputFile & "</InputFile>" & vbCrLf
        strXmlText &= "		<ExportFile>" & dhdText.ExportFile & "</ExportFile>" & vbCrLf
        strXmlText &= "	</Settings>" & vbCrLf
        strXmlText &= "</FileCrawler>" & vbCrLf
        xmlDoc.LoadXml(strXmlText)
        Try
            SaveXmlFile = dhdText.CreateFile(strXmlText, Application.StartupPath & "\" & dhdText.InputFile)
        Catch ex As Exception
            MessageBox.Show("There was an error saving the config file:" & Environment.NewLine & ex.Message)
        End Try
    End Function

    Friend Sub Crawl()
        If dhdText.CheckDir(dhdText.FileRoot) Then
            Dim objData As DataSet
            objData = dhdText.GetFilesInfo(dhdText.FileRoot, dhdText.FileFilter)

            If CurSet.OutputFile = True Then
                ExportFile(objData)
            End If
            If CurSet.OutputDatabase = True Then
                ExportDataBase(objData)
            End If
        Else
            MessageBox.Show("No valid Folder Selected")
        End If
    End Sub

    Friend Sub ExportFile(ByVal objData As DataSet)
        Dim xmlDoc As New StreamWriter(dhdText.ExportFile, False)
        objData.WriteXml(xmlDoc)
        xmlDoc.Close()
    End Sub

    Friend Sub ExportDataBase(ByVal objData As DataSet)
        dhdDB.UploadSqlData(objData.Tables(0))
        'UploadSqlData(objData.Tables(0))
    End Sub

    Friend Sub CreateTable(strTableName As String)
        Try
            Dim strSQL As String = "CREATE TABLE " & strTableName & " (" & _
                     "[FileName] [nvarchar](4000) NULL," & _
                     "[FileSizeKB] [int] NULL," & _
                     "[DateCreated] [datetime] NULL," & _
                     "[DateModified] [datetime] NULL," & _
                     "[FileExtension] [nvarchar](100) NULL," & _
                     "[FilePath] [nvarchar](4000) NULL," & _
                     "[ReportDate] [datetime] NULL" & _
                    ") ON [PRIMARY]"
            dhdDB.QueryDatabase(strSQL, False)
        Catch ex As Exception
            MessageBox.Show("There was an error creating the table:" & Environment.NewLine & ex.Message)
        End Try
    End Sub

End Module
