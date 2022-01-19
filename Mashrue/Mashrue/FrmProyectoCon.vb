Public Class FrmProyectoCon
    Dim ConexionBD As New EnlaceBD
    Private Sub FrmProyectoCon_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ConexionBD.ConsProyecto(DataGridView1)
    End Sub
End Class