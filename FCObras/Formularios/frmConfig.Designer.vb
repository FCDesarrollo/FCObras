<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmConfig
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.tabParam = New System.Windows.Forms.TabPage()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.dgInsumos = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnDelUnidad = New System.Windows.Forms.Button()
        Me.btnAddUnidad = New System.Windows.Forms.Button()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.dgUnidades = New System.Windows.Forms.DataGridView()
        Me.uniid = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.unicodigo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.uninombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.btnActiva = New System.Windows.Forms.Button()
        Me.txtRazon = New System.Windows.Forms.TextBox()
        Me.txtRfc = New System.Windows.Forms.TextBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.linfo2 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.tabGen = New System.Windows.Forms.TabPage()
        Me.linfo = New System.Windows.Forms.Label()
        Me.txtEmpresasComercial = New System.Windows.Forms.TextBox()
        Me.txtSDKComercial = New System.Windows.Forms.TextBox()
        Me.txtEmpresas = New System.Windows.Forms.TextBox()
        Me.txtSDK = New System.Windows.Forms.TextBox()
        Me.TBSA = New System.Windows.Forms.TextBox()
        Me.TBUID = New System.Windows.Forms.TextBox()
        Me.TBBDDGen = New System.Windows.Forms.TextBox()
        Me.TBSql = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.BtInstala = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.mpConfig = New System.Windows.Forms.TabControl()
        Me.tabEmpresas = New System.Windows.Forms.TabPage()
        Me.btnDel = New System.Windows.Forms.Button()
        Me.btnADD = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.dgEmpresas = New System.Windows.Forms.DataGridView()
        Me.empid = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.empnom = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.empbdd = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.empnum = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TabConfigEmpresa = New System.Windows.Forms.TabPage()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.cbtipo = New System.Windows.Forms.ComboBox()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.btDelCon = New System.Windows.Forms.Button()
        Me.btAddCon = New System.Windows.Forms.Button()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.dglisConceptos = New System.Windows.Forms.DataGridView()
        Me.dgconidsuc = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.contipo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.conid = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgconsucursal = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgconcodigo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgconnombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.cbsucursales = New System.Windows.Forms.ComboBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.cbempresas = New System.Windows.Forms.ComboBox()
        Me.tooltip = New System.Windows.Forms.ToolTip(Me.components)
        Me.tabParam.SuspendLayout()
        CType(Me.dgInsumos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgUnidades, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabGen.SuspendLayout()
        Me.mpConfig.SuspendLayout()
        Me.tabEmpresas.SuspendLayout()
        CType(Me.dgEmpresas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabConfigEmpresa.SuspendLayout()
        CType(Me.dglisConceptos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tabParam
        '
        Me.tabParam.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.tabParam.Controls.Add(Me.Button1)
        Me.tabParam.Controls.Add(Me.Button2)
        Me.tabParam.Controls.Add(Me.Label20)
        Me.tabParam.Controls.Add(Me.dgInsumos)
        Me.tabParam.Controls.Add(Me.btnDelUnidad)
        Me.tabParam.Controls.Add(Me.btnAddUnidad)
        Me.tabParam.Controls.Add(Me.Label9)
        Me.tabParam.Controls.Add(Me.dgUnidades)
        Me.tabParam.Controls.Add(Me.Label8)
        Me.tabParam.Controls.Add(Me.btnActiva)
        Me.tabParam.Controls.Add(Me.txtRazon)
        Me.tabParam.Controls.Add(Me.txtRfc)
        Me.tabParam.Controls.Add(Me.Label18)
        Me.tabParam.Controls.Add(Me.Label11)
        Me.tabParam.Controls.Add(Me.linfo2)
        Me.tabParam.Controls.Add(Me.Label13)
        Me.tabParam.Controls.Add(Me.btnGuardar)
        Me.tabParam.Location = New System.Drawing.Point(4, 22)
        Me.tabParam.Name = "tabParam"
        Me.tabParam.Padding = New System.Windows.Forms.Padding(3)
        Me.tabParam.Size = New System.Drawing.Size(544, 360)
        Me.tabParam.TabIndex = 1
        Me.tabParam.Text = "Parametros"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Red
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(480, 164)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(31, 28)
        Me.Button1.TabIndex = 40
        Me.Button1.Text = "-"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.Blue
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(443, 164)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(31, 28)
        Me.Button2.TabIndex = 39
        Me.Button2.Text = "+"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(264, 175)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(97, 13)
        Me.Label20.TabIndex = 38
        Me.Label20.Text = "Insumos Generales"
        '
        'dgInsumos
        '
        Me.dgInsumos.AllowUserToAddRows = False
        Me.dgInsumos.AllowUserToDeleteRows = False
        Me.dgInsumos.AllowUserToResizeRows = False
        Me.dgInsumos.BackgroundColor = System.Drawing.SystemColors.ControlLightLight
        Me.dgInsumos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgInsumos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3})
        Me.dgInsumos.GridColor = System.Drawing.SystemColors.ControlLightLight
        Me.dgInsumos.Location = New System.Drawing.Point(264, 192)
        Me.dgInsumos.MultiSelect = False
        Me.dgInsumos.Name = "dgInsumos"
        Me.dgInsumos.RowHeadersVisible = False
        Me.dgInsumos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgInsumos.Size = New System.Drawing.Size(247, 160)
        Me.dgInsumos.TabIndex = 37
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.HeaderText = "id"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.Visible = False
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.HeaderText = "Codigo"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        Me.DataGridViewTextBoxColumn2.Width = 80
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.HeaderText = "Nombre"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        Me.DataGridViewTextBoxColumn3.Width = 160
        '
        'btnDelUnidad
        '
        Me.btnDelUnidad.BackColor = System.Drawing.Color.Red
        Me.btnDelUnidad.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDelUnidad.Location = New System.Drawing.Point(227, 164)
        Me.btnDelUnidad.Name = "btnDelUnidad"
        Me.btnDelUnidad.Size = New System.Drawing.Size(31, 28)
        Me.btnDelUnidad.TabIndex = 36
        Me.btnDelUnidad.Text = "-"
        Me.btnDelUnidad.UseVisualStyleBackColor = False
        '
        'btnAddUnidad
        '
        Me.btnAddUnidad.BackColor = System.Drawing.Color.Blue
        Me.btnAddUnidad.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddUnidad.Location = New System.Drawing.Point(190, 164)
        Me.btnAddUnidad.Name = "btnAddUnidad"
        Me.btnAddUnidad.Size = New System.Drawing.Size(31, 28)
        Me.btnAddUnidad.TabIndex = 35
        Me.btnAddUnidad.Text = "+"
        Me.btnAddUnidad.UseVisualStyleBackColor = False
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(11, 175)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(156, 13)
        Me.Label9.TabIndex = 34
        Me.Label9.Text = "Unidades de Medida Generales"
        '
        'dgUnidades
        '
        Me.dgUnidades.AllowUserToAddRows = False
        Me.dgUnidades.AllowUserToDeleteRows = False
        Me.dgUnidades.AllowUserToResizeRows = False
        Me.dgUnidades.BackgroundColor = System.Drawing.SystemColors.ControlLightLight
        Me.dgUnidades.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgUnidades.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.uniid, Me.unicodigo, Me.uninombre})
        Me.dgUnidades.GridColor = System.Drawing.SystemColors.ControlLightLight
        Me.dgUnidades.Location = New System.Drawing.Point(11, 192)
        Me.dgUnidades.MultiSelect = False
        Me.dgUnidades.Name = "dgUnidades"
        Me.dgUnidades.RowHeadersVisible = False
        Me.dgUnidades.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgUnidades.Size = New System.Drawing.Size(247, 160)
        Me.dgUnidades.TabIndex = 33
        '
        'uniid
        '
        Me.uniid.HeaderText = "id"
        Me.uniid.Name = "uniid"
        Me.uniid.Visible = False
        '
        'unicodigo
        '
        Me.unicodigo.HeaderText = "Codigo"
        Me.unicodigo.Name = "unicodigo"
        Me.unicodigo.ReadOnly = True
        Me.unicodigo.Width = 80
        '
        'uninombre
        '
        Me.uninombre.HeaderText = "Nombre"
        Me.uninombre.Name = "uninombre"
        Me.uninombre.ReadOnly = True
        Me.uninombre.Width = 160
        '
        'Label8
        '
        Me.Label8.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label8.Location = New System.Drawing.Point(3, 148)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(538, 10)
        Me.Label8.TabIndex = 32
        '
        'btnActiva
        '
        Me.btnActiva.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnActiva.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnActiva.Location = New System.Drawing.Point(315, 78)
        Me.btnActiva.Name = "btnActiva"
        Me.btnActiva.Size = New System.Drawing.Size(122, 36)
        Me.btnActiva.TabIndex = 16
        Me.btnActiva.Text = "Activar Producto"
        Me.btnActiva.UseVisualStyleBackColor = False
        Me.btnActiva.Visible = False
        '
        'txtRazon
        '
        Me.txtRazon.Location = New System.Drawing.Point(11, 28)
        Me.txtRazon.Name = "txtRazon"
        Me.txtRazon.Size = New System.Drawing.Size(298, 20)
        Me.txtRazon.TabIndex = 30
        '
        'txtRfc
        '
        Me.txtRfc.Location = New System.Drawing.Point(11, 67)
        Me.txtRfc.Name = "txtRfc"
        Me.txtRfc.Size = New System.Drawing.Size(298, 20)
        Me.txtRfc.TabIndex = 28
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(8, 12)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(154, 13)
        Me.Label18.TabIndex = 31
        Me.Label18.Text = "Nombre Cliente o Razon Social"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(8, 51)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(60, 13)
        Me.Label11.TabIndex = 29
        Me.Label11.Text = "RFCCliente"
        '
        'linfo2
        '
        Me.linfo2.BackColor = System.Drawing.Color.Red
        Me.linfo2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.linfo2.Location = New System.Drawing.Point(6, 130)
        Me.linfo2.Name = "linfo2"
        Me.linfo2.Size = New System.Drawing.Size(290, 18)
        Me.linfo2.TabIndex = 27
        Me.linfo2.Text = "!No se han Configurado todos los parametros.!" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.linfo2.Visible = False
        '
        'Label13
        '
        Me.Label13.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label13.Location = New System.Drawing.Point(8, 90)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(301, 30)
        Me.Label13.TabIndex = 26
        Me.Label13.Text = "1.- Datos del Cliente para Agregar a nuestra base de Datos." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'btnGuardar
        '
        Me.btnGuardar.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnGuardar.Location = New System.Drawing.Point(315, 28)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(101, 35)
        Me.btnGuardar.TabIndex = 25
        Me.btnGuardar.Text = "Guardar"
        Me.btnGuardar.UseVisualStyleBackColor = False
        '
        'tabGen
        '
        Me.tabGen.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.tabGen.Controls.Add(Me.linfo)
        Me.tabGen.Controls.Add(Me.txtEmpresasComercial)
        Me.tabGen.Controls.Add(Me.txtSDKComercial)
        Me.tabGen.Controls.Add(Me.txtEmpresas)
        Me.tabGen.Controls.Add(Me.txtSDK)
        Me.tabGen.Controls.Add(Me.TBSA)
        Me.tabGen.Controls.Add(Me.TBUID)
        Me.tabGen.Controls.Add(Me.TBBDDGen)
        Me.tabGen.Controls.Add(Me.TBSql)
        Me.tabGen.Controls.Add(Me.Label6)
        Me.tabGen.Controls.Add(Me.Label5)
        Me.tabGen.Controls.Add(Me.Label17)
        Me.tabGen.Controls.Add(Me.Label15)
        Me.tabGen.Controls.Add(Me.Label14)
        Me.tabGen.Controls.Add(Me.BtInstala)
        Me.tabGen.Controls.Add(Me.Label1)
        Me.tabGen.Controls.Add(Me.Label2)
        Me.tabGen.Controls.Add(Me.Label3)
        Me.tabGen.Controls.Add(Me.Label4)
        Me.tabGen.Location = New System.Drawing.Point(4, 22)
        Me.tabGen.Name = "tabGen"
        Me.tabGen.Padding = New System.Windows.Forms.Padding(3)
        Me.tabGen.Size = New System.Drawing.Size(544, 360)
        Me.tabGen.TabIndex = 0
        Me.tabGen.Text = "General"
        '
        'linfo
        '
        Me.linfo.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.linfo.Location = New System.Drawing.Point(6, 262)
        Me.linfo.Name = "linfo"
        Me.linfo.Size = New System.Drawing.Size(399, 32)
        Me.linfo.TabIndex = 21
        Me.linfo.Text = "Intalación" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Guarda la configuración Principal para los Modulos."
        '
        'txtEmpresasComercial
        '
        Me.txtEmpresasComercial.Location = New System.Drawing.Point(278, 200)
        Me.txtEmpresasComercial.Name = "txtEmpresasComercial"
        Me.txtEmpresasComercial.Size = New System.Drawing.Size(249, 20)
        Me.txtEmpresasComercial.TabIndex = 19
        '
        'txtSDKComercial
        '
        Me.txtSDKComercial.Location = New System.Drawing.Point(278, 158)
        Me.txtSDKComercial.Name = "txtSDKComercial"
        Me.txtSDKComercial.Size = New System.Drawing.Size(249, 20)
        Me.txtSDKComercial.TabIndex = 17
        '
        'txtEmpresas
        '
        Me.txtEmpresas.Location = New System.Drawing.Point(6, 200)
        Me.txtEmpresas.Name = "txtEmpresas"
        Me.txtEmpresas.Size = New System.Drawing.Size(249, 20)
        Me.txtEmpresas.TabIndex = 12
        '
        'txtSDK
        '
        Me.txtSDK.Location = New System.Drawing.Point(6, 158)
        Me.txtSDK.Name = "txtSDK"
        Me.txtSDK.Size = New System.Drawing.Size(249, 20)
        Me.txtSDK.TabIndex = 10
        '
        'TBSA
        '
        Me.TBSA.Location = New System.Drawing.Point(120, 103)
        Me.TBSA.Name = "TBSA"
        Me.TBSA.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TBSA.Size = New System.Drawing.Size(100, 20)
        Me.TBSA.TabIndex = 3
        '
        'TBUID
        '
        Me.TBUID.Location = New System.Drawing.Point(6, 103)
        Me.TBUID.Name = "TBUID"
        Me.TBUID.Size = New System.Drawing.Size(100, 20)
        Me.TBUID.TabIndex = 2
        '
        'TBBDDGen
        '
        Me.TBBDDGen.Location = New System.Drawing.Point(6, 64)
        Me.TBBDDGen.Name = "TBBDDGen"
        Me.TBBDDGen.Size = New System.Drawing.Size(214, 20)
        Me.TBBDDGen.TabIndex = 1
        '
        'TBSql
        '
        Me.TBSql.Location = New System.Drawing.Point(6, 21)
        Me.TBSql.Name = "TBSql"
        Me.TBSql.Size = New System.Drawing.Size(214, 20)
        Me.TBSql.TabIndex = 0
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(275, 184)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(143, 13)
        Me.Label6.TabIndex = 20
        Me.Label6.Text = "Ruta de Empresas Comercial"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(275, 142)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(119, 13)
        Me.Label5.TabIndex = 18
        Me.Label5.Text = "Ruta SDK de Comercial"
        '
        'Label17
        '
        Me.Label17.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Label17.Location = New System.Drawing.Point(3, 126)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(300, 10)
        Me.Label17.TabIndex = 16
        Me.Label17.Text = "" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(3, 184)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(163, 13)
        Me.Label15.TabIndex = 13
        Me.Label15.Text = "Ruta de Empresas de AdminPAQ"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(3, 142)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(124, 13)
        Me.Label14.TabIndex = 11
        Me.Label14.Text = "Ruta SDK de AdminPAQ"
        '
        'BtInstala
        '
        Me.BtInstala.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BtInstala.Location = New System.Drawing.Point(207, 319)
        Me.BtInstala.Name = "BtInstala"
        Me.BtInstala.Size = New System.Drawing.Size(82, 35)
        Me.BtInstala.TabIndex = 8
        Me.BtInstala.Text = "Guardar"
        Me.BtInstala.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(3, 5)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(90, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Instancia General"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(3, 48)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(117, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Base de Datos General"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(3, 87)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(43, 13)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Usuario"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(117, 87)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(61, 13)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Contraseña"
        '
        'mpConfig
        '
        Me.mpConfig.Controls.Add(Me.tabGen)
        Me.mpConfig.Controls.Add(Me.tabParam)
        Me.mpConfig.Controls.Add(Me.tabEmpresas)
        Me.mpConfig.Controls.Add(Me.TabConfigEmpresa)
        Me.mpConfig.Location = New System.Drawing.Point(12, 12)
        Me.mpConfig.Name = "mpConfig"
        Me.mpConfig.SelectedIndex = 0
        Me.mpConfig.Size = New System.Drawing.Size(552, 386)
        Me.mpConfig.TabIndex = 2
        '
        'tabEmpresas
        '
        Me.tabEmpresas.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.tabEmpresas.Controls.Add(Me.btnDel)
        Me.tabEmpresas.Controls.Add(Me.btnADD)
        Me.tabEmpresas.Controls.Add(Me.Label7)
        Me.tabEmpresas.Controls.Add(Me.dgEmpresas)
        Me.tabEmpresas.Location = New System.Drawing.Point(4, 22)
        Me.tabEmpresas.Name = "tabEmpresas"
        Me.tabEmpresas.Padding = New System.Windows.Forms.Padding(3)
        Me.tabEmpresas.Size = New System.Drawing.Size(544, 360)
        Me.tabEmpresas.TabIndex = 2
        Me.tabEmpresas.Text = "Empresas"
        '
        'btnDel
        '
        Me.btnDel.BackColor = System.Drawing.Color.Red
        Me.btnDel.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDel.Location = New System.Drawing.Point(474, 7)
        Me.btnDel.Name = "btnDel"
        Me.btnDel.Size = New System.Drawing.Size(31, 28)
        Me.btnDel.TabIndex = 23
        Me.btnDel.Text = "-"
        Me.btnDel.UseVisualStyleBackColor = False
        '
        'btnADD
        '
        Me.btnADD.BackColor = System.Drawing.Color.Blue
        Me.btnADD.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnADD.Location = New System.Drawing.Point(437, 7)
        Me.btnADD.Name = "btnADD"
        Me.btnADD.Size = New System.Drawing.Size(31, 28)
        Me.btnADD.TabIndex = 22
        Me.btnADD.Text = "+"
        Me.btnADD.UseVisualStyleBackColor = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(7, 16)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(48, 13)
        Me.Label7.TabIndex = 21
        Me.Label7.Text = "Empreas"
        '
        'dgEmpresas
        '
        Me.dgEmpresas.AllowUserToAddRows = False
        Me.dgEmpresas.AllowUserToDeleteRows = False
        Me.dgEmpresas.AllowUserToResizeRows = False
        Me.dgEmpresas.BackgroundColor = System.Drawing.SystemColors.ControlLightLight
        Me.dgEmpresas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgEmpresas.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.empid, Me.empnom, Me.empbdd, Me.empnum})
        Me.dgEmpresas.GridColor = System.Drawing.SystemColors.ControlLightLight
        Me.dgEmpresas.Location = New System.Drawing.Point(6, 35)
        Me.dgEmpresas.MultiSelect = False
        Me.dgEmpresas.Name = "dgEmpresas"
        Me.dgEmpresas.RowHeadersVisible = False
        Me.dgEmpresas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgEmpresas.Size = New System.Drawing.Size(499, 223)
        Me.dgEmpresas.TabIndex = 20
        '
        'empid
        '
        Me.empid.HeaderText = "id"
        Me.empid.Name = "empid"
        Me.empid.Visible = False
        '
        'empnom
        '
        Me.empnom.HeaderText = "Empresa ContPAQ"
        Me.empnom.Name = "empnom"
        Me.empnom.ReadOnly = True
        Me.empnom.Width = 250
        '
        'empbdd
        '
        Me.empbdd.HeaderText = "BDD"
        Me.empbdd.Name = "empbdd"
        Me.empbdd.ReadOnly = True
        Me.empbdd.Width = 140
        '
        'empnum
        '
        Me.empnum.HeaderText = "Num. Sucursales"
        Me.empnum.Name = "empnum"
        Me.empnum.ReadOnly = True
        '
        'TabConfigEmpresa
        '
        Me.TabConfigEmpresa.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.TabConfigEmpresa.Controls.Add(Me.Label22)
        Me.TabConfigEmpresa.Controls.Add(Me.cbtipo)
        Me.TabConfigEmpresa.Controls.Add(Me.Label21)
        Me.TabConfigEmpresa.Controls.Add(Me.Label19)
        Me.TabConfigEmpresa.Controls.Add(Me.btDelCon)
        Me.TabConfigEmpresa.Controls.Add(Me.btAddCon)
        Me.TabConfigEmpresa.Controls.Add(Me.Label16)
        Me.TabConfigEmpresa.Controls.Add(Me.dglisConceptos)
        Me.TabConfigEmpresa.Controls.Add(Me.Label10)
        Me.TabConfigEmpresa.Controls.Add(Me.cbsucursales)
        Me.TabConfigEmpresa.Controls.Add(Me.Label12)
        Me.TabConfigEmpresa.Controls.Add(Me.cbempresas)
        Me.TabConfigEmpresa.Location = New System.Drawing.Point(4, 22)
        Me.TabConfigEmpresa.Name = "TabConfigEmpresa"
        Me.TabConfigEmpresa.Padding = New System.Windows.Forms.Padding(3)
        Me.TabConfigEmpresa.Size = New System.Drawing.Size(544, 360)
        Me.TabConfigEmpresa.TabIndex = 3
        Me.TabConfigEmpresa.Text = "Conceptos"
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Location = New System.Drawing.Point(12, 337)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(179, 13)
        Me.Label22.TabIndex = 52
        Me.Label22.Text = "Solo un concepto por sucursal y tipo"
        '
        'cbtipo
        '
        Me.cbtipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbtipo.FormattingEnabled = True
        Me.cbtipo.Location = New System.Drawing.Point(242, 69)
        Me.cbtipo.Name = "cbtipo"
        Me.cbtipo.Size = New System.Drawing.Size(200, 21)
        Me.cbtipo.TabIndex = 51
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Location = New System.Drawing.Point(239, 52)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(31, 13)
        Me.Label21.TabIndex = 50
        Me.Label21.Text = "Tipo:"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(320, 337)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(207, 13)
        Me.Label19.TabIndex = 49
        Me.Label19.Text = "Selccione el concepto que desea eliminar."
        '
        'btDelCon
        '
        Me.btDelCon.BackColor = System.Drawing.Color.Red
        Me.btDelCon.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btDelCon.Location = New System.Drawing.Point(506, 86)
        Me.btDelCon.Name = "btDelCon"
        Me.btDelCon.Size = New System.Drawing.Size(31, 28)
        Me.btDelCon.TabIndex = 48
        Me.btDelCon.Text = "-"
        Me.btDelCon.UseVisualStyleBackColor = False
        '
        'btAddCon
        '
        Me.btAddCon.BackColor = System.Drawing.Color.Blue
        Me.btAddCon.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btAddCon.Location = New System.Drawing.Point(469, 86)
        Me.btAddCon.Name = "btAddCon"
        Me.btAddCon.Size = New System.Drawing.Size(31, 28)
        Me.btAddCon.TabIndex = 47
        Me.btAddCon.Text = "+"
        Me.btAddCon.UseVisualStyleBackColor = False
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(12, 101)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(218, 13)
        Me.Label16.TabIndex = 46
        Me.Label16.Text = "Lista Conceptos Configurados de la Empresa"
        '
        'dglisConceptos
        '
        Me.dglisConceptos.AllowUserToAddRows = False
        Me.dglisConceptos.AllowUserToDeleteRows = False
        Me.dglisConceptos.AllowUserToResizeRows = False
        Me.dglisConceptos.BackgroundColor = System.Drawing.SystemColors.ControlLightLight
        Me.dglisConceptos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dglisConceptos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.dgconidsuc, Me.contipo, Me.conid, Me.dgconsucursal, Me.dgconcodigo, Me.dgconnombre})
        Me.dglisConceptos.GridColor = System.Drawing.SystemColors.ControlLightLight
        Me.dglisConceptos.Location = New System.Drawing.Point(15, 117)
        Me.dglisConceptos.MultiSelect = False
        Me.dglisConceptos.Name = "dglisConceptos"
        Me.dglisConceptos.RowHeadersVisible = False
        Me.dglisConceptos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dglisConceptos.Size = New System.Drawing.Size(523, 217)
        Me.dglisConceptos.TabIndex = 45
        '
        'dgconidsuc
        '
        Me.dgconidsuc.HeaderText = "idsucursal"
        Me.dgconidsuc.Name = "dgconidsuc"
        Me.dgconidsuc.Visible = False
        '
        'contipo
        '
        Me.contipo.HeaderText = "Tipo"
        Me.contipo.Name = "contipo"
        Me.contipo.ReadOnly = True
        '
        'conid
        '
        Me.conid.HeaderText = "idconcepto"
        Me.conid.Name = "conid"
        Me.conid.Visible = False
        '
        'dgconsucursal
        '
        Me.dgconsucursal.HeaderText = "Sucursal"
        Me.dgconsucursal.Name = "dgconsucursal"
        Me.dgconsucursal.ReadOnly = True
        Me.dgconsucursal.Width = 120
        '
        'dgconcodigo
        '
        Me.dgconcodigo.HeaderText = "Codigo"
        Me.dgconcodigo.Name = "dgconcodigo"
        Me.dgconcodigo.ReadOnly = True
        Me.dgconcodigo.Width = 80
        '
        'dgconnombre
        '
        Me.dgconnombre.HeaderText = "Nombre Concepto"
        Me.dgconnombre.Name = "dgconnombre"
        Me.dgconnombre.ReadOnly = True
        Me.dgconnombre.Width = 300
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(12, 52)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(51, 13)
        Me.Label10.TabIndex = 44
        Me.Label10.Text = "Sucursal:"
        '
        'cbsucursales
        '
        Me.cbsucursales.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbsucursales.FormattingEnabled = True
        Me.cbsucursales.Location = New System.Drawing.Point(15, 68)
        Me.cbsucursales.Name = "cbsucursales"
        Me.cbsucursales.Size = New System.Drawing.Size(200, 21)
        Me.cbsucursales.TabIndex = 43
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(12, 12)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(51, 13)
        Me.Label12.TabIndex = 42
        Me.Label12.Text = "Empresa:"
        '
        'cbempresas
        '
        Me.cbempresas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbempresas.FormattingEnabled = True
        Me.cbempresas.Location = New System.Drawing.Point(15, 28)
        Me.cbempresas.Name = "cbempresas"
        Me.cbempresas.Size = New System.Drawing.Size(275, 21)
        Me.cbempresas.TabIndex = 41
        '
        'frmConfig
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ClientSize = New System.Drawing.Size(578, 398)
        Me.Controls.Add(Me.mpConfig)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmConfig"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Configuración"
        Me.tabParam.ResumeLayout(False)
        Me.tabParam.PerformLayout()
        CType(Me.dgInsumos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgUnidades, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabGen.ResumeLayout(False)
        Me.tabGen.PerformLayout()
        Me.mpConfig.ResumeLayout(False)
        Me.tabEmpresas.ResumeLayout(False)
        Me.tabEmpresas.PerformLayout()
        CType(Me.dgEmpresas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabConfigEmpresa.ResumeLayout(False)
        Me.TabConfigEmpresa.PerformLayout()
        CType(Me.dglisConceptos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents tabParam As TabPage
    Friend WithEvents btnActiva As Button
    Friend WithEvents txtRazon As TextBox
    Friend WithEvents txtRfc As TextBox
    Friend WithEvents Label18 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents linfo2 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents btnGuardar As Button
    Friend WithEvents tabGen As TabPage
    Friend WithEvents txtEmpresasComercial As TextBox
    Friend WithEvents txtSDKComercial As TextBox
    Friend WithEvents txtEmpresas As TextBox
    Friend WithEvents txtSDK As TextBox
    Friend WithEvents TBSA As TextBox
    Friend WithEvents TBUID As TextBox
    Friend WithEvents TBBDDGen As TextBox
    Friend WithEvents TBSql As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents BtInstala As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents mpConfig As TabControl
    Friend WithEvents tabEmpresas As TabPage
    Friend WithEvents btnDel As Button
    Friend WithEvents btnADD As Button
    Friend WithEvents Label7 As Label
    Friend WithEvents dgEmpresas As DataGridView
    Friend WithEvents linfo As Label
    Friend WithEvents empid As DataGridViewTextBoxColumn
    Friend WithEvents empnom As DataGridViewTextBoxColumn
    Friend WithEvents empbdd As DataGridViewTextBoxColumn
    Friend WithEvents empnum As DataGridViewTextBoxColumn
    Friend WithEvents tooltip As ToolTip
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents dgUnidades As DataGridView
    Friend WithEvents uniid As DataGridViewTextBoxColumn
    Friend WithEvents unicodigo As DataGridViewTextBoxColumn
    Friend WithEvents uninombre As DataGridViewTextBoxColumn
    Friend WithEvents btnDelUnidad As Button
    Friend WithEvents btnAddUnidad As Button
    Friend WithEvents TabConfigEmpresa As TabPage
    Friend WithEvents Label10 As Label
    Friend WithEvents cbsucursales As ComboBox
    Friend WithEvents Label12 As Label
    Friend WithEvents cbempresas As ComboBox
    Friend WithEvents Label16 As Label
    Friend WithEvents dglisConceptos As DataGridView
    Friend WithEvents btDelCon As Button
    Friend WithEvents btAddCon As Button
    Friend WithEvents Label19 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Label20 As Label
    Friend WithEvents dgInsumos As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents cbtipo As ComboBox
    Friend WithEvents Label21 As Label
    Friend WithEvents Label22 As Label
    Friend WithEvents dgconidsuc As DataGridViewTextBoxColumn
    Friend WithEvents contipo As DataGridViewTextBoxColumn
    Friend WithEvents conid As DataGridViewTextBoxColumn
    Friend WithEvents dgconsucursal As DataGridViewTextBoxColumn
    Friend WithEvents dgconcodigo As DataGridViewTextBoxColumn
    Friend WithEvents dgconnombre As DataGridViewTextBoxColumn
End Class
