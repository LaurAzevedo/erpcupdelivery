<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class data_final
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(data_final))
        Me.dta_final = New CupDelivery.txtdata()
        Me.Button1 = New DevExpress.XtraEditors.SimpleButton()
        Me.SuspendLayout()
        '
        'dta_final
        '
        Me.dta_final.Location = New System.Drawing.Point(18, 16)
        Me.dta_final.Name = "dta_final"
        Me.dta_final.Size = New System.Drawing.Size(82, 22)
        Me.dta_final.TabIndex = 0
        '
        'Button1
        '
        Me.Button1.ImageOptions.Image = CType(resources.GetObject("Button1.ImageOptions.Image"), System.Drawing.Image)
        Me.Button1.Location = New System.Drawing.Point(103, 16)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(23, 23)
        Me.Button1.TabIndex = 8921
        '
        'data_final
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(131, 56)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.dta_final)
        Me.IconOptions.ShowIcon = False
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "data_final"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Data Final"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents dta_final As txtdata
    Friend WithEvents Button1 As DevExpress.XtraEditors.SimpleButton
End Class
