﻿Imports System.IO
Imports Microsoft.ProjectOxford.Vision
Public Class FormularioMaquina

    Private editando As Boolean
    Private idEditando As Integer
    Public Sub Editar(id As Integer)
        Text = "FabLab - Editar Máquina"
        editando = True
        CargarMaquina(id)
        idEditando = id
        Me.Show()
    End Sub

    Public Sub Consultar(id As Integer)
        Text = "FabLab - Consultar Máquina"
        ButtonCancelar.Select()
        editando = False
        DesactivarCampos()
        CargarMaquina(id)
        ButtonCancelar.Select()
        Me.Show()
    End Sub

    Public Sub Nuevo()
        editando = False
        Text = "FabLab - Nueva Máquina"
        TextBoxModelo.Select()
        Me.Show()
    End Sub

    Private Sub FormularioMaquina_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        If MessageBox.Show("¿Esta seguro que desea cerrar la ventana?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) = 7 Then
            e.Cancel = True
        End If
    End Sub

    Private Sub FormularioMaquina_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ActualizarComboBox()
    End Sub
    Private Sub ActualizarComboBox()
        ComboBox1.Items.Clear()
        For Each table As DataRow In ObtenerTiposMaquina().Rows
            ComboBox1.Items.Add(table.Item(1))
        Next
    End Sub
    Private Sub ButtonAceptar_Click(sender As Object, e As EventArgs) Handles ButtonAceptar.Click
        If editando Then
            Try
                Maquinas.ActualizarMaquina(idEditando, TextBoxModelo.Text, CDbl(TextBoxPrecio_hora.Text), DateTimePicker1.Value, TextBoxTelefono_sat.Text, Maquinas.ObtenerIdTipoMaquinaPorTipo(ComboBox1.Text), TextBoxDescripcion.Text, TextBoxCaracteristicas.Text)
                MessageBox.Show("Éxito", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Catch ex As Exception
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        Else
            Try
                Maquinas.InsertarMaquina(TextBoxModelo.Text, Convert.ToDouble(TextBoxPrecio_hora.Text), DateTimePicker1.Value, TextBoxTelefono_sat.Text, Maquinas.ObtenerIdTipoMaquinaPorTipo(ComboBox1.Text), TextBoxDescripcion.Text, TextBoxCaracteristicas.Text)
                'DirectCast(Me.MdiParent, Principal).gestionMaquinas.ActualizarGrid()
                MessageBox.Show("Éxito", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Catch ex As Exception
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If

        For Each formulario As Form In Me.MdiParent.MdiChildren
            If TypeOf formulario Is GestionMaquinas Then
                DirectCast(formulario, GestionMaquinas).ActualizarGrid()
            End If
        Next
    End Sub

    Private Sub ButtonCancelar_Click(sender As Object, e As EventArgs) Handles ButtonCancelar.Click
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            Maquinas.InsertarTipo(ComboBox1.Text)
            MessageBox.Show("Éxito", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
            ComboBox1.Text = ""
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        ActualizarComboBox()
    End Sub

    Private Sub DesactivarCampos()
        TextBoxCaracteristicas.ReadOnly = True
        TextBoxDescripcion.ReadOnly = True
        TextBoxModelo.ReadOnly = True
        TextBoxPrecio_hora.ReadOnly = True
        TextBoxTelefono_sat.ReadOnly = True
        DateTimePicker1.Enabled = False
        ComboBox1.Enabled = False
        Button1.Enabled = False
        ButtonAceptar.Visible = False
        ButtonExaminar.Visible = False
    End Sub

    Public Sub ResetearCampos()
        TextBoxCaracteristicas.Text = ""
        TextBoxDescripcion.Text = ""
        TextBoxModelo.Text = ""
        TextBoxPrecio_hora.Text = ""
        TextBoxTelefono_sat.Text = ""
        ComboBox1.Text = ""
        DateTimePicker1.ResetText()
    End Sub

    Private Sub CargarMaquina(id As Integer)
        Dim table As DataTable = Maquinas.ObtenerMaquinasPorId(id)
        TextBoxModelo.Text = table.Rows(0).Item(1).ToString
        TextBoxPrecio_hora.Text = table.Rows(0).Item(2).ToString
        DateTimePicker1.Text = table.Rows(0).Item(3).ToString
        ComboBox1.Text = Maquinas.ObtenerTipoMaquinaPorId(CInt(table.Rows(0).Item(5)))
        TextBoxTelefono_sat.Text = table.Rows(0).Item(4).ToString
        TextBoxDescripcion.Text = table.Rows(0).Item(6).ToString
        TextBoxCaracteristicas.Text = table.Rows(0).Item(7).ToString
    End Sub

    Private Sub ObtenerThumbNail(ruta As String)

        Dim subscriptionKey As String = My.Settings.claveAPI
        Dim visionClient As IVisionServiceClient
        Dim originalPicture As String = ruta
        Dim width As Integer = 200
        Dim height As Integer = 100
        Dim smartCropping As Boolean = True
        Dim thumbnailResult As Byte() = Nothing


        visionClient = New VisionServiceClient(subscriptionKey, My.Settings.URL)

        thumbnailResult = visionClient.GetThumbnailAsync(originalPicture, width, height, smartCropping).Result


        Using binaryWrite = New BinaryWriter(New FileStream(ObtenerNombrePath(CType(Maquinas.ObtenerProximoId, String), ruta.Split(CType(".", Char())).Last()), FileMode.Create, FileAccess.Write))
            binaryWrite.Write(thumbnailResult)
        End Using
    End Sub
    Private Function ObtenerRutaImagen() As String

        Dim openFileDialog1 As New OpenFileDialog()
        openFileDialog1.Filter = "Image Files(*.BMP;*.JPG;*.GIF)|*.BMP;*.JPG;*.GIF|All files (*.*)|*.*"
        openFileDialog1.Title = "Selecciona una imágen"
        If openFileDialog1.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
            ' Assign the cursor in the Stream to the Form's Cursor property.
            Return openFileDialog1.FileName
        End If
        Return ""
    End Function
    Private Function ObtenerNombrePath(id As String, extension As String) As String
        Dim nombre As String = ""
        Dim path As String = My.Settings.carpetaImagenesMaquinas
        Dim existeCarpeta As Boolean = False

        For Each nombres As String In Directory.GetDirectories(path)
            If nombres.ToString = id Then
                existeCarpeta = True
            End If
            Exit For
        Next
        If existeCarpeta Then
            Return (path) & "\" & id & "\" & ((Directory.GetFiles(path & "\" & id).Count) + 1) & "." & extension
        Else
            Directory.CreateDirectory(path & "\" & id)
            Return ObtenerNombrePath(id, extension)
        End If
        Return nombre
    End Function
End Class