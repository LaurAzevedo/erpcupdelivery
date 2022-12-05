Imports DevExpress.XtraGrid.Views.Base
Public Class Products

    Dim recordPosition As String
    Dim indList As String = "N"
    Dim amountOfRecords As Integer
    Public firstLine As Integer = 0
    Dim gridPosition As Integer = 0
    Dim sequence As String
    Private Sub gvListar_FocusedRowChanged(ByVal sender As System.Object, ByVal e As FocusedRowChangedEventArgs) Handles gvListar.FocusedRowChanged

        Dim counter As Integer = gvListar.FocusedRowHandle + 1

        If counter < 0 Then
            counter = 0
        End If

        lblRegistros.Caption = counter & " de " & gvListar.RowCount & ""

    End Sub

    Public Sub RESET_BALLOON()
        ALERTA.Active = False
        txtId.BackColor = Color.DarkGray
        txtTitle.BackColor = Color.DarkGray
        txtDescription.BackColor = Color.DarkGray
        txtPrice.BackColor = Color.DarkGray
        cmbUnit.BackColor = Color.DarkGray
        txtPicture.BackColor = Color.DarkGray
    End Sub

    Private Sub RELATORIOS()

    End Sub

    Private Sub txtId_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtId.KeyPress

        If e.KeyChar = ","c Then
            e.Handled = (CType(sender, TextBox).Text.IndexOf(","c) <> -1)
        ElseIf e.KeyChar <> ControlChars.Back Then
            e.Handled = ("0123456789".IndexOf(e.KeyChar) = -1)
        End If

    End Sub

    Private Sub cadastro_operador_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown

        If e.KeyCode = Keys.F7 Then

            RELATORIOS()

        End If

        If (e.KeyCode = Keys.NumPad1 AndAlso e.Modifiers = Keys.Alt) Then
            bvcPrincipal.Selected = True
        End If

        If (e.KeyCode = Keys.D1 AndAlso e.Modifiers = Keys.Alt) Then
            bvcPrincipal.Selected = True
        End If

        RESET_BALLOON()

        If e.KeyCode = Keys.PageDown Then

            If tabControlPrincipal.SelectedTabPageIndex = 1 Then
                e.SuppressKeyPress = True
            End If

            OPEN_MOUSE()
            gvListar.MoveNext()
            FILL_IN_FIELDS()
            CLOSE_MOUSE()

        End If

        If e.KeyCode = Keys.PageUp Then

            If tabControlPrincipal.SelectedTabPageIndex = 1 Then
                e.SuppressKeyPress = True
            End If

            OPEN_MOUSE()
            gvListar.MovePrev()
            FILL_IN_FIELDS()
            CLOSE_MOUSE()

        End If

        If e.KeyCode = Keys.End Then
            If tabControlPrincipal.SelectedTabPageIndex = 1 Then
                e.SuppressKeyPress = True
            End If

            OPEN_MOUSE()
            gvListar.MoveLast()
            FILL_IN_FIELDS()
            CLOSE_MOUSE()

        End If

        If e.KeyCode = Keys.Home Then
            If tabControlPrincipal.SelectedTabPageIndex = 1 Then
                e.SuppressKeyPress = True
            End If

            OPEN_MOUSE()
            gvListar.MoveFirst()
            FILL_IN_FIELDS()
            CLOSE_MOUSE()

        End If

        If e.KeyCode = Keys.Enter Then

            If txtId.Text <> "" Then

                If tabControlPrincipal.SelectedTabPageIndex = 0 Then

                    If txtId.Enabled = True Then

                        OPEN_MOUSE()
                        SEARCH_RECORDS()
                        CLOSE_MOUSE()
                        e.SuppressKeyPress = True

                    Else
                        SendKeys.Send("{TAB}")
                    End If

                End If

            Else
                SendKeys.Send("{TAB}")
            End If

        End If

        If e.KeyCode = Keys.F12 Then
            Me.Close()
        End If

        If e.KeyCode = Keys.F1 Then

            OPEN_MOUSE()

            INCLUDE()

            CLOSE_MOUSE()

        End If

        If e.KeyCode = Keys.F2 Then

            OPEN_MOUSE()

            SAVE()

            CLOSE_MOUSE()

        End If

        If e.KeyCode = Keys.F3 Then

            OPEN_MOUSE()

            DELETE()

            CLOSE_MOUSE()

        End If

        If e.KeyCode = Keys.F4 Then

            If btnPesquisar.Enabled = True Then

                OPEN_MOUSE()

                SEARCH_RECORDS()

                CLOSE_MOUSE()

            End If

        End If

        If e.KeyCode = Keys.F5 Then

            OPEN_MOUSE()

            CLEAR_SCREEN()

            CLOSE_MOUSE()

        End If

        If e.KeyCode = Keys.Escape Then

            If tabControlPrincipal.SelectedTabPageIndex = (1) Then
                CLEAR_SCREEN()
                Exit Sub
            End If

            If tabControlPrincipal.SelectedTabPageIndex = (0) Then

                If txtId.Text <> "" Then
                    CLEAR_SCREEN()
                    Exit Sub
                End If

            End If

            If txtId.Enabled = True Then

                OPEN_MOUSE()

                Me.Close()

                CLOSE_MOUSE()

            Else

                OPEN_MOUSE()

                CLEAR_SCREEN()

                CLOSE_MOUSE()

            End If

        End If

        If e.KeyCode = Keys.F6 Then

            LIST()

        End If

    End Sub

    Private Sub CLEAR_SCREEN()

        RESET_BALLOON()

        txtId.Focus()
        txtId.Text = ""
        txtTitle.Text = ""
        txtDescription.Text = ""
        txtPrice.Text = ""
        cmbUnit.Text = ""
        txtPicture.Text = ""
        txtId.Enabled = True

        picture.Image = Nothing

        Try
            Dim dt As DataTable
            dt = dgvListar.DataSource
            dt.Rows.Clear()
        Catch ex As Exception
        End Try

        tabControlPrincipal.SelectedTabPageIndex = (0)
        indList = "N"

        btnIncluir.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
        btnPesquisar.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
        btnExcluir.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
        btnSalvar.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
        btnLimpar.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
        bvcPrincipal.Selected = True
        txtDescription.Focus()

        txtId.Focus()

    End Sub
    Private Sub Model_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        bvcPrincipal.Selected = True

        tabControlPrincipal.ShowTabHeader = DevExpress.Utils.DefaultBoolean.False

        btnIncluir.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
        btnPesquisar.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
        btnExcluir.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
        btnSalvar.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
        btnLimpar.Visibility = DevExpress.XtraBars.BarItemVisibility.Never

    End Sub

    Private Sub INCLUDE()

        If txtId.Enabled = True Then

            If txtTitle.Text = "" Then
                txtTitle.Focus()
                tabControlPrincipal.SelectedTabPageIndex = 0
                ALERTA.Active = True
                ALERTA.Show("Preencha o título do produto!", txtTitle)
                ALERTA.Show("!", txtTitle)
                txtTitle.BackColor = Color.Red
                Exit Sub
            End If

            If txtDescription.Text = "" Then
                txtDescription.Focus()
                tabControlPrincipal.SelectedTabPageIndex = 0
                ALERTA.Active = True
                ALERTA.Show("Preencha a descrição do produto!", txtDescription)
                ALERTA.Show("!", txtDescription)
                txtDescription.BackColor = Color.Red
                Exit Sub
            End If

            If txtPrice.Text = "" Then
                txtPrice.Focus()
                tabControlPrincipal.SelectedTabPageIndex = 0
                ALERTA.Active = True
                ALERTA.Show("Preencha o preço do produto!", txtPrice)
                ALERTA.Show("!", txtPrice)
                txtPrice.BackColor = Color.Red
                Exit Sub
            End If

            If cmbUnit.Text = "" Then
                cmbUnit.Focus()
                tabControlPrincipal.SelectedTabPageIndex = 0
                ALERTA.Active = True
                ALERTA.Show("Preencha a unidade de medida do produto!", cmbUnit)
                ALERTA.Show("!", cmbUnit)
                cmbUnit.BackColor = Color.Red
                Exit Sub
            End If

            If txtPicture.Text = "" Then
                txtPicture.Focus()
                tabControlPrincipal.SelectedTabPageIndex = 0
                ALERTA.Active = True
                ALERTA.Show("Preencha a imagem url do produto!", txtPicture)
                ALERTA.Show("!", txtPicture)
                txtPicture.BackColor = Color.Red
                Exit Sub
            End If

            If CreateProduct(txtTitle.Text, txtDescription.Text, Convert.ToDecimal(txtPrice.Text), cmbUnit.Text.Substring(0, 2), txtPicture.Text) = True Then
                BOX_MESSAGEM("INFORMACAO", "OK", "Registro realizado com sucesso!")
                CLEAR_SCREEN()
            Else
                BOX_MESSAGEM("ERROR", "OK", ReturnWithError)
            End If

        End If

    End Sub

    Private Sub SAVE()

        If txtId.Enabled = False Then

            If txtTitle.Text = "" Then
                txtTitle.Focus()
                tabControlPrincipal.SelectedTabPageIndex = 0
                ALERTA.Active = True
                ALERTA.Show("Preencha o título do produto!", txtTitle)
                ALERTA.Show("!", txtTitle)
                txtTitle.BackColor = Color.Red
                Exit Sub
            End If

            If txtDescription.Text = "" Then
                txtDescription.Focus()
                tabControlPrincipal.SelectedTabPageIndex = 0
                ALERTA.Active = True
                ALERTA.Show("Preencha a descrição do produto!", txtDescription)
                ALERTA.Show("!", txtDescription)
                txtDescription.BackColor = Color.Red
                Exit Sub
            End If

            If txtPrice.Text = "" Then
                txtPrice.Focus()
                tabControlPrincipal.SelectedTabPageIndex = 0
                ALERTA.Active = True
                ALERTA.Show("Preencha o preço do produto!", txtPrice)
                ALERTA.Show("!", txtPrice)
                txtPrice.BackColor = Color.Red
                Exit Sub
            End If

            If cmbUnit.Text = "" Then
                cmbUnit.Focus()
                tabControlPrincipal.SelectedTabPageIndex = 0
                ALERTA.Active = True
                ALERTA.Show("Preencha a unidade de medida do produto!", cmbUnit)
                ALERTA.Show("!", cmbUnit)
                cmbUnit.BackColor = Color.Red
                Exit Sub
            End If

            If txtPicture.Text = "" Then
                txtPicture.Focus()
                tabControlPrincipal.SelectedTabPageIndex = 0
                ALERTA.Active = True
                ALERTA.Show("Preencha a imagem url do produto!", txtPicture)
                ALERTA.Show("!", txtPicture)
                txtPicture.BackColor = Color.Red
                Exit Sub
            End If

            If UpdateProduct(txtId.Text, txtTitle.Text, txtDescription.Text, Convert.ToDecimal(txtPrice.Text), cmbUnit.Text.Substring(0, 2), txtPicture.Text) = True Then
                BOX_MESSAGEM("INFORMACAO", "OK", "Registro alterado com sucesso!")
                CLEAR_SCREEN()
            Else
                BOX_MESSAGEM("ERROR", "OK", ReturnWithError)
            End If

        End If

    End Sub

    Private Sub DELETE()

        If txtId.Enabled = False Then

            MESSAGE_RESULT = ""
            BOX_MESSAGEM("PERGUNTA", "SN", "Deseja realmente excluir o registro?")

            If MESSAGE_RESULT <> "SIM" Then
                Exit Sub
            End If

            FILL_IN_FIELDS()

            If DeleteProduct(txtId.Text) = True Then
                CLEAR_SCREEN()
                PESQUISAR_NEW()
                BOX_MESSAGEM("INFORMACAO", "OK", "Registro excluído com sucesso!")
            Else
                BOX_MESSAGEM("ERROR", "OK", ReturnWithError)
            End If

        End If

    End Sub

    Public Sub SEARCH_RECORDS()

        Dim SCRIPT As String = ""
        SCRIPT = "select * from products where ('' = '" & txtId.Text & "' or id::VARCHAR = '" & txtId.Text & "') and ('' = '" & txtTitle.Text & "' or title like '%" & txtTitle.Text & "%' ) and ('' = '" & txtDescription.Text & "' or description like '%" & txtDescription.Text & "%' ) ORDER BY title"

        Dim cmdselect As New Npgsql.NpgsqlCommand(SCRIPT, connection)

        Dim adapter As New Npgsql.NpgsqlDataAdapter
        adapter.SelectCommand = cmdselect
        Dim tabela As New DataTable()

        adapter.Fill(tabela)

        dgvListar.DataSource = tabela
        sequence = ""
        For i As Integer = 0 To gvListar.DataRowCount - 1

            sequence = sequence & " , " & gvListar.GetRowCellValue(i, "id").ToString()

        Next i

        sequence = "0 " & sequence

        FILL_IN_FIELDS()

    End Sub

    Private Sub PESQUISAR_NEW()

        Dim rowHandle As Integer = gvListar.FocusedRowHandle
        recordPosition = rowHandle

        Dim SCRIPT As String
        SCRIPT = "select * from products where id in (" & sequence & ") ORDER BY description"

        Dim cmdselect As New Npgsql.NpgsqlCommand(SCRIPT, connection)

        Dim adapter As New Npgsql.NpgsqlDataAdapter
        adapter.SelectCommand = cmdselect
        Dim tabela As New DataTable()
        adapter.Fill(tabela)
        dgvListar.DataSource = tabela
        gvListar.FocusedRowHandle = recordPosition
        gvListar.FocusedColumn = gvListar.Columns(recordPosition)
        gvListar.ShowEditor()

        FILL_IN_FIELDS()

    End Sub

    Private Sub FILL_IN_FIELDS()

        Dim rowHandle As Integer = gvListar.FocusedRowHandle

        Try
            txtId.Text = gvListar.GetRowCellValue(rowHandle, "id")
        Catch ex As Exception
            CLEAR_SCREEN()
            Exit Sub
        End Try

        Dim rowHandle2 As Integer = gvListar.FocusedRowHandle
        Dim countRow As Integer = gvListar.RowCount

        If rowHandle2 < 0 And countRow = 0 Then
            CLEAR_SCREEN()
            Exit Sub
        End If

        If txtId.Text = "" Then
            Exit Sub
        End If

        txtId.Enabled = False
        txtTitle.Text = gvListar.GetRowCellValue(rowHandle, "title").ToString
        txtDescription.Text = gvListar.GetRowCellValue(rowHandle, "description").ToString
        txtPrice.Text = gvListar.GetRowCellValue(rowHandle, "price").ToString
        cmbUnit.Text = gvListar.GetRowCellValue(rowHandle, "unit").ToString
        txtPicture.Text = gvListar.GetRowCellValue(rowHandle, "picture").ToString

        btnIncluir.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
        btnPesquisar.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
        btnExcluir.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
        btnSalvar.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
        btnLimpar.Visibility = DevExpress.XtraBars.BarItemVisibility.Always

    End Sub

    Public Sub LIST()

        OPEN_MOUSE()

        If indList = "N" Then
            bvcPrincipal.Selected = True
            tabControlPrincipal.SelectedTabPageIndex = (1)
            indList = "S"
            dgvListar.Focus()
#Disable Warning BC42025 ' Acesso do membro compartilhado, membro constante, membro enumerado ou tipo aninhado por meio de uma instância
            gvListar.FocusedRowHandle = dgvListar.AutoFilterRowHandle
#Enable Warning BC42025 ' Acesso do membro compartilhado, membro constante, membro enumerado ou tipo aninhado por meio de uma instância
            gvListar.FocusedColumn = GridColumn2
            gvListar.ShowEditor()
        Else
            tabControlPrincipal.SelectedTabPageIndex = (0)
            indList = "N"
            bvcPrincipal.Selected = True
            txtDescription.Focus()
        End If

        CLOSE_MOUSE()

    End Sub

    Private Sub dgvListar_DoubleClick(sender As Object, e As EventArgs) Handles dgvListar.DoubleClick

        FILL_IN_FIELDS()
        indList = "N"
        tabControlPrincipal.SelectedTabPageIndex = (0)
        txtDescription.Focus()

    End Sub

    Private Sub dgvListar_KeyDown(sender As Object, e As KeyEventArgs) Handles dgvListar.KeyDown
        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True
            FILL_IN_FIELDS()
            indList = "N"
            tabControlPrincipal.SelectedTabPageIndex = (0)
            txtDescription.Focus()
        End If
    End Sub

    Private Sub txtId_EnabledChanged(sender As Object, e As EventArgs) Handles txtId.EnabledChanged

        If txtId.Enabled = True Then
            btnIncluir.Enabled = True
            btnSalvar.Enabled = False
            btnExcluir.Enabled = False
            btnPesquisar.Enabled = True
        Else
            btnIncluir.Enabled = False
            btnSalvar.Enabled = True
            btnExcluir.Enabled = True
            btnPesquisar.Enabled = False
        End If

    End Sub

    Private Sub btnIncluir_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnIncluir.ItemClick

        OPEN_MOUSE()

        INCLUDE()

        CLOSE_MOUSE()

    End Sub

    Private Sub btnSalvar_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnSalvar.ItemClick

        OPEN_MOUSE()

        SAVE()

        CLOSE_MOUSE()

    End Sub

    Private Sub btnExcluir_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnExcluir.ItemClick

        OPEN_MOUSE()

        DELETE()

        PESQUISAR_NEW()

        CLOSE_MOUSE()

    End Sub

    Private Sub btnPesquisar_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnPesquisar.ItemClick

        OPEN_MOUSE()

        SEARCH_RECORDS()

        CLOSE_MOUSE()

    End Sub

    Private Sub btnLimpar_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnLimpar.ItemClick

        OPEN_MOUSE()

        CLEAR_SCREEN()

        CLOSE_MOUSE()

    End Sub

    Private Sub btnListar_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnListar.ItemClick

        RESET_BALLOON()

        LIST()

    End Sub

    Private Sub btnPrimeiro_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnPrimeiro.ItemClick

        OPEN_MOUSE()
        gvListar.MoveFirst()
        FILL_IN_FIELDS()
        CLOSE_MOUSE()

    End Sub

    Private Sub btnVoltar_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnVoltar.ItemClick

        OPEN_MOUSE()
        gvListar.MovePrev()
        FILL_IN_FIELDS()
        CLOSE_MOUSE()

    End Sub

    Private Sub btnAvancar_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnAvancar.ItemClick

        OPEN_MOUSE()
        gvListar.MoveNext()
        FILL_IN_FIELDS()
        CLOSE_MOUSE()

    End Sub

    Private Sub btnUltimo_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnUltimo.ItemClick

        OPEN_MOUSE()
        gvListar.MoveLast()
        FILL_IN_FIELDS()
        CLOSE_MOUSE()

    End Sub

    Private Sub btnImprimir_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnImprimir.ItemClick
        RELATORIOS()
    End Sub

    Private Sub t_focus_Tick(sender As Object, e As EventArgs) Handles t_focus.Tick

        t_focus.Stop()
        dgvListar.Focus()
#Disable Warning BC42025 ' Acesso do membro compartilhado, membro constante, membro enumerado ou tipo aninhado por meio de uma instância
        gvListar.FocusedRowHandle = dgvListar.AutoFilterRowHandle
#Enable Warning BC42025 ' Acesso do membro compartilhado, membro constante, membro enumerado ou tipo aninhado por meio de uma instância
        gvListar.FocusedColumn = GridColumn2
        gvListar.ShowEditor()

    End Sub

    Private Sub txtPicture_TextChanged(sender As Object, e As EventArgs) Handles txtPicture.TextChanged

        Try
            picture.Load(txtPicture.Text)
        Catch ex As Exception
            picture.Image = Nothing
        End Try

    End Sub
End Class