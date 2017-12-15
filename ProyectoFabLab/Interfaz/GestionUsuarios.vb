Public Class GestionUsuarios
    Private Sub GestionUsuarios_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DataUsuarios.DataSource = Usuarios.CargarUsuarios
    End Sub
End Class