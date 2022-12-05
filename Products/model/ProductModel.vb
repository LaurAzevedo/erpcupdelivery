Public Class ProductModel

    Public Class CreateProduct
        Public Property title As String
        Public Property description As String
        Public Property price As Double
        Public Property unit As String
        Public Property picture As String

    End Class

    Public Class UpdateProduct
        Public Property id As Integer
        Public Property title As String
        Public Property description As String
        Public Property price As Double
        Public Property unit As String
        Public Property picture As String

    End Class

    Public Class Products
        Public Property Propertys() As Product
    End Class

    Public Class Product
        Public Property id As Integer
        Public Property title As String
        Public Property description As String
        Public Property price As Double
        Public Property unit As String
        Public Property picture As String
    End Class

    Public Class Result
        Property message As String
    End Class


End Class
