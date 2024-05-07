<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmFeedback
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmFeedback))
        Me.panelBackground = New System.Windows.Forms.Panel()
        Me.lblfeedback = New System.Windows.Forms.Label()
        Me.pbLogo = New System.Windows.Forms.PictureBox()
        Me.lbldescription = New System.Windows.Forms.Label()
        Me.pbstar1 = New System.Windows.Forms.PictureBox()
        Me.pbstar2 = New System.Windows.Forms.PictureBox()
        Me.pbstar3 = New System.Windows.Forms.PictureBox()
        Me.pbstar4 = New System.Windows.Forms.PictureBox()
        Me.pbstar5 = New System.Windows.Forms.PictureBox()
        Me.lblcomsug = New System.Windows.Forms.Label()
        Me.txtcomsug = New System.Windows.Forms.TextBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.panelBackground.SuspendLayout()
        CType(Me.pbLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbstar1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbstar2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbstar3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbstar4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbstar5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'panelBackground
        '
        Me.panelBackground.BackColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(43, Byte), Integer))
        Me.panelBackground.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.panelBackground.Controls.Add(Me.lblfeedback)
        Me.panelBackground.Controls.Add(Me.pbLogo)
        Me.panelBackground.Dock = System.Windows.Forms.DockStyle.Top
        Me.panelBackground.Location = New System.Drawing.Point(0, 0)
        Me.panelBackground.Name = "panelBackground"
        Me.panelBackground.Size = New System.Drawing.Size(1280, 200)
        Me.panelBackground.TabIndex = 2
        '
        'lblfeedback
        '
        Me.lblfeedback.Font = New System.Drawing.Font("Carlson script", 66.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblfeedback.ForeColor = System.Drawing.Color.FromArgb(CType(CType(228, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.lblfeedback.Location = New System.Drawing.Point(417, 33)
        Me.lblfeedback.Name = "lblfeedback"
        Me.lblfeedback.Size = New System.Drawing.Size(554, 163)
        Me.lblfeedback.TabIndex = 1
        Me.lblfeedback.Text = "Feedback"
        Me.lblfeedback.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'pbLogo
        '
        Me.pbLogo.Image = Global.MunchFlix.My.Resources.Resources.munchbear_logo_picture
        Me.pbLogo.Location = New System.Drawing.Point(-2, -2)
        Me.pbLogo.Name = "pbLogo"
        Me.pbLogo.Size = New System.Drawing.Size(326, 200)
        Me.pbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pbLogo.TabIndex = 0
        Me.pbLogo.TabStop = False
        '
        'lbldescription
        '
        Me.lbldescription.BackColor = System.Drawing.Color.Transparent
        Me.lbldescription.Font = New System.Drawing.Font("Pacifico", 26.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbldescription.ForeColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(43, Byte), Integer))
        Me.lbldescription.Location = New System.Drawing.Point(151, 212)
        Me.lbldescription.Name = "lbldescription"
        Me.lbldescription.Size = New System.Drawing.Size(994, 140)
        Me.lbldescription.TabIndex = 2
        Me.lbldescription.Text = "We value our customers’ opinions; we strive to improve for you. " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Just be mindful" &
    " of your words and keep your comments friendly!"
        Me.lbldescription.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'pbstar1
        '
        Me.pbstar1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.pbstar1.Image = Global.MunchFlix.My.Resources.Resources.star
        Me.pbstar1.Location = New System.Drawing.Point(41, 390)
        Me.pbstar1.Name = "pbstar1"
        Me.pbstar1.Size = New System.Drawing.Size(187, 169)
        Me.pbstar1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pbstar1.TabIndex = 3
        Me.pbstar1.TabStop = False
        '
        'pbstar2
        '
        Me.pbstar2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.pbstar2.Image = Global.MunchFlix.My.Resources.Resources.star
        Me.pbstar2.Location = New System.Drawing.Point(286, 390)
        Me.pbstar2.Name = "pbstar2"
        Me.pbstar2.Size = New System.Drawing.Size(187, 169)
        Me.pbstar2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pbstar2.TabIndex = 4
        Me.pbstar2.TabStop = False
        '
        'pbstar3
        '
        Me.pbstar3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.pbstar3.Image = Global.MunchFlix.My.Resources.Resources.star
        Me.pbstar3.Location = New System.Drawing.Point(531, 390)
        Me.pbstar3.Name = "pbstar3"
        Me.pbstar3.Size = New System.Drawing.Size(187, 169)
        Me.pbstar3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pbstar3.TabIndex = 5
        Me.pbstar3.TabStop = False
        '
        'pbstar4
        '
        Me.pbstar4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.pbstar4.Image = Global.MunchFlix.My.Resources.Resources.star
        Me.pbstar4.Location = New System.Drawing.Point(781, 390)
        Me.pbstar4.Name = "pbstar4"
        Me.pbstar4.Size = New System.Drawing.Size(187, 169)
        Me.pbstar4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pbstar4.TabIndex = 6
        Me.pbstar4.TabStop = False
        '
        'pbstar5
        '
        Me.pbstar5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.pbstar5.Image = Global.MunchFlix.My.Resources.Resources.star
        Me.pbstar5.Location = New System.Drawing.Point(1022, 390)
        Me.pbstar5.Name = "pbstar5"
        Me.pbstar5.Size = New System.Drawing.Size(187, 169)
        Me.pbstar5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pbstar5.TabIndex = 7
        Me.pbstar5.TabStop = False
        '
        'lblcomsug
        '
        Me.lblcomsug.BackColor = System.Drawing.Color.Transparent
        Me.lblcomsug.Font = New System.Drawing.Font("Pacifico", 17.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblcomsug.ForeColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(43, Byte), Integer))
        Me.lblcomsug.Location = New System.Drawing.Point(12, 617)
        Me.lblcomsug.Name = "lblcomsug"
        Me.lblcomsug.Size = New System.Drawing.Size(259, 44)
        Me.lblcomsug.TabIndex = 8
        Me.lblcomsug.Text = "Comments/suggestions:"
        Me.lblcomsug.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtcomsug
        '
        Me.txtcomsug.BackColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(43, Byte), Integer))
        Me.txtcomsug.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtcomsug.Font = New System.Drawing.Font("Sitka Display", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtcomsug.ForeColor = System.Drawing.Color.FromArgb(CType(CType(228, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.txtcomsug.Location = New System.Drawing.Point(309, 617)
        Me.txtcomsug.Multiline = True
        Me.txtcomsug.Name = "txtcomsug"
        Me.txtcomsug.Size = New System.Drawing.Size(558, 70)
        Me.txtcomsug.TabIndex = 9
        Me.txtcomsug.Text = "Comment here ^^"
        Me.txtcomsug.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.MunchFlix.My.Resources.Resources.rounded_txt_box1__1_
        Me.PictureBox1.Location = New System.Drawing.Point(262, 346)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(656, 612)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 10
        Me.PictureBox1.TabStop = False
        '
        'frmFeedback
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(228, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1280, 720)
        Me.Controls.Add(Me.txtcomsug)
        Me.Controls.Add(Me.pbstar5)
        Me.Controls.Add(Me.pbstar4)
        Me.Controls.Add(Me.pbstar3)
        Me.Controls.Add(Me.pbstar2)
        Me.Controls.Add(Me.pbstar1)
        Me.Controls.Add(Me.lbldescription)
        Me.Controls.Add(Me.panelBackground)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.lblcomsug)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frmFeedback"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "MB | Feedback"
        Me.panelBackground.ResumeLayout(False)
        CType(Me.pbLogo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbstar1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbstar2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbstar3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbstar4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbstar5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents panelBackground As Panel
    Friend WithEvents lblfeedback As Label
    Friend WithEvents pbLogo As PictureBox
    Friend WithEvents lbldescription As Label
    Friend WithEvents pbstar1 As PictureBox
    Friend WithEvents pbstar2 As PictureBox
    Friend WithEvents pbstar3 As PictureBox
    Friend WithEvents pbstar4 As PictureBox
    Friend WithEvents pbstar5 As PictureBox
    Friend WithEvents lblcomsug As Label
    Friend WithEvents txtcomsug As TextBox
    Friend WithEvents PictureBox1 As PictureBox
End Class
