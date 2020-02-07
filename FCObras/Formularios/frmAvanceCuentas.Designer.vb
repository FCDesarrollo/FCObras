<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAvanceCuentas
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAvanceCuentas))
        Me.LAvance = New System.Windows.Forms.Label()
        Me.picgif = New System.Windows.Forms.PictureBox()
        CType(Me.picgif, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LAvance
        '
        Me.LAvance.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LAvance.Location = New System.Drawing.Point(12, 23)
        Me.LAvance.Name = "LAvance"
        Me.LAvance.Size = New System.Drawing.Size(262, 23)
        Me.LAvance.TabIndex = 48
        Me.LAvance.Text = "Cargando Cuentas ..."
        '
        'picgif
        '
        Me.picgif.Image = CType(resources.GetObject("picgif.Image"), System.Drawing.Image)
        Me.picgif.Location = New System.Drawing.Point(294, 12)
        Me.picgif.Name = "picgif"
        Me.picgif.Size = New System.Drawing.Size(44, 42)
        Me.picgif.TabIndex = 49
        Me.picgif.TabStop = False
        '
        'frmAvanceCuentas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(365, 61)
        Me.Controls.Add(Me.picgif)
        Me.Controls.Add(Me.LAvance)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmAvanceCuentas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Avance"
        CType(Me.picgif, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents LAvance As Label
    Friend WithEvents picgif As PictureBox
End Class
