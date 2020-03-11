<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmEmpresasAdw
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
        Me.dgEmpresas = New System.Windows.Forms.DataGridView()
        Me.contid = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.empbdd = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.empsele = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.empnom = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.empsucu = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.rbAdmin = New System.Windows.Forms.RadioButton()
        Me.rbcomercial = New System.Windows.Forms.RadioButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.btnAgregar = New System.Windows.Forms.Button()
        CType(Me.dgEmpresas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgEmpresas
        '
        Me.dgEmpresas.AllowUserToAddRows = False
        Me.dgEmpresas.AllowUserToDeleteRows = False
        Me.dgEmpresas.AllowUserToResizeRows = False
        Me.dgEmpresas.BackgroundColor = System.Drawing.SystemColors.ControlLightLight
        Me.dgEmpresas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgEmpresas.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.contid, Me.empbdd, Me.empsele, Me.empnom, Me.empsucu})
        Me.dgEmpresas.GridColor = System.Drawing.SystemColors.ControlLightLight
        Me.dgEmpresas.Location = New System.Drawing.Point(5, 42)
        Me.dgEmpresas.MultiSelect = False
        Me.dgEmpresas.Name = "dgEmpresas"
        Me.dgEmpresas.RowHeadersVisible = False
        Me.dgEmpresas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgEmpresas.Size = New System.Drawing.Size(525, 275)
        Me.dgEmpresas.TabIndex = 22
        '
        'contid
        '
        Me.contid.HeaderText = "id"
        Me.contid.Name = "contid"
        Me.contid.ReadOnly = True
        Me.contid.Visible = False
        '
        'empbdd
        '
        Me.empbdd.HeaderText = "BDD"
        Me.empbdd.Name = "empbdd"
        Me.empbdd.ReadOnly = True
        Me.empbdd.Visible = False
        Me.empbdd.Width = 140
        '
        'empsele
        '
        Me.empsele.HeaderText = "Selecion"
        Me.empsele.Name = "empsele"
        Me.empsele.Width = 50
        '
        'empnom
        '
        Me.empnom.HeaderText = "Empresa"
        Me.empnom.Name = "empnom"
        Me.empnom.ReadOnly = True
        Me.empnom.Width = 340
        '
        'empsucu
        '
        Me.empsucu.HeaderText = "Sucursal"
        Me.empsucu.Name = "empsucu"
        Me.empsucu.Width = 130
        '
        'rbAdmin
        '
        Me.rbAdmin.AutoSize = True
        Me.rbAdmin.Checked = True
        Me.rbAdmin.Location = New System.Drawing.Point(15, 19)
        Me.rbAdmin.Name = "rbAdmin"
        Me.rbAdmin.Size = New System.Drawing.Size(76, 17)
        Me.rbAdmin.TabIndex = 25
        Me.rbAdmin.TabStop = True
        Me.rbAdmin.Text = "AdminPAQ"
        Me.rbAdmin.UseVisualStyleBackColor = True
        '
        'rbcomercial
        '
        Me.rbcomercial.AutoSize = True
        Me.rbcomercial.Location = New System.Drawing.Point(112, 19)
        Me.rbcomercial.Name = "rbcomercial"
        Me.rbcomercial.Size = New System.Drawing.Size(71, 17)
        Me.rbcomercial.TabIndex = 26
        Me.rbcomercial.TabStop = True
        Me.rbcomercial.Text = "Comercial"
        Me.rbcomercial.UseVisualStyleBackColor = True
        Me.rbcomercial.Visible = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 3)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(171, 13)
        Me.Label1.TabIndex = 27
        Me.Label1.Text = "Seleccionar el sistena que maneja:"
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(2, 320)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(252, 33)
        Me.Label2.TabIndex = 28
        Me.Label2.Text = "Solo se asignaran las empresas que esten seleccionadas y con nombre de sucursal."
        '
        'btnSalir
        '
        Me.btnSalir.Location = New System.Drawing.Point(456, 323)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(75, 33)
        Me.btnSalir.TabIndex = 24
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'btnAgregar
        '
        Me.btnAgregar.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnAgregar.Location = New System.Drawing.Point(375, 323)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(75, 33)
        Me.btnAgregar.TabIndex = 29
        Me.btnAgregar.Text = "Agregar"
        Me.btnAgregar.UseVisualStyleBackColor = False
        '
        'frmEmpresasAdw
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Silver
        Me.ClientSize = New System.Drawing.Size(542, 362)
        Me.Controls.Add(Me.btnAgregar)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.rbcomercial)
        Me.Controls.Add(Me.rbAdmin)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.dgEmpresas)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmEmpresasAdw"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Empresas ADW"
        CType(Me.dgEmpresas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dgEmpresas As DataGridView
    Friend WithEvents contid As DataGridViewTextBoxColumn
    Friend WithEvents empbdd As DataGridViewTextBoxColumn
    Friend WithEvents empsele As DataGridViewCheckBoxColumn
    Friend WithEvents empnom As DataGridViewTextBoxColumn
    Friend WithEvents empsucu As DataGridViewTextBoxColumn
    Friend WithEvents rbAdmin As RadioButton
    Friend WithEvents rbcomercial As RadioButton
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents btnSalir As Button
    Friend WithEvents btnAgregar As Button
End Class
