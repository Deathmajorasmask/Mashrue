Module Session
    Private Username, Email, Password, UsernameID, Tel, Rol, DepartamentoID As String

    Public Function GetValUsername() As String
        Return Username
    End Function

    Public Function GetValUsernameID() As String
        Return UsernameID
    End Function

    Public Function GetValEmail() As String
        Return Email
    End Function

    Public Function GetValPassword() As String
        Return Password
    End Function

    Public Function GetValTel() As String
        Return Tel
    End Function

    Public Function GetValRol() As String
        Return Rol
    End Function

    Public Function GetValDepartamentoID() As String
        Return DepartamentoID
    End Function

    Public Function SetValorSession(ByVal Id As String, ByVal Us As String, ByVal Email As String, ByVal Pass As String,
                                    ByVal Te As String, ByVal Ro As String, ByVal DepartID As String) As Boolean
        Dim Estado = True
        Try
            Username = Us
            UsernameID = Id
            Email = Email
            Password = Pass
            Tel = Te
            Rol = Ro
            DepartamentoID = DepartID

        Catch ex As Exception
            Estado = False
            MessageBox.Show(ex.Message)
        End Try

        Return Estado
    End Function

End Module
