Public Class data_final

    Private Sub data_final_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        data_final_pesquisa = dta_final.Text
    End Sub

    Private Sub data_final_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Enter Then
            Me.Close()
        End If
    End Sub

    Private Sub data_final_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()

    End Sub

End Class