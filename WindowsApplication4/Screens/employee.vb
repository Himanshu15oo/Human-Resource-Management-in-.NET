Public Class employee

    Private Sub Search_button_Click(sender As System.Object, e As System.EventArgs) Handles Search_button.Click
        If (Search_box.Text.Trim <> String.Empty) Then
            qr = "Select * from employee where ID =" & Search_box.Text
            ds = Searchdata(qr)
            If (ds.Tables(0).Rows.Count > 0) Then
                DataGridView1.DataSource = ds.Tables(0)
            Else
                MsgBox("Record not found", MsgBoxStyle.Critical)
            End If
        Else
            MsgBox("Enter something in the field", MsgBoxStyle.Critical)
        End If
    End Sub

    Private Sub employee_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Bind()
        If (adminflag = True) Then
            Update_button.Enabled = True
            Add_button.Enabled = True
            Delete_button.Enabled = True
        End If
    End Sub
    Public Sub Bind()
        qr = "Select * from employee"
        ds = Searchdata(qr)
        If (ds.Tables(0).Rows.Count > 0) Then
            DataGridView1.DataSource = ds.Tables(0)
        Else
            MsgBox("Record not found", MsgBoxStyle.Critical)
        End If
    End Sub
    Private Function employeeform() As Boolean

        If (Emp_name.Text.Trim = String.Empty) Then
            MsgBox("Name is required", MsgBoxStyle.Critical)

            Return False
        End If
        If (Emp_age.Text.Trim = String.Empty) Then
            MsgBox("Age is required", MsgBoxStyle.Critical)

            Return False
        End If
        If (Emp_email.Text.Trim = String.Empty) Then
            MsgBox("Email is required", MsgBoxStyle.Critical)

            Return False
        End If
        If (Emp_phone.Text.Trim = String.Empty) Then
            MsgBox("Phone no is required", MsgBoxStyle.Critical)

            Return False
        End If
        If (Emp_address.Text.Trim = String.Empty) Then
            MsgBox("Address is required", MsgBoxStyle.Critical)

            Return False
        End If
        If (Emp_salary.Text.Trim = String.Empty) Then
            MsgBox("Salary name is required", MsgBoxStyle.Critical)

            Return False
        End If
        If (Emp_department.Text.Trim = String.Empty) Then
            MsgBox("Department name is required", MsgBoxStyle.Critical)

            Return False
        End If
        If (Emp_designation.Text.Trim = String.Empty) Then
            MsgBox("Designation name is required", MsgBoxStyle.Critical)

            Return False
        End If
        If (Emp_startdate.Text.Trim = String.Empty) Then
            MsgBox("Start Date is required", MsgBoxStyle.Critical)

            Return False
        End If
        Return True

    End Function

    Private Sub Add_button_Click(sender As System.Object, e As System.EventArgs) Handles Add_button.Click
        If (employeeform()) Then
            qr = "insert into employee (name, age, email, phone_no, address, salary, department,designation,start_date,end_date)values('" & Emp_name.Text & "', " & Emp_age.Text & ", '" & Emp_email.Text & "', " & Emp_phone.Text & ",' " & Emp_address.Text & "', " & Emp_salary.Text & ", '" & Emp_department.Text & "',' " & Emp_designation.Text & "',' " & Emp_startdate.Text & "', '" & Emp_enddate.Text & "')"
            Dim logincorrect As Boolean = Convert.ToBoolean(InsertData(qr))
            If (logincorrect) Then
                Bind()
                MsgBox("Employee added successfully", MsgBoxStyle.OkOnly)
                clremp()
            End If
        Else
            MsgBox("Error! Record not saved", MsgBoxStyle.Critical)
            clremp()
        End If
    End Sub

    Private Sub Update_button_Click(sender As System.Object, e As System.EventArgs) Handles Update_button.Click
        If (Search_box.Text.Trim <> String.Empty) Then
            If (employeeform()) Then
                qr = "update employee set name='" & Emp_name.Text & "', age =" & Emp_age.Text & ", email ='" & Emp_email.Text & "', phone_no =" & Emp_phone.Text & ", address= '" & Emp_address.Text & "' , salary=" & Emp_salary.Text & ", department='" & Emp_department.Text & "',designation='" & Emp_designation.Text & "',start_date='" & Emp_startdate.Text & "', end_date='" & Emp_enddate.Text & "' where ID =" & Search_box.Text
                Dim logincorrect As Boolean = Convert.ToBoolean(InsertData(qr))
                If (logincorrect) Then
                    Bind()
                    MsgBox("Record updated successfully", MsgBoxStyle.OkOnly)
                    clremp()
                Else
                    MsgBox("Error! Record not Updated", MsgBoxStyle.Critical)
                    clremp()
                End If
            Else
                MsgBox("Fill all fields", MsgBoxStyle.Critical)
            End If
        Else
            MsgBox("Enter something in the field", MsgBoxStyle.Critical)
        End If
    End Sub

    Private Sub clremp()
        Emp_name.Clear()
        Emp_age.Clear()
        Emp_email.Clear()
        Emp_phone.Clear()
        Emp_address.Clear()
        Emp_salary.Clear()
        Emp_department.Clear()
        Emp_designation.Clear()
        Emp_startdate.Clear()
        Emp_enddate.Clear()
        Search_box.Clear()
    End Sub

    Private Sub Delete_button_Click(sender As System.Object, e As System.EventArgs) Handles Delete_button.Click
        If (Search_box.Text.Trim <> String.Empty) Then
            qr = "Delete from employee where ID =" & Search_box.Text
            Dim logincorrect As Boolean = Convert.ToBoolean(InsertData(qr))
            If (logincorrect) Then
                Bind()
                MsgBox("Employee record deleted successfully", MsgBoxStyle.OkOnly)
                clremp()
            Else
                MsgBox("Error! Record not deleted", MsgBoxStyle.Critical)
                clremp()
            End If
        Else
            MsgBox("Enter something in the field", MsgBoxStyle.Critical)
        End If
    End Sub
End Class

