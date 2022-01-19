Public Class FrmProyecto
    Dim ConexionBD As New EnlaceBD
    Private Sub FrmProyecto_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtProAddEnc.Text = GetValUsername()
        ConexionBD.LlenarLstProyecto(lstUsuAddDisp)
        ConexionBD.LlenarCmbDepartamento(cboProModDep)
    End Sub

    Private Sub btnUsuAddComp_Click(sender As Object, e As EventArgs) Handles btnUsuAddComp.Click
        ConexionBD.PasarValoresdeLstToLst(lstUsuAddSel, lstUsuAddDisp)
    End Sub

    Private Sub btnUsuDelComp_Click(sender As Object, e As EventArgs) Handles btnUsuDelComp.Click
        ConexionBD.PasarValoresdeLstToLst(lstUsuAddDisp, lstUsuAddSel)
    End Sub

    Private Sub btnProAddOK_Click(sender As Object, e As EventArgs) Handles btnProAddOK.Click

        Dim Conteo As Integer = 0
        Dim value As Object
        Dim countAux = lstUsuAddSel.Items.Count()
        Dim AuxString As String = ConexionBD.ObtenerCmbValorId(cboProModDep, "Departamento", "Departamento_Id")

        'Registro el Proyecto
        If (ConexionBD.RegProyecto(txtProAddID.Text, txtProAddNom.Text, dtpProAddFInicio.Value, dtpProAddFEFinal.Value, txtProAddHoras.Text, txtProAddPres.Text, "1", GetValUsernameID())) Then
            'Registro El proyecto ante el departamento
            If (ConexionBD.RegDepartamento_Proyecto(AuxString, txtProAddID.Text)) Then
                'Registro el proyecto a los Usuarios implicados
                Do While (Conteo < countAux)
                    value = lstUsuAddSel.Items(Conteo)
                    ConexionBD.RegUsuario_Proyecto(value, txtProAddID.Text)
                    Conteo = Conteo + 1
                Loop
            End If
            MsgBox("Registro Agregado Exitosamente", MessageBoxButtons.OK + MessageBoxIcon.Information, "Proyecto Agregado Exitosamente")
        Else
            MsgBox("Ups! Ha ocurrido un error, verificar Id's", MessageBoxButtons.OK + MessageBoxIcon.Information, "Mensaje")
        End If

    End Sub
End Class