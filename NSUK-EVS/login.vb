Imports System.IO
Imports MySql.Data.MySqlClient
Imports System.Security.Cryptography
Imports System.Text

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

        ' Use student matric and date of birth for authentication
        Dim Connection2 As New MySqlDataAdapter("SELECT student_matric, status, fullname, Department, Faculty, Level, Date_of_Birth FROM student_enrollment WHERE student_matric='" & txtusername.Text & "' AND Date_of_Birth='" & txtDateOfBirth.Text & "'", connection)

        Dim DataTable As New DataTable()

        Try
            connection.Open()
            Connection2.Fill(DataTable)

            If DataTable IsNot Nothing AndAlso DataTable.Rows.Count() > 0 Then
                ' Authentication successful, proceed with login
                MessageBox.Show("You have logged in successfully.", "Login Successful", MessageBoxButtons.OK, MessageBoxIcon.Information)

                ' Store the retrieved values into session variables
                Dim row As DataRow = DataTable.Rows(0)
                GlobalData.Fullname = row("fullname").ToString()
                GlobalData.Department = row("Department").ToString()
                GlobalData.Faculty = row("Faculty").ToString()
                GlobalData.Level = row("Level").ToString()
                GlobalData.student_matric = row("student_matric").ToString()
                GlobalData.DateofBirth = row("Date_of_Birth").ToString()

                Dim status As String = row("status")

                If status = "1" Then
                    ' Passport is previously uploaded
                    MessageBox.Show("Passport is previously uploaded.", "Passport Already Uploaded", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    ' retrieve the image data from the database based on the email used for login
                    Dim Connection3 As New MySqlDataAdapter("SELECT passport FROM student_enrollment WHERE student_matric='" & GlobalData.student_matric & "'", connection)
                    Dim DataTable2 As New DataTable()
                    Connection3.Fill(DataTable2)
                    If DataTable2 IsNot Nothing AndAlso DataTable2.Rows.Count() > 0 Then
                        Dim row2 As DataRow = DataTable2.Rows(0)
                        ' get the image data as a byte array
                        Dim imageData As Byte() = DirectCast(row2("passport"), Byte())
                        ' convert the image data to a Base64 string
                        Dim base64String As String = Convert.ToBase64String(imageData)
                        ' store the Base64 string in the GlobalData
                        GlobalData.PassportImageString = base64String
                    Else
                        MessageBox.Show("An error occurred while trying to retrieve the passport image.", "Passport Retrieval Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End If


                ElseIf status = "2" Then
                    ' FingerPrint has already been captured
                    MessageBox.Show("FingerPrint has already been captured.", "FingerPrint Already Captured", MessageBoxButtons.OK, MessageBoxIcon.Information)

                ElseIf status = "3" Then
                    ' Enrollment already done
                    MessageBox.Show("You have already enrolled this student.", "Enrollment Already Done", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Exit Sub
                Else
                    ' Row status is invalid
                    main_biometric.Show()
                End If

                Me.Close()
                main_biometric.Show()
            Else
                ' Authentication failed
                MessageBox.Show("Incorrect Student Matric or Date of Birth. Please try again.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If

        Catch ex As Exception
            MessageBox.Show("An error occurred while trying to login. Error: " & ex.Message, "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            connection.Close()
        End Try
    End Sub


End Class