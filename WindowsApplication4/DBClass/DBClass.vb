Imports System.Data.OleDb


Module DBClass
    Public con As New OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Acer\Desktop\WindowsApplication4\HumanResourceManagement.accdb")
    Public qr As String
    Public cmd As New OleDb.OleDbCommand
    Public dt As New DataTable
    Public da As New OleDb.OleDbDataAdapter
    Public ds As New DataSet
    Public i As Integer
    Public adminflag As Boolean = False

    Public Function Searchdata(ByVal qr As String) As DataSet
        da = New OleDbDataAdapter(qr, con)
        con.Open()
        ds = New DataSet
        da.Fill(ds)
        con.Close()
        Return ds

    End Function

    Public Function InsertData(ByVal qr As String) As Integer
        cmd = New OleDbCommand(qr, con)
        con.Open()
        i = cmd.ExecuteNonQuery()
        con.Close()
        Return i
    End Function
End Module
