<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPrincipal
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPrincipal))
        Me.PMenu = New System.Windows.Forms.ToolStrip()
        Me.MUser = New System.Windows.Forms.ToolStripDropDownButton()
        Me.MuserADD = New System.Windows.Forms.ToolStripMenuItem()
        Me.MuserChan = New System.Windows.Forms.ToolStripMenuItem()
        Me.MuserLog = New System.Windows.Forms.ToolStripMenuItem()
        Me.MSep1 = New System.Windows.Forms.ToolStripSeparator()
        Me.MMovimientos = New System.Windows.Forms.ToolStripDropDownButton()
        Me.OrdenesDeCompraToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AvanceDeObrasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MCatalogos = New System.Windows.Forms.ToolStripDropDownButton()
        Me.ObrasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PlanCronologicoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ClasificacionesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TiposInsumosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UnidadesDeMedidaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MSep3 = New System.Windows.Forms.ToolStripSeparator()
        Me.MConfig = New System.Windows.Forms.ToolStripButton()
        Me.InsumosProductosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PMenu.SuspendLayout()
        Me.SuspendLayout()
        '
        'PMenu
        '
        Me.PMenu.AutoSize = False
        Me.PMenu.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.PMenu.Font = New System.Drawing.Font("Segoe UI", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.PMenu.GripMargin = New System.Windows.Forms.Padding(3)
        Me.PMenu.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.PMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MUser, Me.MSep1, Me.MMovimientos, Me.MCatalogos, Me.MSep3, Me.MConfig})
        Me.PMenu.Location = New System.Drawing.Point(0, 0)
        Me.PMenu.Name = "PMenu"
        Me.PMenu.Size = New System.Drawing.Size(887, 60)
        Me.PMenu.TabIndex = 1
        Me.PMenu.Text = "ToolStrip1"
        '
        'MUser
        '
        Me.MUser.AutoSize = False
        Me.MUser.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MuserADD, Me.MuserChan, Me.MuserLog})
        Me.MUser.Image = CType(resources.GetObject("MUser.Image"), System.Drawing.Image)
        Me.MUser.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.MUser.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.MUser.Name = "MUser"
        Me.MUser.Size = New System.Drawing.Size(65, 50)
        Me.MUser.Tag = "0"
        Me.MUser.Text = "Usuarios"
        Me.MUser.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'MuserADD
        '
        Me.MuserADD.Name = "MuserADD"
        Me.MuserADD.Size = New System.Drawing.Size(170, 22)
        Me.MuserADD.Text = "Nuevo"
        '
        'MuserChan
        '
        Me.MuserChan.Name = "MuserChan"
        Me.MuserChan.Size = New System.Drawing.Size(170, 22)
        Me.MuserChan.Text = "Cambiar Usuario"
        '
        'MuserLog
        '
        Me.MuserLog.Name = "MuserLog"
        Me.MuserLog.Size = New System.Drawing.Size(170, 22)
        Me.MuserLog.Text = "Salir"
        '
        'MSep1
        '
        Me.MSep1.Name = "MSep1"
        Me.MSep1.Size = New System.Drawing.Size(6, 60)
        Me.MSep1.Tag = "0"
        '
        'MMovimientos
        '
        Me.MMovimientos.AutoSize = False
        Me.MMovimientos.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.OrdenesDeCompraToolStripMenuItem, Me.AvanceDeObrasToolStripMenuItem})
        Me.MMovimientos.Image = CType(resources.GetObject("MMovimientos.Image"), System.Drawing.Image)
        Me.MMovimientos.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.MMovimientos.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.MMovimientos.Name = "MMovimientos"
        Me.MMovimientos.Size = New System.Drawing.Size(108, 57)
        Me.MMovimientos.Text = "Movimientos"
        Me.MMovimientos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'OrdenesDeCompraToolStripMenuItem
        '
        Me.OrdenesDeCompraToolStripMenuItem.Name = "OrdenesDeCompraToolStripMenuItem"
        Me.OrdenesDeCompraToolStripMenuItem.Size = New System.Drawing.Size(191, 22)
        Me.OrdenesDeCompraToolStripMenuItem.Text = "- Ordenes de Compra"
        '
        'AvanceDeObrasToolStripMenuItem
        '
        Me.AvanceDeObrasToolStripMenuItem.Name = "AvanceDeObrasToolStripMenuItem"
        Me.AvanceDeObrasToolStripMenuItem.Size = New System.Drawing.Size(191, 22)
        Me.AvanceDeObrasToolStripMenuItem.Text = "- Avance de Obras"
        '
        'MCatalogos
        '
        Me.MCatalogos.AutoSize = False
        Me.MCatalogos.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.MCatalogos.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ObrasToolStripMenuItem, Me.PlanCronologicoToolStripMenuItem, Me.ClasificacionesToolStripMenuItem, Me.TiposInsumosToolStripMenuItem, Me.UnidadesDeMedidaToolStripMenuItem, Me.InsumosProductosToolStripMenuItem})
        Me.MCatalogos.Image = CType(resources.GetObject("MCatalogos.Image"), System.Drawing.Image)
        Me.MCatalogos.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.MCatalogos.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.MCatalogos.Name = "MCatalogos"
        Me.MCatalogos.Size = New System.Drawing.Size(90, 57)
        Me.MCatalogos.Tag = "10"
        Me.MCatalogos.Text = "Catalogos"
        Me.MCatalogos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'ObrasToolStripMenuItem
        '
        Me.ObrasToolStripMenuItem.Name = "ObrasToolStripMenuItem"
        Me.ObrasToolStripMenuItem.Size = New System.Drawing.Size(194, 22)
        Me.ObrasToolStripMenuItem.Text = "- Obras"
        '
        'PlanCronologicoToolStripMenuItem
        '
        Me.PlanCronologicoToolStripMenuItem.Name = "PlanCronologicoToolStripMenuItem"
        Me.PlanCronologicoToolStripMenuItem.Size = New System.Drawing.Size(194, 22)
        Me.PlanCronologicoToolStripMenuItem.Text = "- Plan Cronologico"
        '
        'ClasificacionesToolStripMenuItem
        '
        Me.ClasificacionesToolStripMenuItem.Name = "ClasificacionesToolStripMenuItem"
        Me.ClasificacionesToolStripMenuItem.Size = New System.Drawing.Size(194, 22)
        Me.ClasificacionesToolStripMenuItem.Text = "- Clasificaciones"
        '
        'TiposInsumosToolStripMenuItem
        '
        Me.TiposInsumosToolStripMenuItem.Name = "TiposInsumosToolStripMenuItem"
        Me.TiposInsumosToolStripMenuItem.Size = New System.Drawing.Size(194, 22)
        Me.TiposInsumosToolStripMenuItem.Text = "- Tipos Insumos"
        '
        'UnidadesDeMedidaToolStripMenuItem
        '
        Me.UnidadesDeMedidaToolStripMenuItem.Name = "UnidadesDeMedidaToolStripMenuItem"
        Me.UnidadesDeMedidaToolStripMenuItem.Size = New System.Drawing.Size(194, 22)
        Me.UnidadesDeMedidaToolStripMenuItem.Text = "- Unidades de Medida"
        '
        'MSep3
        '
        Me.MSep3.Name = "MSep3"
        Me.MSep3.Size = New System.Drawing.Size(6, 60)
        Me.MSep3.Tag = "0"
        '
        'MConfig
        '
        Me.MConfig.AutoSize = False
        Me.MConfig.Image = CType(resources.GetObject("MConfig.Image"), System.Drawing.Image)
        Me.MConfig.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.MConfig.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.MConfig.Name = "MConfig"
        Me.MConfig.Size = New System.Drawing.Size(85, 50)
        Me.MConfig.Tag = "-1"
        Me.MConfig.Text = "Configuración"
        Me.MConfig.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'InsumosProductosToolStripMenuItem
        '
        Me.InsumosProductosToolStripMenuItem.Name = "InsumosProductosToolStripMenuItem"
        Me.InsumosProductosToolStripMenuItem.Size = New System.Drawing.Size(194, 22)
        Me.InsumosProductosToolStripMenuItem.Text = "- Insumos/Productos"
        '
        'frmPrincipal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ClientSize = New System.Drawing.Size(887, 450)
        Me.Controls.Add(Me.PMenu)
        Me.IsMdiContainer = True
        Me.Name = "frmPrincipal"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Inicio"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.PMenu.ResumeLayout(False)
        Me.PMenu.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PMenu As ToolStrip
    Friend WithEvents MUser As ToolStripDropDownButton
    Friend WithEvents MuserADD As ToolStripMenuItem
    Friend WithEvents MuserChan As ToolStripMenuItem
    Friend WithEvents MuserLog As ToolStripMenuItem
    Friend WithEvents MSep1 As ToolStripSeparator
    Friend WithEvents MSep3 As ToolStripSeparator
    Friend WithEvents MConfig As ToolStripButton
    Friend WithEvents MMovimientos As ToolStripDropDownButton
    Friend WithEvents OrdenesDeCompraToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AvanceDeObrasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MCatalogos As ToolStripDropDownButton
    Friend WithEvents ObrasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PlanCronologicoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ClasificacionesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TiposInsumosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents UnidadesDeMedidaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents InsumosProductosToolStripMenuItem As ToolStripMenuItem
End Class
