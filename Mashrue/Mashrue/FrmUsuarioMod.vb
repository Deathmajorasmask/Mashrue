Public Class FrmUsuarioMod
    Dim ConexionBD As New EnlaceBD
    Dim Bandera As Boolean = False
    Private Sub FrmUsuarioMod_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ConexionBD.LlenarCmbDepartamento(cboUsuModDep)
        If (ConexionBD.CargarDatUsuario(lblUsuModTotalReg, txtUsuModID, txtUsuModNom, txtUsuModCon, txtUsuModTel, txtUsuModEmail, cboUsuModRol, cboUsuModDep, PictureBox1)) Then
            'MsgBox("Registro Agregado Exitosamente", MessageBoxButtons.OK + MessageBoxIcon.Information, "Agregado")
        End If
    End Sub

    Private Sub btnUsuModNext_Click(sender As Object, e As EventArgs) Handles btnUsuModNext.Click
        ConexionBD.UsuarioSiguiente(lblUsuModTotalReg, txtUsuModID, txtUsuModNom, txtUsuModCon, txtUsuModTel, txtUsuModEmail, cboUsuModRol, cboUsuModDep, PictureBox1)
    End Sub

    Private Sub btnUsuModPrev_Click(sender As Object, e As EventArgs) Handles btnUsuModPrev.Click
        ConexionBD.UsuarioAnterior(lblUsuModTotalReg, txtUsuModID, txtUsuModNom, txtUsuModCon, txtUsuModTel, txtUsuModEmail, cboUsuModRol, cboUsuModDep, PictureBox1)
    End Sub

    Private Sub btnUsuModOK_Click(sender As Object, e As EventArgs) Handles btnUsuModOK.Click
        If (ConexionBD.ModUsuario(txtUsuModID.Text, txtUsuModNom.Text, txtUsuModCon.Text, txtUsuModEmail.Text, txtUsuModTel.Text, cboUsuModRol.SelectedIndex, cboUsuModDep.Text, PictureBox1, Bandera)) Then
            MsgBox("Registro Modificado Exitosamente", MessageBoxButtons.OK + MessageBoxIcon.Information, "Usuario modificado correctamente")
            ConexionBD.CargarDatUsuario(lblUsuModTotalReg, txtUsuModID, txtUsuModNom, txtUsuModCon, txtUsuModTel, txtUsuModEmail, cboUsuModRol, cboUsuModDep, PictureBox1)
        End If
        Bandera = False

    End Sub

    Private Sub btnUsuImg_Click(sender As Object, e As EventArgs) Handles btnUsuImg.Click
        Try
            Dim openFileDialog1 As New OpenFileDialog()
            Dim dialogo As New DialogResult
            openFileDialog1.Filter = "Imagen (JPG,BMP,PNG)|*.JPG;*.BMP;*.PNG|All files (*.*)|*.*"
            openFileDialog1.FilterIndex = 1
            openFileDialog1.RestoreDirectory = True
            dialogo = openFileDialog1.ShowDialog()
            If (dialogo = DialogResult.OK) Then
                Bandera = True
                Dim bmp As New Bitmap(Image.FromFile(openFileDialog1.FileName))
                bmp = bmp.GetThumbnailImage(480, 480, Nothing, IntPtr.Zero) 'Redimencionamos pixeles deimagen (Opcional).
                PictureBox1.BackgroundImage = Nothing
                PictureBox1.BackgroundImageLayout = ImageLayout.Stretch 'Ajustamos la imagen a todo el picturebox.
                PictureBox1.BackgroundImage = bmp 'Cargamos la imagen al PictureBox.
                'sExtencion = System.IO.Path.GetExtension(openFileDialog1.FileName) 'Obtenemos la Extencion de la imagen cargada.
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub btnUsuModDel_Click(sender As Object, e As EventArgs) Handles btnUsuModDel.Click
        If (ConexionBD.DeleteUsuario(txtUsuModID.Text, txtUsuModNom.Text)) Then
            MsgBox("Registro eliminado Exitosamente", MessageBoxButtons.OK + MessageBoxIcon.Information, "Usuario eliminado correctamente")
            ConexionBD.CargarDatUsuario(lblUsuModTotalReg, txtUsuModID, txtUsuModNom, txtUsuModCon, txtUsuModTel, txtUsuModEmail, cboUsuModRol, cboUsuModDep, PictureBox1)
        Else
            MsgBox("El Usuario se encuentra en uso Actualmente, desaloje primero", MessageBoxButtons.OK + MessageBoxIcon.Error, "IMPORTANTE")
        End If
        Bandera = False

    End Sub
End Class