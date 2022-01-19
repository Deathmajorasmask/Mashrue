Public Class FrmUsuario
    Dim ConexionBD As New EnlaceBD
    Private Sub btnUsuImg_Click(sender As Object, e As EventArgs) Handles btnUsuImg.Click
        Try
            Dim openFileDialog1 As New OpenFileDialog()
            Dim dialogo As New DialogResult
            openFileDialog1.Filter = "Imagen (JPG,BMP,PNG)|*.JPG;*.BMP;*.PNG|All files (*.*)|*.*"
            openFileDialog1.FilterIndex = 1
            openFileDialog1.RestoreDirectory = True
            dialogo = openFileDialog1.ShowDialog()
            If (dialogo = DialogResult.OK) Then
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

    Private Sub FrmUsuario_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ConexionBD.LlenarCmbDepartamento(cboUsuAgrDep)
    End Sub

    Private Sub btnUsuAdd_Click(sender As Object, e As EventArgs) Handles btnUsuAdd.Click
        Dim AuxString As String = ConexionBD.ObtenerCmbValorId(cboUsuAgrDep, "Departamento", "Departamento_Id")
        If (ConexionBD.RegUsuario(txtUsuAddID.Text, txtUsuAddNom.Text, txtUsuAddCon.Text, txtUsuAddEmail.Text, txtUsuAddTel.Text, cboUsuAgrRol.SelectedIndex, AuxString, PictureBox1)) Then
            MsgBox("Registro Agregado Exitosamente", MessageBoxButtons.OK + MessageBoxIcon.Information, "Usuario Agregado")
        End If
    End Sub
End Class