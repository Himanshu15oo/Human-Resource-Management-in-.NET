
Public Class homepage

    Private Sub homepage_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Dim dt As Date = Today
        Label1.Text = Now.ToLongTimeString
        Label7.Text = dt
        If (adminflag = True) Then
            user_label.Text = "Admin"
        Else
            user_label.Text = "User"
        End If
    End Sub

    Private Sub PictureBox1_Click(sender As System.Object, e As System.EventArgs) Handles PictureBox1.Click
        department.Show()
    End Sub

    Private Sub PictureBox3_Click(sender As System.Object, e As System.EventArgs) Handles PictureBox3.Click
        employee.Show()
    End Sub

    Private Sub PictureBox4_Click(sender As System.Object, e As System.EventArgs) Handles PictureBox4.Click
        Application.Exit()
    End Sub

    Private Sub PictureBox6_Click(sender As System.Object, e As System.EventArgs) Handles PictureBox6.Click
        performance.Show()
    End Sub

    Private Sub PictureBox2_Click(sender As System.Object, e As System.EventArgs) Handles PictureBox2.Click
        If (adminflag = True) Then
            admin.Show()
        Else
            MsgBox("You are not allowed to access this Tab. (Only for Admins)", MsgBoxStyle.Critical)
        End If
    End Sub

   
End Class