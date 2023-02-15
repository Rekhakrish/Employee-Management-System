Imports System
Imports System.Transactions

Module EmployeeMainMethod
    Sub Main(args As String())

        Console.WriteLine("Welcome to the Employee Management System" & vbCrLf)

        Console.WriteLine("---------------------------------------------" & vbCrLf)

        Console.WriteLine("If You want to handle the Employee ..Please Gohead with foloowing Steps!!!" & vbCrLf)

        Console.WriteLine("---------------------------------------------" & vbCrLf)
        Dim employeeList As New List(Of Employee)
        Dim user1 As New Employee

        Dim userinput As String
        Do
            Console.WriteLine("Enter CREATE,UPDATE,VIEW,VIEWALL,DELETE OR QUIT")
            userinput = Console.ReadLine.ToUpper()
            Select Case userinput
                Case "CREATE"
                    Dim newEmp As New Employee
                    Console.WriteLine("Enter the EmployeeID: ")
                    newEmp.id = (Console.ReadLine())
                    Console.WriteLine("Enter the Employee Name")
                    newEmp.name = Console.ReadLine()
                    Console.WriteLine("Enter the Employee Date of Birth")
                    newEmp.dateofBirth = Console.ReadLine()
                    Console.WriteLine("Enter the Employee Salary")
                    newEmp.salary = Console.ReadLine()
                    Console.WriteLine("Enter the Employee Status")
                    newEmp.active = Console.ReadLine()

                    newEmp.CreateEmployee(newEmp.id, newEmp.name, newEmp.dateofBirth, newEmp.salary, newEmp.active)
                    ' newEmp.CreateEmployee(newEmp.id, newEmp.name, newEmp.dateofBirth, newEmp.salary, newEmp.active)
                    employeeList.Add(newEmp)
                    Console.WriteLine("Succefully created " & vbCrLf)
                Case "UPDATE"
                    Console.WriteLine("Enter Employee Id: ")
                    Dim employeeId As Integer = Console.ReadLine()
                    '   Dim newEmp As New Employee

                    Console.WriteLine("Enter New Salary that you need to update: ")
                    Dim salary As Double = Console.ReadLine()

                    For Each employee As Employee In employeeList
                        If employee.id = employeeId Then
                            employee.UpdateEmployee(employeeId, salary)
                        End If
                    Next

                    Console.WriteLine("Succefully Updated Employee Salary!! " & vbCrLf)
                Case "VIEW"
                    Console.WriteLine("You can view Your Specific Employee List " & vbCrLf)
                    Console.WriteLine("Enter Employee ID you need to view: ")
                    Dim employeeId As Integer = Console.ReadLine()
                    ' Dim newEmp As New Employee

                    For Each employee As Employee In employeeList
                        If employee.id = employeeId Then
                            employee.ViewEmployee(employeeId)
                        End If
                    Next


                Case "VIEWALL"
                    Console.WriteLine("You can see all Employee in Employeelist that we created ")
                    Dim newEmp As New Employee
                    newEmp.ViewAllEmployees(employeeList)

                Case "DELETE"
                    Console.WriteLine("Enter Employee ID to Delete: ")
                    Dim employeeId As Integer = Console.ReadLine()

                    For Each employee As Employee In employeeList
                        If employee.id = employeeId Then
                            ' employee.DeleteEmployee(employeeId)
                            employeeList.Remove(employee)
                        End If
                    Next
                    Console.WriteLine("Succefully Deleted Employee !! " & vbCrLf)

            End Select
        Loop Until userinput = "QUIT"
        Console.WriteLine("Thank You !!")
    End Sub
End Module
