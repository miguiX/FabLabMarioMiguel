Imports System.Data.SqlClient

Public Class GatewayReservas
    Dim conexion As SqlConnection
    Dim comando As New SqlCommand

    ''' <summary>
    ''' Conecta el programa con la base de datos
    ''' </summary>
    ''' <param name="cadenaConexion"></param>
    Public Sub New(ByRef cadenaConexion As String)
        conexion = New SqlConnection(cadenaConexion)
        comando = New SqlCommand
    End Sub

    ''' <summary>
    ''' Inserta una reserva en la base de datos
    ''' </summary>
    ''' <param name="fecha">fecha de la reserva</param>
    ''' <param name="hora">hora de la reserva</param>
    ''' <param name="usuario">usuario que tiene reservada la maquina</param>
    ''' <param name="proyecto">proyecto en el cual se utilizara la maquina</param>
    ''' <returns></returns>
    Public Function Insertar(fecha As Date, hora As Timer, usuario As Integer, proyecto As String) As Integer
        Dim filas As Integer
        Dim Consulta As String

        Consulta = String.Format("INSERT INTO Reservas(fecha={0},hora={1},usuarios={2},proyecto={3}", fecha, hora, usuario, proyecto)
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
    ''' Actualiza una reserva
    ''' </summary>
    ''' <returns></returns>
    Public Function Actualizar(id As Integer, fecha As Date, hora As Timer, usuario As Integer, proyecto As String) As Integer
        Dim filas As Integer
        Dim Consulta As String

        If id = 0 Then
            Throw New ArgumentException("El id no puede ser cero")
        End If

        Consulta = String.Format("UPDATE Reservas SET fecha={0},hora={1},usuario={2},proyecto={3} WHERE id={4}", fecha, hora, usuario, proyecto, id)
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
    ''' Elimina una reserva
    ''' </summary>
    ''' <returns></returns>
    Public Function Eliminar(id As Integer) As Integer
        Dim filas As Integer
        Dim consulta As String = String.Format("DELETE FROM Reservas WHERE id={0}", id)

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
    ''' Selecciona toda la tabla de reservas para mostrar en un datagrid
    ''' </summary>
    ''' <returns></returns>
    Public Function SeleccionarTodo() As DataTable
        Dim Consulta As String
        Dim todo As New DataTable
        Dim reader As SqlDataReader

        Consulta = String.Format("SELECT * FROM Reservas")

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
