Public Class txtdata
    Public data As String

    Public Overrides Property Text() As String
        Get
            Return DateEdit1.EditValue
        End Get
        Set(ByVal Value As String)
            If Value = "" Then

                DateEdit1.EditValue = Value
                DateEdit1.Text = Value
                '  DateEdit1.Focus()
            Else
                'DateEdit1.EditValue = CDate(Value)
                'DateEdit1.Text = CDate(Value)
                '' DateEdit1.Focus()
                Dim TMP As String = Format(CDate(Value), "dd/MM/yyyy")
                tmp_data = TMP.Substring(0, 2) & "/" & TMP.Substring(3, 2) & "/" & TMP.Substring(6, 4)
                DateEdit1.EditValue = CDate(tmp_data)
                ' DateEdit1.Focus()
            End If

        End Set
    End Property

    Private Sub MaskedTextBox1_MaskInputRejected(sender As Object, e As MaskInputRejectedEventArgs)

    End Sub

    Private Sub DateEdit1_KeyDown(sender As Object, e As KeyEventArgs) Handles DateEdit1.KeyDown

        If e.KeyCode = Keys.F12 Then
            Dim tmp As New calendario
            tmp.ShowDialog()
            Try

                DateEdit1.EditValue = Format(CDate(tmp_data), "dd/MM/yyyy")
            Catch ex As Exception

            End Try
        End If

        If e.KeyCode = Keys.F11 Then
            Dim TMP As String = Format(CDate(Date.Today), "dd/MM/yyyy")
            tmp_data = TMP.Substring(0, 2) & "/" & TMP.Substring(3, 2) & "/" & TMP.Substring(6, 4)
            DateEdit1.EditValue = CDate(tmp_data)
            DateEdit1.Focus()
        End If

        If e.KeyCode = Keys.F10 Then
            Dim TMP As String = Format(CDate(Date.Today), "dd/MM/yyyy")
            tmp_data = "01/" & TMP.Substring(3, 2) & "/" & TMP.Substring(6, 4)
            DateEdit1.EditValue = CDate(tmp_data)
            DateEdit1.Focus()
        End If

        If e.KeyCode = Keys.Back Then

            DateEdit1.EditValue = ""

            '   DateEdit1.Focus()

        End If

        'If e.KeyCode = Keys.F1 Then

        '    DateEdit1.EditValue = ""

        '    '   DateEdit1.Focus()

        'End If

        'If e.KeyCode = Keys.F2 Then

        'End If

    End Sub

    Private Sub DateEdit1_EditValueChanged(sender As Object, e As EventArgs) Handles DateEdit1.EditValueChanged
        DateEdit1.BackColor = Color.White
        If DateEdit1.Text = "01/01/0001" Then
            DateEdit1.Text = ""
        Else
            'If DateEdit1.EditValue = "" Then
            '    tmp_data = Date.Today
            '    DateEdit1.EditValue = Format(CDate(tmp_data), "dd/MM/yyyy")
            'End If

        End If
    End Sub

    Private Sub txtdata_BackColorChanged(sender As Object, e As EventArgs) Handles Me.BackColorChanged
        DateEdit1.BackColor = Me.BackColor
        Me.Refresh()

    End Sub

    Private Sub data_validation_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Size = New Size(82, 22)
    End Sub

    Private Sub DateEdit1_TextChanged(sender As Object, e As EventArgs) Handles DateEdit1.TextChanged
        DateEdit1.BackColor = Color.White
    End Sub

End Class