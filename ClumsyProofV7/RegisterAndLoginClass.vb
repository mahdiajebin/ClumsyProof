Public Class RegisterAndLoginClass
    Dim con As MyDBConnection = New MyDBConnection()
    Dim Result As DataTable = New DataTable()

    Public Function CheckUserName(ByVal UserName As String) As Boolean
        If con.CheckUserName(UserName) Then
            Return True
        Else
            Return False
        End If
    End Function

    Public Function Login(ByVal UserName As String, ByVal Password As String) As Boolean
        If UserName = "Username" Or Password = "Password" Then
            MessageBox.Show("Enter user name and password")
            Return False
        Else
            Result = con.Login(UserName, Password)
            If Result.Rows.Count = 1 Then
                'Setting NaveBar Proparties
                UserInformation.UserID = Result.Rows(0)("UserName").ToString()
                UserInformation.Name = Result.Rows(0)("Name").ToString()
                UserInformation.CartItems = con.CartItem(UserID)
                Return True
            Else
                MessageBox.Show("Wrong user name and password")
                Return False
            End If
        End If
    End Function

    Public Function Register(ByVal Name As String, ByVal UserName As String, ByVal Password As String) As Boolean
        If Name = "Name" Or UserName = "Username" Or Password = "Password" Then
            MessageBox.Show("Enter Info Correctly")
            Return False
        Else
            If CheckUserName(UserName) Then
                If con.Register(Name, UserName, Password) Then
                    Return True
                Else
                    MessageBox.Show("Unsuccessfull Try Again")
                    Return True
                End If
            Else
                MessageBox.Show("Username is not Available")
                Return False
            End If
        End If
    End Function

End Class

