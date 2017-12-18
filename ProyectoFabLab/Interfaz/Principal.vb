Public Class Principal
    Private Sub Principal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Inicializar statusStrip
        GestionMaquinas = New GestionMaquinas()
        ToolStripStatusLabel2.Text = "Máquinas: " & NumeroMaquinas().ToString()
        ToolStripStatusLabel1.Text = "Usuarios: " & Usuarios.CargarUsuarios().Rows.Count
    End Sub

    Private Sub NuevaMáquinaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NuevaMáquinaToolStripMenuItem.Click
        Dim nuevaMaquina As FormularioMaquina = New FormularioMaquina()
        nuevaMaquina.MdiParent = Me
        nuevaMaquina.Text = "FabLab - Nueva Máquina"
        nuevaMaquina.Show()
    End Sub

    Private Sub GestiónDeMáquinasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GestiónDeMáquinasToolStripMenuItem.Click
        gestionMaquinas.MdiParent = Me
        gestionMaquinas.Show()
    End Sub

    Private Sub GestionDeUsuariosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GestionDeUsuariosToolStripMenuItem.Click
        Dim gestionUsuarios As GestionUsuarios = New GestionUsuarios()
        gestionUsuarios.MdiParent = Me
        gestionUsuarios.Show()
    End Sub

    Private Sub AcercaDeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AcercaDeToolStripMenuItem.Click
        Dim acercaDe As AcercaDe = New AcercaDe()
        acercaDe.MdiParent = Me
        acercaDe.Show()
    End Sub

    Private Sub HorizontalToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HorizontalToolStripMenuItem.Click
        Me.LayoutMdi(MdiLayout.TileHorizontal)
    End Sub

    Private Sub VerticalToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VerticalToolStripMenuItem.Click
        Me.LayoutMdi(MdiLayout.TileVertical)
    End Sub

    Private Sub MinimizarTodasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MinimizarTodasToolStripMenuItem.Click
        For Each form As Form In Me.MdiChildren
            form.WindowState = WindowState.Minimized
        Next
    End Sub

    Private Sub Principal_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        If MessageBox.Show("¿Esta seguro que desea cerrar la ventana?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) = 7 Then
            e.Cancel = True
        End If
    End Sub

    Private Sub NuevoUsuarioToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NuevoUsuarioToolStripMenuItem.Click
        Dim NuevoUsuarioForm As NuevoUsuario = New NuevoUsuario()
        NuevoUsuarioForm.MdiParent = Me
        NuevoUsuarioForm.Text = "FabLab - Nuevo Usuario"
        CargarNuevoUsuario = "Nuevo"
        NuevoUsuarioForm.Cargar = CargarNuevoUsuario
        NuevoUsuarioForm.Show()
    End Sub

    Private Sub ToolStripButtonGestionUsuarios_Click(sender As Object, e As EventArgs) Handles ToolStripButtonGestionUsuarios.Click
        Dim gestionUsuarios As GestionUsuarios = New GestionUsuarios()
        gestionUsuarios.MdiParent = Me
        gestionUsuarios.Text = "FabLab - Gestion Usuarios"
        gestionUsuarios.Show()
    End Sub

    Private Sub ToolStripButtonNuevoUsuario_Click(sender As Object, e As EventArgs) Handles ToolStripButtonNuevoUsuario.Click
        Dim NuevoUsuarioForm As NuevoUsuario = New NuevoUsuario()
        NuevoUsuarioForm.MdiParent = Me
        NuevoUsuarioForm.Text = "FabLab - Nuevo Usuario"
        CargarNuevoUsuario = "Nuevo"
        NuevoUsuarioForm.Cargar = CargarNuevoUsuario
        NuevoUsuarioForm.Show()
    End Sub

    Private Sub ToolStripButtonGestionMaquinas_Click(sender As Object, e As EventArgs) Handles ToolStripButtonGestionMaquinas.Click
        Dim gestionMaquinas As GestionMaquinas = New GestionMaquinas()
        gestionMaquinas.MdiParent = Me
        gestionMaquinas.Text = "FabLab - Gestion Máquinas"
        gestionMaquinas.Show()
    End Sub

    Private Sub ToolStripButtonNuevaMaquina_Click(sender As Object, e As EventArgs) Handles ToolStripButtonNuevaMaquina.Click
        Dim nuevaMaquina As FormularioMaquina = New FormularioMaquina()
        nuevaMaquina.MdiParent = Me
        nuevaMaquina.Text = "FabLab - Nueva Máquina"
        nuevaMaquina.Show()
    End Sub
End Class
