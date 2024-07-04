<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmVentaProductos
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cmbClienteTipoBusq = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cmbClientes = New System.Windows.Forms.ComboBox()
        Me.chkClienteBusqAvanzada = New System.Windows.Forms.CheckBox()
        Me.txtClienteBusqueda = New System.Windows.Forms.TextBox()
        Me.btnClienteBuscar = New System.Windows.Forms.Button()
        Me.btnProductoBuscar = New System.Windows.Forms.Button()
        Me.txtProductoBusqueda = New System.Windows.Forms.TextBox()
        Me.chkProductoBusqAvanzada = New System.Windows.Forms.CheckBox()
        Me.cmbProductos = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cmbProductoTipoBusq = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lblNroPedido = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.lblCliente = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.lblFechaPedido = New System.Windows.Forms.Label()
        Me.lblImporteTotal = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.gvDetallePedido = New System.Windows.Forms.DataGridView()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.btnAgregarProducto = New System.Windows.Forms.Button()
        Me.btnEliminarSeleccionados = New System.Windows.Forms.Button()
        Me.btnCerrarPedido = New System.Windows.Forms.Button()
        Me.txtCantidad = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.pnlCliente = New System.Windows.Forms.Panel()
        Me.btnClienteBorrarBusq = New System.Windows.Forms.Button()
        Me.pnlProducto = New System.Windows.Forms.Panel()
        Me.btnProdBorrarBusq = New System.Windows.Forms.Button()
        CType(Me.gvDetallePedido, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlCliente.SuspendLayout()
        Me.pnlProducto.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(26, 29)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(266, 32)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Busqueda de cliente"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'cmbClienteTipoBusq
        '
        Me.cmbClienteTipoBusq.FormattingEnabled = True
        Me.cmbClienteTipoBusq.Location = New System.Drawing.Point(106, 5)
        Me.cmbClienteTipoBusq.Name = "cmbClienteTipoBusq"
        Me.cmbClienteTipoBusq.Size = New System.Drawing.Size(155, 28)
        Me.cmbClienteTipoBusq.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(1, 23)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(82, 20)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Buscar por:"
        '
        'cmbClientes
        '
        Me.cmbClientes.DisplayMember = "Cliente"
        Me.cmbClientes.FormattingEnabled = True
        Me.cmbClientes.Location = New System.Drawing.Point(30, 64)
        Me.cmbClientes.Name = "cmbClientes"
        Me.cmbClientes.Size = New System.Drawing.Size(267, 28)
        Me.cmbClientes.TabIndex = 3
        Me.cmbClientes.ValueMember = "Cliente"
        '
        'chkClienteBusqAvanzada
        '
        Me.chkClienteBusqAvanzada.AutoSize = True
        Me.chkClienteBusqAvanzada.Location = New System.Drawing.Point(30, 98)
        Me.chkClienteBusqAvanzada.Name = "chkClienteBusqAvanzada"
        Me.chkClienteBusqAvanzada.Size = New System.Drawing.Size(160, 24)
        Me.chkClienteBusqAvanzada.TabIndex = 4
        Me.chkClienteBusqAvanzada.Text = "Busqueda avanzada"
        Me.chkClienteBusqAvanzada.UseVisualStyleBackColor = True
        '
        'txtClienteBusqueda
        '
        Me.txtClienteBusqueda.Location = New System.Drawing.Point(106, 39)
        Me.txtClienteBusqueda.Name = "txtClienteBusqueda"
        Me.txtClienteBusqueda.Size = New System.Drawing.Size(155, 27)
        Me.txtClienteBusqueda.TabIndex = 5
        '
        'btnClienteBuscar
        '
        Me.btnClienteBuscar.Location = New System.Drawing.Point(106, 75)
        Me.btnClienteBuscar.Name = "btnClienteBuscar"
        Me.btnClienteBuscar.Size = New System.Drawing.Size(157, 40)
        Me.btnClienteBuscar.TabIndex = 6
        Me.btnClienteBuscar.Text = "Buscar"
        Me.btnClienteBuscar.UseVisualStyleBackColor = True
        '
        'btnProductoBuscar
        '
        Me.btnProductoBuscar.Location = New System.Drawing.Point(85, 68)
        Me.btnProductoBuscar.Name = "btnProductoBuscar"
        Me.btnProductoBuscar.Size = New System.Drawing.Size(177, 40)
        Me.btnProductoBuscar.TabIndex = 13
        Me.btnProductoBuscar.Text = "Buscar"
        Me.btnProductoBuscar.UseVisualStyleBackColor = True
        '
        'txtProductoBusqueda
        '
        Me.txtProductoBusqueda.Location = New System.Drawing.Point(85, 37)
        Me.txtProductoBusqueda.Name = "txtProductoBusqueda"
        Me.txtProductoBusqueda.Size = New System.Drawing.Size(177, 27)
        Me.txtProductoBusqueda.TabIndex = 12
        '
        'chkProductoBusqAvanzada
        '
        Me.chkProductoBusqAvanzada.AutoSize = True
        Me.chkProductoBusqAvanzada.Location = New System.Drawing.Point(30, 345)
        Me.chkProductoBusqAvanzada.Name = "chkProductoBusqAvanzada"
        Me.chkProductoBusqAvanzada.Size = New System.Drawing.Size(160, 24)
        Me.chkProductoBusqAvanzada.TabIndex = 11
        Me.chkProductoBusqAvanzada.Text = "Busqueda avanzada"
        Me.chkProductoBusqAvanzada.UseVisualStyleBackColor = True
        '
        'cmbProductos
        '
        Me.cmbProductos.DisplayMember = "Nombre"
        Me.cmbProductos.FormattingEnabled = True
        Me.cmbProductos.Location = New System.Drawing.Point(30, 311)
        Me.cmbProductos.Name = "cmbProductos"
        Me.cmbProductos.Size = New System.Drawing.Size(262, 28)
        Me.cmbProductos.TabIndex = 10
        Me.cmbProductos.ValueMember = "Nombre"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(2, 27)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(82, 20)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Buscar por:"
        '
        'cmbProductoTipoBusq
        '
        Me.cmbProductoTipoBusq.FormattingEnabled = True
        Me.cmbProductoTipoBusq.Location = New System.Drawing.Point(85, 3)
        Me.cmbProductoTipoBusq.Name = "cmbProductoTipoBusq"
        Me.cmbProductoTipoBusq.Size = New System.Drawing.Size(177, 28)
        Me.cmbProductoTipoBusq.TabIndex = 8
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(26, 276)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(266, 32)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Busqueda de producto"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(305, 25)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(140, 32)
        Me.Label5.TabIndex = 15
        Me.Label5.Text = "Pedido Nro:"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblNroPedido
        '
        Me.lblNroPedido.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNroPedido.Location = New System.Drawing.Point(451, 25)
        Me.lblNroPedido.Name = "lblNroPedido"
        Me.lblNroPedido.Size = New System.Drawing.Size(167, 32)
        Me.lblNroPedido.TabIndex = 16
        Me.lblNroPedido.Text = "000000"
        Me.lblNroPedido.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label7
        '
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(305, 80)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(140, 32)
        Me.Label7.TabIndex = 17
        Me.Label7.Text = "Cliente:"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblCliente
        '
        Me.lblCliente.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCliente.Location = New System.Drawing.Point(451, 70)
        Me.lblCliente.Name = "lblCliente"
        Me.lblCliente.Size = New System.Drawing.Size(167, 53)
        Me.lblCliente.TabIndex = 18
        Me.lblCliente.Text = "000000"
        Me.lblCliente.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label9
        '
        Me.Label9.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(631, 80)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(146, 32)
        Me.Label9.TabIndex = 19
        Me.Label9.Text = "Fecha pedido:"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblFechaPedido
        '
        Me.lblFechaPedido.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFechaPedido.Location = New System.Drawing.Point(771, 80)
        Me.lblFechaPedido.Name = "lblFechaPedido"
        Me.lblFechaPedido.Size = New System.Drawing.Size(167, 32)
        Me.lblFechaPedido.TabIndex = 20
        Me.lblFechaPedido.Text = "XX/XX/XXXX"
        Me.lblFechaPedido.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblImporteTotal
        '
        Me.lblImporteTotal.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblImporteTotal.Location = New System.Drawing.Point(783, 531)
        Me.lblImporteTotal.Name = "lblImporteTotal"
        Me.lblImporteTotal.Size = New System.Drawing.Size(167, 32)
        Me.lblImporteTotal.TabIndex = 22
        Me.lblImporteTotal.Text = "000000.00"
        Me.lblImporteTotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label12
        '
        Me.Label12.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(611, 529)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(166, 32)
        Me.Label12.TabIndex = 21
        Me.Label12.Text = "Total a pagar: ($)"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'gvDetallePedido
        '
        Me.gvDetallePedido.AllowUserToAddRows = False
        Me.gvDetallePedido.AllowUserToDeleteRows = False
        Me.gvDetallePedido.AllowUserToOrderColumns = True
        Me.gvDetallePedido.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.gvDetallePedido.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.gvDetallePedido.Location = New System.Drawing.Point(305, 178)
        Me.gvDetallePedido.MultiSelect = False
        Me.gvDetallePedido.Name = "gvDetallePedido"
        Me.gvDetallePedido.RowHeadersVisible = False
        Me.gvDetallePedido.Size = New System.Drawing.Size(645, 348)
        Me.gvDetallePedido.TabIndex = 23
        '
        'Label13
        '
        Me.Label13.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(305, 139)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(645, 32)
        Me.Label13.TabIndex = 24
        Me.Label13.Text = "Detalle pedido"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnAgregarProducto
        '
        Me.btnAgregarProducto.Location = New System.Drawing.Point(115, 538)
        Me.btnAgregarProducto.Name = "btnAgregarProducto"
        Me.btnAgregarProducto.Size = New System.Drawing.Size(177, 40)
        Me.btnAgregarProducto.TabIndex = 25
        Me.btnAgregarProducto.Text = "Agregar al pedido"
        Me.btnAgregarProducto.UseVisualStyleBackColor = True
        '
        'btnEliminarSeleccionados
        '
        Me.btnEliminarSeleccionados.Location = New System.Drawing.Point(305, 529)
        Me.btnEliminarSeleccionados.Name = "btnEliminarSeleccionados"
        Me.btnEliminarSeleccionados.Size = New System.Drawing.Size(174, 40)
        Me.btnEliminarSeleccionados.TabIndex = 26
        Me.btnEliminarSeleccionados.Text = "Eliminar seleccionados"
        Me.btnEliminarSeleccionados.UseVisualStyleBackColor = True
        '
        'btnCerrarPedido
        '
        Me.btnCerrarPedido.Location = New System.Drawing.Point(776, 566)
        Me.btnCerrarPedido.Name = "btnCerrarPedido"
        Me.btnCerrarPedido.Size = New System.Drawing.Size(174, 40)
        Me.btnCerrarPedido.TabIndex = 27
        Me.btnCerrarPedido.Text = "Cerrar pedido"
        Me.btnCerrarPedido.UseVisualStyleBackColor = True
        '
        'txtCantidad
        '
        Me.txtCantidad.Location = New System.Drawing.Point(115, 505)
        Me.txtCantidad.Name = "txtCantidad"
        Me.txtCantidad.Size = New System.Drawing.Size(177, 27)
        Me.txtCantidad.TabIndex = 28
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(26, 508)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(72, 20)
        Me.Label14.TabIndex = 29
        Me.Label14.Text = "Cantidad:"
        '
        'pnlCliente
        '
        Me.pnlCliente.Controls.Add(Me.btnClienteBorrarBusq)
        Me.pnlCliente.Controls.Add(Me.cmbClienteTipoBusq)
        Me.pnlCliente.Controls.Add(Me.Label2)
        Me.pnlCliente.Controls.Add(Me.txtClienteBusqueda)
        Me.pnlCliente.Controls.Add(Me.btnClienteBuscar)
        Me.pnlCliente.Location = New System.Drawing.Point(31, 128)
        Me.pnlCliente.Name = "pnlCliente"
        Me.pnlCliente.Size = New System.Drawing.Size(266, 128)
        Me.pnlCliente.TabIndex = 30
        Me.pnlCliente.Visible = False
        '
        'btnClienteBorrarBusq
        '
        Me.btnClienteBorrarBusq.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnClienteBorrarBusq.ForeColor = System.Drawing.Color.Yellow
        Me.btnClienteBorrarBusq.Location = New System.Drawing.Point(5, 75)
        Me.btnClienteBorrarBusq.Name = "btnClienteBorrarBusq"
        Me.btnClienteBorrarBusq.Size = New System.Drawing.Size(65, 40)
        Me.btnClienteBorrarBusq.TabIndex = 7
        Me.btnClienteBorrarBusq.Text = "Borrar"
        Me.btnClienteBorrarBusq.UseVisualStyleBackColor = False
        '
        'pnlProducto
        '
        Me.pnlProducto.Controls.Add(Me.btnProdBorrarBusq)
        Me.pnlProducto.Controls.Add(Me.cmbProductoTipoBusq)
        Me.pnlProducto.Controls.Add(Me.Label3)
        Me.pnlProducto.Controls.Add(Me.txtProductoBusqueda)
        Me.pnlProducto.Controls.Add(Me.btnProductoBuscar)
        Me.pnlProducto.Location = New System.Drawing.Point(30, 375)
        Me.pnlProducto.Name = "pnlProducto"
        Me.pnlProducto.Size = New System.Drawing.Size(269, 111)
        Me.pnlProducto.TabIndex = 31
        Me.pnlProducto.Visible = False
        '
        'btnProdBorrarBusq
        '
        Me.btnProdBorrarBusq.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnProdBorrarBusq.ForeColor = System.Drawing.Color.Yellow
        Me.btnProdBorrarBusq.Location = New System.Drawing.Point(6, 68)
        Me.btnProdBorrarBusq.Name = "btnProdBorrarBusq"
        Me.btnProdBorrarBusq.Size = New System.Drawing.Size(65, 40)
        Me.btnProdBorrarBusq.TabIndex = 8
        Me.btnProdBorrarBusq.Text = "Borrar"
        Me.btnProdBorrarBusq.UseVisualStyleBackColor = False
        '
        'FrmVentaProductos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(967, 635)
        Me.Controls.Add(Me.pnlProducto)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.pnlCliente)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.gvDetallePedido)
        Me.Controls.Add(Me.txtCantidad)
        Me.Controls.Add(Me.lblNroPedido)
        Me.Controls.Add(Me.btnAgregarProducto)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.chkProductoBusqAvanzada)
        Me.Controls.Add(Me.btnCerrarPedido)
        Me.Controls.Add(Me.cmbProductos)
        Me.Controls.Add(Me.lblFechaPedido)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.chkClienteBusqAvanzada)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.cmbClientes)
        Me.Controls.Add(Me.btnEliminarSeleccionados)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblCliente)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.lblImporteTotal)
        Me.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(5)
        Me.Name = "FrmVentaProductos"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.Text = "Venta de productos"
        CType(Me.gvDetallePedido, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlCliente.ResumeLayout(False)
        Me.pnlCliente.PerformLayout()
        Me.pnlProducto.ResumeLayout(False)
        Me.pnlProducto.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents cmbClienteTipoBusq As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents cmbClientes As ComboBox
    Friend WithEvents chkClienteBusqAvanzada As CheckBox
    Friend WithEvents txtClienteBusqueda As TextBox
    Friend WithEvents btnClienteBuscar As Button
    Friend WithEvents btnProductoBuscar As Button
    Friend WithEvents txtProductoBusqueda As TextBox
    Friend WithEvents chkProductoBusqAvanzada As CheckBox
    Friend WithEvents cmbProductos As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents cmbProductoTipoBusq As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents lblNroPedido As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents lblCliente As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents lblFechaPedido As Label
    Friend WithEvents lblImporteTotal As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents gvDetallePedido As DataGridView
    Friend WithEvents Label13 As Label
    Friend WithEvents btnAgregarProducto As Button
    Friend WithEvents btnEliminarSeleccionados As Button
    Friend WithEvents btnCerrarPedido As Button
    Friend WithEvents txtCantidad As TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents pnlCliente As Panel
    Friend WithEvents pnlProducto As Panel
    Friend WithEvents btnClienteBorrarBusq As Button
    Friend WithEvents btnProdBorrarBusq As Button
End Class
