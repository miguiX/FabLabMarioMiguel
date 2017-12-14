Imports System.Data.SqlClient

Public Class GatewayReservas
    Dim conexion As SqlConnection
    Dim comando As New SqlCommand

    Public Sub New(ByRef cadenaConexion As String)
        conexion = New SqlConnection(cadenaConexion)
        comando = New SqlCommand
    End Sub

    Public Function Insertar(fecha As Date, hora As Timer, Usuario As Integer, proyecto As String) As Integer
        Dim filas As Integer
        Dim Consulta As String

        Consulta = String.Format("INSERT INTO Reservas(fecha,hora,usuarios,proyecto")
    End Function

End Class
