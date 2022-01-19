Public Class FrmTipoMod
    Dim ConexionBD As New EnlaceBD
    Private Sub FrmTipoMod_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If (ConexionBD.CargarDatTActividad(lblTActModTotalReg, txtTActModID, txtTActModNom, txtTActModDescp, txtTActModHour)) Then
        End If
    End Sub

    Private Sub btnCompDelete_Click(sender As Object, e As EventArgs) Handles btnCompDelete.Click
        If (ConexionBD.ModTActividad(txtTActModID.Text, txtTActModNom.Text, txtTActModDescp.Text, txtTActModHour.Text)) Then
            ConexionBD.CargarDatTActividad(lblTActModTotalReg, txtTActModID, txtTActModNom, txtTActModDescp, txtTActModHour)
            MsgBox("Registro Modificado Exitosamente", MessageBoxButtons.OK + MessageBoxIcon.Information, "Departamento modificado correctamente")
        End If
    End Sub

    Private Sub btnTActModNext_Click(sender As Object, e As EventArgs) Handles btnTActModNext.Click
        ConexionBD.TActividadSiguiente(lblTActModTotalReg, txtTActModID, txtTActModNom, txtTActModDescp, txtTActModHour)
    End Sub

    Private Sub btnTActModPrev_Click(sender As Object, e As EventArgs) Handles btnTActModPrev.Click
        ConexionBD.TActividadAnterior(lblTActModTotalReg, txtTActModID, txtTActModNom, txtTActModDescp, txtTActModHour)
    End Sub

    Private Sub btnTActModDelete_Click(sender As Object, e As EventArgs) Handles btnTActModDelete.Click
        If (ConexionBD.DelTActividad(txtTActModID.Text, txtTActModNom.Text, txtTActModDescp.Text, txtTActModHour.Text)) Then
            ConexionBD.CargarDatTActividad(lblTActModTotalReg, txtTActModID, txtTActModNom, txtTActModDescp, txtTActModHour)
            MsgBox("Registro Eliminado Exitosamente", MessageBoxButtons.OK + MessageBoxIcon.Information, "Tipo de Actividad Eliminado correctamente")
        Else
            MsgBox("El Tipo de Actividad se encuentra en uso", MessageBoxButtons.OK + MessageBoxIcon.Error, "ERROR")
        End If
    End Sub
End Class