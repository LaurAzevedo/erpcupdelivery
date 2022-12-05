Public Class txtautocomplete
    Dim qtd_casas_decimais As Integer
    Dim gridPosition As Integer = 0
    Dim codigo As String
    Dim ind_tab As String = "N"

    Public tmp_tamanho1 As String = "50"
    Public tmp_tamanho2 As String = "305"
    Public tmp_tamanho3 As String = "300"
    Public tmp_tamanho4 As String = "300"
    Public tmp_tamanho5 As String = "300"

#Disable Warning BC40004 ' O membro está em conflito com membros no tipo base e deve ser declarado como 'Shadows'

    Public Event TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

#Enable Warning BC40004 ' O membro está em conflito com membros no tipo base e deve ser declarado como 'Shadows'

    Public Event Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    Public Event Item_Selected(ByVal sender As System.Object, ByVal e As System.EventArgs)

    Public lsAuthors As List(Of String) = New List(Of String)

    Public Property listagem() As List(Of String)

        Get
            Return lsAuthors
        End Get
        Set(ByVal Value As List(Of String))
            lsAuthors = Value
        End Set
    End Property

    Public Overrides Property Text() As String

        Get
            Return TextBox1.Text
        End Get
        Set(ByVal Value As String)
            TextBox1.Text = Value

        End Set

    End Property

    Public Property Text_codigo() As String

        Get
            Return codigo
        End Get
        Set(ByVal Value As String)
            codigo = Value

        End Set

    End Property

    Private Sub ListView1_SelectedIndexChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub txtautocomplete_GotFocus(sender As Object, e As EventArgs) Handles Me.GotFocus
        TextBox1.Focus()

    End Sub

    Private Sub txtautocomplete_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        '   Me.OnKeyDown(e)
#Disable Warning BC42025 ' Acesso do membro compartilhado, membro constante, membro enumerado ou tipo aninhado por meio de uma instância
        If e.KeyCode = e.KeyCode.Escape Then
#Enable Warning BC42025 ' Acesso do membro compartilhado, membro constante, membro enumerado ou tipo aninhado por meio de uma instância
            TextBox1.Text = ""

        End If

#Disable Warning BC42025 ' Acesso do membro compartilhado, membro constante, membro enumerado ou tipo aninhado por meio de uma instância
        If e.KeyCode = e.KeyCode.Enter Then
#Enable Warning BC42025 ' Acesso do membro compartilhado, membro constante, membro enumerado ou tipo aninhado por meio de uma instância
            ind_tab = "S"
            e.SuppressKeyPress = True

            '    'Dim tmp As String = ""

            '    'Try
            '    '    tmp = DataGridView1.Rows(DataGridView1.CurrentCell.RowIndex).Cells(1).Value.ToString()
            '    'Catch ex As Exception
            '    '    '   Exit Sub
            '    'End Try
            '    'If tmp <> "" Then
            '    '    Button1.Focus()
            '    '    ' TextBox1.Text = UCase(DataGridView1.Rows(DataGridView1.CurrentCell.RowIndex).Cells(1).Value)
            '    '    DataGridView1.Visible = False
            '    '    Me.Size = New Size(380, 20)

            '    'End If
            '    'TextBox1.Select(0, 0)

            '    'Try
            '    '    codigo = ""
            '    'Catch ex As Exception

            '    'End Try

            '    'RaiseEvent Item_Selected(sender, e)

            '    'Try
            '    '    codigo = DataGridView1.Rows(DataGridView1.CurrentCell.RowIndex).Cells(0).Value.ToString()
            '    'Catch ex As Exception

            '    'End Try

            codigo = ""
            Try
                codigo = DataGridView1.Rows(DataGridView1.CurrentCell.RowIndex).Cells(0).Value.ToString()
            Catch ex As Exception

            End Try
            'If codigo <> "" Then
            '    RaiseEvent Item_Selected(sender, e)
            'End If

            If codigo = "" Then

                If TextBox1.Text = "" Then
                    TextBox1.Focus()

                    RaiseEvent Button_Click(sender, e)
                Else

                    SendKeys.Send("{TAB}")

                End If
            Else
                RaiseEvent Item_Selected(sender, e)
                Try

                    TextBox1.Text = DataGridView1.Rows(DataGridView1.CurrentCell.RowIndex).Cells(1).Value.ToString()
                Catch ex As Exception

                End Try
                'SendKeys.Send("{TAB}")
                'SendKeys.Send("{TAB}")
                'SendKeys.Send("{TAB}")
                'SendKeys.Send("{TAB}")
                'SendKeys.Send("{TAB}")
                'SendKeys.Send("{TAB}")
            End If

        End If
    End Sub

    Private Sub txtautocomplete_Leave(sender As Object, e As EventArgs) Handles Me.Leave
        DataGridView1.Visible = False
        Me.Size = New Size(380, 20)
        DataGridView1.Rows.Clear()
    End Sub

    Private Sub txtautocomplete_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Size = New Size(380, 20)
    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        Dim posicao As String
        posicao = DataGridView1.CurrentCellAddress.Y.ToString
    End Sub

    Public Sub muda_focu()
        Try
            DataGridView1.CurrentCell = DataGridView1.Item(0, gridPosition)
        Catch ex As Exception
            gridPosition = gridPosition - 1
            Try
                DataGridView1.CurrentCell = DataGridView1.Item(0, gridPosition)
            Catch ex2 As Exception
                'DataGridView1.CurrentCell = DataGridView1.Item("NUMBICODataGridViewTextBoxColumn", 0)
            End Try

        End Try
    End Sub

    Private Sub DataGridView1_DoubleClick(sender As Object, e As EventArgs) Handles DataGridView1.DoubleClick
        'Dim tmp As String = ""

        'Try
        '    tmp = DataGridView1.Rows(DataGridView1.CurrentCell.RowIndex).Cells(1).Value.ToString()
        'Catch ex As Exception

        'End Try
        'If tmp <> "" Then
        '    Button1.Focus()
        '    TextBox1.Text = UCase(DataGridView1.Rows(DataGridView1.CurrentCell.RowIndex).Cells(1).Value)
        '    DataGridView1.Visible = False
        '    Me.Size = New Size(380, 20)
        '    DataGridView1.Rows.Clear()
        '    TextBox1.Select(0, 0)
        '    Try
        '        codigo = DataGridView1.Rows(DataGridView1.CurrentCell.RowIndex).Cells(0).Value.ToString()
        '    Catch ex As Exception

        '    End Try

        '    RaiseEvent Item_Selected(sender, e)
        'End If
        codigo = ""
        Try
            codigo = DataGridView1.Rows(DataGridView1.CurrentCell.RowIndex).Cells(0).Value.ToString()
        Catch ex As Exception

        End Try
        If codigo <> "" Then

            RaiseEvent Item_Selected(sender, e)

            Me.Size = New Size(380, 20)
            DataGridView1.Visible = False
            DataGridView1.Rows.Clear()
        End If
    End Sub

    Private Sub TextBox1_GotFocus(sender As Object, e As EventArgs) Handles TextBox1.GotFocus

    End Sub

    Private Sub TextBox1_KeyDown(sender As Object, e As KeyEventArgs) Handles TextBox1.KeyDown
        Me.OnKeyDown(e)

        If e.Modifiers.ToString = "Control" AndAlso e.KeyCode = Keys.A Then
            TextBox1.SelectAll()

        End If

        'If e.KeyCode = e.KeyCode.Enter Then
        '    e.SuppressKeyPress = True

        '    Dim tmp As String = ""

        '    Try
        '        tmp = DataGridView1.Rows(DataGridView1.CurrentCell.RowIndex).Cells(1).Value.ToString()
        '    Catch ex As Exception

        '        ' Exit Sub
        '    End Try
        '    If tmp <> "" Then
        '        Button1.Focus()
        '        ' TextBox1.Text = UCase(DataGridView1.Rows(DataGridView1.CurrentCell.RowIndex).Cells(1).Value)
        '        DataGridView1.Visible = False
        '        Me.Size = New Size(275, 20)
        '    End If
        '    TextBox1.Select(0, 0)

        '    Try
        '        codigo = DataGridView1.Rows(DataGridView1.CurrentCell.RowIndex).Cells(0).Value.ToString()
        '    Catch ex As Exception

        '    End Try

        '    RaiseEvent Item_Selected(sender, e)

        'End If

        If e.KeyCode = Keys.Up Then
            e.SuppressKeyPress = True
            gridPosition = DataGridView1.CurrentCellAddress.Y.ToString
            If gridPosition > 0 Then
                gridPosition = Val(gridPosition) - 1
            End If
            muda_focu()
        End If

        If e.KeyCode = Keys.Down Then
            e.SuppressKeyPress = True
            gridPosition = DataGridView1.CurrentCellAddress.Y.ToString
            gridPosition = Val(gridPosition) + 1
            muda_focu()
        End If

        If e.KeyCode = Keys.End Then
            e.SuppressKeyPress = True
            gridPosition = DataGridView1.Rows.Count
            'gridPosition = DataGridView1.CurrentCellAddress.Y.ToString
            'gridPosition = Val(gridPosition) + 1
            muda_focu()
        End If

        If e.KeyCode = Keys.Home Then
            e.SuppressKeyPress = True
            gridPosition = 0
            ' gridPosition = Val(gridPosition) + 1
            muda_focu()
        End If
    End Sub

    Private Sub TextBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox1.KeyPress
        If Char.IsLower(e.KeyChar) Then
            'Converte o texto para caixa alta
            TextBox1.SelectedText = Char.ToUpper(e.KeyChar)
            e.Handled = True
        End If
    End Sub

    Dim tmp_form As New Form

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

        If TextBox1.Text = "" Then
            codigo = ""
            DataGridView1.Rows.Add()
            DataGridView1.Item(0, DataGridView1.RowCount - 1).Value = UCase("")
            DataGridView1.Item(1, DataGridView1.RowCount - 1).Value = UCase("0")
            DataGridView1.Item(2, DataGridView1.RowCount - 1).Value = UCase("0")
            DataGridView1.Item(3, DataGridView1.RowCount - 1).Value = UCase("0")
            DataGridView1.Item(4, DataGridView1.RowCount - 1).Value = UCase("0")

            Me.Size = New Size(380, 20)
            DataGridView1.Visible = False
            DataGridView1.Rows.Clear()
            Exit Sub

        End If

        codigo = ""
        '  TextBox1.Text = TextBox1.Text.Replace(vbCrLf, "")
        Try

            RaiseEvent TextChanged(sender, e)
        Catch ex As Exception
            Exit Sub
        End Try
        ' ListView1.Items.Clear()
        Me.Text = TextBox1.Text
        DataGridView1.Rows.Clear()
        Dim tmp_texto As String = UCase(TextBox1.Text)
        If tmp_texto = "" Then
            tmp_texto = "$$##"
        End If
        tmp_texto = tmp_texto.Replace(vbCrLf, "")
        For Each line In lsAuthors
            If UCase(line).Contains(tmp_texto) Then

                Dim sqltxt As String = UCase(line)
                Dim arrItem() As String
                Dim strMensagem As String = ""
                arrItem = Split(sqltxt, "@@@")
                Dim cont As Integer = "0"

                Dim cod As String = "0"
                Dim desc As String = ""
                Dim desc2 As String = ""
                Dim desc3 As String = ""
                Dim desc4 As String = ""

                Dim counter2 As Integer = 0
                For Each ei In arrItem
                    counter2 += 1
                    If counter2 = "1" Then
                        cod = ei.ToString()
                    End If

                    If counter2 = "2" Then
                        desc = ei.ToString()
                    End If

                    If counter2 = "3" Then
                        desc2 = ei.ToString()
                    End If

                    If counter2 = "4" Then
                        desc3 = ei.ToString()
                    End If

                    If counter2 = "5" Then
                        desc4 = ei.ToString()
                    End If

                Next

                If counter2 = 1 Then
                    DataGridView1.Columns(0).Width = tmp_tamanho1
                End If
                If counter2 = 2 Then
                    DataGridView1.Columns(0).Width = tmp_tamanho1
                    DataGridView1.Columns(1).Width = tmp_tamanho2
                End If
                If counter2 = 3 Then
                    DataGridView1.Columns(0).Width = tmp_tamanho1
                    DataGridView1.Columns(1).Width = tmp_tamanho2
                    DataGridView1.Columns(2).Width = tmp_tamanho3
                End If

                If counter2 = 4 Then
                    DataGridView1.Columns(0).Width = tmp_tamanho1
                    DataGridView1.Columns(1).Width = tmp_tamanho2
                    DataGridView1.Columns(2).Width = tmp_tamanho3
                    DataGridView1.Columns(3).Width = tmp_tamanho4
                End If

                If counter2 = 5 Then
                    DataGridView1.Columns(0).Width = tmp_tamanho1
                    DataGridView1.Columns(1).Width = tmp_tamanho2
                    DataGridView1.Columns(2).Width = tmp_tamanho3
                    DataGridView1.Columns(3).Width = tmp_tamanho4
                    DataGridView1.Columns(4).Width = tmp_tamanho5

                End If

                If counter2 = 1 Then
                    Me.DataGridView1.Columns(0).Visible = True
                    Me.DataGridView1.Columns(1).Visible = False
                    Me.DataGridView1.Columns(2).Visible = False
                    Me.DataGridView1.Columns(3).Visible = False
                    Me.DataGridView1.Columns(4).Visible = False

                End If

                If counter2 = 2 Then
                    Me.DataGridView1.Columns(0).Visible = True
                    Me.DataGridView1.Columns(1).Visible = True
                    Me.DataGridView1.Columns(2).Visible = False
                    Me.DataGridView1.Columns(3).Visible = False
                    Me.DataGridView1.Columns(4).Visible = False

                End If

                If counter2 = 3 Then
                    Me.DataGridView1.Columns(0).Visible = True
                    Me.DataGridView1.Columns(1).Visible = True
                    Me.DataGridView1.Columns(2).Visible = True
                    Me.DataGridView1.Columns(3).Visible = False
                    Me.DataGridView1.Columns(4).Visible = False

                End If

                If counter2 = 4 Then
                    Me.DataGridView1.Columns(0).Visible = True
                    Me.DataGridView1.Columns(1).Visible = True
                    Me.DataGridView1.Columns(2).Visible = True
                    Me.DataGridView1.Columns(3).Visible = True
                    Me.DataGridView1.Columns(4).Visible = False

                End If

                If counter2 = 5 Then
                    Me.DataGridView1.Columns(0).Visible = True
                    Me.DataGridView1.Columns(1).Visible = True
                    Me.DataGridView1.Columns(2).Visible = True
                    Me.DataGridView1.Columns(3).Visible = True
                    Me.DataGridView1.Columns(4).Visible = True

                End If

                If desc = "" Then
                    DataGridView1.Rows.Add()
                    DataGridView1.Item(0, DataGridView1.RowCount - 1).Value = UCase("")
                    DataGridView1.Item(1, DataGridView1.RowCount - 1).Value = UCase(cod.ToString)

                    If desc2 <> "" Then
                        DataGridView1.Item(2, DataGridView1.RowCount - 1).Value = UCase(desc2.ToString)
                    End If
                Else
                    DataGridView1.Rows.Add()
                    DataGridView1.Item(0, DataGridView1.RowCount - 1).Value = UCase(cod.ToString)
                    DataGridView1.Item(1, DataGridView1.RowCount - 1).Value = UCase(desc.ToString)
                    If desc2 <> "" Then
                        DataGridView1.Item(2, DataGridView1.RowCount - 1).Value = UCase(desc2.ToString)
                    End If
                    If desc3 <> "" Then
                        DataGridView1.Item(3, DataGridView1.RowCount - 1).Value = UCase(desc3.ToString)
                    End If
                    If desc4 <> "" Then
                        DataGridView1.Item(4, DataGridView1.RowCount - 1).Value = UCase(desc4.ToString)
                    End If
                End If

            End If
        Next

        'If DataGridView1.RowCount = 1 Then
        '    DataGridView1.Visible = True
        '    Me.Size = New Size(275, 47)
        '    DataGridView1.Size = New Size(275, 25)
        '    DataGridView1.Dock = DockStyle.Bottom
        '    Exit Sub
        'End If

        'If DataGridView1.RowCount = 2 Then
        '    DataGridView1.Visible = True
        '    Me.Size = New Size(275, 120)
        '    DataGridView1.Size = New Size(275, 60)
        '    DataGridView1.Dock = DockStyle.Bottom
        '    Exit Sub
        'End If

        'If DataGridView1.RowCount = 3 Then
        '    DataGridView1.Visible = True
        '    Me.Size = New Size(275, 140)
        '    DataGridView1.Size = New Size(275, 80)
        '    DataGridView1.Dock = DockStyle.Bottom
        '    Exit Sub
        'End If

        If DataGridView1.RowCount > 0 Then
            DataGridView1.Visible = True
            Me.Size = New Size(380, 182)
            DataGridView1.Size = New Size(380, 160)
            DataGridView1.Dock = DockStyle.Bottom
        Else
            Me.Size = New Size(380, 20)
            DataGridView1.Visible = False
            DataGridView1.Rows.Clear()
        End If

        If TextBox1.Focused = False Then
            DataGridView1.Visible = False
            Me.Size = New Size(380, 20)
            DataGridView1.Rows.Clear()
        End If

        If DataGridView1.Rows.Count = 1 Then

        End If
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        TextBox1.Focus()

        RaiseEvent Button_Click(sender, e)
    End Sub

    Private Sub Button1_GotFocus(sender As Object, e As EventArgs) Handles Button1.GotFocus
        '   TextBox1.Focus()
        ' If e.KeyCode = Keys.Tab Then
        '  SendKeys.Send("{TAB}")
        '  End If
    End Sub

    Private Sub Button1_LostFocus(sender As Object, e As EventArgs) Handles Button1.LostFocus

    End Sub

    Private Sub DataGridView1_GotFocus(sender As Object, e As EventArgs) Handles DataGridView1.GotFocus
        '    SendKeys.Send("{TAB}")
    End Sub

    Private Sub DataGridView1_Click(sender As Object, e As EventArgs) Handles DataGridView1.Click
        'Dim tmp As String = ""

        'Try
        '    tmp = DataGridView1.Rows(DataGridView1.CurrentCell.RowIndex).Cells(1).Value.ToString()
        'Catch ex As Exception

        'End Try
        'If tmp <> "" Then
        '    Button1.Focus()
        '    TextBox1.Text = UCase(DataGridView1.Rows(DataGridView1.CurrentCell.RowIndex).Cells(1).Value)
        '    DataGridView1.Visible = False
        '    Me.Size = New Size(380, 20)
        '    DataGridView1.Rows.Clear()

        '    TextBox1.Select(0, 0)
        '    Try
        '        codigo = DataGridView1.Rows(DataGridView1.CurrentCell.RowIndex).Cells(0).Value.ToString()
        '    Catch ex As Exception

        '    End Try

        '    RaiseEvent Item_Selected(sender, e)
        'End If
        codigo = ""
        Try
            codigo = DataGridView1.Rows(DataGridView1.CurrentCell.RowIndex).Cells(0).Value.ToString()
        Catch ex As Exception

        End Try
        If codigo <> "" Then

            RaiseEvent Item_Selected(sender, e)

            Me.Size = New Size(380, 20)
            DataGridView1.Visible = False
            DataGridView1.Rows.Clear()
            SendKeys.Send("{TAB}")
            SendKeys.Send("{TAB}")
            Try

                TextBox1.Text = DataGridView1.Rows(DataGridView1.CurrentCell.RowIndex).Cells(1).Value.ToString()
            Catch ex As Exception

            End Try
        End If

    End Sub

    Private Sub txtautocomplete_BackColorChanged(sender As Object, e As EventArgs) Handles Me.BackColorChanged
        TextBox1.BackColor = Me.BackColor

    End Sub

    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click

    End Sub

    Private Sub SimpleButton1_GotFocus(sender As Object, e As EventArgs) Handles SimpleButton1.GotFocus
        Try

            DataGridView1.Visible = False
            Me.Size = New Size(380, 20)
            DataGridView1.Rows.Clear()
            SendKeys.Send("{TAB}")
            '   SendKeys.Send("{TAB}")
        Catch ex As Exception

        End Try
    End Sub

    Private Sub SimpleButton2_Click(sender As Object, e As EventArgs) Handles SimpleButton2.Click
        TextBox1.Focus()

        RaiseEvent Button_Click(sender, e)
    End Sub

End Class