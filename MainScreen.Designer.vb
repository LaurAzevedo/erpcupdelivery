<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MainScreen
    Inherits DevExpress.XtraBars.Ribbon.RibbonForm

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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainScreen))
        Me.RibbonControl1 = New DevExpress.XtraBars.Ribbon.RibbonControl()
        Me.SkinDropDownButtonItem1 = New DevExpress.XtraBars.SkinDropDownButtonItem()
        Me.SkinDropDownButtonItem2 = New DevExpress.XtraBars.SkinDropDownButtonItem()
        Me.SkinPaletteDropDownButtonItem1 = New DevExpress.XtraBars.SkinPaletteDropDownButtonItem()
        Me.btnUsers = New DevExpress.XtraBars.BarButtonItem()
        Me.btnProducts = New DevExpress.XtraBars.BarButtonItem()
        Me.btnCustomers = New DevExpress.XtraBars.BarButtonItem()
        Me.btnSales = New DevExpress.XtraBars.BarButtonItem()
        Me.RibbonPage1 = New DevExpress.XtraBars.Ribbon.RibbonPage()
        Me.RibbonPageGroup1 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.RibbonPageGroup7 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.RibbonPageGroup4 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.RibbonPageGroup8 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.RibbonPage2 = New DevExpress.XtraBars.Ribbon.RibbonPage()
        Me.DlgCor = New System.Windows.Forms.ColorDialog()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.StatusStrip2 = New System.Windows.Forms.StatusStrip()
        Me.lblEmpresa = New System.Windows.Forms.ToolStripStatusLabel()
        Me.lblDataHora = New System.Windows.Forms.ToolStripStatusLabel()
        Me.timerHour = New System.Windows.Forms.Timer(Me.components)
        Me.cmbTema = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.DefaultLookAndFeel1 = New DevExpress.LookAndFeel.DefaultLookAndFeel(Me.components)
        Me.FormAssistant1 = New DevExpress.XtraBars.FormAssistant()
        Me.TimerStatus = New System.Windows.Forms.Timer(Me.components)
        Me.ApplicationMenu1 = New DevExpress.XtraBars.Ribbon.ApplicationMenu(Me.components)
        Me.TimerCheckConnection = New System.Windows.Forms.Timer(Me.components)
        Me.TimerBackend = New System.Windows.Forms.Timer(Me.components)
        CType(Me.RibbonControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.StatusStrip2.SuspendLayout()
        CType(Me.ApplicationMenu1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'RibbonControl1
        '
        Me.RibbonControl1.ExpandCollapseItem.Id = 0
        Me.RibbonControl1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.RibbonControl1.ExpandCollapseItem, Me.RibbonControl1.SearchEditItem, Me.SkinDropDownButtonItem1, Me.SkinDropDownButtonItem2, Me.SkinPaletteDropDownButtonItem1, Me.btnUsers, Me.btnProducts, Me.btnCustomers, Me.btnSales})
        Me.RibbonControl1.Location = New System.Drawing.Point(0, 0)
        Me.RibbonControl1.MaxItemId = 20
        Me.RibbonControl1.Name = "RibbonControl1"
        Me.RibbonControl1.Pages.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPage() {Me.RibbonPage1})
        Me.RibbonControl1.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.Office2013
        Me.RibbonControl1.ShowApplicationButton = DevExpress.Utils.DefaultBoolean.[False]
        Me.RibbonControl1.ShowDisplayOptionsMenuButton = DevExpress.Utils.DefaultBoolean.[False]
        Me.RibbonControl1.ShowToolbarCustomizeItem = False
        Me.RibbonControl1.Size = New System.Drawing.Size(1000, 143)
        Me.RibbonControl1.Toolbar.ShowCustomizeItem = False
        Me.RibbonControl1.ToolbarLocation = DevExpress.XtraBars.Ribbon.RibbonQuickAccessToolbarLocation.Hidden
        '
        'SkinDropDownButtonItem1
        '
        Me.SkinDropDownButtonItem1.Id = 1
        Me.SkinDropDownButtonItem1.Name = "SkinDropDownButtonItem1"
        '
        'SkinDropDownButtonItem2
        '
        Me.SkinDropDownButtonItem2.Id = 2
        Me.SkinDropDownButtonItem2.Name = "SkinDropDownButtonItem2"
        '
        'SkinPaletteDropDownButtonItem1
        '
        Me.SkinPaletteDropDownButtonItem1.Enabled = False
        Me.SkinPaletteDropDownButtonItem1.Id = 3
        Me.SkinPaletteDropDownButtonItem1.Name = "SkinPaletteDropDownButtonItem1"
        '
        'btnUsers
        '
        Me.btnUsers.Caption = "Usuários"
        Me.btnUsers.Id = 6
        Me.btnUsers.ImageOptions.Image = CType(resources.GetObject("btnUsers.ImageOptions.Image"), System.Drawing.Image)
        Me.btnUsers.ImageOptions.LargeImage = CType(resources.GetObject("btnUsers.ImageOptions.LargeImage"), System.Drawing.Image)
        Me.btnUsers.Name = "btnUsers"
        '
        'btnProducts
        '
        Me.btnProducts.Caption = "Produtos"
        Me.btnProducts.Id = 9
        Me.btnProducts.ImageOptions.Image = CType(resources.GetObject("btnProducts.ImageOptions.Image"), System.Drawing.Image)
        Me.btnProducts.ImageOptions.LargeImage = CType(resources.GetObject("btnProducts.ImageOptions.LargeImage"), System.Drawing.Image)
        Me.btnProducts.Name = "btnProducts"
        '
        'btnCustomers
        '
        Me.btnCustomers.Caption = "Clientes"
        Me.btnCustomers.Id = 15
        Me.btnCustomers.ImageOptions.Image = CType(resources.GetObject("btnCustomers.ImageOptions.Image"), System.Drawing.Image)
        Me.btnCustomers.ImageOptions.LargeImage = CType(resources.GetObject("btnCustomers.ImageOptions.LargeImage"), System.Drawing.Image)
        Me.btnCustomers.Name = "btnCustomers"
        '
        'btnSales
        '
        Me.btnSales.Caption = "Vendas"
        Me.btnSales.Id = 19
        Me.btnSales.ImageOptions.Image = CType(resources.GetObject("btnSales.ImageOptions.Image"), System.Drawing.Image)
        Me.btnSales.ImageOptions.LargeImage = CType(resources.GetObject("btnSales.ImageOptions.LargeImage"), System.Drawing.Image)
        Me.btnSales.Name = "btnSales"
        '
        'RibbonPage1
        '
        Me.RibbonPage1.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() {Me.RibbonPageGroup1, Me.RibbonPageGroup7, Me.RibbonPageGroup4, Me.RibbonPageGroup8})
        Me.RibbonPage1.Name = "RibbonPage1"
        Me.RibbonPage1.Text = "Cup Delivery"
        '
        'RibbonPageGroup1
        '
        Me.RibbonPageGroup1.ItemLinks.Add(Me.btnUsers)
        Me.RibbonPageGroup1.Name = "RibbonPageGroup1"
        Me.RibbonPageGroup1.Text = "Empresa"
        '
        'RibbonPageGroup7
        '
        Me.RibbonPageGroup7.ItemLinks.Add(Me.btnCustomers)
        Me.RibbonPageGroup7.Name = "RibbonPageGroup7"
        Me.RibbonPageGroup7.Text = "Pessoas"
        '
        'RibbonPageGroup4
        '
        Me.RibbonPageGroup4.ItemLinks.Add(Me.btnProducts)
        Me.RibbonPageGroup4.Name = "RibbonPageGroup4"
        Me.RibbonPageGroup4.Text = "Produtos"
        '
        'RibbonPageGroup8
        '
        Me.RibbonPageGroup8.ItemLinks.Add(Me.btnSales)
        Me.RibbonPageGroup8.Name = "RibbonPageGroup8"
        Me.RibbonPageGroup8.Text = "Caixa"
        '
        'RibbonPage2
        '
        Me.RibbonPage2.Name = "RibbonPage2"
        Me.RibbonPage2.Text = "RibbonPage2"
        '
        'StatusStrip1
        '
        Me.StatusStrip1.BackColor = System.Drawing.Color.DimGray
        Me.StatusStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 623)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(1000, 22)
        Me.StatusStrip1.TabIndex = 54
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'StatusStrip2
        '
        Me.StatusStrip2.AutoSize = False
        Me.StatusStrip2.BackColor = System.Drawing.Color.DimGray
        Me.StatusStrip2.Dock = System.Windows.Forms.DockStyle.Top
        Me.StatusStrip2.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.StatusStrip2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.lblEmpresa, Me.lblDataHora})
        Me.StatusStrip2.Location = New System.Drawing.Point(0, 143)
        Me.StatusStrip2.Name = "StatusStrip2"
        Me.StatusStrip2.Size = New System.Drawing.Size(1000, 19)
        Me.StatusStrip2.TabIndex = 55
        Me.StatusStrip2.Text = "StatusStrip2"
        '
        'lblEmpresa
        '
        Me.lblEmpresa.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEmpresa.ForeColor = System.Drawing.Color.White
        Me.lblEmpresa.Name = "lblEmpresa"
        Me.lblEmpresa.Size = New System.Drawing.Size(74, 14)
        Me.lblEmpresa.Text = "Cup Delivery"
        '
        'lblDataHora
        '
        Me.lblDataHora.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDataHora.ForeColor = System.Drawing.Color.White
        Me.lblDataHora.Name = "lblDataHora"
        Me.lblDataHora.Size = New System.Drawing.Size(59, 14)
        Me.lblDataHora.Text = "Data hora"
        '
        'timerHour
        '
        '
        'cmbTema
        '
        Me.cmbTema.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmbTema.BackColor = System.Drawing.Color.DimGray
        Me.cmbTema.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbTema.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbTema.FormattingEnabled = True
        Me.cmbTema.Location = New System.Drawing.Point(909, 624)
        Me.cmbTema.Name = "cmbTema"
        Me.cmbTema.Size = New System.Drawing.Size(91, 20)
        Me.cmbTema.TabIndex = 93
        Me.cmbTema.Visible = False
        '
        'Label2
        '
        Me.Label2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.DimGray
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(851, 629)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(37, 13)
        Me.Label2.TabIndex = 94
        Me.Label2.Text = "Tema:"
        Me.Label2.Visible = False
        '
        'DefaultLookAndFeel1
        '
        Me.DefaultLookAndFeel1.LookAndFeel.SkinName = "DevExpress Style"
        '
        'TimerStatus
        '
        Me.TimerStatus.Interval = 500
        '
        'ApplicationMenu1
        '
        Me.ApplicationMenu1.Name = "ApplicationMenu1"
        '
        'TimerCheckConnection
        '
        Me.TimerCheckConnection.Interval = 60000
        '
        'TimerBackend
        '
        Me.TimerBackend.Interval = 180000
        '
        'MainScreen
        '
        Me.Appearance.BackColor = System.Drawing.Color.Gray
        Me.Appearance.Options.UseBackColor = True
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1000, 645)
        Me.Controls.Add(Me.cmbTema)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.StatusStrip2)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.RibbonControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.IconOptions.LargeImage = CType(resources.GetObject("MainScreen.IconOptions.LargeImage"), System.Drawing.Image)
        Me.IsMdiContainer = True
        Me.KeyPreview = True
        Me.Name = "MainScreen"
        Me.Ribbon = Me.RibbonControl1
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.RibbonControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.StatusStrip2.ResumeLayout(False)
        Me.StatusStrip2.PerformLayout()
        CType(Me.ApplicationMenu1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents RibbonControl1 As DevExpress.XtraBars.Ribbon.RibbonControl
    Friend WithEvents RibbonPage1 As DevExpress.XtraBars.Ribbon.RibbonPage
    Friend WithEvents RibbonPageGroup1 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents RibbonPage2 As DevExpress.XtraBars.Ribbon.RibbonPage
    Friend WithEvents DlgCor As ColorDialog
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents StatusStrip2 As StatusStrip
    Friend WithEvents lblEmpresa As ToolStripStatusLabel
    Friend WithEvents lblDataHora As ToolStripStatusLabel
    Friend WithEvents timerHour As Timer
    Friend WithEvents SkinDropDownButtonItem1 As DevExpress.XtraBars.SkinDropDownButtonItem
    Friend WithEvents cmbTema As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents SkinDropDownButtonItem2 As DevExpress.XtraBars.SkinDropDownButtonItem
    Friend WithEvents SkinPaletteDropDownButtonItem1 As DevExpress.XtraBars.SkinPaletteDropDownButtonItem
    Friend WithEvents DefaultLookAndFeel1 As DevExpress.LookAndFeel.DefaultLookAndFeel
    Friend WithEvents FormAssistant1 As DevExpress.XtraBars.FormAssistant
    Friend WithEvents TimerStatus As Timer
    Friend WithEvents ApplicationMenu1 As DevExpress.XtraBars.Ribbon.ApplicationMenu
    Friend WithEvents TimerCheckConnection As Timer
    Friend WithEvents btnUsers As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnProducts As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnCustomers As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents RibbonPageGroup7 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents RibbonPageGroup4 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents btnSales As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents RibbonPageGroup8 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents TimerBackend As Timer
End Class
