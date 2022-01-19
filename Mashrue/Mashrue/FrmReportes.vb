Public Class FrmReportes
    Dim ConexionBD As New EnlaceBD
    Private Sub FrmReportes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ConexionBD.LlenarCmbProyecto(ComboBox1)
        ConexionBD.LlenarCmbProyecto(ComboBox3)
        ConexionBD.LlenarCmbUsuario(ComboBox2)
    End Sub

    Private Sub btnConsOne_Click(sender As Object, e As EventArgs) Handles btnConsOne.Click
        If (ConexionBD.Consulta_Uno(DataGridView1, ComboBox1.SelectedItem.ToString())) Then
        Else
            MsgBox("No se encuentran Datos de la Consulta", MessageBoxButtons.OK + MessageBoxIcon.Information, "Consulta")
        End If
    End Sub

    Private Sub btnConsultaTwo_Click(sender As Object, e As EventArgs) Handles btnConsultaTwo.Click
        If (ConexionBD.Consulta_Dos(DataGridView1, ComboBox2.SelectedItem.ToString(), ComboBox3.SelectedItem.ToString())) Then
            Dim UltimaFila As Integer = Me.DataGridView1.Rows.Count
            If (UltimaFila <> 0) Then
                Me.DataGridView1.CurrentCell = DataGridView1.Rows(0).Cells(2)
                Dim Total As Integer = 0
                'Acumular el total
                'Dim UltimaFila As Integer = Me.DataGridView1.Rows.Count
                'Solo calculamos si modificamos la columna
                For Each row As DataGridViewRow In Me.DataGridView1.Rows
                    If row.Index < UltimaFila Then Total += row.Cells(2).Value

                Next
                'Me.DataGridView1.Rows(UltimaFila - 1).Cells(2).Value = Total.ToString
                Me.Label1.Text = "El total de horas de las actividades es de " & Total & "Horas"
            Else
                Me.Label1.Text = "No se encuentra con actividades este usuario en este proyecto"
            End If

        Else
                MsgBox("No se encuentran Datos de la Consulta", MessageBoxButtons.OK + MessageBoxIcon.Information, "Consulta")
        End If
    End Sub

    Private Sub btnConsThree_Click(sender As Object, e As EventArgs) Handles btnConsThree.Click
        If (ConexionBD.Consulta_Tres(DataGridView1, dtpReportesIni.Value, dtpReportesFin.Value)) Then
        Else
            MsgBox("No se encuentran Datos de la Consulta", MessageBoxButtons.OK + MessageBoxIcon.Information, "Consulta")
        End If
    End Sub

    Private Sub btnConRetrasados_Click(sender As Object, e As EventArgs) Handles btnConRetrasados.Click
        If (ConexionBD.Consulta_Cuatro(DataGridView1)) Then
            Label1.Text = "Si se encuentran en negativos se debe a que van al corriente y sobran días"
        Else
            MsgBox("No se encuentran Datos de la Consulta", MessageBoxButtons.OK + MessageBoxIcon.Information, "Consulta")
        End If
    End Sub
End Class