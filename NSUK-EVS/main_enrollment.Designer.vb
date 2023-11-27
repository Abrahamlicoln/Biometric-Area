<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class main_enrollment
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim gbEventHandlerStatus As System.Windows.Forms.GroupBox
        Dim lblMaxFingers As System.Windows.Forms.Label
        Dim lblMask As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(main_enrollment))
        Me.IsSuccess = New System.Windows.Forms.RadioButton()
        Me.Guna2Elipse1 = New Guna.UI2.WinForms.Guna2Elipse(Me.components)
        Me.Guna2ShadowForm1 = New Guna.UI2.WinForms.Guna2ShadowForm(Me.components)
        Me.Guna2HtmlLabel1 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2PictureBox1 = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.mainlabel = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.PictureBox2 = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.Guna2Button1 = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2Button2 = New Guna.UI2.WinForms.Guna2Button()
        Me.Button1 = New Guna.UI.WinForms.GunaAdvenceTileButton()
        Me.label1 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.label2 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2HtmlLabel2 = New Guna.UI2.WinForms.Guna2HtmlLabel()
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
        gbEventHandlerStatus.Location = New System.Drawing.Point(307, 178)
        gbEventHandlerStatus.Name = "gbEventHandlerStatus"
        gbEventHandlerStatus.Size = New System.Drawing.Size(208, 60)
        gbEventHandlerStatus.TabIndex = 53
        gbEventHandlerStatus.TabStop = False
        gbEventHandlerStatus.Text = "Event handler status"
        gbEventHandlerStatus.Visible = False
        '
        'IsSuccess
        '
        Me.IsSuccess.AutoSize = True
        Me.IsSuccess.Location = New System.Drawing.Point(26, 29)
        Me.IsSuccess.Name = "IsSuccess"
        Me.IsSuccess.Size = New System.Drawing.Size(66, 17)
        Me.IsSuccess.TabIndex = 0
        Me.IsSuccess.TabStop = True
        Me.IsSuccess.Text = "Success"
        Me.IsSuccess.UseVisualStyleBackColor = True
        '
        'lblMaxFingers
        '
        lblMaxFingers.Location = New System.Drawing.Point(309, 152)
        lblMaxFingers.Name = "lblMaxFingers"
        lblMaxFingers.Size = New System.Drawing.Size(148, 20)
        lblMaxFingers.TabIndex = 51
        lblMaxFingers.Text = "Max. enrolled fingers count"
        lblMaxFingers.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        lblMaxFingers.Visible = False
        '
        'lblMask
        '
        lblMask.Location = New System.Drawing.Point(309, 126)
        lblMask.Name = "lblMask"
        lblMask.Size = New System.Drawing.Size(148, 20)
        lblMask.TabIndex = 49
        lblMask.Text = "Fingerprint Mask"
        lblMask.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        lblMask.Visible = False
        '
        'Guna2ShadowForm1
        '
        Me.Guna2ShadowForm1.TargetForm = Me
        '
        'Guna2HtmlLabel1
        '
        Me.Guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel1.Font = New System.Drawing.Font("Poppins", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(93, Byte), Integer), CType(CType(43, Byte), Integer))
        Me.Guna2HtmlLabel1.Location = New System.Drawing.Point(46, 12)
        Me.Guna2HtmlLabel1.Name = "Guna2HtmlLabel1"
        Me.Guna2HtmlLabel1.Size = New System.Drawing.Size(333, 30)
        Me.Guna2HtmlLabel1.TabIndex = 9
        Me.Guna2HtmlLabel1.Text = "NSUK - Examination Verification System"
        '
        'Guna2PictureBox1
        '
        Me.Guna2PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2PictureBox1.Image = CType(resources.GetObject("Guna2PictureBox1.Image"), System.Drawing.Image)
        Me.Guna2PictureBox1.ImageRotate = 0!
        Me.Guna2PictureBox1.Location = New System.Drawing.Point(-9, 11)
        Me.Guna2PictureBox1.Name = "Guna2PictureBox1"
        Me.Guna2PictureBox1.Size = New System.Drawing.Size(67, 33)
        Me.Guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.Guna2PictureBox1.TabIndex = 10
        Me.Guna2PictureBox1.TabStop = False
        '
        'mainlabel
        '
        Me.mainlabel.BackColor = System.Drawing.Color.Transparent
        Me.mainlabel.Font = New System.Drawing.Font("Poppins Medium", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mainlabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(93, Byte), Integer), CType(CType(43, Byte), Integer))
        Me.mainlabel.Location = New System.Drawing.Point(75, 53)
        Me.mainlabel.Name = "mainlabel"
        Me.mainlabel.Size = New System.Drawing.Size(174, 39)
        Me.mainlabel.TabIndex = 11
        Me.mainlabel.Text = "Welcome back, "
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.White
        Me.PictureBox2.BorderRadius = 5
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.ImageRotate = 0!
        Me.PictureBox2.Location = New System.Drawing.Point(78, 105)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(207, 198)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 12
        Me.PictureBox2.TabStop = False
        '
        'Guna2Button1
        '
        Me.Guna2Button1.Animated = True
        Me.Guna2Button1.BorderRadius = 5
        Me.Guna2Button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.Guna2Button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.Guna2Button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.Guna2Button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.Guna2Button1.FillColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Guna2Button1.Font = New System.Drawing.Font("Poppins", 9.75!)
        Me.Guna2Button1.ForeColor = System.Drawing.Color.White
        Me.Guna2Button1.Image = CType(resources.GetObject("Guna2Button1.Image"), System.Drawing.Image)
        Me.Guna2Button1.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.Guna2Button1.Location = New System.Drawing.Point(77, 318)
        Me.Guna2Button1.Name = "Guna2Button1"
        Me.Guna2Button1.Size = New System.Drawing.Size(207, 44)
        Me.Guna2Button1.TabIndex = 13
        Me.Guna2Button1.Text = "Choose Image | JPG, PNG"
        Me.Guna2Button1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
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
        Me.Guna2Button2.Location = New System.Drawing.Point(78, 374)
        Me.Guna2Button2.Name = "Guna2Button2"
        Me.Guna2Button2.Size = New System.Drawing.Size(207, 45)
        Me.Guna2Button2.TabIndex = 14
        Me.Guna2Button2.Text = "Upload Image"
        Me.Guna2Button2.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
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
        Me.Button1.Location = New System.Drawing.Point(563, 105)
        Me.Button1.Name = "Button1"
        Me.Button1.OnHoverBaseColor = System.Drawing.Color.White
        Me.Button1.OnHoverBorderColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.Button1.OnHoverForeColor = System.Drawing.Color.Black
        Me.Button1.OnHoverImage = Nothing
        Me.Button1.OnHoverLineColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.Button1.OnPressedColor = System.Drawing.Color.Black
        Me.Button1.Radius = 10
        Me.Button1.Size = New System.Drawing.Size(208, 185)
        Me.Button1.TabIndex = 15
        Me.Button1.Text = "Start Enrollment"
        Me.Button1.TextImageOffsetY = 10
        Me.Button1.UseTransfarantBackground = True
        '
        'label1
        '
        Me.label1.BackColor = System.Drawing.Color.Transparent
        Me.label1.Font = New System.Drawing.Font("Poppins Medium", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(93, Byte), Integer), CType(CType(43, Byte), Integer))
        Me.label1.Location = New System.Drawing.Point(447, 336)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(125, 28)
        Me.label1.TabIndex = 17
        Me.label1.Text = "Welcome back, "
        '
        'label2
        '
        Me.label2.BackColor = System.Drawing.Color.Transparent
        Me.label2.Font = New System.Drawing.Font("Poppins Medium", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(93, Byte), Integer), CType(CType(43, Byte), Integer))
        Me.label2.Location = New System.Drawing.Point(447, 370)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(125, 28)
        Me.label2.TabIndex = 18
        Me.label2.Text = "Welcome back, "
        '
        'Guna2HtmlLabel2
        '
        Me.Guna2HtmlLabel2.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel2.Font = New System.Drawing.Font("Poppins", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel2.ForeColor = System.Drawing.Color.Red
        Me.Guna2HtmlLabel2.Location = New System.Drawing.Point(447, 405)
        Me.Guna2HtmlLabel2.Name = "Guna2HtmlLabel2"
        Me.Guna2HtmlLabel2.Size = New System.Drawing.Size(437, 25)
        Me.Guna2HtmlLabel2.TabIndex = 19
        Me.Guna2HtmlLabel2.Text = "Supported Device : DigitalPersona U. are. U 4500 fingerprint scanner"
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(307, 245)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(208, 23)
        Me.Button2.TabIndex = 48
        Me.Button2.Text = "Button2"
        Me.Button2.UseVisualStyleBackColor = True
        Me.Button2.Visible = False
        '
        'MaxFingers
        '
        Me.MaxFingers.Enabled = False
        Me.MaxFingers.Location = New System.Drawing.Point(463, 152)
        Me.MaxFingers.Maximum = New Decimal(New Integer() {10, 0, 0, 0})
        Me.MaxFingers.Name = "MaxFingers"
        Me.MaxFingers.Size = New System.Drawing.Size(52, 20)
        Me.MaxFingers.TabIndex = 52
        Me.MaxFingers.Value = New Decimal(New Integer() {10, 0, 0, 0})
        Me.MaxFingers.Visible = False
        '
        'Mask
        '
        Me.Mask.Enabled = False
        Me.Mask.Location = New System.Drawing.Point(463, 126)
        Me.Mask.Maximum = New Decimal(New Integer() {1023, 0, 0, 0})
        Me.Mask.Name = "Mask"
        Me.Mask.Size = New System.Drawing.Size(52, 20)
        Me.Mask.TabIndex = 50
        Me.Mask.Visible = False
        '
        'Guna2Button3
        '
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
        Me.Guna2Button3.Location = New System.Drawing.Point(787, 7)
        Me.Guna2Button3.Name = "Guna2Button3"
        Me.Guna2Button3.Size = New System.Drawing.Size(102, 37)
        Me.Guna2Button3.TabIndex = 54
        Me.Guna2Button3.Text = "Close"
        Me.Guna2Button3.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'main_enrollment
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(899, 431)
        Me.Controls.Add(Me.Guna2Button3)
        Me.Controls.Add(gbEventHandlerStatus)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.MaxFingers)
        Me.Controls.Add(Me.Mask)
        Me.Controls.Add(lblMaxFingers)
        Me.Controls.Add(lblMask)
        Me.Controls.Add(Me.Guna2HtmlLabel2)
        Me.Controls.Add(Me.label2)
        Me.Controls.Add(Me.label1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Guna2Button2)
        Me.Controls.Add(Me.Guna2Button1)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.mainlabel)
        Me.Controls.Add(Me.Guna2HtmlLabel1)
        Me.Controls.Add(Me.Guna2PictureBox1)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "main_enrollment"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Student Dashboard"
        gbEventHandlerStatus.ResumeLayout(False)
        gbEventHandlerStatus.PerformLayout()
        CType(Me.Guna2PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MaxFingers, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Mask, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Guna2Elipse1 As Guna.UI2.WinForms.Guna2Elipse
    Friend WithEvents Guna2ShadowForm1 As Guna.UI2.WinForms.Guna2ShadowForm
    Friend WithEvents Guna2HtmlLabel1 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2PictureBox1 As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents PictureBox2 As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents mainlabel As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2Button2 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2Button1 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Button1 As Guna.UI.WinForms.GunaAdvenceTileButton
    Friend WithEvents label2 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents label1 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2HtmlLabel2 As Guna.UI2.WinForms.Guna2HtmlLabel
    Private WithEvents IsSuccess As RadioButton
    Friend WithEvents Button2 As Button
    Friend WithEvents MaxFingers As NumericUpDown
    Friend WithEvents Mask As NumericUpDown
    Friend WithEvents Guna2Button3 As Guna.UI2.WinForms.Guna2Button
End Class
