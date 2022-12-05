Public Class Login
    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        lblVersao.Text = "Cup Delivery: " & Application.ProductVersion

    End Sub

    Private Sub btnSair_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        SplashScreen.Close()
    End Sub

    Private Sub btnLogar_Click(sender As Object, e As EventArgs) Handles btnLogin.Click

        If txtEmail.Text = "" Then
            BOX_MESSAGEM("ATENCAO", "OK", "Preencha o nome do usuário!")
            Exit Sub
        ElseIf txtPassword.Text = "" Then
            BOX_MESSAGEM("ATENCAO", "OK", "Preencha a senha do usuário!")
            Exit Sub
        Else
            LOGAR()
        End If

    End Sub

    Private Sub txtUsuario_KeyDown(sender As Object, e As KeyEventArgs) Handles txtEmail.KeyDown

        If e.KeyCode = Keys.Enter Then

            If txtEmail.Text = "" Then
                BOX_MESSAGEM("ATENCAO", "OK", "Preencha o nome do usuário!")
                Exit Sub
            Else

                If txtPassword.Text <> "" Then
                    LOGAR()
                Else
                    txtPassword.Focus()
                End If

            End If

        End If

    End Sub

    Private Sub txtSenha_KeyDown(sender As Object, e As KeyEventArgs) Handles txtPassword.KeyDown

        If e.KeyCode = Keys.Enter Then

            If txtPassword.Text = "" Then
                BOX_MESSAGEM("ATENCAO", "OK", "Preencha a senha!")
                Exit Sub
            Else

                If txtEmail.Text <> "" Then
                    LOGAR()
                Else
                    BOX_MESSAGEM("ATENCAO", "OK", "Preencha o nome do usuário!")
                    txtEmail.Focus()
                    Exit Sub
                End If

            End If

        End If

    End Sub

    Private Sub LOGAR()

        If UserLogin(txtEmail.Text, txtPassword.Text) = True Then
            Me.Hide()
            MainScreen.Show()
        Else
            BOX_MESSAGEM("ATENCAO", "OK", "E-mail ou senha inválido")
        End If

    End Sub

End Class