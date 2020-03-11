<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmInsumos
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
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtBus = New System.Windows.Forms.TextBox()
        Me.dgInsumos = New System.Windows.Forms.DataGridView()
        Me.insuidcuenta = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.insunidad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.insucodigo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.insuNombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.dgInsumos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(235, 250)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(141, 13)
        Me.Label3.TabIndex = 36
        Me.Label3.Text = "Doble click para seleccionar"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(71, 13)
        Me.Label2.TabIndex = 35
        Me.Label2.Text = "Lista Insumos"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(98, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(43, 13)
        Me.Label1.TabIndex = 34
        Me.Label1.Text = "Buscar:"
        '
        'txtBus
        '
        Me.txtBus.Location = New System.Drawing.Point(143, 4)
        Me.txtBus.Name = "txtBus"
        Me.txtBus.Size = New System.Drawing.Size(233, 20)
        Me.txtBus.TabIndex = 33
        '
        'dgInsumos
        '
        Me.dgInsumos.AllowUserToAddRows = False
        Me.dgInsumos.AllowUserToDeleteRows = False
        Me.dgInsumos.AllowUserToResizeRows = False
        Me.dgInsumos.BackgroundColor = System.Drawing.SystemColors.ControlLightLight
        Me.dgInsumos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgInsumos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.insuidcuenta, Me.insunidad, Me.insucodigo, Me.insuNombre})
        Me.dgInsumos.GridColor = System.Drawing.SystemColors.ControlLightLight
        Me.dgInsumos.Location = New System.Drawing.Point(10, 25)
        Me.dgInsumos.MultiSelect = False
        Me.dgInsumos.Name = "dgInsumos"
        Me.dgInsumos.RowHeadersVisible = False
        Me.dgInsumos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgInsumos.Size = New System.Drawing.Size(366, 223)
        Me.dgInsumos.TabIndex = 32
        '
        'insuidcuenta
        '
        Me.insuidcuenta.HeaderText = "idcuenta"
        Me.insuidcuenta.Name = "insuidcuenta"
        Me.insuidcuenta.Visible = False
        '
        'insunidad
        '
        Me.insunidad.HeaderText = "unidad"
        Me.insunidad.Name = "insunidad"
        Me.insunidad.ReadOnly = True
        Me.insunidad.Visible = False
        '
        'insucodigo
        '
        Me.insucodigo.HeaderText = "Codigo"
        Me.insucodigo.Name = "insucodigo"
        Me.insucodigo.ReadOnly = True
        Me.insucodigo.Width = 120
        '
        'insuNombre
        '
        Me.insuNombre.HeaderText = "Nombre"
        Me.insuNombre.Name = "insuNombre"
        Me.insuNombre.ReadOnly = True
        Me.insuNombre.Width = 240
        '
        'frmInsumos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(380, 272)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtBus)
        Me.Controls.Add(Me.dgInsumos)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmInsumos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Insumos"
        CType(Me.dgInsumos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtBus As TextBox
    Friend WithEvents dgInsumos As DataGridView
    Friend WithEvents insuidcuenta As DataGridViewTextBoxColumn
    Friend WithEvents insunidad As DataGridViewTextBoxColumn
    Friend WithEvents insucodigo As DataGridViewTextBoxColumn
    Friend WithEvents insuNombre As DataGridViewTextBoxColumn
End Class
