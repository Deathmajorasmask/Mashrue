Public Class FrmActividadMod
    Dim ConexionBD As New EnlaceBD
    Private Sub FrmActividadMod_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ConexionBD.LlenarCmbTipoActividades(cboActADDTipo)
        ConexionBD.CargarDatActividad("SELECT * FROM Actividad WHERE AAutorizada = '0' AND AUsuario_Id = '" & GetValUsernameID() & "'", lblregistros, txtActAddIDAct, txtActAddDescp, dtpActAddFInicio,
                                      dtpActAddFEFinal, txtActAddHoras, cboActADDTipo, txtActAddID)
    End Sub
    Private Sub btnActAddNext_Click(sender As Object, e As EventArgs) Handles btnActAddNext.Click
        ConexionBD.ActividadSiguiente(lblregistros, txtActAddIDAct, txtActAddDescp, dtpActAddFInicio,
                                      dtpActAddFEFinal, txtActAddHoras, cboActADDTipo, txtActAddID)
    End Sub

    Private Sub btnActAddPrev_Click(sender As Object, e As EventArgs) Handles btnActAddPrev.Click
        ConexionBD.ActividadAnterior(lblregistros, txtActAddIDAct, txtActAddDescp, dtpActAddFInicio,
                                      dtpActAddFEFinal, txtActAddHoras, cboActADDTipo, txtActAddID)
    End Sub

    Private Sub btnActAddOK_Click(sender As Object, e As EventArgs) Handles btnActAddOK.Click
        ConexionBD.ModActividad(txtActAddIDAct.Text, txtActAddDescp.Text, dtpActAddFInicio.Value, dtpActAddFEFinal.Value,
                                txtActAddHoras.Text, "0", GetValUsernameID(), cboActADDTipo.SelectedItem.ToString(), txtActAddID.Text)
    End Sub

End Class