Imports Controlador

Public Class FrmPresupuestos
    Private Sub FrmPresupuestos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CargarCombobox()
        Dim mes As Integer = Now.Month
        Dim anio As Integer = Now.Year
        cmbMes.SelectedItem = mes
        cmbAnio.SelectedItem = anio

        cargarPresupuesto()
        FormatColumns(gvPrespuestoMensual)
    End Sub

    Private Sub CargarCombobox()
        Dim meses As New List(Of Integer)
        'mes
        For i As Integer = 1 To 12
            meses.Add(i)
        Next

        cmbMes.DataSource = meses

        'año
        Dim años As New List(Of Integer)
        For j As Integer = 2022 To 2025
            años.Add(j)
        Next

        cmbAnio.DataSource = años
    End Sub

    Private Sub cargarPresupuesto()
        If cmbAnio.SelectedItem IsNot Nothing AndAlso cmbMes.SelectedItem IsNot Nothing Then
            Dim venta As New CLVentas
            gvPrespuestoMensual.DataSource = venta.TraerPrespuestoMensual(cmbAnio.SelectedItem, cmbMes.SelectedItem)
        End If

    End Sub

    Private Sub cmbMes_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbMes.SelectedIndexChanged
        cargarPresupuesto()
    End Sub

    Private Sub cmbAnio_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbAnio.SelectedIndexChanged
        cargarPresupuesto()
    End Sub
End Class