<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmConceptos
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
        Me.dgConceptos = New System.Windows.Forms.DataGridView()
        Me.procodigo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.proid = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.proNombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.dgConceptos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(320, 249)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(141, 13)
        Me.Label3.TabIndex = 36
        Me.Label3.Text = "Doble click para seleccionar"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(5, 7)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(83, 13)
        Me.Label2.TabIndex = 35
        Me.Label2.Text = "Lista Conceptos"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(127, 7)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(43, 13)
        Me.Label1.TabIndex = 34
        Me.Label1.Text = "Buscar:"
        '
        'txtBus
        '
        Me.txtBus.Location = New System.Drawing.Point(172, 2)
        Me.txtBus.Name = "txtBus"
        Me.txtBus.Size = New System.Drawing.Size(289, 20)
        Me.txtBus.TabIndex = 33
        '
        'dgConceptos
        '
        Me.dgConceptos.AllowUserToAddRows = False
        Me.dgConceptos.AllowUserToDeleteRows = False
        Me.dgConceptos.AllowUserToResizeRows = False
        Me.dgConceptos.BackgroundColor = System.Drawing.SystemColors.ControlLightLight
        Me.dgConceptos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgConceptos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.procodigo, Me.proid, Me.proNombre})
        Me.dgConceptos.GridColor = System.Drawing.SystemColors.ControlLightLight
        Me.dgConceptos.Location = New System.Drawing.Point(3, 23)
        Me.dgConceptos.MultiSelect = False
        Me.dgConceptos.Name = "dgConceptos"
        Me.dgConceptos.RowHeadersVisible = False
        Me.dgConceptos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgConceptos.Size = New System.Drawing.Size(458, 223)
        Me.dgConceptos.TabIndex = 32
        '
        'procodigo
        '
        Me.procodigo.HeaderText = "Codigo"
        Me.procodigo.Name = "procodigo"
        Me.procodigo.ReadOnly = True
        Me.procodigo.Width = 120
        '
        'proid
        '
        Me.proid.HeaderText = "idconcepto"
        Me.proid.Name = "proid"
        Me.proid.Visible = False
        '
        'proNombre
        '
        Me.proNombre.HeaderText = "Nombre"
        Me.proNombre.Name = "proNombre"
        Me.proNombre.ReadOnly = True
        Me.proNombre.Width = 330
        '
        'frmConceptos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(464, 267)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtBus)
        Me.Controls.Add(Me.dgConceptos)
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmConceptos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Conceptos"
        CType(Me.dgConceptos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtBus As TextBox
    Friend WithEvents dgConceptos As DataGridView
    Friend WithEvents procodigo As DataGridViewTextBoxColumn
    Friend WithEvents proid As DataGridViewTextBoxColumn
    Friend WithEvents proNombre As DataGridViewTextBoxColumn
End Class
