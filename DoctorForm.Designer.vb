<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class DoctorForm
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
        Me.lblSpecialty = New System.Windows.Forms.Label()
        Me.lblPhone = New System.Windows.Forms.Label()
        Me.txtID = New System.Windows.Forms.TextBox()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.txtSpecialty = New System.Windows.Forms.TextBox()
        Me.txtPhone = New System.Windows.Forms.TextBox()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.btnEdit = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.dgvDoctors = New System.Windows.Forms.DataGridView()
        Me.btnBack = New System.Windows.Forms.Button()
        CType(Me.dgvDoctors, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()

        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Segoe UI", 16.0!, System.Drawing.FontStyle.Bold)
        Me.lblTitle.Location = New System.Drawing.Point(300, 15)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(220, 30)
        Me.lblTitle.TabIndex = 0
        Me.lblTitle.Text = "Doctor Management"

        Me.lblID.AutoSize = True
        Me.lblID.Location = New System.Drawing.Point(30, 70)
        Me.lblID.Name = "lblID"
        Me.lblID.Size = New System.Drawing.Size(58, 15)
        Me.lblID.TabIndex = 1
        Me.lblID.Text = "Doctor ID:"

        Me.lblName.AutoSize = True
        Me.lblName.Location = New System.Drawing.Point(30, 110)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(42, 15)
        Me.lblName.TabIndex = 2
        Me.lblName.Text = "Name:"

        Me.lblSpecialty.AutoSize = True
        Me.lblSpecialty.Location = New System.Drawing.Point(30, 150)
        Me.lblSpecialty.Name = "lblSpecialty"
        Me.lblSpecialty.Size = New System.Drawing.Size(57, 15)
        Me.lblSpecialty.TabIndex = 3
        Me.lblSpecialty.Text = "Specialty:"

        Me.lblPhone.AutoSize = True
        Me.lblPhone.Location = New System.Drawing.Point(30, 190)
        Me.lblPhone.Name = "lblPhone"
        Me.lblPhone.Size = New System.Drawing.Size(44, 15)
        Me.lblPhone.TabIndex = 4
        Me.lblPhone.Text = "Phone:"

        Me.txtID.Location = New System.Drawing.Point(150, 67)
        Me.txtID.Name = "txtID"
        Me.txtID.ReadOnly = True
        Me.txtID.Size = New System.Drawing.Size(200, 23)
        Me.txtID.TabIndex = 5

        Me.txtName.Location = New System.Drawing.Point(150, 107)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(200, 23)
        Me.txtName.TabIndex = 6

        Me.txtSpecialty.Location = New System.Drawing.Point(150, 147)
        Me.txtSpecialty.Name = "txtSpecialty"
        Me.txtSpecialty.Size = New System.Drawing.Size(200, 23)
        Me.txtSpecialty.TabIndex = 7

        Me.txtPhone.Location = New System.Drawing.Point(150, 187)
        Me.txtPhone.Name = "txtPhone"
        Me.txtPhone.Size = New System.Drawing.Size(200, 23)
        Me.txtPhone.TabIndex = 8

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

        Me.dgvDoctors.AllowUserToAddRows = False
        Me.dgvDoctors.AllowUserToDeleteRows = False
        Me.dgvDoctors.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvDoctors.Location = New System.Drawing.Point(400, 70)
        Me.dgvDoctors.Name = "dgvDoctors"
        Me.dgvDoctors.ReadOnly = True
        Me.dgvDoctors.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvDoctors.Size = New System.Drawing.Size(450, 280)
        Me.dgvDoctors.TabIndex = 13

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
        Me.Controls.Add(Me.dgvDoctors)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.btnEdit)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.txtPhone)
        Me.Controls.Add(Me.txtSpecialty)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.txtID)
        Me.Controls.Add(Me.lblPhone)
        Me.Controls.Add(Me.lblSpecialty)
        Me.Controls.Add(Me.lblName)
        Me.Controls.Add(Me.lblID)
        Me.Controls.Add(Me.lblTitle)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.Name = "DoctorForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Doctor Management"
        CType(Me.dgvDoctors, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()
    End Sub

    Friend WithEvents lblTitle As Label
    Friend WithEvents lblID As Label
    Friend WithEvents lblName As Label
    Friend WithEvents lblSpecialty As Label
    Friend WithEvents lblPhone As Label
    Friend WithEvents txtID As TextBox
    Friend WithEvents txtName As TextBox
    Friend WithEvents txtSpecialty As TextBox
    Friend WithEvents txtPhone As TextBox
    Friend WithEvents btnAdd As Button
    Friend WithEvents btnEdit As Button
    Friend WithEvents btnDelete As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents dgvDoctors As DataGridView
    Friend WithEvents btnBack As Button
End Class
