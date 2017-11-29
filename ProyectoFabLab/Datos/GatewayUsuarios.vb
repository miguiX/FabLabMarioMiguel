Imports System.Data.SqlClient

Public Class GatewayUsuaios
    Dim conexion As SqlConnection
    Dim comando As New SqlCommand

    Public Sub New()
        conexion = New SqlConnection(My.Settings.cadenaConexion)
    End Sub
End Class