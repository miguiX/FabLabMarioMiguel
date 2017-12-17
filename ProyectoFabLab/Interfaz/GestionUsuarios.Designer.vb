<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class GestionUsuarios
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
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.LabelBuscar = New System.Windows.Forms.Label()
        Me.TextBoxBuscar = New System.Windows.Forms.TextBox()
        Me.ButtonNuevoUsuario = New System.Windows.Forms.Button()
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.ButtonEliminar = New System.Windows.Forms.Button()
        Me.ButtonEditar = New System.Windows.Forms.Button()
        Me.ButtonConsultar = New System.Windows.Forms.Button()
        Me.DataUsuarios = New System.Windows.Forms.DataGridView()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.FlowLayoutPanel1.SuspendLayout()
        CType(Me.DataUsuarios, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 3
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.52632!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 36.84211!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 52.63158!))
        Me.TableLayoutPanel1.Controls.Add(Me.LabelBuscar, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.TextBoxBuscar, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.ButtonNuevoUsuario, 2, 0)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.TableLayoutPanel1.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.FixedSize
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(957, 53)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'LabelBuscar
        '
        Me.LabelBuscar.AutoSize = True
        Me.LabelBuscar.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LabelBuscar.Location = New System.Drawing.Point(3, 0)
        Me.LabelBuscar.Name = "LabelBuscar"
        Me.LabelBuscar.Size = New System.Drawing.Size(94, 53)
        Me.LabelBuscar.TabIndex = 0
        Me.LabelBuscar.Text = "Buscar"
        Me.LabelBuscar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TextBoxBuscar
        '
        Me.TextBoxBuscar.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TextBoxBuscar.Location = New System.Drawing.Point(103, 15)
        Me.TextBoxBuscar.Margin = New System.Windows.Forms.Padding(3, 15, 3, 3)
        Me.TextBoxBuscar.Name = "TextBoxBuscar"
        Me.TextBoxBuscar.Size = New System.Drawing.Size(346, 22)
        Me.TextBoxBuscar.TabIndex = 1
        '
        'ButtonNuevoUsuario
        '
        Me.ButtonNuevoUsuario.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ButtonNuevoUsuario.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ButtonNuevoUsuario.Location = New System.Drawing.Point(805, 3)
        Me.ButtonNuevoUsuario.Name = "ButtonNuevoUsuario"
        Me.ButtonNuevoUsuario.Size = New System.Drawing.Size(149, 47)
        Me.ButtonNuevoUsuario.TabIndex = 2
        Me.ButtonNuevoUsuario.Text = "Nuevo Usuario"
        Me.ButtonNuevoUsuario.UseVisualStyleBackColor = True
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.Controls.Add(Me.ButtonEliminar)
        Me.FlowLayoutPanel1.Controls.Add(Me.ButtonEditar)
        Me.FlowLayoutPanel1.Controls.Add(Me.ButtonConsultar)
        Me.FlowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.FlowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(0, 392)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(957, 57)
        Me.FlowLayoutPanel1.TabIndex = 1
        '
        'ButtonEliminar
        '
        Me.ButtonEliminar.AutoSize = True
        Me.ButtonEliminar.Dock = System.Windows.Forms.DockStyle.Right
        Me.ButtonEliminar.Location = New System.Drawing.Point(865, 3)
        Me.ButtonEliminar.Margin = New System.Windows.Forms.Padding(20, 3, 3, 3)
        Me.ButtonEliminar.Name = "ButtonEliminar"
        Me.ButtonEliminar.Size = New System.Drawing.Size(89, 27)
        Me.ButtonEliminar.TabIndex = 0
        Me.ButtonEliminar.Text = "Eliminar"
        Me.ButtonEliminar.UseVisualStyleBackColor = True
        '
        'ButtonEditar
        '
        Me.ButtonEditar.Dock = System.Windows.Forms.DockStyle.Right
        Me.ButtonEditar.Location = New System.Drawing.Point(727, 3)
        Me.ButtonEditar.Margin = New System.Windows.Forms.Padding(20, 3, 3, 3)
        Me.ButtonEditar.Name = "ButtonEditar"
        Me.ButtonEditar.Size = New System.Drawing.Size(115, 27)
        Me.ButtonEditar.TabIndex = 1
        Me.ButtonEditar.Text = "Editar"
        Me.ButtonEditar.UseVisualStyleBackColor = True
        '
        'ButtonConsultar
        '
        Me.ButtonConsultar.Dock = System.Windows.Forms.DockStyle.Right
        Me.ButtonConsultar.Location = New System.Drawing.Point(576, 3)
        Me.ButtonConsultar.Margin = New System.Windows.Forms.Padding(20, 3, 3, 3)
        Me.ButtonConsultar.Name = "ButtonConsultar"
        Me.ButtonConsultar.Size = New System.Drawing.Size(128, 27)
        Me.ButtonConsultar.TabIndex = 2
        Me.ButtonConsultar.Text = "Consultar"
        Me.ButtonConsultar.UseVisualStyleBackColor = True
        '
        'DataUsuarios
        '
        Me.DataUsuarios.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataUsuarios.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.DataUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataUsuarios.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataUsuarios.Location = New System.Drawing.Point(0, 53)
        Me.DataUsuarios.Name = "DataUsuarios"
        Me.DataUsuarios.ReadOnly = True
        Me.DataUsuarios.RowTemplate.Height = 24
        Me.DataUsuarios.Size = New System.Drawing.Size(957, 339)
        Me.DataUsuarios.TabIndex = 2
        '
        'GestionUsuarios
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(957, 449)
        Me.Controls.Add(Me.DataUsuarios)
        Me.Controls.Add(Me.FlowLayoutPanel1)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Name = "GestionUsuarios"
        Me.Text = "FabLab - Gestion usuarios"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.FlowLayoutPanel1.ResumeLayout(False)
        Me.FlowLayoutPanel1.PerformLayout()
        CType(Me.DataUsuarios, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents FlowLayoutPanel1 As FlowLayoutPanel
    Friend WithEvents DataUsuarios As DataGridView
    Friend WithEvents LabelBuscar As Label
    Friend WithEvents TextBoxBuscar As TextBox
    Friend WithEvents ButtonNuevoUsuario As Button
    Friend WithEvents ButtonEliminar As Button
    Friend WithEvents ButtonEditar As Button
    Friend WithEvents ButtonConsultar As Button
End Class
