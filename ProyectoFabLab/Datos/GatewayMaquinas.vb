Imports System.Data.SqlClient
''' <summary>
''' Clase que define un gateway para la tabla Maquinas
''' </summary>

Public Class GatewayMaquinas
    ''' <summary>
    ''' Almacena el objecto Connection
    ''' </summary>
    Private conexion As SqlConnection
    ''' <summary>
    ''' Almacena el objeto Command
    ''' </summary>
    Private comando As SqlCommand
    Public Sub New(ByRef cadenaConexion As String)
        conexion = New SqlConnection(cadenaConexion)
        comando = New SqlCommand
        comando.Connection = conexion
    End Sub
    ''' <summary>
    ''' Método para insertar un registro en una base de datos
    ''' </summary>
    ''' <param name="modelo"></param>
    ''' <param name="precio_hora"></param>
    ''' <param name="fecha_compra"></param>
    ''' <param name="telefono_sat"></param>
    ''' <param name="tipo"></param>
    ''' <param name="descripcion"></param>
    ''' <param name="caracteristicas"></param>
    ''' <returns></returns>
    Public Function Insertar(modelo As String, precio_hora As Double, fecha_compra As String, telefono_sat As String, tipo As Integer, descripcion As String, caracteristicas As String) As Integer
        Dim filas As Integer
        Dim consulta As String

        'Validamos los datos
        If modelo = "" Or modelo Is Nothing Then
            Throw New ArgumentException("El modelo no puede estar vacío")
        End If

        If precio_hora = "" Or precio_hora = Nothing Then
            Throw New ArgumentException("El precio_hora no puede estar vacío")
        End If

        If fecha_compra = "" Or fecha_compra = Nothing Then
            Throw New ArgumentException("El precio_hora no puede estar vacío")
        End If

        If tipo = "" Or tipo = Nothing Then
            Throw New ArgumentException("El tipo no puede estar vacío")
        End If

        'Metemos los parámetros en el comando
        comando.Parameters.Add("@id", SqlDbType.VarChar)
        comando.Parameters("@id").Value = modelo

        comando.Parameters.Add("@precio_hora", SqlDbType.Money)
        comando.Parameters("@precio_hora").Value = precio_hora

        comando.Parameters.Add("@fecha_compra", SqlDbType.Date)
        comando.Parameters("@fecha_compra").Value = fecha_compra

        comando.Parameters.Add("@tipo", SqlDbType.Int)
        comando.Parameters("@tipo").Value = tipo

        comando.Parameters.Add("@telefono_Sat", SqlDbType.VarChar)
        comando.Parameters("@telefono_sat").Value = telefono_sat

        comando.Parameters.Add("@descripcion", SqlDbType.Text)
        comando.Parameters("@descripcion").Value = descripcion

        comando.Parameters.Add("@caracteristicas", SqlDbType.Text)
        comando.Parameters("@caracteristicas").Value = caracteristicas

        'Creamos la sentencia SQL de inserción
        consulta = "INSERT INTO Usuarios(nombre,apellidos,fecha_nacimiento,email,direccion,organizacion,tipo,fecha_alta)" &
            "VALUES(@nombre,@apellidos,@fecha_nacimiento,@telefono,@email,@direccion,@organizacion,@tipo,@fecha_alta)"

        'Ejecutamos la consulta
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
    ''' Método para actualizar un registro en la base de datos
    ''' </summary>
    ''' <param name="id"></param>
    ''' <param name="modelo"></param>
    ''' <param name="precio_hora"></param>
    ''' <param name="fecha_compra"></param>
    ''' <param name="telefono_sat"></param>
    ''' <param name="tipo"></param>
    ''' <param name="descripcion"></param>
    ''' <param name="caracteristicas"></param>
    ''' <returns></returns>
    Public Function Actualizar(id As Integer, modelo As String, precio_hora As Double, fecha_compra As String, telefono_sat As String, tipo As Integer, descripcion As String, caracteristicas As String) As Integer
        Dim filas As Integer
        Dim consulta As String

        'Validamos los datos
        If id = 0 Then
            Throw New ArgumentException("El identificador no puede ser 0")
        End If

        If modelo = "" Or modelo Is Nothing Then
            Throw New ArgumentException("El modelo no puede estar vacío")
        End If

        If precio_hora = "" Or precio_hora = Nothing Then
            Throw New ArgumentException("El precio_hora no puede estar vacío")
        End If

        If fecha_compra = "" Or fecha_compra = Nothing Then
            Throw New ArgumentException("El precio_hora no puede estar vacío")
        End If

        If tipo = "" Or tipo = Nothing Then
            Throw New ArgumentException("El tipo no puede estar vacío")
        End If

        'Metemos los parámetros en el comando
        comando.Parameters.Add("@id", SqlDbType.Int)
        comando.Parameters("@id").Value = id

        comando.Parameters.Add("@id", SqlDbType.VarChar)
        comando.Parameters("@id").Value = modelo

        comando.Parameters.Add("@precio_hora", SqlDbType.Money)
        comando.Parameters("@precio_hora").Value = precio_hora

        comando.Parameters.Add("@fecha_compra", SqlDbType.Date)
        comando.Parameters("@fecha_compra").Value = fecha_compra

        comando.Parameters.Add("@tipo", SqlDbType.Int)
        comando.Parameters("@tipo").Value = tipo

        comando.Parameters.Add("@telefono_Sat", SqlDbType.VarChar)
        comando.Parameters("@telefono_sat").Value = telefono_sat

        comando.Parameters.Add("@descripcion", SqlDbType.Text)
        comando.Parameters("@descripcion").Value = descripcion

        comando.Parameters.Add("@caracteristicas", SqlDbType.Text)
        comando.Parameters("@caracteristicas").Value = caracteristicas

        consulta = "UPDATE Usuarios SET" &
            "nombre = @nombre,apellidos," &
            "fecha_nacimiento = @fecha_nacimiento," &
            "email = @email," &
            "direccion = @direccion," &
            "organizacion = @organizacion," &
            "tipo = @tipo," &
            "fecha_alta = @fecha_alta)"

        'Ejecutamos la consulta
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
    ''' Método para eliminar un registro de la base de datos
    ''' </summary>
    ''' <param name="id"></param>
    ''' <returns></returns>
    Public Function Eliminar(id As Integer) As Integer
        Dim filas As Integer
        Dim consulta As String

        'Validamos los datos
        If id = 0 Then
            Throw New ArgumentException("El identificador no puede estar vacío")
        End If

        'Metemos los parámetros en el comando
        comando.Parameters.Add("@id", SqlDbType.Int)
        comando.Parameters("@id").Value = id

        'Creamos la sentencia SQL de eliminación
        consulta = "DELETE FROM Maquinas WHERE id = @id"

        'Ejecutamos la consulta
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
    Public Function SeleccionarTodos() As DataTable

        Dim consulta As String = String.Format("SELECT * FROM Maquinas")
        Dim resultado As New DataTable
        Dim reader As SqlDataReader

        'Ejecutamos la consulta
        Try
            conexion.Open()
            comando.CommandText = consulta
            reader = comando.ExecuteReader()
            'Cargamos el DataTable
            resultado.Load(reader)
        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        Finally
            If (conexion IsNot Nothing) Then
                conexion.Close()
            End If
        End Try
        Return resultado
    End Function
End Class
