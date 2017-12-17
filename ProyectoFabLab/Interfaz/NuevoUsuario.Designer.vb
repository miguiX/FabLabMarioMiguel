<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class NuevoUsuario
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.Panel12 = New System.Windows.Forms.Panel()
        Me.ButtonCancelar = New System.Windows.Forms.Button()
        Me.ButtonAceptar = New System.Windows.Forms.Button()
        Me.TableLayoutPanel3 = New System.Windows.Forms.TableLayoutPanel()
        Me.Panel11 = New System.Windows.Forms.Panel()
        Me.RichTextBoxObservaciones = New System.Windows.Forms.RichTextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Panel10 = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.LabelNombre = New System.Windows.Forms.Label()
        Me.LabelTelefono = New System.Windows.Forms.Label()
        Me.LabelOrganizacion = New System.Windows.Forms.Label()
        Me.LabelApellidos = New System.Windows.Forms.Label()
        Me.LabelEmail = New System.Windows.Forms.Label()
        Me.LabelTipo = New System.Windows.Forms.Label()
        Me.LabelFechaNacimiento = New System.Windows.Forms.Label()
        Me.LabelDireccion = New System.Windows.Forms.Label()
        Me.MaskedTextBoxNombre = New System.Windows.Forms.MaskedTextBox()
        Me.MaskedTextBoxTelefono = New System.Windows.Forms.MaskedTextBox()
        Me.MaskedTextBoxOrganizacion = New System.Windows.Forms.MaskedTextBox()
        Me.MaskedTextBoxApellidos = New System.Windows.Forms.MaskedTextBox()
        Me.MaskedTextBoxEmail = New System.Windows.Forms.MaskedTextBox()
        Me.MaskedTextBoxDireccion = New System.Windows.Forms.MaskedTextBox()
        Me.DateTimePickerFechaNacimiento = New System.Windows.Forms.DateTimePicker()
        Me.LabelNuevoTipo = New System.Windows.Forms.Label()
        Me.ComboBoxTipo = New System.Windows.Forms.ComboBox()
        Me.ButtonAñadirNuevoTipo = New System.Windows.Forms.Button()
        Me.TextBoxNuevoTipo = New System.Windows.Forms.MaskedTextBox()
        Me.ButtonAñadirTipo = New System.Windows.Forms.Button()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.Panel12.SuspendLayout()
        Me.TableLayoutPanel3.SuspendLayout()
        Me.Panel11.SuspendLayout()
        Me.Panel10.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 1
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.Panel1, 0, 0)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(933, 201)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.ColumnCount = 1
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.Controls.Add(Me.Panel12, 0, 0)
        Me.TableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(0, 393)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 1
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(933, 57)
        Me.TableLayoutPanel2.TabIndex = 1
        '
        'Panel12
        '
        Me.Panel12.Controls.Add(Me.ButtonCancelar)
        Me.Panel12.Controls.Add(Me.ButtonAceptar)
        Me.Panel12.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel12.Location = New System.Drawing.Point(3, 3)
        Me.Panel12.Name = "Panel12"
        Me.Panel12.Size = New System.Drawing.Size(927, 51)
        Me.Panel12.TabIndex = 0
        '
        'ButtonCancelar
        '
        Me.ButtonCancelar.Location = New System.Drawing.Point(832, 19)
        Me.ButtonCancelar.Name = "ButtonCancelar"
        Me.ButtonCancelar.Size = New System.Drawing.Size(75, 23)
        Me.ButtonCancelar.TabIndex = 1
        Me.ButtonCancelar.Text = "Cancelar"
        Me.ButtonCancelar.UseVisualStyleBackColor = True
        '
        'ButtonAceptar
        '
        Me.ButtonAceptar.Location = New System.Drawing.Point(730, 19)
        Me.ButtonAceptar.Name = "ButtonAceptar"
        Me.ButtonAceptar.Size = New System.Drawing.Size(75, 23)
        Me.ButtonAceptar.TabIndex = 0
        Me.ButtonAceptar.Text = "Aceptar"
        Me.ButtonAceptar.UseVisualStyleBackColor = True
        '
        'TableLayoutPanel3
        '
        Me.TableLayoutPanel3.ColumnCount = 2
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 49.94664!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.05336!))
        Me.TableLayoutPanel3.Controls.Add(Me.Panel11, 1, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.Panel10, 0, 0)
        Me.TableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel3.Location = New System.Drawing.Point(0, 201)
        Me.TableLayoutPanel3.Name = "TableLayoutPanel3"
        Me.TableLayoutPanel3.RowCount = 1
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel3.Size = New System.Drawing.Size(933, 192)
        Me.TableLayoutPanel3.TabIndex = 2
        '
        'Panel11
        '
        Me.Panel11.Controls.Add(Me.RichTextBoxObservaciones)
        Me.Panel11.Controls.Add(Me.Label4)
        Me.Panel11.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel11.Location = New System.Drawing.Point(469, 3)
        Me.Panel11.Name = "Panel11"
        Me.Panel11.Size = New System.Drawing.Size(461, 186)
        Me.Panel11.TabIndex = 2
        '
        'RichTextBoxObservaciones
        '
        Me.RichTextBoxObservaciones.Location = New System.Drawing.Point(39, 42)
        Me.RichTextBoxObservaciones.Name = "RichTextBoxObservaciones"
        Me.RichTextBoxObservaciones.Size = New System.Drawing.Size(400, 134)
        Me.RichTextBoxObservaciones.TabIndex = 1
        Me.RichTextBoxObservaciones.Text = ""
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(36, 22)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(103, 17)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Observaciones"
        '
        'Panel10
        '
        Me.Panel10.Controls.Add(Me.PictureBox1)
        Me.Panel10.Controls.Add(Me.Button2)
        Me.Panel10.Controls.Add(Me.Label2)
        Me.Panel10.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel10.Location = New System.Drawing.Point(3, 3)
        Me.Panel10.Name = "Panel10"
        Me.Panel10.Size = New System.Drawing.Size(460, 186)
        Me.Panel10.TabIndex = 1
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(218, 24)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(201, 152)
        Me.PictureBox1.TabIndex = 2
        Me.PictureBox1.TabStop = False
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(68, 13)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(118, 27)
        Me.Button2.TabIndex = 1
        Me.Button2.Text = "Examinar"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(22, 13)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(40, 17)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Foto:"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.ButtonAñadirTipo)
        Me.Panel1.Controls.Add(Me.TextBoxNuevoTipo)
        Me.Panel1.Controls.Add(Me.ButtonAñadirNuevoTipo)
        Me.Panel1.Controls.Add(Me.ComboBoxTipo)
        Me.Panel1.Controls.Add(Me.LabelNuevoTipo)
        Me.Panel1.Controls.Add(Me.DateTimePickerFechaNacimiento)
        Me.Panel1.Controls.Add(Me.MaskedTextBoxDireccion)
        Me.Panel1.Controls.Add(Me.MaskedTextBoxEmail)
        Me.Panel1.Controls.Add(Me.MaskedTextBoxApellidos)
        Me.Panel1.Controls.Add(Me.MaskedTextBoxOrganizacion)
        Me.Panel1.Controls.Add(Me.MaskedTextBoxTelefono)
        Me.Panel1.Controls.Add(Me.MaskedTextBoxNombre)
        Me.Panel1.Controls.Add(Me.LabelDireccion)
        Me.Panel1.Controls.Add(Me.LabelFechaNacimiento)
        Me.Panel1.Controls.Add(Me.LabelTipo)
        Me.Panel1.Controls.Add(Me.LabelEmail)
        Me.Panel1.Controls.Add(Me.LabelApellidos)
        Me.Panel1.Controls.Add(Me.LabelOrganizacion)
        Me.Panel1.Controls.Add(Me.LabelTelefono)
        Me.Panel1.Controls.Add(Me.LabelNombre)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(3, 3)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(927, 195)
        Me.Panel1.TabIndex = 0
        '
        'LabelNombre
        '
        Me.LabelNombre.AutoSize = True
        Me.LabelNombre.Location = New System.Drawing.Point(31, 29)
        Me.LabelNombre.Name = "LabelNombre"
        Me.LabelNombre.Size = New System.Drawing.Size(58, 17)
        Me.LabelNombre.TabIndex = 0
        Me.LabelNombre.Text = "Nombre"
        '
        'LabelTelefono
        '
        Me.LabelTelefono.AutoSize = True
        Me.LabelTelefono.Location = New System.Drawing.Point(31, 84)
        Me.LabelTelefono.Name = "LabelTelefono"
        Me.LabelTelefono.Size = New System.Drawing.Size(64, 17)
        Me.LabelTelefono.TabIndex = 1
        Me.LabelTelefono.Text = "Teléfono"
        '
        'LabelOrganizacion
        '
        Me.LabelOrganizacion.AutoSize = True
        Me.LabelOrganizacion.Location = New System.Drawing.Point(31, 140)
        Me.LabelOrganizacion.Name = "LabelOrganizacion"
        Me.LabelOrganizacion.Size = New System.Drawing.Size(92, 17)
        Me.LabelOrganizacion.TabIndex = 2
        Me.LabelOrganizacion.Text = "Organización"
        '
        'LabelApellidos
        '
        Me.LabelApellidos.AutoSize = True
        Me.LabelApellidos.Location = New System.Drawing.Point(332, 29)
        Me.LabelApellidos.Name = "LabelApellidos"
        Me.LabelApellidos.Size = New System.Drawing.Size(65, 17)
        Me.LabelApellidos.TabIndex = 3
        Me.LabelApellidos.Text = "Apellidos"
        '
        'LabelEmail
        '
        Me.LabelEmail.AutoSize = True
        Me.LabelEmail.Location = New System.Drawing.Point(332, 84)
        Me.LabelEmail.Name = "LabelEmail"
        Me.LabelEmail.Size = New System.Drawing.Size(47, 17)
        Me.LabelEmail.TabIndex = 4
        Me.LabelEmail.Text = "E-mail"
        '
        'LabelTipo
        '
        Me.LabelTipo.AutoSize = True
        Me.LabelTipo.Location = New System.Drawing.Point(332, 140)
        Me.LabelTipo.Name = "LabelTipo"
        Me.LabelTipo.Size = New System.Drawing.Size(36, 17)
        Me.LabelTipo.TabIndex = 5
        Me.LabelTipo.Text = "Tipo"
        '
        'LabelFechaNacimiento
        '
        Me.LabelFechaNacimiento.AutoSize = True
        Me.LabelFechaNacimiento.Location = New System.Drawing.Point(618, 29)
        Me.LabelFechaNacimiento.Name = "LabelFechaNacimiento"
        Me.LabelFechaNacimiento.Size = New System.Drawing.Size(141, 17)
        Me.LabelFechaNacimiento.TabIndex = 6
        Me.LabelFechaNacimiento.Text = "Fecha de Nacimiento"
        '
        'LabelDireccion
        '
        Me.LabelDireccion.AutoSize = True
        Me.LabelDireccion.Location = New System.Drawing.Point(618, 84)
        Me.LabelDireccion.Name = "LabelDireccion"
        Me.LabelDireccion.Size = New System.Drawing.Size(67, 17)
        Me.LabelDireccion.TabIndex = 7
        Me.LabelDireccion.Text = "Direccion"
        '
        'MaskedTextBoxNombre
        '
        Me.MaskedTextBoxNombre.Location = New System.Drawing.Point(96, 29)
        Me.MaskedTextBoxNombre.Name = "MaskedTextBoxNombre"
        Me.MaskedTextBoxNombre.Size = New System.Drawing.Size(212, 22)
        Me.MaskedTextBoxNombre.TabIndex = 8
        '
        'MaskedTextBoxTelefono
        '
        Me.MaskedTextBoxTelefono.Location = New System.Drawing.Point(96, 79)
        Me.MaskedTextBoxTelefono.Name = "MaskedTextBoxTelefono"
        Me.MaskedTextBoxTelefono.Size = New System.Drawing.Size(212, 22)
        Me.MaskedTextBoxTelefono.TabIndex = 9
        '
        'MaskedTextBoxOrganizacion
        '
        Me.MaskedTextBoxOrganizacion.Location = New System.Drawing.Point(129, 140)
        Me.MaskedTextBoxOrganizacion.Name = "MaskedTextBoxOrganizacion"
        Me.MaskedTextBoxOrganizacion.Size = New System.Drawing.Size(179, 22)
        Me.MaskedTextBoxOrganizacion.TabIndex = 10
        '
        'MaskedTextBoxApellidos
        '
        Me.MaskedTextBoxApellidos.Location = New System.Drawing.Point(403, 29)
        Me.MaskedTextBoxApellidos.Name = "MaskedTextBoxApellidos"
        Me.MaskedTextBoxApellidos.Size = New System.Drawing.Size(212, 22)
        Me.MaskedTextBoxApellidos.TabIndex = 11
        '
        'MaskedTextBoxEmail
        '
        Me.MaskedTextBoxEmail.Location = New System.Drawing.Point(385, 84)
        Me.MaskedTextBoxEmail.Name = "MaskedTextBoxEmail"
        Me.MaskedTextBoxEmail.Size = New System.Drawing.Size(230, 22)
        Me.MaskedTextBoxEmail.TabIndex = 12
        '
        'MaskedTextBoxDireccion
        '
        Me.MaskedTextBoxDireccion.Location = New System.Drawing.Point(691, 84)
        Me.MaskedTextBoxDireccion.Name = "MaskedTextBoxDireccion"
        Me.MaskedTextBoxDireccion.Size = New System.Drawing.Size(224, 22)
        Me.MaskedTextBoxDireccion.TabIndex = 14
        '
        'DateTimePickerFechaNacimiento
        '
        Me.DateTimePickerFechaNacimiento.Location = New System.Drawing.Point(757, 28)
        Me.DateTimePickerFechaNacimiento.Name = "DateTimePickerFechaNacimiento"
        Me.DateTimePickerFechaNacimiento.Size = New System.Drawing.Size(161, 22)
        Me.DateTimePickerFechaNacimiento.TabIndex = 15
        '
        'LabelNuevoTipo
        '
        Me.LabelNuevoTipo.AutoSize = True
        Me.LabelNuevoTipo.Location = New System.Drawing.Point(634, 121)
        Me.LabelNuevoTipo.Name = "LabelNuevoTipo"
        Me.LabelNuevoTipo.Size = New System.Drawing.Size(77, 17)
        Me.LabelNuevoTipo.TabIndex = 16
        Me.LabelNuevoTipo.Text = "NuevoTipo"
        '
        'ComboBoxTipo
        '
        Me.ComboBoxTipo.FormattingEnabled = True
        Me.ComboBoxTipo.Location = New System.Drawing.Point(374, 137)
        Me.ComboBoxTipo.Name = "ComboBoxTipo"
        Me.ComboBoxTipo.Size = New System.Drawing.Size(156, 24)
        Me.ComboBoxTipo.TabIndex = 17
        '
        'ButtonAñadirNuevoTipo
        '
        Me.ButtonAñadirNuevoTipo.Location = New System.Drawing.Point(537, 138)
        Me.ButtonAñadirNuevoTipo.Name = "ButtonAñadirNuevoTipo"
        Me.ButtonAñadirNuevoTipo.Size = New System.Drawing.Size(75, 23)
        Me.ButtonAñadirNuevoTipo.TabIndex = 18
        Me.ButtonAñadirNuevoTipo.Text = "Añadir"
        Me.ButtonAñadirNuevoTipo.UseVisualStyleBackColor = True
        '
        'TextBoxNuevoTipo
        '
        Me.TextBoxNuevoTipo.Location = New System.Drawing.Point(637, 141)
        Me.TextBoxNuevoTipo.Name = "TextBoxNuevoTipo"
        Me.TextBoxNuevoTipo.Size = New System.Drawing.Size(203, 22)
        Me.TextBoxNuevoTipo.TabIndex = 19
        '
        'ButtonAñadirTipo
        '
        Me.ButtonAñadirTipo.Location = New System.Drawing.Point(847, 139)
        Me.ButtonAñadirTipo.Name = "ButtonAñadirTipo"
        Me.ButtonAñadirTipo.Size = New System.Drawing.Size(75, 23)
        Me.ButtonAñadirTipo.TabIndex = 20
        Me.ButtonAñadirTipo.Text = "Añadir"
        Me.ButtonAñadirTipo.UseVisualStyleBackColor = True
        '
        'NuevoUsuario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(933, 450)
        Me.Controls.Add(Me.TableLayoutPanel3)
        Me.Controls.Add(Me.TableLayoutPanel2)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Name = "NuevoUsuario"
        Me.Text = "FabLab - Nuevo usuario"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.Panel12.ResumeLayout(False)
        Me.TableLayoutPanel3.ResumeLayout(False)
        Me.Panel11.ResumeLayout(False)
        Me.Panel11.PerformLayout()
        Me.Panel10.ResumeLayout(False)
        Me.Panel10.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel3 As TableLayoutPanel
    Friend WithEvents Panel11 As Panel
    Friend WithEvents RichTextBoxObservaciones As RichTextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Panel10 As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Button2 As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Panel12 As Panel
    Friend WithEvents ButtonCancelar As Button
    Friend WithEvents ButtonAceptar As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents DateTimePickerFechaNacimiento As DateTimePicker
    Friend WithEvents MaskedTextBoxDireccion As MaskedTextBox
    Friend WithEvents MaskedTextBoxEmail As MaskedTextBox
    Friend WithEvents MaskedTextBoxApellidos As MaskedTextBox
    Friend WithEvents MaskedTextBoxOrganizacion As MaskedTextBox
    Friend WithEvents MaskedTextBoxTelefono As MaskedTextBox
    Friend WithEvents MaskedTextBoxNombre As MaskedTextBox
    Friend WithEvents LabelDireccion As Label
    Friend WithEvents LabelFechaNacimiento As Label
    Friend WithEvents LabelTipo As Label
    Friend WithEvents LabelEmail As Label
    Friend WithEvents LabelApellidos As Label
    Friend WithEvents LabelOrganizacion As Label
    Friend WithEvents LabelTelefono As Label
    Friend WithEvents LabelNombre As Label
    Friend WithEvents ButtonAñadirNuevoTipo As Button
    Friend WithEvents ComboBoxTipo As ComboBox
    Friend WithEvents LabelNuevoTipo As Label
    Friend WithEvents TextBoxNuevoTipo As MaskedTextBox
    Friend WithEvents ButtonAñadirTipo As Button
End Class
