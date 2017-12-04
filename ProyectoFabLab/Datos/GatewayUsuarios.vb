Imports System.Data.SqlClient

Public Class GatewayUsuaios
    Dim conexion As SqlConnection
    Dim comando As New SqlCommand

    Public Sub New(ByRef cadenaConexion As String)
        conexion = New SqlConnection(cadenaConexion)
        comando = New SqlCommand
    End Sub

    Public Function Insertar(id As Integer, nombre As String, apellidos As String, fecha_nacimiento As Date, telefono As String, email As String, direccion As String, Organizacion As String, tipo As Integer, fecha_alta As Date)
        Dim filas As Integer
        Dim Consulta

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
End Class