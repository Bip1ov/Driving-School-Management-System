Imports System.Data.SqlClient

Public Class courseForm
    Dim con As New SqlConnection("Data Source=BIPLOV\MSSQLSERVER04;Initial Catalog=DSM_OCEM;Integrated Security=True")

    Private Sub Guna2Button4_Click(sender As Object, e As EventArgs) Handles Guna2Button4.Click
        courseAdd.ShowDialog()
    End Sub

    Public Sub loadCourseData()
        Try
            Dim query As String = "select * from course"
            Dim cmd As New SqlCommand(query, con)
            Dim a As New SqlDataAdapter(cmd)
            Dim dt As New DataTable
            a.Fill(dt)
            Guna2DataGridView1.DataSource = dt
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub courseForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loadCourseData()
    End Sub
    Public Sub deleteCourseData()
        Try
            Dim query As String = "delete from course where courseid = @a"
            Dim cmd As New SqlCommand(query, con)
            cmd.Parameters.AddWithValue("@a", Guna2DataGridView1.SelectedRows(0).Cells(0))
            con.Open()
            cmd.ExecuteNonQuery()
            con.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
            con.Close()
        End Try
    End Sub
    Private Sub Guna2Button3_Click(sender As Object, e As EventArgs) Handles Guna2Button3.Click

        deleteCourseData()
        loadCourseData()
    End Sub
End Class