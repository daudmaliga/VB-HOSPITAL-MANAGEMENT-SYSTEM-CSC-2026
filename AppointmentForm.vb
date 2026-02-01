Public Class AppointmentForm
    Private Sub AppointmentForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadPatients()
        LoadDoctors()
        LoadAppointments()
    End Sub

    Private Sub LoadPatients()
        Try
            Dim query = "SELECT id, name FROM patients"
            Dim dt = DatabaseHelper.ExecuteQuery(query)
            cmbPatient.DataSource = dt
            cmbPatient.DisplayMember = "name"
            cmbPatient.ValueMember = "id"
            cmbPatient.SelectedIndex = -1
        Catch ex As Exception
            MessageBox.Show("Error loading patients: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub LoadDoctors()
        Try
            Dim query = "SELECT id, name FROM doctors"
            Dim dt = DatabaseHelper.ExecuteQuery(query)
            cmbDoctor.DataSource = dt
            cmbDoctor.DisplayMember = "name"
            cmbDoctor.ValueMember = "id"
            cmbDoctor.SelectedIndex = -1
        Catch ex As Exception
            MessageBox.Show("Error loading doctors: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub LoadAppointments()
        Try
            Dim query = "SELECT a.id, p.name AS patient_name, d.name AS doctor_name, a.appointment_date " &
                       "FROM appointments a " &
                       "JOIN patients p ON a.patient_id = p.id " &
                       "JOIN doctors d ON a.doctor_id = d.id"
            dgvAppointments.DataSource = DatabaseHelper.ExecuteQuery(query)
        Catch ex As Exception
            MessageBox.Show("Error loading appointments: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        If cmbPatient.SelectedIndex = -1 Or cmbDoctor.SelectedIndex = -1 Then
            MessageBox.Show("Please select patient and doctor", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        Try
            Dim query = "INSERT INTO appointments (patient_id, doctor_id, appointment_date) VALUES (@patient_id, @doctor_id, @date)"
            Dim params As New Dictionary(Of String, Object) From {
                {"@patient_id", cmbPatient.SelectedValue},
                {"@doctor_id", cmbDoctor.SelectedValue},
                {"@date", dtpAppointment.Value.ToString("yyyy-MM-dd")}
            }
            DatabaseHelper.ExecuteNonQuery(query, params)
            MessageBox.Show("Appointment added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            ClearFields()
            LoadAppointments()
        Catch ex As Exception
            MessageBox.Show("Error adding appointment: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        If String.IsNullOrEmpty(txtID.Text) Then
            MessageBox.Show("Please select an appointment to edit", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        Try
            Dim query = "UPDATE appointments SET patient_id=@patient_id, doctor_id=@doctor_id, appointment_date=@date WHERE id=@id"
            Dim params As New Dictionary(Of String, Object) From {
                {"@id", txtID.Text},
                {"@patient_id", cmbPatient.SelectedValue},
                {"@doctor_id", cmbDoctor.SelectedValue},
                {"@date", dtpAppointment.Value.ToString("yyyy-MM-dd")}
            }
            DatabaseHelper.ExecuteNonQuery(query, params)
            MessageBox.Show("Appointment updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            ClearFields()
            LoadAppointments()
        Catch ex As Exception
            MessageBox.Show("Error updating appointment: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        If String.IsNullOrEmpty(txtID.Text) Then
            MessageBox.Show("Please select an appointment to delete", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        Dim result = MessageBox.Show("Are you sure you want to delete this appointment?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If result = DialogResult.Yes Then
            Try
                Dim query = "DELETE FROM appointments WHERE id=@id"
                Dim params As New Dictionary(Of String, Object) From {{"@id", txtID.Text}}
                DatabaseHelper.ExecuteNonQuery(query, params)
                MessageBox.Show("Appointment deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                ClearFields()
                LoadAppointments()
            Catch ex As Exception
                MessageBox.Show("Error deleting appointment: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        ClearFields()
    End Sub

    Private Sub ClearFields()
        txtID.Clear()
        cmbPatient.SelectedIndex = -1
        cmbDoctor.SelectedIndex = -1
        dtpAppointment.Value = DateTime.Now
    End Sub

    Private Sub dgvAppointments_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvAppointments.CellClick
        If e.RowIndex >= 0 Then
            Dim row = dgvAppointments.Rows(e.RowIndex)
            txtID.Text = row.Cells("id").Value.ToString()
            cmbPatient.Text = row.Cells("patient_name").Value.ToString()
            cmbDoctor.Text = row.Cells("doctor_name").Value.ToString()
            dtpAppointment.Value = Convert.ToDateTime(row.Cells("appointment_date").Value)
        End If
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Me.Close()
    End Sub
End Class
