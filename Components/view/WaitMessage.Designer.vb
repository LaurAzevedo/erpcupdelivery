<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class WaitMessage
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(WaitMessage))
        Me.DlgCor = New System.Windows.Forms.ColorDialog()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ProgressPanel1 = New DevExpress.XtraWaitForm.ProgressPanel()
        Me.FormAssistant1 = New DevExpress.XtraBars.FormAssistant()
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.SuspendLayout()
        '
        'Timer1
        '
        Me.Timer1.Interval = 500
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 178)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(39, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Label1"
        '
        'ProgressPanel1
        '
        Me.ProgressPanel1.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.ProgressPanel1.Appearance.Font = New System.Drawing.Font("Tahoma", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ProgressPanel1.Appearance.Options.UseBackColor = True
        Me.ProgressPanel1.Appearance.Options.UseFont = True
        Me.ProgressPanel1.Appearance.Options.UseTextOptions = True
        Me.ProgressPanel1.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ProgressPanel1.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.ProgressPanel1.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.ProgressPanel1.AppearanceCaption.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ProgressPanel1.AppearanceCaption.Options.UseFont = True
        Me.ProgressPanel1.AppearanceCaption.Options.UseTextOptions = True
        Me.ProgressPanel1.AppearanceCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ProgressPanel1.AppearanceCaption.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.ProgressPanel1.AppearanceCaption.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.ProgressPanel1.AppearanceDescription.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ProgressPanel1.AppearanceDescription.Options.UseFont = True
        Me.ProgressPanel1.AppearanceDescription.Options.UseTextOptions = True
        Me.ProgressPanel1.AppearanceDescription.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ProgressPanel1.AppearanceDescription.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.ProgressPanel1.AppearanceDescription.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.ProgressPanel1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003
        Me.ProgressPanel1.Caption = ""
        Me.ProgressPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ProgressPanel1.Location = New System.Drawing.Point(0, 0)
        Me.ProgressPanel1.Name = "ProgressPanel1"
        Me.ProgressPanel1.ShowCaption = False
        Me.ProgressPanel1.Size = New System.Drawing.Size(449, 143)
        Me.ProgressPanel1.TabIndex = 3
        Me.ProgressPanel1.Text = "ProgressPanel1"
        '
        'Timer2
        '
        Me.Timer2.Interval = 500
        '
        'msg_aguarde
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(449, 143)
        Me.ControlBox = False
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ProgressPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.IconOptions.LargeImage = CType(resources.GetObject("msg_aguarde.IconOptions.LargeImage"), System.Drawing.Image)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "msg_aguarde"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Aguarde..."
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DlgCor As ColorDialog
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Label1 As Label
    Friend WithEvents ProgressPanel1 As DevExpress.XtraWaitForm.ProgressPanel
    Friend WithEvents FormAssistant1 As DevExpress.XtraBars.FormAssistant
    Friend WithEvents Timer2 As Timer
End Class
