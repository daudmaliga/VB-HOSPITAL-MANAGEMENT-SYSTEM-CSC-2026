<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class PatientForm
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
        Me.lblName = New System.Windows.Forms.Label()
        Me.lblAge = New System.Windows.Forms.Label()
        Me.lblGender = New System.Windows.Forms.Label()
        Me.lblPhone = New System.Windows.Forms.Label()
        Me.lblMedicalHistory = New System.Windows.Forms.Label()
        Me.txtID = New System.Windows.Forms.TextBox()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.txtAge = New System.Windows.Forms.TextBox()
        Me.txtPhone = New System.Windows.Forms.TextBox()
        Me.txtMedicalHistory = New System.Windows.Forms.TextBox()
        Me.cmbGender = New System.Windows.Forms.ComboBox()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.btnEdit = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.dgvPatients = New System.Windows.Forms.DataGridView()
        Me.btnBack = New System.Windows.Forms.Button()
        CType(Me.dgvPatients, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()

        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Segoe UI", 16.0!, System.Drawing.FontStyle.Bold)
        Me.lblTitle.Location = New System.Drawing.Point(300, 15)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(220, 30)
        Me.lblTitle.TabIndex = 0
        Me.lblTitle.Text = "Patient Management"

        Me.lblID.AutoSize = True
        Me.lblID.Location = New System.Drawing.Point(30, 70)
        Me.lblID.Name = "lblID"
        Me.lblID.Size = New System.Drawing.Size(60, 15)
        Me.lblID.TabIndex = 1
        Me.lblID.Text = "Patient ID:"

        Me.lblName.AutoSize = True
        Me.lblName.Location = New System.Drawing.Point(30, 105)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(42, 15)
        Me.lblName.TabIndex = 2
        Me.lblName.Text = "Name:"

        Me.lblAge.AutoSize = True
        Me.lblAge.Location = New System.Drawing.Point(30, 140)
        Me.lblAge.Name = "lblAge"
        Me.lblAge.Size = New System.Drawing.Size(28, 15)
        Me.lblAge.TabIndex = 3
        Me.lblAge.Text = "Age:"

        Me.lblGender.AutoSize = True
        Me.lblGender.Location = New System.Drawing.Point(30, 175)
        Me.lblGender.Name = "lblGender"
        Me.lblGender.Size = New System.Drawing.Size(48, 15)
        Me.lblGender.TabIndex = 4
        Me.lblGender.Text = "Gender:"

        Me.lblPhone.AutoSize = True
        Me.lblPhone.Location = New System.Drawing.Point(30, 210)
        Me.lblPhone.Name = "lblPhone"
        Me.lblPhone.Size = New System.Drawing.Size(44, 15)
        Me.lblPhone.TabIndex = 5
        Me.lblPhone.Text = "Phone:"

        Me.lblMedicalHistory.AutoSize = True
        Me.lblMedicalHistory.Location = New System.Drawing.Point(30, 245)
        Me.lblMedicalHistory.Name = "lblMedicalHistory"
        Me.lblMedicalHistory.Size = New System.Drawing.Size(95, 15)
        Me.lblMedicalHistory.TabIndex = 6
        Me.lblMedicalHistory.Text = "Medical History:"

        Me.txtID.Location = New System.Drawing.Point(150, 67)
        Me.txtID.Name = "txtID"
        Me.txtID.ReadOnly = True
        Me.txtID.Size = New System.Drawing.Size(200, 23)
        Me.txtID.TabIndex = 7

        Me.txtName.Location = New System.Drawing.Point(150, 102)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(200, 23)
        Me.txtName.TabIndex = 8

        Me.txtAge.Location = New System.Drawing.Point(150, 137)
        Me.txtAge.Name = "txtAge"
        Me.txtAge.Size = New System.Drawing.Size(200, 23)
        Me.txtAge.TabIndex = 9

        Me.cmbGender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbGender.FormattingEnabled = True
        Me.cmbGender.Items.AddRange(New Object() {"Male", "Female", "Other"})
        Me.cmbGender.Location = New System.Drawing.Point(150, 172)
        Me.cmbGender.Name = "cmbGender"
        Me.cmbGender.Size = New System.Drawing.Size(200, 23)
        Me.cmbGender.TabIndex = 10

        Me.txtPhone.Location = New System.Drawing.Point(150, 207)
        Me.txtPhone.Name = "txtPhone"
        Me.txtPhone.Size = New System.Drawing.Size(200, 23)
        Me.txtPhone.TabIndex = 11

        Me.txtMedicalHistory.Location = New System.Drawing.Point(150, 242)
        Me.txtMedicalHistory.Multiline = True
        Me.txtMedicalHistory.Name = "txtMedicalHistory"
        Me.txtMedicalHistory.Size = New System.Drawing.Size(200, 60)
        Me.txtMedicalHistory.TabIndex = 12

        Me.btnAdd.BackColor = System.Drawing.Color.LightGreen
        Me.btnAdd.Location = New System.Drawing.Point(30, 320)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(75, 30)
        Me.btnAdd.TabIndex = 13
        Me.btnAdd.Text = "Add"
        Me.btnAdd.UseVisualStyleBackColor = False

        Me.btnEdit.BackColor = System.Drawing.Color.LightBlue
        Me.btnEdit.Location = New System.Drawing.Point(120, 320)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(75, 30)
        Me.btnEdit.TabIndex = 14
        Me.btnEdit.Text = "Edit"
        Me.btnEdit.UseVisualStyleBackColor = False

        Me.btnDelete.BackColor = System.Drawing.Color.LightCoral
        Me.btnDelete.Location = New System.Drawing.Point(210, 320)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(75, 30)
        Me.btnDelete.TabIndex = 15
        Me.btnDelete.Text = "Delete"
        Me.btnDelete.UseVisualStyleBackColor = False

        Me.btnClear.BackColor = System.Drawing.Color.LightGray
        Me.btnClear.Location = New System.Drawing.Point(300, 320)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(75, 30)
        Me.btnClear.TabIndex = 16
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = False

        Me.dgvPatients.AllowUserToAddRows = False
        Me.dgvPatients.AllowUserToDeleteRows = False
        Me.dgvPatients.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvPatients.Location = New System.Drawing.Point(400, 70)
        Me.dgvPatients.Name = "dgvPatients"
        Me.dgvPatients.ReadOnly = True
        Me.dgvPatients.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvPatients.Size = New System.Drawing.Size(450, 280)
        Me.dgvPatients.TabIndex = 17

        Me.btnBack.Location = New System.Drawing.Point(30, 370)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(100, 30)
        Me.btnBack.TabIndex = 18
        Me.btnBack.Text = "Back"
        Me.btnBack.UseVisualStyleBackColor = True

        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(880, 420)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.dgvPatients)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.btnEdit)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.txtMedicalHistory)
        Me.Controls.Add(Me.txtPhone)
        Me.Controls.Add(Me.cmbGender)
        Me.Controls.Add(Me.txtAge)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.txtID)
        Me.Controls.Add(Me.lblMedicalHistory)
        Me.Controls.Add(Me.lblPhone)
        Me.Controls.Add(Me.lblGender)
        Me.Controls.Add(Me.lblAge)
        Me.Controls.Add(Me.lblName)
        Me.Controls.Add(Me.lblID)
        Me.Controls.Add(Me.lblTitle)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.Name = "PatientForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Patient Management"
        CType(Me.dgvPatients, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()
    End Sub

    Friend WithEvents lblTitle As Label
    Friend WithEvents lblID As Label
    Friend WithEvents lblName As Label
    Friend WithEvents lblAge As Label
    Friend WithEvents lblGender As Label
    Friend WithEvents lblPhone As Label
    Friend WithEvents lblMedicalHistory As Label
    Friend WithEvents txtID As TextBox
    Friend WithEvents txtName As TextBox
    Friend WithEvents txtAge As TextBox
    Friend WithEvents txtPhone As TextBox
    Friend WithEvents txtMedicalHistory As TextBox
    Friend WithEvents cmbGender As ComboBox
    Friend WithEvents btnAdd As Button
    Friend WithEvents btnEdit As Button
    Friend WithEvents btnDelete As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents dgvPatients As DataGridView
    Friend WithEvents btnBack As Button
End Class
