Imports MySql.Data.MySqlClient
Imports System.Security.Cryptography
Imports System.Text
Imports BCrypt.Net

Public Class login
    Dim newconnect As New MySqlConnection("server=localhost;" _
    & "user id=root;" _
    & "port= 3306 ;" _
    & "password=;" _
    & "database=exam_verification")

    Dim WithEvents Timer1 As New Timer With {.Interval = 5000} ' set the timer interval to 5 seconds

    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Guna.UI.Lib.GraphicsHelper.ShadowForm(Me)

        ' start the timer when the form loads
        Timer1.Start()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Try
            newconnect.Open()
            If newconnect.State = ConnectionState.Open Then
                Label4.Text = "CONNECTED"
                Label4.ForeColor = Color.Green
            End If
        Catch ex As Exception
            Label4.Text = "NOT CONNECTED"
            Label4.ForeColor = Color.Red
        Finally
            newconnect.Close() ' close the connection
        End Try
    End Sub

    Private Sub Guna2Button2_Click(sender As Object, e As EventArgs) Handles Guna2Button2.Click
        Me.Close()
    End Sub

    Private Sub Guna2HtmlLabel4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub

    Private Sub Btnlogin_Click(sender As Object, e As EventArgs) Handles btnlogin.Click
        Dim connection As New MySqlConnection("server=localhost;" _
& "user id=root;" _
& "port=3306;" _
& "password=;" _
& "database=exam_verification")
        Dim Connection2 As New MySqlDataAdapter("SELECT email_address, password FROM administrator WHERE email_address='" & txtusername.Text & "'", connection)
        Dim DataTable As New DataTable()

        Try
            connection.Open()
            Connection2.Fill(DataTable)

            If DataTable IsNot Nothing AndAlso DataTable.Rows.Count() > 0 Then
                ' Retrieve the hashed password from the database
                Dim hashedPassword As String = DataTable.Rows(0)("password").ToString()
                Dim normalpasssword As String = txtpassword.Text
                ' Verify the entered password against the hashed password

                ' Password is correct, proceed with login
                If BCrypt.Net.BCrypt.Verify(normalpasssword, hashedPassword) Then
                    MessageBox.Show("You have logged in successfully.", "Login Successful", MessageBoxButtons.OK, MessageBoxIcon.Information)

                    Me.Close()
                    main_enrollment.Show()
                Else
                    ' Password is incorrect
                    MessageBox.Show("Incorrect username or password. Please try again.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            End If

        Catch ex As Exception
            MessageBox.Show("An error occurred while trying to login. Error: " & ex.Message, "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            connection.Close()
        End Try

    End Sub


End Class