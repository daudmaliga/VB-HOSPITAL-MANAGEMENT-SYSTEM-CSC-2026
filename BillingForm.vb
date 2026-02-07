Public Class BillingForm
    Private Sub BillingForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadPatients()
        LoadBilling()
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

    Private Sub LoadBilling()
        Try
            Dim query = "SELECT b.id, p.name AS patient_name, b.amount, b.payment_status, b.billing_date " &
                       "FROM billing b " &
                       "JOIN patients p ON b.patient_id = p.id"
            dgvBilling.DataSource = DatabaseHelper.ExecuteQuery(query)
        Catch ex As Exception
            MessageBox.Show("Error loading billing: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        If cmbPatient.SelectedIndex = -1 Or String.IsNullOrEmpty(txtAmount.Text) Then
            MessageBox.Show("Please fill all required fields", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        Try
            Dim query = "INSERT INTO billing (patient_id, amount, payment_status, billing_date) VALUES (@patient_id, @amount, @status, @date)"
            Dim params As New Dictionary(Of String, Object) From {
                {"@patient_id", cmbPatient.SelectedValue},
                {"@amount", txtAmount.Text},
                {"@status", cmbPaymentStatus.Text},
                {"@date", dtpBilling.Value.ToString("yyyy-MM-dd")}
            }
            DatabaseHelper.ExecuteNonQuery(query, params)
            MessageBox.Show("Bill added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            ClearFields()
            LoadBilling()
        Catch ex As Exception
            MessageBox.Show("Error adding bill: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        If String.IsNullOrEmpty(txtID.Text) Then
            MessageBox.Show("Please select a bill to edit", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        Try
            Dim query = "UPDATE billing SET patient_id=@patient_id, amount=@amount, payment_status=@status, billing_date=@date WHERE id=@id"
            Dim params As New Dictionary(Of String, Object) From {
                {"@id", txtID.Text},
                {"@patient_id", cmbPatient.SelectedValue},
                {"@amount", txtAmount.Text},
                {"@status", cmbPaymentStatus.Text},
                {"@date", dtpBilling.Value.ToString("yyyy-MM-dd")}
            }
            DatabaseHelper.ExecuteNonQuery(query, params)
            MessageBox.Show("Bill updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            ClearFields()
            LoadBilling()
        Catch ex As Exception
            MessageBox.Show("Error updating bill: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        If String.IsNullOrEmpty(txtID.Text) Then
            MessageBox.Show("Please select a bill to delete", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        Dim result = MessageBox.Show("Are you sure you want to delete this bill?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If result = DialogResult.Yes Then
            Try
                Dim query = "DELETE FROM billing WHERE id=@id"
                Dim params As New Dictionary(Of String, Object) From {{"@id", txtID.Text}}
                DatabaseHelper.ExecuteNonQuery(query, params)
                MessageBox.Show("Bill deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                ClearFields()
                LoadBilling()
            Catch ex As Exception
                MessageBox.Show("Error deleting bill: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        ClearFields()
    End Sub

    Private Sub ClearFields()
        txtID.Clear()
        cmbPatient.SelectedIndex = -1
        txtAmount.Clear()
        cmbPaymentStatus.SelectedIndex = -1
        dtpBilling.Value = DateTime.Now
    End Sub

    Private Sub dgvBilling_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvBilling.CellClick
        If e.RowIndex >= 0 Then
            Dim row = dgvBilling.Rows(e.RowIndex)
            txtID.Text = row.Cells("id").Value.ToString()
            cmbPatient.Text = row.Cells("patient_name").Value.ToString()
            txtAmount.Text = row.Cells("amount").Value.ToString()
            cmbPaymentStatus.Text = row.Cells("payment_status").Value.ToString()
            dtpBilling.Value = Convert.ToDateTime(row.Cells("billing_date").Value)
        End If
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Me.Close()
    End Sub

    Private Sub dgvBilling_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvBilling.CellContentClick

    End Sub
End Class
