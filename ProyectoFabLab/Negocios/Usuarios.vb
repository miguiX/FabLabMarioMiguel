Module Usuarios
    Public Function CargarUsuarios() As DataTable
        Dim usuarios As New GatewayUsuarios(My.Settings.cadenaConexion)
        Return usuarios.SeleccionarTodo
    End Function
End Module
