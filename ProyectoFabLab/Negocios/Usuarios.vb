Module Usuarios
    Public Function CargarUsuarios() As DataTable
        Dim usuarios As New GatewayUsuarios(My.Settings.cadenaConexion)
        Return usuarios.SeleccionarTodo
    End Function

    Public Sub AgregarUsuario(nombre As String, apellidos As String, fecha_nacimiento As Date, telefono As String, email As String, direccion As String, Organizacion As String, tipo As Integer, fecha_alta As Date)
        Dim usuarios As New GatewayUsuarios(My.Settings.cadenaConexion)

        CargarUsuarios()
    End Sub
End Module
