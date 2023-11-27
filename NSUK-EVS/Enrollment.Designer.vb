<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Enrollment
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Enrollment))
        Me.Guna2Elipse1 = New Guna.UI2.WinForms.Guna2Elipse(Me.components)
        Me.GroupEvents = New System.Windows.Forms.GroupBox()
        Me.ListEvents = New System.Windows.Forms.ListBox()
        Me.EnrollmentControl = New DPFP.Gui.Enrollment.EnrollmentControl()
        Me.Guna2HtmlLabel1 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2PictureBox1 = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.Guna2Button2 = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2HtmlLabel2 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.label7 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.GroupEvents.SuspendLayout()
        CType(Me.Guna2PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupEvents
        '
        Me.GroupEvents.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupEvents.Controls.Add(Me.ListEvents)
        Me.GroupEvents.Location = New System.Drawing.Point(7, 417)
        Me.GroupEvents.Name = "GroupEvents"
        Me.GroupEvents.Size = New System.Drawing.Size(508, 146)
        Me.GroupEvents.TabIndex = 7
        Me.GroupEvents.TabStop = False
        Me.GroupEvents.Text = "Events"
        '
        'ListEvents
        '
        Me.ListEvents.BackColor = System.Drawing.SystemColors.InactiveBorder
        Me.ListEvents.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ListEvents.FormattingEnabled = True
        Me.ListEvents.Location = New System.Drawing.Point(3, 16)
        Me.ListEvents.Name = "ListEvents"
        Me.ListEvents.Size = New System.Drawing.Size(502, 127)
        Me.ListEvents.TabIndex = 0
        '
        'EnrollmentControl
        '
        Me.EnrollmentControl.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.EnrollmentControl.BackColor = System.Drawing.Color.Transparent
        Me.EnrollmentControl.EnrolledFingerMask = 0
        Me.EnrollmentControl.Location = New System.Drawing.Point(10, 92)
        Me.EnrollmentControl.MaxEnrollFingerCount = 10
        Me.EnrollmentControl.Name = "EnrollmentControl"
        Me.EnrollmentControl.ReaderSerialNumber = "00000000-0000-0000-0000-000000000000"
        Me.EnrollmentControl.Size = New System.Drawing.Size(492, 314)
        Me.EnrollmentControl.TabIndex = 6
        '
        'Guna2HtmlLabel1
        '
        Me.Guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(93, Byte), Integer), CType(CType(43, Byte), Integer))
        Me.Guna2HtmlLabel1.Location = New System.Drawing.Point(45, 10)
        Me.Guna2HtmlLabel1.Name = "Guna2HtmlLabel1"
        Me.Guna2HtmlLabel1.Size = New System.Drawing.Size(325, 22)
        Me.Guna2HtmlLabel1.TabIndex = 11
        Me.Guna2HtmlLabel1.Text = "NSUK - Examination Verification System "
        '
        'Guna2PictureBox1
        '
        Me.Guna2PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2PictureBox1.Image = CType(resources.GetObject("Guna2PictureBox1.Image"), System.Drawing.Image)
        Me.Guna2PictureBox1.ImageRotate = 0!
        Me.Guna2PictureBox1.Location = New System.Drawing.Point(-10, 10)
        Me.Guna2PictureBox1.Name = "Guna2PictureBox1"
        Me.Guna2PictureBox1.Size = New System.Drawing.Size(67, 33)
        Me.Guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.Guna2PictureBox1.TabIndex = 12
        Me.Guna2PictureBox1.TabStop = False
        '
        'Guna2Button2
        '
        Me.Guna2Button2.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.Guna2Button2.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.Guna2Button2.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.Guna2Button2.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.Guna2Button2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.Guna2Button2.FillColor = System.Drawing.Color.DarkRed
        Me.Guna2Button2.Font = New System.Drawing.Font("Poppins", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2Button2.ForeColor = System.Drawing.Color.White
        Me.Guna2Button2.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.Guna2Button2.Location = New System.Drawing.Point(410, 573)
        Me.Guna2Button2.Name = "Guna2Button2"
        Me.Guna2Button2.Size = New System.Drawing.Size(67, 32)
        Me.Guna2Button2.TabIndex = 13
        Me.Guna2Button2.Text = "Close"
        Me.Guna2Button2.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'Guna2HtmlLabel2
        '
        Me.Guna2HtmlLabel2.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel2.Location = New System.Drawing.Point(10, 580)
        Me.Guna2HtmlLabel2.Name = "Guna2HtmlLabel2"
        Me.Guna2HtmlLabel2.Size = New System.Drawing.Size(285, 18)
        Me.Guna2HtmlLabel2.TabIndex = 1
        Me.Guna2HtmlLabel2.Text = "Click on Close if you are done with all the fingers"
        '
        'label7
        '
        Me.label7.BackColor = System.Drawing.Color.Transparent
        Me.label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(93, Byte), Integer), CType(CType(43, Byte), Integer))
        Me.label7.Location = New System.Drawing.Point(22, 53)
        Me.label7.Name = "label7"
        Me.label7.Size = New System.Drawing.Size(89, 22)
        Me.label7.TabIndex = 14
        Me.label7.Text = "Enrollment"
        '
        'Enrollment
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(511, 617)
        Me.Controls.Add(Me.label7)
        Me.Controls.Add(Me.Guna2HtmlLabel2)
        Me.Controls.Add(Me.Guna2Button2)
        Me.Controls.Add(Me.Guna2HtmlLabel1)
        Me.Controls.Add(Me.Guna2PictureBox1)
        Me.Controls.Add(Me.GroupEvents)
        Me.Controls.Add(Me.EnrollmentControl)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Enrollment"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Student Enrollment Page"
        Me.GroupEvents.ResumeLayout(False)
        CType(Me.Guna2PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Guna2Elipse1 As Guna.UI2.WinForms.Guna2Elipse
    Private WithEvents GroupEvents As GroupBox
    Private WithEvents ListEvents As ListBox
    Friend WithEvents EnrollmentControl As DPFP.Gui.Enrollment.EnrollmentControl
    Friend WithEvents Guna2HtmlLabel1 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2PictureBox1 As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents Guna2Button2 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2HtmlLabel2 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents label7 As Guna.UI2.WinForms.Guna2HtmlLabel
End Class
