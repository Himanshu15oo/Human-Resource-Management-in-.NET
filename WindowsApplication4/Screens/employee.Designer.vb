<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class employee
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Emp_enddate = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Emp_startdate = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Emp_designation = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Emp_department = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Emp_salary = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Emp_address = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Emp_phone = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Emp_email = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Emp_age = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Emp_name = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Emp_id = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Delete_button = New System.Windows.Forms.Button()
        Me.Add_button = New System.Windows.Forms.Button()
        Me.Update_button = New System.Windows.Forms.Button()
        Me.Search_button = New System.Windows.Forms.Button()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Search_box = New System.Windows.Forms.TextBox()
        Me.Searchbox = New System.Windows.Forms.TextBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Showcard Gothic", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.Label1.Location = New System.Drawing.Point(320, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(187, 42)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "EMPLOYEE"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.HotTrack
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(0, -1)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(839, 87)
        Me.Panel1.TabIndex = 2
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Emp_enddate)
        Me.GroupBox2.Controls.Add(Me.Label13)
        Me.GroupBox2.Controls.Add(Me.Emp_startdate)
        Me.GroupBox2.Controls.Add(Me.Label12)
        Me.GroupBox2.Controls.Add(Me.Emp_designation)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.GroupBox2.Location = New System.Drawing.Point(405, 101)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(380, 228)
        Me.GroupBox2.TabIndex = 21
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Job Details"
        '
        'Emp_enddate
        '
        Me.Emp_enddate.Location = New System.Drawing.Point(164, 146)
        Me.Emp_enddate.Name = "Emp_enddate"
        Me.Emp_enddate.Size = New System.Drawing.Size(188, 22)
        Me.Emp_enddate.TabIndex = 26
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Label13.Location = New System.Drawing.Point(31, 146)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(87, 20)
        Me.Label13.TabIndex = 25
        Me.Label13.Text = "End Date"
        '
        'Emp_startdate
        '
        Me.Emp_startdate.Location = New System.Drawing.Point(164, 98)
        Me.Emp_startdate.Name = "Emp_startdate"
        Me.Emp_startdate.Size = New System.Drawing.Size(188, 22)
        Me.Emp_startdate.TabIndex = 24
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Label12.Location = New System.Drawing.Point(31, 98)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(96, 20)
        Me.Label12.TabIndex = 23
        Me.Label12.Text = "Start Date"
        '
        'Emp_designation
        '
        Me.Emp_designation.Location = New System.Drawing.Point(164, 51)
        Me.Emp_designation.Name = "Emp_designation"
        Me.Emp_designation.Size = New System.Drawing.Size(188, 22)
        Me.Emp_designation.TabIndex = 22
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Label10.Location = New System.Drawing.Point(31, 51)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(109, 20)
        Me.Label10.TabIndex = 21
        Me.Label10.Text = "Designation"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Emp_department)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.Emp_salary)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Emp_address)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Emp_phone)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Emp_email)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Emp_age)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Emp_name)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Emp_id)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.GroupBox1.Location = New System.Drawing.Point(12, 101)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(372, 471)
        Me.GroupBox1.TabIndex = 20
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Enter Details"
        '
        'Emp_department
        '
        Me.Emp_department.Location = New System.Drawing.Point(145, 423)
        Me.Emp_department.Name = "Emp_department"
        Me.Emp_department.Size = New System.Drawing.Size(188, 22)
        Me.Emp_department.TabIndex = 30
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Label9.Location = New System.Drawing.Point(16, 423)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(107, 20)
        Me.Label9.TabIndex = 29
        Me.Label9.Text = "Department"
        '
        'Emp_salary
        '
        Me.Emp_salary.Location = New System.Drawing.Point(145, 376)
        Me.Emp_salary.Name = "Emp_salary"
        Me.Emp_salary.Size = New System.Drawing.Size(188, 22)
        Me.Emp_salary.TabIndex = 28
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Label8.Location = New System.Drawing.Point(16, 376)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(105, 20)
        Me.Label8.TabIndex = 27
        Me.Label8.Text = "Salary (Rs)"
        '
        'Emp_address
        '
        Me.Emp_address.Location = New System.Drawing.Point(145, 284)
        Me.Emp_address.Multiline = True
        Me.Emp_address.Name = "Emp_address"
        Me.Emp_address.Size = New System.Drawing.Size(188, 77)
        Me.Emp_address.TabIndex = 26
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Label7.Location = New System.Drawing.Point(16, 284)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(78, 20)
        Me.Label7.TabIndex = 25
        Me.Label7.Text = "Address"
        '
        'Emp_phone
        '
        Me.Emp_phone.Location = New System.Drawing.Point(145, 237)
        Me.Emp_phone.Name = "Emp_phone"
        Me.Emp_phone.Size = New System.Drawing.Size(188, 22)
        Me.Emp_phone.TabIndex = 24
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Label6.Location = New System.Drawing.Point(16, 237)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(87, 20)
        Me.Label6.TabIndex = 23
        Me.Label6.Text = "Phone no"
        '
        'Emp_email
        '
        Me.Emp_email.Location = New System.Drawing.Point(145, 192)
        Me.Emp_email.Name = "Emp_email"
        Me.Emp_email.Size = New System.Drawing.Size(188, 22)
        Me.Emp_email.TabIndex = 22
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Label5.Location = New System.Drawing.Point(16, 192)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(56, 20)
        Me.Label5.TabIndex = 21
        Me.Label5.Text = "Email"
        '
        'Emp_age
        '
        Me.Emp_age.Location = New System.Drawing.Point(145, 146)
        Me.Emp_age.Name = "Emp_age"
        Me.Emp_age.Size = New System.Drawing.Size(188, 22)
        Me.Emp_age.TabIndex = 20
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Label4.Location = New System.Drawing.Point(16, 146)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(87, 20)
        Me.Label4.TabIndex = 19
        Me.Label4.Text = "Age (yrs)"
        '
        'Emp_name
        '
        Me.Emp_name.Location = New System.Drawing.Point(145, 98)
        Me.Emp_name.Name = "Emp_name"
        Me.Emp_name.Size = New System.Drawing.Size(188, 22)
        Me.Emp_name.TabIndex = 18
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Label3.Location = New System.Drawing.Point(16, 98)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(57, 20)
        Me.Label3.TabIndex = 17
        Me.Label3.Text = "Name"
        '
        'Emp_id
        '
        Me.Emp_id.Enabled = False
        Me.Emp_id.Location = New System.Drawing.Point(145, 51)
        Me.Emp_id.Name = "Emp_id"
        Me.Emp_id.Size = New System.Drawing.Size(188, 22)
        Me.Emp_id.TabIndex = 16
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Label2.Location = New System.Drawing.Point(16, 51)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(111, 20)
        Me.Label2.TabIndex = 15
        Me.Label2.Text = "Employee Id"
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AllowUserToResizeColumns = False
        Me.DataGridView1.AllowUserToResizeRows = False
        Me.DataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonFace
        Me.DataGridView1.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(12, 587)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(773, 177)
        Me.DataGridView1.TabIndex = 22
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Delete_button)
        Me.GroupBox3.Controls.Add(Me.Add_button)
        Me.GroupBox3.Controls.Add(Me.Update_button)
        Me.GroupBox3.Controls.Add(Me.Search_button)
        Me.GroupBox3.Controls.Add(Me.Label11)
        Me.GroupBox3.Controls.Add(Me.Search_box)
        Me.GroupBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.GroupBox3.Location = New System.Drawing.Point(405, 338)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(380, 234)
        Me.GroupBox3.TabIndex = 23
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Search"
        '
        'Delete_button
        '
        Me.Delete_button.BackColor = System.Drawing.SystemColors.HotTrack
        Me.Delete_button.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Delete_button.Enabled = False
        Me.Delete_button.ForeColor = System.Drawing.SystemColors.Window
        Me.Delete_button.Location = New System.Drawing.Point(182, 174)
        Me.Delete_button.Name = "Delete_button"
        Me.Delete_button.Size = New System.Drawing.Size(101, 38)
        Me.Delete_button.TabIndex = 24
        Me.Delete_button.Text = "Delete"
        Me.Delete_button.UseVisualStyleBackColor = False
        '
        'Add_button
        '
        Me.Add_button.BackColor = System.Drawing.SystemColors.HotTrack
        Me.Add_button.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Add_button.Enabled = False
        Me.Add_button.ForeColor = System.Drawing.SystemColors.Window
        Me.Add_button.Location = New System.Drawing.Point(35, 176)
        Me.Add_button.Name = "Add_button"
        Me.Add_button.Size = New System.Drawing.Size(101, 38)
        Me.Add_button.TabIndex = 23
        Me.Add_button.Text = "Add"
        Me.Add_button.UseVisualStyleBackColor = False
        '
        'Update_button
        '
        Me.Update_button.BackColor = System.Drawing.SystemColors.HotTrack
        Me.Update_button.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Update_button.Enabled = False
        Me.Update_button.ForeColor = System.Drawing.SystemColors.Window
        Me.Update_button.Location = New System.Drawing.Point(182, 114)
        Me.Update_button.Name = "Update_button"
        Me.Update_button.Size = New System.Drawing.Size(101, 38)
        Me.Update_button.TabIndex = 22
        Me.Update_button.Text = "Update"
        Me.Update_button.UseVisualStyleBackColor = False
        '
        'Search_button
        '
        Me.Search_button.BackColor = System.Drawing.SystemColors.HotTrack
        Me.Search_button.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Search_button.ForeColor = System.Drawing.SystemColors.Window
        Me.Search_button.Location = New System.Drawing.Point(35, 114)
        Me.Search_button.Name = "Search_button"
        Me.Search_button.Size = New System.Drawing.Size(101, 38)
        Me.Search_button.TabIndex = 21
        Me.Search_button.Text = "Search"
        Me.Search_button.UseVisualStyleBackColor = False
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Label11.Location = New System.Drawing.Point(22, 35)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(114, 20)
        Me.Label11.TabIndex = 20
        Me.Label11.Text = "Search by Id"
        '
        'Search_box
        '
        Me.Search_box.Location = New System.Drawing.Point(26, 70)
        Me.Search_box.Name = "Search_box"
        Me.Search_box.Size = New System.Drawing.Size(188, 22)
        Me.Search_box.TabIndex = 17
        '
        'Searchbox
        '
        Me.Searchbox.Location = New System.Drawing.Point(26, 70)
        Me.Searchbox.Name = "Searchbox"
        Me.Searchbox.Size = New System.Drawing.Size(188, 22)
        Me.Searchbox.TabIndex = 17
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.SystemColors.HotTrack
        Me.Panel2.Location = New System.Drawing.Point(0, 780)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(799, 47)
        Me.Panel2.TabIndex = 24
        '
        'employee
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Window
        Me.ClientSize = New System.Drawing.Size(797, 822)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Panel1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "employee"
        Me.Text = "employee"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Emp_department As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Emp_salary As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Emp_address As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Emp_phone As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Emp_email As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Emp_age As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Emp_name As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Emp_id As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents Delete_button As System.Windows.Forms.Button
    Friend WithEvents Add_button As System.Windows.Forms.Button
    Friend WithEvents Update_button As System.Windows.Forms.Button
    Friend WithEvents Search_button As System.Windows.Forms.Button
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Search_box As System.Windows.Forms.TextBox
    Friend WithEvents Emp_enddate As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Emp_startdate As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Emp_designation As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Searchbox As System.Windows.Forms.TextBox
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
End Class
