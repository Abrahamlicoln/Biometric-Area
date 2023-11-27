Imports MySql.Data.MySqlClient
Imports System.IO
Public Class Enrollment

    Public Data As AppData
    Dim counter As Integer = 0
    Dim mysqlconn As MySqlConnection
    Dim dr As MySqlDataReader
    Dim cmd As MySqlCommand

    Sub New(ByVal data As AppData)
        InitializeComponent()
        Me.Data = data
        ExchangeData(False)
        AddHandler data.OnChange, AddressOf OnDataChange

    End Sub

    Private Sub OnDataChange()
        ExchangeData(False)
    End Sub

    Public Sub ExchangeData(ByVal read As Boolean)
        If (read) Then
            Data.EnrolledFingersMask = EnrollmentControl.EnrolledFingerMask
            Data.MaxEnrollFingerCount = EnrollmentControl.MaxEnrollFingerCount
            Data.Update()
        Else
            EnrollmentControl.EnrolledFingerMask = Data.EnrolledFingersMask
            EnrollmentControl.MaxEnrollFingerCount = Data.MaxEnrollFingerCount
        End If
    End Sub

    Sub EnrollmentControl_OnEnroll(ByVal Control As Object, ByVal Finger As Integer, ByVal Template As DPFP.Template, ByRef EventHandlerStatus As DPFP.Gui.EventHandlerStatus) Handles EnrollmentControl.OnEnroll
        If (Data.IsEventHandlerSucceeds) Then
            Data.Templates(Finger - 1) = Template
            ExchangeData(True)
            ListEvents.Items.Insert(0, String.Format("OnEnroll: finger {0}", Finger))
            saveme(Finger, Template)
            counter += 1

            ' Check if the counter is equal to the maximum number of enrolled fingers
            If counter = Data.MaxEnrollFingerCount Then
                ' Update the status of the user in the database to 3
                Try
                    mysqlconn = New MySqlConnection(main_biometric.connection)
                    mysqlconn.Open()

                    cmd = New MySqlCommand("UPDATE student_enrollment SET status=3 WHERE student_matric='" & GlobalData.student_matric & "'", mysqlconn)
                    cmd.ExecuteNonQuery()
                    MsgBox("Biometric Saved Successfully", MsgBoxStyle.Information, "Biometric Enrollment")
                    mysqlconn.Close()

                Catch ex As Exception
                    MessageBox.Show(ex.Message)
                Finally
                    mysqlconn.Dispose()
                End Try
            End If

        Else
            EventHandlerStatus = DPFP.Gui.EventHandlerStatus.Failure
        End If
    End Sub


    Sub EnrollmentControl_OnDelete(ByVal Control As Object, ByVal Finger As Integer, ByRef EventHandlerStatus As DPFP.Gui.EventHandlerStatus) Handles EnrollmentControl.OnDelete
        If (Data.IsEventHandlerSucceeds) Then
            Data.Templates(Finger - 1) = Nothing
            ExchangeData(True)
            ListEvents.Items.Insert(0, String.Format("OnDelete: finger {0}", Finger))
            counter -= 1
            deleteprint(Finger, Data.EnrolledFingersMask)
        Else
            EventHandlerStatus = DPFP.Gui.EventHandlerStatus.Failure
        End If
    End Sub

    Private Sub EnrollmentControl_OnCancelEnroll(ByVal Control As System.Object, ByVal ReaderSerialNumber As System.String, ByVal Finger As System.Int32) Handles EnrollmentControl.OnCancelEnroll
        ListEvents.Items.Insert(0, String.Format("OnCancelEnroll: {0}, finger {1}", ReaderSerialNumber, Finger))
    End Sub

    Private Sub EnrollmentControl_OnComplete(ByVal Control As System.Object, ByVal ReaderSerialNumber As System.String, ByVal Finger As System.Int32) Handles EnrollmentControl.OnComplete
        ListEvents.Items.Insert(0, String.Format("OnComplete: {0}, finger {1}", ReaderSerialNumber, Finger))
    End Sub

    Private Sub EnrollmentControl_OnFingerRemove(ByVal Control As System.Object, ByVal ReaderSerialNumber As System.String, ByVal Finger As System.Int32) Handles EnrollmentControl.OnFingerRemove
        ListEvents.Items.Insert(0, String.Format("OnFingerRemove: {0}, finger {1}", ReaderSerialNumber, Finger))
    End Sub

    Private Sub EnrollmentControl_OnFingerTouch(ByVal Control As System.Object, ByVal ReaderSerialNumber As System.String, ByVal Finger As System.Int32) Handles EnrollmentControl.OnFingerTouch
        ListEvents.Items.Insert(0, String.Format("OnFingerTouch: {0}, finger {1}", ReaderSerialNumber, Finger))
    End Sub

    Private Sub EnrollmentControl_OnReaderConnect(ByVal Control As System.Object, ByVal ReaderSerialNumber As System.String, ByVal Finger As System.Int32) Handles EnrollmentControl.OnReaderConnect
        ListEvents.Items.Insert(0, String.Format("OnReaderConnect: {0}, finger {1}", ReaderSerialNumber, Finger))
    End Sub

    Private Sub EnrollmentControl_OnReaderDisconnect(ByVal Control As System.Object, ByVal ReaderSerialNumber As System.String, ByVal Finger As System.Int32) Handles EnrollmentControl.OnReaderDisconnect
        ListEvents.Items.Insert(0, String.Format("OnReaderDisconnect: {0}, finger {1}", ReaderSerialNumber, Finger))
    End Sub

    Private Sub EnrollmentControl_OnSampleQuality(ByVal Control As System.Object, ByVal ReaderSerialNumber As System.String, ByVal Finger As System.Int32, ByVal CaptureFeedback As DPFP.Capture.CaptureFeedback) Handles EnrollmentControl.OnSampleQuality
        ListEvents.Items.Insert(0, String.Format("OnSampleQuality: {0}, finger {1}, {2}", ReaderSerialNumber, Finger, CaptureFeedback))
    End Sub

    Private Sub EnrollmentControl_OnStartEnroll(ByVal Control As System.Object, ByVal ReaderSerialNumber As System.String, ByVal Finger As System.Int32) Handles EnrollmentControl.OnStartEnroll
        ListEvents.Items.Insert(0, String.Format("OnStartEnroll: {0}, finger {1}", ReaderSerialNumber, Finger))
    End Sub





    Private Sub CloseButton_Click(sender As System.Object, e As System.EventArgs)

        'If counter <> 3 Then
        '    MsgBox("3 different fingers need to be enrolled")
        'Else
        '    Me.Close()
        '    Form1.Panel1.BackgroundImage = My.Resources.punchclock_app
        'End If

    End Sub

    Sub saveme(ByVal Finger As Integer, ByVal Templatee As DPFP.Template)
        Dim cmd As New MySqlCommand

        mysqlconn = New MySqlConnection
        mysqlconn.ConnectionString = main_biometric.connection

        Dim sup As Integer = 0
        Dim dr As MySqlDataReader
        Dim query As String

        mysqlconn.Open()

        Try
            ' Check if the student with the given matric number exists in the table
            query = "SELECT COUNT(*) AS nm FROM student_enrollment WHERE student_matric = '" & main_biometric.registration & "'"
            If mysqlconn.State = ConnectionState.Closed Then mysqlconn.Open()
            cmd = New MySqlCommand(query, mysqlconn)
            dr = cmd.ExecuteReader()
            If dr.Read = True Then
                sup = dr("nm")
            End If
            mysqlconn.Close()
            dr.Close()
        Catch ex As Exception
            ' Handle exceptions if necessary
        End Try

        Using sqlCommand As New MySqlCommand()
            With sqlCommand
                ' If the student exists, update the existing record; otherwise, insert a new record
                If sup > 0 Then
                    .CommandText = "UPDATE student_enrollment SET fingerdata" & Finger & " = @fingerdata, fingermask = @fingermask WHERE student_matric = @identification"
                Else
                    .CommandText = "INSERT INTO student_enrollment (student_matric, fingerdata" & Finger & ", fingermask) VALUES (@identification, @fingerdata, @fingermask)"
                End If

                .Connection = mysqlconn
                .CommandType = CommandType.Text
                .Parameters.AddWithValue("@identification", main_biometric.registration)
                .Parameters.AddWithValue("@fingermask", EnrollmentControl.EnrolledFingerMask)
                Dim pp1 As New MySqlParameter("@fingerdata", MySqlDbType.MediumBlob)
                Dim ms1 As New MemoryStream()
                Templatee.Serialize(ms1)
                Dim data As Byte() = ms1.GetBuffer()
                pp1.Value = data
                .Parameters.Add(pp1)
            End With

            Try
                If mysqlconn.State = ConnectionState.Closed Then mysqlconn.Open()
                sqlCommand.ExecuteNonQuery()
            Catch ex As MySqlException
                MsgBox(ex.ToString)
                ' Handle exceptions if necessary
            Finally
                mysqlconn.Close()
            End Try
        End Using
    End Sub


    Sub deleteprint(ByVal finger As Integer, ByVal fingermask As Object)
        Try
            Dim mysqlconn = New MySqlConnection
            mysqlconn.ConnectionString = main_biometric.connection
            Dim query = "update student_enrollment set fingerdata" & finger & " = null where student_matric = '" & main_biometric.registration & "';update student_enrollment set fingermask = " & Data.EnrolledFingersMask & " where identification = '" & main_biometric.registration & "' "
            If mysqlconn.State = ConnectionState.Closed Then mysqlconn.Open()
            cmd = New MySqlCommand(query, mysqlconn)
            cmd.ExecuteNonQuery()
            mysqlconn.Close()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub EnrollmentControl_Load(sender As Object, e As EventArgs) Handles EnrollmentControl.Load

    End Sub

    'Protected Overridable Sub Process(ByVal Sample As DPFP.Sample)
    '    ConvertSampleToBitmap(Sample)
    'End Sub

    'Protected Function ConvertSampleToBitmap(ByVal Sample As DPFP.Sample) As Bitmap
    '    Dim convertor As New DPFP.Capture.SampleConversion()  ' Create a sample convertor.
    '    Dim bitmap As Bitmap = Nothing              ' TODO: the size doesn't matter
    '    convertor.ConvertToPicture(Sample, bitmap)

    '    Try
    '        Invoke(New FunctionCall(AddressOf _picturebox1draw), bitmap)
    '    Catch ex As Exception

    '    End Try

    '    Return bitmap
    'End Function

    'Sub _picturebox1draw(ByVal bmp)
    '    PictureBox1.Image = New Bitmap(bmp, 157, 168)
    'End Sub
    Private Sub Enrollment_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim firstName As String = GlobalData.Fullname
        label7.Text = "We will Soon Finish " + Fullname
    End Sub

    Private Sub Guna2Button2_Click(sender As Object, e As EventArgs) Handles Guna2Button2.Click
        Me.Close()

    End Sub
End Class