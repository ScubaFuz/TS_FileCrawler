Public Class Settings
    Private _OutputScreen As Boolean = True
    Private _OutputFile As Boolean = False
    Private _OutputDatabase As Boolean = False
    Private _InputFile As Boolean = False
    Private _Folder As String = Nothing
    Private _SilentMode As Boolean = False

    Public Property OutputScreen() As Boolean
        Get
            Return _OutputScreen
        End Get
        Set(ByVal Value As Boolean)
            _OutputScreen = Value
        End Set
    End Property

    Public Property OutputFile() As Boolean
        Get
            Return _OutputFile
        End Get
        Set(ByVal Value As Boolean)
            _OutputFile = Value
        End Set
    End Property

    Public Property OutputDatabase() As Boolean
        Get
            Return _OutputDatabase
        End Get
        Set(ByVal Value As Boolean)
            _OutputDatabase = Value
        End Set
    End Property

    Public Property InputFile() As Boolean
        Get
            Return _InputFile
        End Get
        Set(ByVal Value As Boolean)
            _InputFile = Value
        End Set
    End Property

    Public Property Folder() As String
        Get
            Return _Folder
        End Get
        Set(ByVal Value As String)
            _Folder = Value
        End Set
    End Property

    Public Property SilentMode() As Boolean
        Get
            Return _SilentMode
        End Get
        Set(ByVal Value As Boolean)
            _SilentMode = Value
        End Set
    End Property

End Class
