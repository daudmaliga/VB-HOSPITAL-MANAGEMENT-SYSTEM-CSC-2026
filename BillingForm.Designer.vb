<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class BillingForm
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
        lblTitle = New Label()
        lblID = New Label()
        lblPatient = New Label()
        lblAmount = New Label()
        lblPaymentStatus = New Label()
        lblDate = New Label()
        txtID = New TextBox()
        cmbPatient = New ComboBox()
        txtAmount = New TextBox()
        cmbPaymentStatus = New ComboBox()
        dtpBilling = New DateTimePicker()
        btnAdd = New Button()
        btnEdit = New Button()
        btnDelete = New Button()
        btnClear = New Button()
        dgvBilling = New DataGridView()
        btnBack = New Button()
        CType(dgvBilling, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' lblTitle
        ' 
        lblTitle.AutoSize = True
        lblTitle.Font = New Font("Segoe UI", 16F, FontStyle.Bold)
        lblTitle.Location = New Point(300, 15)
        lblTitle.Name = "lblTitle"
        lblTitle.Size = New Size(222, 30)
        lblTitle.TabIndex = 0
        lblTitle.Text = "Billing Management"
        ' 
        ' lblID
        ' 
        lblID.AutoSize = True
        lblID.Location = New Point(30, 70)
        lblID.Name = "lblID"
        lblID.Size = New Size(40, 15)
        lblID.TabIndex = 1
        lblID.Text = "Bill ID:"
        ' 
        ' lblPatient
        ' 
        lblPatient.AutoSize = True
        lblPatient.Location = New Point(30, 110)
        lblPatient.Name = "lblPatient"
        lblPatient.Size = New Size(47, 15)
        lblPatient.TabIndex = 2
        lblPatient.Text = "Patient:"
        ' 
        ' lblAmount
        ' 
        lblAmount.AutoSize = True
        lblAmount.Location = New Point(30, 150)
        lblAmount.Name = "lblAmount"
        lblAmount.Size = New Size(54, 15)
        lblAmount.TabIndex = 3
        lblAmount.Text = "Amount:"
        ' 
        ' lblPaymentStatus
        ' 
        lblPaymentStatus.AutoSize = True
        lblPaymentStatus.Location = New Point(30, 190)
        lblPaymentStatus.Name = "lblPaymentStatus"
        lblPaymentStatus.Size = New Size(92, 15)
        lblPaymentStatus.TabIndex = 4
        lblPaymentStatus.Text = "Payment Status:"
        ' 
        ' lblDate
        ' 
        lblDate.AutoSize = True
        lblDate.Location = New Point(30, 230)
        lblDate.Name = "lblDate"
        lblDate.Size = New Size(34, 15)
        lblDate.TabIndex = 5
        lblDate.Text = "Date:"
        ' 
        ' txtID
        ' 
        txtID.Location = New Point(150, 67)
        txtID.Name = "txtID"
        txtID.ReadOnly = True
        txtID.Size = New Size(200, 23)
        txtID.TabIndex = 6
        ' 
        ' cmbPatient
        ' 
        cmbPatient.DropDownStyle = ComboBoxStyle.DropDownList
        cmbPatient.FormattingEnabled = True
        cmbPatient.Location = New Point(150, 107)
        cmbPatient.Name = "cmbPatient"
        cmbPatient.Size = New Size(200, 23)
        cmbPatient.TabIndex = 7
        ' 
        ' txtAmount
        ' 
        txtAmount.Location = New Point(150, 147)
        txtAmount.Name = "txtAmount"
        txtAmount.Size = New Size(200, 23)
        txtAmount.TabIndex = 8
        ' 
        ' cmbPaymentStatus
        ' 
        cmbPaymentStatus.DropDownStyle = ComboBoxStyle.DropDownList
        cmbPaymentStatus.FormattingEnabled = True
        cmbPaymentStatus.Items.AddRange(New Object() {"Paid", "Pending", "Cancelled"})
        cmbPaymentStatus.Location = New Point(150, 187)
        cmbPaymentStatus.Name = "cmbPaymentStatus"
        cmbPaymentStatus.Size = New Size(200, 23)
        cmbPaymentStatus.TabIndex = 9
        ' 
        ' dtpBilling
        ' 
        dtpBilling.Format = DateTimePickerFormat.Short
        dtpBilling.Location = New Point(150, 227)
        dtpBilling.Name = "dtpBilling"
        dtpBilling.Size = New Size(200, 23)
        dtpBilling.TabIndex = 10
        ' 
        ' btnAdd
        ' 
        btnAdd.BackColor = Color.LightGreen
        btnAdd.Location = New Point(30, 280)
        btnAdd.Name = "btnAdd"
        btnAdd.Size = New Size(75, 30)
        btnAdd.TabIndex = 11
        btnAdd.Text = "Add"
        btnAdd.UseVisualStyleBackColor = False
        ' 
        ' btnEdit
        ' 
        btnEdit.BackColor = Color.LightBlue
        btnEdit.Location = New Point(120, 280)
        btnEdit.Name = "btnEdit"
        btnEdit.Size = New Size(75, 30)
        btnEdit.TabIndex = 12
        btnEdit.Text = "Edit"
        btnEdit.UseVisualStyleBackColor = False
        ' 
        ' btnDelete
        ' 
        btnDelete.BackColor = Color.LightCoral
        btnDelete.Location = New Point(210, 280)
        btnDelete.Name = "btnDelete"
        btnDelete.Size = New Size(75, 30)
        btnDelete.TabIndex = 13
        btnDelete.Text = "Delete"
        btnDelete.UseVisualStyleBackColor = False
        ' 
        ' btnClear
        ' 
        btnClear.BackColor = Color.LightGray
        btnClear.Location = New Point(300, 280)
        btnClear.Name = "btnClear"
        btnClear.Size = New Size(75, 30)
        btnClear.TabIndex = 14
        btnClear.Text = "Clear"
        btnClear.UseVisualStyleBackColor = False
        ' 
        ' dgvBilling
        ' 
        dgvBilling.AllowUserToAddRows = False
        dgvBilling.AllowUserToDeleteRows = False
        dgvBilling.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvBilling.Location = New Point(400, 70)
        dgvBilling.Name = "dgvBilling"
        dgvBilling.ReadOnly = True
        dgvBilling.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvBilling.Size = New Size(450, 280)
        dgvBilling.TabIndex = 15
        ' 
        ' btnBack
        ' 
        btnBack.Location = New Point(30, 330)
        btnBack.Name = "btnBack"
        btnBack.Size = New Size(100, 30)
        btnBack.TabIndex = 16
        btnBack.Text = "Back"
        btnBack.UseVisualStyleBackColor = True
        ' 
        ' BillingForm
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1147, 545)
        Controls.Add(btnBack)
        Controls.Add(dgvBilling)
        Controls.Add(btnClear)
        Controls.Add(btnDelete)
        Controls.Add(btnEdit)
        Controls.Add(btnAdd)
        Controls.Add(dtpBilling)
        Controls.Add(cmbPaymentStatus)
        Controls.Add(txtAmount)
        Controls.Add(cmbPatient)
        Controls.Add(txtID)
        Controls.Add(lblDate)
        Controls.Add(lblPaymentStatus)
        Controls.Add(lblAmount)
        Controls.Add(lblPatient)
        Controls.Add(lblID)
        Controls.Add(lblTitle)
        FormBorderStyle = FormBorderStyle.FixedDialog
        MaximizeBox = False
        Name = "BillingForm"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Billing Management"
        CType(dgvBilling, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblTitle As Label
    Friend WithEvents lblID As Label
    Friend WithEvents lblPatient As Label
    Friend WithEvents lblAmount As Label
    Friend WithEvents lblPaymentStatus As Label
    Friend WithEvents lblDate As Label
    Friend WithEvents txtID As TextBox
    Friend WithEvents cmbPatient As ComboBox
    Friend WithEvents txtAmount As TextBox
    Friend WithEvents cmbPaymentStatus As ComboBox
    Friend WithEvents dtpBilling As DateTimePicker
    Friend WithEvents btnAdd As Button
    Friend WithEvents btnEdit As Button
    Friend WithEvents btnDelete As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents dgvBilling As DataGridView
    Friend WithEvents btnBack As Button
End Class
