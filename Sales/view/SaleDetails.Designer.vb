<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class SaleDetails
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SaleDetails))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.txtTotal = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnPrint = New DevExpress.XtraEditors.SimpleButton()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtCpf = New System.Windows.Forms.MaskedTextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtTelephone = New System.Windows.Forms.MaskedTextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.btnClose = New DevExpress.XtraEditors.SimpleButton()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtZipCode = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtDistrict = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtCity = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtComplement = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtNumber = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtPublicPlace = New System.Windows.Forms.TextBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.dgvProducts = New System.Windows.Forms.DataGridView()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.VALOR = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TOTAL = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.dgvProducts, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtTotal
        '
        Me.txtTotal.BackColor = System.Drawing.Color.DarkGray
        Me.txtTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtTotal.Enabled = False
        Me.txtTotal.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotal.Location = New System.Drawing.Point(378, 19)
        Me.txtTotal.Margin = New System.Windows.Forms.Padding(1)
        Me.txtTotal.Name = "txtTotal"
        Me.txtTotal.Size = New System.Drawing.Size(130, 33)
        Me.txtTotal.TabIndex = 697
        Me.txtTotal.TabStop = False
        Me.txtTotal.Text = "0,00"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(174, 23)
        Me.Label3.Margin = New System.Windows.Forms.Padding(1)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(146, 25)
        Me.Label3.TabIndex = 696
        Me.Label3.Text = "Valor total R$:"
        '
        'btnPrint
        '
        Me.btnPrint.ImageOptions.Image = CType(resources.GetObject("btnPrint.ImageOptions.Image"), System.Drawing.Image)
        Me.btnPrint.Location = New System.Drawing.Point(10, 370)
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Size = New System.Drawing.Size(222, 32)
        Me.btnPrint.TabIndex = 4
        Me.btnPrint.Text = "IMPRIMIR"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Label9)
        Me.Panel1.Controls.Add(Me.txtCpf)
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Controls.Add(Me.txtTelephone)
        Me.Panel1.Controls.Add(Me.Label17)
        Me.Panel1.Controls.Add(Me.Label10)
        Me.Panel1.Controls.Add(Me.txtEmail)
        Me.Panel1.Controls.Add(Me.Label11)
        Me.Panel1.Controls.Add(Me.txtName)
        Me.Panel1.Controls.Add(Me.btnClose)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.txtZipCode)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.txtDistrict)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.txtCity)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.txtComplement)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.txtNumber)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.txtPublicPlace)
        Me.Panel1.Controls.Add(Me.btnPrint)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel1.Location = New System.Drawing.Point(517, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(468, 417)
        Me.Panel1.TabIndex = 699
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(147, 10)
        Me.Label9.Margin = New System.Windows.Forms.Padding(1)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(204, 25)
        Me.Label9.TabIndex = 721
        Me.Label9.Text = "DADOS DO CLIENTE"
        '
        'txtCpf
        '
        Me.txtCpf.BackColor = System.Drawing.Color.DarkGray
        Me.txtCpf.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCpf.Enabled = False
        Me.txtCpf.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.txtCpf.Location = New System.Drawing.Point(89, 117)
        Me.txtCpf.Margin = New System.Windows.Forms.Padding(2)
        Me.txtCpf.Mask = "000.000.000-00"
        Me.txtCpf.Name = "txtCpf"
        Me.txtCpf.Size = New System.Drawing.Size(141, 20)
        Me.txtCpf.TabIndex = 719
        Me.txtCpf.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label8.Location = New System.Drawing.Point(15, 121)
        Me.Label8.Margin = New System.Windows.Forms.Padding(2)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(26, 13)
        Me.Label8.TabIndex = 720
        Me.Label8.Text = "Cpf:"
        '
        'txtTelephone
        '
        Me.txtTelephone.BackColor = System.Drawing.Color.DarkGray
        Me.txtTelephone.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtTelephone.Enabled = False
        Me.txtTelephone.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.txtTelephone.Location = New System.Drawing.Point(89, 96)
        Me.txtTelephone.Margin = New System.Windows.Forms.Padding(2)
        Me.txtTelephone.Mask = "(00) 00000-0000"
        Me.txtTelephone.Name = "txtTelephone"
        Me.txtTelephone.Size = New System.Drawing.Size(141, 20)
        Me.txtTelephone.TabIndex = 714
        Me.txtTelephone.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.BackColor = System.Drawing.Color.Transparent
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label17.Location = New System.Drawing.Point(15, 100)
        Me.Label17.Margin = New System.Windows.Forms.Padding(2)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(52, 13)
        Me.Label17.TabIndex = 717
        Me.Label17.Text = "Telefone:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.Label10.Location = New System.Drawing.Point(15, 76)
        Me.Label10.Margin = New System.Windows.Forms.Padding(1)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(39, 13)
        Me.Label10.TabIndex = 716
        Me.Label10.Text = "E-mail:"
        '
        'txtEmail
        '
        Me.txtEmail.BackColor = System.Drawing.Color.DarkGray
        Me.txtEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtEmail.Enabled = False
        Me.txtEmail.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.txtEmail.Location = New System.Drawing.Point(89, 72)
        Me.txtEmail.Margin = New System.Windows.Forms.Padding(1)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(363, 21)
        Me.txtEmail.TabIndex = 712
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.Label11.Location = New System.Drawing.Point(15, 53)
        Me.Label11.Margin = New System.Windows.Forms.Padding(1)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(38, 13)
        Me.Label11.TabIndex = 715
        Me.Label11.Text = "Nome:"
        '
        'txtName
        '
        Me.txtName.BackColor = System.Drawing.Color.DarkGray
        Me.txtName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtName.Enabled = False
        Me.txtName.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.txtName.Location = New System.Drawing.Point(89, 49)
        Me.txtName.Margin = New System.Windows.Forms.Padding(1)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(363, 21)
        Me.txtName.TabIndex = 711
        '
        'btnClose
        '
        Me.btnClose.ImageOptions.Image = CType(resources.GetObject("btnClose.ImageOptions.Image"), System.Drawing.Image)
        Me.btnClose.Location = New System.Drawing.Point(238, 370)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(220, 32)
        Me.btnClose.TabIndex = 707
        Me.btnClose.Text = "SAIR"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.Label7.Location = New System.Drawing.Point(272, 212)
        Me.Label7.Margin = New System.Windows.Forms.Padding(1)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(30, 13)
        Me.Label7.TabIndex = 706
        Me.Label7.Text = "CEP:"
        '
        'txtZipCode
        '
        Me.txtZipCode.BackColor = System.Drawing.Color.DarkGray
        Me.txtZipCode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtZipCode.Enabled = False
        Me.txtZipCode.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.txtZipCode.Location = New System.Drawing.Point(304, 208)
        Me.txtZipCode.Margin = New System.Windows.Forms.Padding(1)
        Me.txtZipCode.Name = "txtZipCode"
        Me.txtZipCode.Size = New System.Drawing.Size(148, 21)
        Me.txtZipCode.TabIndex = 705
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.Label5.Location = New System.Drawing.Point(15, 212)
        Me.Label5.Margin = New System.Windows.Forms.Padding(1)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(44, 13)
        Me.Label5.TabIndex = 704
        Me.Label5.Text = "Estado:"
        '
        'txtDistrict
        '
        Me.txtDistrict.BackColor = System.Drawing.Color.DarkGray
        Me.txtDistrict.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtDistrict.Enabled = False
        Me.txtDistrict.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.txtDistrict.Location = New System.Drawing.Point(89, 208)
        Me.txtDistrict.Margin = New System.Windows.Forms.Padding(1)
        Me.txtDistrict.Name = "txtDistrict"
        Me.txtDistrict.Size = New System.Drawing.Size(173, 21)
        Me.txtDistrict.TabIndex = 703
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.Label6.Location = New System.Drawing.Point(15, 189)
        Me.Label6.Margin = New System.Windows.Forms.Padding(1)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(44, 13)
        Me.Label6.TabIndex = 702
        Me.Label6.Text = "Cidade:"
        '
        'txtCity
        '
        Me.txtCity.BackColor = System.Drawing.Color.DarkGray
        Me.txtCity.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCity.Enabled = False
        Me.txtCity.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.txtCity.Location = New System.Drawing.Point(89, 185)
        Me.txtCity.Margin = New System.Windows.Forms.Padding(1)
        Me.txtCity.Name = "txtCity"
        Me.txtCity.Size = New System.Drawing.Size(363, 21)
        Me.txtCity.TabIndex = 701
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.Label4.Location = New System.Drawing.Point(186, 166)
        Me.Label4.Margin = New System.Windows.Forms.Padding(1)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(76, 13)
        Me.Label4.TabIndex = 700
        Me.Label4.Text = "Complemento:"
        '
        'txtComplement
        '
        Me.txtComplement.BackColor = System.Drawing.Color.DarkGray
        Me.txtComplement.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtComplement.Enabled = False
        Me.txtComplement.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.txtComplement.Location = New System.Drawing.Point(264, 162)
        Me.txtComplement.Margin = New System.Windows.Forms.Padding(1)
        Me.txtComplement.Name = "txtComplement"
        Me.txtComplement.Size = New System.Drawing.Size(188, 21)
        Me.txtComplement.TabIndex = 699
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.Label2.Location = New System.Drawing.Point(15, 166)
        Me.Label2.Margin = New System.Windows.Forms.Padding(1)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(48, 13)
        Me.Label2.TabIndex = 698
        Me.Label2.Text = "Número:"
        '
        'txtNumber
        '
        Me.txtNumber.BackColor = System.Drawing.Color.DarkGray
        Me.txtNumber.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtNumber.Enabled = False
        Me.txtNumber.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.txtNumber.Location = New System.Drawing.Point(89, 162)
        Me.txtNumber.Margin = New System.Windows.Forms.Padding(1)
        Me.txtNumber.Name = "txtNumber"
        Me.txtNumber.Size = New System.Drawing.Size(91, 21)
        Me.txtNumber.TabIndex = 697
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.Label1.Location = New System.Drawing.Point(15, 143)
        Me.Label1.Margin = New System.Windows.Forms.Padding(1)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(56, 13)
        Me.Label1.TabIndex = 696
        Me.Label1.Text = "Endereço:"
        '
        'txtPublicPlace
        '
        Me.txtPublicPlace.BackColor = System.Drawing.Color.DarkGray
        Me.txtPublicPlace.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtPublicPlace.Enabled = False
        Me.txtPublicPlace.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.txtPublicPlace.Location = New System.Drawing.Point(89, 139)
        Me.txtPublicPlace.Margin = New System.Windows.Forms.Padding(1)
        Me.txtPublicPlace.Name = "txtPublicPlace"
        Me.txtPublicPlace.Size = New System.Drawing.Size(363, 21)
        Me.txtPublicPlace.TabIndex = 695
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.dgvProducts)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(517, 345)
        Me.Panel2.TabIndex = 700
        '
        'dgvProducts
        '
        Me.dgvProducts.AllowUserToAddRows = False
        Me.dgvProducts.AllowUserToDeleteRows = False
        Me.dgvProducts.BackgroundColor = System.Drawing.Color.DimGray
        Me.dgvProducts.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.DimGray
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Tahoma", 8.25!)
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Gray
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvProducts.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvProducts.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.VALOR, Me.TOTAL})
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.DimGray
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(53, Byte), Integer))
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Gray
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvProducts.DefaultCellStyle = DataGridViewCellStyle2
        Me.dgvProducts.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvProducts.EnableHeadersVisualStyles = False
        Me.dgvProducts.Location = New System.Drawing.Point(0, 0)
        Me.dgvProducts.MultiSelect = False
        Me.dgvProducts.Name = "dgvProducts"
        Me.dgvProducts.ReadOnly = True
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Tahoma", 8.25!)
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.LightSalmon
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvProducts.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.dgvProducts.RowHeadersVisible = False
        Me.dgvProducts.RowHeadersWidth = 22
        Me.dgvProducts.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.LightSalmon
        Me.dgvProducts.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.White
        Me.dgvProducts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvProducts.Size = New System.Drawing.Size(517, 345)
        Me.dgvProducts.StandardTab = True
        Me.dgvProducts.TabIndex = 687
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.txtTotal)
        Me.Panel3.Controls.Add(Me.Label3)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel3.Location = New System.Drawing.Point(0, 351)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(517, 66)
        Me.Panel3.TabIndex = 701
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "id"
        Me.DataGridViewTextBoxColumn2.HeaderText = "ID"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        Me.DataGridViewTextBoxColumn2.Width = 50
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "item"
        Me.DataGridViewTextBoxColumn3.HeaderText = "PRODUCT_ID"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        Me.DataGridViewTextBoxColumn3.Visible = False
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "title"
        Me.DataGridViewTextBoxColumn5.HeaderText = "PRODUTO"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.ReadOnly = True
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "quantity"
        Me.DataGridViewTextBoxColumn6.HeaderText = "QUANTIDADE"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.ReadOnly = True
        '
        'VALOR
        '
        Me.VALOR.DataPropertyName = "price"
        Me.VALOR.HeaderText = "VALOR"
        Me.VALOR.Name = "VALOR"
        Me.VALOR.ReadOnly = True
        '
        'TOTAL
        '
        Me.TOTAL.DataPropertyName = "total_price"
        Me.TOTAL.HeaderText = "TOTAL"
        Me.TOTAL.Name = "TOTAL"
        Me.TOTAL.ReadOnly = True
        Me.TOTAL.Visible = False
        Me.TOTAL.Width = 80
        '
        'SaleDetails
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(985, 417)
        Me.ControlBox = False
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "SaleDetails"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Detalhes da Venda"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        CType(Me.dgvProducts, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents txtTotal As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents btnPrint As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents dgvProducts As DataGridView
    Friend WithEvents Label7 As Label
    Friend WithEvents txtZipCode As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtDistrict As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txtCity As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtComplement As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtNumber As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtPublicPlace As TextBox
    Friend WithEvents btnClose As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents Label9 As Label
    Friend WithEvents txtCpf As MaskedTextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents txtTelephone As MaskedTextBox
    Friend WithEvents Label17 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents txtName As TextBox
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents VALOR As DataGridViewTextBoxColumn
    Friend WithEvents TOTAL As DataGridViewTextBoxColumn
End Class
