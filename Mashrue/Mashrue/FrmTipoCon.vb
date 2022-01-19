Public Class FrmTipoCon
    Private Sub FrmTipoCon_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim ConexionBD As New EnlaceBD
        If (ConexionBD.ConsTActividad(dgvConsTAct)) Then

        End If
    End Sub
End Class