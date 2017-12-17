Public Class NuevoUsuario
    Dim Tipos As List(Of String)
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
End Class