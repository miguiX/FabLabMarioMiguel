Public Class Principal
    Private Sub Principal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim Bienvenida As New PantallaBienvenida
        Bienvenida.MdiParent = Me
        Bienvenida.Text = "Pantalla Bienvenida - FabLab"
        Bienvenida.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Bienvenida.Dock = DockStyle.Fill
        Bienvenida.Show()
    End Sub
End Class
