<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCantidadInsumos
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
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.dgInsumos = New System.Windows.Forms.DataGridView()
        Me.insuidcuenta = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.insidcuentapadre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.insunidad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.inspresutotal = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.inscodcuentapadre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.insucodigo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.insuNombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.inscantidaddi = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.inscantidad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnAgregar = New System.Windows.Forms.Button()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.dgInsumos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(5, 10)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(71, 13)
        Me.Label2.TabIndex = 40
        Me.Label2.Text = "Lista Insumos"
        '
        'dgInsumos
        '
        Me.dgInsumos.AllowUserToAddRows = False
        Me.dgInsumos.AllowUserToDeleteRows = False
        Me.dgInsumos.AllowUserToResizeRows = False
        Me.dgInsumos.BackgroundColor = System.Drawing.SystemColors.ControlLightLight
        Me.dgInsumos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgInsumos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.insuidcuenta, Me.insidcuentapadre, Me.insunidad, Me.inspresutotal, Me.inscodcuentapadre, Me.insucodigo, Me.insuNombre, Me.inscantidaddi, Me.inscantidad})
        Me.dgInsumos.GridColor = System.Drawing.SystemColors.ControlLightLight
        Me.dgInsumos.Location = New System.Drawing.Point(3, 26)
        Me.dgInsumos.MultiSelect = False
        Me.dgInsumos.Name = "dgInsumos"
        Me.dgInsumos.RowHeadersVisible = False
        Me.dgInsumos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgInsumos.Size = New System.Drawing.Size(560, 262)
        Me.dgInsumos.TabIndex = 37
        '
        'insuidcuenta
        '
        Me.insuidcuenta.HeaderText = "idcuenta"
        Me.insuidcuenta.Name = "insuidcuenta"
        Me.insuidcuenta.Visible = False
        '
        'insidcuentapadre
        '
        Me.insidcuentapadre.HeaderText = "idcuentapadre"
        Me.insidcuentapadre.Name = "insidcuentapadre"
        Me.insidcuentapadre.Visible = False
        '
        'insunidad
        '
        Me.insunidad.HeaderText = "unidad"
        Me.insunidad.Name = "insunidad"
        Me.insunidad.ReadOnly = True
        Me.insunidad.Visible = False
        '
        'inspresutotal
        '
        Me.inspresutotal.HeaderText = "Presupuesto total"
        Me.inspresutotal.Name = "inspresutotal"
        Me.inspresutotal.Visible = False
        '
        'inscodcuentapadre
        '
        Me.inscodcuentapadre.HeaderText = "Codigo Padre"
        Me.inscodcuentapadre.Name = "inscodcuentapadre"
        Me.inscodcuentapadre.ReadOnly = True
        '
        'insucodigo
        '
        Me.insucodigo.HeaderText = "Codigo"
        Me.insucodigo.Name = "insucodigo"
        Me.insucodigo.ReadOnly = True
        '
        'insuNombre
        '
        Me.insuNombre.HeaderText = "Nombre"
        Me.insuNombre.Name = "insuNombre"
        Me.insuNombre.ReadOnly = True
        Me.insuNombre.Width = 180
        '
        'inscantidaddi
        '
        DataGridViewCellStyle7.Format = "N2"
        DataGridViewCellStyle7.NullValue = "0.00"
        Me.inscantidaddi.DefaultCellStyle = DataGridViewCellStyle7
        Me.inscantidaddi.HeaderText = "Cant. Disponible"
        Me.inscantidaddi.Name = "inscantidaddi"
        Me.inscantidaddi.ReadOnly = True
        '
        'inscantidad
        '
        DataGridViewCellStyle8.Format = "N2"
        DataGridViewCellStyle8.NullValue = "0"
        Me.inscantidad.DefaultCellStyle = DataGridViewCellStyle8
        Me.inscantidad.HeaderText = "Cantidad"
        Me.inscantidad.Name = "inscantidad"
        Me.inscantidad.Width = 70
        '
        'btnAgregar
        '
        Me.btnAgregar.BackColor = System.Drawing.Color.Blue
        Me.btnAgregar.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAgregar.Location = New System.Drawing.Point(166, 295)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(103, 28)
        Me.btnAgregar.TabIndex = 60
        Me.btnAgregar.Text = "Agregar"
        Me.btnAgregar.UseVisualStyleBackColor = False
        '
        'btnSalir
        '
        Me.btnSalir.BackColor = System.Drawing.SystemColors.ControlLight
        Me.btnSalir.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSalir.Location = New System.Drawing.Point(286, 294)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(103, 28)
        Me.btnSalir.TabIndex = 61
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnSalir.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(296, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(267, 13)
        Me.Label1.TabIndex = 62
        Me.Label1.Text = "Solo se agregan los que su cantidad sea diferente de 0"
        '
        'frmCantidadInsumos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(575, 335)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.btnAgregar)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.dgInsumos)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmCantidadInsumos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cantidad Insumos"
        CType(Me.dgInsumos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label2 As Label
    Friend WithEvents dgInsumos As DataGridView
    Friend WithEvents btnAgregar As Button
    Friend WithEvents btnSalir As Button
    Friend WithEvents insuidcuenta As DataGridViewTextBoxColumn
    Friend WithEvents insidcuentapadre As DataGridViewTextBoxColumn
    Friend WithEvents insunidad As DataGridViewTextBoxColumn
    Friend WithEvents inspresutotal As DataGridViewTextBoxColumn
    Friend WithEvents inscodcuentapadre As DataGridViewTextBoxColumn
    Friend WithEvents insucodigo As DataGridViewTextBoxColumn
    Friend WithEvents insuNombre As DataGridViewTextBoxColumn
    Friend WithEvents inscantidaddi As DataGridViewTextBoxColumn
    Friend WithEvents inscantidad As DataGridViewTextBoxColumn
    Friend WithEvents Label1 As Label
End Class
