Public Class MessageDetails
    Private Sub btnOk_Click(sender As Object, e As EventArgs) Handles btnOk.Click
        Me.Close()
    End Sub
    Private Sub mensagem_detalhe_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Enter Then
            Me.Close()
        End If

        If e.KeyCode = Keys.Escape Then
            Me.Close()
        End If
    End Sub
End Class