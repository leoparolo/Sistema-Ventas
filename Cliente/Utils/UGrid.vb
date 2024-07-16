Module UGrid
    Public Sub FormatColumns(ByRef Grid As DataGridView)
        For Each column As DataGridViewColumn In Grid.Columns
            column.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
            column.HeaderCell.Style.Font = New Font(Grid.Font, FontStyle.Bold)
            column.ReadOnly = True
        Next
    End Sub
End Module
