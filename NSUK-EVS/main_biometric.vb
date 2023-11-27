Imports MySql.Data.MySqlClient
Imports System.IO
Imports System.Speech.Synthesis
Imports DPFP
Public Class main_biometric
    Private data As AppData
    Private enroller As Enrollment
    Public WithEvents appdata As AppData
    Private templatedata As DPFP.Data
    Public registration As String
    Dim mysqlconn As MySqlConnection
    Dim dr As MySqlDataReader
    Dim cmd As MySqlCommand

    Public Shared connection = "server= localhost;" _
      & "user id=root;" _
      & "port= 3306 ;" _
      & "password= ;" _
      & "database=exam_verification"

    Private Property speech As Object
    Private Sub wait(p1 As Integer)
        Throw New NotImplementedException
    End Sub
    Private Sub Main_biometric_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Guna.UI.Lib.GraphicsHelper.ShadowForm(Me)
        Dim firstName As String = GlobalData.Fullname
        Dim department As String = GlobalData.Department
        Dim faculty As String = GlobalData.Faculty
        Dim level As String = GlobalData.Level
        registration = GlobalData.student_matric
        If Not String.IsNullOrEmpty(GlobalData.PassportImageString) Then
            ' Convert the Base64 string to a byte array
            Dim imageData As Byte() = Convert.FromBase64String(GlobalData.PassportImageString)

            ' Create an Image object from the byte array
            Dim passportImage As Image = Image.FromStream(New MemoryStream(imageData))

            ' Resize the image to fit the PictureBox control
            Dim pictureBoxSize As Size = PictureBox2.Size ' Use the Size property, not SizeMode
            Dim resizedImage As Image = passportImage.GetThumbnailImage(pictureBoxSize.Width, pictureBoxSize.Height, Nothing, IntPtr.Zero)

            ' Set the Image property of the PictureBox control to the resized image
            PictureBox2.Image = resizedImage

            ' Clear the PassportImageString after displaying the image
            GlobalData.PassportImageString = ""


        Else
            ' display a default image or a message indicating that the image is not available
            Dim defaultImage As Image = My.Resources._new
            PictureBox2.Image = defaultImage
        End If

        student_name.Text = GlobalData.Fullname
        matricnumber.Text = GlobalData.student_matric
        dateofbirth.Text = GlobalData.DateofBirth
        student_faculty.Text = GlobalData.Faculty
        student_department.Text = GlobalData.Department
        student_level.Text = GlobalData.Level
    End Sub



    Sub startenrollerment()
        exchangedata(True)
        If data.EnrolledFingersMask = data.MaxEnrollFingerCount Then
            MessageBox.Show("Enrollment Complete")
            ' or you can use the speech API to notify the user
            ' speech.speak("Enrollment Complete")
        End If
        Dim frmControl As Form = enroller
        With frmControl
            .FormBorderStyle = Windows.Forms.FormBorderStyle.None
            .TopLevel = True ' Change to True to open as a top-level form
            .BackColor = Color.White
        End With
        frmControl.Show()
        frmControl.StartPosition = FormStartPosition.CenterScreen
        frmControl.WindowState = FormWindowState.Normal

    End Sub


    Sub save()
        If Not Directory.Exists(Application.StartupPath & "\enrolled_fingers") Then
            Directory.CreateDirectory(Application.StartupPath & "\enrolled_fingers")
        End If

        If My.Computer.FileSystem.FileExists(Application.StartupPath & "\enrolled_fingers\" & GlobalData.student_matric & ".fpt") Then
            If MessageBox.Show("This Student have already been Captured", "", MessageBoxButtons.YesNo) = DialogResult.No Then
                Exit Sub
            Else

                For Each template As DPFP.Template In data.Templates

                Next

                Using fs As IO.FileStream = IO.File.Open(Application.StartupPath & "\enrolled_fingers\" & GlobalData.student_matric & ".fpt", IO.FileMode.Create, IO.FileAccess.Write)
                    ' template.serialize(fs)
                End Using

                Try
                    wait(100)
                    speech = CreateObject("sapi.spvoice")
                    With speech
                        .voice = .getvoices.item(0)
                        .volume = 100
                        .rate = 3
                    End With

                    speech.speak("welcome ")
                    speech.speak("thank you for enrolling")
                Catch ex As Exception

                End Try

            End If
        Else



            Using fs As IO.FileStream = IO.File.Open(Application.StartupPath & "\enrolled_fingers\" & GlobalData.student_matric & ".fpt", IO.FileMode.Create, IO.FileAccess.Write)
                'template.serialize(fs)
            End Using
        End If

        Dim cmd As New MySqlCommand
        'Me.Text = "home - enrollment"


        ' Dim cmd As New MySqlCommand

        mysqlconn = New MySqlConnection
        mysqlconn.ConnectionString = connection

        ' Save other enrollment data in the database
        Using mysqlconn As New MySqlConnection(connection)
            mysqlconn.Open()

            Using sqlcommand As New MySqlCommand()
                With sqlcommand
                    .CommandText = "UPDATE student_enrollment SET fingerdata1 = @fingerdata1, fingerdata2 = @fingerdata2, " &
                                       "fingerdata3 = @fingerdata3, fingerdata4 = @fingerdata4, fingerdata5 = @fingerdata5, " &
                                       "fingerdata6 = @fingerdata6, fingerdata7 = @fingerdata7, fingerdata8 = @fingerdata8, " &
                                       "fingerdata9 = @fingerdata9, fingerdata10 = @fingerdata10 WHERE student_matric = @student_matric"
                    .Connection = mysqlconn
                    .CommandType = CommandType.Text
                    ' Add parameters and values
                    .Parameters.AddWithValue("@student_matric", GlobalData.student_matric)
                    Dim pp1 As New MySqlParameter("@fingerdata1", MySqlDbType.MediumBlob)
                    Dim pp2 As New MySqlParameter("@fingerdata2", MySqlDbType.MediumBlob)
                    Dim pp3 As New MySqlParameter("@fingerdata3", MySqlDbType.MediumBlob)
                    Dim pp4 As New MySqlParameter("@fingerdata4", MySqlDbType.MediumBlob)
                    Dim pp5 As New MySqlParameter("@fingerdata5", MySqlDbType.MediumBlob)
                    Dim pp6 As New MySqlParameter("@fingerdata6", MySqlDbType.MediumBlob)
                    Dim pp7 As New MySqlParameter("@fingerdata7", MySqlDbType.MediumBlob)
                    Dim pp8 As New MySqlParameter("@fingerdata8", MySqlDbType.MediumBlob)
                    Dim pp9 As New MySqlParameter("@fingerdata9", MySqlDbType.MediumBlob)
                    Dim pp10 As New MySqlParameter("@fingerdata10", MySqlDbType.MediumBlob)


                    Dim ms1 As New MemoryStream()
                    Dim ms2 As New MemoryStream()
                    Dim ms3 As New MemoryStream()
                    Dim ms4 As New MemoryStream()

                End With

                sqlcommand.ExecuteNonQuery()

                ' Update status if PassportImageString is not empty
                If GlobalData.PassportImageString <> "" Then
                    Using updateCmd As New MySqlCommand()
                        updateCmd.CommandText = "UPDATE student_enrollment SET status = 3 WHERE student_matric = @student_matric AND PassportImageString <> ''"
                        updateCmd.Connection = mysqlconn
                        updateCmd.CommandType = CommandType.Text
                        updateCmd.Parameters.AddWithValue("@student_matric", GlobalData.student_matric)

                        updateCmd.ExecuteNonQuery()
                    End Using
                End If

                ' Notify user of successful enrollment
                MsgBox("Biometric saved successfully.", MsgBoxStyle.Information, "Biometric Enrollment")
            End Using
        End Using

    End Sub

    Private Sub exchangedata(ByVal read As Boolean)
        If (read) Then
            data.EnrolledFingersMask = 0

            data.MaxEnrollFingerCount = 10

            data.IsEventHandlerSucceeds = True
            data.Update()
        Else
            Mask.Value = data.EnrolledFingersMask
            MaxFingers.Value = data.MaxEnrollFingerCount
            IsSuccess.Checked = data.IsEventHandlerSucceeds


            'isfailure.checked = Not IsSuccess.Checked
            'isfeaturesetmatched.checked = data.IsFeatureSetMatched
            'falseacceptrate.text = data.FalseAcceptRate.ToString()
            'verifybutton.enabled = data.EnrolledFingersMask > 0
        End If
    End Sub
    Private Sub ondatachange()
        exchangedata(False)
    End Sub

    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        Dim openFileDialog1 As New OpenFileDialog()

        ' Set the filter to allow only png and jpg files
        openFileDialog1.Filter = "Image Files (*.png, *.jpg)|*.png;*.jpg"

        ' If the user selects a file and clicks the OK button, load the image into the picturebox
        If openFileDialog1.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
            ' Check if the file size is less than 500 KB
            Dim fileInfo As New FileInfo(openFileDialog1.FileName)
            If fileInfo.Length <= 500 * 1024 Then ' 500 KB in bytes
                PictureBox2.Image = Image.FromFile(openFileDialog1.FileName)
            Else

                MessageBox.Show("The selected image file is too large. Please select a file that is less than 500 KB in size.", "Image Size")
            End If
        End If
    End Sub
    Private Sub Guna2Button2_Click(sender As Object, e As EventArgs) Handles Guna2Button2.Click
        ' Get the image data from the picturebox
        Dim image As Image = PictureBox2.Image
        Dim ms As New MemoryStream()
        image.Save(ms, image.RawFormat)
        Dim imageData As Byte() = ms.ToArray()

        ' Establish a connection to the MySQL database
        Dim connString As String = "server=localhost;port=3306;user=root;password=;database=exam_verification;"
        Dim conn As New MySqlConnection(connString)
        conn.Open()

        ' Create the SQL query to insert the image data into the table
        Dim query As String = "UPDATE student_enrollment SET passport = @passport, status = @status, Iscaptured = @captured WHERE student_matric = @registration_number"
        Dim cmd As New MySqlCommand(query, conn)
        cmd.Parameters.AddWithValue("@passport", imageData)
        cmd.Parameters.AddWithValue("@status", "1")
        cmd.Parameters.AddWithValue("@captured", "1")
        cmd.Parameters.AddWithValue("@registration_number", GlobalData.student_matric)
        Dim rowsUpdated As Integer = cmd.ExecuteNonQuery()


        ' Close the database connection
        conn.Close()

        ' Show a success message if the query was successful
        If rowsUpdated > 0 Then
            MessageBox.Show("Passport uploaded successfully! Please Click on Start Enrollment to Capture Fingerprint", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            MessageBox.Show("An error occurred while uploading the image.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If String.IsNullOrWhiteSpace(GlobalData.student_matric) Then
        Else
            data = New AppData()
            AddHandler data.OnChange, AddressOf ondatachange
            enroller = New Enrollment(data)
            exchangedata(False)
            startenrollerment()
        End If
    End Sub

    Private Sub Guna2Button3_Click(sender As Object, e As EventArgs) Handles Guna2Button3.Click
        Me.Close()
        login.Show()
    End Sub


End Class