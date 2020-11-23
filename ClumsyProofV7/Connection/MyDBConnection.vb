Imports System.Data.SqlClient

Public Class MyDBConnection

    ReadOnly ConnectionString As String = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\mahdi\source\repos\ClumsyProofV7\Database\ClumsyProofDBC.mdf;Integrated Security=True;Connect Timeout=30"
    Dim myconn As New SqlClient.SqlConnection(ConnectionString)
    Dim mycommand As SqlClient.SqlCommand
    Dim myadapter As New SqlClient.SqlDataAdapter
    Dim myDataTable As DataTable

    Public Function CheckUserName(ByVal UserName As String) As Boolean
        myconn.Open()
        mycommand = New SqlClient.SqlCommand With {
            .CommandText = "SELECT * FROM USERS WHERE username = @U"
        }
        mycommand.Parameters.Add("@U", SqlDbType.VarChar)
        mycommand.Parameters("@U").Value = UserName
        mycommand.Connection = myconn
        myadapter.SelectCommand = mycommand
        myDataTable = New DataTable
        myadapter.Fill(myDataTable)
        If myDataTable.Rows.Count = 0 Then
            myconn.Close()
            Return True
        Else
            myconn.Close()
            Return False
        End If
    End Function

    Public Function Login(ByVal UserName As String, ByVal Password As String) As DataTable
        myconn.Open()
        mycommand = New SqlClient.SqlCommand With {
            .Connection = myconn,
            .CommandText = "SELECT Name,UserName FROM USERS WHERE username = @User AND password = @Pass"
        }
        mycommand.Parameters.Add("@User", SqlDbType.VarChar)
        mycommand.Parameters("@User").Value = UserName
        mycommand.Parameters.Add("@Pass", SqlDbType.VarChar)
        mycommand.Parameters("@Pass").Value = Password
        mycommand.Connection = myconn
        myadapter.SelectCommand = mycommand
        myDataTable = New DataTable
        myadapter.Fill(myDataTable)
        If myDataTable.Rows.Count = 1 Then
            myconn.Close()
            Return myDataTable
        Else
            myconn.Close()
            Return myDataTable
        End If
    End Function
    Public Function Register(ByVal Name As String, ByVal UserName As String, ByVal Password As String) As Boolean
        Dim insertcommand = New SqlClient.SqlCommand
        Try
            myconn.Open()
            insertcommand.Connection = myconn
            insertcommand.CommandText = "INSERT INTO USERS (UserName,Password,Name) VALUES(@User,@Pass,@Name)"
            insertcommand.Parameters.Add("@User", SqlDbType.VarChar)
            insertcommand.Parameters("@User").Value = UserName
            insertcommand.Parameters.Add("@Pass", SqlDbType.VarChar)
            insertcommand.Parameters("@Pass").Value = Password
            insertcommand.Parameters.Add("@Name", SqlDbType.VarChar)
            insertcommand.Parameters("@Name").Value = Name
            insertcommand.ExecuteNonQuery()
            myconn.Close()
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function
    Public Function GetProduct(ByVal Type As String) As DataTable
        myconn.Open()
        mycommand = New SqlClient.SqlCommand With {
            .CommandText = "SELECT * FROM PRODUCT WHERE Type = @T"
        }
        mycommand.Parameters.Add("@T", SqlDbType.VarChar)
        mycommand.Parameters("@T").Value = Type
        mycommand.Connection = myconn
        myadapter.SelectCommand = mycommand
        Dim Result As New DataTable
        myadapter.Fill(Result)
        myconn.Close()
        Return Result
    End Function

    Public Function CartItem(ByVal UserName As String) As Integer
        myconn.Open()
        mycommand = New SqlClient.SqlCommand With {
            .CommandText = "SELECT * FROM CART WHERE username = @U"
        }
        mycommand.Parameters.Add("@U", SqlDbType.VarChar)
        mycommand.Parameters("@U").Value = UserName
        mycommand.Connection = myconn
        myadapter.SelectCommand = mycommand
        myDataTable = New DataTable
        myadapter.Fill(myDataTable)
        myconn.Close()
        Return myDataTable.Rows.Count

    End Function
    Public Function AdItemToCart(ByVal UserID As String, ByVal ItemID As Integer) As Boolean
        'Console.WriteLine(UserID & ItemID)
        Dim insertcommand = New SqlClient.SqlCommand
        Try
            myconn.Open()
            'Check
            mycommand = New SqlClient.SqlCommand With {
            .CommandText = "SELECT * FROM CART WHERE username = @U AND  ProductID = @I"
        }
            mycommand.Parameters.Add("@U", SqlDbType.VarChar)
            mycommand.Parameters("@U").Value = UserID
            mycommand.Parameters.Add("@I", SqlDbType.VarChar)
            mycommand.Parameters("@I").Value = ItemID
            mycommand.Connection = myconn
            myadapter.SelectCommand = mycommand
            myDataTable = New DataTable
            myadapter.Fill(myDataTable)
            'Insert
            If myDataTable.Rows.Count = 0 Then
                insertcommand.Connection = myconn
                insertcommand.CommandText = "INSERT INTO CART (UserName,ProductID) VALUES(@U,@I)"
                insertcommand.Parameters.Add("@U", SqlDbType.VarChar)
                insertcommand.Parameters("@U").Value = UserID
                insertcommand.Parameters.Add("@I", SqlDbType.Int)
                insertcommand.Parameters("@I").Value = ItemID
                insertcommand.ExecuteNonQuery()
                myconn.Close()
                Return True
            Else
                myconn.Close()
                Return False
            End If
        Catch ex As Exception
            Console.WriteLine(ex)
            MessageBox.Show(ex.ToString)
            Return False
        End Try
    End Function
    Public Function GetCartItems(ByVal UserId As String) As DataTable
        myconn.Open()
        mycommand = New SqlClient.SqlCommand With {
            .CommandText = "SELECT PRODUCT.Image, PRODUCT.Name, PRODUCT.Description, PRODUCT.Price, CART.ProductId, CART.Quantity
                            FROM CART  INNER JOIN PRODUCT ON CART.ProductID = PRODUCT.Id
                            WHERE CART.UserName = @U"
        }
        mycommand.Parameters.Add("@U", SqlDbType.VarChar)
        mycommand.Parameters("@U").Value = UserId
        mycommand.Connection = myconn
        myadapter.SelectCommand = mycommand
        Dim Result As New DataTable
        myadapter.Fill(Result)
        myconn.Close()
        Return Result
    End Function
    Public Function UpdateQuantity(ByVal UserId As String, ByVal Quantity As String, ByVal ProductId As String) As Boolean
        Dim insertcommand = New SqlClient.SqlCommand
        Try
            myconn.Open()
            'Insert
            insertcommand.Connection = myconn
            insertcommand.CommandText = "Update CART SET Quantity = @Q WHERE UserName = @U And ProductId = @P"
            insertcommand.Parameters.Add("@U", SqlDbType.VarChar)
            insertcommand.Parameters("@U").Value = UserId
            insertcommand.Parameters.Add("@Q", SqlDbType.Int)
            insertcommand.Parameters("@Q").Value = Quantity
            insertcommand.Parameters.Add("@P", SqlDbType.Int)
            insertcommand.Parameters("@P").Value = ProductId
            insertcommand.ExecuteNonQuery()
            myconn.Close()
            Return True
        Catch ex As Exception
            Console.WriteLine(ex)
            MessageBox.Show(ex.ToString)
            Return False
        End Try
    End Function
    Public Function PlaceOrder(ByVal UserId As String) As Boolean
        Dim deletecommand = New SqlClient.SqlCommand
        Try
            myconn.Open()
            'Delete all items from cart
            deletecommand.Connection = myconn
            deletecommand.CommandText = "DELETE FROM CART WHERE UserName = @U"
            deletecommand.Parameters.Add("@U", SqlDbType.VarChar)
            deletecommand.Parameters("@U").Value = UserId
            deletecommand.ExecuteNonQuery()
            myconn.Close()
            Return True
        Catch ex As Exception
            Console.WriteLine(ex)
            MessageBox.Show(ex.ToString)
            Return False
        End Try
    End Function

    Public Function DeleteCartItem(ByVal UserId As String, ByVal ProductId As String) As Boolean
        Dim deletecommand = New SqlClient.SqlCommand
        Try
            myconn.Open()
            'Delete Singal Item from cart
            deletecommand.Connection = myconn
            deletecommand.CommandText = "DELETE FROM CART WHERE UserName = @U AND ProductId = @P"
            deletecommand.Parameters.Add("@U", SqlDbType.VarChar)
            deletecommand.Parameters("@U").Value = UserId
            deletecommand.Parameters.Add("@P", SqlDbType.VarChar)
            deletecommand.Parameters("@P").Value = ProductId
            deletecommand.ExecuteNonQuery()
            myconn.Close()
            Return True
        Catch ex As Exception
            Console.WriteLine(ex)
            MessageBox.Show(ex.ToString)
            Return False
        End Try
    End Function


End Class
