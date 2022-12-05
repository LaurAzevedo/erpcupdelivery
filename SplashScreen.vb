Public Class SplashScreen
    Private Sub StartScreen_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        TimerConnection.Start()

    End Sub

    Private Sub TimerLogin_Tick(sender As Object, e As EventArgs) Handles TimerSplash.Tick

        Me.Hide()
        TimerSplash.Stop()
        Login.Show()

    End Sub

    Private Sub TimerLogin_Tick_1(sender As Object, e As EventArgs) Handles TimerConnection.Tick

        TimerConnection.Stop()
        Dim connectionConfig As New PostgreSQLController
        connectionConfig.ConnectDatabase()
        AuthLogin()
        TimerSplash.Start()

    End Sub
End Class
