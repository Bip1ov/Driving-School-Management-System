Imports System.Data.SqlClient
Public Class student
    Dim con As New SqlConnection("Data Source=BIPLOV\MSSQLSERVER04;Initial Catalog=DSM_OCEM;Integrated Security=True")
    Private Sub Guna2Button4_Click(sender As Object, e As EventArgs) Handles add_btn.Click

        enrollStudent.ShowDialog()
    End Sub
    Public Sub loadStudentData()
        Dim query As String = "select * from student"
        Dim cmd As New SqlCommand(query, con)
        Dim a As New SqlDataAdapter(cmd)
        Dim dt As New DataTable
        a.Fill(dt)
        Guna2DataGridView1.DataSource = dt
    End Sub

    Private Sub student_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loadStudentData()
    End Sub

    Private Sub update_btn_Click(sender As Object, e As EventArgs) Handles update_btn.Click
        updatestudent.ShowDialog()
    End Sub
    Public Sub deleteStudentData()
        Try
            Dim query As String = "delete from student where stuid = @a"
            Dim cmd As New SqlCommand(query, con)
            cmd.Parameters.AddWithValue("@a", Guna2DataGridView1.SelectedRows(0).Cells(0).Value)
            con.Open()
            cmd.ExecuteNonQuery()
            con.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub delete_btn_Click(sender As Object, e As EventArgs) Handles delete_btn.Click
        deleteStudentData()
        loadStudentData()
    End Sub

    Public Sub searchStudentData()
        Dim query As String = "select * from student where stuName like @a+'%'"
        Dim cmd As New SqlCommand(query, con)
        cmd.Parameters.AddWithValue("@a", Guna2TextBox1.Text)
        Dim a As New SqlDataAdapter(cmd)
        Dim dt As New DataTable
        a.Fill(dt)
        Guna2DataGridView1.DataSource = dt
    End Sub
    Private Sub search_btn_Click(sender As Object, e As EventArgs) Handles search_btn.Click
        searchStudentData()
    End Sub
End Class