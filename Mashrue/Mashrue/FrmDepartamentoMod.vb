Public Class FrmDepartamentoMod
    Dim ConexionBD As New EnlaceBD
    Private Sub FrmDepartamentoMod_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If (ConexionBD.CargarDatDep(lblDepModTotalReg, txtDepModID, txtDepModNom, txtDepModDescp, txtDepModExt, txtDepModUb)) Then
        End If
    End Sub

    Private Sub btnDepModNext_Click(sender As Object, e As EventArgs) Handles btnDepModNext.Click
        ConexionBD.DepatamentoSiguiente(lblDepModTotalReg, txtDepModID, txtDepModNom, txtDepModDescp, txtDepModExt, txtDepModUb)
    End Sub

    Private Sub btnDepModPrev_Click(sender As Object, e As EventArgs) Handles btnDepModPrev.Click
        ConexionBD.DepatamentoAnterior(lblDepModTotalReg, txtDepModID, txtDepModNom, txtDepModDescp, txtDepModExt, txtDepModUb)
    End Sub

    Private Sub btnDepModOK_Click(sender As Object, e As EventArgs) Handles btnDepModOK.Click
        If (ConexionBD.ModDep(txtDepModID.Text, txtDepModNom.Text, txtDepModDescp.Text, txtDepModExt.Text, txtDepModUb.Text)) Then
            MsgBox("Registro Modificado Exitosamente", MessageBoxButtons.OK + MessageBoxIcon.Information, "Departamento modificado correctamente")
            ConexionBD.CargarDatDep(lblDepModTotalReg, txtDepModID, txtDepModNom, txtDepModDescp, txtDepModExt, txtDepModUb)
        End If
    End Sub

    Private Sub btnDepModDelete_Click(sender As Object, e As EventArgs) Handles btnDepModDelete.Click
        If (ConexionBD.DeleteDep(txtDepModID.Text, txtDepModNom.Text, txtDepModDescp.Text, txtDepModExt.Text, txtDepModUb.Text)) Then
            MsgBox("Registro Eliminado Exitosamente", MessageBoxButtons.OK + MessageBoxIcon.Information, "Departamento Eliminado correctamente")
            ConexionBD.CargarDatDep(lblDepModTotalReg, txtDepModID, txtDepModNom, txtDepModDescp, txtDepModExt, txtDepModUb)
        Else
            MsgBox("El Departamento se encuentra en uso Actualmente, desaloje primero", MessageBoxButtons.OK + MessageBoxIcon.Error, "IMPORTANTE")
        End If

    End Sub
End Class