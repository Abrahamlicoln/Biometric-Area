
Public Class main_enrollment


    Private Sub Main_enrollment_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Guna.UI.Lib.GraphicsHelper.ShadowForm(Me)
        mainlabel.Text = "Welcome back, Administrator"
    End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        check_room.Show()
    End Sub


End Class