Public Class FrmActividad
    Dim ConexionBD As New EnlaceBD
    Private Sub FrmActividad_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ConexionBD.ConsProyectoINActividad(dtgActAddProyectos)
        ConexionBD.LlenarCmbTipoActividades(cboActADDTipo)
    End Sub

    Private Sub btnActAddOK_Click(sender As Object, e As EventArgs) Handles btnActAddOK.Click
        If (ConexionBD.RegActividad(txtActAddIDAct.Text, txtActAddDescp.Text, dtpActAddFInicio.Value, dtpActAddFEFinal.Value,
                                txtActAddHoras.Text, "0", GetValUsernameID(), cboActADDTipo.SelectedItem.ToString(), txtActAddID.Text)) Then
            MsgBox("Registro Agregado Exitosamente", MessageBoxButtons.OK + MessageBoxIcon.Information, "Actividad Agregada Exitosamente")
        Else
            MessageBox.Show("Ha ocurrido un error, verifique id's")
        End If
    End Sub
End Class