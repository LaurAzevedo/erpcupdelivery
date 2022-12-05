Public Class SalesUpdate

    Public salesId As Integer

    Private Sub btnConfirmar_Click(sender As Object, e As EventArgs) Handles btnPeding.Click

        MESSAGE_RESULT = ""
        BOX_MESSAGEM("PERGUNTA", "SN", "Deseja atualizar o status do pedido " & salesId & " para PENDENTE?")

        If MESSAGE_RESULT <> "SIM" Then
            Exit Sub
        End If

        If UpdateSales(salesId, "pending_payment") = True Then
            BOX_MESSAGEM("INFORMACAO", "OK", "Status atualizado com sucesso")
            Me.Close()
        Else
            BOX_MESSAGEM("ERRO", "OK", ReturnWithError)
        End If

    End Sub

    Private Sub btnInPreparation_Click(sender As Object, e As EventArgs) Handles btnInPreparation.Click
        MESSAGE_RESULT = ""
        BOX_MESSAGEM("PERGUNTA", "SN", "Deseja atualizar o status do pedido " & salesId & " para EM PREPARAÇÃO?")

        If MESSAGE_RESULT <> "SIM" Then
            Exit Sub
        End If

        If UpdateSales(salesId, "preparing_purchase") = True Then
            BOX_MESSAGEM("INFORMACAO", "OK", "Status atualizado com sucesso")
            Me.Close()
        Else
            BOX_MESSAGEM("ERRO", "OK", ReturnWithError)
        End If
    End Sub

    Private Sub btnOnDeliveryRoute_Click(sender As Object, e As EventArgs) Handles btnOnDeliveryRoute.Click
        MESSAGE_RESULT = ""
        BOX_MESSAGEM("PERGUNTA", "SN", "Deseja atualizar o status do pedido " & salesId & " para EM ROTA DE ENTREGA?")

        If MESSAGE_RESULT <> "SIM" Then
            Exit Sub
        End If

        If UpdateSales(salesId, "shipping") = True Then
            BOX_MESSAGEM("INFORMACAO", "OK", "Status atualizado com sucesso")
            Me.Close()
        Else
            BOX_MESSAGEM("ERRO", "OK", ReturnWithError)
        End If
    End Sub

    Private Sub btnConcluded_Click(sender As Object, e As EventArgs) Handles btnConcluded.Click
        MESSAGE_RESULT = ""
        BOX_MESSAGEM("PERGUNTA", "SN", "Deseja atualizar o status do pedido " & salesId & " para CONCLUÍDO?")

        If MESSAGE_RESULT <> "SIM" Then
            Exit Sub
        End If

        If UpdateSales(salesId, "delivered") = True Then
            BOX_MESSAGEM("INFORMACAO", "OK", "Status atualizado com sucesso")
            Me.Close()
        Else
            BOX_MESSAGEM("ERRO", "OK", ReturnWithError)
        End If
    End Sub

    Private Sub btnCanceled_Click(sender As Object, e As EventArgs) Handles btnCanceled.Click
        MESSAGE_RESULT = ""
        BOX_MESSAGEM("PERGUNTA", "SN", "Deseja atualizar o status do pedido " & salesId & " para CANCELADO?")

        If MESSAGE_RESULT <> "SIM" Then
            Exit Sub
        End If

        If UpdateSales(salesId, "refunded") = True Then
            BOX_MESSAGEM("INFORMACAO", "OK", "Status atualizado com sucesso")
            Me.Close()
        Else
            BOX_MESSAGEM("ERRO", "OK", ReturnWithError)
        End If
    End Sub

End Class