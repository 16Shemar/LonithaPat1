Public Class Person
    ' Private attributes (encapsulation)
    Private _firstName As String
    Private _lastName As String
    Private _age As Integer

    ' Public properties to access private attributes
    Public Property FirstName As String
        Get
            Return _firstName
        End Get
        Set(value As String)
            _firstName = value
        End Set
    End Property

    Public Property LastName As String
        Get
            Return _lastName
        End Get
        Set(value As String)
            _lastName = value
        End Set
    End Property

    Public Property Age As Integer
        Get
            Return _age
        End Get
        Set(value As Integer)
            _age = value
        End Set
    End Property

    ' Constructor
    Public Sub New(firstName As String, lastName As String, age As Integer)
        _firstName = firstName
        _lastName = lastName
        _age = age
    End Sub
End Class
