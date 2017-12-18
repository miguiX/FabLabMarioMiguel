Imports System.Data.SqlClient

Public Class GatewayUsuarios
    Dim conexion As SqlConnection
    Dim comando As New SqlCommand

    ''' <summary>
    ''' Conecta el programa con la base de datos
    ''' </summary>
    Public Sub New(ByRef cadenaConexion As String)
        conexion = New SqlConnection(cadenaConexion)
        comando = New SqlCommand
        comando.Connection = conexion
    End Sub

    ''' <summary>
    ''' Inserta un usuario en la base de datos
    ''' </summary>
    ''' <param name="nombre">Nombre del usuario</param>
    ''' <param name="apellidos">Apellidos del usuario</param>
    ''' <param name="fecha_nacimiento">Fecha de nacimiento del usuario</param>
    ''' <param name="telefono">Telefono del usuario</param>
    ''' <param name="email">email del usuario</param>
    ''' <param name="direccion">Direccion del usuario</param>
    ''' <param name="Organizacion">Organizacion a la que pertenece el usuario</param>
    ''' <param name="tipo">Tipo de usuario del FabLab</param>
    ''' <param name="fecha_alta">Fecha de alta del usuario en el FabLab</param>
    ''' <param name="observaciones">Observaciones sobre el usuario</param>
    ''' <returns></returns>
    Public Function Insertar(nombre As String, apellidos As String, fecha_nacimiento As Date, telefono As String, email As String, direccion As String, Organizacion As String, tipo As Integer, fecha_alta As Date, observaciones As String) As Integer
        Dim filas As Integer
        Dim Consulta As String

        If nombre = "" Or nombre Is Nothing Then
            Throw New ArgumentException("El nombre no puede estar vacío")
        Else
            comando.Parameters.Add("@nombre", SqlDbType.VarChar)
            comando.Parameters("@nombre").Value = nombre
        End If

        If apellidos = "" Or apellidos Is Nothing Then
            Throw New ArgumentException("Los apellidos no puede estar vacío")
        Else
            comando.Parameters.Add("@apellidos", SqlDbType.VarChar)
            comando.Parameters("@apellidos").Value = apellidos
        End If

        If fecha_nacimiento = DateTime.MinValue Then
            Throw New ArgumentException("La fecha_nacimiento no puede estar vacía")
        Else
            comando.Parameters.Add("@fecha_nacimiento", SqlDbType.Date)
            comando.Parameters("@fecha_nacimiento").Value = fecha_nacimiento
        End If

        If telefono = "" Or telefono Is Nothing Then
            Throw New ArgumentException("La fecha_nacimiento no puede estar vacía")
        Else
            comando.Parameters.Add("@telefono", SqlDbType.VarChar)
            comando.Parameters("@telefono").Value = telefono
        End If
        comando.Parameters.Add("@email", SqlDbType.VarChar)
        comando.Parameters("@email").Value = email

        If direccion = "" Or direccion Is Nothing Then
            Throw New ArgumentException("La direccion no puede estar vacía")
        Else
            comando.Parameters.Add("@direccion", SqlDbType.VarChar)
            comando.Parameters("@direccion").Value = direccion
        End If

        If Organizacion = "" Or Organizacion Is Nothing Then
            comando.Parameters.Add("@Organizacion", SqlDbType.VarChar)
            comando.Parameters("@Organizacion").Value = Organizacion
        Else
            comando.Parameters.Add("@Organizacion", SqlDbType.VarChar)
            comando.Parameters("@Organizacion").Value = Organizacion
        End If

        comando.Parameters.Add("@tipo", SqlDbType.Int)
        comando.Parameters("@tipo").Value = tipo

        If fecha_alta = DateTime.MinValue Then
            Throw New ArgumentException("La fecha_nacimiento no puede estar vacía")
        Else
            comando.Parameters.Add("@fecha_alta", SqlDbType.Date)
            comando.Parameters("@fecha_alta").Value = fecha_alta
        End If
        comando.Parameters.Add("@Observaciones", SqlDbType.Text)
        comando.Parameters("@Observaciones").Value = observaciones

        Consulta = "INSERT INTO Usuarios(nombre,apellidos,fecha_nacimiento,telefono,email,direccion,organizacion,tipo,fecha_alta,Observaciones)" &
            "VALUES(@nombre,@apellidos,@fecha_nacimiento,@telefono,@email,@direccion,@organizacion,@tipo,@fecha_alta,@Observaciones)"

        Try
            conexion.Open()
            comando.CommandText = Consulta
            filas = comando.ExecuteNonQuery
        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        Finally
            If (conexion IsNot Nothing) Then
                conexion.Close()
            End If
        End Try
        Return filas
    End Function

    ''' <summary>
    ''' Actualiza los datos de un usuario
    ''' </summary>
    ''' <returns></returns>
    Public Function Actualizar(id As Integer, nombre As String, apellidos As String, fecha_nacimiento As Date, telefono As String, email As String, direccion As String, Organizacion As String, tipo As Integer, observaciones As String) As Integer
        Dim filas As Integer
        Dim Consulta As String

        If id = 0 Then
            Throw New ArgumentException("El id no puede ser cero")
        End If

        Consulta = String.Format("UPDATE Usuarios SET nombre={0},apellidos={1},fecha_nacimiento={2},telefono={3},email={4},direccion={5},organizacion={6},tipo={7},observaciones={8} WHERE id={9}", nombre, apellidos, fecha_nacimiento, email, direccion, Organizacion, tipo, observaciones, id.ToString)
        Try
            conexion.Open()
            comando.CommandText = Consulta
            filas = comando.ExecuteNonQuery
        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        Finally
            If (conexion IsNot Nothing) Then
                conexion.Close()
            End If
        End Try

        Return filas
    End Function

    ''' <summary>
    ''' Elimina un usuario
    ''' </summary>
    ''' <returns></returns>
    Public Function Eliminar(id As Integer) As Integer
        Dim filas As Integer
        Dim consulta As String = String.Format("DELETE FROM Usuarios WHERE id={0}", id)

        If id = 0 Then
            Throw New ArgumentException("El id no puede ser cero")
        End If

        Try
            conexion.Open()
            comando.CommandText = consulta
            filas = comando.ExecuteNonQuery
        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        Finally
            If (conexion IsNot Nothing) Then
                conexion.Close()
            End If
        End Try

        Return filas
    End Function

    ''' <summary>
    ''' Selecciona toda la tabla para mostrarla en un datagrid
    ''' </summary>
    ''' <returns></returns>
    Public Function SeleccionarTodo() As DataTable
        Dim Consulta As String
        Dim todo As New DataTable
        Dim reader As SqlDataReader

        Consulta = String.Format("SELECT * FROM Usuarios")

        Try
            conexion.Open()
            comando.CommandText = Consulta
            reader = comando.ExecuteReader()
            todo.Load(reader)
        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        Finally
            If (conexion IsNot Nothing) Then
                conexion.Close()
            End If
        End Try
        Return todo
    End Function

    ''' <summary>
    ''' Permite buscar un usuario dentro de la tabla usando su nombre
    ''' </summary>
    ''' <returns></returns>
    Public Function BuscarPorNombre(nombre As String) As DataTable
        Dim Consulta As String
        Dim todo As New DataTable
        Dim reader As SqlDataReader

        If nombre = "" Or nombre Is Nothing Then
            Throw New ArgumentException("El nombre no puede estar vacio")
        End If
        Consulta = String.Format("SELECT * FROM Usuarios WHERE nombre='{0}'", nombre)
        Try
            conexion.Open()
            comando.CommandText = Consulta
            reader = comando.ExecuteReader()
            todo.Load(reader)
        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        Finally
            If (conexion IsNot Nothing) Then
                conexion.Close()
            End If
        End Try
        Return todo
    End Function
    Public Function NumeroDeUsuarios() As Integer

    End Function
End Class