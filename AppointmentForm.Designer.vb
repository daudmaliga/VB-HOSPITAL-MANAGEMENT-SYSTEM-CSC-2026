<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class AppointmentForm
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
        Me.lblID = New System.Windows.Forms.Label()
        Me.lblPatient = New System.Windows.Forms.Label()
        Me.lblDoctor = New System.Windows.Forms.Label()
        Me.lblDate = New System.Windows.Forms.Label()
        Me.txtID = New System.Windows.Forms.TextBox()
        Me.cmbPatient = New System.Windows.Forms.ComboBox()
        Me.cmbDoctor = New System.Windows.Forms.ComboBox()
        Me.dtpAppointment = New System.Windows.Forms.DateTimePicker()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.btnEdit = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.dgvAppointments = New System.Windows.Forms.DataGridView()
        Me.btnBack = New System.Windows.Forms.Button()
        CType(Me.dgvAppointments, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()

        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Segoe UI", 16.0!, System.Drawing.FontStyle.Bold)
        Me.lblTitle.Location = New System.Drawing.Point(280, 15)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(280, 30)
        Me.lblTitle.TabIndex = 0
        Me.lblTitle.Text = "Appointment Management"

        Me.lblID.AutoSize = True
        Me.lblID.Location = New System.Drawing.Point(30, 70)
        Me.lblID.Name = "lblID"
        Me.lblID.Size = New System.Drawing.Size(96, 15)
        Me.lblID.TabIndex = 1
        Me.lblID.Text = "Appointment ID:"

        Me.lblPatient.AutoSize = True
        Me.lblPatient.Location = New System.Drawing.Point(30, 110)
        Me.lblPatient.Name = "lblPatient"
        Me.lblPatient.Size = New System.Drawing.Size(47, 15)
        Me.lblPatient.TabIndex = 2
        Me.lblPatient.Text = "Patient:"

        Me.lblDoctor.AutoSize = True
        Me.lblDoctor.Location = New System.Drawing.Point(30, 150)
        Me.lblDoctor.Name = "lblDoctor"
        Me.lblDoctor.Size = New System.Drawing.Size(46, 15)
        Me.lblDoctor.TabIndex = 3
        Me.lblDoctor.Text = "Doctor:"

        Me.lblDate.AutoSize = True
        Me.lblDate.Location = New System.Drawing.Point(30, 190)
        Me.lblDate.Name = "lblDate"
        Me.lblDate.Size = New System.Drawing.Size(34, 15)
        Me.lblDate.TabIndex = 4
        Me.lblDate.Text = "Date:"

        Me.txtID.Location = New System.Drawing.Point(150, 67)
        Me.txtID.Name = "txtID"
        Me.txtID.ReadOnly = True
        Me.txtID.Size = New System.Drawing.Size(200, 23)
        Me.txtID.TabIndex = 5

        Me.cmbPatient.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbPatient.FormattingEnabled = True
        Me.cmbPatient.Location = New System.Drawing.Point(150, 107)
        Me.cmbPatient.Name = "cmbPatient"
        Me.cmbPatient.Size = New System.Drawing.Size(200, 23)
        Me.cmbPatient.TabIndex = 6

        Me.cmbDoctor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbDoctor.FormattingEnabled = True
        Me.cmbDoctor.Location = New System.Drawing.Point(150, 147)
        Me.cmbDoctor.Name = "cmbDoctor"
        Me.cmbDoctor.Size = New System.Drawing.Size(200, 23)
        Me.cmbDoctor.TabIndex = 7

        Me.dtpAppointment.Format = System.Windows.Forms.DateTimePickerFormat.Short
        Me.dtpAppointment.Location = New System.Drawing.Point(150, 187)
        Me.dtpAppointment.Name = "dtpAppointment"
        Me.dtpAppointment.Size = New System.Drawing.Size(200, 23)
        Me.dtpAppointment.TabIndex = 8

        Me.btnAdd.BackColor = System.Drawing.Color.LightGreen
        Me.btnAdd.Location = New System.Drawing.Point(30, 240)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(75, 30)
        Me.btnAdd.TabIndex = 9
        Me.btnAdd.Text = "Add"
        Me.btnAdd.UseVisualStyleBackColor = False

        Me.btnEdit.BackColor = System.Drawing.Color.LightBlue
        Me.btnEdit.Location = New System.Drawing.Point(120, 240)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(75, 30)
        Me.btnEdit.TabIndex = 10
        Me.btnEdit.Text = "Edit"
        Me.btnEdit.UseVisualStyleBackColor = False

        Me.btnDelete.BackColor = System.Drawing.Color.LightCoral
        Me.btnDelete.Location = New System.Drawing.Point(210, 240)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(75, 30)
        Me.btnDelete.TabIndex = 11
        Me.btnDelete.Text = "Delete"
        Me.btnDelete.UseVisualStyleBackColor = False

        Me.btnClear.BackColor = System.Drawing.Color.LightGray
        Me.btnClear.Location = New System.Drawing.Point(300, 240)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(75, 30)
        Me.btnClear.TabIndex = 12
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = False

        Me.dgvAppointments.AllowUserToAddRows = False
        Me.dgvAppointments.AllowUserToDeleteRows = False
        Me.dgvAppointments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvAppointments.Location = New System.Drawing.Point(400, 70)
        Me.dgvAppointments.Name = "dgvAppointments"
        Me.dgvAppointments.ReadOnly = True
        Me.dgvAppointments.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvAppointments.Size = New System.Drawing.Size(450, 280)
        Me.dgvAppointments.TabIndex = 13

        Me.btnBack.Location = New System.Drawing.Point(30, 290)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(100, 30)
        Me.btnBack.TabIndex = 14
        Me.btnBack.Text = "Back"
        Me.btnBack.UseVisualStyleBackColor = True

        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(880, 370)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.dgvAppointments)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.btnEdit)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.dtpAppointment)
        Me.Controls.Add(Me.cmbDoctor)
        Me.Controls.Add(Me.cmbPatient)
        Me.Controls.Add(Me.txtID)
        Me.Controls.Add(Me.lblDate)
        Me.Controls.Add(Me.lblDoctor)
        Me.Controls.Add(Me.lblPatient)
        Me.Controls.Add(Me.lblID)
        Me.Controls.Add(Me.lblTitle)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.Name = "AppointmentForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Appointment Management"
        CType(Me.dgvAppointments, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()
    End Sub

    Friend WithEvents lblTitle As Label
    Friend WithEvents lblID As Label
    Friend WithEvents lblPatient As Label
    Friend WithEvents lblDoctor As Label
    Friend WithEvents lblDate As Label
    Friend WithEvents txtID As TextBox
    Friend WithEvents cmbPatient As ComboBox
    Friend WithEvents cmbDoctor As ComboBox
    Friend WithEvents dtpAppointment As DateTimePicker
    Friend WithEvents btnAdd As Button
    Friend WithEvents btnEdit As Button
    Friend WithEvents btnDelete As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents dgvAppointments As DataGridView
    Friend WithEvents btnBack As Button
End Class
