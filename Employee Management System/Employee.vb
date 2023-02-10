Public Class Employee
    Public id As Integer
    Public name As String
    Public dateofBirth As Date
    Public salary As Double
    Public active As Boolean

    Public Sub CreateEmployee(ByVal id As Integer, ByVal name As String, ByVal dateofBirth As Date, ByVal salary As Double, ByVal active As Boolean)
        Me.id = id
        Me.name = id
        Me.dateofBirth = dateofBirth
        Me.salary = salary
        Me.active = active
    End Sub
End Class
