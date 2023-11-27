Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Guna.UI.Lib.GraphicsHelper.ShadowForm(Me)
    End Sub

    Private Sub FileSystemWatcher1_Changed(sender As Object, e As IO.FileSystemEventArgs) 

    End Sub

    Private Sub GunaLabel1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub GunaLabel3_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Timer1.Stop()
        Me.Hide()
        login.Show()
    End Sub

    Private Sub Guna2HtmlLabel3_Click(sender As Object, e As EventArgs) Handles Guna2HtmlLabel3.Click

    End Sub

    Private Sub Guna2HtmlLabel2_Click(sender As Object, e As EventArgs) Handles Guna2HtmlLabel2.Click

    End Sub
End Class
