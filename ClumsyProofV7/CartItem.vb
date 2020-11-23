Public Class CartItem
    Private _Image As Image = My.Resources.iphone_11_PNG42

    Public Property Image() As Image
        Get
            Return _Image
        End Get
        Set(ByVal value As Image)
            PictureBox1.Image = value
            _Image = value
        End Set
    End Property

    Private _ItemName As String = "Name"
    Public Property ItemName() As String
        Get
            Return _ItemName
        End Get
        Set(ByVal value As String)
            Label1.Text = value
            _ItemName = value
        End Set
    End Property

    Private _Price As String = "Price"
    Public Property Price() As String
        Get
            Return _Price
        End Get
        Set(ByVal value As String)
            Label2.Text = value
            _Price = value
        End Set
    End Property

    Private _Quantity As String = "1"
    Public Property Quantity() As String
        Get
            Return _Quantity
        End Get
        Set(ByVal value As String)
            ComboBox1.Text = value
            _Quantity = value
        End Set
    End Property

    Private _ProductId As String
    Public Property ProductId() As String
        Get
            Return _ProductId
        End Get
        Set(ByVal value As String)
            _ProductId = value
        End Set
    End Property

    Public Event Quantity_Change(ByVal Quantity As Integer, ByVal ProductId As String)
    Private Sub ComboBox1_TextChanged(sender As Object, e As EventArgs) Handles ComboBox1.TextChanged
        Quantity = ComboBox1.Text
        RaiseEvent Quantity_Change(Quantity, ProductId)
    End Sub

    Public Event DeleteItem_Click(ByVal ProductId As String)
    Private Sub Delete_Click(sender As Object, e As EventArgs) Handles Delete.Click
        RaiseEvent DeleteItem_Click(ProductId)
    End Sub

    Private Sub Delete_MouseEnter(sender As Object, e As EventArgs) Handles Delete.MouseEnter
        sender.ForeColor = System.Drawing.Color.LightSkyBlue
        sender.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, FontStyle.Underline)
    End Sub

    Private Sub Delete_MouseLeave(sender As Object, e As EventArgs) Handles Delete.MouseLeave
        sender.ForeColor = System.Drawing.Color.DodgerBlue
        sender.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, FontStyle.Regular)
    End Sub
End Class
