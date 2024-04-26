Public Class dashboard

    Dim fadeOutTimer As New Timer()

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        fadeOutTimer.Interval = 50
        AddHandler fadeOutTimer.Tick, AddressOf FadeOutTick
        courseAdd.loadInstructorForCourse()
        'dashboard Color 
        childForm(dashboardForm)
        dashboard_btn.BackColor = ColorTranslator.FromHtml("#8a127f")
        dashboard_btn.ForeColor = Color.White

        instructor_btn.BackColor = ColorTranslator.FromHtml("#1b263e")
        instructor_btn.ForeColor = ColorTranslator.FromHtml("#d22b87")

        student_btn.BackColor = ColorTranslator.FromHtml("#1b263e")
        student_btn.ForeColor = ColorTranslator.FromHtml("#d22b87")

        course_btn.BackColor = ColorTranslator.FromHtml("#1b263e")
        course_btn.ForeColor = ColorTranslator.FromHtml("#d22b87")

    End Sub

    Private Sub FadeOutTick(sender As Object, e As EventArgs)
        If Me.Opacity > 0 Then
            Me.Opacity -= 4000 ' Adjust the value to control the speed of the fade-out
        Else
            Me.Close()
        End If
    End Sub

    Private Sub Guna2ControlBox1_Click(sender As Object, e As EventArgs) Handles Guna2ControlBox1.Click
        fadeOutTimer.Start()
    End Sub

    Public Sub childForm(ByVal CHpanel As Form)
        parentPanel.Controls.Clear()
        CHpanel.TopLevel = False
        parentPanel.Controls.Add(CHpanel)
        CHpanel.Show()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles dashboard_btn.Click
        childForm(dashboardForm)

        'colors
        dashboard_btn.BackColor = ColorTranslator.FromHtml("#8a127f")
        dashboard_btn.ForeColor = Color.White

        instructor_btn.BackColor = ColorTranslator.FromHtml("#1b263e")
        instructor_btn.ForeColor = ColorTranslator.FromHtml("#d22b87")

        student_btn.BackColor = ColorTranslator.FromHtml("#1b263e")
        student_btn.ForeColor = ColorTranslator.FromHtml("#d22b87")

        course_btn.BackColor = ColorTranslator.FromHtml("#1b263e")
        course_btn.ForeColor = ColorTranslator.FromHtml("#d22b87")





    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles instructor_btn.Click
        childForm(instructorForm)

        instructor_btn.BackColor = ColorTranslator.FromHtml("#8a127f")
        instructor_btn.ForeColor = Color.White

        dashboard_btn.BackColor = ColorTranslator.FromHtml("#1b263e")
        dashboard_btn.ForeColor = ColorTranslator.FromHtml("#d22b87")

        student_btn.BackColor = ColorTranslator.FromHtml("#1b263e")
        student_btn.ForeColor = ColorTranslator.FromHtml("#d22b87")

        course_btn.BackColor = ColorTranslator.FromHtml("#1b263e")
        course_btn.ForeColor = ColorTranslator.FromHtml("#d22b87")




    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles student_btn.Click
        childForm(student)

        student_btn.BackColor = ColorTranslator.FromHtml("#8a127f")
        student_btn.ForeColor = Color.White

        instructor_btn.BackColor = ColorTranslator.FromHtml("#1b263e")
        instructor_btn.ForeColor = ColorTranslator.FromHtml("#d22b87")

        dashboard_btn.BackColor = ColorTranslator.FromHtml("#1b263e")
        dashboard_btn.ForeColor = ColorTranslator.FromHtml("#d22b87")

        course_btn.BackColor = ColorTranslator.FromHtml("#1b263e")
        course_btn.ForeColor = ColorTranslator.FromHtml("#d22b87")




    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles course_btn.Click
        childForm(courseForm)

        course_btn.BackColor = ColorTranslator.FromHtml("#8a127f")
        course_btn.ForeColor = Color.White

        instructor_btn.BackColor = ColorTranslator.FromHtml("#1b263e")
        instructor_btn.ForeColor = ColorTranslator.FromHtml("#d22b87")

        dashboard_btn.BackColor = ColorTranslator.FromHtml("#1b263e")
        dashboard_btn.ForeColor = ColorTranslator.FromHtml("#d22b87")

        student_btn.BackColor = ColorTranslator.FromHtml("#1b263e")
        student_btn.ForeColor = ColorTranslator.FromHtml("#d22b87")






    End Sub


End Class