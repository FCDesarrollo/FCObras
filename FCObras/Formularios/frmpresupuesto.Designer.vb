<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmpresupuesto
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
        Me.components = New System.ComponentModel.Container()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtDes = New System.Windows.Forms.TextBox()
        Me.btnAgregar = New System.Windows.Forms.Button()
        Me.dgArchivos = New System.Windows.Forms.DataGridView()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnSelect = New System.Windows.Forms.Button()
        Me.idcrono = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgarchRut = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgarch = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgadesc = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnDelDoc = New System.Windows.Forms.Button()
        Me.toltip = New System.Windows.Forms.ToolTip(Me.components)
        CType(Me.dgArchivos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtNombre
        '
        Me.txtNombre.Location = New System.Drawing.Point(75, 10)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(266, 20)
        Me.txtNombre.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(4, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(47, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Nombre:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(4, 44)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(66, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Descripción:"
        '
        'txtDes
        '
        Me.txtDes.Location = New System.Drawing.Point(75, 36)
        Me.txtDes.Multiline = True
        Me.txtDes.Name = "txtDes"
        Me.txtDes.Size = New System.Drawing.Size(266, 51)
        Me.txtDes.TabIndex = 3
        '
        'btnAgregar
        '
        Me.btnAgregar.Location = New System.Drawing.Point(127, 268)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(75, 28)
        Me.btnAgregar.TabIndex = 4
        Me.btnAgregar.Text = "Agregar"
        Me.btnAgregar.UseVisualStyleBackColor = True
        '
        'dgArchivos
        '
        Me.dgArchivos.AllowUserToAddRows = False
        Me.dgArchivos.AllowUserToDeleteRows = False
        Me.dgArchivos.AllowUserToResizeRows = False
        Me.dgArchivos.BackgroundColor = System.Drawing.SystemColors.ControlLightLight
        Me.dgArchivos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgArchivos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.idcrono, Me.dgarchRut, Me.dgarch, Me.dgadesc})
        Me.dgArchivos.GridColor = System.Drawing.SystemColors.ControlLightLight
        Me.dgArchivos.Location = New System.Drawing.Point(7, 130)
        Me.dgArchivos.MultiSelect = False
        Me.dgArchivos.Name = "dgArchivos"
        Me.dgArchivos.RowHeadersVisible = False
        Me.dgArchivos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgArchivos.Size = New System.Drawing.Size(344, 132)
        Me.dgArchivos.TabIndex = 27
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(4, 104)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(70, 13)
        Me.Label3.TabIndex = 28
        Me.Label3.Text = "Documentos:"
        '
        'btnSelect
        '
        Me.btnSelect.Location = New System.Drawing.Point(80, 104)
        Me.btnSelect.Name = "btnSelect"
        Me.btnSelect.Size = New System.Drawing.Size(132, 23)
        Me.btnSelect.TabIndex = 29
        Me.btnSelect.Text = "Seleccionar Archivos"
        Me.btnSelect.UseVisualStyleBackColor = True
        '
        'idcrono
        '
        Me.idcrono.HeaderText = "id"
        Me.idcrono.Name = "idcrono"
        Me.idcrono.Visible = False
        '
        'dgarchRut
        '
        Me.dgarchRut.HeaderText = "Ruta"
        Me.dgarchRut.Name = "dgarchRut"
        Me.dgarchRut.Visible = False
        '
        'dgarch
        '
        Me.dgarch.HeaderText = "Archivo"
        Me.dgarch.Name = "dgarch"
        Me.dgarch.ReadOnly = True
        Me.dgarch.Width = 150
        '
        'dgadesc
        '
        Me.dgadesc.HeaderText = "Descripcion"
        Me.dgadesc.Name = "dgadesc"
        Me.dgadesc.Width = 180
        '
        'btnDelDoc
        '
        Me.btnDelDoc.BackColor = System.Drawing.Color.Red
        Me.btnDelDoc.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDelDoc.Location = New System.Drawing.Point(320, 100)
        Me.btnDelDoc.Name = "btnDelDoc"
        Me.btnDelDoc.Size = New System.Drawing.Size(31, 28)
        Me.btnDelDoc.TabIndex = 40
        Me.btnDelDoc.Text = "-"
        Me.btnDelDoc.UseVisualStyleBackColor = False
        '
        'frmpresupuesto
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(353, 298)
        Me.Controls.Add(Me.btnDelDoc)
        Me.Controls.Add(Me.btnSelect)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.dgArchivos)
        Me.Controls.Add(Me.btnAgregar)
        Me.Controls.Add(Me.txtDes)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtNombre)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmpresupuesto"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Presupuesto"
        CType(Me.dgArchivos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtNombre As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtDes As TextBox
    Friend WithEvents btnAgregar As Button
    Friend WithEvents dgArchivos As DataGridView
    Friend WithEvents Label3 As Label
    Friend WithEvents btnSelect As Button
    Friend WithEvents idcrono As DataGridViewTextBoxColumn
    Friend WithEvents dgarchRut As DataGridViewTextBoxColumn
    Friend WithEvents dgarch As DataGridViewTextBoxColumn
    Friend WithEvents dgadesc As DataGridViewTextBoxColumn
    Friend WithEvents btnDelDoc As Button
    Friend WithEvents toltip As ToolTip
End Class
