Public Class FrmUsuarioCon
    Dim ConexionBD As New EnlaceBD
    Private Sub FrmUsuarioCon_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ConexionBD.ConsUsuario(dgvConsUsu)
    End Sub
End Class