<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmProductos
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
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GVProductos = New System.Windows.Forms.DataGridView()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtID = New System.Windows.Forms.TextBox()
        Me.txtPrecio = New System.Windows.Forms.TextBox()
        Me.txtCategoria = New System.Windows.Forms.TextBox()
        Me.btnEliminar = New System.Windows.Forms.Button()
        Me.btnInsertar = New System.Windows.Forms.Button()
        Me.btnModificar = New System.Windows.Forms.Button()
        Me.btnCerrar = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnLimpiarDatos = New System.Windows.Forms.Button()
        Me.pnlCentral = New System.Windows.Forms.Panel()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtBusqueda = New System.Windows.Forms.TextBox()
        CType(Me.GVProductos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.pnlCentral.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtNombre
        '
        Me.txtNombre.Location = New System.Drawing.Point(123, 85)
        Me.txtNombre.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(152, 27)
        Me.txtNombre.TabIndex = 21
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Black", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(3, 7)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(306, 29)
        Me.Label1.TabIndex = 14
        Me.Label1.Text = "Información del producto"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GVProductos
        '
        Me.GVProductos.AllowUserToAddRows = False
        Me.GVProductos.AllowUserToDeleteRows = False
        Me.GVProductos.AllowUserToOrderColumns = True
        Me.GVProductos.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GVProductos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.GVProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.GVProductos.Location = New System.Drawing.Point(333, 47)
        Me.GVProductos.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.GVProductos.MultiSelect = False
        Me.GVProductos.Name = "GVProductos"
        Me.GVProductos.ReadOnly = True
        Me.GVProductos.RowHeadersVisible = False
        Me.GVProductos.Size = New System.Drawing.Size(583, 348)
        Me.GVProductos.TabIndex = 15
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(15, 56)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(24, 20)
        Me.Label2.TabIndex = 16
        Me.Label2.Text = "ID"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(15, 88)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(64, 20)
        Me.Label3.TabIndex = 17
        Me.Label3.Text = "Nombre"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(15, 124)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(50, 20)
        Me.Label4.TabIndex = 18
        Me.Label4.Text = "Precio"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(15, 157)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(74, 20)
        Me.Label5.TabIndex = 19
        Me.Label5.Text = "Categoria"
        '
        'txtID
        '
        Me.txtID.Location = New System.Drawing.Point(123, 52)
        Me.txtID.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtID.Name = "txtID"
        Me.txtID.Size = New System.Drawing.Size(152, 27)
        Me.txtID.TabIndex = 20
        '
        'txtPrecio
        '
        Me.txtPrecio.Location = New System.Drawing.Point(123, 121)
        Me.txtPrecio.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtPrecio.Name = "txtPrecio"
        Me.txtPrecio.Size = New System.Drawing.Size(152, 27)
        Me.txtPrecio.TabIndex = 22
        '
        'txtCategoria
        '
        Me.txtCategoria.Location = New System.Drawing.Point(123, 154)
        Me.txtCategoria.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtCategoria.Name = "txtCategoria"
        Me.txtCategoria.Size = New System.Drawing.Size(152, 27)
        Me.txtCategoria.TabIndex = 23
        '
        'btnEliminar
        '
        Me.btnEliminar.Location = New System.Drawing.Point(19, 198)
        Me.btnEliminar.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(85, 34)
        Me.btnEliminar.TabIndex = 24
        Me.btnEliminar.Text = "Eliminar"
        Me.btnEliminar.UseVisualStyleBackColor = True
        '
        'btnInsertar
        '
        Me.btnInsertar.Location = New System.Drawing.Point(110, 198)
        Me.btnInsertar.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnInsertar.Name = "btnInsertar"
        Me.btnInsertar.Size = New System.Drawing.Size(85, 34)
        Me.btnInsertar.TabIndex = 25
        Me.btnInsertar.Text = "Insertar"
        Me.btnInsertar.UseVisualStyleBackColor = True
        '
        'btnModificar
        '
        Me.btnModificar.Location = New System.Drawing.Point(201, 198)
        Me.btnModificar.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnModificar.Name = "btnModificar"
        Me.btnModificar.Size = New System.Drawing.Size(85, 34)
        Me.btnModificar.TabIndex = 26
        Me.btnModificar.Text = "Modificar"
        Me.btnModificar.UseVisualStyleBackColor = True
        '
        'btnCerrar
        '
        Me.btnCerrar.Location = New System.Drawing.Point(19, 319)
        Me.btnCerrar.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnCerrar.Name = "btnCerrar"
        Me.btnCerrar.Size = New System.Drawing.Size(267, 36)
        Me.btnCerrar.TabIndex = 27
        Me.btnCerrar.Text = "Cerrar"
        Me.btnCerrar.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(98, 124)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(17, 20)
        Me.Label6.TabIndex = 28
        Me.Label6.Text = "$"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.btnLimpiarDatos)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.txtID)
        Me.Panel1.Controls.Add(Me.btnCerrar)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.txtNombre)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.btnModificar)
        Me.Panel1.Controls.Add(Me.txtPrecio)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.btnInsertar)
        Me.Panel1.Controls.Add(Me.txtCategoria)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.btnEliminar)
        Me.Panel1.Location = New System.Drawing.Point(12, 12)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(306, 384)
        Me.Panel1.TabIndex = 29
        '
        'btnLimpiarDatos
        '
        Me.btnLimpiarDatos.Location = New System.Drawing.Point(19, 240)
        Me.btnLimpiarDatos.Name = "btnLimpiarDatos"
        Me.btnLimpiarDatos.Size = New System.Drawing.Size(166, 41)
        Me.btnLimpiarDatos.TabIndex = 15
        Me.btnLimpiarDatos.Text = "Limpiar datos"
        Me.btnLimpiarDatos.UseVisualStyleBackColor = True
        '
        'pnlCentral
        '
        Me.pnlCentral.Controls.Add(Me.Label7)
        Me.pnlCentral.Controls.Add(Me.txtBusqueda)
        Me.pnlCentral.Controls.Add(Me.Panel1)
        Me.pnlCentral.Controls.Add(Me.GVProductos)
        Me.pnlCentral.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlCentral.Location = New System.Drawing.Point(0, 0)
        Me.pnlCentral.Name = "pnlCentral"
        Me.pnlCentral.Size = New System.Drawing.Size(928, 409)
        Me.pnlCentral.TabIndex = 30
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe UI Black", 14.25!, System.Drawing.FontStyle.Bold)
        Me.Label7.Location = New System.Drawing.Point(330, 11)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(104, 25)
        Me.Label7.TabIndex = 31
        Me.Label7.Text = "Buscador:"
        '
        'txtBusqueda
        '
        Me.txtBusqueda.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBusqueda.Location = New System.Drawing.Point(447, 12)
        Me.txtBusqueda.Name = "txtBusqueda"
        Me.txtBusqueda.Size = New System.Drawing.Size(469, 27)
        Me.txtBusqueda.TabIndex = 30
        '
        'FrmProductos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(928, 409)
        Me.Controls.Add(Me.pnlCentral)
        Me.Font = New System.Drawing.Font("Segoe UI", 11.25!)
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "FrmProductos"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.Text = "Productos"
        CType(Me.GVProductos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.pnlCentral.ResumeLayout(False)
        Me.pnlCentral.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents txtNombre As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents GVProductos As DataGridView
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txtID As TextBox
    Friend WithEvents txtPrecio As TextBox
    Friend WithEvents txtCategoria As TextBox
    Friend WithEvents btnEliminar As Button
    Friend WithEvents btnInsertar As Button
    Friend WithEvents btnModificar As Button
    Friend WithEvents btnCerrar As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents pnlCentral As Panel
    Friend WithEvents btnLimpiarDatos As Button
    Friend WithEvents Label7 As Label
    Friend WithEvents txtBusqueda As TextBox
End Class
