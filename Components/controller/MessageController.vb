Module MessageController

    'VARIAVEIS DE ALERTA
    Public MESSAGE_RESULT As String = ""
    Public ABORTA_MSG_AGUARDE As Boolean = False
    Public Sub BOX_MESSAGEM(ByVal TIPO_ICONE As String, ByVal TIPO_BOTAO As String, ByVal MENSAGEM As String, Optional ByVal DETALHE As String = "")
        CLOSE_MOUSE()
        Dim TMP As New Message
        TMP.TIPO_BOTAO = TIPO_BOTAO
        TMP.TIPO_ICONE = TIPO_ICONE
        TMP.txtMensagem.Text = MENSAGEM
        TMP.MSG_DETALHE = DETALHE
        CLOSE_MOUSE()
        TMP.ShowDialog()
        CLOSE_MOUSE()
    End Sub

End Module
