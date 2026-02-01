<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class DashboardForm
    Inherits System.Windows.Forms.Form

    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    Private components As System.ComponentModel.IContainer

    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.btnPatients = New System.Windows.Forms.Button()
        Me.btnDoctors = New System.Windows.Forms.Button()
        Me.btnAppointments = New System.Windows.Forms.Button()
        Me.btnBilling = New System.Windows.Forms.Button()
        Me.btnLogout = New System.Windows.Forms.Button()
        Me.SuspendLayout()

        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Segoe UI", 20.0!, System.Drawing.FontStyle.Bold)
        Me.lblTitle.Location = New System.Drawing.Point(200, 30)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(150, 37)
        Me.lblTitle.TabIndex = 0
        Me.lblTitle.Text = "Dashboard"

        Me.btnPatients.BackColor = System.Drawing.Color.LightGreen
        Me.btnPatients.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.btnPatients.Location = New System.Drawing.Point(100, 100)
        Me.btnPatients.Name = "btnPatients"
        Me.btnPatients.Size = New System.Drawing.Size(180, 80)
        Me.btnPatients.TabIndex = 1
        Me.btnPatients.Text = "Patients"
        Me.btnPatients.UseVisualStyleBackColor = False

        Me.btnDoctors.BackColor = System.Drawing.Color.LightBlue
        Me.btnDoctors.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.btnDoctors.Location = New System.Drawing.Point(320, 100)
        Me.btnDoctors.Name = "btnDoctors"
        Me.btnDoctors.Size = New System.Drawing.Size(180, 80)
        Me.btnDoctors.TabIndex = 2
        Me.btnDoctors.Text = "Doctors"
        Me.btnDoctors.UseVisualStyleBackColor = False

        Me.btnAppointments.BackColor = System.Drawing.Color.LightCoral
        Me.btnAppointments.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.btnAppointments.Location = New System.Drawing.Point(100, 210)
        Me.btnAppointments.Name = "btnAppointments"
        Me.btnAppointments.Size = New System.Drawing.Size(180, 80)
        Me.btnAppointments.TabIndex = 3
        Me.btnAppointments.Text = "Appointments"
        Me.btnAppointments.UseVisualStyleBackColor = False

        Me.btnBilling.BackColor = System.Drawing.Color.LightGoldenrodYellow
        Me.btnBilling.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.btnBilling.Location = New System.Drawing.Point(320, 210)
        Me.btnBilling.Name = "btnBilling"
        Me.btnBilling.Size = New System.Drawing.Size(180, 80)
        Me.btnBilling.TabIndex = 4
        Me.btnBilling.Text = "Billing"
        Me.btnBilling.UseVisualStyleBackColor = False

        Me.btnLogout.BackColor = System.Drawing.Color.LightGray
        Me.btnLogout.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.btnLogout.Location = New System.Drawing.Point(250, 320)
        Me.btnLogout.Name = "btnLogout"
        Me.btnLogout.Size = New System.Drawing.Size(100, 35)
        Me.btnLogout.TabIndex = 5
        Me.btnLogout.Text = "Logout"
        Me.btnLogout.UseVisualStyleBackColor = False

        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(600, 400)
        Me.Controls.Add(Me.btnLogout)
        Me.Controls.Add(Me.btnBilling)
        Me.Controls.Add(Me.btnAppointments)
        Me.Controls.Add(Me.btnDoctors)
        Me.Controls.Add(Me.btnPatients)
        Me.Controls.Add(Me.lblTitle)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.Name = "DashboardForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Dashboard"
        Me.ResumeLayout(False)
        Me.PerformLayout()
    End Sub

    Friend WithEvents lblTitle As Label
    Friend WithEvents btnPatients As Button
    Friend WithEvents btnDoctors As Button
    Friend WithEvents btnAppointments As Button
    Friend WithEvents btnBilling As Button
    Friend WithEvents btnLogout As Button
End Class
