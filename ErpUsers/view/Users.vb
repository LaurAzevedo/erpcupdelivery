Imports DevExpress.XtraGrid.Views.Base
Public Class RegisterUser

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
        txtName.BackColor = Color.DarkGray
        txtEmail.BackColor = Color.DarkGray
        txtTelephone.BackColor = Color.DarkGray
        txtPassword.BackColor = Color.DarkGray
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
        txtName.Text = ""
        txtEmail.Text = ""
        txtPassword.Text = ""
        txtTelephone.Text = ""
        txtId.Enabled = True

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
        txtName.Focus()

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
    Private Function VALIDATE_FIELDS()

        If txtName.Text = "" Then
            txtName.Focus()
            tabControlPrincipal.SelectedTabPageIndex = 0
            ALERTA.Active = True
            ALERTA.Show("Preencha o nome do usuário!", txtName)
            ALERTA.Show("!", txtName)
            txtName.BackColor = Color.Red
            Return False
        End If

        If txtEmail.Text = "" Then
            txtEmail.Focus()
            tabControlPrincipal.SelectedTabPageIndex = 0
            ALERTA.Active = True
            ALERTA.Show("Preencha o email!", txtEmail)
            ALERTA.Show("!", txtEmail)
            txtEmail.BackColor = Color.Red
            Return False
        End If

        If txtPassword.Text = "" Then
            txtPassword.Focus()
            tabControlPrincipal.SelectedTabPageIndex = 0
            ALERTA.Active = True
            ALERTA.Show("Preencha a senha!", txtPassword)
            ALERTA.Show("!", txtPassword)
            txtPassword.BackColor = Color.Red
            Return False
        End If

        If txtTelephone.Text = "" Then
            txtTelephone.Focus()
            tabControlPrincipal.SelectedTabPageIndex = 0
            ALERTA.Active = True
            ALERTA.Show("Preencha o telefone!", txtTelephone)
            ALERTA.Show("!", txtTelephone)
            txtTelephone.BackColor = Color.Red
            Return False
        End If

        Return True

    End Function
    Private Sub INCLUDE()

        If txtId.Enabled = True Then

            If VALIDATE_FIELDS() = False Then Exit Sub

            Dim user As New UserModel.CreateUser
            user.name = txtName.Text
            user.password = txtPassword.Text
            user.email = txtEmail.Text
            user.telephone = txtTelephone.Text

            If CreateUser(user) = True Then
                BOX_MESSAGEM("INFORMACAO", "OK", "Registro realizado com sucesso!")
                CLEAR_SCREEN()
            Else
                BOX_MESSAGEM("ERROR", "OK", ReturnWithError)
            End If

        End If

    End Sub

    Private Sub SAVE()

        If txtId.Enabled = False Then

            If VALIDATE_FIELDS() = False Then Exit Sub

            Dim user As New UserModel.UpdateUser
            user.id = txtId.Text
            user.name = txtName.Text
            user.email = txtEmail.Text
            user.telephone = txtTelephone.Text

            If UpdateUser(user) = True Then
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

            If DeleteUser(txtId.Text) = True Then
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
        SCRIPT = "select * from erp_users where ('' = '" & txtId.Text & "' or id::VARCHAR = '" & txtId.Text & "') and ('' = '" & txtName.Text & "' or name like '%" & txtName.Text & "%' )  and ('' = '" & txtEmail.Text & "' or email like '%" & txtEmail.Text & "%' ) ORDER BY name"

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
        SCRIPT = "select * from erp_users where id in (" & sequence & ") ORDER BY name"

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
        txtName.Text = gvListar.GetRowCellValue(rowHandle, "name").ToString
        txtEmail.Text = gvListar.GetRowCellValue(rowHandle, "email").ToString
        txtTelephone.Text = gvListar.GetRowCellValue(rowHandle, "telephone").ToString
        txtPassword.Text = gvListar.GetRowCellValue(rowHandle, "password").ToString

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
            txtName.Focus()
        End If

        CLOSE_MOUSE()

    End Sub

    Private Sub dgvListar_DoubleClick(sender As Object, e As EventArgs) Handles dgvListar.DoubleClick

        FILL_IN_FIELDS()
        indList = "N"
        tabControlPrincipal.SelectedTabPageIndex = (0)
        txtName.Focus()

    End Sub

    Private Sub dgvListar_KeyDown(sender As Object, e As KeyEventArgs) Handles dgvListar.KeyDown
        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True
            FILL_IN_FIELDS()
            indList = "N"
            tabControlPrincipal.SelectedTabPageIndex = (0)
            txtName.Focus()
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

End Class