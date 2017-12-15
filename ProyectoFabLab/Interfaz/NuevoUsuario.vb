Public Class NuevoUsuario
    Private Sub NuevoUsuario_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DateTimePicker1.Format = DateTimePickerFormat.Custom
        DateTimePicker1.CustomFormat = "dd-MM-yyyy"

    End Sub
End Class