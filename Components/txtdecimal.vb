Public Class txtdecimal
    Dim qtd_casas_decimais As Integer
    Dim tamanho_txt As Integer = "0"
    Dim editavel_boolean As Boolean = True

#Disable Warning BC40004 ' O membro está em conflito com membros no tipo base e deve ser declarado como 'Shadows'

    Public Event TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

#Enable Warning BC40004 ' O membro está em conflito com membros no tipo base e deve ser declarado como 'Shadows'

#Disable Warning BC40004 ' O membro está em conflito com membros no tipo base e deve ser declarado como 'Shadows'

    Public Event Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

#Enable Warning BC40004 ' O membro está em conflito com membros no tipo base e deve ser declarado como 'Shadows'

#Disable Warning BC40004 ' O membro está em conflito com membros no tipo base e deve ser declarado como 'Shadows'

    Public Event GotFocus(ByVal sender As System.Object, ByVal e As System.EventArgs)

#Enable Warning BC40004 ' O membro está em conflito com membros no tipo base e deve ser declarado como 'Shadows'

    Public Event my_click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    Public Event texto_mudar()

    Public Overrides Property Text() As String

        Get
            Return TextBox1.Value
        End Get
        Set(ByVal Value As String)
            If Value = "" Then
                Value = "0,00"
            End If
            Try
                TextBox1.Value = Convert.ToDecimal(Value)
            Catch ex As Exception

            End Try
        End Set

    End Property

    Property casasdecimais As Integer
        Get
            Return qtd_casas_decimais
        End Get
        Set(ByVal Value As Integer)
            qtd_casas_decimais = Value
        End Set
    End Property

    Property tamanho As Integer
        Get
            Return tamanho_txt
        End Get
        Set(ByVal Value As Integer)
            tamanho_txt = Value
        End Set
    End Property

    Property editavel As Boolean
        Get
            Return editavel_boolean
        End Get
        Set(ByVal Value As Boolean)
            editavel_boolean = Value
        End Set
    End Property

    Private Sub txtdecimal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TextBox1.BackColor = Me.BackColor

        Me.Size = New Size(71, 22)

        If Me.Enabled = True Then
            TextBox1.ReadOnly = False
            TextBox1.BackColor = Me.BackColor
            TextBox1.ForeColor = Me.ForeColor
        Else
            TextBox1.ReadOnly = True
            TextBox1.BackColor = Color.DimGray
            TextBox1.ForeColor = Color.White
        End If

        Me.Enabled = True

        If Val(casasdecimais) > 3 Then
            Me.Size = New Size(82, 22)
        End If

        If Val(tamanho_txt) > 0 Then
            Me.Size = New Size(86, 22)
        End If

        Me.TextBox1.Properties.DisplayFormat.FormatString = "N" & casasdecimais
        Me.TextBox1.Properties.DisplayFormat.FormatType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        'Me.TextBox1.Properties.EditFormat.FormatString = "N" & casasdecimais
        'Me.TextBox1.Properties.EditFormat.FormatType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        'Me.TextBox1.Properties.Mask.EditMask = "N" & casasdecimais
        'Me.TextBox1.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric

        '   TextBox1.DecimalPlaces = qtd_casas_decimais
        If editavel_boolean = False Then
            TextBox1.ReadOnly = True

        End If
    End Sub

    Private Sub TextBox1_Click(sender As Object, e As EventArgs) Handles TextBox1.Click
        TextBox1.Select(0, TextBox1.Text.Length)
        RaiseEvent Click(sender, e)

    End Sub

    Public Event Item_Selected(ByVal sender As System.Object, ByVal e As System.EventArgs)

    Private Sub TextBox1_EditValueChanged(sender As Object, e As EventArgs) Handles TextBox1.EditValueChanged
        Dim tmp As String = TextBox1.Text
        tmp = TextBox1.Value

        RaiseEvent TextChanged(sender, e)
        RaiseEvent texto_mudar()
    End Sub

    Private Sub TextBox1_GotFocus(sender As Object, e As EventArgs) Handles TextBox1.GotFocus
        RaiseEvent GotFocus(sender, e)
    End Sub

    Private Sub txtdecimal_BackColorChanged(sender As Object, e As EventArgs) Handles Me.BackColorChanged
        TextBox1.BackColor = Me.BackColor
    End Sub

    Private Sub txtdecimal_EnabledChanged(sender As Object, e As EventArgs) Handles Me.EnabledChanged

    End Sub

End Class