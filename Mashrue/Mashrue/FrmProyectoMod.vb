Public Class FrmProyectoMod
    Dim ConexionBD As New EnlaceBD
    Private Sub FrmProyectoMod_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ConexionBD.LlenarLstProyecto(lstUsuModDisp)
        ConexionBD.LlenarCmbDepartamento(cboProModDep)

        ConexionBD.CargarDatProyecto(lblUsuModTotalReg, txtProModID, txtProModNom, dtpProModFInicio,
                                     dtpProModFEFinal, txtProModPres, txtProModHoras, cboProModDep, txtProModEnc,
                                     lstUsuModDisp, lstUsuModSel, CheckBox1, txtProHorasReales, dtpProModFREALFinal)
        If (CheckBox1.Checked = True) Then
            lblestado.Text = "El proyecto se encuentra ACTIVO"
        Else
            lblestado.Text = "El Proyecto se encuentra INACTIVO"
        End If

    End Sub

    Private Sub btnProModNext_Click(sender As Object, e As EventArgs) Handles btnProModNext.Click
        ConexionBD.ProyectoSiguiente(lblUsuModTotalReg, txtProModID, txtProModNom, dtpProModFInicio,
                                     dtpProModFEFinal, txtProModPres, txtProModHoras, cboProModDep, txtProModEnc,
                                     lstUsuModDisp, lstUsuModSel, CheckBox1, txtProHorasReales, dtpProModFREALFinal)
        If (CheckBox1.Checked = True) Then
            lblestado.Text = "El proyecto se encuentra ACTIVO"
        Else
            lblestado.Text = "El Proyecto se encuentra INACTIVO"
        End If

    End Sub

    Private Sub btnProModPrev_Click(sender As Object, e As EventArgs) Handles btnProModPrev.Click
        ConexionBD.ProyectoAnterior(lblUsuModTotalReg, txtProModID, txtProModNom, dtpProModFInicio,
                                     dtpProModFEFinal, txtProModPres, txtProModHoras, cboProModDep, txtProModEnc,
                                     lstUsuModDisp, lstUsuModSel, CheckBox1, txtProHorasReales, dtpProModFREALFinal)

        If (CheckBox1.Checked = True) Then
            lblestado.Text = "El proyecto se encuentra ACTIVO"
        Else
            lblestado.Text = "El Proyecto se encuentra INACTIVO"
        End If

    End Sub

    Private Sub btnProModOK_Click(sender As Object, e As EventArgs) Handles btnProModOK.Click
        'ConexionBD.DelDepartamento_Proyecto(txtProModID.Text)
        'ConexionBD.DelUsuario_Proyecto(txtProModID.Text)
        Dim Estadito As String
        If (CheckBox1.Checked = True) Then
            Estadito = "1"
        Else
            Estadito = "0"
        End If
        'Se verifica si se lleno el proyecto con reportes

        If (ConexionBD.ModProyecto(txtProModID.Text, txtProModNom.Text, dtpProModFInicio.Value, dtpProModFEFinal.Value,
                               txtProModHoras.Text, txtProModPres.Text, dtpProModFREALFinal.Value, txtProHorasReales.Text,
                               Estadito, txtProModEnc.Text)) Then
                MsgBox("Modificaciones Agregadas Exitosamente", MessageBoxButtons.OK + MessageBoxIcon.Information, "Aviso")
            Else
                MessageBox.Show("A ocurrido un problema")
            End If
            ConexionBD.CargarDatProyecto(lblUsuModTotalReg, txtProModID, txtProModNom, dtpProModFInicio,
                                         dtpProModFEFinal, txtProModPres, txtProModHoras, cboProModDep, txtProModEnc,
                                         lstUsuModDisp, lstUsuModSel, CheckBox1, txtProHorasReales, dtpProModFREALFinal)


    End Sub

    Private Sub btnProModDEL_Click(sender As Object, e As EventArgs) Handles btnProModDEL.Click
        If (ConexionBD.DelProyecto(txtProModID.Text)) Then
            MsgBox("Registro eliminado Exitosamente", MessageBoxButtons.OK + MessageBoxIcon.Information, "Aviso")
        Else
            MessageBox.Show("A ocurrido un problema")
        End If
        ConexionBD.CargarDatProyecto(lblUsuModTotalReg, txtProModID, txtProModNom, dtpProModFInicio,
                                     dtpProModFEFinal, txtProModPres, txtProModHoras, cboProModDep, txtProModEnc,
                                     lstUsuModDisp, lstUsuModSel, CheckBox1, txtProHorasReales, dtpProModFREALFinal)

    End Sub
End Class