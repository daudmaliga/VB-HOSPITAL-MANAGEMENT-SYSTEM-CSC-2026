Public Class DashboardForm
    Private Sub btnPatients_Click(sender As Object, e As EventArgs) Handles btnPatients.Click
        Dim patientForm As New PatientForm()
        patientForm.ShowDialog()
    End Sub

    Private Sub btnDoctors_Click(sender As Object, e As EventArgs) Handles btnDoctors.Click
        Dim doctorForm As New DoctorForm()
        doctorForm.ShowDialog()
    End Sub

    Private Sub btnAppointments_Click(sender As Object, e As EventArgs) Handles btnAppointments.Click
        Dim appointmentForm As New AppointmentForm()
        appointmentForm.ShowDialog()
    End Sub

    Private Sub btnBilling_Click(sender As Object, e As EventArgs) Handles btnBilling.Click
        Dim billingForm As New BillingForm()
        billingForm.ShowDialog()
    End Sub

    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        Dim result = MessageBox.Show("Are you sure you want to logout?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If result = DialogResult.Yes Then
            Dim loginForm As New LoginForm()
            loginForm.Show()
            Me.Close()
        End If
    End Sub
End Class
