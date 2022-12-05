Imports System.IO
Imports System.Security.Cryptography
Imports System.Net
Imports System.Text
Imports Newtonsoft.Json
Imports System.Net.Http

Module SalesController

    Public Function UpdateSales(Id As Integer, Status As String)

        Dim Sales As New SalesModel.UpdateSales
        Sales.id = Id
        Sales.status = Status

        Dim HttpRequest As New WebClient()
        Dim RequestByte As Byte()
        Dim RequestString() As Byte
        Dim Parameters As String = JsonConvert.SerializeObject(Sales)
        Dim Path As String = "/sales"

        Try

            'DEFINIÇÃO DO TIPO DE REQUISIÇÃO QUE SERÁ FEITA
            HttpRequest.Headers("content-type") = "application/json"
            HttpRequest.Headers("Authorization") = "Bearer " & AccessToken

            'CONVERTENDO O BODY PARA BYTES
            RequestString = Encoding.Default.GetBytes(Parameters)

            'FAZENDO A REQUISIÇÃO
            RequestByte = HttpRequest.UploadData(BaseUrl & Path, "put", RequestString)

            'PEGANDO O RETORNO EM STRING
            Dim Request As String = Encoding.Default.GetString(RequestByte)

            'DECODIFICANDO O RETORNO
            Dim Result As UserModel.User = JsonConvert.DeserializeObject(Of UserModel.User)(Request)

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
