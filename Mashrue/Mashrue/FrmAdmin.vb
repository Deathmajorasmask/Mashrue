Public Class FrmAdmin
    Private Sub btnAdminAddDep_Click(sender As Object, e As EventArgs) Handles btnAdminAddDep.Click
        'Me.Close()
        'My.Forms.FrmDepartamento.Visible = True
        My.Forms.FrmDepartamento.ShowDialog()
    End Sub

    Private Sub btnAdminConDep_Click(sender As Object, e As EventArgs) Handles btnAdminConDep.Click
        My.Forms.FrmDepartamentoCon.ShowDialog()
    End Sub

    Private Sub btnAdminModDep_Click(sender As Object, e As EventArgs) Handles btnAdminModDep.Click
        My.Forms.FrmDepartamentoMod.ShowDialog()
    End Sub

    Private Sub btnAdminAddTAct_Click(sender As Object, e As EventArgs) Handles btnAdminAddTAct.Click
        My.Forms.FrmTipo.ShowDialog()
    End Sub

    Private Sub btnAdminConTAct_Click(sender As Object, e As EventArgs) Handles btnAdminConTAct.Click
        My.Forms.FrmTipoCon.ShowDialog()
    End Sub

    Private Sub btnAdminModTAct_Click(sender As Object, e As EventArgs) Handles btnAdminModTAct.Click
        My.Forms.FrmTipoMod.ShowDialog()
    End Sub

    Private Sub btnAdminAddUsu_Click(sender As Object, e As EventArgs) Handles btnAdminAddUsu.Click
        My.Forms.FrmUsuario.ShowDialog()
    End Sub

    Private Sub btnAdminConUsu_Click(sender As Object, e As EventArgs) Handles btnAdminConUsu.Click
        My.Forms.FrmUsuarioCon.ShowDialog()
    End Sub

    Private Sub btnAdminModUsu_Click(sender As Object, e As EventArgs) Handles btnAdminModUsu.Click
        My.Forms.FrmUsuarioMod.ShowDialog()
    End Sub
End Class