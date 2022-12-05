Public Class Message

    Private Declare Function FlashWindow Lib "user32" Alias "FlashWindow" (ByVal hwnd As IntPtr, ByVal bInvert As Integer) As Integer
    Public TIPO_ICONE As String
    Public TIPO_BOTAO As String
    Public MSG_DETALHE As String

    Private Sub mensagem_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing

        If MESSAGE_RESULT = "" Then
            MESSAGE_RESULT = "NAO"
        End If

        CLOSE_MOUSE()
    End Sub

    Private Sub mensagem_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Enter Then
            If TIPO_BOTAO = "OK" Then
                MESSAGE_RESULT = "OK"
                Me.Close()
            End If

            If TIPO_BOTAO = "SN" Then
                MESSAGE_RESULT = "SIM"
                Me.Close()
            End If
        End If

        If e.KeyCode = Keys.F1 And MSG_DETALHE <> "" Then

            Dim tmp As New MessageDetails
            tmp.txtDetalhe.Text = MSG_DETALHE
            tmp.ShowDialog()

        End If

        If e.KeyCode = Keys.Space Then

            If TIPO_BOTAO = "OK" Then
                MESSAGE_RESULT = "OK"
                Me.Close()
            End If

            If TIPO_BOTAO = "SN" Then
                MESSAGE_RESULT = "SIM"
                Me.Close()
            End If

        End If

        If e.KeyCode = Keys.Escape Then
            Me.Close()
        End If
    End Sub

    Private Sub mensagem_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If MSG_DETALHE <> "" Then
            lb_detalhe.Visible = True
        End If

        txtTitulo.BackColor = Me.BackColor
        txtMensagem.BackColor = Me.BackColor
        MESSAGE_RESULT = ""

        Timer1.Start()

        If TIPO_BOTAO = "SN" Then
            btnSim.Visible = True
            btnNao.Visible = True
        End If

        If TIPO_BOTAO = "OK" Then
            btnOk.Visible = True
        End If

        If TIPO_ICONE = "ATENCAO" Then
            PIC_ATENCAO.Visible = True
            txtTitulo.Text = "Usuário"
            txtTitulo.ForeColor = Color.LightSalmon
        End If

        If TIPO_ICONE = "INFORMACAO" Then
            PIC_INFORMACAO.Visible = True
            txtTitulo.Text = ""
            txtTitulo.ForeColor = Color.SlateBlue
        End If

        If TIPO_ICONE = "ERRO" Then
            PIC_ERRO.Visible = True
            txtTitulo.Text = "ERRO"
            txtTitulo.ForeColor = Color.Crimson
        End If

        If TIPO_BOTAO = "SN" Then
            PIC_PERGUNTA.Visible = True
            txtTitulo.Text = "Usuário"
            txtTitulo.ForeColor = Color.DodgerBlue
        End If

        Dim texto As String
        texto = txtMensagem.Text.Replace("PROCEDURE", "")
        texto = texto.Replace("'", "")
        texto = texto.Replace("column Param1 at row 1", "")
        texto = texto.Replace("column Param1 at row 2", "")
        texto = texto.Replace("column Param1 at row 3", "")
        texto = texto.Replace("column Param1 at row 4", "")
        texto = texto.Replace("column Param1 at row 5", "")
        texto = texto.Replace("column Param1 at row 6", "")
        texto = texto.Replace("column Param1 at row 7", "")
        texto = texto.Replace("Variable MYSQL_ERRNO cant be set to the value of", "")
        texto = texto.Replace("ERROR", "")
        texto = texto.Replace("Error while executing the query", "")
        texto = texto.Replace(" [P0001] : ", "")
        txtMensagem.Text = texto

        Me.BringToFront()
        FlashWindow(Me.Handle, 1)
    End Sub

    Private Sub btnOk_Click(sender As Object, e As EventArgs) Handles btnOk.Click
        MESSAGE_RESULT = "OK"
        Me.Close()
    End Sub

    Private Sub btnSim_Click(sender As Object, e As EventArgs) Handles btnSim.Click
        MESSAGE_RESULT = "SIM"
        Me.Close()
    End Sub

    Private Sub btnNao_Click(sender As Object, e As EventArgs) Handles btnNao.Click
        MESSAGE_RESULT = "NAO"
        Me.Close()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If TIPO_ICONE = "ATENCAO" Then
            PIC_ATENCAO.Focus()
        End If
        If TIPO_ICONE = "INFORMACAO" Then
            PIC_INFORMACAO.Focus()
        End If

        If TIPO_ICONE = "ERRO" Then
            PIC_ERRO.Focus()
        End If

        If TIPO_ICONE = "PERGUNTA" Then
            PIC_PERGUNTA.Focus()
        End If
        Timer1.Stop()
    End Sub

End Class