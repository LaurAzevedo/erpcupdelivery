Imports Newtonsoft.Json

Public Class SaleDetails

    Public salesId As Integer
    Public customerId As Integer

    Private Sub SaleDetails_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        SEARCH_PRODUCTS_SALES(salesId)
        SEARCH_CUSTOMER()

    End Sub

    Private Sub SEARCH_PRODUCTS_SALES(sales As Integer)

        Dim cmdSelect As New Npgsql.NpgsqlCommand("SELECT id, item, title, quantity, price, (quantity * price) AS total_price FROM products_sales WHERE sales_id = @v1", connection)

        With cmdSelect.Parameters

            .Add(NEW_PARAMETER("1", "I", sales))

        End With

        Dim adapter As New Npgsql.NpgsqlDataAdapter
        adapter.SelectCommand = cmdSelect
        Dim tabela As New DataTable()
        adapter.Fill(tabela)

        dgvProducts.DataSource = tabela

        CALCULATE_TOTAL()

    End Sub

    Private Sub SEARCH_CUSTOMER()

        Dim cmdSelect As New Npgsql.NpgsqlCommand("SELECT * FROM customers WHERE id = @v1", connection)

        With cmdSelect.Parameters

            .Add(NEW_PARAMETER("1", "I", customerId))

        End With

        Dim adapter As New Npgsql.NpgsqlDataAdapter
        adapter.SelectCommand = cmdSelect
        Dim tabela As New DataTable()
        adapter.Fill(tabela)
        Dim row As DataRow

        For Each row In tabela.Rows

            txtName.Text = row("name")
            txtEmail.Text = row("email")
            txtTelephone.Text = row("telephone")
            txtCpf.Text = row("cpf")
            txtZipCode.Text = row("zip_code")
            txtPublicPlace.Text = row("public_place")
            txtNumber.Text = row("number")
            txtComplement.Text = row("complement")
            txtCity.Text = row("city")
            txtDistrict.Text = row("district")

        Next

    End Sub

    Private Sub CALCULATE_TOTAL()

        Dim total As Double = 0

        For i = 0 To dgvProducts.Rows.Count - 1

            total += Convert.ToDecimal(dgvProducts.Rows(i).Cells(5).Value)

        Next

        txtTotal.Text = total
        txtTotal.Text = Format(Convert.ToDecimal(txtTotal.Text), "#,##0.00")

    End Sub

    Private Sub SaleDetails_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown

        If e.KeyCode = Keys.Escape Then
            Me.Close()
        End If

    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub
End Class