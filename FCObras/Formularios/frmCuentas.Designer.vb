<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCuentas
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCuentas))
        Me.btnSiguien = New System.Windows.Forms.Button()
        Me.txtBuscar = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.tvCuentas = New System.Windows.Forms.TreeView()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.dtFechaF = New System.Windows.Forms.DateTimePicker()
        Me.dtFechaI = New System.Windows.Forms.DateTimePicker()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtnombrecuenta = New System.Windows.Forms.TextBox()
        Me.txtCuenta = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lbEmpresa = New System.Windows.Forms.Label()
        Me.lbObra = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtSubCuenta = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.dgPrecios = New System.Windows.Forms.DataGridView()
        Me.idasoc = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.preidpre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.prefecha = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.precant = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.preprecio = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.preimporte = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.prepresupuesto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.cbUnidad = New System.Windows.Forms.ComboBox()
        Me.btnADDPrecio = New System.Windows.Forms.Button()
        Me.btnDelPrecio = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.ckTipo = New System.Windows.Forms.CheckBox()
        Me.cbclas3 = New System.Windows.Forms.ComboBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.cbclas2 = New System.Windows.Forms.ComboBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.cbclas1 = New System.Windows.Forms.ComboBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.cbNombreTipo = New System.Windows.Forms.ComboBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.dgFechas = New System.Windows.Forms.DataGridView()
        Me.planid = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.plannombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.planfechai = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.planfechaF = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnCarga = New System.Windows.Forms.Button()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.btnEliminar = New System.Windows.Forms.Button()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.btnNuevo = New System.Windows.Forms.Button()
        Me.btnbusSub = New System.Windows.Forms.Button()
        Me.btnbusCuen = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        CType(Me.dgPrecios, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        CType(Me.dgFechas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnSiguien
        '
        Me.btnSiguien.Location = New System.Drawing.Point(230, 49)
        Me.btnSiguien.Name = "btnSiguien"
        Me.btnSiguien.Size = New System.Drawing.Size(75, 23)
        Me.btnSiguien.TabIndex = 2
        Me.btnSiguien.Text = "Siguiente"
        Me.btnSiguien.UseVisualStyleBackColor = True
        '
        'txtBuscar
        '
        Me.txtBuscar.Location = New System.Drawing.Point(58, 49)
        Me.txtBuscar.Name = "txtBuscar"
        Me.txtBuscar.Size = New System.Drawing.Size(166, 20)
        Me.txtBuscar.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(14, 52)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(43, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Buscar:"
        '
        'tvCuentas
        '
        Me.tvCuentas.HideSelection = False
        Me.tvCuentas.Location = New System.Drawing.Point(12, 75)
        Me.tvCuentas.Name = "tvCuentas"
        Me.tvCuentas.Size = New System.Drawing.Size(407, 526)
        Me.tvCuentas.TabIndex = 5
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.dtFechaF)
        Me.Panel1.Controls.Add(Me.dtFechaI)
        Me.Panel1.Controls.Add(Me.Label9)
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Controls.Add(Me.btnbusCuen)
        Me.Panel1.Controls.Add(Me.txtnombrecuenta)
        Me.Panel1.Controls.Add(Me.txtCuenta)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Location = New System.Drawing.Point(440, 67)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(454, 83)
        Me.Panel1.TabIndex = 6
        '
        'dtFechaF
        '
        Me.dtFechaF.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtFechaF.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.dtFechaF.Location = New System.Drawing.Point(277, 55)
        Me.dtFechaF.Name = "dtFechaF"
        Me.dtFechaF.Size = New System.Drawing.Size(97, 20)
        Me.dtFechaF.TabIndex = 26
        '
        'dtFechaI
        '
        Me.dtFechaI.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtFechaI.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.dtFechaI.Location = New System.Drawing.Point(89, 56)
        Me.dtFechaI.Name = "dtFechaI"
        Me.dtFechaI.Size = New System.Drawing.Size(97, 20)
        Me.dtFechaI.TabIndex = 25
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(192, 59)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(82, 13)
        Me.Label9.TabIndex = 24
        Me.Label9.Text = "Fecha Final*:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(3, 59)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(86, 13)
        Me.Label8.TabIndex = 23
        Me.Label8.Text = "Fecha Inicio*:"
        '
        'txtnombrecuenta
        '
        Me.txtnombrecuenta.Location = New System.Drawing.Point(65, 31)
        Me.txtnombrecuenta.Name = "txtnombrecuenta"
        Me.txtnombrecuenta.Size = New System.Drawing.Size(381, 20)
        Me.txtnombrecuenta.TabIndex = 8
        '
        'txtCuenta
        '
        Me.txtCuenta.Location = New System.Drawing.Point(65, 5)
        Me.txtCuenta.Name = "txtCuenta"
        Me.txtCuenta.Size = New System.Drawing.Size(175, 20)
        Me.txtCuenta.TabIndex = 7
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(3, 37)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(59, 13)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Nombre:*"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(3, 10)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(56, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Cuenta:*"
        '
        'lbEmpresa
        '
        Me.lbEmpresa.AutoSize = True
        Me.lbEmpresa.Location = New System.Drawing.Point(13, 9)
        Me.lbEmpresa.Name = "lbEmpresa"
        Me.lbEmpresa.Size = New System.Drawing.Size(194, 13)
        Me.lbEmpresa.TabIndex = 37
        Me.lbEmpresa.Text = "Nombre de la empresa para información"
        '
        'lbObra
        '
        Me.lbObra.AutoSize = True
        Me.lbObra.Location = New System.Drawing.Point(13, 28)
        Me.lbObra.Name = "lbObra"
        Me.lbObra.Size = New System.Drawing.Size(175, 13)
        Me.lbObra.TabIndex = 38
        Me.lbObra.Text = "Nombre de la obra para información"
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.Navy
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(6, 4)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(448, 19)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "Datos de la cuenta"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(6, 34)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(77, 13)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Subcuenta de:"
        '
        'txtSubCuenta
        '
        Me.txtSubCuenta.Location = New System.Drawing.Point(81, 31)
        Me.txtSubCuenta.Name = "txtSubCuenta"
        Me.txtSubCuenta.Size = New System.Drawing.Size(175, 20)
        Me.txtSubCuenta.TabIndex = 8
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(6, 63)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(87, 13)
        Me.Label7.TabIndex = 9
        Me.Label7.Text = "Tipo de Cuenta:*"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(6, 90)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(96, 13)
        Me.Label12.TabIndex = 19
        Me.Label12.Text = "Unidad de medida:"
        '
        'dgPrecios
        '
        Me.dgPrecios.AllowUserToAddRows = False
        Me.dgPrecios.AllowUserToDeleteRows = False
        Me.dgPrecios.AllowUserToResizeRows = False
        Me.dgPrecios.BackgroundColor = System.Drawing.SystemColors.ControlLightLight
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgPrecios.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgPrecios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgPrecios.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.idasoc, Me.preidpre, Me.prefecha, Me.precant, Me.preprecio, Me.preimporte, Me.prepresupuesto})
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgPrecios.DefaultCellStyle = DataGridViewCellStyle2
        Me.dgPrecios.GridColor = System.Drawing.SystemColors.ControlLightLight
        Me.dgPrecios.Location = New System.Drawing.Point(6, 195)
        Me.dgPrecios.MultiSelect = False
        Me.dgPrecios.Name = "dgPrecios"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgPrecios.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.dgPrecios.RowHeadersVisible = False
        Me.dgPrecios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgPrecios.Size = New System.Drawing.Size(437, 112)
        Me.dgPrecios.TabIndex = 22
        '
        'idasoc
        '
        Me.idasoc.HeaderText = "id"
        Me.idasoc.Name = "idasoc"
        Me.idasoc.Visible = False
        '
        'preidpre
        '
        Me.preidpre.HeaderText = "idpresupuesto"
        Me.preidpre.Name = "preidpre"
        Me.preidpre.Visible = False
        '
        'prefecha
        '
        Me.prefecha.HeaderText = "Fecha"
        Me.prefecha.Name = "prefecha"
        Me.prefecha.ReadOnly = True
        Me.prefecha.Width = 80
        '
        'precant
        '
        Me.precant.HeaderText = "Cantidad"
        Me.precant.Name = "precant"
        Me.precant.ReadOnly = True
        Me.precant.Width = 60
        '
        'preprecio
        '
        Me.preprecio.HeaderText = "Precio"
        Me.preprecio.Name = "preprecio"
        Me.preprecio.ReadOnly = True
        Me.preprecio.Width = 90
        '
        'preimporte
        '
        Me.preimporte.HeaderText = "Importe"
        Me.preimporte.Name = "preimporte"
        '
        'prepresupuesto
        '
        Me.prepresupuesto.HeaderText = "Presupuesto"
        Me.prepresupuesto.Name = "prepresupuesto"
        Me.prepresupuesto.ReadOnly = True
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(3, 179)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(82, 13)
        Me.Label13.TabIndex = 23
        Me.Label13.Text = "Historial Precios"
        '
        'cbUnidad
        '
        Me.cbUnidad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbUnidad.FormattingEnabled = True
        Me.cbUnidad.Location = New System.Drawing.Point(103, 87)
        Me.cbUnidad.Name = "cbUnidad"
        Me.cbUnidad.Size = New System.Drawing.Size(102, 21)
        Me.cbUnidad.TabIndex = 24
        '
        'btnADDPrecio
        '
        Me.btnADDPrecio.BackColor = System.Drawing.Color.Blue
        Me.btnADDPrecio.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnADDPrecio.Location = New System.Drawing.Point(374, 164)
        Me.btnADDPrecio.Name = "btnADDPrecio"
        Me.btnADDPrecio.Size = New System.Drawing.Size(31, 28)
        Me.btnADDPrecio.TabIndex = 40
        Me.btnADDPrecio.Text = "+"
        Me.btnADDPrecio.UseVisualStyleBackColor = False
        '
        'btnDelPrecio
        '
        Me.btnDelPrecio.BackColor = System.Drawing.Color.Red
        Me.btnDelPrecio.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDelPrecio.Location = New System.Drawing.Point(411, 164)
        Me.btnDelPrecio.Name = "btnDelPrecio"
        Me.btnDelPrecio.Size = New System.Drawing.Size(31, 28)
        Me.btnDelPrecio.TabIndex = 41
        Me.btnDelPrecio.Text = "-"
        Me.btnDelPrecio.UseVisualStyleBackColor = False
        '
        'Panel2
        '
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.ckTipo)
        Me.Panel2.Controls.Add(Me.cbclas3)
        Me.Panel2.Controls.Add(Me.Label15)
        Me.Panel2.Controls.Add(Me.cbclas2)
        Me.Panel2.Controls.Add(Me.Label14)
        Me.Panel2.Controls.Add(Me.cbclas1)
        Me.Panel2.Controls.Add(Me.Label11)
        Me.Panel2.Controls.Add(Me.cbNombreTipo)
        Me.Panel2.Controls.Add(Me.Label10)
        Me.Panel2.Controls.Add(Me.Button1)
        Me.Panel2.Controls.Add(Me.Button2)
        Me.Panel2.Controls.Add(Me.dgFechas)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Controls.Add(Me.btnDelPrecio)
        Me.Panel2.Controls.Add(Me.btnADDPrecio)
        Me.Panel2.Controls.Add(Me.cbUnidad)
        Me.Panel2.Controls.Add(Me.Label13)
        Me.Panel2.Controls.Add(Me.dgPrecios)
        Me.Panel2.Controls.Add(Me.btnbusSub)
        Me.Panel2.Controls.Add(Me.Label12)
        Me.Panel2.Controls.Add(Me.Label7)
        Me.Panel2.Controls.Add(Me.txtSubCuenta)
        Me.Panel2.Controls.Add(Me.Label6)
        Me.Panel2.Controls.Add(Me.Label5)
        Me.Panel2.Location = New System.Drawing.Point(440, 156)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(454, 446)
        Me.Panel2.TabIndex = 7
        '
        'ckTipo
        '
        Me.ckTipo.AutoSize = True
        Me.ckTipo.Location = New System.Drawing.Point(105, 60)
        Me.ckTipo.Name = "ckTipo"
        Me.ckTipo.Size = New System.Drawing.Size(60, 17)
        Me.ckTipo.TabIndex = 54
        Me.ckTipo.Text = "Insumo"
        Me.ckTipo.UseVisualStyleBackColor = True
        '
        'cbclas3
        '
        Me.cbclas3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbclas3.FormattingEnabled = True
        Me.cbclas3.Location = New System.Drawing.Point(89, 148)
        Me.cbclas3.Name = "cbclas3"
        Me.cbclas3.Size = New System.Drawing.Size(129, 21)
        Me.cbclas3.TabIndex = 53
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(5, 151)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(78, 13)
        Me.Label15.TabIndex = 52
        Me.Label15.Text = "Clasificación 3:"
        '
        'cbclas2
        '
        Me.cbclas2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbclas2.FormattingEnabled = True
        Me.cbclas2.Location = New System.Drawing.Point(309, 121)
        Me.cbclas2.Name = "cbclas2"
        Me.cbclas2.Size = New System.Drawing.Size(137, 21)
        Me.cbclas2.TabIndex = 51
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(225, 124)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(78, 13)
        Me.Label14.TabIndex = 50
        Me.Label14.Text = "Clasificación 2:"
        '
        'cbclas1
        '
        Me.cbclas1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbclas1.FormattingEnabled = True
        Me.cbclas1.Location = New System.Drawing.Point(90, 121)
        Me.cbclas1.Name = "cbclas1"
        Me.cbclas1.Size = New System.Drawing.Size(129, 21)
        Me.cbclas1.TabIndex = 49
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(6, 124)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(78, 13)
        Me.Label11.TabIndex = 48
        Me.Label11.Text = "Clasificación 1:"
        '
        'cbNombreTipo
        '
        Me.cbNombreTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbNombreTipo.FormattingEnabled = True
        Me.cbNombreTipo.Location = New System.Drawing.Point(269, 58)
        Me.cbNombreTipo.Name = "cbNombreTipo"
        Me.cbNombreTipo.Size = New System.Drawing.Size(141, 21)
        Me.cbNombreTipo.TabIndex = 47
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(192, 61)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(71, 13)
        Me.Label10.TabIndex = 46
        Me.Label10.Text = "Nombre Tipo:"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Red
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(411, 313)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(31, 28)
        Me.Button1.TabIndex = 45
        Me.Button1.Text = "-"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.Blue
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(374, 313)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(31, 28)
        Me.Button2.TabIndex = 44
        Me.Button2.Text = "+"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'dgFechas
        '
        Me.dgFechas.AllowUserToAddRows = False
        Me.dgFechas.AllowUserToDeleteRows = False
        Me.dgFechas.AllowUserToResizeRows = False
        Me.dgFechas.BackgroundColor = System.Drawing.SystemColors.ControlLightLight
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgFechas.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.dgFechas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgFechas.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.planid, Me.plannombre, Me.planfechai, Me.planfechaF})
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgFechas.DefaultCellStyle = DataGridViewCellStyle5
        Me.dgFechas.GridColor = System.Drawing.SystemColors.ControlLightLight
        Me.dgFechas.Location = New System.Drawing.Point(6, 341)
        Me.dgFechas.MultiSelect = False
        Me.dgFechas.Name = "dgFechas"
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgFechas.RowHeadersDefaultCellStyle = DataGridViewCellStyle6
        Me.dgFechas.RowHeadersVisible = False
        Me.dgFechas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgFechas.Size = New System.Drawing.Size(437, 103)
        Me.dgFechas.TabIndex = 43
        '
        'planid
        '
        Me.planid.HeaderText = "id"
        Me.planid.Name = "planid"
        Me.planid.Visible = False
        '
        'plannombre
        '
        Me.plannombre.HeaderText = "Plan"
        Me.plannombre.Name = "plannombre"
        Me.plannombre.ReadOnly = True
        Me.plannombre.Width = 160
        '
        'planfechai
        '
        Me.planfechai.HeaderText = "Fecha Inicial"
        Me.planfechai.Name = "planfechai"
        Me.planfechai.ReadOnly = True
        Me.planfechai.Width = 130
        '
        'planfechaF
        '
        Me.planfechaF.HeaderText = "Fecha Final"
        Me.planfechaF.Name = "planfechaF"
        Me.planfechaF.ReadOnly = True
        Me.planfechaF.Width = 130
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(3, 322)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(82, 13)
        Me.Label1.TabIndex = 42
        Me.Label1.Text = "Historial Fechas"
        '
        'btnCarga
        '
        Me.btnCarga.BackColor = System.Drawing.Color.Green
        Me.btnCarga.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCarga.Image = CType(resources.GetObject("btnCarga.Image"), System.Drawing.Image)
        Me.btnCarga.Location = New System.Drawing.Point(311, 15)
        Me.btnCarga.Name = "btnCarga"
        Me.btnCarga.Size = New System.Drawing.Size(108, 57)
        Me.btnCarga.TabIndex = 36
        Me.btnCarga.Text = "Carga Cuentas"
        Me.btnCarga.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnCarga.UseVisualStyleBackColor = False
        '
        'btnSalir
        '
        Me.btnSalir.BackColor = System.Drawing.Color.Silver
        Me.btnSalir.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSalir.Image = CType(resources.GetObject("btnSalir.Image"), System.Drawing.Image)
        Me.btnSalir.Location = New System.Drawing.Point(827, 9)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(67, 52)
        Me.btnSalir.TabIndex = 35
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnSalir.UseVisualStyleBackColor = False
        '
        'btnEliminar
        '
        Me.btnEliminar.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnEliminar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEliminar.Image = CType(resources.GetObject("btnEliminar.Image"), System.Drawing.Image)
        Me.btnEliminar.Location = New System.Drawing.Point(746, 9)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(75, 52)
        Me.btnEliminar.TabIndex = 34
        Me.btnEliminar.Text = "Eliminar"
        Me.btnEliminar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnEliminar.UseVisualStyleBackColor = False
        '
        'btnGuardar
        '
        Me.btnGuardar.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnGuardar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGuardar.Image = CType(resources.GetObject("btnGuardar.Image"), System.Drawing.Image)
        Me.btnGuardar.Location = New System.Drawing.Point(584, 9)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(75, 52)
        Me.btnGuardar.TabIndex = 33
        Me.btnGuardar.Text = "Guardar"
        Me.btnGuardar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnGuardar.UseVisualStyleBackColor = False
        '
        'btnNuevo
        '
        Me.btnNuevo.BackColor = System.Drawing.Color.Yellow
        Me.btnNuevo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNuevo.Image = CType(resources.GetObject("btnNuevo.Image"), System.Drawing.Image)
        Me.btnNuevo.Location = New System.Drawing.Point(665, 9)
        Me.btnNuevo.Name = "btnNuevo"
        Me.btnNuevo.Size = New System.Drawing.Size(75, 52)
        Me.btnNuevo.TabIndex = 32
        Me.btnNuevo.Text = "Nuevo"
        Me.btnNuevo.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnNuevo.UseVisualStyleBackColor = False
        '
        'btnbusSub
        '
        Me.btnbusSub.BackColor = System.Drawing.Color.Transparent
        Me.btnbusSub.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnbusSub.Image = CType(resources.GetObject("btnbusSub.Image"), System.Drawing.Image)
        Me.btnbusSub.Location = New System.Drawing.Point(257, 29)
        Me.btnbusSub.Name = "btnbusSub"
        Me.btnbusSub.Size = New System.Drawing.Size(30, 22)
        Me.btnbusSub.TabIndex = 21
        Me.btnbusSub.UseVisualStyleBackColor = False
        '
        'btnbusCuen
        '
        Me.btnbusCuen.BackColor = System.Drawing.Color.Transparent
        Me.btnbusCuen.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnbusCuen.Image = CType(resources.GetObject("btnbusCuen.Image"), System.Drawing.Image)
        Me.btnbusCuen.Location = New System.Drawing.Point(241, 3)
        Me.btnbusCuen.Name = "btnbusCuen"
        Me.btnbusCuen.Size = New System.Drawing.Size(30, 22)
        Me.btnbusCuen.TabIndex = 22
        Me.btnbusCuen.UseVisualStyleBackColor = False
        '
        'frmCuentas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(901, 606)
        Me.Controls.Add(Me.lbObra)
        Me.Controls.Add(Me.lbEmpresa)
        Me.Controls.Add(Me.btnCarga)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.btnEliminar)
        Me.Controls.Add(Me.btnGuardar)
        Me.Controls.Add(Me.btnNuevo)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.tvCuentas)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtBuscar)
        Me.Controls.Add(Me.btnSiguien)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmCuentas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Catálogo de Cuentas"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.dgPrecios, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.dgFechas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnSiguien As Button
    Friend WithEvents txtBuscar As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents tvCuentas As TreeView
    Friend WithEvents Panel1 As Panel
    Friend WithEvents txtnombrecuenta As TextBox
    Friend WithEvents txtCuenta As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents btnSalir As Button
    Friend WithEvents btnEliminar As Button
    Friend WithEvents btnGuardar As Button
    Friend WithEvents btnNuevo As Button
    Friend WithEvents btnCarga As Button
    Friend WithEvents btnbusCuen As Button
    Friend WithEvents lbEmpresa As Label
    Friend WithEvents lbObra As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents txtSubCuenta As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents btnbusSub As Button
    Friend WithEvents dgPrecios As DataGridView
    Friend WithEvents idasoc As DataGridViewTextBoxColumn
    Friend WithEvents preidpre As DataGridViewTextBoxColumn
    Friend WithEvents prefecha As DataGridViewTextBoxColumn
    Friend WithEvents precant As DataGridViewTextBoxColumn
    Friend WithEvents preprecio As DataGridViewTextBoxColumn
    Friend WithEvents preimporte As DataGridViewTextBoxColumn
    Friend WithEvents prepresupuesto As DataGridViewTextBoxColumn
    Friend WithEvents Label13 As Label
    Friend WithEvents cbUnidad As ComboBox
    Friend WithEvents btnADDPrecio As Button
    Friend WithEvents btnDelPrecio As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents dgFechas As DataGridView
    Friend WithEvents planid As DataGridViewTextBoxColumn
    Friend WithEvents plannombre As DataGridViewTextBoxColumn
    Friend WithEvents planfechai As DataGridViewTextBoxColumn
    Friend WithEvents planfechaF As DataGridViewTextBoxColumn
    Friend WithEvents Label1 As Label
    Friend WithEvents dtFechaI As DateTimePicker
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents dtFechaF As DateTimePicker
    Friend WithEvents Label10 As Label
    Friend WithEvents cbNombreTipo As ComboBox
    Friend WithEvents cbclas3 As ComboBox
    Friend WithEvents Label15 As Label
    Friend WithEvents cbclas2 As ComboBox
    Friend WithEvents Label14 As Label
    Friend WithEvents cbclas1 As ComboBox
    Friend WithEvents Label11 As Label
    Friend WithEvents ckTipo As CheckBox
End Class
