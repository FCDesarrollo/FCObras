<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmAsocProductos
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAsocProductos))
        Me.Label2 = New System.Windows.Forms.Label()
        Me.dgCodigos = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtBus = New System.Windows.Forms.TextBox()
        Me.rbsinasoc = New System.Windows.Forms.RadioButton()
        Me.rbasoc = New System.Windows.Forms.RadioButton()
        Me.dgProductos = New System.Windows.Forms.DataGridView()
        Me.txtbusadw = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnadd = New System.Windows.Forms.Button()
        Me.toltip = New System.Windows.Forms.ToolTip(Me.components)
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.cbsucursales = New System.Windows.Forms.ComboBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.cbempresas = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.cbObra = New System.Windows.Forms.ComboBox()
        Me.btnDesa = New System.Windows.Forms.Button()
        CType(Me.dgCodigos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgProductos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(4, 54)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(71, 13)
        Me.Label2.TabIndex = 40
        Me.Label2.Text = "Lista Insumos"
        '
        'dgCodigos
        '
        Me.dgCodigos.AllowUserToAddRows = False
        Me.dgCodigos.AllowUserToDeleteRows = False
        Me.dgCodigos.AllowUserToResizeRows = False
        Me.dgCodigos.BackgroundColor = System.Drawing.SystemColors.ControlLightLight
        Me.dgCodigos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgCodigos.GridColor = System.Drawing.SystemColors.ControlLightLight
        Me.dgCodigos.Location = New System.Drawing.Point(7, 90)
        Me.dgCodigos.MultiSelect = False
        Me.dgCodigos.Name = "dgCodigos"
        Me.dgCodigos.RowHeadersVisible = False
        Me.dgCodigos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgCodigos.Size = New System.Drawing.Size(408, 206)
        Me.dgCodigos.TabIndex = 37
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(170, 71)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(43, 13)
        Me.Label1.TabIndex = 39
        Me.Label1.Text = "Buscar:"
        '
        'txtBus
        '
        Me.txtBus.Location = New System.Drawing.Point(219, 68)
        Me.txtBus.Name = "txtBus"
        Me.txtBus.Size = New System.Drawing.Size(137, 20)
        Me.txtBus.TabIndex = 38
        '
        'rbsinasoc
        '
        Me.rbsinasoc.AutoSize = True
        Me.rbsinasoc.Checked = True
        Me.rbsinasoc.Location = New System.Drawing.Point(7, 72)
        Me.rbsinasoc.Name = "rbsinasoc"
        Me.rbsinasoc.Size = New System.Drawing.Size(78, 17)
        Me.rbsinasoc.TabIndex = 41
        Me.rbsinasoc.TabStop = True
        Me.rbsinasoc.Text = "Sin Asociar"
        Me.rbsinasoc.UseVisualStyleBackColor = True
        '
        'rbasoc
        '
        Me.rbasoc.AutoSize = True
        Me.rbasoc.Location = New System.Drawing.Point(91, 72)
        Me.rbasoc.Name = "rbasoc"
        Me.rbasoc.Size = New System.Drawing.Size(69, 17)
        Me.rbasoc.TabIndex = 42
        Me.rbasoc.Text = "Asociado"
        Me.rbasoc.UseVisualStyleBackColor = True
        '
        'dgProductos
        '
        Me.dgProductos.AllowUserToAddRows = False
        Me.dgProductos.AllowUserToDeleteRows = False
        Me.dgProductos.AllowUserToResizeRows = False
        Me.dgProductos.BackgroundColor = System.Drawing.SystemColors.ControlLightLight
        Me.dgProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgProductos.GridColor = System.Drawing.SystemColors.ControlLightLight
        Me.dgProductos.Location = New System.Drawing.Point(466, 90)
        Me.dgProductos.MultiSelect = False
        Me.dgProductos.Name = "dgProductos"
        Me.dgProductos.RowHeadersVisible = False
        Me.dgProductos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgProductos.Size = New System.Drawing.Size(290, 206)
        Me.dgProductos.TabIndex = 43
        '
        'txtbusadw
        '
        Me.txtbusadw.Location = New System.Drawing.Point(603, 69)
        Me.txtbusadw.Name = "txtbusadw"
        Me.txtbusadw.Size = New System.Drawing.Size(153, 20)
        Me.txtbusadw.TabIndex = 44
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(554, 72)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(43, 13)
        Me.Label3.TabIndex = 45
        Me.Label3.Text = "Buscar:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(463, 72)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(80, 13)
        Me.Label4.TabIndex = 46
        Me.Label4.Text = "Lista Productos"
        '
        'btnadd
        '
        Me.btnadd.Image = CType(resources.GetObject("btnadd.Image"), System.Drawing.Image)
        Me.btnadd.Location = New System.Drawing.Point(421, 139)
        Me.btnadd.Name = "btnadd"
        Me.btnadd.Size = New System.Drawing.Size(39, 36)
        Me.btnadd.TabIndex = 47
        Me.btnadd.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(9, 299)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(347, 47)
        Me.Label5.TabIndex = 50
        Me.Label5.Text = "Para Asociar" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "     - Seleccione el Insumo y el Producto ADW con el que se va Asoc" &
    "iar." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "     - Y darle click en la flecha ->->"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(260, 6)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(51, 13)
        Me.Label10.TabIndex = 54
        Me.Label10.Text = "Sucursal:"
        '
        'cbsucursales
        '
        Me.cbsucursales.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbsucursales.FormattingEnabled = True
        Me.cbsucursales.Location = New System.Drawing.Point(263, 22)
        Me.cbsucursales.Name = "cbsucursales"
        Me.cbsucursales.Size = New System.Drawing.Size(200, 21)
        Me.cbsucursales.TabIndex = 53
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(9, 6)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(51, 13)
        Me.Label9.TabIndex = 52
        Me.Label9.Text = "Empresa:"
        '
        'cbempresas
        '
        Me.cbempresas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbempresas.FormattingEnabled = True
        Me.cbempresas.Location = New System.Drawing.Point(12, 22)
        Me.cbempresas.Name = "cbempresas"
        Me.cbempresas.Size = New System.Drawing.Size(245, 21)
        Me.cbempresas.TabIndex = 51
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(472, 6)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(33, 13)
        Me.Label6.TabIndex = 55
        Me.Label6.Text = "Obra:"
        '
        'cbObra
        '
        Me.cbObra.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbObra.FormattingEnabled = True
        Me.cbObra.Location = New System.Drawing.Point(475, 22)
        Me.cbObra.Name = "cbObra"
        Me.cbObra.Size = New System.Drawing.Size(281, 21)
        Me.cbObra.TabIndex = 56
        '
        'btnDesa
        '
        Me.btnDesa.BackColor = System.Drawing.Color.Red
        Me.btnDesa.Location = New System.Drawing.Point(373, 66)
        Me.btnDesa.Name = "btnDesa"
        Me.btnDesa.Size = New System.Drawing.Size(42, 23)
        Me.btnDesa.TabIndex = 57
        Me.btnDesa.Text = "DES"
        Me.btnDesa.UseVisualStyleBackColor = False
        '
        'frmAsocProductos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(788, 355)
        Me.Controls.Add(Me.btnDesa)
        Me.Controls.Add(Me.cbObra)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.cbsucursales)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.cbempresas)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.btnadd)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtbusadw)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.dgProductos)
        Me.Controls.Add(Me.rbasoc)
        Me.Controls.Add(Me.rbsinasoc)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtBus)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.dgCodigos)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmAsocProductos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Insumos/Productos"
        CType(Me.dgCodigos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgProductos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label2 As Label
    Friend WithEvents dgCodigos As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents txtBus As TextBox
    Friend WithEvents rbsinasoc As RadioButton
    Friend WithEvents rbasoc As RadioButton
    Friend WithEvents dgProductos As DataGridView
    Friend WithEvents txtbusadw As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents btnadd As Button
    Friend WithEvents toltip As ToolTip
    Friend WithEvents Label5 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents cbsucursales As ComboBox
    Friend WithEvents Label9 As Label
    Friend WithEvents cbempresas As ComboBox
    Friend WithEvents Label6 As Label
    Friend WithEvents cbObra As ComboBox
    Friend WithEvents btnDesa As Button
End Class
