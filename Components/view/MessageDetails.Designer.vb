<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MessageDetails
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MessageDetails))
        Me.txtDetalhe = New System.Windows.Forms.TextBox()
        Me.txtTitulo = New DevExpress.XtraEditors.TextEdit()
        Me.btnOk = New System.Windows.Forms.Button()
        CType(Me.txtTitulo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtDetalhe
        '
        Me.txtDetalhe.BackColor = System.Drawing.Color.White
        Me.txtDetalhe.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtDetalhe.Dock = System.Windows.Forms.DockStyle.Top
        Me.txtDetalhe.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDetalhe.Location = New System.Drawing.Point(0, 24)
        Me.txtDetalhe.Multiline = True
        Me.txtDetalhe.Name = "txtDetalhe"
        Me.txtDetalhe.ReadOnly = True
        Me.txtDetalhe.Size = New System.Drawing.Size(652, 181)
        Me.txtDetalhe.TabIndex = 17
        '
        'txtTitulo
        '
        Me.txtTitulo.Dock = System.Windows.Forms.DockStyle.Top
        Me.txtTitulo.EditValue = "Detalhe"
        Me.txtTitulo.Location = New System.Drawing.Point(0, 0)
        Me.txtTitulo.Name = "txtTitulo"
        Me.txtTitulo.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(239, Byte), Integer))
        Me.txtTitulo.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTitulo.Properties.Appearance.ForeColor = System.Drawing.Color.Black
        Me.txtTitulo.Properties.Appearance.Options.UseBackColor = True
        Me.txtTitulo.Properties.Appearance.Options.UseFont = True
        Me.txtTitulo.Properties.Appearance.Options.UseForeColor = True
        Me.txtTitulo.Properties.Appearance.Options.UseTextOptions = True
        Me.txtTitulo.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.txtTitulo.Size = New System.Drawing.Size(652, 24)
        Me.txtTitulo.TabIndex = 18
        '
        'btnOk
        '
        Me.btnOk.BackColor = System.Drawing.Color.Transparent
        Me.btnOk.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnOk.Image = CType(resources.GetObject("btnOk.Image"), System.Drawing.Image)
        Me.btnOk.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.btnOk.Location = New System.Drawing.Point(544, 213)
        Me.btnOk.Name = "btnOk"
        Me.btnOk.Size = New System.Drawing.Size(89, 33)
        Me.btnOk.TabIndex = 16
        Me.btnOk.Text = "OK"
        Me.btnOk.UseVisualStyleBackColor = False
        '
        'MessageDetails
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(652, 248)
        Me.Controls.Add(Me.txtDetalhe)
        Me.Controls.Add(Me.txtTitulo)
        Me.Controls.Add(Me.btnOk)
        Me.IconOptions.ShowIcon = False
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "MessageDetails"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Detalhes"
        CType(Me.txtTitulo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtDetalhe As TextBox
    Friend WithEvents txtTitulo As DevExpress.XtraEditors.TextEdit
    Friend WithEvents btnOk As Button
End Class
