<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Message
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Message))
        Me.txtMensagem = New System.Windows.Forms.TextBox()
        Me.PIC_ERRO = New System.Windows.Forms.PictureBox()
        Me.PIC_INFORMACAO = New System.Windows.Forms.PictureBox()
        Me.PIC_ATENCAO = New System.Windows.Forms.PictureBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.PIC_PERGUNTA = New System.Windows.Forms.PictureBox()
        Me.btnNao = New DevExpress.XtraEditors.SimpleButton()
        Me.btnSim = New DevExpress.XtraEditors.SimpleButton()
        Me.btnOk = New DevExpress.XtraEditors.SimpleButton()
        Me.lb_detalhe = New System.Windows.Forms.Label()
        Me.txtTitulo = New DevExpress.XtraEditors.TextEdit()
        CType(Me.PIC_ERRO, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PIC_INFORMACAO, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PIC_ATENCAO, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PIC_PERGUNTA, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTitulo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtMensagem
        '
        Me.txtMensagem.BackColor = System.Drawing.Color.Gray
        Me.txtMensagem.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtMensagem.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMensagem.ForeColor = System.Drawing.Color.White
        Me.txtMensagem.Location = New System.Drawing.Point(44, 27)
        Me.txtMensagem.Multiline = True
        Me.txtMensagem.Name = "txtMensagem"
        Me.txtMensagem.ReadOnly = True
        Me.txtMensagem.Size = New System.Drawing.Size(311, 97)
        Me.txtMensagem.TabIndex = 8925
        '
        'PIC_ERRO
        '
        Me.PIC_ERRO.BackColor = System.Drawing.Color.Transparent
        Me.PIC_ERRO.BackgroundImage = CType(resources.GetObject("PIC_ERRO.BackgroundImage"), System.Drawing.Image)
        Me.PIC_ERRO.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PIC_ERRO.Location = New System.Drawing.Point(7, 45)
        Me.PIC_ERRO.Name = "PIC_ERRO"
        Me.PIC_ERRO.Size = New System.Drawing.Size(32, 31)
        Me.PIC_ERRO.TabIndex = 8924
        Me.PIC_ERRO.TabStop = False
        Me.PIC_ERRO.Visible = False
        '
        'PIC_INFORMACAO
        '
        Me.PIC_INFORMACAO.BackColor = System.Drawing.Color.Transparent
        Me.PIC_INFORMACAO.BackgroundImage = CType(resources.GetObject("PIC_INFORMACAO.BackgroundImage"), System.Drawing.Image)
        Me.PIC_INFORMACAO.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PIC_INFORMACAO.Location = New System.Drawing.Point(7, 45)
        Me.PIC_INFORMACAO.Name = "PIC_INFORMACAO"
        Me.PIC_INFORMACAO.Size = New System.Drawing.Size(32, 31)
        Me.PIC_INFORMACAO.TabIndex = 8923
        Me.PIC_INFORMACAO.TabStop = False
        Me.PIC_INFORMACAO.Visible = False
        '
        'PIC_ATENCAO
        '
        Me.PIC_ATENCAO.BackColor = System.Drawing.Color.Transparent
        Me.PIC_ATENCAO.BackgroundImage = CType(resources.GetObject("PIC_ATENCAO.BackgroundImage"), System.Drawing.Image)
        Me.PIC_ATENCAO.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PIC_ATENCAO.Location = New System.Drawing.Point(7, 44)
        Me.PIC_ATENCAO.Name = "PIC_ATENCAO"
        Me.PIC_ATENCAO.Size = New System.Drawing.Size(32, 31)
        Me.PIC_ATENCAO.TabIndex = 8922
        Me.PIC_ATENCAO.TabStop = False
        Me.PIC_ATENCAO.Visible = False
        '
        'Timer1
        '
        '
        'PIC_PERGUNTA
        '
        Me.PIC_PERGUNTA.BackColor = System.Drawing.Color.Transparent
        Me.PIC_PERGUNTA.BackgroundImage = CType(resources.GetObject("PIC_PERGUNTA.BackgroundImage"), System.Drawing.Image)
        Me.PIC_PERGUNTA.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PIC_PERGUNTA.Location = New System.Drawing.Point(7, 45)
        Me.PIC_PERGUNTA.Name = "PIC_PERGUNTA"
        Me.PIC_PERGUNTA.Size = New System.Drawing.Size(32, 31)
        Me.PIC_PERGUNTA.TabIndex = 8926
        Me.PIC_PERGUNTA.TabStop = False
        Me.PIC_PERGUNTA.Visible = False
        '
        'btnNao
        '
        Me.btnNao.ImageOptions.Image = CType(resources.GetObject("btnNao.ImageOptions.Image"), System.Drawing.Image)
        Me.btnNao.Location = New System.Drawing.Point(273, 130)
        Me.btnNao.Name = "btnNao"
        Me.btnNao.Size = New System.Drawing.Size(82, 27)
        Me.btnNao.TabIndex = 8931
        Me.btnNao.Text = "NÃO"
        Me.btnNao.Visible = False
        '
        'btnSim
        '
        Me.btnSim.ImageOptions.Image = CType(resources.GetObject("btnSim.ImageOptions.Image"), System.Drawing.Image)
        Me.btnSim.Location = New System.Drawing.Point(187, 130)
        Me.btnSim.Name = "btnSim"
        Me.btnSim.Size = New System.Drawing.Size(82, 27)
        Me.btnSim.TabIndex = 8930
        Me.btnSim.Text = "SIM"
        Me.btnSim.Visible = False
        '
        'btnOk
        '
        Me.btnOk.ImageOptions.Image = CType(resources.GetObject("btnOk.ImageOptions.Image"), System.Drawing.Image)
        Me.btnOk.Location = New System.Drawing.Point(139, 130)
        Me.btnOk.Name = "btnOk"
        Me.btnOk.Size = New System.Drawing.Size(82, 27)
        Me.btnOk.TabIndex = 8929
        Me.btnOk.Text = "OK"
        Me.btnOk.Visible = False
        '
        'lb_detalhe
        '
        Me.lb_detalhe.AutoSize = True
        Me.lb_detalhe.Font = New System.Drawing.Font("Tahoma", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb_detalhe.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lb_detalhe.Location = New System.Drawing.Point(1, 140)
        Me.lb_detalhe.Name = "lb_detalhe"
        Me.lb_detalhe.Size = New System.Drawing.Size(91, 11)
        Me.lb_detalhe.TabIndex = 8928
        Me.lb_detalhe.Text = "F1 para ver detalhes"
        Me.lb_detalhe.Visible = False
        '
        'txtTitulo
        '
        Me.txtTitulo.Dock = System.Windows.Forms.DockStyle.Top
        Me.txtTitulo.EditValue = "ATENÇÃO"
        Me.txtTitulo.Location = New System.Drawing.Point(0, 0)
        Me.txtTitulo.Name = "txtTitulo"
        Me.txtTitulo.Properties.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.txtTitulo.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTitulo.Properties.Appearance.Options.UseBackColor = True
        Me.txtTitulo.Properties.Appearance.Options.UseFont = True
        Me.txtTitulo.Properties.Appearance.Options.UseTextOptions = True
        Me.txtTitulo.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.txtTitulo.Size = New System.Drawing.Size(360, 24)
        Me.txtTitulo.TabIndex = 8927
        '
        'Message
        '
        Me.Appearance.BackColor = System.Drawing.Color.Gray
        Me.Appearance.Options.UseBackColor = True
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(360, 161)
        Me.Controls.Add(Me.txtMensagem)
        Me.Controls.Add(Me.PIC_ERRO)
        Me.Controls.Add(Me.PIC_INFORMACAO)
        Me.Controls.Add(Me.PIC_ATENCAO)
        Me.Controls.Add(Me.PIC_PERGUNTA)
        Me.Controls.Add(Me.btnNao)
        Me.Controls.Add(Me.btnSim)
        Me.Controls.Add(Me.btnOk)
        Me.Controls.Add(Me.lb_detalhe)
        Me.Controls.Add(Me.txtTitulo)
        Me.IconOptions.ShowIcon = False
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Message"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Mensagem"
        CType(Me.PIC_ERRO, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PIC_INFORMACAO, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PIC_ATENCAO, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PIC_PERGUNTA, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTitulo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtMensagem As TextBox
    Friend WithEvents PIC_ERRO As PictureBox
    Friend WithEvents PIC_INFORMACAO As PictureBox
    Friend WithEvents PIC_ATENCAO As PictureBox
    Friend WithEvents Timer1 As Timer
    Friend WithEvents PIC_PERGUNTA As PictureBox
    Friend WithEvents btnNao As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnSim As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnOk As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents lb_detalhe As Label
    Friend WithEvents txtTitulo As DevExpress.XtraEditors.TextEdit
End Class
