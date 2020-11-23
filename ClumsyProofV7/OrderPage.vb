Public Class OrderPage
    Dim con As MyDBConnection = New MyDBConnection()
    Dim Result As DataTable
    Private Page As Object




    'TOPnavbarCode 
    Public Event CartClick(ByVal CartItem As Integer)

    Private _UserName As String = ""
    Public Property UserName() As String
        Get
            Return _UserName
        End Get
        Set(ByVal value As String)
            Try
                Label2.Text = value.Substring(0, 1)
                If value.Length > 5 Then
                    CustomerName.Text = value.Remove(4) + "..."
                Else
                    CustomerName.Text = value
                End If
            Catch ex As Exception

            End Try

            _UserName = value
        End Set
    End Property
    Private _CartItem As Integer = 0
    Public Property CartItem() As Integer
        Get
            Return _CartItem
        End Get
        Set(ByVal value As Integer)
            If value > 9 Then
                If value > 99 Then
                    numberofItems.Text = "99"
                    numberofItems.ForeColor = Color.Red
                Else
                    numberofItems.Text = value
                End If
                numberofItems.Location = New System.Drawing.Point(numberofItems.Location.X - 2, 15)
            Else
                numberofItems.Text = value
                numberofItems.Location = New System.Drawing.Point(numberofItems.Location.X, 15)
            End If
            _CartItem = value
        End Set
    End Property

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click, numberofItems.Click
        RaiseEvent CartClick(CartItem())
    End Sub

    Private Sub PictureBox2_MouseHover(sender As Object, e As EventArgs) Handles PictureBox2.MouseHover, numberofItems.MouseHover
        PictureBox2.BorderStyle = BorderStyle.Fixed3D

    End Sub

    Private Sub PictureBox2_MouseLeave(sender As Object, e As EventArgs) Handles PictureBox2.MouseLeave, numberofItems.MouseLeave
        '    OvalShape1.BringToFront()
        PictureBox1.BorderStyle = BorderStyle.None

    End Sub




    'End of Top Nav'





    'Private Sub OrderPage_Load(sender As Object, e As EventArgs) Handles Me.Load
    '    Me.CustomerName.Text = "Welcome, " + UserInfo.Name
    '    Me.CenterToScreen()
    'End Sub



    Private Sub GoToMainWindow()
        UserInformation.CartItems = con.CartItem(UserInformation.UserID)
        Me.CartItem = UserInformation.CartItems
        Page = ProductDashboard
        Me.Close()
    End Sub




    Public Sub ShowOrder(ByVal sender As Object)
        Page = sender
        Me.Show()
    End Sub

    Private Sub Order_Closed(sender As Object, e As EventArgs) Handles Me.Closed

        Page.Show()
    End Sub

    Private Sub Order_Load(sender As Object, e As EventArgs) Handles Me.Load
        Me.CenterToScreen()
        Result = con.GetCartItems(UserInformation.UserID)
        If Result.Rows.Count > 0 Then
            SubTotal1.Total = -SubTotal1.Total
            For Each Row As DataRow In Result.Rows
                Dim img() As Byte = Row("Image")
                Dim ms As New System.IO.MemoryStream(img)
                Dim CartItem = New CartItem With {
                    .Image = Image.FromStream(ms),
                    .Price = "$" + Row("Price").ToString,
                    .ItemName = Row("Name").ToString & Row("Description").ToString,
                    .Quantity = Row("Quantity"),
                    .ProductId = Row("ProductID")
                }
                SubTotal1.Total = CDec(Row("Price")) * CDec(Row("Quantity"))
                AddHandler CartItem.Quantity_Change, AddressOf QuantityChange
                AddHandler CartItem.DeleteItem_Click, AddressOf DeleteItem
                FlowLayoutPanel1.Controls.Add(CartItem)
            Next
        End If
    End Sub

    Private Sub QuantityChange(ByVal Quantity As Integer, ByVal ProductId As Integer)
        If con.UpdateQuantity(UserInformation.UserID, Quantity, ProductId) Then
            Result = con.GetCartItems(UserInformation.UserID)
            If Result.Rows.Count > 0 Then
                SubTotal1.Total = -SubTotal1.Total
                For Each Row As DataRow In Result.Rows
                    SubTotal1.Total = CDec(Row("Price")) * CDec(Row("Quantity"))
                Next
            End If
        End If
    End Sub

    Private Sub SubTotal1_PlaceYourOrder_Click() Handles SubTotal1.PlaceYourOrder_Click
        If con.PlaceOrder(UserInformation.UserID) Then
            MessageBox.Show("Thanks For Shopping with Us")
            GoToMainWindow()
        End If
    End Sub

    Private Sub DeleteItem(ByVal ProductId As Integer)
        If con.DeleteCartItem(UserInformation.UserID, ProductId) Then
            MessageBox.Show("Item Removed")
            Result = con.GetCartItems(UserInformation.UserID)
            If Result.Rows.Count > 0 Then
                FlowLayoutPanel1.Controls.Clear()
                SubTotal1.Total = -SubTotal1.Total
                For Each Row As DataRow In Result.Rows
                    Dim img() As Byte = Row("Image")
                    Dim ms As New System.IO.MemoryStream(img)
                    Dim CartItem = New CartItem With {
                        .Image = Image.FromStream(ms),
                        .Price = "$" + Row("Price").ToString,
                        .ItemName = Row("Name").ToString & Row("Description").ToString,
                        .Quantity = Row("Quantity"),
                        .ProductId = Row("ProductID")
                    }
                    SubTotal1.Total = CDbl(Row("Price") * Row("Quantity"))
                    AddHandler CartItem.Quantity_Change, AddressOf QuantityChange
                    AddHandler CartItem.DeleteItem_Click, AddressOf DeleteItem
                    FlowLayoutPanel1.Controls.Add(CartItem)
                Next
            Else
                GoToMainWindow()
            End If
        End If

    End Sub




End Class