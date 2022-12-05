Public Class UserModel
    Public Class CreateUser
        Public Property name As String
        Public Property password As String
        Public Property email As String
        Public Property telephone As String
    End Class

    Public Class UpdateUser
        Public Property id As Integer
        Public Property name As String
        Public Property email As String
        Public Property telephone As String
    End Class

    Public Class Users
        Public Property Propertys() As User
    End Class

    Public Class User
        Public Property id As Integer
        Public Property name As String
        Public Property email As String
        Public Property telephone As String
        Public Property created_at As String
        Public Property updated_at As String
    End Class

    Public Class Result
        Property message As String
    End Class


End Class
