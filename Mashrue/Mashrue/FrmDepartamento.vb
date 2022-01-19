Public Class FrmDepartamento
    Private Sub btnDeptAdd_Click(sender As Object, e As EventArgs) Handles btnDeptAdd.Click
        Dim AgregarForm As New EnlaceBD
        If (AgregarForm.RegDep(txtDepAddID.Text, txtDepAddNom.Text, txtDepAddDescp.Text, txtDepAddExt.Text, txtDepAddUb.Text) = True) Then
            MsgBox("Registro Agregado Exitosamente", MessageBoxButtons.OK + MessageBoxIcon.Information, "Agente Agregado")
        End If
    End Sub
End Class