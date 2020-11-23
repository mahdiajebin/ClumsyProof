Module UserInformation

    Private _UserID As String = ""
    Public Property UserID() As String
        Get
            Return _UserID
        End Get
        Set(ByVal value As String)
            _UserID = value
        End Set
    End Property
    Private _Name As String = "Name"
    Public Property Name() As String
        Get
            Return _Name
        End Get
        Set(ByVal value As String)
            _Name = value
        End Set
    End Property

    Private _CartItems As Integer = 0
    Public Property CartItems() As Integer
        Get
            Return _CartItems
        End Get
        Set(ByVal value As Integer)
            _CartItems = value
        End Set
    End Property
End Module
