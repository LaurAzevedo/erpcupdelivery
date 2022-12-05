Imports System.ComponentModel
Imports DevExpress.Skins

Public Class MainScreen
    Private Sub MainScreen_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        For Each cnt As SkinContainer In SkinManager.Default.Skins
            If cnt.SkinName = "Sharp" Or cnt.SkinName = "Sharp Plus" Or cnt.SkinName = "Office 2010 Black" Or cnt.SkinName = "High Contrast" Then
                Continue For
            End If
            cmbTema.Items.Add(cnt.SkinName)
        Next cnt

        Me.DefaultLookAndFeel1.LookAndFeel.SkinName = "DevExpress Dark Style"

        timerHour.Start()
        TimerStatus.Start()
        TimerCheckConnection.Start()
        TimerBackend.Start()

    End Sub
    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles timerHour.Tick
        lblDataHora.Text = UCase((FormatDateTime(Date.Today, DateFormat.LongDate) & " " & TimeOfDay))
    End Sub

    Private Sub MainScreen_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing

        SplashScreen.Close()

    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles TimerStatus.Tick

        StatusStrip1.Items.Clear()
        Dim cont As Integer = 0
        For Each ei In Me.MdiChildren
            Dim tmp As New ToolStripSplitButton
            tmp.Text = cont & " " & Me.MdiChildren(cont).Text
            StatusStrip1.Items.Add(tmp)
            cont += 1
        Next

        StatusStrip1.ForeColor = Color.White

    End Sub

    Private Sub StatusStrip1_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles StatusStrip1.ItemClicked

        Dim tmp As String = e.ClickedItem.Text.Substring(0, 2)
        tmp = (tmp)

        Me.MdiChildren(tmp).BringToFront()
        Me.MdiChildren(tmp).WindowState = FormWindowState.Normal

    End Sub

    Private Sub StatusStrip1_MouseHover(sender As Object, e As EventArgs) Handles StatusStrip1.MouseHover
        TimerStatus.Stop()
    End Sub

    Private Sub StatusStrip1_MouseLeave(sender As Object, e As EventArgs) Handles StatusStrip1.MouseLeave
        TimerStatus.Start()
    End Sub

    Public Sub WAIT_A_TIME()
        System.Threading.Thread.Sleep(0.001)
        Application.DoEvents()
    End Sub

    Private Sub t_verifica_conexao_db_Tick(sender As Object, e As EventArgs) Handles TimerCheckConnection.Tick

        If connectionAttempt >= 3 Then

            TimerCheckConnection.Stop()

            BOX_MESSAGEM("ERRO", "OK", "Não foi possível acessar o SERVIDOR!" & vbCrLf & "Verifique sua rede!" & vbCrLf & "Verifique se o SERVIDOR esta ligado!")

            Exit Sub

        End If

        Dim cmd As New Npgsql.NpgsqlCommand("SELECT id FROM api_users limit 1", connection)

        Try
            cmd.ExecuteNonQuery()
        Catch ex As Exception

            WAIT_A_TIME()

            Try
                connection.Close()
            Catch ex2 As Exception

            End Try

            WAIT_A_TIME()

            Try
                connection.Open()
            Catch ex3 As Exception

                WAIT_A_TIME()
                connectionAttempt += 1

                Exit Sub
            End Try

            connectionAttempt = 0

        End Try

    End Sub

    Private Sub btnCadastrarUsuarios_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnUsers.ItemClick
        OPEN_MOUSE()
        RegisterUser.MdiParent = Me
        RegisterUser.Show()
        RegisterUser.BringToFront()
        RegisterUser.WindowState = FormWindowState.Normal
        CLOSE_MOUSE()
    End Sub

    Private Sub btnCadastrarProdutos_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnProducts.ItemClick
        OPEN_MOUSE()
        Products.MdiParent = Me
        Products.Show()
        Products.BringToFront()
        Products.WindowState = FormWindowState.Normal
        CLOSE_MOUSE()
    End Sub


    Private Sub btnVendas_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnSales.ItemClick
        OPEN_MOUSE()
        Sales.MdiParent = Me
        Sales.Show()
        Sales.BringToFront()
        Sales.WindowState = FormWindowState.Normal
        CLOSE_MOUSE()
    End Sub

    Private Sub btnCustomers_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnCustomers.ItemClick
        OPEN_MOUSE()
        Customers.MdiParent = Me
        Customers.Show()
        Customers.BringToFront()
        Customers.WindowState = FormWindowState.Normal
        CLOSE_MOUSE()
    End Sub

    Private Sub TimerBackend_Tick(sender As Object, e As EventArgs) Handles TimerBackend.Tick
        AuthLogin()
    End Sub
End Class