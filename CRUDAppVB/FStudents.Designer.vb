<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FStudents
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        GroupBox1 = New GroupBox()
        Label4 = New Label()
        txtContact = New TextBox()
        Label3 = New Label()
        txtAddress = New TextBox()
        Label2 = New Label()
        txtAge = New TextBox()
        Label1 = New Label()
        txtName = New TextBox()
        dgvStudents = New DataGridView()
        colID = New DataGridViewTextBoxColumn()
        colName = New DataGridViewTextBoxColumn()
        colAge = New DataGridViewTextBoxColumn()
        colAddress = New DataGridViewTextBoxColumn()
        colContact = New DataGridViewTextBoxColumn()
        colEdit = New DataGridViewButtonColumn()
        colDelete = New DataGridViewButtonColumn()
        btnSave = New Button()
        btnCancel = New Button()
        GroupBox1.SuspendLayout()
        CType(dgvStudents, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(Label4)
        GroupBox1.Controls.Add(txtContact)
        GroupBox1.Controls.Add(Label3)
        GroupBox1.Controls.Add(txtAddress)
        GroupBox1.Controls.Add(Label2)
        GroupBox1.Controls.Add(txtAge)
        GroupBox1.Controls.Add(Label1)
        GroupBox1.Controls.Add(txtName)
        GroupBox1.Location = New Point(12, 12)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(554, 135)
        GroupBox1.TabIndex = 0
        GroupBox1.TabStop = False
        GroupBox1.Text = "Student Details"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(26, 101)
        Label4.Name = "Label4"
        Label4.Size = New Size(49, 15)
        Label4.TabIndex = 7
        Label4.Text = "Contact"
        ' 
        ' txtContact
        ' 
        txtContact.Location = New Point(79, 98)
        txtContact.Name = "txtContact"
        txtContact.Size = New Size(303, 23)
        txtContact.TabIndex = 3
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(26, 75)
        Label3.Name = "Label3"
        Label3.Size = New Size(49, 15)
        Label3.TabIndex = 5
        Label3.Text = "Address"
        ' 
        ' txtAddress
        ' 
        txtAddress.Location = New Point(79, 72)
        txtAddress.Name = "txtAddress"
        txtAddress.Size = New Size(303, 23)
        txtAddress.TabIndex = 2
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(26, 49)
        Label2.Name = "Label2"
        Label2.Size = New Size(28, 15)
        Label2.TabIndex = 3
        Label2.Text = "Age"
        ' 
        ' txtAge
        ' 
        txtAge.Location = New Point(79, 46)
        txtAge.Name = "txtAge"
        txtAge.Size = New Size(92, 23)
        txtAge.TabIndex = 1
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(26, 24)
        Label1.Name = "Label1"
        Label1.Size = New Size(39, 15)
        Label1.TabIndex = 1
        Label1.Text = "Name"
        ' 
        ' txtName
        ' 
        txtName.Location = New Point(79, 21)
        txtName.Name = "txtName"
        txtName.Size = New Size(303, 23)
        txtName.TabIndex = 0
        ' 
        ' dgvStudents
        ' 
        dgvStudents.AllowUserToAddRows = False
        dgvStudents.AllowUserToDeleteRows = False
        dgvStudents.AllowUserToOrderColumns = True
        dgvStudents.AllowUserToResizeColumns = False
        dgvStudents.AllowUserToResizeRows = False
        dgvStudents.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvStudents.Columns.AddRange(New DataGridViewColumn() {colID, colName, colAge, colAddress, colContact, colEdit, colDelete})
        dgvStudents.Location = New Point(12, 183)
        dgvStudents.Name = "dgvStudents"
        dgvStudents.Size = New Size(554, 233)
        dgvStudents.TabIndex = 6
        ' 
        ' colID
        ' 
        colID.DataPropertyName = "ID"
        colID.Frozen = True
        colID.HeaderText = "ID"
        colID.Name = "colID"
        colID.ReadOnly = True
        colID.Visible = False
        ' 
        ' colName
        ' 
        colName.DataPropertyName = "Name"
        colName.Frozen = True
        colName.HeaderText = "Name"
        colName.Name = "colName"
        colName.ReadOnly = True
        ' 
        ' colAge
        ' 
        colAge.DataPropertyName = "Age"
        colAge.Frozen = True
        colAge.HeaderText = "Age"
        colAge.Name = "colAge"
        colAge.ReadOnly = True
        ' 
        ' colAddress
        ' 
        colAddress.DataPropertyName = "Address"
        colAddress.Frozen = True
        colAddress.HeaderText = "Address"
        colAddress.Name = "colAddress"
        colAddress.ReadOnly = True
        ' 
        ' colContact
        ' 
        colContact.DataPropertyName = "Contact"
        colContact.Frozen = True
        colContact.HeaderText = "Contact"
        colContact.Name = "colContact"
        colContact.ReadOnly = True
        ' 
        ' colEdit
        ' 
        colEdit.HeaderText = "Edit"
        colEdit.Name = "colEdit"
        colEdit.Text = "Edit"
        colEdit.UseColumnTextForButtonValue = True
        colEdit.Width = 50
        ' 
        ' colDelete
        ' 
        colDelete.HeaderText = "Delete"
        colDelete.Name = "colDelete"
        colDelete.Text = "Delete"
        colDelete.UseColumnTextForButtonValue = True
        colDelete.Width = 50
        ' 
        ' btnSave
        ' 
        btnSave.Location = New Point(410, 154)
        btnSave.Name = "btnSave"
        btnSave.Size = New Size(75, 23)
        btnSave.TabIndex = 4
        btnSave.Text = "Save"
        btnSave.UseVisualStyleBackColor = True
        ' 
        ' btnCancel
        ' 
        btnCancel.Location = New Point(491, 154)
        btnCancel.Name = "btnCancel"
        btnCancel.Size = New Size(75, 23)
        btnCancel.TabIndex = 5
        btnCancel.Text = "Cancel"
        btnCancel.UseVisualStyleBackColor = True
        ' 
        ' FStudents
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(578, 428)
        Controls.Add(btnCancel)
        Controls.Add(btnSave)
        Controls.Add(dgvStudents)
        Controls.Add(GroupBox1)
        FormBorderStyle = FormBorderStyle.FixedToolWindow
        Name = "FStudents"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Student Entry Form"
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        CType(dgvStudents, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents dgvStudents As DataGridView
    Friend WithEvents btnSave As Button
    Friend WithEvents btnCancel As Button
    Friend WithEvents colID As DataGridViewTextBoxColumn
    Friend WithEvents colName As DataGridViewTextBoxColumn
    Friend WithEvents colAge As DataGridViewTextBoxColumn
    Friend WithEvents colAddress As DataGridViewTextBoxColumn
    Friend WithEvents colContact As DataGridViewTextBoxColumn
    Friend WithEvents colEdit As DataGridViewButtonColumn
    Friend WithEvents colDelete As DataGridViewButtonColumn
    Friend WithEvents Label4 As Label
    Friend WithEvents txtContact As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtAddress As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtAge As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtName As TextBox

End Class
