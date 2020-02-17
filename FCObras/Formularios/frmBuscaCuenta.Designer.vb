<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBuscaCuenta
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
        Me.dgCuentas = New System.Windows.Forms.DataGridView()
        Me.txtBusca = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cuenid = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cuencod = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cuennombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cuenfechaini = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cuenfechafin = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cuenclas1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cuenclas2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cuenclas3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cuentipo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cueninsumo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.dgCuentas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgCuentas
        '
        Me.dgCuentas.AllowUserToAddRows = False
        Me.dgCuentas.AllowUserToDeleteRows = False
        Me.dgCuentas.AllowUserToResizeRows = False
        Me.dgCuentas.BackgroundColor = System.Drawing.SystemColors.ControlLightLight
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgCuentas.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgCuentas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgCuentas.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.cuenid, Me.cuencod, Me.cuennombre, Me.cuenfechaini, Me.cuenfechafin, Me.cuenclas1, Me.cuenclas2, Me.cuenclas3, Me.cuentipo, Me.cueninsumo})
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgCuentas.DefaultCellStyle = DataGridViewCellStyle2
        Me.dgCuentas.GridColor = System.Drawing.SystemColors.ControlLightLight
        Me.dgCuentas.Location = New System.Drawing.Point(3, 38)
        Me.dgCuentas.MultiSelect = False
        Me.dgCuentas.Name = "dgCuentas"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgCuentas.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.dgCuentas.RowHeadersVisible = False
        Me.dgCuentas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgCuentas.Size = New System.Drawing.Size(437, 175)
        Me.dgCuentas.TabIndex = 23
        '
        'txtBusca
        '
        Me.txtBusca.Location = New System.Drawing.Point(3, 12)
        Me.txtBusca.Name = "txtBusca"
        Me.txtBusca.Size = New System.Drawing.Size(437, 20)
        Me.txtBusca.TabIndex = 24
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(299, 216)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(141, 13)
        Me.Label1.TabIndex = 25
        Me.Label1.Text = "Doble click para seleccionar"
        '
        'cuenid
        '
        Me.cuenid.HeaderText = "id"
        Me.cuenid.Name = "cuenid"
        Me.cuenid.Visible = False
        '
        'cuencod
        '
        Me.cuencod.HeaderText = "Codigo Cuenta"
        Me.cuencod.Name = "cuencod"
        Me.cuencod.ReadOnly = True
        Me.cuencod.Width = 150
        '
        'cuennombre
        '
        Me.cuennombre.HeaderText = "Nombre Cuenta"
        Me.cuennombre.Name = "cuennombre"
        Me.cuennombre.ReadOnly = True
        Me.cuennombre.Width = 260
        '
        'cuenfechaini
        '
        Me.cuenfechaini.HeaderText = "fechaini"
        Me.cuenfechaini.Name = "cuenfechaini"
        Me.cuenfechaini.Visible = False
        '
        'cuenfechafin
        '
        Me.cuenfechafin.HeaderText = "fechafin"
        Me.cuenfechafin.Name = "cuenfechafin"
        Me.cuenfechafin.Visible = False
        '
        'cuenclas1
        '
        Me.cuenclas1.HeaderText = "clas1"
        Me.cuenclas1.Name = "cuenclas1"
        Me.cuenclas1.Visible = False
        '
        'cuenclas2
        '
        Me.cuenclas2.HeaderText = "clas2"
        Me.cuenclas2.Name = "cuenclas2"
        Me.cuenclas2.Visible = False
        '
        'cuenclas3
        '
        Me.cuenclas3.HeaderText = "clas3"
        Me.cuenclas3.Name = "cuenclas3"
        Me.cuenclas3.Visible = False
        '
        'cuentipo
        '
        Me.cuentipo.HeaderText = "tipo"
        Me.cuentipo.Name = "cuentipo"
        Me.cuentipo.Visible = False
        '
        'cueninsumo
        '
        Me.cueninsumo.HeaderText = "insumo"
        Me.cueninsumo.Name = "cueninsumo"
        Me.cueninsumo.Visible = False
        '
        'frmBuscaCuenta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(442, 237)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtBusca)
        Me.Controls.Add(Me.dgCuentas)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmBuscaCuenta"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Buscar Cuenta Obra"
        CType(Me.dgCuentas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dgCuentas As DataGridView
    Friend WithEvents txtBusca As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents cuenid As DataGridViewTextBoxColumn
    Friend WithEvents cuencod As DataGridViewTextBoxColumn
    Friend WithEvents cuennombre As DataGridViewTextBoxColumn
    Friend WithEvents cuenfechaini As DataGridViewTextBoxColumn
    Friend WithEvents cuenfechafin As DataGridViewTextBoxColumn
    Friend WithEvents cuenclas1 As DataGridViewTextBoxColumn
    Friend WithEvents cuenclas2 As DataGridViewTextBoxColumn
    Friend WithEvents cuenclas3 As DataGridViewTextBoxColumn
    Friend WithEvents cuentipo As DataGridViewTextBoxColumn
    Friend WithEvents cueninsumo As DataGridViewTextBoxColumn
End Class
