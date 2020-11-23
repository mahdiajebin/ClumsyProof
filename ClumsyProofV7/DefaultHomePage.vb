Public Class DefaultHomePage
    ' Dim conn As DBConnection
    '   Dim Register As Register = New Register()
    Dim LoginOrRegister As RegisterAndLoginClass = New RegisterAndLoginClass
    Public Event LoginEvent(ByVal UserName As String, ByVal Password As String)
    Public Event SignUPEvent(ByVal UserName As String, ByVal Password As String, ByVal ConPassword As String)


    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles Me.Load

        Me.CenterToScreen()
    End Sub

    Private Sub GoToMainWindow()
        'Hide this Login window and Show Main Window
        ProductDashboard.Show()
        Me.Hide()
    End Sub
    'LOGIN FUNCtions

    Private Sub LoginPanel_LoginEvent(ByVal UserName As String, ByVal Password As String) Handles Me.LoginEvent
        If LoginOrRegister.Login(UserName, Password) Then
            GoToMainWindow()
        End If

    End Sub
    Private Sub pinkbtnLogin_Click(sender As Object, e As EventArgs) Handles pinkbtnLogin.Click
        RaiseEvent LoginEvent(txtuserNameL.Text, txtpasswordL.Text)
    End Sub

    Private Sub TextBoxs_Click(sender As Object, e As EventArgs) Handles txtpasswordL.Click, txtpasswordL.GotFocus

        If sender.name = "txtpasswordL" Then
            sender.PasswordChar = "✱"
        End If

        If sender.name = "txtpasswordSU" Then
            sender.PasswordChar = "✱"
        End If

    End Sub

    'Registration Functions 

    Private Sub RegiserPanel_SignUPEvent(ByVal Name As String, ByVal UserName As String, ByVal Password As String) Handles Me.SignUPEvent
        If LoginOrRegister.Register(Name, UserName, Password) Then
            MessageBox.Show("Registration Successful")
            Me.registerPanel.Visible = False


            Me.loginPanel.Visible = True
        End If
    End Sub
    Private Sub pinkbtnsignUP_Click(sender As Object, e As EventArgs) Handles pinkbtnsignUP.Click
        RaiseEvent SignUPEvent(txtName.Text, txtuserNameSU.Text, txtpasswordSU.Text)
    End Sub





    'Continue As Guest
    Private Sub ContinueAsGuest()
        Dim MacAddress = System.Net.NetworkInformation.NetworkInterface.GetAllNetworkInterfaces(0).GetPhysicalAddress()

        If LoginOrRegister.CheckUserName(MacAddress.ToString) Then
            If LoginOrRegister.Register("Guest", MacAddress.ToString, "Guest") Then
                If LoginOrRegister.Login(MacAddress.ToString, "Guest") Then
                    GoToMainWindow()
                End If
            End If
        Else
            If LoginOrRegister.Login(MacAddress.ToString, "Guest") Then
                GoToMainWindow()
            End If
        End If
    End Sub

    Private Sub ForgotPassword(sender As Object, e As EventArgs)
        MessageBox.Show("ForgotPassword")
    End Sub

    Private Sub ContinueAsGuest(sender As Object, e As EventArgs)
        ContinueAsGuest()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btncontinueasGuest.Click
        Me.ContinueAsGuest()
    End Sub

    Public Sub bluebtnLogin_Click(sender As Object, e As EventArgs) Handles bluebtnLogin.Click

        loginPanel.Visible = True


    End Sub

    Public Sub bluebtnSignUp_Click(sender As Object, e As EventArgs) Handles bluebtnSignUp.Click

        registerPanel.Visible = True
        Me.loginPanel.Visible = False




    End Sub


End Class
