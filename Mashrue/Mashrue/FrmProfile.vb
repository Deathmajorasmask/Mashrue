Public Class FrmProfile
    Dim ConexionBD As New EnlaceBD
    Private Sub FrmProfile_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ConexionBD.LlenarCmbDepartamento(cboUsuModDep)
        ConexionBD.MyProfile(txtUsuModID, txtUsuModNom, txtUsuModCon, txtUsuModTel, txtUsuModEmail, cboUsuModRol, cboUsuModDep, PictureBox1)
    End Sub
End Class