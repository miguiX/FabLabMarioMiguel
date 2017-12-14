Public Class PantallaBienvenida
    Private Sub PantallaBienvenida_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim gateWayUsuarios As New GatewayUsuarios(My.Settings.cadenaConexion)

        gateWayUsuarios.ActualizarBaseDatosUsuarios()
    End Sub
End Class