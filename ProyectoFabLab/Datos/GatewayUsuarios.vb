Imports System.Data.SqlClient

Public Class GatewayUsuarios
    Dim conexion As SqlConnection
    Dim comando As New SqlCommand

    Public Sub New(ByRef cadenaConexion As String)
        conexion = New SqlConnection(cadenaConexion)
        comando = New SqlCommand
        comando.Connection = conexion
    End Sub

    Public Function Insertar(nombre As String, apellidos As String, fecha_nacimiento As Date, telefono As String, email As String, direccion As String, Organizacion As String, tipo As Integer, fecha_alta As Date) As Integer
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
            comando.Parameters.Add("@fecha_nacimiento", SqlDbType.Date)
            comando.Parameters("@fecha_nacimiento").Value = fecha_alta
        End If

        Consulta = "INSERT INTO Usuarios(nombre,apellidos,fecha_nacimiento,email,direccion,organizacion,tipo,fecha_alta)" &
            "VALUES(@nombre,@apellidos,@fecha_nacimiento,@telefono,@email,@direccion,@organizacion,@tipo,@fecha_alta)"

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

    Public Function Actualizar(id As Integer, nombre As String, apellidos As String, fecha_nacimiento As Date, telefono As String, email As String, direccion As String, Organizacion As String, tipo As Integer, fecha_alta As Date) As Integer
        Dim filas As Integer
        Dim Consulta As String

        If id = 0 Then
            Throw New ArgumentException("El id no puede ser cero")
        End If

        Consulta = String.Format("UPDATE Usuarios SET nombre={0},apellidos={1},fecha_nacimiento={2},telefono={3},email={4},direccion={5},organizacion={6},tipo={7},fecha_alta={8} WHERE id={9}", nombre, apellidos, fecha_nacimiento, email, direccion, Organizacion, tipo, fecha_alta, id)
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
    Public Function SelecionarConID(id As Integer) As DataTable
        Dim Consulta As String
        Dim todo As New DataTable
        Dim reader As SqlDataReader

        Consulta = String.Format("SELECT * FROM Usuarios WHERE id='{0}'", id)
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

    Public Function ActualizarBaseDatosUsuarios() As Integer
        Dim filas As Integer
        Dim consulta As String = String.Format("ALTER TABLE [dbo].[Usuarios] ADD [observaciones] TEXT NULL")

        Return filas
    End Function
End Class