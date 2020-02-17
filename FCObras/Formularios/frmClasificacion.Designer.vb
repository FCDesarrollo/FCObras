<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmClasificacion
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmClasificacion))
        Me.txtnombre = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cbtipo = New System.Windows.Forms.ComboBox()
        Me.dgClasificaciones = New System.Windows.Forms.DataGridView()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnDelClas = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cbEmpresas = New System.Windows.Forms.ComboBox()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.btnNuevo = New System.Windows.Forms.Button()
        Me.ttTextos = New System.Windows.Forms.ToolTip(Me.components)
        Me.idcrono = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nomCrono = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clatipo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clastipo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.dgClasificaciones, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtnombre
        '
        Me.txtnombre.Location = New System.Drawing.Point(53, 47)
        Me.txtnombre.Name = "txtnombre"
        Me.txtnombre.Size = New System.Drawing.Size(233, 20)
        Me.txtnombre.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(3, 50)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(47, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Nombre "
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(3, 81)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(28, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Tipo"
        '
        'cbtipo
        '
        Me.cbtipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbtipo.FormattingEnabled = True
        Me.cbtipo.Location = New System.Drawing.Point(53, 81)
        Me.cbtipo.Name = "cbtipo"
        Me.cbtipo.Size = New System.Drawing.Size(233, 21)
        Me.cbtipo.TabIndex = 3
        '
        'dgClasificaciones
        '
        Me.dgClasificaciones.AllowUserToAddRows = False
        Me.dgClasificaciones.AllowUserToDeleteRows = False
        Me.dgClasificaciones.AllowUserToResizeRows = False
        Me.dgClasificaciones.BackgroundColor = System.Drawing.SystemColors.ControlLightLight
        Me.dgClasificaciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgClasificaciones.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.idcrono, Me.nomCrono, Me.clatipo, Me.clastipo})
        Me.dgClasificaciones.GridColor = System.Drawing.SystemColors.ControlLightLight
        Me.dgClasificaciones.Location = New System.Drawing.Point(6, 162)
        Me.dgClasificaciones.MultiSelect = False
        Me.dgClasificaciones.Name = "dgClasificaciones"
        Me.dgClasificaciones.RowHeadersVisible = False
        Me.dgClasificaciones.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgClasificaciones.Size = New System.Drawing.Size(371, 173)
        Me.dgClasificaciones.TabIndex = 27
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 146)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(77, 13)
        Me.Label3.TabIndex = 28
        Me.Label3.Text = "Clasificaciónes"
        '
        'btnDelClas
        '
        Me.btnDelClas.BackColor = System.Drawing.Color.Red
        Me.btnDelClas.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDelClas.Location = New System.Drawing.Point(346, 133)
        Me.btnDelClas.Name = "btnDelClas"
        Me.btnDelClas.Size = New System.Drawing.Size(31, 28)
        Me.btnDelClas.TabIndex = 41
        Me.btnDelClas.Text = "-"
        Me.btnDelClas.UseVisualStyleBackColor = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(264, 338)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(113, 13)
        Me.Label4.TabIndex = 42
        Me.Label4.Text = "Doble click para editar"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(3, 14)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(48, 13)
        Me.Label5.TabIndex = 43
        Me.Label5.Text = "Empresa"
        '
        'cbEmpresas
        '
        Me.cbEmpresas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbEmpresas.FormattingEnabled = True
        Me.cbEmpresas.Location = New System.Drawing.Point(53, 11)
        Me.cbEmpresas.Name = "cbEmpresas"
        Me.cbEmpresas.Size = New System.Drawing.Size(233, 21)
        Me.cbEmpresas.TabIndex = 44
        '
        'btnGuardar
        '
        Me.btnGuardar.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnGuardar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGuardar.Image = CType(resources.GetObject("btnGuardar.Image"), System.Drawing.Image)
        Me.btnGuardar.Location = New System.Drawing.Point(302, 71)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(75, 52)
        Me.btnGuardar.TabIndex = 46
        Me.btnGuardar.Text = "Guardar"
        Me.btnGuardar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnGuardar.UseVisualStyleBackColor = False
        '
        'btnNuevo
        '
        Me.btnNuevo.BackColor = System.Drawing.Color.Yellow
        Me.btnNuevo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNuevo.Image = CType(resources.GetObject("btnNuevo.Image"), System.Drawing.Image)
        Me.btnNuevo.Location = New System.Drawing.Point(302, 11)
        Me.btnNuevo.Name = "btnNuevo"
        Me.btnNuevo.Size = New System.Drawing.Size(75, 52)
        Me.btnNuevo.TabIndex = 45
        Me.btnNuevo.Text = "Nuevo"
        Me.btnNuevo.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnNuevo.UseVisualStyleBackColor = False
        '
        'idcrono
        '
        Me.idcrono.HeaderText = "id"
        Me.idcrono.Name = "idcrono"
        Me.idcrono.Visible = False
        '
        'nomCrono
        '
        Me.nomCrono.HeaderText = "Nombre"
        Me.nomCrono.Name = "nomCrono"
        Me.nomCrono.ReadOnly = True
        Me.nomCrono.Width = 180
        '
        'clatipo
        '
        Me.clatipo.HeaderText = "Tipo Clasificación"
        Me.clatipo.Name = "clatipo"
        Me.clatipo.ReadOnly = True
        Me.clatipo.Width = 180
        '
        'clastipo
        '
        Me.clastipo.HeaderText = "tipo"
        Me.clastipo.Name = "clastipo"
        Me.clastipo.Visible = False
        '
        'frmClasificacion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(394, 359)
        Me.Controls.Add(Me.btnGuardar)
        Me.Controls.Add(Me.btnNuevo)
        Me.Controls.Add(Me.cbEmpresas)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.btnDelClas)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.dgClasificaciones)
        Me.Controls.Add(Me.cbtipo)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtnombre)
        Me.MaximizeBox = False
        Me.Name = "frmClasificacion"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Clasificaciónes"
        CType(Me.dgClasificaciones, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtnombre As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents cbtipo As ComboBox
    Friend WithEvents dgClasificaciones As DataGridView
    Friend WithEvents Label3 As Label
    Friend WithEvents btnDelClas As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents cbEmpresas As ComboBox
    Friend WithEvents btnGuardar As Button
    Friend WithEvents btnNuevo As Button
    Friend WithEvents ttTextos As ToolTip
    Friend WithEvents idcrono As DataGridViewTextBoxColumn
    Friend WithEvents nomCrono As DataGridViewTextBoxColumn
    Friend WithEvents clatipo As DataGridViewTextBoxColumn
    Friend WithEvents clastipo As DataGridViewTextBoxColumn
End Class
