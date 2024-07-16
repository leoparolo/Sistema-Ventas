Module UForm
    ''' <summary>
    ''' Permite abrir un formulario con un estilo determinado
    ''' </summary>
    ''' <param name="nombreForm"></param>
    Public Sub SeleccionarForm(ByRef nombreForm As Form, ByRef spContainer As SplitContainer)
        nombreForm.TopLevel = False
        nombreForm.FormBorderStyle = FormBorderStyle.None
        nombreForm.Dock = DockStyle.Fill

        spContainer.Panel2.Controls.Clear()
        spContainer.Panel2.Controls.Add(nombreForm)
        nombreForm.Show()
    End Sub
End Module
