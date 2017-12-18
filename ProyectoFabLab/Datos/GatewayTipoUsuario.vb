Imports System.Data.SqlClient

Public Class GatewayTipoUsuario
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
    ''' Inserta un tipo en la tabla de tipos
    ''' </summary>
    ''' <returns></returns>
    Public Function Insertar(tipo As String) As Integer
        Dim filas As Integer
        Dim Consulta As String

        If tipo = "" Then
            Throw New ArgumentException("No se puede dejar el tipo vacio")
        End If
        Consulta = String.Format("INSERT INTO TiposUsuario(tipo) VALUES ('{0}')", tipo)

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
    ''' Actualiza un tipo
    ''' </summary>
    ''' <returns></returns>
    Public Function Actualizar(id As Integer, tipo As String) As Integer
        Dim filas As Integer
        Dim Consulta As String

        If id = 0 Then
            Throw New ArgumentException("El id no puede ser cero")
        End If

        Consulta = String.Format("UPDATE TiposUsuario SET tipo={0} WHERE id={1}", tipo, id)

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
    ''' Permite eliminar un tipo de la base de datos
    ''' </summary>
    ''' <returns></returns>
    Public Function Eliminar(id As Integer) As Integer
        Dim filas As Integer
        Dim consulta As String = String.Format("DELETE FROM TiposUsuario WHERE id={0}", id)

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
    ''' Permite mostrar todos los tipos
    ''' </summary>
    ''' <returns></returns>
    Public Function SeleccionarTodo() As DataTable
        Dim Consulta As String
        Dim todo As New DataTable
        Dim reader As SqlDataReader

        Consulta = String.Format("SELECT * FROM TiposUsuario")

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
End Class
