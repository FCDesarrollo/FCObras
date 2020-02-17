<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmOrdenes
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmOrdenes))
        Me.Label10 = New System.Windows.Forms.Label()
        Me.cbsucursales = New System.Windows.Forms.ComboBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.cbempresas = New System.Windows.Forms.ComboBox()
        Me.dgOrdenes = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnNuevo = New System.Windows.Forms.Button()
        Me.ord = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.comfecha = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.comserie = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.comfolio = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.comrazon = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.comtotal = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.comref = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.dgOrdenes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(297, 8)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(51, 13)
        Me.Label10.TabIndex = 40
        Me.Label10.Text = "Sucursal:"
        '
        'cbsucursales
        '
        Me.cbsucursales.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbsucursales.FormattingEnabled = True
        Me.cbsucursales.Location = New System.Drawing.Point(300, 24)
        Me.cbsucursales.Name = "cbsucursales"
        Me.cbsucursales.Size = New System.Drawing.Size(200, 21)
        Me.cbsucursales.TabIndex = 39
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(8, 8)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(51, 13)
        Me.Label9.TabIndex = 38
        Me.Label9.Text = "Empresa:"
        '
        'cbempresas
        '
        Me.cbempresas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbempresas.FormattingEnabled = True
        Me.cbempresas.Location = New System.Drawing.Point(11, 24)
        Me.cbempresas.Name = "cbempresas"
        Me.cbempresas.Size = New System.Drawing.Size(275, 21)
        Me.cbempresas.TabIndex = 37
        '
        'dgOrdenes
        '
        Me.dgOrdenes.AllowUserToAddRows = False
        Me.dgOrdenes.AllowUserToDeleteRows = False
        Me.dgOrdenes.AllowUserToResizeRows = False
        Me.dgOrdenes.BackgroundColor = System.Drawing.SystemColors.ControlLightLight
        Me.dgOrdenes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgOrdenes.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ord, Me.comfecha, Me.comserie, Me.comfolio, Me.comrazon, Me.comtotal, Me.comref})
        Me.dgOrdenes.GridColor = System.Drawing.SystemColors.ControlLightLight
        Me.dgOrdenes.Location = New System.Drawing.Point(11, 76)
        Me.dgOrdenes.MultiSelect = False
        Me.dgOrdenes.Name = "dgOrdenes"
        Me.dgOrdenes.RowHeadersVisible = False
        Me.dgOrdenes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgOrdenes.Size = New System.Drawing.Size(969, 450)
        Me.dgOrdenes.TabIndex = 41
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(11, 60)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(109, 13)
        Me.Label1.TabIndex = 42
        Me.Label1.Text = "Ordenes de Compras:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(801, 60)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(179, 13)
        Me.Label2.TabIndex = 44
        Me.Label2.Text = "Doble click para abrir la orden"
        '
        'btnNuevo
        '
        Me.btnNuevo.BackColor = System.Drawing.Color.Yellow
        Me.btnNuevo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNuevo.Image = CType(resources.GetObject("btnNuevo.Image"), System.Drawing.Image)
        Me.btnNuevo.Location = New System.Drawing.Point(523, 24)
        Me.btnNuevo.Name = "btnNuevo"
        Me.btnNuevo.Size = New System.Drawing.Size(75, 52)
        Me.btnNuevo.TabIndex = 43
        Me.btnNuevo.Text = "Nuevo"
        Me.btnNuevo.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnNuevo.UseVisualStyleBackColor = False
        '
        'ord
        '
        Me.ord.HeaderText = "Obra"
        Me.ord.Name = "ord"
        Me.ord.Width = 200
        '
        'comfecha
        '
        Me.comfecha.HeaderText = "Fecha"
        Me.comfecha.Name = "comfecha"
        Me.comfecha.ReadOnly = True
        '
        'comserie
        '
        Me.comserie.HeaderText = "Serie"
        Me.comserie.Name = "comserie"
        Me.comserie.ReadOnly = True
        Me.comserie.Width = 50
        '
        'comfolio
        '
        Me.comfolio.HeaderText = "Folio"
        Me.comfolio.Name = "comfolio"
        Me.comfolio.ReadOnly = True
        Me.comfolio.Width = 80
        '
        'comrazon
        '
        Me.comrazon.HeaderText = "Razón Social"
        Me.comrazon.Name = "comrazon"
        Me.comrazon.ReadOnly = True
        Me.comrazon.Width = 220
        '
        'comtotal
        '
        Me.comtotal.HeaderText = "Total"
        Me.comtotal.Name = "comtotal"
        Me.comtotal.ReadOnly = True
        '
        'comref
        '
        Me.comref.HeaderText = "Referencia"
        Me.comref.Name = "comref"
        Me.comref.ReadOnly = True
        Me.comref.Width = 180
        '
        'frmOrdenes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ClientSize = New System.Drawing.Size(986, 588)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnNuevo)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.dgOrdenes)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.cbsucursales)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.cbempresas)
        Me.MaximizeBox = False
        Me.Name = "frmOrdenes"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Ordenes de Compra"
        CType(Me.dgOrdenes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label10 As Label
    Friend WithEvents cbsucursales As ComboBox
    Friend WithEvents Label9 As Label
    Friend WithEvents cbempresas As ComboBox
    Friend WithEvents dgOrdenes As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents btnNuevo As Button
    Friend WithEvents ord As DataGridViewTextBoxColumn
    Friend WithEvents comfecha As DataGridViewTextBoxColumn
    Friend WithEvents comserie As DataGridViewTextBoxColumn
    Friend WithEvents comfolio As DataGridViewTextBoxColumn
    Friend WithEvents comrazon As DataGridViewTextBoxColumn
    Friend WithEvents comtotal As DataGridViewTextBoxColumn
    Friend WithEvents comref As DataGridViewTextBoxColumn
End Class
