Imports System.Data.SqlClient

Public Class GatewayUsuaios
    Dim conexion As SqlConnection
    Dim comando As New SqlCommand

    Public Sub New(ByRef cadenaConexion As String)
        conexion = New SqlConnection(cadenaConexion)
        comando = New SqlCommand
    End Sub

    Public Function Insertar(id As Integer, nombre As String, apellidos As String, fecha_nacimiento As Date, email As String, direccion As String, Organizacion As String, tipo As Integer, fecha_alta As Date)
        Dim Consulta

        Consulta = "INSERT Into Usuarios (id,nombre,apellidos, fecha_nacimiento, email, direccion, Organizacion, tipo, fecha_alta) VALUES (@id, @nombre, @apellidos, @fecha_nacimiento, @email, @direccion, @Organizacion, @tipo, @fecha_alta"

    End Function
End Class