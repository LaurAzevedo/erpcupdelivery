Imports DevExpress.XtraGrid.Views.Base
Imports DevExpress.XtraTab

Public Class Sales

    Private Sub Sales_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SEARCH_SALES("pending_payment", 0)
        TimerSearch.Start()
    End Sub

    Private Sub SEARCH()

        If XtraTabControl1.SelectedTabPageIndex = 0 Then
            SEARCH_SALES("pending_payment", 0)
        End If

        If XtraTabControl1.SelectedTabPageIndex = 1 Then
            SEARCH_SALES("preparing_purchase", 1)
        End If

        If XtraTabControl1.SelectedTabPageIndex = 2 Then
            SEARCH_SALES("shipping", 2)
        End If

        If XtraTabControl1.SelectedTabPageIndex = 3 Then
            SEARCH_SALES("delivered", 3)
        End If

        If XtraTabControl1.SelectedTabPageIndex = 4 Then
            SEARCH_SALES("refunded", 4)
        End If

    End Sub

    Private Sub SEARCH_SALES(status As String, tab As Integer)

        Dim cmdSelect As New Npgsql.NpgsqlCommand("SELECT A.id, A.customer_id, B.name, A.created_at::TIMESTAMP::DATE AS created_at FROM sales A INNER JOIN customers B ON (A.customer_id = B.id) WHERE A.status = @v1", connection)

        With cmdSelect.Parameters

            .Add(NEW_PARAMETER("1", "S", status))

        End With

        Dim adapter As New Npgsql.NpgsqlDataAdapter
        adapter.SelectCommand = cmdSelect
        Dim tabela As New DataTable()
        adapter.Fill(tabela)

        Select Case tab
            Case 0
                dgvSalesPeding.DataSource = tabela
            Case 1
                dgvSalesInPreparation.DataSource = tabela
            Case 2
                dgvSalesOnDeliveryRoute.DataSource = tabela
            Case 3
                dgvSalesCompleted.DataSource = tabela
            Case 4
                dgvSalesCanceled.DataSource = tabela
        End Select

    End Sub

    Private Sub SEARCH_PRODUCTS_SALES(sales As Integer, tab As Integer)

        Dim cmdSelect As New Npgsql.NpgsqlCommand("SELECT id, item, title, quantity FROM products_sales WHERE sales_id = @v1", connection)

        With cmdSelect.Parameters

            .Add(NEW_PARAMETER("1", "I", sales))

        End With

        Dim adapter As New Npgsql.NpgsqlDataAdapter
        adapter.SelectCommand = cmdSelect
        Dim tabela As New DataTable()
        adapter.Fill(tabela)

        Select Case tab
            Case 0
                dgvProductsPeding.DataSource = tabela
            Case 1
                dgvProductsSalesInPreparation.DataSource = tabela
            Case 2
                dgvProductsSalesOnDeliveryRoute.DataSource = tabela
            Case 3
                dgvProductsSalesCompleted.DataSource = tabela
            Case 4
                dgvProductsSalesCanceled.DataSource = tabela
        End Select

    End Sub

    Private Sub btnFecharVenda_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnUpdateSales.ItemClick
        UPDATE_SALE()
    End Sub

    Private Sub UPDATE_SALE()

        Dim salesId As Integer = 0

        If XtraTabControl1.SelectedTabPageIndex = 0 Then
            salesId = dgvSalesPeding.Rows(dgvSalesPeding.CurrentCell.RowIndex).Cells(0).Value
        End If

        If XtraTabControl1.SelectedTabPageIndex = 1 Then
            salesId = dgvSalesInPreparation.Rows(dgvSalesInPreparation.CurrentCell.RowIndex).Cells(0).Value
        End If

        If XtraTabControl1.SelectedTabPageIndex = 2 Then
            salesId = dgvSalesOnDeliveryRoute.Rows(dgvSalesOnDeliveryRoute.CurrentCell.RowIndex).Cells(0).Value
        End If

        If XtraTabControl1.SelectedTabPageIndex = 3 Then
            salesId = dgvSalesCompleted.Rows(dgvSalesCompleted.CurrentCell.RowIndex).Cells(0).Value
        End If

        If XtraTabControl1.SelectedTabPageIndex = 4 Then
            salesId = dgvSalesCanceled.Rows(dgvSalesCanceled.CurrentCell.RowIndex).Cells(0).Value
        End If

        SalesUpdate.salesId = salesId
        SalesUpdate.ShowDialog()
        SEARCH()

    End Sub
    Private Sub dgvSalesPeding_Enter(sender As Object, e As EventArgs) Handles dgvSalesPeding.Enter

        SEARCH_PRODUCTS_SALES(dgvSalesPeding.Rows(dgvSalesPeding.CurrentCell.RowIndex).Cells(0).Value, 0)

    End Sub

    Private Sub dgvSalesInPreparation_Enter(sender As Object, e As EventArgs) Handles dgvSalesInPreparation.Enter

        SEARCH_PRODUCTS_SALES(dgvSalesInPreparation.Rows(dgvSalesInPreparation.CurrentCell.RowIndex).Cells(0).Value, 1)

    End Sub

    Private Sub dgvSalesOnDeliveryRoute_Enter(sender As Object, e As EventArgs) Handles dgvSalesOnDeliveryRoute.Enter

        SEARCH_PRODUCTS_SALES(dgvSalesOnDeliveryRoute.Rows(dgvSalesOnDeliveryRoute.CurrentCell.RowIndex).Cells(0).Value, 2)

    End Sub

    Private Sub dgvSalesCompleted_Enter(sender As Object, e As EventArgs) Handles dgvSalesCompleted.Enter

        SEARCH_PRODUCTS_SALES(dgvSalesCompleted.Rows(dgvSalesCompleted.CurrentCell.RowIndex).Cells(0).Value, 3)

    End Sub

    Private Sub dgvSalesCanceled_Enter(sender As Object, e As EventArgs) Handles dgvSalesCanceled.Enter

        SEARCH_PRODUCTS_SALES(dgvSalesCanceled.Rows(dgvSalesCanceled.CurrentCell.RowIndex).Cells(0).Value, 4)

    End Sub

    Private Sub btnPesquisar_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnSearch.ItemClick

        SEARCH()

    End Sub

    Private Sub XtraTabControl1_TabIndexChanged(sender As Object, e As EventArgs) Handles XtraTabControl1.TabIndexChanged

        SEARCH()

    End Sub

    Private Sub XtraTabControl1_SelectedPageChanged(sender As Object, e As TabPageChangedEventArgs) Handles XtraTabControl1.SelectedPageChanged
        SEARCH()
    End Sub

    Private Sub btnSalesDetails_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnSalesDetails.ItemClick
        SALE_DETAIS()

    End Sub

    Private Sub SALE_DETAIS()

        Dim salesId As Integer = 0
        Dim customerId As Integer = 0

        If XtraTabControl1.SelectedTabPageIndex = 0 Then
            salesId = dgvSalesPeding.Rows(dgvSalesPeding.CurrentCell.RowIndex).Cells(0).Value
            customerId = dgvSalesPeding.Rows(dgvSalesPeding.CurrentCell.RowIndex).Cells(1).Value
        End If

        If XtraTabControl1.SelectedTabPageIndex = 1 Then
            salesId = dgvSalesInPreparation.Rows(dgvSalesInPreparation.CurrentCell.RowIndex).Cells(0).Value
            customerId = dgvSalesInPreparation.Rows(dgvSalesInPreparation.CurrentCell.RowIndex).Cells(1).Value
        End If

        If XtraTabControl1.SelectedTabPageIndex = 2 Then
            salesId = dgvSalesOnDeliveryRoute.Rows(dgvSalesOnDeliveryRoute.CurrentCell.RowIndex).Cells(0).Value
            customerId = dgvSalesOnDeliveryRoute.Rows(dgvSalesOnDeliveryRoute.CurrentCell.RowIndex).Cells(1).Value
        End If

        If XtraTabControl1.SelectedTabPageIndex = 3 Then
            salesId = dgvSalesCompleted.Rows(dgvSalesCompleted.CurrentCell.RowIndex).Cells(0).Value
            customerId = dgvSalesCompleted.Rows(dgvSalesCompleted.CurrentCell.RowIndex).Cells(1).Value
        End If

        If XtraTabControl1.SelectedTabPageIndex = 4 Then
            salesId = dgvSalesCanceled.Rows(dgvSalesCanceled.CurrentCell.RowIndex).Cells(0).Value
            customerId = dgvSalesCanceled.Rows(dgvSalesCanceled.CurrentCell.RowIndex).Cells(1).Value
        End If

        SaleDetails.salesId = salesId
        SaleDetails.customerId = customerId
        SaleDetails.ShowDialog()

    End Sub

    Private Sub TimerSearch_Tick(sender As Object, e As EventArgs) Handles TimerSearch.Tick
        SEARCH()
    End Sub

    Private Sub Sales_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown

        If e.KeyCode = Keys.F1 Then

            OPEN_MOUSE()

            UPDATE_SALE()

            CLOSE_MOUSE()

        End If

        If e.KeyCode = Keys.F2 Then

            OPEN_MOUSE()

            SALE_DETAIS()

            CLOSE_MOUSE()

        End If

        If e.KeyCode = Keys.F5 Then

            OPEN_MOUSE()

            SEARCH()

            CLOSE_MOUSE()

        End If

    End Sub

    Private Sub dgvSalesPeding_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvSalesPeding.CellContentClick

        SEARCH_PRODUCTS_SALES(dgvSalesPeding.Rows(dgvSalesPeding.CurrentCell.RowIndex).Cells(0).Value, 0)

    End Sub

    Private Sub dgvSalesInPreparation_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvSalesInPreparation.CellContentClick

        SEARCH_PRODUCTS_SALES(dgvSalesInPreparation.Rows(dgvSalesInPreparation.CurrentCell.RowIndex).Cells(0).Value, 1)

    End Sub

    Private Sub dgvSalesOnDeliveryRoute_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvSalesOnDeliveryRoute.CellContentClick

        SEARCH_PRODUCTS_SALES(dgvSalesOnDeliveryRoute.Rows(dgvSalesOnDeliveryRoute.CurrentCell.RowIndex).Cells(0).Value, 2)

    End Sub

    Private Sub dgvSalesCompleted_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvSalesCompleted.CellContentClick

        SEARCH_PRODUCTS_SALES(dgvSalesCompleted.Rows(dgvSalesCompleted.CurrentCell.RowIndex).Cells(0).Value, 3)

    End Sub

    Private Sub dgvSalesCanceled_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvSalesCanceled.CellContentClick

        SEARCH_PRODUCTS_SALES(dgvSalesCanceled.Rows(dgvSalesCanceled.CurrentCell.RowIndex).Cells(0).Value, 4)

    End Sub
End Class