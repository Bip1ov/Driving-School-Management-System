Public Class Form2
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click
        Me.Close()
    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub LinkLabel2_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel2.LinkClicked
        Dim form1 As New Form1()
        form1.Show()
        Me.Hide()
    End Sub

    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        Dim username As String = Guna2TextBox1.Text
        Dim password As String = Guna2TextBox3.Text
        Dim confirm_password As String = Guna2TextBox2.Text

        If Len(username) < 5 Then
            MessageBox.Show("Username must be more than 5 characters.")
        ElseIf Len(password) < 6 Then
            MessageBox.Show("Password must be more than 6 characters.")
        ElseIf confirm_password <> password Then
            MessageBox.Show("Passwords do not match.")
        Else
            Dim dashboard As New dashboard()  ' Assuming Dashboard is the name of your dashboard form
            dashboard.Show()
            Me.Hide()
        End If
    End Sub


    Private Sub Guna2CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles Guna2CheckBox1.CheckedChanged
        Guna2TextBox3.UseSystemPasswordChar = Guna2CheckBox1.Checked
    End Sub
End Class