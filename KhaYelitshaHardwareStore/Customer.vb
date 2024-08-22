Public Class Customer
    Inherits Person

    ' Private attributes specific to Customer
    Private _email As String
    Private _phoneNumber As String

    ' Public properties
    Public Property Email As String
        Get
            Return _email
        End Get
        Set(value As String)
            _email = value
        End Set
    End Property

    Public Property PhoneNumber As String
        Get
            Return _phoneNumber
        End Get
        Set(value As String)
            _phoneNumber = value
        End Set
    End Property

    ' Constructor
    Public Sub New(firstName As String, lastName As String, age As Integer, email As String, phoneNumber As String)
        MyBase.New(firstName, lastName, age)
        _email = email
        _phoneNumber = phoneNumber
    End Sub
End Class
