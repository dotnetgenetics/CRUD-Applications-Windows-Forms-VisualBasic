Option Infer On
Imports System.Configuration
Imports System.Data.SqlClient

Public Class DALHelper
    Private myAdapter As SqlDataAdapter
    Private myConn As SqlConnection
    Private connectionString As String

    Public Sub New()
        connectionString = ConfigurationManager.ConnectionStrings("TestDatabase").ConnectionString
        myAdapter = New SqlDataAdapter()
        myConn = New SqlConnection(connectionString)
    End Sub

    Private Function OpenConnection() As SqlConnection
        If myConn.State = ConnectionState.Closed OrElse myConn.State = ConnectionState.Broken Then
            myConn.Open()
        End If

        Return myConn
    End Function

    Private Function CloseConnection() As SqlConnection
        If myConn.State = ConnectionState.Open Or myConn.State = ConnectionState.Broken Then
            myConn.Close()
        End If

        Return myConn
    End Function

    Public Function ExecuteScalar(ByVal _query As String) As Integer
        Dim id As Integer = -1
        Dim command As SqlCommand = myConn.CreateCommand()

        Try
            command.Connection = OpenConnection()
            command.CommandText = _query
            Dim objId As Object = command.ExecuteScalar()

            If objId <> DBNull.Value AndAlso objId IsNot Nothing Then
                id = CInt(objId)
            End If

        Catch ex As Exception
        Finally
            CloseConnection()
            command.Dispose()
            myConn.Dispose()
        End Try

        Return id
    End Function

    Public Function ExecuteScalar(ByVal _query As String, ByVal sqlParameter As SqlParameter()) As Integer
        Dim id As Integer = -1
        Dim command As SqlCommand = myConn.CreateCommand()

        Try
            command.Connection = OpenConnection()
            command.Parameters.AddRange(sqlParameter)
            command.CommandText = _query
            Dim objId As Object = command.ExecuteScalar()

            If objId <> DBNull.Value And objId IsNot Nothing Then
                id = CInt(objId)
            End If

        Catch ex As Exception
        Finally
            CloseConnection()
            command.Dispose()
            myConn.Dispose()
        End Try

        Return id
    End Function

    Public Function BoolExecuteScalar(ByVal _query As String, ByVal sqlParameter As SqlParameter()) As Boolean
        Dim isExisting As Boolean = False
        Dim command As SqlCommand = myConn.CreateCommand()

        Try
            command.Connection = OpenConnection()
            command.Parameters.AddRange(sqlParameter)
            command.CommandText = _query
            Dim objId As Object = command.ExecuteScalar()

            If objId <> DBNull.Value And objId IsNot Nothing Then
                isExisting = True
            End If

        Catch ex As Exception
        Finally
            CloseConnection()
            command.Dispose()
            myConn.Dispose()
        End Try

        Return isExisting
    End Function

    Public Function ExecuteSelectQuery(ByVal _query As String) As DataSet
        Dim ds As DataSet = New DataSet()
        Dim command As SqlCommand = myConn.CreateCommand()

        Try
            command.Connection = OpenConnection()
            command.CommandText = _query
            myAdapter.SelectCommand = command
            myAdapter.Fill(ds)
        Catch ex As Exception
        Finally
            CloseConnection()
            command.Dispose()
            myConn.Dispose()
        End Try

        Return ds
    End Function

    Public Function ExecuteSelectQueryDataTable(ByVal _query As String) As DataTable
        Dim dt As DataTable = New DataTable()
        Dim command As SqlCommand = myConn.CreateCommand()

        Try
            command.Connection = OpenConnection()
            command.CommandText = _query
            myAdapter.SelectCommand = command
            myAdapter.Fill(dt)
        Catch ex As Exception
        Finally
            CloseConnection()
            command.Dispose()
            myConn.Dispose()
        End Try

        Return dt
    End Function

    Public Function ExecuteSelectQueryDataTable(ByVal _query As String, ByVal sqlParameter As SqlParameter()) As DataTable
        Dim dt As DataTable = New DataTable()
        Dim command As SqlCommand = myConn.CreateCommand()

        Try
            command.Connection = OpenConnection()
            command.Parameters.AddRange(sqlParameter)
            command.CommandText = _query
            myAdapter.SelectCommand = command
            myAdapter.Fill(dt)
        Catch ex As Exception
        Finally
            CloseConnection()
            command.Dispose()
            myConn.Dispose()
        End Try

        Return dt
    End Function

    Public Function ExecuteSelectQuery(ByVal _query As String, ByVal sqlParameter As SqlParameter()) As DataSet
        Dim ds As DataSet = New DataSet()
        Dim command As SqlCommand = myConn.CreateCommand()

        Try
            command.Connection = OpenConnection()
            command.Parameters.AddRange(sqlParameter)
            command.CommandText = _query
            myAdapter.SelectCommand = command
            myAdapter.Fill(ds)
        Catch ex As Exception
        Finally
            CloseConnection()
            command.Dispose()
            myConn.Dispose()
        End Try

        Return ds
    End Function

    Public Sub ExecuteNonQuery(ByVal query As String)
        Dim command As SqlCommand = myConn.CreateCommand()

        Try
            command.Connection = OpenConnection()
            command.CommandText = query
            command.CommandTimeout = 0
            command.ExecuteNonQuery()
        Catch e As Exception
        Finally
            CloseConnection()
            command.Dispose()
            myConn.Dispose()
        End Try
    End Sub

    Public Sub ExecuteNonQuery(ByVal query As String, ByVal sqlParameters As SqlParameter())
        Dim command As SqlCommand = myConn.CreateCommand()

        Try
            command.Connection = OpenConnection()
            command.Parameters.AddRange(sqlParameters)
            command.CommandText = query
            command.CommandTimeout = 0
            command.ExecuteNonQuery()
        Catch e As Exception
        Finally
            CloseConnection()
            command.Dispose()
            myConn.Dispose()
        End Try
    End Sub
End Class
