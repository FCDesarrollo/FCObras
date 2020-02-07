<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmObras
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmObras))
        Me.txtobra = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtBuscaObra = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cbEstatus = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.dtFechaI = New System.Windows.Forms.DateTimePicker()
        Me.dtFechaF = New System.Windows.Forms.DateTimePicker()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtdes = New System.Windows.Forms.TextBox()
        Me.dgPresupuesto = New System.Windows.Forms.DataGridView()
        Me.preid = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nomPresupuesto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.archPresupuesto = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.verPresu = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.btnNuevo = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.dgPlanes = New System.Windows.Forms.DataGridView()
        Me.idcrono = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nomCrono = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.btnPartidas = New System.Windows.Forms.Button()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.btnEliminar = New System.Windows.Forms.Button()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.dgObras = New System.Windows.Forms.DataGridView()
        Me.obrid = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.obrnom = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.obrestatus = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cbempresas = New System.Windows.Forms.ComboBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.cbsucursales = New System.Windows.Forms.ComboBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.btnDelPresupuesto = New System.Windows.Forms.Button()
        Me.btnADDPresupuesto = New System.Windows.Forms.Button()
        Me.btnDelPlan = New System.Windows.Forms.Button()
        Me.btnADDPlan = New System.Windows.Forms.Button()
        CType(Me.dgPresupuesto, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgPlanes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgObras, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtobra
        '
        Me.txtobra.Location = New System.Drawing.Point(322, 136)
        Me.txtobra.Name = "txtobra"
        Me.txtobra.Size = New System.Drawing.Size(278, 20)
        Me.txtobra.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(319, 120)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(99, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Nombre de la Obra:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(13, 65)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(78, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Lista de Obras:"
        '
        'txtBuscaObra
        '
        Me.txtBuscaObra.Location = New System.Drawing.Point(13, 81)
        Me.txtBuscaObra.Name = "txtBuscaObra"
        Me.txtBuscaObra.Size = New System.Drawing.Size(278, 20)
        Me.txtBuscaObra.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(623, 118)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(45, 13)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Estatus:"
        '
        'cbEstatus
        '
        Me.cbEstatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbEstatus.FormattingEnabled = True
        Me.cbEstatus.Items.AddRange(New Object() {"ACTIVA", "INACTIVA"})
        Me.cbEstatus.Location = New System.Drawing.Point(626, 134)
        Me.cbEstatus.Name = "cbEstatus"
        Me.cbEstatus.Size = New System.Drawing.Size(135, 21)
        Me.cbEstatus.TabIndex = 7
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(319, 162)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(70, 13)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Fecha Inicial:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(558, 162)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(65, 13)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Fecha Final:"
        '
        'dtFechaI
        '
        Me.dtFechaI.Location = New System.Drawing.Point(322, 178)
        Me.dtFechaI.Name = "dtFechaI"
        Me.dtFechaI.Size = New System.Drawing.Size(200, 20)
        Me.dtFechaI.TabIndex = 11
        '
        'dtFechaF
        '
        Me.dtFechaF.Location = New System.Drawing.Point(561, 178)
        Me.dtFechaF.Name = "dtFechaF"
        Me.dtFechaF.Size = New System.Drawing.Size(200, 20)
        Me.dtFechaF.TabIndex = 12
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(319, 207)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(66, 13)
        Me.Label6.TabIndex = 13
        Me.Label6.Text = "Descripción:"
        '
        'txtdes
        '
        Me.txtdes.Location = New System.Drawing.Point(322, 224)
        Me.txtdes.Multiline = True
        Me.txtdes.Name = "txtdes"
        Me.txtdes.Size = New System.Drawing.Size(439, 86)
        Me.txtdes.TabIndex = 14
        '
        'dgPresupuesto
        '
        Me.dgPresupuesto.AllowUserToAddRows = False
        Me.dgPresupuesto.AllowUserToDeleteRows = False
        Me.dgPresupuesto.AllowUserToResizeRows = False
        Me.dgPresupuesto.BackgroundColor = System.Drawing.SystemColors.ControlLightLight
        Me.dgPresupuesto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgPresupuesto.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.preid, Me.nomPresupuesto, Me.archPresupuesto, Me.verPresu})
        Me.dgPresupuesto.GridColor = System.Drawing.SystemColors.ControlLightLight
        Me.dgPresupuesto.Location = New System.Drawing.Point(322, 350)
        Me.dgPresupuesto.MultiSelect = False
        Me.dgPresupuesto.Name = "dgPresupuesto"
        Me.dgPresupuesto.RowHeadersVisible = False
        Me.dgPresupuesto.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgPresupuesto.Size = New System.Drawing.Size(374, 206)
        Me.dgPresupuesto.TabIndex = 19
        '
        'preid
        '
        Me.preid.HeaderText = "id"
        Me.preid.Name = "preid"
        Me.preid.Visible = False
        '
        'nomPresupuesto
        '
        Me.nomPresupuesto.HeaderText = "Nombre Presupuesto"
        Me.nomPresupuesto.Name = "nomPresupuesto"
        Me.nomPresupuesto.ReadOnly = True
        Me.nomPresupuesto.Width = 180
        '
        'archPresupuesto
        '
        Me.archPresupuesto.HeaderText = "Archivos"
        Me.archPresupuesto.Name = "archPresupuesto"
        Me.archPresupuesto.ReadOnly = True
        Me.archPresupuesto.Width = 130
        '
        'verPresu
        '
        Me.verPresu.HeaderText = "Ver"
        Me.verPresu.Name = "verPresu"
        Me.verPresu.ReadOnly = True
        Me.verPresu.ToolTipText = "Muestra el archivo seleccionado en la columna archivos"
        Me.verPresu.Width = 50
        '
        'btnNuevo
        '
        Me.btnNuevo.BackColor = System.Drawing.Color.Yellow
        Me.btnNuevo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNuevo.Image = CType(resources.GetObject("btnNuevo.Image"), System.Drawing.Image)
        Me.btnNuevo.Location = New System.Drawing.Point(783, 60)
        Me.btnNuevo.Name = "btnNuevo"
        Me.btnNuevo.Size = New System.Drawing.Size(75, 52)
        Me.btnNuevo.TabIndex = 21
        Me.btnNuevo.Text = "Nuevo"
        Me.btnNuevo.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnNuevo.UseVisualStyleBackColor = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(323, 335)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(74, 13)
        Me.Label7.TabIndex = 24
        Me.Label7.Text = "Presupuestos:"
        '
        'Label17
        '
        Me.Label17.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Label17.Location = New System.Drawing.Point(297, 48)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(10, 525)
        Me.Label17.TabIndex = 25
        Me.Label17.Text = "" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'dgPlanes
        '
        Me.dgPlanes.AllowUserToAddRows = False
        Me.dgPlanes.AllowUserToDeleteRows = False
        Me.dgPlanes.AllowUserToResizeRows = False
        Me.dgPlanes.BackgroundColor = System.Drawing.SystemColors.ControlLightLight
        Me.dgPlanes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgPlanes.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.idcrono, Me.nomCrono})
        Me.dgPlanes.GridColor = System.Drawing.SystemColors.ControlLightLight
        Me.dgPlanes.Location = New System.Drawing.Point(702, 350)
        Me.dgPlanes.MultiSelect = False
        Me.dgPlanes.Name = "dgPlanes"
        Me.dgPlanes.RowHeadersVisible = False
        Me.dgPlanes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgPlanes.Size = New System.Drawing.Size(197, 206)
        Me.dgPlanes.TabIndex = 26
        '
        'idcrono
        '
        Me.idcrono.HeaderText = "id"
        Me.idcrono.Name = "idcrono"
        Me.idcrono.Visible = False
        '
        'nomCrono
        '
        Me.nomCrono.HeaderText = "Nombre"
        Me.nomCrono.Name = "nomCrono"
        Me.nomCrono.ReadOnly = True
        Me.nomCrono.Width = 180
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(702, 335)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(103, 13)
        Me.Label8.TabIndex = 27
        Me.Label8.Text = "Planes Cronologicos"
        '
        'btnPartidas
        '
        Me.btnPartidas.BackColor = System.Drawing.Color.YellowGreen
        Me.btnPartidas.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPartidas.Image = CType(resources.GetObject("btnPartidas.Image"), System.Drawing.Image)
        Me.btnPartidas.ImageAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnPartidas.Location = New System.Drawing.Point(322, 60)
        Me.btnPartidas.Name = "btnPartidas"
        Me.btnPartidas.Size = New System.Drawing.Size(110, 52)
        Me.btnPartidas.TabIndex = 28
        Me.btnPartidas.Text = "Agregar Cuentas"
        Me.btnPartidas.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnPartidas.UseVisualStyleBackColor = False
        '
        'btnGuardar
        '
        Me.btnGuardar.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnGuardar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGuardar.Image = CType(resources.GetObject("btnGuardar.Image"), System.Drawing.Image)
        Me.btnGuardar.Location = New System.Drawing.Point(783, 120)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(75, 52)
        Me.btnGuardar.TabIndex = 29
        Me.btnGuardar.Text = "Guardar"
        Me.btnGuardar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnGuardar.UseVisualStyleBackColor = False
        '
        'btnEliminar
        '
        Me.btnEliminar.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnEliminar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEliminar.Image = CType(resources.GetObject("btnEliminar.Image"), System.Drawing.Image)
        Me.btnEliminar.Location = New System.Drawing.Point(783, 178)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(75, 52)
        Me.btnEliminar.TabIndex = 30
        Me.btnEliminar.Text = "Eliminar"
        Me.btnEliminar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnEliminar.UseVisualStyleBackColor = False
        '
        'btnSalir
        '
        Me.btnSalir.BackColor = System.Drawing.Color.Silver
        Me.btnSalir.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSalir.Image = CType(resources.GetObject("btnSalir.Image"), System.Drawing.Image)
        Me.btnSalir.Location = New System.Drawing.Point(783, 236)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(75, 63)
        Me.btnSalir.TabIndex = 31
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnSalir.UseVisualStyleBackColor = False
        '
        'dgObras
        '
        Me.dgObras.AllowUserToAddRows = False
        Me.dgObras.AllowUserToDeleteRows = False
        Me.dgObras.AllowUserToResizeRows = False
        Me.dgObras.BackgroundColor = System.Drawing.SystemColors.ControlLightLight
        Me.dgObras.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgObras.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.obrid, Me.obrnom, Me.obrestatus})
        Me.dgObras.GridColor = System.Drawing.SystemColors.ControlLightLight
        Me.dgObras.Location = New System.Drawing.Point(13, 107)
        Me.dgObras.MultiSelect = False
        Me.dgObras.Name = "dgObras"
        Me.dgObras.RowHeadersVisible = False
        Me.dgObras.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgObras.Size = New System.Drawing.Size(278, 449)
        Me.dgObras.TabIndex = 32
        '
        'obrid
        '
        Me.obrid.HeaderText = "id"
        Me.obrid.Name = "obrid"
        Me.obrid.Visible = False
        '
        'obrnom
        '
        Me.obrnom.HeaderText = "Nombre Obra"
        Me.obrnom.Name = "obrnom"
        Me.obrnom.ReadOnly = True
        Me.obrnom.Width = 200
        '
        'obrestatus
        '
        Me.obrestatus.HeaderText = "Estatus"
        Me.obrestatus.Name = "obrestatus"
        Me.obrestatus.ReadOnly = True
        Me.obrestatus.Width = 70
        '
        'cbempresas
        '
        Me.cbempresas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbempresas.FormattingEnabled = True
        Me.cbempresas.Location = New System.Drawing.Point(16, 24)
        Me.cbempresas.Name = "cbempresas"
        Me.cbempresas.Size = New System.Drawing.Size(275, 21)
        Me.cbempresas.TabIndex = 33
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(13, 8)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(51, 13)
        Me.Label9.TabIndex = 34
        Me.Label9.Text = "Empresa:"
        '
        'cbsucursales
        '
        Me.cbsucursales.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbsucursales.FormattingEnabled = True
        Me.cbsucursales.Location = New System.Drawing.Point(322, 24)
        Me.cbsucursales.Name = "cbsucursales"
        Me.cbsucursales.Size = New System.Drawing.Size(200, 21)
        Me.cbsucursales.TabIndex = 35
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(319, 8)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(51, 13)
        Me.Label10.TabIndex = 36
        Me.Label10.Text = "Sucursal:"
        '
        'Label11
        '
        Me.Label11.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Label11.Location = New System.Drawing.Point(15, 48)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(890, 10)
        Me.Label11.TabIndex = 37
        Me.Label11.Text = "" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'btnDelPresupuesto
        '
        Me.btnDelPresupuesto.BackColor = System.Drawing.Color.Red
        Me.btnDelPresupuesto.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDelPresupuesto.Location = New System.Drawing.Point(641, 322)
        Me.btnDelPresupuesto.Name = "btnDelPresupuesto"
        Me.btnDelPresupuesto.Size = New System.Drawing.Size(31, 28)
        Me.btnDelPresupuesto.TabIndex = 39
        Me.btnDelPresupuesto.Text = "-"
        Me.btnDelPresupuesto.UseVisualStyleBackColor = False
        '
        'btnADDPresupuesto
        '
        Me.btnADDPresupuesto.BackColor = System.Drawing.Color.Blue
        Me.btnADDPresupuesto.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnADDPresupuesto.Location = New System.Drawing.Point(604, 322)
        Me.btnADDPresupuesto.Name = "btnADDPresupuesto"
        Me.btnADDPresupuesto.Size = New System.Drawing.Size(31, 28)
        Me.btnADDPresupuesto.TabIndex = 38
        Me.btnADDPresupuesto.Text = "+"
        Me.btnADDPresupuesto.UseVisualStyleBackColor = False
        '
        'btnDelPlan
        '
        Me.btnDelPlan.BackColor = System.Drawing.Color.Red
        Me.btnDelPlan.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDelPlan.Location = New System.Drawing.Point(874, 322)
        Me.btnDelPlan.Name = "btnDelPlan"
        Me.btnDelPlan.Size = New System.Drawing.Size(31, 28)
        Me.btnDelPlan.TabIndex = 41
        Me.btnDelPlan.Text = "-"
        Me.btnDelPlan.UseVisualStyleBackColor = False
        '
        'btnADDPlan
        '
        Me.btnADDPlan.BackColor = System.Drawing.Color.Blue
        Me.btnADDPlan.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnADDPlan.Location = New System.Drawing.Point(837, 322)
        Me.btnADDPlan.Name = "btnADDPlan"
        Me.btnADDPlan.Size = New System.Drawing.Size(31, 28)
        Me.btnADDPlan.TabIndex = 40
        Me.btnADDPlan.Text = "+"
        Me.btnADDPlan.UseVisualStyleBackColor = False
        '
        'frmObras
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ClientSize = New System.Drawing.Size(910, 566)
        Me.Controls.Add(Me.btnDelPlan)
        Me.Controls.Add(Me.btnADDPlan)
        Me.Controls.Add(Me.btnDelPresupuesto)
        Me.Controls.Add(Me.btnADDPresupuesto)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.cbsucursales)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.cbempresas)
        Me.Controls.Add(Me.dgObras)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.btnEliminar)
        Me.Controls.Add(Me.btnGuardar)
        Me.Controls.Add(Me.btnPartidas)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.dgPlanes)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.btnNuevo)
        Me.Controls.Add(Me.dgPresupuesto)
        Me.Controls.Add(Me.txtdes)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.dtFechaF)
        Me.Controls.Add(Me.dtFechaI)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.cbEstatus)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtBuscaObra)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtobra)
        Me.MaximizeBox = False
        Me.Name = "frmObras"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Obras"
        CType(Me.dgPresupuesto, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgPlanes, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgObras, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtobra As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtBuscaObra As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents cbEstatus As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents dtFechaI As DateTimePicker
    Friend WithEvents dtFechaF As DateTimePicker
    Friend WithEvents Label6 As Label
    Friend WithEvents txtdes As TextBox
    Friend WithEvents dgPresupuesto As DataGridView
    Friend WithEvents btnNuevo As Button
    Friend WithEvents Label7 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents dgPlanes As DataGridView
    Friend WithEvents Label8 As Label
    Friend WithEvents idcrono As DataGridViewTextBoxColumn
    Friend WithEvents nomCrono As DataGridViewTextBoxColumn
    Friend WithEvents btnPartidas As Button
    Friend WithEvents btnGuardar As Button
    Friend WithEvents btnEliminar As Button
    Friend WithEvents btnSalir As Button
    Friend WithEvents dgObras As DataGridView
    Friend WithEvents cbempresas As ComboBox
    Friend WithEvents Label9 As Label
    Friend WithEvents cbsucursales As ComboBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents obrid As DataGridViewTextBoxColumn
    Friend WithEvents obrnom As DataGridViewTextBoxColumn
    Friend WithEvents obrestatus As DataGridViewTextBoxColumn
    Friend WithEvents btnDelPresupuesto As Button
    Friend WithEvents btnADDPresupuesto As Button
    Friend WithEvents btnDelPlan As Button
    Friend WithEvents btnADDPlan As Button
    Friend WithEvents preid As DataGridViewTextBoxColumn
    Friend WithEvents nomPresupuesto As DataGridViewTextBoxColumn
    Friend WithEvents archPresupuesto As DataGridViewComboBoxColumn
    Friend WithEvents verPresu As DataGridViewButtonColumn
End Class
