Module Maquinas
    Public Sub InsertarMaquina(modelo As String, precio_hora As Double, fecha_compra As Date, telefono_sat As String, tipo As Integer, descripcion As String, caracteristicas As String)

        Dim gateway As New GatewayMaquinas(My.Settings.cadenaConexion)

        If ExisteModeloFecha(modelo, fecha_compra) Then
            Throw New ApplicationException("No puedes repetir dos modelos con la misma fecha de compra")
        ElseIf (precio_hora <= 0) Then
            Throw New ApplicationException("El precio por hora no puede ser 0 o negativo")
        Else
            gateway.Insertar(modelo, precio_hora, fecha_compra, telefono_sat, tipo, descripcion, caracteristicas)
        End If

    End Sub
    Public Function ObtenerMaquinas(modelo As String) As DataTable
        Dim gateway As New GatewayMaquinas(My.Settings.cadenaConexion)

        Return gateway.Seleccionar(modelo)
    End Function
    Public Sub ActualizarMaquina(id As Integer, modelo As String, precio_hora As Double, fecha_compra As Date, telefono_sat As String, tipo As Integer, descripcion As String, caracteristicas As String)

    End Sub
    Private Function ExisteModeloFecha(modelo As String, fecha As Date) As Boolean
        Dim gateway As New GatewayMaquinas(My.Settings.cadenaConexion)
        Dim tabla As DataTable

        'Utilizamos el método SeleccionarModeloFecha del gateway
        tabla = gateway.SeleccionarModeloFecha(modelo, fecha)

        'Si el resultado tiene 1 filas o mas, no puede haber más de 1 modelo con la misma fecha de compra
        If tabla.Rows.Count >= 1 Then
            Return True
        Else
            Return False
        End If

    End Function

End Module
