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
        Me.pnlFiltros = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtCliente = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnBuscar = New System.Windows.Forms.Button()
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
        Me.datePedido.Location = New System.Drawing.Point(443, 5)
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
        Me.txtNroPedido.Location = New System.Drawing.Point(813, 5)
        Me.txtNroPedido.Margin = New System.Windows.Forms.Padding(5)
        Me.txtNroPedido.Name = "txtNroPedido"
        Me.txtNroPedido.Size = New System.Drawing.Size(132, 27)
        Me.txtNroPedido.TabIndex = 31
        '
        'pnlFiltros
        '
        Me.pnlFiltros.Controls.Add(Me.btnBuscar)
        Me.pnlFiltros.Controls.Add(Me.Label4)
        Me.pnlFiltros.Controls.Add(Me.Label2)
        Me.pnlFiltros.Controls.Add(Me.txtCliente)
        Me.pnlFiltros.Controls.Add(Me.Label1)
        Me.pnlFiltros.Controls.Add(Me.txtNroPedido)
        Me.pnlFiltros.Controls.Add(Me.datePedido)
        Me.pnlFiltros.Location = New System.Drawing.Point(18, 6)
        Me.pnlFiltros.Name = "pnlFiltros"
        Me.pnlFiltros.Size = New System.Drawing.Size(1051, 40)
        Me.pnlFiltros.TabIndex = 31
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(3, 10)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(58, 20)
        Me.Label1.TabIndex = 39
        Me.Label1.Text = "Cliente:"
        '
        'txtCliente
        '
        Me.txtCliente.Location = New System.Drawing.Point(66, 7)
        Me.txtCliente.Margin = New System.Windows.Forms.Padding(5)
        Me.txtCliente.Name = "txtCliente"
        Me.txtCliente.Size = New System.Drawing.Size(311, 27)
        Me.txtCliente.TabIndex = 40
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(385, 10)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(50, 20)
        Me.Label2.TabIndex = 41
        Me.Label2.Text = "Fecha:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(717, 10)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(88, 20)
        Me.Label4.TabIndex = 42
        Me.Label4.Text = "Num. Venta:"
        '
        'btnBuscar
        '
        Me.btnBuscar.Location = New System.Drawing.Point(962, 2)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(75, 36)
        Me.btnBuscar.TabIndex = 31
        Me.btnBuscar.Text = "Buscar"
        Me.btnBuscar.UseVisualStyleBackColor = True
        '
        'FrmVentasRealizadas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1183, 634)
        Me.Controls.Add(Me.pnlFiltros)
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

    End Sub

    Friend WithEvents gvPedidos As DataGridView
    Friend WithEvents datePedido As DateTimePicker
    Friend WithEvents Label3 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents gvDetallePedido As DataGridView
    Friend WithEvents txtNroPedido As TextBox
    Friend WithEvents pnlFiltros As Panel
    Friend WithEvents Label4 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtCliente As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents btnBuscar As Button
End Class
