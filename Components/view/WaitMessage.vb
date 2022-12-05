Public Class WaitMessage

    Private Sub Timer1_Tick(sender As System.Object, e As System.EventArgs) Handles Timer1.Tick
        Timer1.Stop()
        Me.Close()
    End Sub

    Private Sub msg_aguarde_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer2.Start()
    End Sub

    Private Sub Label1_TextChanged1(sender As Object, e As EventArgs) Handles Label1.TextChanged
        ProgressPanel1.Description = Label1.Text
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        Me.BringToFront()

        If aborta_msg_aguarde = True Then
            Try
                Me.Close()
            Catch ex As Exception

            End Try
        End If
    End Sub

End Class