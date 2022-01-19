Public Class FrmAdminActividad
    Dim ConexionBD As New EnlaceBD
    Private Sub FrmAdminActividad_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ConexionBD.LlenarCmbTipoActividades(cboActADDTipo)
        ConexionBD.CargarDatActividad("SELECT * from Proyecto Inner Join Actividad ON Proyecto.Proyecto_Id = Actividad.AProyecto_Id WHERE AAutorizada = '0' AND Proyecto.PEncargado = '" & GetValUsernameID() & "'", lblregistros, txtActAddIDAct, txtActAddDescp, dtpActAddFInicio,
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
        If (ConexionBD.ModActividad(txtActAddIDAct.Text, txtActAddDescp.Text, dtpActAddFInicio.Value, dtpActAddFEFinal.Value,
                                txtActAddHoras.Text, "1", GetValUsernameID(), cboActADDTipo.SelectedItem.ToString(), txtActAddID.Text)) Then
        Else
            MessageBox.Show("Ha ocurrido un error")
        End If
    End Sub
End Class