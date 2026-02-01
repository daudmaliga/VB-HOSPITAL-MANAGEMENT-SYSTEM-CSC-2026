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
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.lblID = New System.Windows.Forms.Label()
        Me.lblPatient = New System.Windows.Forms.Label()
        Me.lblAmount = New System.Windows.Forms.Label()
        Me.lblPaymentStatus = New System.Windows.Forms.Label()
        Me.lblDate = New System.Windows.Forms.Label()
        Me.txtID = New System.Windows.Forms.TextBox()
        Me.cmbPatient = New System.Windows.Forms.ComboBox()
        Me.txtAmount = New System.Windows.Forms.TextBox()
        Me.cmbPaymentStatus = New System.Windows.Forms.ComboBox()
        Me.dtpBilling = New System.Windows.Forms.DateTimePicker()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.btnEdit = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.dgvBilling = New System.Windows.Forms.DataGridView()
        Me.btnBack = New System.Windows.Forms.Button()
        CType(Me.dgvBilling, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()

        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Segoe UI", 16.0!, System.Drawing.FontStyle.Bold)
        Me.lblTitle.Location = New System.Drawing.Point(300, 15)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(220, 30)
        Me.lblTitle.TabIndex = 0
        Me.lblTitle.Text = "Billing Management"

        Me.lblID.AutoSize = True
        Me.lblID.Location = New System.Drawing.Point(30, 70)
        Me.lblID.Name = "lblID"
        Me.lblID.Size = New System.Drawing.Size(44, 15)
        Me.lblID.TabIndex = 1
        Me.lblID.Text = "Bill ID:"

        Me.lblPatient.AutoSize = True
        Me.lblPatient.Location = New System.Drawing.Point(30, 110)
        Me.lblPatient.Name = "lblPatient"
        Me.lblPatient.Size = New System.Drawing.Size(47, 15)
        Me.lblPatient.TabIndex = 2
        Me.lblPatient.Text = "Patient:"

        Me.lblAmount.AutoSize = True
        Me.lblAmount.Location = New System.Drawing.Point(30, 150)
        Me.lblAmount.Name = "lblAmount"
        Me.lblAmount.Size = New System.Drawing.Size(54, 15)
        Me.lblAmount.TabIndex = 3
        Me.lblAmount.Text = "Amount:"

        Me.lblPaymentStatus.AutoSize = True
        Me.lblPaymentStatus.Location = New System.Drawing.Point(30, 190)
        Me.lblPaymentStatus.Name = "lblPaymentStatus"
        Me.lblPaymentStatus.Size = New System.Drawing.Size(92, 15)
        Me.lblPaymentStatus.TabIndex = 4
        Me.lblPaymentStatus.Text = "Payment Status:"

        Me.lblDate.AutoSize = True
        Me.lblDate.Location = New System.Drawing.Point(30, 230)
        Me.lblDate.Name = "lblDate"
        Me.lblDate.Size = New System.Drawing.Size(34, 15)
        Me.lblDate.TabIndex = 5
        Me.lblDate.Text = "Date:"

        Me.txtID.Location = New System.Drawing.Point(150, 67)
        Me.txtID.Name = "txtID"
        Me.txtID.ReadOnly = True
        Me.txtID.Size = New System.Drawing.Size(200, 23)
        Me.txtID.TabIndex = 6

        Me.cmbPatient.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbPatient.FormattingEnabled = True
        Me.cmbPatient.Location = New System.Drawing.Point(150, 107)
        Me.cmbPatient.Name = "cmbPatient"
        Me.cmbPatient.Size = New System.Drawing.Size(200, 23)
        Me.cmbPatient.TabIndex = 7

        Me.txtAmount.Location = New System.Drawing.Point(150, 147)
        Me.txtAmount.Name = "txtAmount"
        Me.txtAmount.Size = New System.Drawing.Size(200, 23)
        Me.txtAmount.TabIndex = 8

        Me.cmbPaymentStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbPaymentStatus.FormattingEnabled = True
        Me.cmbPaymentStatus.Items.AddRange(New Object() {"Paid", "Pending", "Cancelled"})
        Me.cmbPaymentStatus.Location = New System.Drawing.Point(150, 187)
        Me.cmbPaymentStatus.Name = "cmbPaymentStatus"
        Me.cmbPaymentStatus.Size = New System.Drawing.Size(200, 23)
        Me.cmbPaymentStatus.TabIndex = 9

        Me.dtpBilling.Format = System.Windows.Forms.DateTimePickerFormat.Short
        Me.dtpBilling.Location = New System.Drawing.Point(150, 227)
        Me.dtpBilling.Name = "dtpBilling"
        Me.dtpBilling.Size = New System.Drawing.Size(200, 23)
        Me.dtpBilling.TabIndex = 10

        Me.btnAdd.BackColor = System.Drawing.Color.LightGreen
        Me.btnAdd.Location = New System.Drawing.Point(30, 280)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(75, 30)
        Me.btnAdd.TabIndex = 11
        Me.btnAdd.Text = "Add"
        Me.btnAdd.UseVisualStyleBackColor = False

        Me.btnEdit.BackColor = System.Drawing.Color.LightBlue
        Me.btnEdit.Location = New System.Drawing.Point(120, 280)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(75, 30)
        Me.btnEdit.TabIndex = 12
        Me.btnEdit.Text = "Edit"
        Me.btnEdit.UseVisualStyleBackColor = False

        Me.btnDelete.BackColor = System.Drawing.Color.LightCoral
        Me.btnDelete.Location = New System.Drawing.Point(210, 280)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(75, 30)
        Me.btnDelete.TabIndex = 13
        Me.btnDelete.Text = "Delete"
        Me.btnDelete.UseVisualStyleBackColor = False

        Me.btnClear.BackColor = System.Drawing.Color.LightGray
        Me.btnClear.Location = New System.Drawing.Point(300, 280)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(75, 30)
        Me.btnClear.TabIndex = 14
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = False

        Me.dgvBilling.AllowUserToAddRows = False
        Me.dgvBilling.AllowUserToDeleteRows = False
        Me.dgvBilling.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvBilling.Location = New System.Drawing.Point(400, 70)
        Me.dgvBilling.Name = "dgvBilling"
        Me.dgvBilling.ReadOnly = True
        Me.dgvBilling.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvBilling.Size = New System.Drawing.Size(450, 280)
        Me.dgvBilling.TabIndex = 15

        Me.btnBack.Location = New System.Drawing.Point(30, 330)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(100, 30)
        Me.btnBack.TabIndex = 16
        Me.btnBack.Text = "Back"
        Me.btnBack.UseVisualStyleBackColor = True

        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(880, 380)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.dgvBilling)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.btnEdit)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.dtpBilling)
        Me.Controls.Add(Me.cmbPaymentStatus)
        Me.Controls.Add(Me.txtAmount)
        Me.Controls.Add(Me.cmbPatient)
        Me.Controls.Add(Me.txtID)
        Me.Controls.Add(Me.lblDate)
        Me.Controls.Add(Me.lblPaymentStatus)
        Me.Controls.Add(Me.lblAmount)
        Me.Controls.Add(Me.lblPatient)
        Me.Controls.Add(Me.lblID)
        Me.Controls.Add(Me.lblTitle)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.Name = "BillingForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Billing Management"
        CType(Me.dgvBilling, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()
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
