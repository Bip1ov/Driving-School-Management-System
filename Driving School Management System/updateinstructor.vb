Imports System.Data.SqlClient
Public Class updateinstructor
    Dim con As New SqlConnection("Data Source=BIPLOV\MSSQLSERVER04;Initial Catalog=DSM_OCEM;Integrated Security=True")
    Private Sub Guna2ControlBox2_Click(sender As Object, e As EventArgs) Handles Guna2ControlBox2.Click
        Me.Close()
    End Sub
    Public Sub reset()
        Guna2TextBox1.Clear()
        Guna2TextBox3.Clear()
        Guna2TextBox4.Clear()
        Guna2TextBox5.Clear()
        Guna2TextBox6.Clear()

    End Sub
    Public Sub loadInstructorDataForUpdate()
        Guna2TextBox1.Text = instructorForm.Guna2DataGridView1.SelectedRows(0).Cells(1).Value
        Guna2TextBox3.Text = instructorForm.Guna2DataGridView1.SelectedRows(0).Cells(2).Value
        Guna2TextBox4.Text = instructorForm.Guna2DataGridView1.SelectedRows(0).Cells(3).Value
        Guna2TextBox5.Text = instructorForm.Guna2DataGridView1.SelectedRows(0).Cells(4).Value
        Guna2TextBox6.Text = instructorForm.Guna2DataGridView1.SelectedRows(0).Cells(5).Value
        Guna2DateTimePicker1.Value = instructorForm.Guna2DataGridView1.SelectedRows(0).Cells(6).Value




    End Sub

    Public Sub updateInstructorData()
        Try
            Dim query As String = "update instructor set instName = @a, instEmail = @b, instPhone = @c, instAddress = @d, instNote = @e, instDob = @f where instid = @i"
            Dim cmd As New SqlCommand(query, con)
            cmd.Parameters.AddWithValue("@a", Guna2TextBox1.Text)
            cmd.Parameters.AddWithValue("@b", Guna2TextBox3.Text)
            cmd.Parameters.AddWithValue("@c", Guna2TextBox4.Text)
            cmd.Parameters.AddWithValue("@d", Guna2TextBox5.Text)
            cmd.Parameters.AddWithValue("@e", Guna2TextBox6.Text)
            cmd.Parameters.AddWithValue("@f", Guna2DateTimePicker1.Value)
            cmd.Parameters.AddWithValue("@i", instructorForm.Guna2DataGridView1.SelectedRows(0).Cells(0).Value)
            con.Open()
            cmd.ExecuteNonQuery()
            con.Close()
            MsgBox("Successfully Updated")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub update_btn_Click(sender As Object, e As EventArgs) Handles update_btn.Click
        updateInstructorData()
        instructorForm.showInstructorData()
        reset()
    End Sub

    Private Sub updateinstructor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loadInstructorDataForUpdate()
    End Sub

    Private Sub reset_btn_Click(sender As Object, e As EventArgs) Handles reset_btn.Click
        Me.Hide()
    End Sub
End Class