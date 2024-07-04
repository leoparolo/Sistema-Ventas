<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmVentasRealizadas
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
        Me.gvPedidos = New System.Windows.Forms.DataGridView()
        Me.datePedido = New System.Windows.Forms.DateTimePicker()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.gvDetallePedido = New System.Windows.Forms.DataGridView()
        Me.txtNroPedido = New System.Windows.Forms.TextBox()
        Me.btnBuscar = New System.Windows.Forms.Button()
        Me.chkNroPedido = New System.Windows.Forms.CheckBox()
        Me.chkCliente = New System.Windows.Forms.CheckBox()
        Me.chkFechaPedido = New System.Windows.Forms.CheckBox()
        Me.chkSinFiltro = New System.Windows.Forms.CheckBox()
        Me.pnlFiltros = New System.Windows.Forms.Panel()
        Me.cmbClientes = New System.Windows.Forms.ComboBox()
        CType(Me.gvPedidos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.gvDetallePedido, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlFiltros.SuspendLayout()
        Me.SuspendLayout()
        '
        'gvPedidos
        '
        Me.gvPedidos.AllowUserToAddRows = False
        Me.gvPedidos.AllowUserToDeleteRows = False
        Me.gvPedidos.AllowUserToOrderColumns = True
        Me.gvPedidos.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.gvPedidos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.gvPedidos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.gvPedidos.Location = New System.Drawing.Point(18, 54)
        Me.gvPedidos.Margin = New System.Windows.Forms.Padding(5)
        Me.gvPedidos.MultiSelect = False
        Me.gvPedidos.Name = "gvPedidos"
        Me.gvPedidos.ReadOnly = True
        Me.gvPedidos.RowHeadersVisible = False
        Me.gvPedidos.Size = New System.Drawing.Size(546, 498)
        Me.gvPedidos.TabIndex = 24
        '
        'datePedido
        '
        Me.datePedido.Location = New System.Drawing.Point(434, 5)
        Me.datePedido.Margin = New System.Windows.Forms.Padding(5)
        Me.datePedido.Name = "datePedido"
        Me.datePedido.Size = New System.Drawing.Size(266, 27)
        Me.datePedido.TabIndex = 27
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(1, 1)
        Me.Label3.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(491, 51)
        Me.Label3.TabIndex = 29
        Me.Label3.Text = "Detalle del pedido"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.gvDetallePedido)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Location = New System.Drawing.Point(572, 54)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(497, 441)
        Me.Panel1.TabIndex = 30
        '
        'gvDetallePedido
        '
        Me.gvDetallePedido.AllowUserToAddRows = False
        Me.gvDetallePedido.AllowUserToDeleteRows = False
        Me.gvDetallePedido.AllowUserToOrderColumns = True
        Me.gvDetallePedido.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.gvDetallePedido.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.gvDetallePedido.Location = New System.Drawing.Point(3, 56)
        Me.gvDetallePedido.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.gvDetallePedido.MultiSelect = False
        Me.gvDetallePedido.Name = "gvDetallePedido"
        Me.gvDetallePedido.ReadOnly = True
        Me.gvDetallePedido.RowHeadersVisible = False
        Me.gvDetallePedido.Size = New System.Drawing.Size(490, 380)
        Me.gvDetallePedido.TabIndex = 30
        '
        'txtNroPedido
        '
        Me.txtNroPedido.Location = New System.Drawing.Point(819, 6)
        Me.txtNroPedido.Margin = New System.Windows.Forms.Padding(5)
        Me.txtNroPedido.Name = "txtNroPedido"
        Me.txtNroPedido.Size = New System.Drawing.Size(132, 27)
        Me.txtNroPedido.TabIndex = 31
        '
        'btnBuscar
        '
        Me.btnBuscar.Location = New System.Drawing.Point(108, 14)
        Me.btnBuscar.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(86, 27)
        Me.btnBuscar.TabIndex = 33
        Me.btnBuscar.Text = "Buscar"
        Me.btnBuscar.UseVisualStyleBackColor = True
        '
        'chkNroPedido
        '
        Me.chkNroPedido.AutoSize = True
        Me.chkNroPedido.Location = New System.Drawing.Point(708, 8)
        Me.chkNroPedido.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.chkNroPedido.Name = "chkNroPedido"
        Me.chkNroPedido.Size = New System.Drawing.Size(103, 24)
        Me.chkNroPedido.TabIndex = 34
        Me.chkNroPedido.Text = "Nro Pedido"
        Me.chkNroPedido.UseVisualStyleBackColor = True
        '
        'chkCliente
        '
        Me.chkCliente.AutoSize = True
        Me.chkCliente.Location = New System.Drawing.Point(3, 8)
        Me.chkCliente.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.chkCliente.Name = "chkCliente"
        Me.chkCliente.Size = New System.Drawing.Size(74, 24)
        Me.chkCliente.TabIndex = 35
        Me.chkCliente.Text = "Cliente"
        Me.chkCliente.UseVisualStyleBackColor = True
        '
        'chkFechaPedido
        '
        Me.chkFechaPedido.AutoSize = True
        Me.chkFechaPedido.Location = New System.Drawing.Point(308, 8)
        Me.chkFechaPedido.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.chkFechaPedido.Name = "chkFechaPedido"
        Me.chkFechaPedido.Size = New System.Drawing.Size(118, 24)
        Me.chkFechaPedido.TabIndex = 36
        Me.chkFechaPedido.Text = "Fecha pedido"
        Me.chkFechaPedido.UseVisualStyleBackColor = True
        '
        'chkSinFiltro
        '
        Me.chkSinFiltro.AutoSize = True
        Me.chkSinFiltro.Checked = True
        Me.chkSinFiltro.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkSinFiltro.Location = New System.Drawing.Point(18, 15)
        Me.chkSinFiltro.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.chkSinFiltro.Name = "chkSinFiltro"
        Me.chkSinFiltro.Size = New System.Drawing.Size(84, 24)
        Me.chkSinFiltro.TabIndex = 37
        Me.chkSinFiltro.Text = "Sin filtro"
        Me.chkSinFiltro.UseVisualStyleBackColor = True
        '
        'pnlFiltros
        '
        Me.pnlFiltros.Controls.Add(Me.cmbClientes)
        Me.pnlFiltros.Controls.Add(Me.chkCliente)
        Me.pnlFiltros.Controls.Add(Me.chkFechaPedido)
        Me.pnlFiltros.Controls.Add(Me.chkNroPedido)
        Me.pnlFiltros.Controls.Add(Me.txtNroPedido)
        Me.pnlFiltros.Controls.Add(Me.datePedido)
        Me.pnlFiltros.Location = New System.Drawing.Point(209, 6)
        Me.pnlFiltros.Name = "pnlFiltros"
        Me.pnlFiltros.Size = New System.Drawing.Size(960, 40)
        Me.pnlFiltros.TabIndex = 31
        '
        'cmbClientes
        '
        Me.cmbClientes.DisplayMember = "Cliente"
        Me.cmbClientes.FormattingEnabled = True
        Me.cmbClientes.Location = New System.Drawing.Point(83, 7)
        Me.cmbClientes.Name = "cmbClientes"
        Me.cmbClientes.Size = New System.Drawing.Size(209, 28)
        Me.cmbClientes.TabIndex = 38
        Me.cmbClientes.ValueMember = "Cliente"
        '
        'FrmVentasRealizadas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1183, 634)
        Me.Controls.Add(Me.pnlFiltros)
        Me.Controls.Add(Me.chkSinFiltro)
        Me.Controls.Add(Me.btnBuscar)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.gvPedidos)
        Me.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(5)
        Me.Name = "FrmVentasRealizadas"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.Text = "Ventas realizadas"
        CType(Me.gvPedidos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        CType(Me.gvDetallePedido, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlFiltros.ResumeLayout(False)
        Me.pnlFiltros.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents gvPedidos As DataGridView
    Friend WithEvents datePedido As DateTimePicker
    Friend WithEvents Label3 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents gvDetallePedido As DataGridView
    Friend WithEvents txtNroPedido As TextBox
    Friend WithEvents btnBuscar As Button
    Friend WithEvents chkNroPedido As CheckBox
    Friend WithEvents chkCliente As CheckBox
    Friend WithEvents chkFechaPedido As CheckBox
    Friend WithEvents chkSinFiltro As CheckBox
    Friend WithEvents pnlFiltros As Panel
    Friend WithEvents cmbClientes As ComboBox
End Class
