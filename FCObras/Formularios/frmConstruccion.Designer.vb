<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmConstruccion
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmConstruccion))
        Me.MDigital = New System.Windows.Forms.ToolStrip()
        Me.CObra = New System.Windows.Forms.ToolStripButton()
        Me.CConfig = New System.Windows.Forms.ToolStripButton()
        Me.DCerrar = New System.Windows.Forms.ToolStripButton()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.cbsucursales = New System.Windows.Forms.ComboBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.cbempresas = New System.Windows.Forms.ComboBox()
        Me.dgOrdenes = New System.Windows.Forms.DataGridView()
        Me.comfecha = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.comserie = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.comfolio = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.comrazon = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.comtotal = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.comref = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnNuevo = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cbObras = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.MDigital.SuspendLayout()
        CType(Me.dgOrdenes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MDigital
        '
        Me.MDigital.AutoSize = False
        Me.MDigital.BackColor = System.Drawing.Color.Teal
        Me.MDigital.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CObra, Me.CConfig, Me.DCerrar})
        Me.MDigital.Location = New System.Drawing.Point(0, 0)
        Me.MDigital.Name = "MDigital"
        Me.MDigital.Size = New System.Drawing.Size(1124, 51)
        Me.MDigital.TabIndex = 28
        Me.MDigital.Text = "ToolStrip1"
        '
        'CObra
        '
        Me.CObra.AutoSize = False
        Me.CObra.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CObra.Image = CType(resources.GetObject("CObra.Image"), System.Drawing.Image)
        Me.CObra.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.CObra.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.CObra.Name = "CObra"
        Me.CObra.Size = New System.Drawing.Size(87, 48)
        Me.CObra.Text = "Obras"
        Me.CObra.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'CConfig
        '
        Me.CConfig.AutoSize = False
        Me.CConfig.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CConfig.Image = CType(resources.GetObject("CConfig.Image"), System.Drawing.Image)
        Me.CConfig.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.CConfig.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.CConfig.Name = "CConfig"
        Me.CConfig.Size = New System.Drawing.Size(87, 48)
        Me.CConfig.Text = "Configuración"
        Me.CConfig.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'DCerrar
        '
        Me.DCerrar.Image = CType(resources.GetObject("DCerrar.Image"), System.Drawing.Image)
        Me.DCerrar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.DCerrar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.DCerrar.Name = "DCerrar"
        Me.DCerrar.Size = New System.Drawing.Size(43, 48)
        Me.DCerrar.Text = "Cerrar"
        Me.DCerrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(298, 64)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(51, 13)
        Me.Label10.TabIndex = 40
        Me.Label10.Text = "Sucursal:"
        '
        'cbsucursales
        '
        Me.cbsucursales.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbsucursales.FormattingEnabled = True
        Me.cbsucursales.Location = New System.Drawing.Point(301, 80)
        Me.cbsucursales.Name = "cbsucursales"
        Me.cbsucursales.Size = New System.Drawing.Size(200, 21)
        Me.cbsucursales.TabIndex = 39
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(9, 64)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(51, 13)
        Me.Label9.TabIndex = 38
        Me.Label9.Text = "Empresa:"
        '
        'cbempresas
        '
        Me.cbempresas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbempresas.FormattingEnabled = True
        Me.cbempresas.Location = New System.Drawing.Point(12, 80)
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
        Me.dgOrdenes.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.comfecha, Me.comserie, Me.comfolio, Me.comrazon, Me.comtotal, Me.comref})
        Me.dgOrdenes.GridColor = System.Drawing.SystemColors.ControlLightLight
        Me.dgOrdenes.Location = New System.Drawing.Point(12, 132)
        Me.dgOrdenes.MultiSelect = False
        Me.dgOrdenes.Name = "dgOrdenes"
        Me.dgOrdenes.RowHeadersVisible = False
        Me.dgOrdenes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgOrdenes.Size = New System.Drawing.Size(969, 450)
        Me.dgOrdenes.TabIndex = 41
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
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 116)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(109, 13)
        Me.Label1.TabIndex = 42
        Me.Label1.Text = "Ordenes de Compras:"
        '
        'btnNuevo
        '
        Me.btnNuevo.BackColor = System.Drawing.Color.Yellow
        Me.btnNuevo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNuevo.Image = CType(resources.GetObject("btnNuevo.Image"), System.Drawing.Image)
        Me.btnNuevo.Location = New System.Drawing.Point(721, 80)
        Me.btnNuevo.Name = "btnNuevo"
        Me.btnNuevo.Size = New System.Drawing.Size(75, 52)
        Me.btnNuevo.TabIndex = 43
        Me.btnNuevo.Text = "Nuevo"
        Me.btnNuevo.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnNuevo.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(802, 116)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(179, 13)
        Me.Label2.TabIndex = 44
        Me.Label2.Text = "Doble click para abrir la orden"
        '
        'cbObras
        '
        Me.cbObras.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbObras.FormattingEnabled = True
        Me.cbObras.Location = New System.Drawing.Point(515, 80)
        Me.cbObras.Name = "cbObras"
        Me.cbObras.Size = New System.Drawing.Size(200, 21)
        Me.cbObras.TabIndex = 45
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(512, 64)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(33, 13)
        Me.Label3.TabIndex = 46
        Me.Label3.Text = "Obra:"
        '
        'frmConstruccion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ClientSize = New System.Drawing.Size(1124, 588)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.cbObras)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnNuevo)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.dgOrdenes)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.cbsucursales)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.cbempresas)
        Me.Controls.Add(Me.MDigital)
        Me.MaximizeBox = False
        Me.Name = "frmConstruccion"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Construcción"
        Me.MDigital.ResumeLayout(False)
        Me.MDigital.PerformLayout()
        CType(Me.dgOrdenes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MDigital As ToolStrip
    Friend WithEvents CConfig As ToolStripButton
    Friend WithEvents DCerrar As ToolStripButton
    Friend WithEvents CObra As ToolStripButton
    Friend WithEvents Label10 As Label
    Friend WithEvents cbsucursales As ComboBox
    Friend WithEvents Label9 As Label
    Friend WithEvents cbempresas As ComboBox
    Friend WithEvents dgOrdenes As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents btnNuevo As Button
    Friend WithEvents comfecha As DataGridViewTextBoxColumn
    Friend WithEvents comserie As DataGridViewTextBoxColumn
    Friend WithEvents comfolio As DataGridViewTextBoxColumn
    Friend WithEvents comrazon As DataGridViewTextBoxColumn
    Friend WithEvents comtotal As DataGridViewTextBoxColumn
    Friend WithEvents comref As DataGridViewTextBoxColumn
    Friend WithEvents Label2 As Label
    Friend WithEvents cbObras As ComboBox
    Friend WithEvents Label3 As Label
End Class
