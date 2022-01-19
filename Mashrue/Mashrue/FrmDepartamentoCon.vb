Public Class FrmDepartamentoCon

    Private Sub FrmDepartamentoCon_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim ConexionBD As New EnlaceBD
        If (ConexionBD.ConsDep(dgvConsDep)) Then

        End If

    End Sub
End Class