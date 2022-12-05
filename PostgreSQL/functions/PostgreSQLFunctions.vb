Module PostgreSQLFunctions

    'VARIAVEIS DE CONEXÃO
    Public server As String = "localhost"
    Public database As String = "deliverybackend"
    Public databaseUser As String = "postgres"
    Public databasePassword As String = "postgrespw"
    Public databasePort As String = "5432"
    Public connectionString As String = ""
    Public connection As New Npgsql.NpgsqlConnection
    Public connectionAttempt As Integer = 0

    Private Declare Function SQLConfigDataSource Lib "ODBCCP32.DLL" (ByVal hwndParent As Integer, ByVal ByValfRequest As Integer, ByVal lpszDriver As String, ByVal lpszAttributes As String) As Integer
    Private Declare Function SQLInstallerError Lib "ODBCCP32.DLL" (ByVal iError As Integer, ByRef pfErrorCode As Integer, ByVal lpszErrorMsg As System.Text.StringBuilder, ByVal cbErrorMsgMax As Integer, ByRef pcbErrorMsg As Integer) As Integer

    Private Const ODBC_ADD_DSN As Short = 1 ' Add data source
    Private Const ODBC_ADD_SYS_DSN As Short = 4
    Private Const vbAPINull As Integer = 0 ' NULL Pointer

    Function NEW_PARAMETER(ByRef sequence As String, ByRef parameterType As String, ByRef parameterValue As Object, Optional ByVal parameterSize As Integer = 0) As Npgsql.NpgsqlParameter

        Try
            parameterType = UCase(parameterType)
        Catch ex As Exception

        End Try

        Dim parametro As New Npgsql.NpgsqlParameter

        If parameterSize = 0 Then

            If parameterType = "I" Then

                parametro = New Npgsql.NpgsqlParameter("@v" & sequence, NpgsqlTypes.NpgsqlDbType.Integer)

                If parameterValue Is Nothing Then
                    parametro.Value = DBNull.Value
                Else

                    Try
                        parametro.Value = Val(parameterValue)
                    Catch ex As Exception
                        parametro.Value = DBNull.Value
                    End Try

                End If

            ElseIf parameterType = "S" Then

                Try
                    parameterValue = parameterValue.Replace(Convert.ToChar(0), "")
                Catch ex As Exception

                End Try

                parametro = New Npgsql.NpgsqlParameter("@v" & sequence, NpgsqlTypes.NpgsqlDbType.Varchar)

                If parameterValue Is Nothing Then
                    parametro.Value = DBNull.Value
                Else
                    parametro.Value = parameterValue.ToString
                End If

            ElseIf parameterType = "N" Then

                parametro = New Npgsql.NpgsqlParameter("@v" & sequence, NpgsqlTypes.NpgsqlDbType.Numeric)

                If parameterValue Is Nothing Then
                    parametro.Value = DBNull.Value
                Else
                    parametro.Value = Convert.ToDecimal(parameterValue)
                End If

            ElseIf parameterType = "D" Then

                parametro = New Npgsql.NpgsqlParameter("@v" & sequence, NpgsqlTypes.NpgsqlDbType.Date)

                If parameterValue Is Nothing Then
                    parametro.Value = DBNull.Value
                Else
                    parametro.Value = CDate(parameterValue)
                End If

            ElseIf parameterType = "B" Then

                parametro = New Npgsql.NpgsqlParameter("@v" & sequence, NpgsqlTypes.NpgsqlDbType.Bytea)

                If parameterValue Is Nothing Then
                    parametro.Value = DBNull.Value
                Else
                    parametro.Value = parameterValue
                End If

            End If
        Else

            If parameterType = "I" Then

                parametro = New Npgsql.NpgsqlParameter("@v" & sequence, NpgsqlTypes.NpgsqlDbType.Integer)

                If parameterValue Is Nothing Then
                    parametro.Value = DBNull.Value
                Else
                    parametro.Value = Val(parameterValue)
                End If

            ElseIf parameterType = "S" Then

                Try
                    parameterValue = parameterValue.Replace(Convert.ToChar(0), "")
                Catch ex As Exception

                End Try

                parametro = New Npgsql.NpgsqlParameter("@v" & sequence, NpgsqlTypes.NpgsqlDbType.Varchar)

                If parameterValue Is Nothing Then
                    parametro.Value = DBNull.Value
                Else
                    parametro.Value = parameterValue.ToString
                End If

            ElseIf parameterType = "N" Then

                parametro = New Npgsql.NpgsqlParameter("@v" & sequence, NpgsqlTypes.NpgsqlDbType.Numeric)

                If parameterValue Is Nothing Then
                    parametro.Value = DBNull.Value
                Else
                    parametro.Value = Convert.ToDecimal(parameterValue)
                End If

            ElseIf parameterType = "D" Then

                parametro = New Npgsql.NpgsqlParameter("@v" & sequence, NpgsqlTypes.NpgsqlDbType.Date)

                If parameterValue Is Nothing Then
                    parametro.Value = DBNull.Value
                Else
                    parametro.Value = CDate(parameterValue)
                End If

            ElseIf parameterType = "B" Then

                parametro = New Npgsql.NpgsqlParameter("@v" & sequence, NpgsqlTypes.NpgsqlDbType.Bytea)

                If parameterValue Is Nothing Then
                    parametro.Value = DBNull.Value
                Else
                    parametro.Value = parameterValue
                End If

            End If

        End If

        Return parametro

    End Function


End Module
