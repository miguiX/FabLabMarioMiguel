Public Class GestionMaquinas
    Private Sub GestionMaquinas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ActualizarGrid()
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
                EditarMaquina()
            Case ButtonEliminarMaquina.Name
                EliminarMaquina()
            Case Else

        End Select
    End Sub

    Public Sub ActualizarGrid()
        DataGridView1.DataSource = ObtenerMaquinas("")
        DataGridView1.Columns(0).Visible = False
    End Sub

    Public Sub NuevaMaquina()
        Dim nuevaMaquina As FormularioMaquina = New FormularioMaquina()
        nuevaMaquina.MdiParent = Me.MdiParent
        nuevaMaquina.Nuevo()
    End Sub

    Public Sub ConsultarMaquina()
        Dim consultaMaquina As FormularioMaquina = New FormularioMaquina()
        consultaMaquina.MdiParent = Me.MdiParent
        consultaMaquina.Consultar(idSeleccionado())
    End Sub

    Public Sub EditarMaquina()
        Dim consultaMaquina As FormularioMaquina = New FormularioMaquina()
        consultaMaquina.MdiParent = Me.MdiParent
        consultaMaquina.Editar(idSeleccionado())
    End Sub

    Public Sub EliminarMaquina()
        Maquinas.EliminarMaquina(idSeleccionado())
        ActualizarGrid()
    End Sub

    Private Sub GestionMaquinas_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        If MessageBox.Show("¿Esta seguro que desea cerrar la ventana?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) = 7 Then
            e.Cancel = True
        End If
    End Sub

    Private Function idSeleccionado() As Integer
        Try
            Return CInt(DataGridView1.SelectedRows(0).Cells.Item(0).Value.ToString)
        Catch e As Exception
            Try
                Return CInt(DataGridView1.SelectedCells(0).OwningRow.Cells.Item(0).Value.ToString)
            Catch e2 As Exception
                Throw New Exception("No se ha seleccionado nada", e2)
            End Try
        End Try
    End Function



End Class