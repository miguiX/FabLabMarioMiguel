Public Class Principal
    Private Sub Principal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim Bienvenida As New PantallaBienvenida
        Bienvenida.MdiParent = Me
        Bienvenida.Text = "Pantalla Bienvenida - FabLab"
        Bienvenida.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Bienvenida.Dock = DockStyle.Fill
        Bienvenida.Show()
    End Sub

    Private Sub NuevaMáquinaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NuevaMáquinaToolStripMenuItem.Click
        Dim nuevaMaquina As FormularioMaquina = New FormularioMaquina()
        nuevaMaquina.MdiParent = Me
        nuevaMaquina.Text = "FabLab - Nueva Máquina"
        nuevaMaquina.Show()
    End Sub

    Private Sub GestiónDeMáquinasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GestiónDeMáquinasToolStripMenuItem.Click
        Dim gestionMaquinas As GestionMaquinas = New GestionMaquinas()
        gestionMaquinas.MdiParent = Me
        gestionMaquinas.Show()
    End Sub
End Class
