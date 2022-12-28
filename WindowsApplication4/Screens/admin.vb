Public Class admin
    Public Sub Bindusers()
        qr = "Select * from authority"
        ds = Searchdata(qr)
        If (ds.Tables(0).Rows.Count > 0) Then
            DataGridView1.DataSource = ds.Tables(0)
        Else
            MsgBox("Record not found", MsgBoxStyle.Critical)
        End If
    End Sub
    Private Sub admin_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Bindusers()
    End Sub
End Class