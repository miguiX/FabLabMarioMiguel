Public Class GestionMaquinas
    Private Sub GestionMaquinas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DataGridView1.DataSource = ObtenerMaquinas("")
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        DataGridView1.DataSource = ObtenerMaquinas(TextBox1.Text)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles ButtonNuevaMaquina.Click, ButtonConsultarMaquina.Click, ButtonEliminarMaquina.Click, ButtonEditarMaquina.Click

        Dim boton As Button = DirectCast(sender, Button)

        Select Case boton.Name
            Case ButtonNuevaMaquina.Name
                NuevaMaquina()
            Case ButtonConsultarMaquina.Name
                ConsultarMaquina()
            Case ButtonEditarMaquina.Name

            Case ButtonEliminarMaquina.Name

            Case Else

        End Select
    End Sub
    Public Sub NuevaMaquina()
        Dim nuevaMaquina As FormularioMaquina = New FormularioMaquina()
        nuevaMaquina.MdiParent = Me.MdiParent
        nuevaMaquina.Text = "FabLab - Nueva Máquina"
        nuevaMaquina.Show()
    End Sub

    Public Sub ConsultarMaquina()

    End Sub

    Public Sub EditarMaquina()

    End Sub

    Public Sub EliminarMaquina()

    End Sub

    Private Sub GestionMaquinas_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        If MessageBox.Show("¿Esta seguro que desea cerrar la ventana?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) = 7 Then
            e.Cancel = True
        End If
    End Sub
End Class