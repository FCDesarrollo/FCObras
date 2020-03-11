<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAgregaCat
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
        Me.Label9 = New System.Windows.Forms.Label()
        Me.dgCatalogo = New System.Windows.Forms.DataGridView()
        Me.uniid = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.unicodigo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.uninombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtnombre = New System.Windows.Forms.TextBox()
        Me.txtclave = New System.Windows.Forms.TextBox()
        Me.btnEliminar = New System.Windows.Forms.Button()
        Me.btnAgregar = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cbEmpresas = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        CType(Me.dgCatalogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(12, 146)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(49, 13)
        Me.Label9.TabIndex = 36
        Me.Label9.Text = "Catalogo"
        '
        'dgCatalogo
        '
        Me.dgCatalogo.AllowUserToAddRows = False
        Me.dgCatalogo.AllowUserToDeleteRows = False
        Me.dgCatalogo.AllowUserToResizeRows = False
        Me.dgCatalogo.BackgroundColor = System.Drawing.SystemColors.ControlLightLight
        Me.dgCatalogo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgCatalogo.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.uniid, Me.unicodigo, Me.uninombre})
        Me.dgCatalogo.GridColor = System.Drawing.SystemColors.ControlLightLight
        Me.dgCatalogo.Location = New System.Drawing.Point(12, 162)
        Me.dgCatalogo.MultiSelect = False
        Me.dgCatalogo.Name = "dgCatalogo"
        Me.dgCatalogo.RowHeadersVisible = False
        Me.dgCatalogo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgCatalogo.Size = New System.Drawing.Size(327, 176)
        Me.dgCatalogo.TabIndex = 35
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
        '
        'uninombre
        '
        Me.uninombre.HeaderText = "Nombre"
        Me.uninombre.Name = "uninombre"
        Me.uninombre.ReadOnly = True
        Me.uninombre.Width = 210
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(13, 72)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(44, 13)
        Me.Label2.TabIndex = 58
        Me.Label2.Text = "Nombre"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 46)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(40, 13)
        Me.Label1.TabIndex = 57
        Me.Label1.Text = "Codigo"
        '
        'txtnombre
        '
        Me.txtnombre.Location = New System.Drawing.Point(59, 72)
        Me.txtnombre.Name = "txtnombre"
        Me.txtnombre.Size = New System.Drawing.Size(233, 20)
        Me.txtnombre.TabIndex = 56
        '
        'txtclave
        '
        Me.txtclave.Location = New System.Drawing.Point(59, 46)
        Me.txtclave.Name = "txtclave"
        Me.txtclave.Size = New System.Drawing.Size(233, 20)
        Me.txtclave.TabIndex = 55
        Me.txtclave.Tag = "0"
        '
        'btnEliminar
        '
        Me.btnEliminar.BackColor = System.Drawing.Color.Red
        Me.btnEliminar.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEliminar.Location = New System.Drawing.Point(168, 98)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(106, 28)
        Me.btnEliminar.TabIndex = 60
        Me.btnEliminar.Text = "- Eliminar"
        Me.btnEliminar.UseVisualStyleBackColor = False
        '
        'btnAgregar
        '
        Me.btnAgregar.BackColor = System.Drawing.Color.Blue
        Me.btnAgregar.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAgregar.Location = New System.Drawing.Point(59, 98)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(103, 28)
        Me.btnAgregar.TabIndex = 59
        Me.btnAgregar.Text = "+ Agregar"
        Me.btnAgregar.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(195, 341)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(144, 13)
        Me.Label3.TabIndex = 61
        Me.Label3.Text = "Doble click para seleccionar "
        '
        'cbEmpresas
        '
        Me.cbEmpresas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbEmpresas.FormattingEnabled = True
        Me.cbEmpresas.Location = New System.Drawing.Point(59, 12)
        Me.cbEmpresas.Name = "cbEmpresas"
        Me.cbEmpresas.Size = New System.Drawing.Size(233, 21)
        Me.cbEmpresas.TabIndex = 63
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(9, 15)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(48, 13)
        Me.Label5.TabIndex = 62
        Me.Label5.Text = "Empresa"
        '
        'frmAgregaCat
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(351, 357)
        Me.Controls.Add(Me.cbEmpresas)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.btnEliminar)
        Me.Controls.Add(Me.btnAgregar)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtnombre)
        Me.Controls.Add(Me.txtclave)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.dgCatalogo)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmAgregaCat"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Agrega"
        CType(Me.dgCatalogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label9 As Label
    Friend WithEvents dgCatalogo As DataGridView
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtnombre As TextBox
    Friend WithEvents txtclave As TextBox
    Friend WithEvents uniid As DataGridViewTextBoxColumn
    Friend WithEvents unicodigo As DataGridViewTextBoxColumn
    Friend WithEvents uninombre As DataGridViewTextBoxColumn
    Friend WithEvents btnEliminar As Button
    Friend WithEvents btnAgregar As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents cbEmpresas As ComboBox
    Friend WithEvents Label5 As Label
End Class
