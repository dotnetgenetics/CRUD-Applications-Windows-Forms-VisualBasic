Option Infer On
Imports System.Data.SqlClient

Public Class StudentService
    Private helper As DALHelper
    Private dtStudent As DataTable
    Private parameter As SqlParameter()
    Private query As String

    Public Sub SaveStudent(ByVal student As Student)
        helper = New DALHelper()
        query = "Insert Into Students(Name,Age,Address,Contact) " & " Values (@Name,@Age, @Address,@Contact)"
        parameter = New SqlParameter(3) {}
        parameter(0) = New SqlParameter("@Name", SqlDbType.VarChar) With {
            .Value = student.Name
        }
        parameter(1) = New SqlParameter("@Age", SqlDbType.Int) With {
            .Value = student.Age
        }
        parameter(2) = New SqlParameter("@Address", SqlDbType.VarChar) With {
            .Value = student.Address
        }
        parameter(3) = New SqlParameter("@Contact", SqlDbType.VarChar) With {
            .Value = student.Contact
        }
        helper.ExecuteNonQuery(query, parameter)
    End Sub

    Public Sub UpdateStudent(ByVal student As Student)
        helper = New DALHelper()
        query = "Update Students set Name=@Name,Age=@Age,Address=@Address,Contact=@Contact Where ID=@ID"
        parameter = New SqlParameter(4) {}
        parameter(0) = New SqlParameter("@Name", SqlDbType.VarChar) With {
            .Value = student.Name
        }
        parameter(1) = New SqlParameter("@Age", SqlDbType.Int) With {
            .Value = student.Age
        }
        parameter(2) = New SqlParameter("@Address", SqlDbType.VarChar) With {
            .Value = student.Address
        }
        parameter(3) = New SqlParameter("@Contact", SqlDbType.VarChar) With {
            .Value = student.Contact
        }
        parameter(4) = New SqlParameter("@ID", SqlDbType.Int) With {
            .Value = student.ID
        }
        helper.ExecuteNonQuery(query, parameter)
    End Sub

    Public Sub DeleteStudent(ByVal student As Student)
        helper = New DALHelper()
        query = "DELETE FROM Students WHERE ID=@id"
        parameter = New SqlParameter(0) {}
        parameter(0) = New SqlParameter("@id", SqlDbType.Int) With {
            .Value = student.ID
        }
        helper.ExecuteNonQuery(query, parameter)
    End Sub

    Public Function Fetch() As DataTable
        helper = New DALHelper()
        dtStudent = New DataTable()
        query = "Select * from Students"
        dtStudent = helper.ExecuteSelectQueryDataTable(query)
        Return dtStudent
    End Function
End Class
