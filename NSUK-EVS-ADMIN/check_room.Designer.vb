<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class check_room
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim gbReturnValues As System.Windows.Forms.GroupBox
        Dim lblFalseAcceptRate As System.Windows.Forms.Label
        Dim lblPrompt As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(check_room))
        Me.FalseAcceptRate = New System.Windows.Forms.TextBox()
        Me.Guna2Elipse1 = New Guna.UI2.WinForms.Guna2Elipse(Me.components)
        Me.Guna2HtmlLabel1 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2PictureBox1 = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.PictureBox2 = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.Guna2HtmlLabel2 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2HtmlLabel4 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2HtmlLabel5 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2HtmlLabel6 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2HtmlLabel7 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2HtmlLabel8 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2HtmlLabel9 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.firstname = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.lastname = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2Button3 = New Guna.UI2.WinForms.Guna2Button()
        Me.VerificationControl = New DPFP.Gui.Verification.VerificationControl()
        Me.middlename = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.middlename1 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.fullname1 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.level1 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.matric_number1 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.faculty1 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.course_code1 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.course_title1 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.department1 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        gbReturnValues = New System.Windows.Forms.GroupBox()
        lblFalseAcceptRate = New System.Windows.Forms.Label()
        lblPrompt = New System.Windows.Forms.Label()
        gbReturnValues.SuspendLayout()
        CType(Me.Guna2PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'gbReturnValues
        '
        gbReturnValues.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        gbReturnValues.BackColor = System.Drawing.Color.FromArgb(CType(CType(76, Byte), Integer), CType(CType(112, Byte), Integer), CType(CType(247, Byte), Integer))
        gbReturnValues.Controls.Add(Me.FalseAcceptRate)
        gbReturnValues.Controls.Add(lblFalseAcceptRate)
        gbReturnValues.ForeColor = System.Drawing.Color.White
        gbReturnValues.Location = New System.Drawing.Point(64, 403)
        gbReturnValues.Name = "gbReturnValues"
        gbReturnValues.Size = New System.Drawing.Size(315, 100)
        gbReturnValues.TabIndex = 26
        gbReturnValues.TabStop = False
        gbReturnValues.Text = "Return values"
        gbReturnValues.Visible = False
        '
        'FalseAcceptRate
        '
        Me.FalseAcceptRate.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.FalseAcceptRate.Location = New System.Drawing.Point(6, 41)
        Me.FalseAcceptRate.Name = "FalseAcceptRate"
        Me.FalseAcceptRate.ReadOnly = True
        Me.FalseAcceptRate.Size = New System.Drawing.Size(234, 24)
        Me.FalseAcceptRate.TabIndex = 2
        '
        'lblFalseAcceptRate
        '
        lblFalseAcceptRate.ForeColor = System.Drawing.Color.White
        lblFalseAcceptRate.Location = New System.Drawing.Point(44, 18)
        lblFalseAcceptRate.Name = "lblFalseAcceptRate"
        lblFalseAcceptRate.Size = New System.Drawing.Size(120, 20)
        lblFalseAcceptRate.TabIndex = 1
        lblFalseAcceptRate.Text = "False accept rate"
        lblFalseAcceptRate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblPrompt
        '
        lblPrompt.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        lblPrompt.Font = New System.Drawing.Font("Tahoma", 8.25!)
        lblPrompt.Location = New System.Drawing.Point(12, 56)
        lblPrompt.Name = "lblPrompt"
        lblPrompt.Size = New System.Drawing.Size(513, 24)
        lblPrompt.TabIndex = 25
        lblPrompt.Text = "To verify Student Details Let the Student Place his/her finger that enrolled duri" &
    "ng registration."
        '
        'Guna2HtmlLabel1
        '
        Me.Guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(93, Byte), Integer), CType(CType(43, Byte), Integer))
        Me.Guna2HtmlLabel1.Location = New System.Drawing.Point(45, 8)
        Me.Guna2HtmlLabel1.Name = "Guna2HtmlLabel1"
        Me.Guna2HtmlLabel1.Size = New System.Drawing.Size(325, 22)
        Me.Guna2HtmlLabel1.TabIndex = 11
        Me.Guna2HtmlLabel1.Text = "NSUK - Examination Verification System"
        '
        'Guna2PictureBox1
        '
        Me.Guna2PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2PictureBox1.Image = CType(resources.GetObject("Guna2PictureBox1.Image"), System.Drawing.Image)
        Me.Guna2PictureBox1.ImageRotate = 0!
        Me.Guna2PictureBox1.Location = New System.Drawing.Point(-10, 8)
        Me.Guna2PictureBox1.Name = "Guna2PictureBox1"
        Me.Guna2PictureBox1.Size = New System.Drawing.Size(67, 33)
        Me.Guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.Guna2PictureBox1.TabIndex = 12
        Me.Guna2PictureBox1.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.BorderRadius = 10
        Me.PictureBox2.Image = Global.NSUK_HMS.My.Resources.Resources._new
        Me.PictureBox2.ImageRotate = 0!
        Me.PictureBox2.Location = New System.Drawing.Point(70, 122)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(309, 325)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 27
        Me.PictureBox2.TabStop = False
        '
        'Guna2HtmlLabel2
        '
        Me.Guna2HtmlLabel2.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel2.Font = New System.Drawing.Font("Poppins", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel2.Location = New System.Drawing.Point(418, 131)
        Me.Guna2HtmlLabel2.Name = "Guna2HtmlLabel2"
        Me.Guna2HtmlLabel2.Size = New System.Drawing.Size(62, 25)
        Me.Guna2HtmlLabel2.TabIndex = 28
        Me.Guna2HtmlLabel2.Text = "Fullname"
        '
        'Guna2HtmlLabel4
        '
        Me.Guna2HtmlLabel4.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel4.Font = New System.Drawing.Font("Poppins", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel4.Location = New System.Drawing.Point(416, 199)
        Me.Guna2HtmlLabel4.Name = "Guna2HtmlLabel4"
        Me.Guna2HtmlLabel4.Size = New System.Drawing.Size(99, 25)
        Me.Guna2HtmlLabel4.TabIndex = 30
        Me.Guna2HtmlLabel4.Text = "Matric Number"
        '
        'Guna2HtmlLabel5
        '
        Me.Guna2HtmlLabel5.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel5.Font = New System.Drawing.Font("Poppins", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel5.Location = New System.Drawing.Point(418, 258)
        Me.Guna2HtmlLabel5.Name = "Guna2HtmlLabel5"
        Me.Guna2HtmlLabel5.Size = New System.Drawing.Size(50, 25)
        Me.Guna2HtmlLabel5.TabIndex = 31
        Me.Guna2HtmlLabel5.Text = "Faculty"
        '
        'Guna2HtmlLabel6
        '
        Me.Guna2HtmlLabel6.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel6.Font = New System.Drawing.Font("Poppins", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel6.Location = New System.Drawing.Point(666, 312)
        Me.Guna2HtmlLabel6.Name = "Guna2HtmlLabel6"
        Me.Guna2HtmlLabel6.Size = New System.Drawing.Size(82, 25)
        Me.Guna2HtmlLabel6.TabIndex = 32
        Me.Guna2HtmlLabel6.Text = "Department"
        '
        'Guna2HtmlLabel7
        '
        Me.Guna2HtmlLabel7.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel7.Font = New System.Drawing.Font("Poppins", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel7.Location = New System.Drawing.Point(666, 199)
        Me.Guna2HtmlLabel7.Name = "Guna2HtmlLabel7"
        Me.Guna2HtmlLabel7.Size = New System.Drawing.Size(35, 25)
        Me.Guna2HtmlLabel7.TabIndex = 33
        Me.Guna2HtmlLabel7.Text = "Level"
        '
        'Guna2HtmlLabel8
        '
        Me.Guna2HtmlLabel8.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel8.Font = New System.Drawing.Font("Poppins", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel8.Location = New System.Drawing.Point(417, 312)
        Me.Guna2HtmlLabel8.Name = "Guna2HtmlLabel8"
        Me.Guna2HtmlLabel8.Size = New System.Drawing.Size(87, 25)
        Me.Guna2HtmlLabel8.TabIndex = 34
        Me.Guna2HtmlLabel8.Text = "Course Code"
        '
        'Guna2HtmlLabel9
        '
        Me.Guna2HtmlLabel9.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel9.Font = New System.Drawing.Font("Poppins", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel9.Location = New System.Drawing.Point(417, 376)
        Me.Guna2HtmlLabel9.Name = "Guna2HtmlLabel9"
        Me.Guna2HtmlLabel9.Size = New System.Drawing.Size(78, 25)
        Me.Guna2HtmlLabel9.TabIndex = 35
        Me.Guna2HtmlLabel9.Text = "Course Title"
        '
        'firstname
        '
        Me.firstname.BackColor = System.Drawing.Color.Transparent
        Me.firstname.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.firstname.ForeColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(93, Byte), Integer), CType(CType(43, Byte), Integer))
        Me.firstname.Location = New System.Drawing.Point(416, 116)
        Me.firstname.Name = "firstname"
        Me.firstname.Size = New System.Drawing.Size(3, 2)
        Me.firstname.TabIndex = 37
        Me.firstname.Text = Nothing
        '
        'lastname
        '
        Me.lastname.BackColor = System.Drawing.Color.Transparent
        Me.lastname.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.lastname.ForeColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(93, Byte), Integer), CType(CType(43, Byte), Integer))
        Me.lastname.Location = New System.Drawing.Point(658, 113)
        Me.lastname.Name = "lastname"
        Me.lastname.Size = New System.Drawing.Size(3, 2)
        Me.lastname.TabIndex = 38
        Me.lastname.Text = Nothing
        '
        'Guna2Button3
        '
        Me.Guna2Button3.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.Guna2Button3.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.Guna2Button3.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.Guna2Button3.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.Guna2Button3.FillColor = System.Drawing.Color.Red
        Me.Guna2Button3.Font = New System.Drawing.Font("Poppins", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2Button3.ForeColor = System.Drawing.Color.White
        Me.Guna2Button3.Image = CType(resources.GetObject("Guna2Button3.Image"), System.Drawing.Image)
        Me.Guna2Button3.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.Guna2Button3.Location = New System.Drawing.Point(588, 461)
        Me.Guna2Button3.Name = "Guna2Button3"
        Me.Guna2Button3.Size = New System.Drawing.Size(102, 32)
        Me.Guna2Button3.TabIndex = 55
        Me.Guna2Button3.Text = "Close"
        Me.Guna2Button3.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'VerificationControl
        '
        Me.VerificationControl.Active = True
        Me.VerificationControl.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.VerificationControl.Location = New System.Drawing.Point(882, 443)
        Me.VerificationControl.Name = "VerificationControl"
        Me.VerificationControl.ReaderSerialNumber = "00000000-0000-0000-0000-000000000000"
        Me.VerificationControl.Size = New System.Drawing.Size(48, 47)
        Me.VerificationControl.TabIndex = 56
        '
        'middlename
        '
        Me.middlename.BackColor = System.Drawing.Color.Transparent
        Me.middlename.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.middlename.ForeColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(93, Byte), Integer), CType(CType(43, Byte), Integer))
        Me.middlename.Location = New System.Drawing.Point(416, 163)
        Me.middlename.Name = "middlename"
        Me.middlename.Size = New System.Drawing.Size(3, 2)
        Me.middlename.TabIndex = 39
        Me.middlename.Text = Nothing
        '
        'middlename1
        '
        Me.middlename1.BackColor = System.Drawing.Color.Transparent
        Me.middlename1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.middlename1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(93, Byte), Integer), CType(CType(43, Byte), Integer))
        Me.middlename1.Location = New System.Drawing.Point(416, 163)
        Me.middlename1.Name = "middlename1"
        Me.middlename1.Size = New System.Drawing.Size(3, 2)
        Me.middlename1.TabIndex = 43
        Me.middlename1.Text = Nothing
        '
        'fullname1
        '
        Me.fullname1.BackColor = System.Drawing.Color.Transparent
        Me.fullname1.Font = New System.Drawing.Font("Poppins Medium", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.fullname1.ForeColor = System.Drawing.Color.DarkGreen
        Me.fullname1.Location = New System.Drawing.Point(415, 155)
        Me.fullname1.Name = "fullname1"
        Me.fullname1.Size = New System.Drawing.Size(88, 30)
        Me.fullname1.TabIndex = 57
        Me.fullname1.Text = "_ _ _ _ _"
        '
        'level1
        '
        Me.level1.BackColor = System.Drawing.Color.Transparent
        Me.level1.Font = New System.Drawing.Font("Poppins Medium", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.level1.ForeColor = System.Drawing.Color.DarkGreen
        Me.level1.Location = New System.Drawing.Point(662, 221)
        Me.level1.Name = "level1"
        Me.level1.Size = New System.Drawing.Size(88, 30)
        Me.level1.TabIndex = 60
        Me.level1.Text = "_ _ _ _ _"
        '
        'matric_number1
        '
        Me.matric_number1.BackColor = System.Drawing.Color.Transparent
        Me.matric_number1.Font = New System.Drawing.Font("Poppins Medium", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.matric_number1.ForeColor = System.Drawing.Color.DarkGreen
        Me.matric_number1.Location = New System.Drawing.Point(418, 220)
        Me.matric_number1.Name = "matric_number1"
        Me.matric_number1.Size = New System.Drawing.Size(88, 30)
        Me.matric_number1.TabIndex = 59
        Me.matric_number1.Text = "_ _ _ _ _"
        '
        'faculty1
        '
        Me.faculty1.BackColor = System.Drawing.Color.Transparent
        Me.faculty1.Font = New System.Drawing.Font("Poppins Medium", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.faculty1.ForeColor = System.Drawing.Color.DarkGreen
        Me.faculty1.Location = New System.Drawing.Point(418, 279)
        Me.faculty1.Name = "faculty1"
        Me.faculty1.Size = New System.Drawing.Size(88, 30)
        Me.faculty1.TabIndex = 61
        Me.faculty1.Text = "_ _ _ _ _"
        '
        'course_code1
        '
        Me.course_code1.BackColor = System.Drawing.Color.Transparent
        Me.course_code1.Font = New System.Drawing.Font("Poppins Medium", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.course_code1.ForeColor = System.Drawing.Color.DarkGreen
        Me.course_code1.Location = New System.Drawing.Point(418, 334)
        Me.course_code1.Name = "course_code1"
        Me.course_code1.Size = New System.Drawing.Size(88, 30)
        Me.course_code1.TabIndex = 62
        Me.course_code1.Text = "_ _ _ _ _"
        '
        'course_title1
        '
        Me.course_title1.BackColor = System.Drawing.Color.Transparent
        Me.course_title1.Font = New System.Drawing.Font("Poppins Medium", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.course_title1.ForeColor = System.Drawing.Color.DarkGreen
        Me.course_title1.Location = New System.Drawing.Point(418, 397)
        Me.course_title1.Name = "course_title1"
        Me.course_title1.Size = New System.Drawing.Size(52, 30)
        Me.course_title1.TabIndex = 63
        Me.course_title1.Text = "_ _ _"
        '
        'department1
        '
        Me.department1.BackColor = System.Drawing.Color.Transparent
        Me.department1.Font = New System.Drawing.Font("Poppins Medium", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.department1.ForeColor = System.Drawing.Color.DarkGreen
        Me.department1.Location = New System.Drawing.Point(666, 334)
        Me.department1.Name = "department1"
        Me.department1.Size = New System.Drawing.Size(88, 30)
        Me.department1.TabIndex = 65
        Me.department1.Text = "_ _ _ _ _"
        '
        'check_room
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(981, 504)
        Me.Controls.Add(Me.department1)
        Me.Controls.Add(Me.course_title1)
        Me.Controls.Add(Me.course_code1)
        Me.Controls.Add(Me.faculty1)
        Me.Controls.Add(Me.level1)
        Me.Controls.Add(Me.matric_number1)
        Me.Controls.Add(Me.fullname1)
        Me.Controls.Add(Me.VerificationControl)
        Me.Controls.Add(Me.Guna2Button3)
        Me.Controls.Add(Me.middlename1)
        Me.Controls.Add(Me.middlename)
        Me.Controls.Add(Me.lastname)
        Me.Controls.Add(Me.firstname)
        Me.Controls.Add(Me.Guna2HtmlLabel9)
        Me.Controls.Add(Me.Guna2HtmlLabel8)
        Me.Controls.Add(Me.Guna2HtmlLabel7)
        Me.Controls.Add(Me.Guna2HtmlLabel6)
        Me.Controls.Add(Me.Guna2HtmlLabel5)
        Me.Controls.Add(Me.Guna2HtmlLabel4)
        Me.Controls.Add(Me.Guna2HtmlLabel2)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(gbReturnValues)
        Me.Controls.Add(lblPrompt)
        Me.Controls.Add(Me.Guna2HtmlLabel1)
        Me.Controls.Add(Me.Guna2PictureBox1)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "check_room"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Verify Student"
        gbReturnValues.ResumeLayout(False)
        gbReturnValues.PerformLayout()
        CType(Me.Guna2PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Guna2Elipse1 As Guna.UI2.WinForms.Guna2Elipse
    Friend WithEvents Guna2HtmlLabel1 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2PictureBox1 As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents PictureBox2 As Guna.UI2.WinForms.Guna2PictureBox
    Private WithEvents FalseAcceptRate As TextBox
    Friend WithEvents Guna2HtmlLabel2 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2HtmlLabel4 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2HtmlLabel5 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2HtmlLabel6 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2HtmlLabel7 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2HtmlLabel8 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2HtmlLabel9 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents firstname As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents lastname As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2Button3 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents VerificationControl As DPFP.Gui.Verification.VerificationControl
    Friend WithEvents middlename As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents middlename1 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents fullname1 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents level1 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents matric_number1 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents faculty1 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents course_code1 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents course_title1 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents department1 As Guna.UI2.WinForms.Guna2HtmlLabel
End Class
