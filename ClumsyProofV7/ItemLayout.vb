Public Class ItemLayout
    Private PriceText As String = "$00.00"
    Private TitleText As String = "title"
    Private DescriptionText As String = "description"
    Private ButtonText As String = "Add To Cart"
    Private ImageLocation As Image = My.Resources.iphone_11_PNG42

    Public Event AddtoCart_Click(ByVal ItemID As Integer)

    Property SelectImage() As Image
        Get
            Return ImageLocation
        End Get
        Set(value As Image)
            ImageLocation = value
            PictureBox.Image = value
        End Set
    End Property

    Property Price() As String
        Get
            Return PriceText
        End Get
        Set(value As String)
            PriceText = value
            Label1.Text = value
        End Set
    End Property

    Property Title() As String
        Get
            Return TitleText
        End Get
        Set(value As String)
            If value.Length > 21 Then
                Label2.Text = value.Remove(18) + "..."
            Else
                Label2.Text = value
            End If
            TitleText = value
            ToolTip1.SetToolTip(Label2, value)
        End Set
    End Property

    Property Description() As String
        Get
            Return DescriptionText
        End Get
        Set(value As String)
            If value.Length > 84 Then
                Label3.Text = value.Remove(81) + "..."
            Else
                Label3.Text = value
            End If
            DescriptionText = value
            ToolTip1.SetToolTip(Label3, value)
        End Set
    End Property

    Property AddtoCart() As String
        Get
            Return ButtonText
        End Get
        Set(value As String)
            ButtonText = value
            Button.Text = value
        End Set
    End Property

    Private _ItemID As Integer
    Public Property ItemId() As Integer
        Get
            Return _ItemID
        End Get
        Set(ByVal value As Integer)
            _ItemID = value
        End Set
    End Property


    Private Sub Button_Click(sender As Object, e As EventArgs) Handles Button.Click
        RaiseEvent AddtoCart_Click(ItemId)
    End Sub
    Private Sub Button_MouseEnter(sender As Object, e As EventArgs) Handles Button.MouseEnter
        sender.BackColor = SystemColors.ControlDarkDark
    End Sub

    Private Sub Button_MouseLeave(sender As Object, e As EventArgs) Handles Button.MouseLeave
        sender.BackColor = SystemColors.ActiveCaptionText
    End Sub

    Private Sub PictureBox_Click(sender As Object, e As EventArgs) Handles PictureBox.Click

    End Sub

    Private Sub FlowLayoutPanel_Paint(sender As Object, e As PaintEventArgs) Handles FlowLayoutPanel.Paint

    End Sub
End Class
