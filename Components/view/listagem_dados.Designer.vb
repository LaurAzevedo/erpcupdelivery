<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class listagem_Dados
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(listagem_Dados))
        Me.textbox6 = New CupDelivery.txtdecimal()
        Me.btnLocalizar = New DevExpress.XtraEditors.SimpleButton()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txtFiltroPrincipal = New System.Windows.Forms.TextBox()
        Me.dgvListaDados = New System.Windows.Forms.DataGridView()
        Me.dg_lista = New System.Windows.Forms.DataGridView()
        Me.bt_desmarca_todos_1 = New DevExpress.XtraEditors.SimpleButton()
        Me.bt_marca_todos_1 = New DevExpress.XtraEditors.SimpleButton()
        Me.bt_selecionar = New DevExpress.XtraEditors.SimpleButton()
        Me.txtFiltro = New System.Windows.Forms.TextBox()
        Me.FormAssistant1 = New DevExpress.XtraBars.FormAssistant()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cmbCampo = New System.Windows.Forms.ComboBox()
        Me.DlgCor = New System.Windows.Forms.ColorDialog()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        CType(Me.dgvListaDados, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dg_lista, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'textbox6
        '
        Me.textbox6.BackColor = System.Drawing.Color.DimGray
        Me.textbox6.casasdecimais = 0
        Me.textbox6.editavel = True
        Me.textbox6.Location = New System.Drawing.Point(274, 627)
        Me.textbox6.Name = "textbox6"
        Me.textbox6.Size = New System.Drawing.Size(71, 22)
        Me.textbox6.TabIndex = 0
        Me.textbox6.tamanho = 0
        Me.textbox6.Visible = False
        '
        'btnLocalizar
        '
        Me.btnLocalizar.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLocalizar.Appearance.Options.UseFont = True
        Me.btnLocalizar.Location = New System.Drawing.Point(538, 1)
        Me.btnLocalizar.Name = "btnLocalizar"
        Me.btnLocalizar.Size = New System.Drawing.Size(95, 26)
        Me.btnLocalizar.TabIndex = 10011
        Me.btnLocalizar.Text = "Localizar"
        '
        'Column1
        '
        Me.Column1.HeaderText = "Column1"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        '
        'txtFiltroPrincipal
        '
        Me.txtFiltroPrincipal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtFiltroPrincipal.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFiltroPrincipal.Location = New System.Drawing.Point(641, 3)
        Me.txtFiltroPrincipal.Name = "txtFiltroPrincipal"
        Me.txtFiltroPrincipal.Size = New System.Drawing.Size(36, 20)
        Me.txtFiltroPrincipal.TabIndex = 10005
        Me.txtFiltroPrincipal.Visible = False
        '
        'dgvListaDados
        '
        Me.dgvListaDados.AllowUserToAddRows = False
        Me.dgvListaDados.AllowUserToDeleteRows = False
        Me.dgvListaDados.BackgroundColor = System.Drawing.Color.DimGray
        Me.dgvListaDados.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.DimGray
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Tahoma", 8.25!)
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Gray
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvListaDados.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvListaDados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.DimGray
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer))
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Gray
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvListaDados.DefaultCellStyle = DataGridViewCellStyle2
        Me.dgvListaDados.EnableHeadersVisualStyles = False
        Me.dgvListaDados.Location = New System.Drawing.Point(0, 30)
        Me.dgvListaDados.Name = "dgvListaDados"
        Me.dgvListaDados.ReadOnly = True
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.DimGray
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Tahoma", 8.25!)
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.LightSalmon
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvListaDados.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.dgvListaDados.RowHeadersWidth = 22
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.LightSalmon
        Me.dgvListaDados.RowsDefaultCellStyle = DataGridViewCellStyle4
        Me.dgvListaDados.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.DimGray
        Me.dgvListaDados.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.LightSalmon
        Me.dgvListaDados.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.dgvListaDados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvListaDados.Size = New System.Drawing.Size(633, 594)
        Me.dgvListaDados.TabIndex = 10003
        '
        'dg_lista
        '
        Me.dg_lista.AllowUserToAddRows = False
        Me.dg_lista.AllowUserToDeleteRows = False
        Me.dg_lista.BackgroundColor = System.Drawing.Color.White
        Me.dg_lista.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(186, Byte), Integer))
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Tahoma", 8.25!)
        DataGridViewCellStyle5.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dg_lista.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle5
        Me.dg_lista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dg_lista.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1})
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer))
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dg_lista.DefaultCellStyle = DataGridViewCellStyle6
        Me.dg_lista.EnableHeadersVisualStyles = False
        Me.dg_lista.Location = New System.Drawing.Point(674, 47)
        Me.dg_lista.Name = "dg_lista"
        Me.dg_lista.ReadOnly = True
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Tahoma", 8.25!)
        DataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.LightSalmon
        DataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dg_lista.RowHeadersDefaultCellStyle = DataGridViewCellStyle7
        Me.dg_lista.RowHeadersWidth = 22
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.LightSalmon
        Me.dg_lista.RowsDefaultCellStyle = DataGridViewCellStyle8
        Me.dg_lista.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.LightSalmon
        Me.dg_lista.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.dg_lista.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dg_lista.Size = New System.Drawing.Size(214, 461)
        Me.dg_lista.TabIndex = 10010
        '
        'bt_desmarca_todos_1
        '
        Me.bt_desmarca_todos_1.ImageOptions.Image = CType(resources.GetObject("bt_desmarca_todos_1.ImageOptions.Image"), System.Drawing.Image)
        Me.bt_desmarca_todos_1.Location = New System.Drawing.Point(34, 628)
        Me.bt_desmarca_todos_1.Name = "bt_desmarca_todos_1"
        Me.bt_desmarca_todos_1.Size = New System.Drawing.Size(24, 21)
        Me.bt_desmarca_todos_1.TabIndex = 10009
        '
        'bt_marca_todos_1
        '
        Me.bt_marca_todos_1.ImageOptions.Image = CType(resources.GetObject("bt_marca_todos_1.ImageOptions.Image"), System.Drawing.Image)
        Me.bt_marca_todos_1.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleLeft
        Me.bt_marca_todos_1.Location = New System.Drawing.Point(5, 628)
        Me.bt_marca_todos_1.Name = "bt_marca_todos_1"
        Me.bt_marca_todos_1.Size = New System.Drawing.Size(23, 21)
        Me.bt_marca_todos_1.TabIndex = 10008
        '
        'bt_selecionar
        '
        Me.bt_selecionar.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bt_selecionar.Appearance.Options.UseFont = True
        Me.bt_selecionar.ImageOptions.Image = CType(resources.GetObject("bt_selecionar.ImageOptions.Image"), System.Drawing.Image)
        Me.bt_selecionar.Location = New System.Drawing.Point(536, 625)
        Me.bt_selecionar.Name = "bt_selecionar"
        Me.bt_selecionar.Size = New System.Drawing.Size(95, 26)
        Me.bt_selecionar.TabIndex = 10007
        Me.bt_selecionar.Text = "Selecionar"
        '
        'txtFiltro
        '
        Me.txtFiltro.BackColor = System.Drawing.Color.DarkGray
        Me.txtFiltro.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtFiltro.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFiltro.Location = New System.Drawing.Point(210, 0)
        Me.txtFiltro.Name = "txtFiltro"
        Me.txtFiltro.Size = New System.Drawing.Size(321, 27)
        Me.txtFiltro.TabIndex = 10001
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(237, 632)
        Me.Label9.Margin = New System.Windows.Forms.Padding(1)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(34, 13)
        Me.Label9.TabIndex = 10006
        Me.Label9.Text = "Total:"
        Me.Label9.Visible = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(4, 7)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(67, 13)
        Me.Label3.TabIndex = 10004
        Me.Label3.Text = "Campo Filtro"
        '
        'cmbCampo
        '
        Me.cmbCampo.BackColor = System.Drawing.Color.DimGray
        Me.cmbCampo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbCampo.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbCampo.FormattingEnabled = True
        Me.cmbCampo.Location = New System.Drawing.Point(74, 3)
        Me.cmbCampo.Name = "cmbCampo"
        Me.cmbCampo.Size = New System.Drawing.Size(130, 21)
        Me.cmbCampo.TabIndex = 10002
        '
        'Timer1
        '
        '
        'listagem_Dados
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(633, 624)
        Me.Controls.Add(Me.btnLocalizar)
        Me.Controls.Add(Me.txtFiltroPrincipal)
        Me.Controls.Add(Me.dgvListaDados)
        Me.Controls.Add(Me.dg_lista)
        Me.Controls.Add(Me.bt_desmarca_todos_1)
        Me.Controls.Add(Me.bt_marca_todos_1)
        Me.Controls.Add(Me.bt_selecionar)
        Me.Controls.Add(Me.txtFiltro)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.cmbCampo)
        Me.Controls.Add(Me.textbox6)
        Me.IconOptions.ShowIcon = False
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "listagem_Dados"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Lista de dados"
        CType(Me.dgvListaDados, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dg_lista, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents textbox6 As txtdecimal
    Friend WithEvents btnLocalizar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents txtFiltroPrincipal As TextBox
    Friend WithEvents dgvListaDados As DataGridView
    Friend WithEvents dg_lista As DataGridView
    Friend WithEvents bt_desmarca_todos_1 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents bt_marca_todos_1 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents bt_selecionar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txtFiltro As TextBox
    Friend WithEvents FormAssistant1 As DevExpress.XtraBars.FormAssistant
    Friend WithEvents Label9 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents cmbCampo As ComboBox
    Friend WithEvents DlgCor As ColorDialog
    Friend WithEvents Timer1 As Timer
End Class
