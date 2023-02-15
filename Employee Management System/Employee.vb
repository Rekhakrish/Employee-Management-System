Public Class Employee
    Public id As Integer
    Public name As String
    Public dateofBirth As Date
    Public salary As Double
    Public active As Boolean

    Public Sub CreateEmployee(ByVal id As Integer, ByVal name As String, ByVal dateofBirth As Date, ByVal salary As Double, ByVal active As Boolean)
        Me.id = id
        Me.name = name
        Me.dateofBirth = dateofBirth
        Me.salary = salary
        Me.active = active



    End Sub

    Public Sub UpdateEmployee(ByVal id As Integer, ByVal salary As Double)
        Me.id = id
        Me.salary = salary
    End Sub

    Public Sub ViewEmployee(ByVal id As Integer)
        Console.WriteLine("Employee ID: " & Me.id)
        Console.WriteLine("Name: " & Me.name)
        Console.WriteLine("Date Of Birth: " & Me.dateofBirth)
        Console.WriteLine("Salary: " & Me.salary)
        Console.WriteLine("Active: " & Me.active)
    End Sub

    Public Sub ViewAllEmployees(employeeList As List(Of Employee))
        For Each employee As Employee In employeeList
            Console.WriteLine("Employee ID: " & employee.id)
            Console.WriteLine("Name: " & employee.name)
            Console.WriteLine("Date Of Birth: " & employee.dateofBirth)
            Console.WriteLine("Salary: " & employee.salary)
            Console.WriteLine("Active: " & employee.active)
        Next
    End Sub
    Public Sub DeleteEmployee(ByVal id As Integer)
        Me.id = id
        Me.name = Nothing
        Me.dateofBirth = Nothing
        Me.salary = Nothing
        Me.active = Nothing
    End Sub
End Class
