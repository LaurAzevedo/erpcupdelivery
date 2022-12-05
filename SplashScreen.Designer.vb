<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class SplashScreen
    Inherits DevExpress.XtraEditors.XtraForm

    'Descartar substituições de formulário para limpar a lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SplashScreen))
        Me.ProgressPanel2 = New DevExpress.XtraWaitForm.ProgressPanel()
        Me.TimerSplash = New System.Windows.Forms.Timer(Me.components)
        Me.TimerConnection = New System.Windows.Forms.Timer(Me.components)
        Me.SuspendLayout()
        '
        'ProgressPanel2
        '
        Me.ProgressPanel2.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.ProgressPanel2.Appearance.Options.UseBackColor = True
        Me.ProgressPanel2.Caption = "Aguarde"
        Me.ProgressPanel2.Description = "Conectando ..."
        Me.ProgressPanel2.Location = New System.Drawing.Point(88, 27)
        Me.ProgressPanel2.Name = "ProgressPanel2"
        Me.ProgressPanel2.Size = New System.Drawing.Size(172, 81)
        Me.ProgressPanel2.TabIndex = 1
        Me.ProgressPanel2.Text = "ProgressPanel2"
        '
        'TimerSplash
        '
        Me.TimerSplash.Interval = 1000
        '
        'TimerConnection
        '
        Me.TimerConnection.Interval = 2000
        '
        'SplashScreen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(298, 119)
        Me.ControlBox = False
        Me.Controls.Add(Me.ProgressPanel2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.IconOptions.LargeImage = CType(resources.GetObject("SplashScreen.IconOptions.LargeImage"), System.Drawing.Image)
        Me.IconOptions.ShowIcon = False
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "SplashScreen"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cup Delivery"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ProgressPanel2 As DevExpress.XtraWaitForm.ProgressPanel
    Friend WithEvents TimerSplash As Timer
    Friend WithEvents TimerConnection As Timer
End Class
