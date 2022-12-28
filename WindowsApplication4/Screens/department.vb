Public Class department


    Private Sub Add_button_Click(sender As System.Object, e As System.EventArgs) Handles Add_button.Click
        If (formvalidation()) Then
            qr = "insert into department (dept_name, phone_no, strength)values('" & TextBox2.Text & "', " & TextBox3.Text & ", " & TextBox4.Text & ")"
            Dim logincorrect As Boolean = Convert.ToBoolean(InsertData(qr))
            If (logincorrect) Then
                BindGD()
                MsgBox("Department added successfully", MsgBoxStyle.OkOnly)
                clr()
            End If
        Else
            MsgBox("Error! Record not saved", MsgBoxStyle.Critical)
            clr()
        End If
    End Sub

    Private Function formvalidation() As Boolean

        If (TextBox2.Text.Trim = String.Empty) Then
            MsgBox("Department name is required", MsgBoxStyle.Critical)
            TextBox1.Clear()
            TextBox2.Clear()
            TextBox3.Clear()
            TextBox4.Clear()
            Return False
        End If
        If (TextBox3.Text.Trim = String.Empty) Then
            MsgBox("Department phone no. is required", MsgBoxStyle.Critical)
            TextBox1.Clear()
            TextBox2.Clear()
            TextBox3.Clear()
            TextBox4.Clear()
            Return False
        End If
        If (TextBox4.Text.Trim = String.Empty) Then
            MsgBox("Department strength is required", MsgBoxStyle.Critical)
            TextBox1.Clear()
            TextBox2.Clear()
            TextBox3.Clear()
            TextBox4.Clear()
            Return False
        End If

        Return True

    End Function

    Public Sub BindGD()
        qr = "Select * from department"
        ds = Searchdata(qr)
        If (ds.Tables(0).Rows.Count > 0) Then
            DataGridView1.DataSource = ds.Tables(0)
        Else
            MsgBox("Record not found", MsgBoxStyle.Critical)
        End If
    End Sub

    Private Sub department_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        BindGD()
        If (adminflag = True) Then
            Update_button.Enabled = True
            Add_button.Enabled = True
            Delete_button.Enabled = True
        End If
    End Sub

    Private Sub clr()
        TextBox1.Clear()
        TextBox2.Clear()
        TextBox3.Clear()
        TextBox4.Clear()
    End Sub

    Private Sub DataGridView1_CellClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        i = DataGridView1.CurrentRow.Index
        Me.TextBox1.Text = DataGridView1.Item(0, i).Value
        Me.TextBox2.Text = DataGridView1.Item(1, i).Value
        Me.TextBox3.Text = DataGridView1.Item(2, i).Value
        Me.TextBox4.Text = DataGridView1.Item(3, i).Value
    End Sub

    Private Sub Search_button_Click(sender As System.Object, e As System.EventArgs) Handles Search_button.Click
        If (TextBox5.Text.Trim <> String.Empty) Then
            qr = "Select * from department where ID =" & TextBox5.Text
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

    Private Sub Update_button_Click(sender As System.Object, e As System.EventArgs) Handles Update_button.Click
        If (TextBox5.Text.Trim <> String.Empty) Then
            If (formvalidation()) Then
                qr = "update department set dept_name='" & TextBox2.Text & "', phone_no =" & TextBox3.Text & ", strength =" & TextBox4.Text & " where ID =" & TextBox5.Text
                Dim logincorrect As Boolean = Convert.ToBoolean(InsertData(qr))
                If (logincorrect) Then
                    BindGD()
                    MsgBox("Record updated successfully", MsgBoxStyle.OkOnly)
                    clr()
                Else
                    MsgBox("Error! Record not Updated", MsgBoxStyle.Critical)
                    clr()
                End If
            Else
                MsgBox("Fill all fields", MsgBoxStyle.Critical)
            End If
        Else
            MsgBox("Enter something in the field", MsgBoxStyle.Critical)
        End If
    End Sub

    Private Sub Delete_button_Click(sender As System.Object, e As System.EventArgs) Handles Delete_button.Click
        If (TextBox5.Text.Trim <> String.Empty) Then
            qr = "Delete from department where ID =" & TextBox5.Text
            Dim logincorrect As Boolean = Convert.ToBoolean(InsertData(qr))
            If (logincorrect) Then
                BindGD()
                MsgBox("Department deleted successfully", MsgBoxStyle.OkOnly)
                clr()
            Else
                MsgBox("Error! Record not deleted", MsgBoxStyle.Critical)
                clr()
            End If
        Else
            MsgBox("Enter something in the field", MsgBoxStyle.Critical)
        End If
    End Sub
End Class