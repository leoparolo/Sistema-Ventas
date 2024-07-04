<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmPresupuestos
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
        Me.gvPrespuestoMensual = New System.Windows.Forms.DataGridView()
        Me.cmbMes = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cmbAnio = New System.Windows.Forms.ComboBox()
        CType(Me.gvPrespuestoMensual, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'gvPrespuestoMensual
        '
        Me.gvPrespuestoMensual.AllowUserToAddRows = False
        Me.gvPrespuestoMensual.AllowUserToDeleteRows = False
        Me.gvPrespuestoMensual.AllowUserToOrderColumns = True
        Me.gvPrespuestoMensual.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.gvPrespuestoMensual.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.gvPrespuestoMensual.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.gvPrespuestoMensual.Location = New System.Drawing.Point(14, 73)
        Me.gvPrespuestoMensual.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.gvPrespuestoMensual.MultiSelect = False
        Me.gvPrespuestoMensual.Name = "gvPrespuestoMensual"
        Me.gvPrespuestoMensual.ReadOnly = True
        Me.gvPrespuestoMensual.RowHeadersVisible = False
        Me.gvPrespuestoMensual.Size = New System.Drawing.Size(592, 408)
        Me.gvPrespuestoMensual.TabIndex = 6
        '
        'cmbMes
        '
        Me.cmbMes.FormattingEnabled = True
        Me.cmbMes.Location = New System.Drawing.Point(70, 18)
        Me.cmbMes.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cmbMes.Name = "cmbMes"
        Me.cmbMes.Size = New System.Drawing.Size(138, 28)
        Me.cmbMes.TabIndex = 7
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(36, 20)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Mes"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(259, 21)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(36, 20)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "Año"
        '
        'cmbAnio
        '
        Me.cmbAnio.FormattingEnabled = True
        Me.cmbAnio.Location = New System.Drawing.Point(317, 18)
        Me.cmbAnio.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cmbAnio.Name = "cmbAnio"
        Me.cmbAnio.Size = New System.Drawing.Size(138, 28)
        Me.cmbAnio.TabIndex = 9
        '
        'FrmPresupuestos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(621, 495)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.cmbAnio)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cmbMes)
        Me.Controls.Add(Me.gvPrespuestoMensual)
        Me.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.Name = "FrmPresupuestos"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.Text = "Presupuestos mensual"
        CType(Me.gvPrespuestoMensual, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents gvPrespuestoMensual As DataGridView
    Friend WithEvents cmbMes As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents cmbAnio As ComboBox
End Class
