Imports System.Data.SqlClient

Public Class instructorForm
    Dim con As New SqlConnection("Data Source=BIPLOV\MSSQLSERVER04;Initial Catalog=DSM_OCEM;Integrated Security=True")
    Private Sub Guna2Button4_Click(sender As Object, e As EventArgs) Handles Guna2Button4.Click
        enrollinstructor.ShowDialog()
    End Sub

    Public Sub showInstructorData()
        Try
            Dim query As String = "select * from instructor"
            Dim cmd As New SqlCommand(query, con)
            Dim a As New SqlDataAdapter(cmd)
            Dim dt As New DataTable
            a.Fill(dt)
            Guna2DataGridView1.DataSource = dt
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub instructorForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        showInstructorData()
    End Sub

    Public Sub deleteInstructorData()
        Try
            Dim query As String = "delete from instructor where instid = @a"
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
        If MessageBox.Show("Are You Sure to Delete ?", "confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = DialogResult.Yes Then
            deleteInstructorData()
            showInstructorData()
        End If
    End Sub

    Private Sub update_btn_Click(sender As Object, e As EventArgs) Handles update_btn.Click
        updateinstructor.ShowDialog()
    End Sub

    Public Sub searchInstructor()
        Dim query As String = "select * from instructor where instName like @a+'%'"
        Dim cmd As New SqlCommand(query, con)
        cmd.Parameters.AddWithValue("@a", Guna2TextBox1.Text)
        Dim a As New SqlDataAdapter(cmd)
        Dim dt As New DataTable
        a.Fill(dt)
        If dt.Rows.Count > 0 Then
            Guna2DataGridView1.DataSource = dt
        End If
    End Sub
    Private Sub search_btn_Click(sender As Object, e As EventArgs) Handles search_btn.Click
        searchInstructor()
    End Sub
End Class