Public Class FrmLogin
    Dim ConexionBD As New EnlaceBD
    ' TODO: Insert code to perform custom authentication using the provided username and password 
    ' (See http://go.microsoft.com/fwlink/?LinkId=35339).  
    ' The custom principal can then be attached to the current thread's principal as follows: 
    '     My.User.CurrentPrincipal = CustomPrincipal
    ' where CustomPrincipal is the IPrincipal implementation used to perform authentication. 
    ' Subsequently, My.User will return identity information encapsulated in the CustomPrincipal object
    ' such as the username, display name, etc.

    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK.Click
        'Me.Close()
        'My.Forms.FrmInicio.Visible = True
        If (ConexionBD.VerificarCuenta(UsernameTextBox.Text, PasswordTextBox.Text)) Then
            My.Forms.FrmInicio.Dispose()
            My.Forms.FrmInicio.ShowDialog()
        Else
            MsgBox("Verifique que su Username/Password esten correctos", MessageBoxButtons.OK + MessageBoxIcon.Information, "ERROR")
        End If

    End Sub

    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel.Click
        Me.Close()
    End Sub

End Class
