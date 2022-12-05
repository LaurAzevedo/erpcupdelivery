Imports System.IO
Imports System.Text
Imports Microsoft.Win32
Imports Npgsql

Class PostgreSQLController

    Private Declare Auto Function GetPrivateProfileString Lib "Kernel32" (ByVal lpAppName As String, ByVal lpKeyName As String, ByVal lpDefault As String, ByVal lpReturnedString As StringBuilder, ByVal nSize As Integer, ByVal lpFileName As String) As Integer
    Private Declare Auto Function WritePrivateProfileString Lib "Kernel32" (ByVal lpAppName As String, ByVal lpKeyName As String, ByVal lpString As String, ByVal lpFileName As String) As Integer
    Private Declare Function SQLConfigDataSource Lib "NpgsqlCP32.DLL" (ByVal hwndParent As Integer, ByVal ByValfRequest As Integer, ByVal lpszDriver As String, ByVal lpszAttributes As String) As Integer
    Private Declare Function SQLInstallerError Lib "NpgsqlCP32.DLL" (ByVal iError As Integer, ByRef pfErrorCode As Integer, ByVal lpszErrorMsg As System.Text.StringBuilder, ByVal cbErrorMsgMax As Integer, ByRef pcbErrorMsg As Integer) As Integer
    Private Const npgSqlAddDsn As Short = 1 'ADD DATA SOURCE
    Private Const npgSqlAddSysDsn As Short = 4
    Private Const vbAPINull As Integer = 0 'NULL POINTER
    Dim databaseConnectionAttempts As Integer = 0
    Dim driversNpgsql As New ArrayList()

    Public Sub ConnectDatabase()

        connectionString = "Server=" & server & ";Port=" & databasePort & ";Database=" & database & ";Userid=" & databaseUser & ";Password=" & databasePassword & ";Timeout=15;CommandTimeout=0;Encoding=UTF8;Client Encoding=UTF8;"
        connection = New NpgsqlConnection(connectionString)

        If connection.State = ConnectionState.Open Then
            connection.Close()
        End If

        connection.ConnectionString = connectionString

        Try
            connection.Open()
        Catch ex As Exception

            databaseConnectionAttempts += 1

            If databaseConnectionAttempts < 2 Then

                ConnectDatabase()

            End If

            BOX_MESSAGEM("ATENCAO", "OK", "Não foi possível estabelecer conexão com a base de dados!", ex.Message.ToString)

        End Try

    End Sub

End Class
