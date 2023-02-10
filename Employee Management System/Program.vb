Imports System
Imports System.Transactions

Module Program
    Sub Main(args As String())
        Dim employeeList As New List(Of Employee)
        Dim userinput As String
        Do
            Console.WriteLine("Enter CREATE,UPDATE,VIEW,VIEWALL OR QUIT")
            userinput = Console.ReadLine()
            Select Case userinput
                Case "CREATE"
                    Dim newEmp As New Employee
                    Console.WriteLine("Enter the EmployeeID: ")
                    newEmp.id = Console.ReadLine()
                    Console.WriteLine("Enter the Employee Name")
                    newEmp.name = Console.ReadLine()
                    Console.WriteLine("Enter the Employee Date of Birth")
                    newEmp.dateofBirth = Console.ReadLine()
                    Console.WriteLine("Enter the Employee Salary")
                    newEmp.salary = Console.ReadLine()
                    Console.WriteLine("Enter the Employee Status")
                    newEmp.active = Console.ReadLine()

                    newEmp.CreateEmployee(newEmp.id, newEmp.name, newEmp.dateofBirth, newEmp.salary, newEmp.active)
                    employeeList.Add(newEmp)



            End Select
        Loop
    End Sub
End Module
