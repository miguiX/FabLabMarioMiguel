Public Class GestionUsuarios
    Dim CargarNuevoUsuario As String
    Dim id As Integer
    Dim Nombre As String
    Dim Apellidos As String
    Dim FechaNacimiento As Date
    Dim Telefono As String
    Dim Organizacion As String
    Dim Email As String
    Dim Direccion As String
    Dim Tipo As String
    Dim Observaciones As String

    Private Sub GestionUsuarios_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DataUsuarios.DataSource = Usuarios.CargarUsuarios
    End Sub

    Private Sub ButtonConsultar_Click(sender As Object, e As EventArgs) Handles ButtonConsultar.Click
        Dim NuevoUsuarioForm As NuevoUsuario = New NuevoUsuario()
        Dim i As Integer
        NuevoUsuarioForm.Text = "FabLab - Consultar Usuario"
        NuevoUsuarioForm.MdiParent = Principal
        CargarNuevoUsuario = "Consultar"
        i = DataUsuarios.CurrentRow.Index

        id = Integer.Parse(DataUsuarios.Item(0, i).Value.ToString)
        Nombre = DataUsuarios.Item(1, i).Value.ToString
        Apellidos = DataUsuarios.Item(2, i).Value.ToString
        FechaNacimiento = Date.Parse(DataUsuarios.Item(3, i).Value.ToString)
        Telefono = DataUsuarios.Item(4, i).Value.ToString
        Email = DataUsuarios.Item(5, i).Value.ToString
        Direccion = DataUsuarios.Item(6, i).Value.ToString
        Organizacion = DataUsuarios.Item(7, i).Value.ToString
        Tipo = DataUsuarios.Item(8, i).Value.ToString
        Observaciones = DataUsuarios.Item(10, i).Value.ToString

        NuevoUsuarioForm.Cargar = CargarNuevoUsuario
        NuevoUsuarioForm.Nombre = Nombre
        NuevoUsuarioForm.Apellidos = Apellidos
        NuevoUsuarioForm.FechaNacimiento = FechaNacimiento
        NuevoUsuarioForm.Telefono = Telefono
        NuevoUsuarioForm.Email = Email
        NuevoUsuarioForm.Direccion = Direccion
        NuevoUsuarioForm.Organizacion = Organizacion
        NuevoUsuarioForm.Tipo = Tipo
        NuevoUsuarioForm.Observaciones = Observaciones

        NuevoUsuarioForm.Show()
    End Sub

    Private Sub ButtonEditar_Click(sender As Object, e As EventArgs) Handles ButtonEditar.Click
        Dim NuevoUsuarioForm As NuevoUsuario = New NuevoUsuario()
        NuevoUsuarioForm.MdiParent = Principal
        NuevoUsuarioForm.Text = "FabLab - Editar Usuario"

        NuevoUsuarioForm.Show()
    End Sub
End Class