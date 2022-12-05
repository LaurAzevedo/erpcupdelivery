Public Class calendario

    Private Sub MonthCalendar1_DateSelected(sender As Object, e As DateRangeEventArgs) Handles MonthCalendar1.DateSelected
        tmp_data = MonthCalendar1.SelectionStart

        Me.Close()
    End Sub

    Private Sub MonthCalendar1_KeyDown(sender As Object, e As KeyEventArgs) Handles MonthCalendar1.KeyDown
        If e.KeyCode = Keys.Escape Then
            Me.Close()

        End If
    End Sub

    Private Sub calendario_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub calendario_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Escape Then
            Me.Close()
        End If
    End Sub

End Class