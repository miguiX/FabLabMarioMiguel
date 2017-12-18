Imports System.Text.RegularExpressions

Public Class NuevoUsuario
    Dim Tipos As List(Of String)
    Dim ErrorTextBox As New ErrorProvider
    Dim confirmarEmail As New Regex("^[_a-z0-9-]+(.[a-z0-9-]+)@[a-z0-9-]+(.[a-z0-9-]+)*(.[a-z]{2,4})$")
    Public Cargar As String
    Public id As Integer
    Public Nombre As String
    Public Apellidos As String
    Public FechaNacimiento As Date
    Public Telefono As String
    Public Organizacion As String
    Public Email As String
    Public Direccion As String
    Public Tipo As String
    Public Observaciones As String
    Private Sub NuevoUsuario_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DateTimePickerFechaNacimiento.Format = DateTimePickerFormat.Custom
        DateTimePickerFechaNacimiento.CustomFormat = "dd-MM-yyyy"
        AñadirNuevosTiposOcultar()
        CargarTipos()
        If Cargar = "Editar" Then
            CargarUsuario()
        ElseIf Cargar = "Consultar" Then
            ButtonAñadirNuevoTipo.Hide()
            BloquearTodo()
            CargarUsuario()
        End If
    End Sub
    Private Sub CargarTipos()
        Tipos = Usuarios.CargarTipoUsuarios()
        ComboBoxTipo.DataSource = Tipos
        ComboBoxTipo.DisplayMember = "tipo"
    End Sub
    Private Sub AñadirNuevosTiposMostrar()
        LabelNuevoTipo.Show()
        ButtonAñadirTipo.Show()
        TextBoxNuevoTipo.Show()
    End Sub
    Private Sub AñadirNuevosTiposOcultar()
        LabelNuevoTipo.Hide()
        ButtonAñadirTipo.Hide()
        TextBoxNuevoTipo.Hide()
    End Sub
    Private Sub BloquearTodo()
        MaskedTextBoxNombre.Enabled = False
        MaskedTextBoxApellidos.Enabled = False
        MaskedTextBoxTelefono.Enabled = False
        MaskedTextBoxEmail.Enabled = False
        MaskedTextBoxOrganizacion.Enabled = False
        MaskedTextBoxDireccion.Enabled = False
        RichTextBoxObservaciones.Enabled = False
        ComboBoxTipo.Enabled = False
        DateTimePickerFechaNacimiento.Enabled = False
    End Sub
    Private Sub CargarUsuario()
        MaskedTextBoxNombre.Text = Nombre
        MaskedTextBoxApellidos.Text = Apellidos
        MaskedTextBoxTelefono.Text = Telefono
        MaskedTextBoxEmail.Text = Email
        MaskedTextBoxOrganizacion.Text = Organizacion
        MaskedTextBoxDireccion.Text = Direccion
        DateTimePickerFechaNacimiento.Value = FechaNacimiento
    End Sub

    Private Sub ButtonAceptar_Click(sender As Object, e As EventArgs) Handles ButtonAceptar.Click
        If Cargar = "Nuevo" Then
            Usuarios.AgregarUsuario(MaskedTextBoxNombre.Text, MaskedTextBoxApellidos.Text, DateTimePickerFechaNacimiento.Value, MaskedTextBoxTelefono.Text, MaskedTextBoxEmail.Text, MaskedTextBoxDireccion.Text, MaskedTextBoxOrganizacion.Text, ComboBoxTipo.SelectedIndex + 1, DateTime.Now.Date, RichTextBoxObservaciones.Text)
            Me.Close()
        ElseIf Cargar = "Editar" Then
            Usuarios.ModificarUsuario(id, MaskedTextBoxNombre.Text, MaskedTextBoxApellidos.Text, DateTimePickerFechaNacimiento.Value, MaskedTextBoxTelefono.Text, MaskedTextBoxEmail.Text, MaskedTextBoxDireccion.Text, MaskedTextBoxOrganizacion.Text, ComboBoxTipo.SelectedIndex + 1, RichTextBoxObservaciones.Text)
            Me.Close()
        ElseIf Cargar = "Consultar" Then
            Me.Close()
        End If
    End Sub

    Private Sub ButtonCancelar_Click(sender As Object, e As EventArgs) Handles ButtonCancelar.Click
        Me.Close()
    End Sub

    Private Sub ButtonAñadirNuevoTipo_Click(sender As Object, e As EventArgs) Handles ButtonAñadirNuevoTipo.Click
        AñadirNuevosTiposMostrar()
    End Sub

    Private Sub ButtonAñadirTipo_Click(sender As Object, e As EventArgs) Handles ButtonAñadirTipo.Click
        Usuarios.AñadirTipoUsuario(TextBoxNuevoTipo.Text)
        CargarTipos()
        AñadirNuevosTiposOcultar()
    End Sub

    Private Sub NuevoUsuario_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        If MessageBox.Show("¿Esta seguro que desea cerrar la ventana?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) = 7 Then
            e.Cancel = True
        End If
    End Sub

    Private Sub MaskedTextBoxNombre_Validated(sender As Object, e As EventArgs) Handles MaskedTextBoxNombre.Validated
        If MaskedTextBoxNombre.Text = "" Then
            ErrorTextBox.SetError(MaskedTextBoxNombre, "Introduce algun nombre")
        End If
    End Sub

    Private Sub MaskedTextBoxNombre_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles MaskedTextBoxNombre.Validating
        ErrorTextBox.SetError(MaskedTextBoxNombre, "")
    End Sub

    Private Sub MaskedTextBoxApellidos_Validated(sender As Object, e As EventArgs) Handles MaskedTextBoxApellidos.Validated
        If MaskedTextBoxApellidos.Text = "" Then
            ErrorTextBox.SetError(MaskedTextBoxApellidos, "Introduce algun apellido")
        End If
    End Sub

    Private Sub MaskedTextBoxApellidos_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles MaskedTextBoxApellidos.Validating
        ErrorTextBox.SetError(MaskedTextBoxApellidos, "")
    End Sub

    Private Sub MaskedTextBoxOrganizacion_Validated(sender As Object, e As EventArgs) Handles MaskedTextBoxOrganizacion.Validated
        If ComboBoxTipo.Text = "Profesional" Or ComboBoxTipo.Text = "Investigador" Then
            ErrorTextBox.SetError(MaskedTextBoxOrganizacion, "Introduce una organizacion ya que el usuario es Profesional o Investigador")
        End If
    End Sub

    Private Sub MaskedTextBoxOrganizacion_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles MaskedTextBoxOrganizacion.Validating
        ErrorTextBox.SetError(MaskedTextBoxOrganizacion, "")
    End Sub

    Private Sub MaskedTextBoxEmail_Validated(sender As Object, e As EventArgs) Handles MaskedTextBoxEmail.Validated
        If confirmarEmail.IsMatch(MaskedTextBoxEmail.Text) Then
            ErrorTextBox.SetError(MaskedTextBoxEmail, "Introduce un email valido")
        End If
    End Sub

    Private Sub MaskedTextBoxEmail_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles MaskedTextBoxEmail.Validating
        ErrorTextBox.SetError(MaskedTextBoxEmail, "")
    End Sub

    Private Sub PonerImagen()
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.Image = System.Drawing.Bitmap.FromFile(My.Settings.CarpetaImagenes & id & MaskedTextBoxNombre.Text.Trim() & ".jpg")
    End Sub

    Private Sub ButtonExaminar_Click(sender As Object, e As EventArgs) Handles ButtonExaminar.Click
        OpenFileDialogFoto.Filter = "Bitmap |*.bmp| JPG | *.jpg | GIF | *.gif | All Files|*.*"
        OpenFileDialogFoto.FileName = ""

        If OpenFileDialogFoto.ShowDialog(Me) = DialogResult.OK Then
            Dim img As String = OpenFileDialogFoto.FileName
            FileCopy(img, My.Settings.CarpetaImagenes)
            My.Computer.FileSystem.RenameFile(My.Settings.CarpetaImagenes & img, id & MaskedTextBoxNombre.Text.Trim() & ".jpg")
            PictureBox1.Image = System.Drawing.Bitmap.FromFile(img)
        End If
    End Sub
End Class