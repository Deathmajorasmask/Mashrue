Public Class FrmInicio
    Dim ConexionBD As New EnlaceBD
    Private Sub btnIndexAdmin_Click(sender As Object, e As EventArgs) Handles btnIndexAdmin.Click
        'Me.Close()
        'My.Forms.FrmAdmin.Visible = True
        My.Forms.FrmAdmin.Dispose()
        My.Forms.FrmAdmin.ShowDialog()
    End Sub

    Private Sub btnIndexProNew_Click(sender As Object, e As EventArgs) Handles btnIndexProNew.Click
        My.Forms.FrmProyecto.Dispose()
        My.Forms.FrmProyecto.ShowDialog()
    End Sub

    Private Sub btnIndexProMod_Click(sender As Object, e As EventArgs) Handles btnIndexProMod.Click
        If (ConexionBD.VerificarDatosDB("SELECT * FROM Proyecto Where PEncargado = '" & GetValUsernameID() & "'", "Proyecto")) Then
            My.Forms.FrmProyectoMod.Dispose()
            My.Forms.FrmProyectoMod.ShowDialog()
        Else
            MessageBox.Show("No se han encontrado registros previamente")
        End If
    End Sub

    Private Sub btnIndexProHis_Click(sender As Object, e As EventArgs) Handles btnIndexProHis.Click
        My.Forms.FrmProyectoCon.Dispose()
        My.Forms.FrmProyectoCon.ShowDialog()
    End Sub

    Private Sub btnIndexActNew_Click(sender As Object, e As EventArgs) Handles btnIndexActNew.Click
        My.Forms.FrmActividad.Dispose()
        My.Forms.FrmActividad.ShowDialog()
    End Sub

    Private Sub FrmInicio_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If (GetValRol() <> 0) Then
            btnIndexAdmin.Enabled = False
        Else
            btnIndexAdmin.Enabled = True
        End If

        If (ConexionBD.ConsIndex(DataGridView1)) Then

        End If
    End Sub

    Private Sub btnIndexAdminActProy_Click(sender As Object, e As EventArgs) Handles btnIndexAdminActProy.Click
        If (ConexionBD.VerificarDatosDB("SELECT * from Proyecto Inner Join Actividad ON Proyecto.Proyecto_Id = Actividad.AProyecto_Id WHERE AAutorizada = '0' AND Proyecto.PEncargado = '" & GetValUsernameID() & "'", "Actividad")) Then
            My.Forms.FrmAdminActividad.Dispose()
            My.Forms.FrmAdminActividad.ShowDialog()
        Else
            MessageBox.Show("No se han encontrado registros previamente")
        End If
    End Sub

    Private Sub btnReportIndex_Click(sender As Object, e As EventArgs) Handles btnReportIndex.Click
        My.Forms.FrmReportes.Dispose()
        My.Forms.FrmReportes.ShowDialog()
    End Sub

    Private Sub btnMyProfile_Click(sender As Object, e As EventArgs) Handles btnMyProfile.Click
        My.Forms.FrmProfile.Dispose()
        My.Forms.FrmProfile.ShowDialog()
    End Sub

    Private Sub btnIndexAdminAct_Click(sender As Object, e As EventArgs) Handles btnIndexAdminAct.Click
        If (ConexionBD.VerificarDatosDB("SELECT * FROM Actividad WHERE AUsuario_Id = '" & GetValUsernameID() & "'", "Actividad")) Then
            My.Forms.FrmActividadMod.Dispose()
            My.Forms.FrmActividadMod.ShowDialog()
        Else
            MessageBox.Show("No se han encontrado registros previamente")
        End If

    End Sub
End Class