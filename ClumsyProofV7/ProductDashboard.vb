
Public Class ProductDashboard
    Dim con As MyDBConnection = New MyDBConnection()

    Private Sub Main_Load(sender As Object, e As EventArgs) Handles Me.Load
        Me.CustomerName.Text = "Welcome, " + UserInformation.Name
        Me.CenterToScreen()
    End Sub

    'top menu bar 


    Public Event CartClick(ByVal CartItem As Integer)

    Private _UserName As String = ""
    Public Property UserName() As String
        Get
            Return _UserName
        End Get
        Set(ByVal value As String)
            Try
                ' Label2.Text = value.Substring(0, 1)
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





    'End of top panel





    'Side Menu Bar Code









    'GridView 

    Public Sub AddItems(ByVal Items() As ItemLayout)
        'Console.WriteLine(Items.Length)
        Dim height As Integer = -Items(0).Height
        Dim colum = 1
        Me.SuspendLayout()
        FlowLayoutPanel1.Controls.Clear()
        FlowLayoutPanel2.Controls.Clear()

        ' TableLayoutPanel1.ColumnStyles(0).Width = Items(0).Width + 100
        ' TableLayoutPanel1.ColumnStyles(1).Width = Items(0).Width + 20
        TableLayoutPanel1.ColumnStyles(0).Width = FlowLayoutPanel1.Width

        TableLayoutPanel1.ColumnStyles(1).Width = FlowLayoutPanel2.Width

        For Each Item As ItemLayout In Items
            If colum = 0 Then
                height += Items(0).Height
                FlowLayoutPanel1.Controls.Add(Item)

                TableLayoutPanel1.RowStyles(0).Height = height
                colum = 1
            ElseIf colum = 1 Then
                FlowLayoutPanel2.Controls.Add(Item)
                colum = 0
            End If
        Next
        Me.Refresh()
        Me.ResumeLayout(False)
    End Sub

    'Private Sub FlowLayoutPanel2_Resize(sender As Object, e As EventArgs) Handles FlowLayoutPanel2.Resize
    '    Panel1.Size = New Size(Panel1.Size.Width, FlowLayoutPanel2.Size.Height)
    'End Sub










    'Items 




    '-----------------------------------------------------------------------------]
    'Product 
    '   Dim con As DBConnection = New DBConnection()
    Dim Result As DataTable
    Dim items() As ItemLayout

    'Private Sub Product_Load(sender As Object, e As EventArgs) Handles Me.Load
    '    '     Me.NavBar1.UserName = UserInfo.Name
    '    Me.CenterToParent()
    'End Sub

    Private Sub LoadeItems(ByVal Type As String)

        ' MessageBox.Show(Type)

        Result = con.GetProduct(Type)
        items = New ItemLayout(Result.Rows.Count) {}
        'Console.WriteLine(Result.Rows.Count)
        If Result.Rows.Count > 0 Then
            For Each Row As DataRow In Result.Rows
                Dim img() As Byte = Row("Image")
                Dim ms As New System.IO.MemoryStream(img)
                Dim Item = New ItemLayout With {
                    .SelectImage = Image.FromStream(ms),
                    .Price = "$" + Row("Price").ToString,
                    .Title = Row("Name").ToString,
                    .Description = Row("Description").ToString,
                    .ItemId = Row("Id")
                }
                AddHandler Item.AddtoCart_Click, AddressOf AddtoCart
                items(Result.Rows.IndexOf(Row)) = Item
            Next
            Me.AddItems(items)

            Me.Show()
        Else
            Me.Show()
        End If


    End Sub

    Private Sub AddtoCart(ByVal ItemID As Integer)
        If con.AdItemToCart(UserInformation.UserID, ItemID) Then
            UserInformation.CartItems = con.CartItem(UserInformation.UserID)
            Me.CartItem = UserInformation.CartItems
            MessageBox.Show("Item Added to Cart")
        Else
            MessageBox.Show("Item Already in Cart")
        End If
    End Sub

    Private Sub Product_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        Me.UserName = UserInformation.Name
        Me.CartItem = UserInformation.CartItems
        Me.Hide()
        Me.Show()
    End Sub

    Private Sub NavBar1_CartClick(CartItem As Integer) Handles Me.CartClick
        If UserInformation.CartItems >= 1 Then
            OrderPage.ShowOrder(Me)
            Me.Hide()
        Else
            MessageBox.Show("Add Some Item to The Shopping Cart")
        End If
    End Sub



    Public Sub Iphone()
        LoadeItems("Iphone")
    End Sub

    Public Sub Cake()
        LoadeItems("Android")
    End Sub

    Public Sub Coffee()
        LoadeItems("Tablet")
    End Sub

    Private Sub Product_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        UserInformation.CartItems = con.CartItem(UserInformation.UserID)
        Me.CartItem = UserInformation.CartItems
        'Console.WriteLine("Activated")
    End Sub

    Private Sub btnIphone_Click(sender As Object, e As EventArgs) Handles btnIphone.Click
        LoadeItems("Iphone")
    End Sub

    Private Sub btnAndroid_Click(sender As Object, e As EventArgs) Handles btnAndroid.Click
        LoadeItems("Android")
    End Sub

    Private Sub btnTablets_Click(sender As Object, e As EventArgs) Handles btnTablets.Click
        LoadeItems("Tablet")
    End Sub
End Class