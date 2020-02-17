<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmOrden
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmOrden))
        Me.Label10 = New System.Windows.Forms.Label()
        Me.cbObra = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dtFecha = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtCodigo = New System.Windows.Forms.TextBox()
        Me.cbMoneda = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtSerie = New System.Windows.Forms.TextBox()
        Me.txtFolio = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtTipocambio = New System.Windows.Forms.TextBox()
        Me.dgMov = New System.Windows.Forms.DataGridView()
        Me.movidcuen = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.movidcuentapadre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.movCodigo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.movcuenta = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.movbus = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.movUni = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.movcant = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.movPre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.movTota = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.movcantidadT = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.movprecioT = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.movtotalT = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.btnEliminar = New System.Windows.Forms.Button()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.btnNuevo = New System.Windows.Forms.Button()
        Me.btnbusca = New System.Windows.Forms.Button()
        CType(Me.dgMov, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(9, 7)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(34, 13)
        Me.Label10.TabIndex = 42
        Me.Label10.Text = "Obra*"
        '
        'cbObra
        '
        Me.cbObra.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbObra.FormattingEnabled = True
        Me.cbObra.Location = New System.Drawing.Point(64, 4)
        Me.cbObra.Name = "cbObra"
        Me.cbObra.Size = New System.Drawing.Size(200, 21)
        Me.cbObra.TabIndex = 41
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(9, 39)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(41, 13)
        Me.Label1.TabIndex = 43
        Me.Label1.Text = "Fecha*"
        '
        'dtFecha
        '
        Me.dtFecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtFecha.Location = New System.Drawing.Point(64, 33)
        Me.dtFecha.Name = "dtFecha"
        Me.dtFecha.Size = New System.Drawing.Size(108, 20)
        Me.dtFecha.TabIndex = 44
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(9, 95)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(48, 13)
        Me.Label2.TabIndex = 45
        Me.Label2.Text = "Nombre*"
        '
        'txtNombre
        '
        Me.txtNombre.Enabled = False
        Me.txtNombre.Location = New System.Drawing.Point(64, 92)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(344, 20)
        Me.txtNombre.TabIndex = 46
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(9, 66)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(44, 13)
        Me.Label3.TabIndex = 47
        Me.Label3.Text = "Codigo*"
        '
        'txtCodigo
        '
        Me.txtCodigo.Location = New System.Drawing.Point(64, 63)
        Me.txtCodigo.Name = "txtCodigo"
        Me.txtCodigo.Size = New System.Drawing.Size(188, 20)
        Me.txtCodigo.TabIndex = 48
        '
        'cbMoneda
        '
        Me.cbMoneda.FormattingEnabled = True
        Me.cbMoneda.Location = New System.Drawing.Point(689, 8)
        Me.cbMoneda.Name = "cbMoneda"
        Me.cbMoneda.Size = New System.Drawing.Size(90, 21)
        Me.cbMoneda.TabIndex = 50
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(428, 45)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(33, 13)
        Me.Label4.TabIndex = 52
        Me.Label4.Text = "Folio*"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(428, 12)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(31, 13)
        Me.Label5.TabIndex = 51
        Me.Label5.Text = "Serie"
        '
        'txtSerie
        '
        Me.txtSerie.Location = New System.Drawing.Point(465, 9)
        Me.txtSerie.Name = "txtSerie"
        Me.txtSerie.Size = New System.Drawing.Size(104, 20)
        Me.txtSerie.TabIndex = 53
        '
        'txtFolio
        '
        Me.txtFolio.Location = New System.Drawing.Point(465, 41)
        Me.txtFolio.Name = "txtFolio"
        Me.txtFolio.Size = New System.Drawing.Size(104, 20)
        Me.txtFolio.TabIndex = 54
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(605, 12)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(46, 13)
        Me.Label6.TabIndex = 55
        Me.Label6.Text = "Moneda"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(605, 45)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(81, 13)
        Me.Label7.TabIndex = 56
        Me.Label7.Text = "Tipo de Cambio"
        '
        'txtTipocambio
        '
        Me.txtTipocambio.Location = New System.Drawing.Point(689, 42)
        Me.txtTipocambio.Name = "txtTipocambio"
        Me.txtTipocambio.Size = New System.Drawing.Size(90, 20)
        Me.txtTipocambio.TabIndex = 57
        '
        'dgMov
        '
        Me.dgMov.AllowUserToResizeColumns = False
        Me.dgMov.BackgroundColor = System.Drawing.Color.White
        Me.dgMov.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgMov.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.movidcuen, Me.movidcuentapadre, Me.movCodigo, Me.movcuenta, Me.movbus, Me.movUni, Me.movcant, Me.movPre, Me.movTota, Me.movcantidadT, Me.movprecioT, Me.movtotalT})
        Me.dgMov.Location = New System.Drawing.Point(12, 161)
        Me.dgMov.Name = "dgMov"
        Me.dgMov.RowHeadersVisible = False
        Me.dgMov.Size = New System.Drawing.Size(767, 261)
        Me.dgMov.TabIndex = 58
        '
        'movidcuen
        '
        Me.movidcuen.HeaderText = "idcuenta"
        Me.movidcuen.Name = "movidcuen"
        Me.movidcuen.Visible = False
        '
        'movidcuentapadre
        '
        Me.movidcuentapadre.HeaderText = "idcuentapadre"
        Me.movidcuentapadre.Name = "movidcuentapadre"
        Me.movidcuentapadre.Visible = False
        '
        'movCodigo
        '
        Me.movCodigo.HeaderText = "Codigo"
        Me.movCodigo.Name = "movCodigo"
        Me.movCodigo.Width = 120
        '
        'movcuenta
        '
        Me.movcuenta.HeaderText = "Nombre Cuenta"
        Me.movcuenta.Name = "movcuenta"
        Me.movcuenta.ReadOnly = True
        Me.movcuenta.Width = 200
        '
        'movbus
        '
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.movbus.DefaultCellStyle = DataGridViewCellStyle1
        Me.movbus.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.movbus.HeaderText = ""
        Me.movbus.Name = "movbus"
        Me.movbus.ReadOnly = True
        Me.movbus.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.movbus.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.movbus.Text = "O"
        Me.movbus.ToolTipText = "Buscar Codigo"
        Me.movbus.Width = 30
        '
        'movUni
        '
        Me.movUni.HeaderText = "Unidad"
        Me.movUni.Name = "movUni"
        Me.movUni.ReadOnly = True
        '
        'movcant
        '
        DataGridViewCellStyle2.Format = "N2"
        DataGridViewCellStyle2.NullValue = Nothing
        Me.movcant.DefaultCellStyle = DataGridViewCellStyle2
        Me.movcant.HeaderText = "Cantidad"
        Me.movcant.Name = "movcant"
        '
        'movPre
        '
        DataGridViewCellStyle3.Format = "N2"
        DataGridViewCellStyle3.NullValue = Nothing
        Me.movPre.DefaultCellStyle = DataGridViewCellStyle3
        Me.movPre.HeaderText = "Precio"
        Me.movPre.Name = "movPre"
        Me.movPre.ReadOnly = True
        '
        'movTota
        '
        DataGridViewCellStyle4.Format = "N2"
        DataGridViewCellStyle4.NullValue = Nothing
        Me.movTota.DefaultCellStyle = DataGridViewCellStyle4
        Me.movTota.HeaderText = "Total"
        Me.movTota.Name = "movTota"
        Me.movTota.ReadOnly = True
        Me.movTota.Width = 120
        '
        'movcantidadT
        '
        Me.movcantidadT.HeaderText = "Cantidad total"
        Me.movcantidadT.Name = "movcantidadT"
        Me.movcantidadT.Visible = False
        '
        'movprecioT
        '
        Me.movprecioT.HeaderText = "Precio Total"
        Me.movprecioT.Name = "movprecioT"
        Me.movprecioT.Visible = False
        '
        'movtotalT
        '
        Me.movtotalT.HeaderText = "Total total"
        Me.movtotalT.Name = "movtotalT"
        Me.movtotalT.Visible = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(14, 145)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(66, 13)
        Me.Label8.TabIndex = 59
        Me.Label8.Text = "Movimientos"
        '
        'btnEliminar
        '
        Me.btnEliminar.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnEliminar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEliminar.Image = CType(resources.GetObject("btnEliminar.Image"), System.Drawing.Image)
        Me.btnEliminar.Location = New System.Drawing.Point(701, 103)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(75, 52)
        Me.btnEliminar.TabIndex = 62
        Me.btnEliminar.Text = "Eliminar"
        Me.btnEliminar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnEliminar.UseVisualStyleBackColor = False
        '
        'btnGuardar
        '
        Me.btnGuardar.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnGuardar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGuardar.Image = CType(resources.GetObject("btnGuardar.Image"), System.Drawing.Image)
        Me.btnGuardar.Location = New System.Drawing.Point(539, 103)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(75, 52)
        Me.btnGuardar.TabIndex = 61
        Me.btnGuardar.Text = "Guardar"
        Me.btnGuardar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnGuardar.UseVisualStyleBackColor = False
        '
        'btnNuevo
        '
        Me.btnNuevo.BackColor = System.Drawing.Color.Yellow
        Me.btnNuevo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNuevo.Image = CType(resources.GetObject("btnNuevo.Image"), System.Drawing.Image)
        Me.btnNuevo.Location = New System.Drawing.Point(620, 103)
        Me.btnNuevo.Name = "btnNuevo"
        Me.btnNuevo.Size = New System.Drawing.Size(75, 52)
        Me.btnNuevo.TabIndex = 60
        Me.btnNuevo.Text = "Nuevo"
        Me.btnNuevo.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnNuevo.UseVisualStyleBackColor = False
        '
        'btnbusca
        '
        Me.btnbusca.BackColor = System.Drawing.Color.Transparent
        Me.btnbusca.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnbusca.Image = Global.FCConstruccion.My.Resources.Resources.search_18
        Me.btnbusca.Location = New System.Drawing.Point(256, 62)
        Me.btnbusca.Name = "btnbusca"
        Me.btnbusca.Size = New System.Drawing.Size(30, 22)
        Me.btnbusca.TabIndex = 49
        Me.btnbusca.UseVisualStyleBackColor = False
        '
        'frmOrden
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnEliminar)
        Me.Controls.Add(Me.btnGuardar)
        Me.Controls.Add(Me.btnNuevo)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.dgMov)
        Me.Controls.Add(Me.txtTipocambio)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtFolio)
        Me.Controls.Add(Me.txtSerie)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.cbMoneda)
        Me.Controls.Add(Me.btnbusca)
        Me.Controls.Add(Me.txtCodigo)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtNombre)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.dtFecha)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.cbObra)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmOrden"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Orden"
        CType(Me.dgMov, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label10 As Label
    Friend WithEvents cbObra As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents dtFecha As DateTimePicker
    Friend WithEvents Label2 As Label
    Friend WithEvents txtNombre As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtCodigo As TextBox
    Friend WithEvents btnbusca As Button
    Friend WithEvents cbMoneda As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txtSerie As TextBox
    Friend WithEvents txtFolio As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents txtTipocambio As TextBox
    Friend WithEvents dgMov As DataGridView
    Friend WithEvents Label8 As Label
    Friend WithEvents btnEliminar As Button
    Friend WithEvents btnGuardar As Button
    Friend WithEvents btnNuevo As Button
    Friend WithEvents movidcuen As DataGridViewTextBoxColumn
    Friend WithEvents movidcuentapadre As DataGridViewTextBoxColumn
    Friend WithEvents movCodigo As DataGridViewTextBoxColumn
    Friend WithEvents movcuenta As DataGridViewTextBoxColumn
    Friend WithEvents movbus As DataGridViewButtonColumn
    Friend WithEvents movUni As DataGridViewTextBoxColumn
    Friend WithEvents movcant As DataGridViewTextBoxColumn
    Friend WithEvents movPre As DataGridViewTextBoxColumn
    Friend WithEvents movTota As DataGridViewTextBoxColumn
    Friend WithEvents movcantidadT As DataGridViewTextBoxColumn
    Friend WithEvents movprecioT As DataGridViewTextBoxColumn
    Friend WithEvents movtotalT As DataGridViewTextBoxColumn
End Class
