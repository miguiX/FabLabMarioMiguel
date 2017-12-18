Module Maquinas
    Public Sub InsertarMaquina(modelo As String, precio_hora As Double, fecha_compra As Date, telefono_sat As String, tipo As Integer, descripcion As String, caracteristicas As String)

        Dim gateway As New GatewayMaquinas(My.Settings.cadenaConexion)
        Dim er As New System.Text.RegularExpressions.Regex("[0-9]{9}")

        If Not er.IsMatch(telefono_sat) Then
            Throw New ArgumentException("El teléfono debe contener 9 dígitos")

        End If
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
        Dim gateway As New GatewayMaquinas(My.Settings.cadenaConexion)
        Dim er As New System.Text.RegularExpressions.Regex("[0-9]{9}")

        If Not er.IsMatch(telefono_sat) Then
            Throw New ArgumentException("El teléfono debe contener 9 dígitos")
        End If

        If ExisteModeloFecha(modelo, fecha_compra) Then
            Throw New ApplicationException("No puedes repetir dos modelos con la misma fecha de compra")
        ElseIf (precio_hora <= 0) Then
            Throw New ApplicationException("El precio por hora no puede ser 0 o negativo")
        Else
            gateway.Actualizar(id, modelo, precio_hora, fecha_compra, telefono_sat, tipo, descripcion, caracteristicas)
        End If
    End Sub

    Public Function ObtenerTiposMaquina() As DataTable
        Dim gateway As New GatewayTipoMaquina(My.Settings.cadenaConexion)
        Dim tabla As DataTable
        tabla = gateway.SeleccionarTodo()
        Return tabla
    End Function

    Public Sub InsertarTipo(tipo As String)
        Dim gateway As New GatewayTipoMaquina(My.Settings.cadenaConexion)
        gateway.Insertar(tipo)
    End Sub

    Public Function ObtenerTipoMaquinaPorId(id As Integer) As String
        Dim gateway As New GatewayTipoMaquina(My.Settings.cadenaConexion)
        Dim tabla As DataTable
        tabla = gateway.SeleccionarPorId(id)
        If tabla.Rows.Count = 0 Then
            Throw New Exception("El tipo no existe")
        End If
        Return tabla.Rows(0).Item(1).ToString
    End Function

    Public Function ObtenerIdTipoMaquinaPorTipo(tipo As String) As Integer
        Dim gateway As New GatewayTipoMaquina(My.Settings.cadenaConexion)
        Dim tabla As DataTable

        tabla = gateway.SeleccionarPorTipo(tipo)

        If tabla.Rows.Count = 0 Then
            Throw New Exception("El tipo no existe")
        End If

        Return CInt(tabla.Rows(0).Item(0).ToString)
    End Function

    Public Function ObtenerMaquinasPorId(id As Integer) As DataTable
        Dim gateway As New GatewayMaquinas(My.Settings.cadenaConexion)

        Return gateway.SeleccionarPorId(id)
    End Function

    Public Function NumeroMaquinas() As Integer
        Dim gateway As New GatewayMaquinas(My.Settings.cadenaConexion)
        'Utilizamos el método SeleccionarModeloFecha del gateway
        Return gateway.Seleccionar("").Rows.Count
    End Function

    Public Function ExisteModeloFecha(modelo As String, fecha As Date) As Boolean
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

    Public Sub EliminarMaquina(id As Integer)
        Dim gateway As New GatewayMaquinas(My.Settings.cadenaConexion)
        gateway.Eliminar(id)
    End Sub
End Module
