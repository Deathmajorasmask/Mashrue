Public Class FrmTipo
    Private Sub btnTActOK_Click(sender As Object, e As EventArgs) Handles btnTActOK.Click
        Dim AgregarForm As New EnlaceBD
        If (AgregarForm.RegTActividad(txtTActAddID.Text, txtTActAddNom.Text, txtTActAddDescp.Text, txtTActAddHour.Text)) Then
            MsgBox("Registro Agregado Exitosamente", MessageBoxButtons.OK + MessageBoxIcon.Information, "Tipo de Actividad Agregado")
        End If
    End Sub
End Class