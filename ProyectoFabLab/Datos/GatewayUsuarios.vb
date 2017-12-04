Imports System.Data.SqlClient

Public Class GatewayUsuaios
    Dim conexion As SqlConnection
    Dim comando As New SqlCommand

    Public Sub New(ByRef cadenaConexion As String)
        conexion = New SqlConnection(cadenaConexion)
        comando = New SqlCommand
    End Sub

    Public Function Insertar(id As Integer, nombre As String, apellidos As String, fecha_nacimiento As Date, email As String, direccion As String, Organizacion As String, tipo As Integer, fecha_alta As Date)
        Dim filas As Integer
        Dim Consulta

        Consulta = String.Format("INSERT Into Usuarios (id,nombre,apellidos, fecha_nacimiento, email, direccion, Organizacion, tipo, fecha_alta) VALUES ('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}')", id, nombre, apellidos, fecha_nacimiento, email, direccion, Organizacion, tipo, fecha_alta)

        If nombre = "" Or nombre Is Nothing Then
            Throw New ArgumentException("El nombre no puede estar vacío")
        End If

        If apellidos = "" Or apellidos Is Nothing Then
            Throw New ArgumentException("Los apellidos no puede estar vacío")
        End If
        If fecha_nacimiento = "" Then
            Throw New ArgumentException("La fecha_nacimiento no puede estar vacía")
        End If
        If fecha_nacimiento = "" Then
            Throw New ArgumentException("La fecha_nacimiento no puede estar vacía")
        End If

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
End Class