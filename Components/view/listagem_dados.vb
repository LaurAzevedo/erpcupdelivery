Public Class listagem_Dados

    Public resultado_listagem As String
    Public resultado_listagem2 As String
    Public script1 As String
    Public script2 As String
    Public IND_LIMPA_TEXTBOX1 As String = "N"
    Public ind_Selecao As String = "N"
    Public ind_calcula_total As String = "N"
    Public coluna As Integer
    Public ind_carregado As String = "N"
    Dim gridPosition As Integer = 0
    Public ind_selecao_string As String = "N"
    Public lista_selecionados As String
    Public ind_relatorio As String = "N"

    Public Sub MUDA_FOCU()
        Try
            dgvListaDados.CurrentCell = dgvListaDados.Item(0, gridPosition)
        Catch ex As Exception
            gridPosition = gridPosition - 1
            Try
                dgvListaDados.CurrentCell = dgvListaDados.Item(0, gridPosition)
            Catch ex2 As Exception
            End Try

        End Try
    End Sub

    Private Sub listagem_Dados_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown

        If e.KeyCode = Keys.Escape Then
            Me.Close()
        End If

        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True

            gridPosition = dgvListaDados.CurrentCellAddress.Y.ToString

            If ind_Selecao = "S" Then
                seleciona()
            Else

                ESCOLHE_ITEM()

            End If
        End If

        If e.KeyCode = Keys.Up Then
            e.SuppressKeyPress = True
            gridPosition = dgvListaDados.CurrentCellAddress.Y.ToString
            If gridPosition > 0 Then
                gridPosition = Val(gridPosition) - 1
            End If
            MUDA_FOCU()
        End If

        If e.KeyCode = Keys.Down Then
            e.SuppressKeyPress = True
            gridPosition = dgvListaDados.CurrentCellAddress.Y.ToString
            gridPosition = Val(gridPosition) + 1
            MUDA_FOCU()
        End If

        If e.KeyCode = Keys.End Then
            e.SuppressKeyPress = True
            gridPosition = dgvListaDados.Rows.Count
            MUDA_FOCU()
        End If

        If e.KeyCode = Keys.Home Then
            e.SuppressKeyPress = True
            gridPosition = 0
            MUDA_FOCU()
        End If
        VERIFICA_COR_GRID()

    End Sub

    Public Sub CALCULA_TOTAL()
        textbox6.Text = "0,00"
        For Each row As DataGridViewRow In Me.dgvListaDados.Rows
            If row.Cells(0).Value = True Then

                textbox6.Text = Convert.ToDecimal(textbox6.Text) + Convert.ToDecimal(row.Cells(coluna).Value)
                textbox6.Text = Format(Convert.ToDecimal(textbox6.Text), "#,##0.00")
            End If
        Next

    End Sub

    Private Sub me_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        txtFiltroPrincipal.Text = ""

        If ind_Selecao = "S" Then
        Else
            bt_selecionar.Visible = False
            bt_marca_todos_1.Visible = False
            bt_desmarca_todos_1.Visible = False

        End If

        If ind_calcula_total = "S" Then
            textbox6.Visible = True
            Label9.Visible = True
        End If

        Dim sqlCmd As New Npgsql.NpgsqlCommand

        Dim arrItem() As String
        arrItem = Split(lista_selecionados, ",")

        For Each ei In arrItem

            Dim item As String = ""
            item = ei.ToString

            If item <> "" Then
                Try
                    dg_lista.Rows.Add(item)
                Catch ex As Exception

                End Try
            End If

        Next

        FILTRA()

        If ind_Selecao = "S" Then

            Me.Size = New Size(647, 700)
            dgvListaDados.Focus()

        End If

        ind_carregado = "S"

        Timer1.Start()

        If ind_relatorio = "S" Then
            dgvListaDados.Dock = DockStyle.Fill
            txtFiltroPrincipal.Visible = False
            txtFiltro.Visible = False

        End If

    End Sub

    Public Sub FILTRA()
        Dim campo As String = ""

        txtFiltroPrincipal.Text = UCase(txtFiltroPrincipal.Text)

        With dgvListaDados
            Try
                If .Columns(0).HeaderText = cmbCampo.Text Then
                    campo = .Columns(0).DataPropertyName
                End If
            Catch ex As Exception
            End Try

            Try
                If .Columns(1).HeaderText = cmbCampo.Text Then
                    campo = .Columns(1).DataPropertyName
                End If
            Catch ex As Exception
            End Try

            Try
                If .Columns(2).HeaderText = cmbCampo.Text Then
                    campo = .Columns(2).DataPropertyName
                End If
            Catch ex As Exception
            End Try

            Try
                If .Columns(3).HeaderText = cmbCampo.Text Then
                    campo = .Columns(3).DataPropertyName
                End If
            Catch ex As Exception
            End Try

        End With
        Dim script_completo As String

        If script1.Contains("where") Or UCase(script1).Contains("WHERE") Then

            script_completo = script1 & " and UPPER(" & campo & ") like '%" & UCase(txtFiltroPrincipal.Text) & "%'" & " ORDER BY " & campo
        Else

            script_completo = script1 & " where UPPER(" & campo & ") like '%" & UCase(txtFiltroPrincipal.Text) & "%'" & " ORDER BY " & campo

        End If

        script_completo = script_completo & " LIMIT 100"

        Dim cmd As New Npgsql.NpgsqlCommand(script_completo, connection)
        With cmd.Parameters
            .Add(NEW_PARAMETER("1", "S", txtFiltroPrincipal.Text))
        End With

        Dim adapter As New Npgsql.NpgsqlDataAdapter
        adapter.SelectCommand = cmd
        Dim tabela As New DataTable()
        Try
            adapter.Fill(tabela)
        Catch ex As Exception
            Exit Sub

        End Try
        dgvListaDados.DataSource = tabela
        If IND_LIMPA_TEXTBOX1 = "S" Then
            txtFiltroPrincipal.Text = ""
            IND_LIMPA_TEXTBOX1 = "N"
        End If
        If dgvListaDados.RowCount = 1 Then
            ESCOLHE_ITEM()
        End If

        VERIFICA_COR_GRID()

        If ind_Selecao = "S" Then

            For Each row As DataGridViewRow In Me.dg_lista.Rows

                For i As Integer = 0 To dgvListaDados.Rows.Count - 1

                    If dgvListaDados.Rows(i).Cells(1).Value = row.Cells(0).Value Then

                        dgvListaDados.Rows(i).Cells(0).Value = True

                        Exit For
                    End If

                Next

                VERIFICA_COR_GRID()

            Next

            Me.Size = New Size(647, 700)

        End If
    End Sub

    Public Sub FILTRA2()
        Dim campo As String = ""

        txtFiltroPrincipal.Text = UCase(txtFiltroPrincipal.Text)

        With dgvListaDados
            Try
                If .Columns(0).HeaderText = cmbCampo.Text Then
                    If cmbCampo.Text.Contains("A. ") Then
                        campo = .Columns(0).DataPropertyName
                        campo = "A." & campo
                    ElseIf cmbCampo.Text.Contains("B. ") Then
                        campo = .Columns(0).DataPropertyName
                        campo = "B." & campo
                    Else

                        campo = .Columns(0).DataPropertyName
                    End If

                End If
            Catch ex As Exception
                Dim tmp As String
                tmp = tmp
            End Try

            Try
                If .Columns(1).HeaderText = cmbCampo.Text Then
                    campo = .Columns(1).DataPropertyName
                End If
            Catch ex As Exception
            End Try

            Try
                If .Columns(2).HeaderText = cmbCampo.Text Then
                    campo = .Columns(2).DataPropertyName
                End If
            Catch ex As Exception
            End Try

            Try
                If .Columns(3).HeaderText = cmbCampo.Text Then
                    campo = .Columns(3).DataPropertyName
                End If
            Catch ex As Exception
            End Try

        End With


        Dim script_completo As String

        If script1.Contains("where") Or UCase(script1).Contains("WHERE") Then

            script_completo = script1 & " and UPPER(" & campo & "::varchar) like '%" & UCase(txtFiltroPrincipal.Text) & "%'" & " ORDER BY " & campo
        Else

            script_completo = script1 & " where UPPER(" & campo & "::varchar) like '%" & UCase(txtFiltroPrincipal.Text) & "%'" & " ORDER BY " & campo

        End If

        script_completo = script_completo & " LIMIT 200"

        Dim cmd As New Npgsql.NpgsqlCommand(script_completo, connection)
        With cmd.Parameters
            .Add(NEW_PARAMETER("1", "S", txtFiltroPrincipal.Text))
        End With

        Dim adapter As New Npgsql.NpgsqlDataAdapter
        adapter.SelectCommand = cmd
        Dim tabela As New DataTable()
        Try
            adapter.Fill(tabela)
        Catch ex As Exception
            script_completo = script_completo.Replace("%", "")
            script_completo = script_completo.Replace("like", "=")
            Dim cmd2 As New Npgsql.NpgsqlCommand(script_completo, connection)
            adapter.SelectCommand = cmd2
            Try
                adapter.Fill(tabela)
            Catch ex2 As Exception
                Exit Sub
            End Try

        End Try
        'If tabela.Columns.Count > 0 Then
        dgvListaDados.DataSource = tabela
        'End If

        If IND_LIMPA_TEXTBOX1 = "S" Then
            txtFiltroPrincipal.Text = ""
            IND_LIMPA_TEXTBOX1 = "N"
        End If
        If dgvListaDados.RowCount = 1 Then
        End If

        VERIFICA_COR_GRID()

        If ind_Selecao = "S" Then

            For Each row As DataGridViewRow In Me.dg_lista.Rows

                For i As Integer = 0 To dgvListaDados.Rows.Count - 1

                    If dgvListaDados.Rows(i).Cells(1).Value = row.Cells(0).Value Then

                        dgvListaDados.Rows(i).Cells(0).Value = True

                        Exit For
                    End If

                Next

                VERIFICA_COR_GRID()

            Next

            Me.Size = New Size(647, 700)

        End If
    End Sub

    Private Sub dgvListaDados_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvListaDados.CellClick
        If ind_Selecao = "S" Then

            If ind_Selecao = "S" Then
                Dim posicao As String
                posicao = dgvListaDados.CurrentCellAddress.Y.ToString
                Dim counter As Integer = 0

                For Each row As DataGridViewRow In Me.dgvListaDados.Rows

                    If counter = posicao Then
                        If row.Cells(0).Value = False Then

                            row.Cells(0).Value = True
                        Else
                            row.Cells(0).Value = False
                        End If
                    End If
                    counter += 1
                Next
            End If

            If ind_calcula_total = "S" Then
                CALCULA_TOTAL()
            End If

            VERIFICA_COR_GRID()

            check_uncheck_itens()

        End If

    End Sub

    Private Sub dgvListaDados_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgvListaDados.DoubleClick

        If ind_Selecao = "S" Then
        Else
            ESCOLHE_ITEM()
        End If

    End Sub

    Private Sub ESCOLHE_ITEM()
        Try

            resultado_listagem = dgvListaDados.Rows(dgvListaDados.CurrentCell.RowIndex).Cells(0).Value
            resultado_listagem2 = dgvListaDados.Rows(dgvListaDados.CurrentCell.RowIndex).Cells(1).Value
        Catch ex As Exception

        End Try

        Me.Close()

    End Sub

    Private Sub dgvListaDados_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles dgvListaDados.KeyDown
        If e.KeyCode = Keys.Enter Then
            ESCOLHE_ITEM()

        End If
    End Sub

    Private Sub txtFiltroPrincipal_KeyDown(sender As Object, e As KeyEventArgs) Handles txtFiltroPrincipal.KeyDown
        If ind_carregado = "S" Then
            FILTRA()

        End If
    End Sub

    Private Sub txtFiltroPrincipal_TextChanged(sender As Object, e As EventArgs) Handles txtFiltroPrincipal.TextChanged
        If ind_carregado = "S" Then
            FILTRA2()
        End If
    End Sub

    Private Sub txtFiltro_TextChanged(sender As Object, e As EventArgs) Handles txtFiltro.TextChanged
        txtFiltroPrincipal.Text = txtFiltro.Text
    End Sub

    Public Sub VERIFICA_COR_GRID()
        If ind_Selecao = "S" Then

            For i As Integer = 0 To dgvListaDados.Rows.Count - 1

                If dgvListaDados.Rows(i).Cells(0).Value = True Then

                    dgvListaDados.Rows(i).DefaultCellStyle.BackColor = Color.Maroon
                    dgvListaDados.Rows(i).DefaultCellStyle.ForeColor = Color.White
                Else
                    dgvListaDados.Rows(i).DefaultCellStyle.BackColor = Color.White
                    dgvListaDados.Rows(i).DefaultCellStyle.ForeColor = Color.Black
                End If

            Next

        End If
    End Sub

    Private Sub btnLocalizar_Click(sender As Object, e As EventArgs) Handles btnLocalizar.Click
        FILTRA2()
    End Sub

    Private Sub bt_selecionar_Click(sender As Object, e As EventArgs) Handles bt_selecionar.Click

        seleciona()

        Me.Close()

    End Sub

    Public Sub seleciona()
        txtFiltroPrincipal.Text = ""

        resultado_listagem = ""

        For i As Integer = 0 To dg_lista.Rows.Count - 1

            If i = 0 Then
                If ind_selecao_string = "S" Then
                    resultado_listagem = "'" & dg_lista.Rows(i).Cells(0).Value & "'"
                Else
                    resultado_listagem = dg_lista.Rows(i).Cells(0).Value
                End If
            Else
                If ind_selecao_string = "S" Then
                    resultado_listagem = resultado_listagem & "', " & "'" & dg_lista.Rows(i).Cells(0).Value & "'"
                Else
                    resultado_listagem = resultado_listagem & ", " & dg_lista.Rows(i).Cells(0).Value
                End If
            End If

        Next

    End Sub

    Public Sub check_uncheck_itens()

        Dim selecionado As Boolean = dgvListaDados.Rows(dgvListaDados.CurrentCell.RowIndex).Cells(0).Value

        Dim item As String = dgvListaDados.Rows(dgvListaDados.CurrentCell.RowIndex).Cells(1).Value

        If selecionado = True Then
            If ind_selecao_string = "S" Then
                For j = dg_lista.RowCount - 1 To 0 Step -1
                    If dg_lista(0, j).Value = item Then
                        dg_lista.Rows.RemoveAt(j)
                    End If
                Next
                dg_lista.Rows.Add()
                dg_lista.Item(0, dg_lista.RowCount - 1).Value = "'" & item & "'"
            Else
                For j = dg_lista.RowCount - 1 To 0 Step -1
                    If dg_lista(0, j).Value = item Then
                        dg_lista.Rows.RemoveAt(j)
                    End If
                Next
                dg_lista.Rows.Add()
                dg_lista.Item(0, dg_lista.RowCount - 1).Value = item
            End If
        Else

            For j = dg_lista.RowCount - 1 To 0 Step -1
                If dg_lista(0, j).Value = item Then
                    dg_lista.Rows.RemoveAt(j)
                End If
            Next

        End If

    End Sub

    Private Sub bt_marca_todos_1_Click(sender As Object, e As EventArgs) Handles bt_marca_todos_1.Click
        For Each row As DataGridViewRow In Me.dgvListaDados.Rows
            row.Cells(0).Value = True

            Dim selecionado As Boolean = row.Cells(0).Value

            Dim item As String = row.Cells(1).Value

            If selecionado = True Then
                If ind_selecao_string = "S" Then
                    For j = dg_lista.RowCount - 1 To 0 Step -1
                        If dg_lista(0, j).Value = item Then
                            dg_lista.Rows.RemoveAt(j)
                        End If
                    Next
                    dg_lista.Rows.Add()
                    dg_lista.Item(0, dg_lista.RowCount - 1).Value = "'" & item & "'"
                Else
                    For j = dg_lista.RowCount - 1 To 0 Step -1
                        If dg_lista(0, j).Value = item Then
                            dg_lista.Rows.RemoveAt(j)
                        End If
                    Next
                    dg_lista.Rows.Add()
                    dg_lista.Item(0, dg_lista.RowCount - 1).Value = item
                End If
            Else

                For j = dg_lista.RowCount - 1 To 0 Step -1
                    If dg_lista(0, j).Value = item Then
                        dg_lista.Rows.RemoveAt(j)
                    End If
                Next

            End If

        Next

        If ind_calcula_total = "S" Then
            CALCULA_TOTAL()

        End If
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvListaDados.CellContentClick

    End Sub

    Private Sub bt_desmarca_todos_1_Click(sender As Object, e As EventArgs) Handles bt_desmarca_todos_1.Click
        For Each row As DataGridViewRow In Me.dgvListaDados.Rows
            row.Cells(0).Value = False

            Dim selecionado As Boolean = row.Cells(0).Value

            Dim item As String = row.Cells(1).Value

            If selecionado = True Then
                If ind_selecao_string = "S" Then
                    For j = dg_lista.RowCount - 1 To 0 Step -1
                        If dg_lista(0, j).Value = item Then
                            dg_lista.Rows.RemoveAt(j)
                        End If
                    Next
                    dg_lista.Rows.Add()
                    dg_lista.Item(0, dg_lista.RowCount - 1).Value = "'" & item & "'"
                Else
                    For j = dg_lista.RowCount - 1 To 0 Step -1
                        If dg_lista(0, j).Value = item Then
                            dg_lista.Rows.RemoveAt(j)
                        End If
                    Next
                    dg_lista.Rows.Add()
                    dg_lista.Item(0, dg_lista.RowCount - 1).Value = item
                End If
            Else

                For j = dg_lista.RowCount - 1 To 0 Step -1
                    If dg_lista(0, j).Value = item Then
                        dg_lista.Rows.RemoveAt(j)
                    End If
                Next

            End If
        Next
    End Sub

    Private Sub DataGridView1_Click(sender As Object, e As EventArgs) Handles dgvListaDados.Click

    End Sub

    Private Sub Timer1_Tick_1(sender As Object, e As EventArgs) Handles Timer1.Tick
        txtFiltro.Focus()
        Timer1.Stop()
    End Sub

    Private Sub dg_lista_KeyDown(sender As Object, e As KeyEventArgs) Handles dg_lista.KeyDown
        If e.KeyCode = Keys.Space Then
            If ind_Selecao = "S" Then
                e.SuppressKeyPress = True

                If ind_Selecao = "S" Then
                    Dim posicao As String
                    posicao = dgvListaDados.CurrentCellAddress.Y.ToString
                    Dim counter As Integer = 0

                    For Each row As DataGridViewRow In Me.dgvListaDados.Rows

                        If counter = posicao Then
                            If row.Cells(0).Value = False Then

                                row.Cells(0).Value = True
                            Else
                                row.Cells(0).Value = False
                            End If
                        End If
                        counter += 1
                    Next
                End If

                If ind_calcula_total = "S" Then
                    CALCULA_TOTAL()
                End If

                VERIFICA_COR_GRID()

                check_uncheck_itens()

            End If

        End If
    End Sub
End Class