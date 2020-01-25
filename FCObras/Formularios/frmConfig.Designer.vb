<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmConfig
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
        Me.tabParam = New System.Windows.Forms.TabPage()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.linfo2 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtRfc = New System.Windows.Forms.TextBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.txtRazon = New System.Windows.Forms.TextBox()
        Me.btnActiva = New System.Windows.Forms.Button()
        Me.tabGen = New System.Windows.Forms.TabPage()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BtInstala = New System.Windows.Forms.Button()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.TBSql = New System.Windows.Forms.TextBox()
        Me.TBBDDGen = New System.Windows.Forms.TextBox()
        Me.TBUID = New System.Windows.Forms.TextBox()
        Me.TBSA = New System.Windows.Forms.TextBox()
        Me.txtSDK = New System.Windows.Forms.TextBox()
        Me.txtEmpresas = New System.Windows.Forms.TextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtSDKComercial = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtEmpresasComercial = New System.Windows.Forms.TextBox()
        Me.mpConfig = New System.Windows.Forms.TabControl()
        Me.tabParam.SuspendLayout()
        Me.tabGen.SuspendLayout()
        Me.mpConfig.SuspendLayout()
        Me.SuspendLayout()
        '
        'tabParam
        '
        Me.tabParam.Controls.Add(Me.btnActiva)
        Me.tabParam.Controls.Add(Me.txtRazon)
        Me.tabParam.Controls.Add(Me.txtRfc)
        Me.tabParam.Controls.Add(Me.Label18)
        Me.tabParam.Controls.Add(Me.Label11)
        Me.tabParam.Controls.Add(Me.linfo2)
        Me.tabParam.Controls.Add(Me.Label13)
        Me.tabParam.Controls.Add(Me.btnGuardar)
        Me.tabParam.Location = New System.Drawing.Point(4, 22)
        Me.tabParam.Name = "tabParam"
        Me.tabParam.Padding = New System.Windows.Forms.Padding(3)
        Me.tabParam.Size = New System.Drawing.Size(544, 360)
        Me.tabParam.TabIndex = 1
        Me.tabParam.Text = "Parametros"
        Me.tabParam.UseVisualStyleBackColor = True
        '
        'btnGuardar
        '
        Me.btnGuardar.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnGuardar.Location = New System.Drawing.Point(226, 164)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(101, 35)
        Me.btnGuardar.TabIndex = 25
        Me.btnGuardar.Text = "Guardar"
        Me.btnGuardar.UseVisualStyleBackColor = False
        '
        'Label13
        '
        Me.Label13.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label13.Location = New System.Drawing.Point(96, 100)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(412, 30)
        Me.Label13.TabIndex = 26
        Me.Label13.Text = "1.- Datos del Cliente para Agregar a nuestra base de Datos." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'linfo2
        '
        Me.linfo2.BackColor = System.Drawing.Color.Red
        Me.linfo2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.linfo2.Location = New System.Drawing.Point(144, 143)
        Me.linfo2.Name = "linfo2"
        Me.linfo2.Size = New System.Drawing.Size(290, 18)
        Me.linfo2.TabIndex = 27
        Me.linfo2.Text = "!No se han Configurado todos los parametros.!" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.linfo2.Visible = False
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(237, 52)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(60, 13)
        Me.Label11.TabIndex = 29
        Me.Label11.Text = "RFCCliente"
        '
        'txtRfc
        '
        Me.txtRfc.Location = New System.Drawing.Point(136, 68)
        Me.txtRfc.Name = "txtRfc"
        Me.txtRfc.Size = New System.Drawing.Size(298, 20)
        Me.txtRfc.TabIndex = 28
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(183, 13)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(154, 13)
        Me.Label18.TabIndex = 31
        Me.Label18.Text = "Nombre Cliente o Razon Social"
        '
        'txtRazon
        '
        Me.txtRazon.Location = New System.Drawing.Point(136, 29)
        Me.txtRazon.Name = "txtRazon"
        Me.txtRazon.Size = New System.Drawing.Size(298, 20)
        Me.txtRazon.TabIndex = 30
        '
        'btnActiva
        '
        Me.btnActiva.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnActiva.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnActiva.Location = New System.Drawing.Point(215, 215)
        Me.btnActiva.Name = "btnActiva"
        Me.btnActiva.Size = New System.Drawing.Size(122, 36)
        Me.btnActiva.TabIndex = 16
        Me.btnActiva.Text = "Activar Producto"
        Me.btnActiva.UseVisualStyleBackColor = False
        '
        'tabGen
        '
        Me.tabGen.Controls.Add(Me.txtEmpresasComercial)
        Me.tabGen.Controls.Add(Me.txtSDKComercial)
        Me.tabGen.Controls.Add(Me.txtEmpresas)
        Me.tabGen.Controls.Add(Me.txtSDK)
        Me.tabGen.Controls.Add(Me.TBSA)
        Me.tabGen.Controls.Add(Me.TBUID)
        Me.tabGen.Controls.Add(Me.TBBDDGen)
        Me.tabGen.Controls.Add(Me.TBSql)
        Me.tabGen.Controls.Add(Me.Label6)
        Me.tabGen.Controls.Add(Me.Label5)
        Me.tabGen.Controls.Add(Me.Label17)
        Me.tabGen.Controls.Add(Me.Label15)
        Me.tabGen.Controls.Add(Me.Label14)
        Me.tabGen.Controls.Add(Me.BtInstala)
        Me.tabGen.Controls.Add(Me.Label1)
        Me.tabGen.Controls.Add(Me.Label2)
        Me.tabGen.Controls.Add(Me.Label3)
        Me.tabGen.Controls.Add(Me.Label4)
        Me.tabGen.Location = New System.Drawing.Point(4, 22)
        Me.tabGen.Name = "tabGen"
        Me.tabGen.Padding = New System.Windows.Forms.Padding(3)
        Me.tabGen.Size = New System.Drawing.Size(544, 360)
        Me.tabGen.TabIndex = 0
        Me.tabGen.Text = "General"
        Me.tabGen.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(117, 87)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(61, 13)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Contraseña"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(3, 87)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(43, 13)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Usuario"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(3, 48)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(117, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Base de Datos General"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(3, 5)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(90, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Instancia General"
        '
        'BtInstala
        '
        Me.BtInstala.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BtInstala.Location = New System.Drawing.Point(173, 306)
        Me.BtInstala.Name = "BtInstala"
        Me.BtInstala.Size = New System.Drawing.Size(82, 35)
        Me.BtInstala.TabIndex = 8
        Me.BtInstala.Text = "Instalar"
        Me.BtInstala.UseVisualStyleBackColor = False
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(3, 142)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(124, 13)
        Me.Label14.TabIndex = 11
        Me.Label14.Text = "Ruta SDK de AdminPAQ"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(3, 184)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(163, 13)
        Me.Label15.TabIndex = 13
        Me.Label15.Text = "Ruta de Empresas de AdminPAQ"
        '
        'TBSql
        '
        Me.TBSql.Location = New System.Drawing.Point(6, 21)
        Me.TBSql.Name = "TBSql"
        Me.TBSql.Size = New System.Drawing.Size(214, 20)
        Me.TBSql.TabIndex = 0
        '
        'TBBDDGen
        '
        Me.TBBDDGen.Location = New System.Drawing.Point(6, 64)
        Me.TBBDDGen.Name = "TBBDDGen"
        Me.TBBDDGen.Size = New System.Drawing.Size(214, 20)
        Me.TBBDDGen.TabIndex = 1
        '
        'TBUID
        '
        Me.TBUID.Location = New System.Drawing.Point(6, 103)
        Me.TBUID.Name = "TBUID"
        Me.TBUID.Size = New System.Drawing.Size(100, 20)
        Me.TBUID.TabIndex = 2
        '
        'TBSA
        '
        Me.TBSA.Location = New System.Drawing.Point(120, 103)
        Me.TBSA.Name = "TBSA"
        Me.TBSA.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TBSA.Size = New System.Drawing.Size(100, 20)
        Me.TBSA.TabIndex = 3
        '
        'txtSDK
        '
        Me.txtSDK.Location = New System.Drawing.Point(6, 158)
        Me.txtSDK.Name = "txtSDK"
        Me.txtSDK.Size = New System.Drawing.Size(249, 20)
        Me.txtSDK.TabIndex = 10
        '
        'txtEmpresas
        '
        Me.txtEmpresas.Location = New System.Drawing.Point(6, 200)
        Me.txtEmpresas.Name = "txtEmpresas"
        Me.txtEmpresas.Size = New System.Drawing.Size(249, 20)
        Me.txtEmpresas.TabIndex = 12
        '
        'Label17
        '
        Me.Label17.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Label17.Location = New System.Drawing.Point(3, 126)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(300, 10)
        Me.Label17.TabIndex = 16
        Me.Label17.Text = "" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(275, 142)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(119, 13)
        Me.Label5.TabIndex = 18
        Me.Label5.Text = "Ruta SDK de Comercial"
        '
        'txtSDKComercial
        '
        Me.txtSDKComercial.Location = New System.Drawing.Point(278, 158)
        Me.txtSDKComercial.Name = "txtSDKComercial"
        Me.txtSDKComercial.Size = New System.Drawing.Size(249, 20)
        Me.txtSDKComercial.TabIndex = 17
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(275, 184)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(143, 13)
        Me.Label6.TabIndex = 20
        Me.Label6.Text = "Ruta de Empresas Comercial"
        '
        'txtEmpresasComercial
        '
        Me.txtEmpresasComercial.Location = New System.Drawing.Point(278, 200)
        Me.txtEmpresasComercial.Name = "txtEmpresasComercial"
        Me.txtEmpresasComercial.Size = New System.Drawing.Size(249, 20)
        Me.txtEmpresasComercial.TabIndex = 19
        '
        'mpConfig
        '
        Me.mpConfig.Controls.Add(Me.tabGen)
        Me.mpConfig.Controls.Add(Me.tabParam)
        Me.mpConfig.Location = New System.Drawing.Point(12, 12)
        Me.mpConfig.Name = "mpConfig"
        Me.mpConfig.SelectedIndex = 0
        Me.mpConfig.Size = New System.Drawing.Size(552, 386)
        Me.mpConfig.TabIndex = 2
        '
        'frmConfig
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(578, 450)
        Me.Controls.Add(Me.mpConfig)
        Me.Name = "frmConfig"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Configuración"
        Me.tabParam.ResumeLayout(False)
        Me.tabParam.PerformLayout()
        Me.tabGen.ResumeLayout(False)
        Me.tabGen.PerformLayout()
        Me.mpConfig.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents tabParam As TabPage
    Friend WithEvents btnActiva As Button
    Friend WithEvents txtRazon As TextBox
    Friend WithEvents txtRfc As TextBox
    Friend WithEvents Label18 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents linfo2 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents btnGuardar As Button
    Friend WithEvents tabGen As TabPage
    Friend WithEvents txtEmpresasComercial As TextBox
    Friend WithEvents txtSDKComercial As TextBox
    Friend WithEvents txtEmpresas As TextBox
    Friend WithEvents txtSDK As TextBox
    Friend WithEvents TBSA As TextBox
    Friend WithEvents TBUID As TextBox
    Friend WithEvents TBBDDGen As TextBox
    Friend WithEvents TBSql As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents BtInstala As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents mpConfig As TabControl
End Class
