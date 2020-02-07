<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmEmpresasCont
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
        Me.btnAgregar = New System.Windows.Forms.Button()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.contid = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.empbdd = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.empsele = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.empnom = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label1 = New System.Windows.Forms.Label()
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
        Me.dgEmpresas.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.contid, Me.empbdd, Me.empsele, Me.empnom})
        Me.dgEmpresas.GridColor = System.Drawing.SystemColors.ControlLightLight
        Me.dgEmpresas.Location = New System.Drawing.Point(0, 1)
        Me.dgEmpresas.MultiSelect = False
        Me.dgEmpresas.Name = "dgEmpresas"
        Me.dgEmpresas.RowHeadersVisible = False
        Me.dgEmpresas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgEmpresas.Size = New System.Drawing.Size(525, 223)
        Me.dgEmpresas.TabIndex = 21
        '
        'btnAgregar
        '
        Me.btnAgregar.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnAgregar.Location = New System.Drawing.Point(343, 230)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(75, 33)
        Me.btnAgregar.TabIndex = 22
        Me.btnAgregar.Text = "Agregar"
        Me.btnAgregar.UseVisualStyleBackColor = False
        '
        'btnSalir
        '
        Me.btnSalir.Location = New System.Drawing.Point(434, 230)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(75, 33)
        Me.btnSalir.TabIndex = 23
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.UseVisualStyleBackColor = True
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
        Me.empnom.HeaderText = "Empresas ContPAQ"
        Me.empnom.Name = "empnom"
        Me.empnom.ReadOnly = True
        Me.empnom.Width = 460
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(0, 230)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(302, 26)
        Me.Label1.TabIndex = 24
        Me.Label1.Text = "Se agregaran las empresas seleccionadas. " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Además se creara las tablas en su base" &
    " de datos de contPAQ."
        '
        'frmEmpresasCont
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Silver
        Me.ClientSize = New System.Drawing.Size(527, 265)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.btnAgregar)
        Me.Controls.Add(Me.dgEmpresas)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmEmpresasCont"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Empresas ContPAQ"
        CType(Me.dgEmpresas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dgEmpresas As DataGridView
    Friend WithEvents btnAgregar As Button
    Friend WithEvents btnSalir As Button
    Friend WithEvents contid As DataGridViewTextBoxColumn
    Friend WithEvents empbdd As DataGridViewTextBoxColumn
    Friend WithEvents empsele As DataGridViewCheckBoxColumn
    Friend WithEvents empnom As DataGridViewTextBoxColumn
    Friend WithEvents Label1 As Label
End Class
