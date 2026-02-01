Public Class DoctorForm
    Private Sub DoctorForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadDoctors()
    End Sub

    Private Sub LoadDoctors()
        Try
            Dim query = "SELECT * FROM doctors"
            dgvDoctors.DataSource = DatabaseHelper.ExecuteQuery(query)
        Catch ex As Exception
            MessageBox.Show("Error loading doctors: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        If String.IsNullOrEmpty(txtName.Text) Or String.IsNullOrEmpty(txtSpecialty.Text) Then
            MessageBox.Show("Please fill all required fields", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        Try
            Dim query = "INSERT INTO doctors (name, specialty, phone) VALUES (@name, @specialty, @phone)"
            Dim params As New Dictionary(Of String, Object) From {
                {"@name", txtName.Text},
                {"@specialty", txtSpecialty.Text},
                {"@phone", txtPhone.Text}
            }
            DatabaseHelper.ExecuteNonQuery(query, params)
            MessageBox.Show("Doctor added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            ClearFields()
            LoadDoctors()
        Catch ex As Exception
            MessageBox.Show("Error adding doctor: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        If String.IsNullOrEmpty(txtID.Text) Then
            MessageBox.Show("Please select a doctor to edit", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        Try
            Dim query = "UPDATE doctors SET name=@name, specialty=@specialty, phone=@phone WHERE id=@id"
            Dim params As New Dictionary(Of String, Object) From {
                {"@id", txtID.Text},
                {"@name", txtName.Text},
                {"@specialty", txtSpecialty.Text},
                {"@phone", txtPhone.Text}
            }
            DatabaseHelper.ExecuteNonQuery(query, params)
            MessageBox.Show("Doctor updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            ClearFields()
            LoadDoctors()
        Catch ex As Exception
            MessageBox.Show("Error updating doctor: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        If String.IsNullOrEmpty(txtID.Text) Then
            MessageBox.Show("Please select a doctor to delete", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        Dim result = MessageBox.Show("Are you sure you want to delete this doctor?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If result = DialogResult.Yes Then
            Try
                Dim query = "DELETE FROM doctors WHERE id=@id"
                Dim params As New Dictionary(Of String, Object) From {{"@id", txtID.Text}}
                DatabaseHelper.ExecuteNonQuery(query, params)
                MessageBox.Show("Doctor deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                ClearFields()
                LoadDoctors()
            Catch ex As Exception
                MessageBox.Show("Error deleting doctor: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        ClearFields()
    End Sub

    Private Sub ClearFields()
        txtID.Clear()
        txtName.Clear()
        txtSpecialty.Clear()
        txtPhone.Clear()
    End Sub

    Private Sub dgvDoctors_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvDoctors.CellClick
        If e.RowIndex >= 0 Then
            Dim row = dgvDoctors.Rows(e.RowIndex)
            txtID.Text = row.Cells("id").Value.ToString()
            txtName.Text = row.Cells("name").Value.ToString()
            txtSpecialty.Text = row.Cells("specialty").Value.ToString()
            txtPhone.Text = row.Cells("phone").Value.ToString()
        End If
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Me.Close()
    End Sub
End Class
