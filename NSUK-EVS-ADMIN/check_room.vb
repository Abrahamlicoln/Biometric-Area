Imports MySql.Data.MySqlClient
Imports System.IO

Public Class check_room
    Dim mysqlconn As MySqlConnection
    Dim dr As MySqlDataReader
    Dim data As New DataTable
    Dim adapter As New MySqlDataAdapter
    Dim cmd As MySqlCommand
    Dim cnn As MySqlConnection
    Dim connectionString As String
    Dim Connection As New MySqlConnection("datasource=localhost; port=3306;user id=root;password=;database=exam_verification")

    Sub OnComplete(ByVal Control As Object, ByVal FeatureSet As DPFP.FeatureSet, ByRef EventHandlerStatus As DPFP.Gui.EventHandlerStatus) Handles VerificationControl.OnComplete
        Dim ver As New DPFP.Verification.Verification()
        Dim res As New DPFP.Verification.Verification.Result()
        Dim plo As Integer = 0

        Try
            ' Connect to the MySQL database.
            Dim connectionString As String = "Server=localhost;Port=3306;Database=exam_verification;Uid=root;Pwd=;"
            Dim connection As New MySqlConnection(connectionString)
            connection.Open()

            ' Retrieve the templates from the "new_enrollment" table.
            Dim query As String = "SELECT student_matric, fingerdata1, fingerdata2, fingerdata3, fingerdata4, fingerdata5, fingerdata6, fingerdata7, fingerdata8, fingerdata9, fingerdata10 FROM student_enrollment"

            Dim command As New MySqlCommand(query, connection)
            Dim reader As MySqlDataReader = command.ExecuteReader()

            While reader.Read()
                ' Iterate over the retrieved templates and compare them with the current feature set.
                For i As Integer = 1 To 10
                    Dim templateData As Byte() = CType(reader("fingerdata" & i), Byte())
                    Dim template As New DPFP.Template(New MemoryStream(templateData))
                    ver.Verify(FeatureSet, template, res)

                    If res.Verified Then
                        EventHandlerStatus = DPFP.Gui.EventHandlerStatus.Success
                        Dim student_matric As String = reader("student_matric").ToString()
                        autoselect(student_matric)
                        Exit While ' success
                    ElseIf Not res.Verified Then
                        EventHandlerStatus = DPFP.Gui.EventHandlerStatus.Failure
                            fullname1.Text = "_ _ _ _ _"
                            matric_number1.Text = "_ _ _ _ _"
                            level1.Text = "_ _ _ _ _"
                            faculty1.Text = "_ _ _ _ _"
                            course_code1.Text = "_ _ _ _ _"
                            course_title1.Text = "_ _ _ _ _ _"
                            course_code1.Text = "_ _ _ _ _ _"
                            department1.Text = "_ _ _ _ _"

                            Dim defaultImage As Image = My.Resources._new
                            PictureBox2.Image = defaultImage
                        End If

                Next
                plo += 1
            End While

            ' Close the database connection.
            reader.Close()
            connection.Close()
        Catch ex As Exception
            MessageBox.Show("This Student does not Exist",
                    "Registration Information",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error)
        End Try


    End Sub

    Sub autoselect(ByVal identity As String)
        Try
            Dim arrImage() As Byte = Nothing
            Dim dr As MySqlDataReader
            Dim department As String = ""
            Dim level As String = ""
            Dim fullname As String = ""
            Dim course_code As String = ""
            Dim course_title As String = ""
            Dim faculty As String = ""
            Dim matricnumber As String = ""

            ' Get the regno from registration
            Dim regno_query As String = "SELECT s.*, c.*, c.course_code, c.course_title " &
                                     "FROM student_enrollment s " &
                                     "INNER JOIN courses c ON s.student_matric = c.student_matric " &
                                     "WHERE s.student_matric = @identity AND s.IsCaptured = '1' AND s.status = '3'"

            cmd = New MySqlCommand(regno_query, Connection)
            cmd.Parameters.AddWithValue("@identity", identity)

            Connection.Open()
            dr = cmd.ExecuteReader()

            If dr.Read() Then
                fullname = dr("fullname")
                matricnumber = dr("student_matric")
                course_code = dr("course_code")
                course_title = dr("course_title")
                faculty = dr("Faculty")
                department = dr("Department")
                level = dr("Level")

                Dim imageBytes As Byte() = DirectCast(dr("passport"), Byte())
                If imageBytes IsNot Nothing AndAlso imageBytes.Length > 0 Then
                    Using stream As New System.IO.MemoryStream(imageBytes)
                        PictureBox2.Image = Image.FromStream(stream)
                    End Using
                End If


            End If

            dr.Close()
            Connection.Close()



            dr.Close()
            Connection.Close()


            'Set the department in the UI
            Invoke(New FunctionCall(AddressOf setlevel), level)
            Invoke(New FunctionCall(AddressOf setfullname), fullname)
            Invoke(New FunctionCall(AddressOf setfaculty), faculty)
            Invoke(New FunctionCall(AddressOf setdepartment), department)
            Invoke(New FunctionCall(AddressOf setmatricnumber), matricnumber)
            Invoke(New FunctionCall(AddressOf setcoursecode), course_code)
            Invoke(New FunctionCall(AddressOf setcoursetitle), course_title)


        Catch ex As MySqlException
            MsgBox(ex.ToString, MsgBoxStyle.Exclamation, "")
        End Try
    End Sub
    Private Sub setlevel(ByVal level As String)
        level1.Text = level
    End Sub
    Private Sub setfullname(ByVal fullname As String)
        fullname1.Text = fullname
    End Sub

    Private Sub setcoursecode(ByVal course_code As String)
        course_code1.Text = course_code
    End Sub
    Private Sub setcoursetitle(ByVal course_title As String)
        course_title1.Text = course_title
    End Sub

    Private Sub setfaculty(ByVal faculty As String)
        faculty1.Text = faculty
    End Sub
    Private Sub setdepartment(ByVal department As String)
        department1.Text = department
    End Sub
    Private Sub setmatricnumber(ByVal matric_number As String)
        matric_number1.Text = matric_number
    End Sub
    Private Sub Check_room_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Guna.UI.Lib.GraphicsHelper.ShadowForm(Me)
    End Sub

    Private Sub Faculty_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Guna2Button3_Click(sender As Object, e As EventArgs) Handles Guna2Button3.Click
        Me.Close()
    End Sub

    Private Sub Guna2HtmlLabel6_Click(sender As Object, e As EventArgs) Handles Guna2HtmlLabel6.Click

    End Sub
End Class