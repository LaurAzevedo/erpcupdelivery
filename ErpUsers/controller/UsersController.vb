Imports System.IO
Imports System.Security.Cryptography
Imports System.Net
Imports System.Text
Imports Newtonsoft.Json
Imports System.Net.Http

Module UsersController

    Public Function CreateUser(user As UserModel.CreateUser)

        Dim HttpRequest As New WebClient()
        Dim RequestByte As Byte()
        Dim RequestString() As Byte
        Dim Parameters As String = JsonConvert.SerializeObject(user)
        Dim Path As String = "/erpuser"

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
            Dim Result As UserModel.Users = JsonConvert.DeserializeObject(Of UserModel.Users)(Request)

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

    Public Function UpdateUser(user As UserModel.UpdateUser)

        Dim HttpRequest As New WebClient()
        Dim RequestByte As Byte()
        Dim RequestString() As Byte
        Dim Parameters As String = JsonConvert.SerializeObject(user)
        Dim Path As String = "/erpuser"

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

    Public Function DeleteUser(Id As Integer)

        Dim cmdDelete As New Npgsql.NpgsqlCommand("delete from erp_users where id = @v1", connection)

        With cmdDelete.Parameters

            .Add(NEW_PARAMETER("1", "I", Id))

        End With

        Try
            cmdDelete.ExecuteNonQuery()
        Catch ex As HttpRequestException
            Return False
            Exit Function
        End Try

        Return True

    End Function

End Module
