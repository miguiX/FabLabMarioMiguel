Public Class Principal
    Private Sub Principal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim NuevoForm As New PantallaBienvenida
        NuevoForm.MdiParent = Me
        NuevoForm.Text = "Pantalla Bienvenida - FabLab"
        NuevoForm.Show()
    End Sub
End Class
