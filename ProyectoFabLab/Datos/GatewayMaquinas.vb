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
    Public Function Insertar(id As Integer, modelo As String, precio_hora As Double, fecha_compra As String)

    End Function
End Class
