Public Class txtnumeric
    Dim qtd_valor As Integer

    Private Sub TextBox1_Click(sender As Object, e As EventArgs) Handles TextBox1.Click
        TextBox1.SelectAll()

    End Sub

    Private Sub TextBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox1.KeyPress
        If e.KeyChar = ","c Then
            e.Handled = (CType(sender, TextBox).Text.IndexOf(","c) <> -1)
        ElseIf e.KeyChar <> ControlChars.Back Then
            e.Handled = ("0123456789".IndexOf(e.KeyChar) = -1)
        End If
    End Sub

    Public Overrides Property Text() As String
        Get
            Return TextBox1.Text
        End Get
        Set(ByVal Value As String)
            TextBox1.Text = Value
        End Set
    End Property

    Private Sub TextBox1_LostFocus(sender As Object, e As EventArgs) Handles TextBox1.LostFocus

        If TextBox1.Text = "" Then
            TextBox1.Text = "0"
        Else

        End If

    End Sub

    Property valor As Integer
        Get
            Return qtd_valor
        End Get
        Set(ByVal Value As Integer)
            qtd_valor = Value
        End Set
    End Property

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub txtdecimal_Click(sender As Object, e As EventArgs) Handles Me.Click
        TextBox1.SelectAll()

    End Sub

    Private Sub txtdecimal_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        If qtd_valor = "0" Then
            qtd_valor = "100"
        End If

        TextBox1.Text = qtd_valor
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs)
        If TextBox1.Text = "" Then
            TextBox1.Text = "0"
        End If

        TextBox1.Text = Convert.ToDecimal(TextBox1.Text) + 1

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        If TextBox1.Text = "" Then
            TextBox1.Text = "0"
        End If
        TextBox1.Text = Convert.ToDecimal(TextBox1.Text) - 1
        If Convert.ToDecimal(TextBox1.Text) < 0 Then
            TextBox1.Text = 0
        End If
    End Sub

End Class