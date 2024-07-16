<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmPrincipal
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
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ClientesToolStrip = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProductosToolStrip = New System.Windows.Forms.ToolStripMenuItem()
        Me.VentasToolStrip = New System.Windows.Forms.ToolStripMenuItem()
        Me.GenerarPedidoToolStrip = New System.Windows.Forms.ToolStripMenuItem()
        Me.EliminarModificarPedidoToolStrip = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReportesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VentasRealizadasToolStrip = New System.Windows.Forms.ToolStripMenuItem()
        Me.PresupuestoMensualToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.IsSplitterFixed = True
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer1.Name = "SplitContainer1"
        Me.SplitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.MenuStrip1)
        Me.SplitContainer1.Size = New System.Drawing.Size(800, 450)
        Me.SplitContainer1.SplitterDistance = 25
        Me.SplitContainer1.TabIndex = 1
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ClientesToolStrip, Me.ProductosToolStrip, Me.VentasToolStrip, Me.ReportesToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(800, 25)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ClientesToolStrip
        '
        Me.ClientesToolStrip.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ClientesToolStrip.Name = "ClientesToolStrip"
        Me.ClientesToolStrip.Size = New System.Drawing.Size(69, 21)
        Me.ClientesToolStrip.Text = "Clientes"
        '
        'ProductosToolStrip
        '
        Me.ProductosToolStrip.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ProductosToolStrip.Name = "ProductosToolStrip"
        Me.ProductosToolStrip.Size = New System.Drawing.Size(82, 21)
        Me.ProductosToolStrip.Text = "Productos"
        '
        'VentasToolStrip
        '
        Me.VentasToolStrip.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.GenerarPedidoToolStrip, Me.EliminarModificarPedidoToolStrip})
        Me.VentasToolStrip.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.VentasToolStrip.Name = "VentasToolStrip"
        Me.VentasToolStrip.Size = New System.Drawing.Size(61, 21)
        Me.VentasToolStrip.Text = "Ventas"
        '
        'GenerarPedidoToolStrip
        '
        Me.GenerarPedidoToolStrip.Name = "GenerarPedidoToolStrip"
        Me.GenerarPedidoToolStrip.Size = New System.Drawing.Size(239, 22)
        Me.GenerarPedidoToolStrip.Text = "Generar pedido"
        '
        'EliminarModificarPedidoToolStrip
        '
        Me.EliminarModificarPedidoToolStrip.Name = "EliminarModificarPedidoToolStrip"
        Me.EliminarModificarPedidoToolStrip.Size = New System.Drawing.Size(239, 22)
        Me.EliminarModificarPedidoToolStrip.Text = "Eliminar/Modificar pedido"
        '
        'ReportesToolStripMenuItem
        '
        Me.ReportesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.VentasRealizadasToolStrip, Me.PresupuestoMensualToolStripMenuItem})
        Me.ReportesToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ReportesToolStripMenuItem.Name = "ReportesToolStripMenuItem"
        Me.ReportesToolStripMenuItem.Size = New System.Drawing.Size(74, 21)
        Me.ReportesToolStripMenuItem.Text = "Reportes"
        '
        'VentasRealizadasToolStrip
        '
        Me.VentasRealizadasToolStrip.Name = "VentasRealizadasToolStrip"
        Me.VentasRealizadasToolStrip.Size = New System.Drawing.Size(208, 22)
        Me.VentasRealizadasToolStrip.Text = "Ventas realizadas"
        '
        'PresupuestoMensualToolStripMenuItem
        '
        Me.PresupuestoMensualToolStripMenuItem.Name = "PresupuestoMensualToolStripMenuItem"
        Me.PresupuestoMensualToolStripMenuItem.Size = New System.Drawing.Size(208, 22)
        Me.PresupuestoMensualToolStripMenuItem.Text = "Presupuesto mensual"
        '
        'FrmPrincipal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.SplitContainer1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStrip1
        Me.MaximizeBox = False
        Me.Name = "FrmPrincipal"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Inicio"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel1.PerformLayout()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents SplitContainer1 As SplitContainer
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents ClientesToolStrip As ToolStripMenuItem
    Friend WithEvents ProductosToolStrip As ToolStripMenuItem
    Friend WithEvents VentasToolStrip As ToolStripMenuItem
    Friend WithEvents GenerarPedidoToolStrip As ToolStripMenuItem
    Friend WithEvents EliminarModificarPedidoToolStrip As ToolStripMenuItem
    Friend WithEvents ReportesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents VentasRealizadasToolStrip As ToolStripMenuItem
    Friend WithEvents PresupuestoMensualToolStripMenuItem As ToolStripMenuItem
End Class
