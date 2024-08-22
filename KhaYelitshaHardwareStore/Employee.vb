Public Class Employee
    Inherits Person

    ' Private attributes specific to Employee
    Private _employeeID As String
    Private _department As String

    ' Public properties
    Public Property EmployeeID As String
        Get
            Return _employeeID
        End Get
        Set(value As String)
            _employeeID = value
        End Set
    End Property

    Public Property Department As String
        Get
            Return _department
        End Get
        Set(value As String)
            _department = value
        End Set
    End Property

    ' Constructor
    Public Sub New(firstName As String, lastName As String, age As Integer, employeeID As String, department As String)
        MyBase.New(firstName, lastName, age)
        _employeeID = employeeID
        _department = department
    End Sub
End Class
