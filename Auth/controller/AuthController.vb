Imports System.IO
Imports System.Security.Cryptography
Imports System.Net
Imports System.Text
Imports Newtonsoft.Json

Module AuthController

    Public BaseUrl As String = "http://164.92.120.210:7766"
    ReadOnly Username As String = "erp"
    ReadOnly Password As String = "71681095"
    Public AccessToken As String = ""
    Public RefreshToken As String = ""
    Public ReturnWithError As String = ""

    Private Function EncodeBase64(input As String) As String
        Return System.Convert.ToBase64String(System.Text.Encoding.UTF8.GetBytes(input))
    End Function

    Public Function AuthLogin()

        Dim HttpRequest As New WebClient()

        Dim RequestByte As Byte()
        Dim RequestString() As Byte
        Dim Parameters As String = ""
        Dim Path As String = "/auth/login"

        Try

            'DEFINIÇÃO DO TIPO DE REQUISIÇÃO QUE SERÁ FEITA
            HttpRequest.Headers("content-type") = "application/json"
            HttpRequest.Headers("Authorization") = "Basic " & EncodeBase64(Username & ":" & Password)

            Dim codigo As String = "Basic " & EncodeBase64(Username & ":" & Password)

            'CONVERTENDO O BODY PARA BYTES
            RequestString = Encoding.Default.GetBytes(Parameters)

            'FAZENDO A REQUISIÇÃO
            RequestByte = HttpRequest.DownloadData(BaseUrl & Path)

            'PEGANDO O RETORNO EM STRING
            Dim Request As String = Encoding.Default.GetString(RequestByte)

            'DECODIFICANDO O RETORNO
            Dim Result As Auth.Login = JsonConvert.DeserializeObject(Of Auth.Login)(Request)

            AccessToken = Result.Access_token
            RefreshToken = Result.Refresh_token

            HttpRequest.Dispose()

        Catch ex As WebException

            'TRATAMENTO DE ERRO
            Using stream = ex.Response.GetResponseStream()

                Using sr = New StreamReader(stream)

                    ReturnWithError = sr.ReadToEnd()

                End Using

            End Using

            Return False

            Exit Function
        End Try

        Return True

    End Function

End Module
