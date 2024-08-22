Public Class Item
    ' Private attributes for item names and prices
    Private _itemName As String
    Private _itemPrice As Decimal

    ' Public properties
    Public Property ItemName As String
        Get
            Return _itemName
        End Get
        Set(value As String)
            _itemName = value
        End Set
    End Property

    Public Property ItemPrice As Decimal
        Get
            Return _itemPrice
        End Get
        Set(value As Decimal)
            _itemPrice = value
        End Set
    End Property

    ' Constructor
    Public Sub New(itemName As String, itemPrice As Decimal)
        _itemName = itemName
        _itemPrice = itemPrice
    End Sub
End Class
