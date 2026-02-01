Public Class PatientForm
    Private Sub PatientForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadPatients()
    End Sub

    Private Sub LoadPatients()
        Try
            Dim query = "SELECT * FROM patients"
            dgvPatients.DataSource = DatabaseHelper.ExecuteQuery(query)
        Catch ex As Exception
            MessageBox.Show("Error loading patients: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        If String.IsNullOrEmpty(txtName.Text) Or String.IsNullOrEmpty(txtAge.Text) Then
            MessageBox.Show("Please fill all required fields", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        Try
            Dim query = "INSERT INTO patients (name, age, gender, phone, medical_history) VALUES (@name, @age, @gender, @phone, @history)"
            Dim params As New Dictionary(Of String, Object) From {
                {"@name", txtName.Text},
                {"@age", txtAge.Text},
                {"@gender", cmbGender.Text},
                {"@phone", txtPhone.Text},
                {"@history", txtMedicalHistory.Text}
            }
            DatabaseHelper.ExecuteNonQuery(query, params)
            MessageBox.Show("Patient added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            ClearFields()
            LoadPatients()
        Catch ex As Exception
            MessageBox.Show("Error adding patient: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        If String.IsNullOrEmpty(txtID.Text) Then
            MessageBox.Show("Please select a patient to edit", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        Try
            Dim query = "UPDATE patients SET name=@name, age=@age, gender=@gender, phone=@phone, medical_history=@history WHERE id=@id"
            Dim params As New Dictionary(Of String, Object) From {
                {"@id", txtID.Text},
                {"@name", txtName.Text},
                {"@age", txtAge.Text},
                {"@gender", cmbGender.Text},
                {"@phone", txtPhone.Text},
                {"@history", txtMedicalHistory.Text}
            }
            DatabaseHelper.ExecuteNonQuery(query, params)
            MessageBox.Show("Patient updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            ClearFields()
            LoadPatients()
        Catch ex As Exception
            MessageBox.Show("Error updating patient: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        If String.IsNullOrEmpty(txtID.Text) Then
            MessageBox.Show("Please select a patient to delete", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        Dim result = MessageBox.Show("Are you sure you want to delete this patient?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If result = DialogResult.Yes Then
            Try
                Dim query = "DELETE FROM patients WHERE id=@id"
                Dim params As New Dictionary(Of String, Object) From {{"@id", txtID.Text}}
                DatabaseHelper.ExecuteNonQuery(query, params)
                MessageBox.Show("Patient deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                ClearFields()
                LoadPatients()
            Catch ex As Exception
                MessageBox.Show("Error deleting patient: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        ClearFields()
    End Sub

    Private Sub ClearFields()
        txtID.Clear()
        txtName.Clear()
        txtAge.Clear()
        cmbGender.SelectedIndex = -1
        txtPhone.Clear()
        txtMedicalHistory.Clear()
    End Sub

    Private Sub dgvPatients_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvPatients.CellClick
        If e.RowIndex >= 0 Then
            Dim row = dgvPatients.Rows(e.RowIndex)
            txtID.Text = row.Cells("id").Value.ToString()
            txtName.Text = row.Cells("name").Value.ToString()
            txtAge.Text = row.Cells("age").Value.ToString()
            cmbGender.Text = row.Cells("gender").Value.ToString()
            txtPhone.Text = row.Cells("phone").Value.ToString()
            txtMedicalHistory.Text = row.Cells("medical_history").Value.ToString()
        End If
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Me.Close()
    End Sub
End Class
