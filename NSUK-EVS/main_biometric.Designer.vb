<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class main_biometric
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
        Dim gbEventHandlerStatus As System.Windows.Forms.GroupBox
        Dim lblMaxFingers As System.Windows.Forms.Label
        Dim lblMask As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(main_biometric))
        Me.IsSuccess = New System.Windows.Forms.RadioButton()
        Me.Guna2Shapes1 = New Guna.UI2.WinForms.Guna2Shapes()
        Me.Guna2Shapes2 = New Guna.UI2.WinForms.Guna2Shapes()
        Me.Guna2HtmlLabel1 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2PictureBox1 = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.Guna2HtmlLabel2 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2HtmlLabel3 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2HtmlLabel6 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.student_name = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.student_faculty = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2HtmlLabel9 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.student_department = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2HtmlLabel11 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.student_level = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2HtmlLabel13 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.dateofbirth = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2HtmlLabel15 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.matricnumber = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2HtmlLabel17 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2Separator1 = New Guna.UI2.WinForms.Guna2Separator()
        Me.Guna2HtmlLabel18 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2HtmlLabel19 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2HtmlLabel20 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2HtmlLabel21 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2HtmlLabel22 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2HtmlLabel23 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2HtmlLabel24 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2HtmlLabel25 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2Separator2 = New Guna.UI2.WinForms.Guna2Separator()
        Me.Guna2HtmlLabel26 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2HtmlLabel27 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2HtmlLabel28 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2HtmlLabel29 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2HtmlLabel32 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2HtmlLabel33 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.Guna2HtmlLabel30 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.PictureBox2 = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.Button1 = New Guna.UI.WinForms.GunaAdvenceTileButton()
        Me.Guna2Button2 = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2Button1 = New Guna.UI2.WinForms.Guna2Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.MaxFingers = New System.Windows.Forms.NumericUpDown()
        Me.Mask = New System.Windows.Forms.NumericUpDown()
        Me.Guna2Button3 = New Guna.UI2.WinForms.Guna2Button()
        gbEventHandlerStatus = New System.Windows.Forms.GroupBox()
        lblMaxFingers = New System.Windows.Forms.Label()
        lblMask = New System.Windows.Forms.Label()
        gbEventHandlerStatus.SuspendLayout()
        CType(Me.Guna2PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MaxFingers, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Mask, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'gbEventHandlerStatus
        '
        gbEventHandlerStatus.Controls.Add(Me.IsSuccess)
        gbEventHandlerStatus.Enabled = False
        gbEventHandlerStatus.Location = New System.Drawing.Point(757, 450)
        gbEventHandlerStatus.Name = "gbEventHandlerStatus"
        gbEventHandlerStatus.Size = New System.Drawing.Size(208, 60)
        gbEventHandlerStatus.TabIndex = 59
        gbEventHandlerStatus.TabStop = False
        gbEventHandlerStatus.Text = "Event handler status"
        gbEventHandlerStatus.Visible = False
        '
        'IsSuccess
        '
        Me.IsSuccess.AutoSize = True
        Me.IsSuccess.Location = New System.Drawing.Point(26, 29)
        Me.IsSuccess.Name = "IsSuccess"
        Me.IsSuccess.Size = New System.Drawing.Size(75, 24)
        Me.IsSuccess.TabIndex = 0
        Me.IsSuccess.TabStop = True
        Me.IsSuccess.Text = "Success"
        Me.IsSuccess.UseVisualStyleBackColor = True
        '
        'lblMaxFingers
        '
        lblMaxFingers.Location = New System.Drawing.Point(759, 424)
        lblMaxFingers.Name = "lblMaxFingers"
        lblMaxFingers.Size = New System.Drawing.Size(148, 20)
        lblMaxFingers.TabIndex = 57
        lblMaxFingers.Text = "Max. enrolled fingers count"
        lblMaxFingers.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        lblMaxFingers.Visible = False
        '
        'lblMask
        '
        lblMask.Location = New System.Drawing.Point(759, 398)
        lblMask.Name = "lblMask"
        lblMask.Size = New System.Drawing.Size(148, 20)
        lblMask.TabIndex = 55
        lblMask.Text = "Fingerprint Mask"
        lblMask.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        lblMask.Visible = False
        '
        'Guna2Shapes1
        '
        Me.Guna2Shapes1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Guna2Shapes1.BorderColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.Guna2Shapes1.BorderThickness = 0
        Me.Guna2Shapes1.FillColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.Guna2Shapes1.Location = New System.Drawing.Point(-155, -171)
        Me.Guna2Shapes1.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.Guna2Shapes1.Name = "Guna2Shapes1"
        Me.Guna2Shapes1.PolygonSkip = 1
        Me.Guna2Shapes1.Rotate = 0!
        Me.Guna2Shapes1.Shape = Guna.UI2.WinForms.Enums.ShapeType.Rectangle
        Me.Guna2Shapes1.Size = New System.Drawing.Size(644, 1371)
        Me.Guna2Shapes1.TabIndex = 0
        Me.Guna2Shapes1.Text = "Guna2Shapes1"
        Me.Guna2Shapes1.Zoom = 100
        '
        'Guna2Shapes2
        '
        Me.Guna2Shapes2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Guna2Shapes2.BorderColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.Guna2Shapes2.BorderThickness = 0
        Me.Guna2Shapes2.FillColor = System.Drawing.Color.Black
        Me.Guna2Shapes2.Location = New System.Drawing.Point(-2, -5)
        Me.Guna2Shapes2.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.Guna2Shapes2.Name = "Guna2Shapes2"
        Me.Guna2Shapes2.PolygonSkip = 1
        Me.Guna2Shapes2.Rotate = 0!
        Me.Guna2Shapes2.Shape = Guna.UI2.WinForms.Enums.ShapeType.Rectangle
        Me.Guna2Shapes2.Size = New System.Drawing.Size(1490, 61)
        Me.Guna2Shapes2.TabIndex = 1
        Me.Guna2Shapes2.Text = "Guna2Shapes2"
        Me.Guna2Shapes2.Zoom = 100
        '
        'Guna2HtmlLabel1
        '
        Me.Guna2HtmlLabel1.BackColor = System.Drawing.Color.Black
        Me.Guna2HtmlLabel1.Font = New System.Drawing.Font("Poppins", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel1.ForeColor = System.Drawing.Color.White
        Me.Guna2HtmlLabel1.Location = New System.Drawing.Point(79, 13)
        Me.Guna2HtmlLabel1.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.Guna2HtmlLabel1.Name = "Guna2HtmlLabel1"
        Me.Guna2HtmlLabel1.Size = New System.Drawing.Size(333, 30)
        Me.Guna2HtmlLabel1.TabIndex = 11
        Me.Guna2HtmlLabel1.Text = "NSUK - Examination Verification System"
        '
        'Guna2PictureBox1
        '
        Me.Guna2PictureBox1.BackColor = System.Drawing.Color.Black
        Me.Guna2PictureBox1.FillColor = System.Drawing.Color.Transparent
        Me.Guna2PictureBox1.Image = CType(resources.GetObject("Guna2PictureBox1.Image"), System.Drawing.Image)
        Me.Guna2PictureBox1.ImageRotate = 0!
        Me.Guna2PictureBox1.Location = New System.Drawing.Point(14, 5)
        Me.Guna2PictureBox1.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.Guna2PictureBox1.Name = "Guna2PictureBox1"
        Me.Guna2PictureBox1.Size = New System.Drawing.Size(78, 51)
        Me.Guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.Guna2PictureBox1.TabIndex = 12
        Me.Guna2PictureBox1.TabStop = False
        '
        'Guna2HtmlLabel2
        '
        Me.Guna2HtmlLabel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.Guna2HtmlLabel2.Font = New System.Drawing.Font("Arial Narrow", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel2.Location = New System.Drawing.Point(34, 98)
        Me.Guna2HtmlLabel2.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.Guna2HtmlLabel2.Name = "Guna2HtmlLabel2"
        Me.Guna2HtmlLabel2.Size = New System.Drawing.Size(103, 22)
        Me.Guna2HtmlLabel2.TabIndex = 13
        Me.Guna2HtmlLabel2.Text = "Programme Type:"
        '
        'Guna2HtmlLabel3
        '
        Me.Guna2HtmlLabel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.Guna2HtmlLabel3.Font = New System.Drawing.Font("Arial Narrow", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel3.Location = New System.Drawing.Point(228, 101)
        Me.Guna2HtmlLabel3.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.Guna2HtmlLabel3.Name = "Guna2HtmlLabel3"
        Me.Guna2HtmlLabel3.Size = New System.Drawing.Size(115, 22)
        Me.Guna2HtmlLabel3.TabIndex = 14
        Me.Guna2HtmlLabel3.Text = "UNDERGRADUATE"
        '
        'Guna2HtmlLabel6
        '
        Me.Guna2HtmlLabel6.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.Guna2HtmlLabel6.Font = New System.Drawing.Font("Arial Narrow", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel6.Location = New System.Drawing.Point(34, 146)
        Me.Guna2HtmlLabel6.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.Guna2HtmlLabel6.Name = "Guna2HtmlLabel6"
        Me.Guna2HtmlLabel6.Size = New System.Drawing.Size(85, 22)
        Me.Guna2HtmlLabel6.TabIndex = 15
        Me.Guna2HtmlLabel6.Text = "Student Name:"
        '
        'student_name
        '
        Me.student_name.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.student_name.Font = New System.Drawing.Font("Arial Narrow", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.student_name.Location = New System.Drawing.Point(229, 146)
        Me.student_name.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.student_name.Name = "student_name"
        Me.student_name.Size = New System.Drawing.Size(75, 22)
        Me.student_name.TabIndex = 16
        Me.student_name.Text = "NAME HERE"
        '
        'student_faculty
        '
        Me.student_faculty.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.student_faculty.Font = New System.Drawing.Font("Arial Narrow", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.student_faculty.Location = New System.Drawing.Point(230, 295)
        Me.student_faculty.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.student_faculty.Name = "student_faculty"
        Me.student_faculty.Size = New System.Drawing.Size(59, 22)
        Me.student_faculty.TabIndex = 20
        Me.student_faculty.Text = "FACULTY"
        '
        'Guna2HtmlLabel9
        '
        Me.Guna2HtmlLabel9.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.Guna2HtmlLabel9.Font = New System.Drawing.Font("Arial Narrow", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel9.Location = New System.Drawing.Point(35, 295)
        Me.Guna2HtmlLabel9.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.Guna2HtmlLabel9.Name = "Guna2HtmlLabel9"
        Me.Guna2HtmlLabel9.Size = New System.Drawing.Size(46, 22)
        Me.Guna2HtmlLabel9.TabIndex = 19
        Me.Guna2HtmlLabel9.Text = "Faculty:"
        '
        'student_department
        '
        Me.student_department.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.student_department.Font = New System.Drawing.Font("Arial Narrow", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.student_department.Location = New System.Drawing.Point(228, 354)
        Me.student_department.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.student_department.Name = "student_department"
        Me.student_department.Size = New System.Drawing.Size(90, 22)
        Me.student_department.TabIndex = 22
        Me.student_department.Text = "DEPARTMENT"
        '
        'Guna2HtmlLabel11
        '
        Me.Guna2HtmlLabel11.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.Guna2HtmlLabel11.Font = New System.Drawing.Font("Arial Narrow", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel11.Location = New System.Drawing.Point(33, 354)
        Me.Guna2HtmlLabel11.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.Guna2HtmlLabel11.Name = "Guna2HtmlLabel11"
        Me.Guna2HtmlLabel11.Size = New System.Drawing.Size(71, 22)
        Me.Guna2HtmlLabel11.TabIndex = 21
        Me.Guna2HtmlLabel11.Text = "Department:"
        '
        'student_level
        '
        Me.student_level.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.student_level.Font = New System.Drawing.Font("Arial Narrow", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.student_level.Location = New System.Drawing.Point(228, 409)
        Me.student_level.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.student_level.Name = "student_level"
        Me.student_level.Size = New System.Drawing.Size(40, 22)
        Me.student_level.TabIndex = 24
        Me.student_level.Text = "LEVEL"
        '
        'Guna2HtmlLabel13
        '
        Me.Guna2HtmlLabel13.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.Guna2HtmlLabel13.Font = New System.Drawing.Font("Arial Narrow", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel13.Location = New System.Drawing.Point(33, 409)
        Me.Guna2HtmlLabel13.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.Guna2HtmlLabel13.Name = "Guna2HtmlLabel13"
        Me.Guna2HtmlLabel13.Size = New System.Drawing.Size(35, 22)
        Me.Guna2HtmlLabel13.TabIndex = 23
        Me.Guna2HtmlLabel13.Text = "Level:"
        '
        'dateofbirth
        '
        Me.dateofbirth.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.dateofbirth.Font = New System.Drawing.Font("Arial Narrow", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dateofbirth.Location = New System.Drawing.Point(229, 239)
        Me.dateofbirth.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.dateofbirth.Name = "dateofbirth"
        Me.dateofbirth.Size = New System.Drawing.Size(77, 22)
        Me.dateofbirth.TabIndex = 26
        Me.dateofbirth.Text = "DATE BIRTH"
        '
        'Guna2HtmlLabel15
        '
        Me.Guna2HtmlLabel15.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.Guna2HtmlLabel15.Font = New System.Drawing.Font("Arial Narrow", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel15.Location = New System.Drawing.Point(34, 239)
        Me.Guna2HtmlLabel15.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.Guna2HtmlLabel15.Name = "Guna2HtmlLabel15"
        Me.Guna2HtmlLabel15.Size = New System.Drawing.Size(73, 22)
        Me.Guna2HtmlLabel15.TabIndex = 25
        Me.Guna2HtmlLabel15.Text = "Date of Birth:"
        '
        'matricnumber
        '
        Me.matricnumber.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.matricnumber.Font = New System.Drawing.Font("Arial Narrow", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.matricnumber.Location = New System.Drawing.Point(229, 192)
        Me.matricnumber.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.matricnumber.Name = "matricnumber"
        Me.matricnumber.Size = New System.Drawing.Size(108, 22)
        Me.matricnumber.TabIndex = 28
        Me.matricnumber.Text = "MATRIC NUMBER"
        '
        'Guna2HtmlLabel17
        '
        Me.Guna2HtmlLabel17.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.Guna2HtmlLabel17.Font = New System.Drawing.Font("Arial Narrow", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel17.Location = New System.Drawing.Point(34, 192)
        Me.Guna2HtmlLabel17.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.Guna2HtmlLabel17.Name = "Guna2HtmlLabel17"
        Me.Guna2HtmlLabel17.Size = New System.Drawing.Size(89, 22)
        Me.Guna2HtmlLabel17.TabIndex = 27
        Me.Guna2HtmlLabel17.Text = "Matric Number:"
        '
        'Guna2Separator1
        '
        Me.Guna2Separator1.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.Guna2Separator1.Location = New System.Drawing.Point(43, 553)
        Me.Guna2Separator1.Name = "Guna2Separator1"
        Me.Guna2Separator1.Size = New System.Drawing.Size(410, 10)
        Me.Guna2Separator1.TabIndex = 29
        '
        'Guna2HtmlLabel18
        '
        Me.Guna2HtmlLabel18.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.Guna2HtmlLabel18.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel18.Location = New System.Drawing.Point(34, 544)
        Me.Guna2HtmlLabel18.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.Guna2HtmlLabel18.Name = "Guna2HtmlLabel18"
        Me.Guna2HtmlLabel18.Size = New System.Drawing.Size(211, 22)
        Me.Guna2HtmlLabel18.TabIndex = 30
        Me.Guna2HtmlLabel18.Text = "Fingerprint Biometric Instruction:"
        '
        'Guna2HtmlLabel19
        '
        Me.Guna2HtmlLabel19.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.Guna2HtmlLabel19.Font = New System.Drawing.Font("Arial Narrow", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel19.Location = New System.Drawing.Point(32, 575)
        Me.Guna2HtmlLabel19.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.Guna2HtmlLabel19.Name = "Guna2HtmlLabel19"
        Me.Guna2HtmlLabel19.Size = New System.Drawing.Size(209, 22)
        Me.Guna2HtmlLabel19.TabIndex = 31
        Me.Guna2HtmlLabel19.Text = "* You Must Captured Ten(10) Fingers "
        '
        'Guna2HtmlLabel20
        '
        Me.Guna2HtmlLabel20.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.Guna2HtmlLabel20.Font = New System.Drawing.Font("Arial Narrow", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel20.Location = New System.Drawing.Point(32, 610)
        Me.Guna2HtmlLabel20.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.Guna2HtmlLabel20.Name = "Guna2HtmlLabel20"
        Me.Guna2HtmlLabel20.Size = New System.Drawing.Size(441, 22)
        Me.Guna2HtmlLabel20.TabIndex = 32
        Me.Guna2HtmlLabel20.Text = "* Only  DigitalPersona U. are. U 4500 fingerprint scanner is the Supported Device" &
    ""
        '
        'Guna2HtmlLabel21
        '
        Me.Guna2HtmlLabel21.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.Guna2HtmlLabel21.Font = New System.Drawing.Font("Arial Narrow", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel21.Location = New System.Drawing.Point(34, 647)
        Me.Guna2HtmlLabel21.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.Guna2HtmlLabel21.Name = "Guna2HtmlLabel21"
        Me.Guna2HtmlLabel21.Size = New System.Drawing.Size(309, 22)
        Me.Guna2HtmlLabel21.TabIndex = 33
        Me.Guna2HtmlLabel21.Text = "* Click on the Start Enrollment Button to Begin Biometric"
        '
        'Guna2HtmlLabel22
        '
        Me.Guna2HtmlLabel22.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel22.Font = New System.Drawing.Font("Arial Narrow", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel22.Location = New System.Drawing.Point(510, 156)
        Me.Guna2HtmlLabel22.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.Guna2HtmlLabel22.Name = "Guna2HtmlLabel22"
        Me.Guna2HtmlLabel22.Size = New System.Drawing.Size(312, 22)
        Me.Guna2HtmlLabel22.TabIndex = 38
        Me.Guna2HtmlLabel22.Text = "* Use a plain, light-colored background for better visibility"
        '
        'Guna2HtmlLabel23
        '
        Me.Guna2HtmlLabel23.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel23.Font = New System.Drawing.Font("Arial Narrow", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel23.Location = New System.Drawing.Point(508, 126)
        Me.Guna2HtmlLabel23.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.Guna2HtmlLabel23.Name = "Guna2HtmlLabel23"
        Me.Guna2HtmlLabel23.Size = New System.Drawing.Size(362, 22)
        Me.Guna2HtmlLabel23.TabIndex = 37
        Me.Guna2HtmlLabel23.Text = "*The photo should have a minimum resolution of 300 x 300 pixels"
        '
        'Guna2HtmlLabel24
        '
        Me.Guna2HtmlLabel24.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel24.Font = New System.Drawing.Font("Arial Narrow", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel24.Location = New System.Drawing.Point(508, 100)
        Me.Guna2HtmlLabel24.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.Guna2HtmlLabel24.Name = "Guna2HtmlLabel24"
        Me.Guna2HtmlLabel24.Size = New System.Drawing.Size(321, 22)
        Me.Guna2HtmlLabel24.TabIndex = 36
        Me.Guna2HtmlLabel24.Text = "* Upload a JPEG or PNG file format for the passport photo."
        '
        'Guna2HtmlLabel25
        '
        Me.Guna2HtmlLabel25.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel25.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel25.Location = New System.Drawing.Point(510, 69)
        Me.Guna2HtmlLabel25.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.Guna2HtmlLabel25.Name = "Guna2HtmlLabel25"
        Me.Guna2HtmlLabel25.Size = New System.Drawing.Size(181, 22)
        Me.Guna2HtmlLabel25.TabIndex = 35
        Me.Guna2HtmlLabel25.Text = "Passport Upload Instruction:"
        '
        'Guna2Separator2
        '
        Me.Guna2Separator2.BackColor = System.Drawing.Color.Transparent
        Me.Guna2Separator2.Location = New System.Drawing.Point(519, 78)
        Me.Guna2Separator2.Name = "Guna2Separator2"
        Me.Guna2Separator2.Size = New System.Drawing.Size(377, 13)
        Me.Guna2Separator2.TabIndex = 34
        '
        'Guna2HtmlLabel26
        '
        Me.Guna2HtmlLabel26.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel26.Font = New System.Drawing.Font("Arial Narrow", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel26.Location = New System.Drawing.Point(510, 185)
        Me.Guna2HtmlLabel26.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.Guna2HtmlLabel26.Name = "Guna2HtmlLabel26"
        Me.Guna2HtmlLabel26.Size = New System.Drawing.Size(330, 22)
        Me.Guna2HtmlLabel26.TabIndex = 39
        Me.Guna2HtmlLabel26.Text = "* The photo should be a clear, front-facing view of your face."
        '
        'Guna2HtmlLabel27
        '
        Me.Guna2HtmlLabel27.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel27.Font = New System.Drawing.Font("Arial Narrow", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel27.Location = New System.Drawing.Point(511, 213)
        Me.Guna2HtmlLabel27.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.Guna2HtmlLabel27.Name = "Guna2HtmlLabel27"
        Me.Guna2HtmlLabel27.Size = New System.Drawing.Size(311, 22)
        Me.Guna2HtmlLabel27.TabIndex = 40
        Me.Guna2HtmlLabel27.Text = "* Ensure a neutral facial expression with both eyes open."
        '
        'Guna2HtmlLabel28
        '
        Me.Guna2HtmlLabel28.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel28.Font = New System.Drawing.Font("Arial Narrow", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel28.Location = New System.Drawing.Point(511, 243)
        Me.Guna2HtmlLabel28.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.Guna2HtmlLabel28.Name = "Guna2HtmlLabel28"
        Me.Guna2HtmlLabel28.Size = New System.Drawing.Size(269, 22)
        Me.Guna2HtmlLabel28.TabIndex = 41
        Me.Guna2HtmlLabel28.Text = "* Your head should be centered within the frame."
        '
        'Guna2HtmlLabel29
        '
        Me.Guna2HtmlLabel29.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel29.Font = New System.Drawing.Font("Arial Narrow", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel29.Location = New System.Drawing.Point(511, 273)
        Me.Guna2HtmlLabel29.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.Guna2HtmlLabel29.Name = "Guna2HtmlLabel29"
        Me.Guna2HtmlLabel29.Size = New System.Drawing.Size(347, 22)
        Me.Guna2HtmlLabel29.TabIndex = 42
        Me.Guna2HtmlLabel29.Text = "* The head's height in the photo should measure between 50% "
        '
        'Guna2HtmlLabel32
        '
        Me.Guna2HtmlLabel32.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel32.Font = New System.Drawing.Font("Arial Narrow", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel32.Location = New System.Drawing.Point(512, 363)
        Me.Guna2HtmlLabel32.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.Guna2HtmlLabel32.Name = "Guna2HtmlLabel32"
        Me.Guna2HtmlLabel32.Size = New System.Drawing.Size(306, 22)
        Me.Guna2HtmlLabel32.TabIndex = 44
        Me.Guna2HtmlLabel32.Text = "* Keep the file size below 500 KB for efficient uploading."
        '
        'Guna2HtmlLabel33
        '
        Me.Guna2HtmlLabel33.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel33.Font = New System.Drawing.Font("Arial Narrow", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel33.Location = New System.Drawing.Point(511, 335)
        Me.Guna2HtmlLabel33.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.Guna2HtmlLabel33.Name = "Guna2HtmlLabel33"
        Me.Guna2HtmlLabel33.Size = New System.Drawing.Size(427, 22)
        Me.Guna2HtmlLabel33.TabIndex = 43
        Me.Guna2HtmlLabel33.Text = "* Remove accessories that may obstruct the face, such as hats or sunglasses."
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(61, 4)
        '
        'Guna2HtmlLabel30
        '
        Me.Guna2HtmlLabel30.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel30.Font = New System.Drawing.Font("Arial Narrow", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel30.Location = New System.Drawing.Point(524, 304)
        Me.Guna2HtmlLabel30.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.Guna2HtmlLabel30.Name = "Guna2HtmlLabel30"
        Me.Guna2HtmlLabel30.Size = New System.Drawing.Size(178, 22)
        Me.Guna2HtmlLabel30.TabIndex = 46
        Me.Guna2HtmlLabel30.Text = "  to 70% of the total image height."
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.ImageRotate = 0!
        Me.PictureBox2.Location = New System.Drawing.Point(943, 57)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(416, 435)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 47
        Me.PictureBox2.TabStop = False
        '
        'Button1
        '
        Me.Button1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Button1.Animated = True
        Me.Button1.AnimationHoverSpeed = 0.07!
        Me.Button1.AnimationSpeed = 0.03!
        Me.Button1.BackColor = System.Drawing.Color.Transparent
        Me.Button1.BaseColor = System.Drawing.Color.White
        Me.Button1.BorderColor = System.Drawing.Color.White
        Me.Button1.BorderSize = 3
        Me.Button1.CheckedBaseColor = System.Drawing.Color.DimGray
        Me.Button1.CheckedBorderColor = System.Drawing.Color.Black
        Me.Button1.CheckedForeColor = System.Drawing.Color.White
        Me.Button1.CheckedImage = Nothing
        Me.Button1.CheckedLineColor = System.Drawing.Color.DimGray
        Me.Button1.DialogResult = System.Windows.Forms.DialogResult.None
        Me.Button1.FocusedColor = System.Drawing.Color.Empty
        Me.Button1.Font = New System.Drawing.Font("Poppins", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.Black
        Me.Button1.Image = CType(resources.GetObject("Button1.Image"), System.Drawing.Image)
        Me.Button1.ImageSize = New System.Drawing.Size(120, 120)
        Me.Button1.LineBottom = 5
        Me.Button1.LineColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.Button1.Location = New System.Drawing.Point(583, 455)
        Me.Button1.Name = "Button1"
        Me.Button1.OnHoverBaseColor = System.Drawing.Color.White
        Me.Button1.OnHoverBorderColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.Button1.OnHoverForeColor = System.Drawing.Color.Black
        Me.Button1.OnHoverImage = Nothing
        Me.Button1.OnHoverLineColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.Button1.OnPressedColor = System.Drawing.Color.Black
        Me.Button1.Radius = 10
        Me.Button1.Size = New System.Drawing.Size(239, 226)
        Me.Button1.TabIndex = 48
        Me.Button1.Text = "Start Enrollment"
        Me.Button1.TextImageOffsetY = 10
        Me.Button1.UseTransfarantBackground = True
        '
        'Guna2Button2
        '
        Me.Guna2Button2.BorderRadius = 5
        Me.Guna2Button2.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.Guna2Button2.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.Guna2Button2.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.Guna2Button2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.Guna2Button2.FillColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.Guna2Button2.Font = New System.Drawing.Font("Poppins", 9.75!)
        Me.Guna2Button2.ForeColor = System.Drawing.Color.White
        Me.Guna2Button2.Image = CType(resources.GetObject("Guna2Button2.Image"), System.Drawing.Image)
        Me.Guna2Button2.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.Guna2Button2.Location = New System.Drawing.Point(977, 589)
        Me.Guna2Button2.Name = "Guna2Button2"
        Me.Guna2Button2.Size = New System.Drawing.Size(346, 51)
        Me.Guna2Button2.TabIndex = 50
        Me.Guna2Button2.Text = "Upload Image"
        Me.Guna2Button2.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'Guna2Button1
        '
        Me.Guna2Button1.Animated = True
        Me.Guna2Button1.BorderRadius = 5
        Me.Guna2Button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.Guna2Button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.Guna2Button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.Guna2Button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.Guna2Button1.FillColor = System.Drawing.Color.Silver
        Me.Guna2Button1.Font = New System.Drawing.Font("Poppins", 9.75!)
        Me.Guna2Button1.ForeColor = System.Drawing.Color.White
        Me.Guna2Button1.Image = CType(resources.GetObject("Guna2Button1.Image"), System.Drawing.Image)
        Me.Guna2Button1.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.Guna2Button1.Location = New System.Drawing.Point(978, 517)
        Me.Guna2Button1.Name = "Guna2Button1"
        Me.Guna2Button1.Size = New System.Drawing.Size(346, 49)
        Me.Guna2Button1.TabIndex = 49
        Me.Guna2Button1.Text = "Choose Image | JPG, PNG"
        Me.Guna2Button1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(757, 517)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(208, 23)
        Me.Button2.TabIndex = 54
        Me.Button2.Text = "Button2"
        Me.Button2.UseVisualStyleBackColor = True
        Me.Button2.Visible = False
        '
        'MaxFingers
        '
        Me.MaxFingers.Enabled = False
        Me.MaxFingers.Location = New System.Drawing.Point(913, 424)
        Me.MaxFingers.Maximum = New Decimal(New Integer() {10, 0, 0, 0})
        Me.MaxFingers.Name = "MaxFingers"
        Me.MaxFingers.Size = New System.Drawing.Size(52, 25)
        Me.MaxFingers.TabIndex = 58
        Me.MaxFingers.Value = New Decimal(New Integer() {10, 0, 0, 0})
        Me.MaxFingers.Visible = False
        '
        'Mask
        '
        Me.Mask.Enabled = False
        Me.Mask.Location = New System.Drawing.Point(913, 398)
        Me.Mask.Maximum = New Decimal(New Integer() {1023, 0, 0, 0})
        Me.Mask.Name = "Mask"
        Me.Mask.Size = New System.Drawing.Size(52, 25)
        Me.Mask.TabIndex = 56
        Me.Mask.Visible = False
        '
        'Guna2Button3
        '
        Me.Guna2Button3.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.Guna2Button3.BorderRadius = 15
        Me.Guna2Button3.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.Guna2Button3.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.Guna2Button3.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.Guna2Button3.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.Guna2Button3.FillColor = System.Drawing.Color.DarkRed
        Me.Guna2Button3.Font = New System.Drawing.Font("Poppins", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2Button3.ForeColor = System.Drawing.Color.White
        Me.Guna2Button3.Image = CType(resources.GetObject("Guna2Button3.Image"), System.Drawing.Image)
        Me.Guna2Button3.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.Guna2Button3.Location = New System.Drawing.Point(175, 699)
        Me.Guna2Button3.Name = "Guna2Button3"
        Me.Guna2Button3.Size = New System.Drawing.Size(102, 37)
        Me.Guna2Button3.TabIndex = 60
        Me.Guna2Button3.Text = "Close"
        Me.Guna2Button3.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'main_biometric
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1370, 749)
        Me.Controls.Add(Me.Guna2Button3)
        Me.Controls.Add(gbEventHandlerStatus)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.MaxFingers)
        Me.Controls.Add(Me.Mask)
        Me.Controls.Add(lblMaxFingers)
        Me.Controls.Add(lblMask)
        Me.Controls.Add(Me.Guna2Button2)
        Me.Controls.Add(Me.Guna2Button1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.Guna2HtmlLabel30)
        Me.Controls.Add(Me.Guna2HtmlLabel32)
        Me.Controls.Add(Me.Guna2HtmlLabel33)
        Me.Controls.Add(Me.Guna2HtmlLabel29)
        Me.Controls.Add(Me.Guna2HtmlLabel28)
        Me.Controls.Add(Me.Guna2HtmlLabel27)
        Me.Controls.Add(Me.Guna2HtmlLabel26)
        Me.Controls.Add(Me.Guna2HtmlLabel22)
        Me.Controls.Add(Me.Guna2HtmlLabel23)
        Me.Controls.Add(Me.Guna2HtmlLabel24)
        Me.Controls.Add(Me.Guna2HtmlLabel25)
        Me.Controls.Add(Me.Guna2Separator2)
        Me.Controls.Add(Me.Guna2HtmlLabel21)
        Me.Controls.Add(Me.Guna2HtmlLabel20)
        Me.Controls.Add(Me.Guna2HtmlLabel19)
        Me.Controls.Add(Me.Guna2HtmlLabel18)
        Me.Controls.Add(Me.Guna2Separator1)
        Me.Controls.Add(Me.matricnumber)
        Me.Controls.Add(Me.Guna2HtmlLabel17)
        Me.Controls.Add(Me.dateofbirth)
        Me.Controls.Add(Me.Guna2HtmlLabel15)
        Me.Controls.Add(Me.student_level)
        Me.Controls.Add(Me.Guna2HtmlLabel13)
        Me.Controls.Add(Me.student_department)
        Me.Controls.Add(Me.Guna2HtmlLabel11)
        Me.Controls.Add(Me.student_faculty)
        Me.Controls.Add(Me.Guna2HtmlLabel9)
        Me.Controls.Add(Me.student_name)
        Me.Controls.Add(Me.Guna2HtmlLabel6)
        Me.Controls.Add(Me.Guna2HtmlLabel3)
        Me.Controls.Add(Me.Guna2HtmlLabel2)
        Me.Controls.Add(Me.Guna2HtmlLabel1)
        Me.Controls.Add(Me.Guna2PictureBox1)
        Me.Controls.Add(Me.Guna2Shapes2)
        Me.Controls.Add(Me.Guna2Shapes1)
        Me.Font = New System.Drawing.Font("Arial Narrow", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.Name = "main_biometric"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "main_biometric"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        gbEventHandlerStatus.ResumeLayout(False)
        gbEventHandlerStatus.PerformLayout()
        CType(Me.Guna2PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MaxFingers, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Mask, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Guna2Shapes1 As Guna.UI2.WinForms.Guna2Shapes
    Friend WithEvents Guna2Shapes2 As Guna.UI2.WinForms.Guna2Shapes
    Friend WithEvents Guna2HtmlLabel1 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2PictureBox1 As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents Guna2HtmlLabel2 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2HtmlLabel3 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2HtmlLabel6 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents student_name As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents student_faculty As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2HtmlLabel9 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents student_department As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2HtmlLabel11 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents student_level As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2HtmlLabel13 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents dateofbirth As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2HtmlLabel15 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents matricnumber As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2HtmlLabel17 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2Separator1 As Guna.UI2.WinForms.Guna2Separator
    Friend WithEvents Guna2HtmlLabel18 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2HtmlLabel19 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2HtmlLabel20 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2HtmlLabel21 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2HtmlLabel22 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2HtmlLabel23 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2HtmlLabel24 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2HtmlLabel25 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2Separator2 As Guna.UI2.WinForms.Guna2Separator
    Friend WithEvents Guna2HtmlLabel26 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2HtmlLabel27 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2HtmlLabel28 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2HtmlLabel29 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2HtmlLabel32 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2HtmlLabel33 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents Guna2HtmlLabel30 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents PictureBox2 As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents Button1 As Guna.UI.WinForms.GunaAdvenceTileButton
    Friend WithEvents Guna2Button2 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2Button1 As Guna.UI2.WinForms.Guna2Button
    Private WithEvents IsSuccess As RadioButton
    Friend WithEvents Button2 As Button
    Friend WithEvents MaxFingers As NumericUpDown
    Friend WithEvents Mask As NumericUpDown
    Friend WithEvents Guna2Button3 As Guna.UI2.WinForms.Guna2Button


End Class
