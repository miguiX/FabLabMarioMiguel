Imports System.Data.SqlClient

Public Class GatewayTipoMaquina
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

    Public Function Insertar(tipo As String) As Integer

        Dim filas As Integer
        Dim consulta As String

        If (tipo = "" Or tipo Is Nothing) Then
            Throw New ArgumentException("El tipo de la máquina no puede estar vacío")
        End If

        'Metemos los parámetros en el comando
        comando.Parameters.Add("@tipo", SqlDbType.VarChar)
        comando.Parameters("@tipo").Value = tipo

        'Creamos la sentencia SQL de inserción
        consulta = "INSERT INTO TiposMaquina(tipo)" &
                   "VALUES(@tipo)"

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

    Public Function SeleccionarTodo() As DataTable

        Dim consulta As String
        Dim resultado As New DataTable
        Dim reader As SqlDataReader

        consulta = "SELECT * FROM TiposMaquina"

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

    Public Function SeleccionarPorId(id As Integer) As DataTable
        Dim consulta As String
        Dim resultado As New DataTable
        Dim reader As SqlDataReader

        comando.Parameters.Add("@id", SqlDbType.Int)
        comando.Parameters("@id").Value = id

        consulta = "SELECT * FROM TiposMaquina WHERE id = @id"

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

    Public Function SeleccionarPorTipo(tipo As String) As DataTable
        Dim consulta As String
        Dim resultado As New DataTable
        Dim reader As SqlDataReader
        comando.Parameters.Add("@tipo", SqlDbType.VarChar)
        comando.Parameters("@tipo").Value = tipo
        consulta = "SELECT * FROM TiposMaquina WHERE tipo = @tipo"

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
