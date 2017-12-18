<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Principal
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Principal))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.UsuariosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NuevoUsuarioToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GestionDeUsuariosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MaquinasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NuevaMáquinaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GestiónDeMáquinasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.InformesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VentanaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OrganizarVentanasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HorizontalToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VerticalToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MinimizarTodasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.AyudaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AcercaDeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripButtonGestionUsuarios = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButtonNuevoUsuario = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButtonGestionMaquinas = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButtonNuevaMaquina = New System.Windows.Forms.ToolStripButton()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel2 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.CerrarTodasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.UsuariosToolStripMenuItem, Me.MaquinasToolStripMenuItem, Me.InformesToolStripMenuItem, Me.VentanaToolStripMenuItem, Me.AyudaToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.MdiWindowListItem = Me.VentanaToolStripMenuItem
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(4, 2, 0, 2)
        Me.MenuStrip1.Size = New System.Drawing.Size(775, 24)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'UsuariosToolStripMenuItem
        '
        Me.UsuariosToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NuevoUsuarioToolStripMenuItem, Me.GestionDeUsuariosToolStripMenuItem})
        Me.UsuariosToolStripMenuItem.Name = "UsuariosToolStripMenuItem"
        Me.UsuariosToolStripMenuItem.Size = New System.Drawing.Size(64, 20)
        Me.UsuariosToolStripMenuItem.Text = "Usuarios"
        '
        'NuevoUsuarioToolStripMenuItem
        '
        Me.NuevoUsuarioToolStripMenuItem.Name = "NuevoUsuarioToolStripMenuItem"
        Me.NuevoUsuarioToolStripMenuItem.Size = New System.Drawing.Size(177, 22)
        Me.NuevoUsuarioToolStripMenuItem.Text = "&Nuevo usuario"
        '
        'GestionDeUsuariosToolStripMenuItem
        '
        Me.GestionDeUsuariosToolStripMenuItem.Name = "GestionDeUsuariosToolStripMenuItem"
        Me.GestionDeUsuariosToolStripMenuItem.Size = New System.Drawing.Size(177, 22)
        Me.GestionDeUsuariosToolStripMenuItem.Text = "&Gestion de usuarios"
        '
        'MaquinasToolStripMenuItem
        '
        Me.MaquinasToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NuevaMáquinaToolStripMenuItem, Me.GestiónDeMáquinasToolStripMenuItem})
        Me.MaquinasToolStripMenuItem.Name = "MaquinasToolStripMenuItem"
        Me.MaquinasToolStripMenuItem.Size = New System.Drawing.Size(71, 20)
        Me.MaquinasToolStripMenuItem.Text = "Maquinas"
        '
        'NuevaMáquinaToolStripMenuItem
        '
        Me.NuevaMáquinaToolStripMenuItem.Name = "NuevaMáquinaToolStripMenuItem"
        Me.NuevaMáquinaToolStripMenuItem.Size = New System.Drawing.Size(185, 22)
        Me.NuevaMáquinaToolStripMenuItem.Text = "&Nueva máquina"
        '
        'GestiónDeMáquinasToolStripMenuItem
        '
        Me.GestiónDeMáquinasToolStripMenuItem.Name = "GestiónDeMáquinasToolStripMenuItem"
        Me.GestiónDeMáquinasToolStripMenuItem.Size = New System.Drawing.Size(185, 22)
        Me.GestiónDeMáquinasToolStripMenuItem.Text = "&Gestión de máquinas"
        '
        'InformesToolStripMenuItem
        '
        Me.InformesToolStripMenuItem.Name = "InformesToolStripMenuItem"
        Me.InformesToolStripMenuItem.Size = New System.Drawing.Size(66, 20)
        Me.InformesToolStripMenuItem.Text = "Informes"
        '
        'VentanaToolStripMenuItem
        '
        Me.VentanaToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.OrganizarVentanasToolStripMenuItem, Me.MinimizarTodasToolStripMenuItem, Me.ToolStripSeparator1, Me.CerrarTodasToolStripMenuItem})
        Me.VentanaToolStripMenuItem.Name = "VentanaToolStripMenuItem"
        Me.VentanaToolStripMenuItem.Size = New System.Drawing.Size(62, 20)
        Me.VentanaToolStripMenuItem.Text = "Ventana"
        '
        'OrganizarVentanasToolStripMenuItem
        '
        Me.OrganizarVentanasToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.HorizontalToolStripMenuItem, Me.VerticalToolStripMenuItem})
        Me.OrganizarVentanasToolStripMenuItem.Name = "OrganizarVentanasToolStripMenuItem"
        Me.OrganizarVentanasToolStripMenuItem.Size = New System.Drawing.Size(175, 22)
        Me.OrganizarVentanasToolStripMenuItem.Text = "&Organizar ventanas"
        '
        'HorizontalToolStripMenuItem
        '
        Me.HorizontalToolStripMenuItem.Name = "HorizontalToolStripMenuItem"
        Me.HorizontalToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.HorizontalToolStripMenuItem.Text = "Horizontal"
        '
        'VerticalToolStripMenuItem
        '
        Me.VerticalToolStripMenuItem.Name = "VerticalToolStripMenuItem"
        Me.VerticalToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.VerticalToolStripMenuItem.Text = "Vertical"
        '
        'MinimizarTodasToolStripMenuItem
        '
        Me.MinimizarTodasToolStripMenuItem.Name = "MinimizarTodasToolStripMenuItem"
        Me.MinimizarTodasToolStripMenuItem.Size = New System.Drawing.Size(175, 22)
        Me.MinimizarTodasToolStripMenuItem.Text = "&Minimizar todas"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(172, 6)
        '
        'AyudaToolStripMenuItem
        '
        Me.AyudaToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AcercaDeToolStripMenuItem})
        Me.AyudaToolStripMenuItem.Name = "AyudaToolStripMenuItem"
        Me.AyudaToolStripMenuItem.Size = New System.Drawing.Size(53, 20)
        Me.AyudaToolStripMenuItem.Text = "Ayuda"
        '
        'AcercaDeToolStripMenuItem
        '
        Me.AcercaDeToolStripMenuItem.Name = "AcercaDeToolStripMenuItem"
        Me.AcercaDeToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.AcercaDeToolStripMenuItem.Text = "&Acerca de"
        '
        'ToolStrip1
        '
        Me.ToolStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripButtonGestionUsuarios, Me.ToolStripButtonNuevoUsuario, Me.ToolStripButtonGestionMaquinas, Me.ToolStripButtonNuevaMaquina})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 24)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(775, 27)
        Me.ToolStrip1.TabIndex = 3
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'ToolStripButtonGestionUsuarios
        '
        Me.ToolStripButtonGestionUsuarios.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButtonGestionUsuarios.Image = Global.ProyectoFabLab.My.Resources.Resources.Icons_Land_Vista_People_Groups_Meeting_Dark
        Me.ToolStripButtonGestionUsuarios.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButtonGestionUsuarios.Name = "ToolStripButtonGestionUsuarios"
        Me.ToolStripButtonGestionUsuarios.Size = New System.Drawing.Size(24, 24)
        Me.ToolStripButtonGestionUsuarios.Text = "Gestión Usuarios"
        '
        'ToolStripButtonNuevoUsuario
        '
        Me.ToolStripButtonNuevoUsuario.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButtonNuevoUsuario.Image = Global.ProyectoFabLab.My.Resources.Resources.Oxygen_Icons_org_Oxygen_Actions_list_add_user
        Me.ToolStripButtonNuevoUsuario.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButtonNuevoUsuario.Name = "ToolStripButtonNuevoUsuario"
        Me.ToolStripButtonNuevoUsuario.Size = New System.Drawing.Size(24, 24)
        Me.ToolStripButtonNuevoUsuario.Text = "Nuevo Usuario"
        '
        'ToolStripButtonGestionMaquinas
        '
        Me.ToolStripButtonGestionMaquinas.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButtonGestionMaquinas.Image = Global.ProyectoFabLab.My.Resources.Resources.Icons8_Windows_8_Printing_Cnc_Machine
        Me.ToolStripButtonGestionMaquinas.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButtonGestionMaquinas.Name = "ToolStripButtonGestionMaquinas"
        Me.ToolStripButtonGestionMaquinas.Size = New System.Drawing.Size(24, 24)
        Me.ToolStripButtonGestionMaquinas.Text = "Gestión Máquinas"
        '
        'ToolStripButtonNuevaMaquina
        '
        Me.ToolStripButtonNuevaMaquina.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButtonNuevaMaquina.Image = Global.ProyectoFabLab.My.Resources.Resources.Icons8_Windows_8_Files_Add_List
        Me.ToolStripButtonNuevaMaquina.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButtonNuevaMaquina.Name = "ToolStripButtonNuevaMaquina"
        Me.ToolStripButtonNuevaMaquina.Size = New System.Drawing.Size(24, 24)
        Me.ToolStripButtonNuevaMaquina.Text = "Nueva Máquina"
        '
        'StatusStrip1
        '
        Me.StatusStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel1, Me.ToolStripStatusLabel2})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 348)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Padding = New System.Windows.Forms.Padding(1, 0, 10, 0)
        Me.StatusStrip1.Size = New System.Drawing.Size(775, 22)
        Me.StatusStrip1.TabIndex = 4
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(121, 17)
        Me.ToolStripStatusLabel1.Text = "ToolStripStatusLabel1"
        '
        'ToolStripStatusLabel2
        '
        Me.ToolStripStatusLabel2.Name = "ToolStripStatusLabel2"
        Me.ToolStripStatusLabel2.Size = New System.Drawing.Size(121, 17)
        Me.ToolStripStatusLabel2.Text = "ToolStripStatusLabel2"
        '
        'CerrarTodasToolStripMenuItem
        '
        Me.CerrarTodasToolStripMenuItem.Name = "CerrarTodasToolStripMenuItem"
        Me.CerrarTodasToolStripMenuItem.Size = New System.Drawing.Size(175, 22)
        Me.CerrarTodasToolStripMenuItem.Text = "&Cerrar todas"
        '
        'Principal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(775, 370)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Name = "Principal"
        Me.Text = "FabLab - Ventana Principal"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents UsuariosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents NuevoUsuarioToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GestionDeUsuariosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MaquinasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents NuevaMáquinaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GestiónDeMáquinasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents InformesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents VentanaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents OrganizarVentanasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MinimizarTodasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents AyudaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AcercaDeToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents ToolStripStatusLabel1 As ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel2 As ToolStripStatusLabel
    Friend WithEvents HorizontalToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents VerticalToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripButtonGestionUsuarios As ToolStripButton
    Friend WithEvents ToolStripButtonNuevoUsuario As ToolStripButton
    Friend WithEvents ToolStripButtonGestionMaquinas As ToolStripButton
    Friend WithEvents ToolStripButtonNuevaMaquina As ToolStripButton
    Friend WithEvents CerrarTodasToolStripMenuItem As ToolStripMenuItem
End Class
