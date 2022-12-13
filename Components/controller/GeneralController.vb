Imports System.Text.RegularExpressions

Module GeneralController

    Public CloseSplashScreen As Boolean = False
    Public AppDataFolder As String = "C:\ProgramData\"

    'DATA_VALIDA
    Public tmp_data As String
    Public DATA_FINAL_PESQUISA As String = "N"

    Public Sub OPEN_MOUSE()
        Dim cur As Cursor = Cursors.WaitCursor
        Cursor.Current = cur
    End Sub

    Public Sub CLOSE_MOUSE()
        Dim cur As Cursor = Cursors.Default
        Cursor.Current = cur
    End Sub

    Public Function CHECK_INTERNET_CONNECTION()
        Try
            My.Computer.Network.Ping("www.google.com", 10)
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function

    Public Sub WAIT_A_TIME()
        System.Threading.Thread.Sleep(0.001)
        Application.DoEvents()
    End Sub

    Public Function ValidateCpf(ByVal CPF As String) As Boolean

        'Remove caracteres inválidos do CPF
        CPF = Regex.Replace(CPF, "[^0-9]", "")

        'Verifica se o CPF tem 11 dígitos
        If CPF.Length <> 11 Then
            Return False
        End If

        'Calcula o primeiro dígito verificador

        Dim sum As Integer = 0

        For i As Integer = 0 To 8
            sum += Integer.Parse(CPF.Substring(i, 1)) * (10 - i)
        Next

        Dim firstDigit As Integer = 11 - (sum Mod 11)

        If firstDigit >= 10 Then
            firstDigit = 0
        End If

        'Calcula o segundo dígito verificador

        sum = 0

        For i As Integer = 0 To 8
            sum += Integer.Parse(CPF.Substring(i, 1)) * (11 - i)
        Next

        sum += firstDigit * 2

        Dim secondDigit As Integer = 11 - (sum Mod 11)

        If secondDigit >= 10 Then
            secondDigit = 0
        End If

        'Verifica se os dígitos verificadores calculados são iguais aos dígitos verificadores do CPF informado
        If firstDigit = Integer.Parse(CPF.Substring(9, 1)) AndAlso secondDigit = Integer.Parse(CPF.Substring(10, 1)) Then
            Return True
        Else
            Return False
        End If

    End Function

End Module
