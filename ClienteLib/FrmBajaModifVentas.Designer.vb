<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmBajaModifVentas
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
        Me.txtBusqNroPedido = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btnBuscarPedido = New System.Windows.Forms.Button()
        Me.btnGuardarCambios = New System.Windows.Forms.Button()
        Me.btnEliminarSeleccionados = New System.Windows.Forms.Button()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.gvDetallePedido = New System.Windows.Forms.DataGridView()
        Me.lblImporteTotal = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.lblFechaPedido = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.lblCliente = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.lblNroPedido = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.pnlProducto = New System.Windows.Forms.Panel()
        Me.btnProdBorrarBusq = New System.Windows.Forms.Button()
        Me.cmbProductoTipoBusq = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtProductoBusqueda = New System.Windows.Forms.TextBox()
        Me.btnProductoBuscar = New System.Windows.Forms.Button()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.txtCantidad = New System.Windows.Forms.TextBox()
        Me.btnAgregarProducto = New System.Windows.Forms.Button()
        Me.chkProductoBusqAvanzada = New System.Windows.Forms.CheckBox()
        Me.cmbProductos = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnBorrarPedido = New System.Windows.Forms.Button()
        Me.pnlPedido = New System.Windows.Forms.Panel()
        Me.pnlBusqProducto = New System.Windows.Forms.Panel()
        CType(Me.gvDetallePedido, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlProducto.SuspendLayout()
        Me.pnlPedido.SuspendLayout()
        Me.pnlBusqProducto.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtBusqNroPedido
        '
        Me.txtBusqNroPedido.Location = New System.Drawing.Point(169, 19)
        Me.txtBusqNroPedido.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtBusqNroPedido.Name = "txtBusqNroPedido"
        Me.txtBusqNroPedido.Size = New System.Drawing.Size(135, 27)
        Me.txtBusqNroPedido.TabIndex = 0
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(14, 11)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(149, 38)
        Me.Label5.TabIndex = 16
        Me.Label5.Text = "Pedido Nro:"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btnBuscarPedido
        '
        Me.btnBuscarPedido.Location = New System.Drawing.Point(169, 53)
        Me.btnBuscarPedido.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnBuscarPedido.Name = "btnBuscarPedido"
        Me.btnBuscarPedido.Size = New System.Drawing.Size(135, 36)
        Me.btnBuscarPedido.TabIndex = 17
        Me.btnBuscarPedido.Text = "Buscar"
        Me.btnBuscarPedido.UseVisualStyleBackColor = True
        '
        'btnGuardarCambios
        '
        Me.btnGuardarCambios.Location = New System.Drawing.Point(459, 540)
        Me.btnGuardarCambios.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnGuardarCambios.Name = "btnGuardarCambios"
        Me.btnGuardarCambios.Size = New System.Drawing.Size(174, 40)
        Me.btnGuardarCambios.TabIndex = 39
        Me.btnGuardarCambios.Text = "Guardar cambios"
        Me.btnGuardarCambios.UseVisualStyleBackColor = True
        '
        'btnEliminarSeleccionados
        '
        Me.btnEliminarSeleccionados.Location = New System.Drawing.Point(0, 498)
        Me.btnEliminarSeleccionados.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnEliminarSeleccionados.Name = "btnEliminarSeleccionados"
        Me.btnEliminarSeleccionados.Size = New System.Drawing.Size(174, 40)
        Me.btnEliminarSeleccionados.TabIndex = 38
        Me.btnEliminarSeleccionados.Text = "Eliminar seleccionados"
        Me.btnEliminarSeleccionados.UseVisualStyleBackColor = True
        '
        'Label13
        '
        Me.Label13.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(0, 104)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(645, 38)
        Me.Label13.TabIndex = 37
        Me.Label13.Text = "Detalle pedido"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'gvDetallePedido
        '
        Me.gvDetallePedido.AllowUserToAddRows = False
        Me.gvDetallePedido.AllowUserToDeleteRows = False
        Me.gvDetallePedido.AllowUserToOrderColumns = True
        Me.gvDetallePedido.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.gvDetallePedido.Location = New System.Drawing.Point(0, 146)
        Me.gvDetallePedido.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.gvDetallePedido.MultiSelect = False
        Me.gvDetallePedido.Name = "gvDetallePedido"
        Me.gvDetallePedido.RowHeadersVisible = False
        Me.gvDetallePedido.Size = New System.Drawing.Size(645, 348)
        Me.gvDetallePedido.TabIndex = 36
        '
        'lblImporteTotal
        '
        Me.lblImporteTotal.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblImporteTotal.Location = New System.Drawing.Point(454, 498)
        Me.lblImporteTotal.Name = "lblImporteTotal"
        Me.lblImporteTotal.Size = New System.Drawing.Size(191, 38)
        Me.lblImporteTotal.TabIndex = 35
        Me.lblImporteTotal.Text = "000000.00"
        Me.lblImporteTotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label12
        '
        Me.Label12.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(277, 498)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(171, 38)
        Me.Label12.TabIndex = 34
        Me.Label12.Text = "Total a pagar: ($)"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblFechaPedido
        '
        Me.lblFechaPedido.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFechaPedido.Location = New System.Drawing.Point(478, 64)
        Me.lblFechaPedido.Name = "lblFechaPedido"
        Me.lblFechaPedido.Size = New System.Drawing.Size(167, 32)
        Me.lblFechaPedido.TabIndex = 33
        Me.lblFechaPedido.Text = "XX/XX/XXXX"
        Me.lblFechaPedido.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label9
        '
        Me.Label9.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(319, 59)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(167, 38)
        Me.Label9.TabIndex = 32
        Me.Label9.Text = "Fecha pedido:"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblCliente
        '
        Me.lblCliente.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCliente.Location = New System.Drawing.Point(146, 49)
        Me.lblCliente.Name = "lblCliente"
        Me.lblCliente.Size = New System.Drawing.Size(167, 53)
        Me.lblCliente.TabIndex = 31
        Me.lblCliente.Text = "000000"
        Me.lblCliente.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label7
        '
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(3, 58)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(160, 38)
        Me.Label7.TabIndex = 30
        Me.Label7.Text = "Cliente:"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblNroPedido
        '
        Me.lblNroPedido.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNroPedido.Location = New System.Drawing.Point(146, 0)
        Me.lblNroPedido.Name = "lblNroPedido"
        Me.lblNroPedido.Size = New System.Drawing.Size(167, 32)
        Me.lblNroPedido.TabIndex = 29
        Me.lblNroPedido.Text = "000000"
        Me.lblNroPedido.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(140, 32)
        Me.Label1.TabIndex = 28
        Me.Label1.Text = "Pedido Nro:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btnSalir
        '
        Me.btnSalir.Location = New System.Drawing.Point(157, 21)
        Me.btnSalir.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(135, 45)
        Me.btnSalir.TabIndex = 40
        Me.btnSalir.Text = "Salir sin guardar"
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'pnlProducto
        '
        Me.pnlProducto.Controls.Add(Me.btnProdBorrarBusq)
        Me.pnlProducto.Controls.Add(Me.cmbProductoTipoBusq)
        Me.pnlProducto.Controls.Add(Me.Label3)
        Me.pnlProducto.Controls.Add(Me.txtProductoBusqueda)
        Me.pnlProducto.Controls.Add(Me.btnProductoBuscar)
        Me.pnlProducto.Location = New System.Drawing.Point(0, 224)
        Me.pnlProducto.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.pnlProducto.Name = "pnlProducto"
        Me.pnlProducto.Size = New System.Drawing.Size(303, 130)
        Me.pnlProducto.TabIndex = 48
        '
        'btnProdBorrarBusq
        '
        Me.btnProdBorrarBusq.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnProdBorrarBusq.ForeColor = System.Drawing.Color.Yellow
        Me.btnProdBorrarBusq.Location = New System.Drawing.Point(7, 75)
        Me.btnProdBorrarBusq.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnProdBorrarBusq.Name = "btnProdBorrarBusq"
        Me.btnProdBorrarBusq.Size = New System.Drawing.Size(74, 47)
        Me.btnProdBorrarBusq.TabIndex = 8
        Me.btnProdBorrarBusq.Text = "Borrar"
        Me.btnProdBorrarBusq.UseVisualStyleBackColor = False
        Me.btnProdBorrarBusq.Visible = False
        '
        'cmbProductoTipoBusq
        '
        Me.cmbProductoTipoBusq.FormattingEnabled = True
        Me.cmbProductoTipoBusq.Location = New System.Drawing.Point(90, 4)
        Me.cmbProductoTipoBusq.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cmbProductoTipoBusq.Name = "cmbProductoTipoBusq"
        Me.cmbProductoTipoBusq.Size = New System.Drawing.Size(202, 28)
        Me.cmbProductoTipoBusq.TabIndex = 8
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(2, 32)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(82, 20)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Buscar por:"
        '
        'txtProductoBusqueda
        '
        Me.txtProductoBusqueda.Location = New System.Drawing.Point(90, 40)
        Me.txtProductoBusqueda.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtProductoBusqueda.Name = "txtProductoBusqueda"
        Me.txtProductoBusqueda.Size = New System.Drawing.Size(202, 27)
        Me.txtProductoBusqueda.TabIndex = 12
        '
        'btnProductoBuscar
        '
        Me.btnProductoBuscar.Location = New System.Drawing.Point(90, 75)
        Me.btnProductoBuscar.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnProductoBuscar.Name = "btnProductoBuscar"
        Me.btnProductoBuscar.Size = New System.Drawing.Size(202, 47)
        Me.btnProductoBuscar.TabIndex = 44
        Me.btnProductoBuscar.Text = "Buscar"
        Me.btnProductoBuscar.UseVisualStyleBackColor = True
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(0, 369)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(72, 20)
        Me.Label14.TabIndex = 47
        Me.Label14.Text = "Cantidad:"
        '
        'txtCantidad
        '
        Me.txtCantidad.Location = New System.Drawing.Point(90, 366)
        Me.txtCantidad.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtCantidad.Name = "txtCantidad"
        Me.txtCantidad.Size = New System.Drawing.Size(202, 27)
        Me.txtCantidad.TabIndex = 46
        '
        'btnAgregarProducto
        '
        Me.btnAgregarProducto.Location = New System.Drawing.Point(90, 401)
        Me.btnAgregarProducto.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnAgregarProducto.Name = "btnAgregarProducto"
        Me.btnAgregarProducto.Size = New System.Drawing.Size(202, 47)
        Me.btnAgregarProducto.TabIndex = 45
        Me.btnAgregarProducto.Text = "Agregar al pedido"
        Me.btnAgregarProducto.UseVisualStyleBackColor = True
        '
        'chkProductoBusqAvanzada
        '
        Me.chkProductoBusqAvanzada.AutoSize = True
        Me.chkProductoBusqAvanzada.Location = New System.Drawing.Point(2, 191)
        Me.chkProductoBusqAvanzada.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.chkProductoBusqAvanzada.Name = "chkProductoBusqAvanzada"
        Me.chkProductoBusqAvanzada.Size = New System.Drawing.Size(160, 24)
        Me.chkProductoBusqAvanzada.TabIndex = 43
        Me.chkProductoBusqAvanzada.Text = "Busqueda avanzada"
        Me.chkProductoBusqAvanzada.UseVisualStyleBackColor = True
        '
        'cmbProductos
        '
        Me.cmbProductos.DisplayMember = "Nombre"
        Me.cmbProductos.FormattingEnabled = True
        Me.cmbProductos.Location = New System.Drawing.Point(0, 155)
        Me.cmbProductos.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cmbProductos.Name = "cmbProductos"
        Me.cmbProductos.Size = New System.Drawing.Size(292, 28)
        Me.cmbProductos.TabIndex = 42
        Me.cmbProductos.ValueMember = "Nombre"
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(2, 114)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(290, 38)
        Me.Label4.TabIndex = 41
        Me.Label4.Text = "Busqueda de producto"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnBorrarPedido
        '
        Me.btnBorrarPedido.BackColor = System.Drawing.Color.Red
        Me.btnBorrarPedido.Location = New System.Drawing.Point(0, 17)
        Me.btnBorrarPedido.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnBorrarPedido.Name = "btnBorrarPedido"
        Me.btnBorrarPedido.Size = New System.Drawing.Size(135, 52)
        Me.btnBorrarPedido.TabIndex = 49
        Me.btnBorrarPedido.Text = "Eliminar pedido"
        Me.btnBorrarPedido.UseVisualStyleBackColor = False
        '
        'pnlPedido
        '
        Me.pnlPedido.Controls.Add(Me.Label1)
        Me.pnlPedido.Controls.Add(Me.lblNroPedido)
        Me.pnlPedido.Controls.Add(Me.Label7)
        Me.pnlPedido.Controls.Add(Me.lblCliente)
        Me.pnlPedido.Controls.Add(Me.Label9)
        Me.pnlPedido.Controls.Add(Me.lblFechaPedido)
        Me.pnlPedido.Controls.Add(Me.Label13)
        Me.pnlPedido.Controls.Add(Me.gvDetallePedido)
        Me.pnlPedido.Controls.Add(Me.Label12)
        Me.pnlPedido.Controls.Add(Me.lblImporteTotal)
        Me.pnlPedido.Controls.Add(Me.btnEliminarSeleccionados)
        Me.pnlPedido.Controls.Add(Me.btnGuardarCambios)
        Me.pnlPedido.Location = New System.Drawing.Point(335, 19)
        Me.pnlPedido.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.pnlPedido.Name = "pnlPedido"
        Me.pnlPedido.Size = New System.Drawing.Size(658, 597)
        Me.pnlPedido.TabIndex = 50
        '
        'pnlBusqProducto
        '
        Me.pnlBusqProducto.Controls.Add(Me.btnSalir)
        Me.pnlBusqProducto.Controls.Add(Me.Label4)
        Me.pnlBusqProducto.Controls.Add(Me.btnBorrarPedido)
        Me.pnlBusqProducto.Controls.Add(Me.cmbProductos)
        Me.pnlBusqProducto.Controls.Add(Me.btnAgregarProducto)
        Me.pnlBusqProducto.Controls.Add(Me.Label14)
        Me.pnlBusqProducto.Controls.Add(Me.txtCantidad)
        Me.pnlBusqProducto.Controls.Add(Me.pnlProducto)
        Me.pnlBusqProducto.Controls.Add(Me.chkProductoBusqAvanzada)
        Me.pnlBusqProducto.Location = New System.Drawing.Point(12, 89)
        Me.pnlBusqProducto.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.pnlBusqProducto.Name = "pnlBusqProducto"
        Me.pnlBusqProducto.Size = New System.Drawing.Size(317, 527)
        Me.pnlBusqProducto.TabIndex = 51
        '
        'FrmBajaModifVentas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(991, 624)
        Me.Controls.Add(Me.pnlBusqProducto)
        Me.Controls.Add(Me.pnlPedido)
        Me.Controls.Add(Me.btnBuscarPedido)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtBusqNroPedido)
        Me.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(5)
        Me.Name = "FrmBajaModifVentas"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.Text = "Baja/Modificacion de Ventas"
        CType(Me.gvDetallePedido, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlProducto.ResumeLayout(False)
        Me.pnlProducto.PerformLayout()
        Me.pnlPedido.ResumeLayout(False)
        Me.pnlBusqProducto.ResumeLayout(False)
        Me.pnlBusqProducto.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtBusqNroPedido As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents btnBuscarPedido As Button
    Friend WithEvents btnGuardarCambios As Button
    Friend WithEvents btnEliminarSeleccionados As Button
    Friend WithEvents Label13 As Label
    Friend WithEvents gvDetallePedido As DataGridView
    Friend WithEvents lblImporteTotal As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents lblFechaPedido As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents lblCliente As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents lblNroPedido As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents btnSalir As Button
    Friend WithEvents pnlProducto As Panel
    Friend WithEvents cmbProductoTipoBusq As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtProductoBusqueda As TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents txtCantidad As TextBox
    Friend WithEvents btnAgregarProducto As Button
    Friend WithEvents btnProductoBuscar As Button
    Friend WithEvents chkProductoBusqAvanzada As CheckBox
    Friend WithEvents cmbProductos As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents btnBorrarPedido As Button
    Friend WithEvents pnlPedido As Panel
    Friend WithEvents pnlBusqProducto As Panel
    Friend WithEvents btnProdBorrarBusq As Button
End Class
