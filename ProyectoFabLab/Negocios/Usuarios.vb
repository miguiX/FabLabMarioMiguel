Module Usuarios
    Public Function CargarUsuarios() As DataTable
        Dim usuarios As New GatewayUsuarios(My.Settings.cadenaConexion)
        Return usuarios.SeleccionarTodo
    End Function

    Public Sub AgregarUsuario(nombre As String, apellidos As String, fecha_nacimiento As Date, telefono As String, email As String, direccion As String, Organizacion As String, tipo As Integer, fecha_alta As Date)
        Dim usuarios As New GatewayUsuarios(My.Settings.cadenaConexion)
        CargarUsuarios()
    End Sub

    Public Function BuscarPorId(id As Integer) As DataTable
        Dim usuario As New GatewayUsuarios(My.Settings.cadenaConexion)
        Return usuario.SelecionarConID(id)
    End Function

    Public Sub Eliminar(id As Integer)
        Dim usuario As New GatewayUsuarios(My.Settings.cadenaConexion)
        usuario.Eliminar(id)
    End Sub

    Public Function CargarTipoUsuarios() As List(Of String)
        Dim usuario As New GatewayTipoUsuario(My.Settings.cadenaConexion)
        Dim lista As List(Of String) = New List(Of String)
        Dim tabla As DataTable

        tabla = usuario.SeleccionarTodo()

        For index = 0 To tabla.Rows.Count - 1
            lista.Add(tabla.Rows(index).Item("tipo").ToString)
        Next
        Return lista
    End Function

    Public Sub AñadirTipoUsuario(ByVal TipoUsuario As String)
        Dim usuario As New GatewayTipoUsuario(My.Settings.cadenaConexion)
        usuario.Insertar(TipoUsuario)
    End Sub


End Module
