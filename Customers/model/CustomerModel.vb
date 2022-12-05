Public Class CustomerModel
    Public Class CreateCustomer
        Public Property name As String
        Public Property password As String
        Public Property email As String
        Public Property telephone As String
        Public Property cpf As String
        Public Property zip_code As String
        Public Property public_place As String
        Public Property number As String
        Public Property complement As String
        Public Property city As String
        Public Property district As String
    End Class

    Public Class UpdateCustomer
        Public Property id As Integer
        Public Property name As String
        Public Property email As String
        Public Property telephone As String
        Public Property cpf As String
        Public Property zip_code As String
        Public Property public_place As String
        Public Property number As String
        Public Property complement As String
        Public Property city As String
        Public Property district As String
    End Class

    Public Class Customer
        Public Property id As Integer
        Public Property name As String
        Public Property email As String
        Public Property telephone As String
        Public Property cpf As String
        Public Property zip_code As String
        Public Property public_place As String
        Public Property number As String
        Public Property complement As String
        Public Property city As String
        Public Property district As String
    End Class

    Public Class Result
        Property message As String
    End Class


End Class
