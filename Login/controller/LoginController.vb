Imports System.IO
Imports System.Security.Cryptography
Imports System.Net
Imports System.Text
Imports Newtonsoft.Json

Module LoginController

    Public Function UserLogin(Email As String, Password As String)

        Dim Credentials As New ErpLogin.Login
        Credentials.email = Email
        Credentials.password = Password

        Dim HttpRequest As New WebClient()
        Dim RequestByte As Byte()
        Dim RequestString() As Byte
        Dim Parameters As String = JsonConvert.SerializeObject(Credentials)
        Dim Path As String = "/erpuser/login"

        Try

            'DEFINIÇÃO DO TIPO DE REQUISIÇÃO QUE SERÁ FEITA
            HttpRequest.Headers("content-type") = "application/json"
            HttpRequest.Headers("Authorization") = "Bearer " & AccessToken

            'CONVERTENDO O BODY PARA BYTES
            RequestString = Encoding.Default.GetBytes(Parameters)

            'FAZENDO A REQUISIÇÃO
            RequestByte = HttpRequest.UploadData(BaseUrl & Path, "post", RequestString)

            'PEGANDO O RETORNO EM STRING
            Dim Request As String = Encoding.Default.GetString(RequestByte)

            'DECODIFICANDO O RETORNO
            Dim Result As ErpLogin.Result = JsonConvert.DeserializeObject(Of ErpLogin.Result)(Request)

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
