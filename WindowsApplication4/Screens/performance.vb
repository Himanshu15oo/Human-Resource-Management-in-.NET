Public Class performance
    Public Sub Bindperformance()
        qr = "Select * from performance"
        ds = Searchdata(qr)
        If (ds.Tables(0).Rows.Count > 0) Then
            DataGridView1.DataSource = ds.Tables(0)
        Else
            MsgBox("Record not found", MsgBoxStyle.Critical)
        End If
    End Sub

    Private Sub performance_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Bindperformance()
        If (adminflag = True) Then
            Update_button.Enabled = True
        End If
    End Sub

    Private Sub Update_button_Click(sender As System.Object, e As System.EventArgs) Handles Update_button.Click
        If (ID_box.Text.Trim <> String.Empty) Then
            If (performnacevalidation()) Then
                qr = "update performance set salary=" & Salary_box.Text & ", points =" & Points_box.Text & " where ID =" & ID_box.Text & " and months = '" & Update_month_box.Text & "'"
                Dim logincorrect As Boolean = Convert.ToBoolean(InsertData(qr))
                If (logincorrect) Then
                    Bindperformance()
                    MsgBox("Record updated successfully", MsgBoxStyle.OkOnly)
                    clrperformance()
                Else
                    MsgBox("Error! Record not Updated", MsgBoxStyle.Critical)
                    clrperformance()
                End If
            Else
                MsgBox("Fill all fields", MsgBoxStyle.Critical)
            End If
        Else
            MsgBox("Enter something in the ID field", MsgBoxStyle.Critical)
        End If
    End Sub
    Private Function performnacevalidation() As Boolean
        If (ID_box.Text.Trim = String.Empty) Then
            MsgBox("Employee ID is required", MsgBoxStyle.Critical)
            ID_box.Clear()
            Update_month_box.Clear()
            Salary_box.Clear()
            Points_box.Clear()
        End If
        If (Update_month_box.Text = String.Empty) Then
            MsgBox("Month is required", MsgBoxStyle.Critical)
            ID_box.Clear()
            Update_month_box.Clear()
            Salary_box.Clear()
            Points_box.Clear()
            Return False
        End If
        If (Salary_box.Text.Trim = String.Empty) Then
            MsgBox("Salary is required", MsgBoxStyle.Critical)
            ID_box.Clear()
            Update_month_box.Clear()
            Salary_box.Clear()
            Points_box.Clear()
            Return False
        End If
        If (Points_box.Text.Trim = String.Empty) Then
            MsgBox("Points are required", MsgBoxStyle.Critical)
            ID_box.Clear()
            Update_month_box.Clear()
            Salary_box.Clear()
            Points_box.Clear()
            Return False
        End If
        Return True
    End Function

    Private Sub clrperformance()
        ID_box.Clear()
        Update_month_box.Clear()
        Salary_box.Clear()
        Points_box.Clear()
    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        qr = "Select * from performance where months ='" & Search_month_box.Text & "'"
        ds = Searchdata(qr)
        If (ds.Tables(0).Rows.Count > 0) Then
            DataGridView1.DataSource = ds.Tables(0)
        Else
            MsgBox("Record not found", MsgBoxStyle.Critical)
        End If
    End Sub


End Class