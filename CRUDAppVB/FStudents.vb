Option Infer On
Option Strict On

Public Class FStudents
    Private student As Student
    Private service As StudentService
    Private Property ID As Integer

    Public Sub New()
        InitializeComponent()
    End Sub

    Private Sub FStudents_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FetchData()
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        student = New Student()

        If ID <= 0 Then
            If (txtName.Text <> String.Empty) Then
                student.Name = txtName.Text
                student.Address = txtAddress.Text
                student.Age = If(String.IsNullOrEmpty(txtAge.Text), 0, Convert.ToInt32(txtAge.Text))
                student.Contact = txtContact.Text
                service.SaveStudent(student)
            Else
                MessageBox.Show("Add at least a value to name!", "Add value", MessageBoxButtons.OK, MessageBoxIcon.[Error])
            End If
        Else
            student.ID = ID
            student.Name = txtName.Text
            student.Address = txtAddress.Text
            student.Age = If(String.IsNullOrEmpty(txtAge.Text), 0, Convert.ToInt32(txtAge.Text))
            student.Contact = txtContact.Text
            service.UpdateStudent(student)
        End If

        ClearControls()
        ResetID()
        FetchData()
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        ClearControls()
        ResetID()
    End Sub

    Private Sub FetchData()
        service = New StudentService()
        dgvStudents.DataSource = service.Fetch()
    End Sub

    Private Sub ResetID()
        ID = -1
    End Sub

    Private Sub ClearControls()
        txtAddress.Text = String.Empty
        txtAge.Text = String.Empty
        txtContact.Text = String.Empty
        txtName.Text = String.Empty
    End Sub

    Private Sub dgvStudents_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvStudents.CellContentClick
        If e.RowIndex >= 0 AndAlso (CType(sender, DataGridView)).Columns(e.ColumnIndex).[GetType]() = GetType(DataGridViewButtonColumn) AndAlso (e.ColumnIndex = 1) Then
            If MessageBox.Show("You sure about this? Student will be deleted from database!", "Remove?", MessageBoxButtons.OKCancel) = DialogResult.OK Then

                If (CType(sender, DataGridView)).CurrentRow.Cells(2).Value IsNot Nothing Then
                    student = New Student()
                    student.ID = Convert.ToInt32((CType(sender, DataGridView)).CurrentRow.Cells(2).Value)
                    service.DeleteStudent(student)
                    FetchData()
                End If
            End If
        Else

            If e.RowIndex >= 0 AndAlso (CType(sender, DataGridView)).Columns(e.ColumnIndex).[GetType]() = GetType(DataGridViewButtonColumn) AndAlso (e.ColumnIndex = 0) Then
                ID = Convert.ToInt32((CType(sender, DataGridView)).CurrentRow.Cells(2).Value)
                txtAddress.Text = (CType(sender, DataGridView)).CurrentRow.Cells(5).Value.ToString()
                txtAge.Text = (CType(sender, DataGridView)).CurrentRow.Cells(4).Value.ToString()
                txtContact.Text = (CType(sender, DataGridView)).CurrentRow.Cells(6).Value.ToString()
                txtName.Text = (CType(sender, DataGridView)).CurrentRow.Cells(3).Value.ToString()
            End If
        End If
    End Sub
End Class
