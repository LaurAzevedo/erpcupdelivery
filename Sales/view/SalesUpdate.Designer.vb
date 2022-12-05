<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SalesUpdate
    Inherits DevExpress.XtraEditors.XtraForm

    'Descartar substituições de formulário para limpar a lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Exigido pelo Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'OBSERVAÇÃO: o procedimento a seguir é exigido pelo Windows Form Designer
    'Pode ser modificado usando o Windows Form Designer.  
    'Não o modifique usando o editor de códigos.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SalesUpdate))
        Me.btnPeding = New DevExpress.XtraEditors.SimpleButton()
        Me.btnInPreparation = New DevExpress.XtraEditors.SimpleButton()
        Me.btnOnDeliveryRoute = New DevExpress.XtraEditors.SimpleButton()
        Me.btnConcluded = New DevExpress.XtraEditors.SimpleButton()
        Me.btnCanceled = New DevExpress.XtraEditors.SimpleButton()
        Me.SuspendLayout()
        '
        'btnPeding
        '
        Me.btnPeding.ImageOptions.Image = CType(resources.GetObject("btnPeding.ImageOptions.Image"), System.Drawing.Image)
        Me.btnPeding.Location = New System.Drawing.Point(8, 12)
        Me.btnPeding.Name = "btnPeding"
        Me.btnPeding.Size = New System.Drawing.Size(322, 32)
        Me.btnPeding.TabIndex = 3
        Me.btnPeding.Text = "ATUALIZAR PARA PENDENTE"
        '
        'btnInPreparation
        '
        Me.btnInPreparation.ImageOptions.Image = CType(resources.GetObject("btnInPreparation.ImageOptions.Image"), System.Drawing.Image)
        Me.btnInPreparation.Location = New System.Drawing.Point(8, 50)
        Me.btnInPreparation.Name = "btnInPreparation"
        Me.btnInPreparation.Size = New System.Drawing.Size(322, 32)
        Me.btnInPreparation.TabIndex = 4
        Me.btnInPreparation.Text = "ATUALIZAR PARA EM PREPARAÇÃO"
        '
        'btnOnDeliveryRoute
        '
        Me.btnOnDeliveryRoute.ImageOptions.Image = CType(resources.GetObject("btnOnDeliveryRoute.ImageOptions.Image"), System.Drawing.Image)
        Me.btnOnDeliveryRoute.Location = New System.Drawing.Point(8, 88)
        Me.btnOnDeliveryRoute.Name = "btnOnDeliveryRoute"
        Me.btnOnDeliveryRoute.Size = New System.Drawing.Size(322, 32)
        Me.btnOnDeliveryRoute.TabIndex = 5
        Me.btnOnDeliveryRoute.Text = "ATUALIZAR PARA EM ROTA DE ENTREGA"
        '
        'btnConcluded
        '
        Me.btnConcluded.ImageOptions.Image = CType(resources.GetObject("btnConcluded.ImageOptions.Image"), System.Drawing.Image)
        Me.btnConcluded.Location = New System.Drawing.Point(8, 126)
        Me.btnConcluded.Name = "btnConcluded"
        Me.btnConcluded.Size = New System.Drawing.Size(322, 32)
        Me.btnConcluded.TabIndex = 6
        Me.btnConcluded.Text = "ATUALIZAR PARA CONCLUÍDO"
        '
        'btnCanceled
        '
        Me.btnCanceled.ImageOptions.Image = CType(resources.GetObject("btnCanceled.ImageOptions.Image"), System.Drawing.Image)
        Me.btnCanceled.Location = New System.Drawing.Point(8, 164)
        Me.btnCanceled.Name = "btnCanceled"
        Me.btnCanceled.Size = New System.Drawing.Size(322, 32)
        Me.btnCanceled.TabIndex = 7
        Me.btnCanceled.Text = "ATUALIZAR PARA CANCELADO"
        '
        'SalesUpdate
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(342, 208)
        Me.ControlBox = False
        Me.Controls.Add(Me.btnCanceled)
        Me.Controls.Add(Me.btnConcluded)
        Me.Controls.Add(Me.btnOnDeliveryRoute)
        Me.Controls.Add(Me.btnInPreparation)
        Me.Controls.Add(Me.btnPeding)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "SalesUpdate"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Atulização de Status"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnPeding As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnInPreparation As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnOnDeliveryRoute As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnConcluded As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnCanceled As DevExpress.XtraEditors.SimpleButton
End Class
