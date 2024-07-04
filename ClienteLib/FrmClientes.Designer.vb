<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmClientes
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
        Me.GVClientes = New System.Windows.Forms.DataGridView()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtID = New System.Windows.Forms.TextBox()
        Me.txtCliente = New System.Windows.Forms.TextBox()
        Me.txtTelefono = New System.Windows.Forms.TextBox()
        Me.txtCorreo = New System.Windows.Forms.TextBox()
        Me.btnEliminar = New System.Windows.Forms.Button()
        Me.btnInsertar = New System.Windows.Forms.Button()
        Me.btnModificar = New System.Windows.Forms.Button()
        Me.btnCerrar = New System.Windows.Forms.Button()
        Me.btnLimpiarDatos = New System.Windows.Forms.Button()
        Me.pnlInfoCliente = New System.Windows.Forms.Panel()
        Me.pnlCentral = New System.Windows.Forms.Panel()
        CType(Me.GVClientes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlInfoCliente.SuspendLayout()
        Me.pnlCentral.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Black", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(3, 7)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(283, 29)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Información del cliente"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GVClientes
        '
        Me.GVClientes.AllowUserToAddRows = False
        Me.GVClientes.AllowUserToDeleteRows = False
        Me.GVClientes.AllowUserToOrderColumns = True
        Me.GVClientes.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GVClientes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.GVClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.GVClientes.Location = New System.Drawing.Point(333, 12)
        Me.GVClientes.MultiSelect = False
        Me.GVClientes.Name = "GVClientes"
        Me.GVClientes.ReadOnly = True
        Me.GVClientes.RowHeadersVisible = False
        Me.GVClientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
        Me.GVClientes.Size = New System.Drawing.Size(581, 385)
        Me.GVClientes.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(15, 56)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(24, 20)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "ID"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(15, 92)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(55, 20)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Cliente"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(15, 125)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(67, 20)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Telefono"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(15, 158)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(54, 20)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Correo"
        '
        'txtID
        '
        Me.txtID.Location = New System.Drawing.Point(123, 52)
        Me.txtID.Name = "txtID"
        Me.txtID.Size = New System.Drawing.Size(163, 27)
        Me.txtID.TabIndex = 6
        '
        'txtCliente
        '
        Me.txtCliente.Location = New System.Drawing.Point(123, 85)
        Me.txtCliente.Name = "txtCliente"
        Me.txtCliente.Size = New System.Drawing.Size(163, 27)
        Me.txtCliente.TabIndex = 7
        '
        'txtTelefono
        '
        Me.txtTelefono.Location = New System.Drawing.Point(123, 121)
        Me.txtTelefono.Name = "txtTelefono"
        Me.txtTelefono.Size = New System.Drawing.Size(163, 27)
        Me.txtTelefono.TabIndex = 8
        '
        'txtCorreo
        '
        Me.txtCorreo.Location = New System.Drawing.Point(123, 154)
        Me.txtCorreo.Name = "txtCorreo"
        Me.txtCorreo.Size = New System.Drawing.Size(163, 27)
        Me.txtCorreo.TabIndex = 9
        '
        'btnEliminar
        '
        Me.btnEliminar.Location = New System.Drawing.Point(19, 198)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(85, 34)
        Me.btnEliminar.TabIndex = 10
        Me.btnEliminar.Text = "Eliminar"
        Me.btnEliminar.UseVisualStyleBackColor = True
        '
        'btnInsertar
        '
        Me.btnInsertar.Location = New System.Drawing.Point(110, 198)
        Me.btnInsertar.Name = "btnInsertar"
        Me.btnInsertar.Size = New System.Drawing.Size(85, 34)
        Me.btnInsertar.TabIndex = 11
        Me.btnInsertar.Text = "Insertar"
        Me.btnInsertar.UseVisualStyleBackColor = True
        '
        'btnModificar
        '
        Me.btnModificar.Location = New System.Drawing.Point(201, 198)
        Me.btnModificar.Name = "btnModificar"
        Me.btnModificar.Size = New System.Drawing.Size(85, 34)
        Me.btnModificar.TabIndex = 12
        Me.btnModificar.Text = "Modificar"
        Me.btnModificar.UseVisualStyleBackColor = True
        '
        'btnCerrar
        '
        Me.btnCerrar.Location = New System.Drawing.Point(19, 319)
        Me.btnCerrar.Name = "btnCerrar"
        Me.btnCerrar.Size = New System.Drawing.Size(267, 36)
        Me.btnCerrar.TabIndex = 13
        Me.btnCerrar.Text = "Cerrar"
        Me.btnCerrar.UseVisualStyleBackColor = True
        '
        'btnLimpiarDatos
        '
        Me.btnLimpiarDatos.Location = New System.Drawing.Point(19, 238)
        Me.btnLimpiarDatos.Name = "btnLimpiarDatos"
        Me.btnLimpiarDatos.Size = New System.Drawing.Size(166, 41)
        Me.btnLimpiarDatos.TabIndex = 14
        Me.btnLimpiarDatos.Text = "Limpiar datos"
        Me.btnLimpiarDatos.UseVisualStyleBackColor = True
        '
        'pnlInfoCliente
        '
        Me.pnlInfoCliente.Controls.Add(Me.Label1)
        Me.pnlInfoCliente.Controls.Add(Me.btnLimpiarDatos)
        Me.pnlInfoCliente.Controls.Add(Me.btnCerrar)
        Me.pnlInfoCliente.Controls.Add(Me.Label2)
        Me.pnlInfoCliente.Controls.Add(Me.btnModificar)
        Me.pnlInfoCliente.Controls.Add(Me.txtID)
        Me.pnlInfoCliente.Controls.Add(Me.btnEliminar)
        Me.pnlInfoCliente.Controls.Add(Me.Label3)
        Me.pnlInfoCliente.Controls.Add(Me.txtTelefono)
        Me.pnlInfoCliente.Controls.Add(Me.btnInsertar)
        Me.pnlInfoCliente.Controls.Add(Me.txtCorreo)
        Me.pnlInfoCliente.Controls.Add(Me.Label4)
        Me.pnlInfoCliente.Controls.Add(Me.txtCliente)
        Me.pnlInfoCliente.Controls.Add(Me.Label5)
        Me.pnlInfoCliente.Location = New System.Drawing.Point(12, 12)
        Me.pnlInfoCliente.Name = "pnlInfoCliente"
        Me.pnlInfoCliente.Size = New System.Drawing.Size(306, 384)
        Me.pnlInfoCliente.TabIndex = 15
        '
        'pnlCentral
        '
        Me.pnlCentral.Controls.Add(Me.pnlInfoCliente)
        Me.pnlCentral.Controls.Add(Me.GVClientes)
        Me.pnlCentral.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlCentral.Location = New System.Drawing.Point(0, 0)
        Me.pnlCentral.Name = "pnlCentral"
        Me.pnlCentral.Size = New System.Drawing.Size(926, 409)
        Me.pnlCentral.TabIndex = 16
        '
        'FrmClientes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(926, 409)
        Me.Controls.Add(Me.pnlCentral)
        Me.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "FrmClientes"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.Text = "Clientes"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.GVClientes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlInfoCliente.ResumeLayout(False)
        Me.pnlInfoCliente.PerformLayout()
        Me.pnlCentral.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents GVClientes As DataGridView
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txtID As TextBox
    Friend WithEvents txtCliente As TextBox
    Friend WithEvents txtTelefono As TextBox
    Friend WithEvents txtCorreo As TextBox
    Friend WithEvents btnEliminar As Button
    Friend WithEvents btnInsertar As Button
    Friend WithEvents btnModificar As Button
    Friend WithEvents btnCerrar As Button
    Friend WithEvents btnLimpiarDatos As Button
    Friend WithEvents pnlInfoCliente As Panel
    Friend WithEvents pnlCentral As Panel
End Class
