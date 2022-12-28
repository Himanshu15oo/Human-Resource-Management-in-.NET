Public Class loginform

    Private Sub Login_button_Click(sender As System.Object, e As System.EventArgs) Handles Login_button.Click
        If (formvalidation()) Then
            qr = "select * from users where user_name='" & TextBox1.Text & "' and user_password='" & TextBox2.Text & "' and role='" & ComboBox1.Text & "'"
            ds = Searchdata(qr)

            If (ds.Tables(0).Rows.Count > 0) Then
                If (ComboBox1.Text = "admin") Then
                    adminflag = True
                End If
                homepage.Show()
            Else
                MsgBox("Username and Password not correct", MsgBoxStyle.Critical)

            End If
        End If
    End Sub

    Private Function formvalidation() As Boolean
        If (TextBox1.Text.Trim = String.Empty) Then
            MsgBox("User name is required", MsgBoxStyle.Critical)
            TextBox1.Clear()
            TextBox2.Clear()
            Return False
        End If
        If (TextBox2.Text.Trim = String.Empty) Then
            MsgBox("Password is required", MsgBoxStyle.Critical)
            TextBox1.Clear()
            TextBox2.Clear()
            Return False
        End If

        Return True

    End Function
End Class