﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class StdLogin
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(StdLogin))
        Me.btnLogin = New System.Windows.Forms.Button()
        Me.user = New System.Windows.Forms.TextBox()
        Me.password = New System.Windows.Forms.TextBox()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.btnAbout = New System.Windows.Forms.Button()
        Me.eye = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lblSwitchLogin = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnUseRFID = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        CType(Me.eye, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnLogin
        '
        Me.btnLogin.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(8, Byte), Integer))
        Me.btnLogin.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnLogin.Font = New System.Drawing.Font("Verdana", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLogin.ForeColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(46, Byte), Integer))
        Me.btnLogin.Location = New System.Drawing.Point(149, 241)
        Me.btnLogin.Name = "btnLogin"
        Me.btnLogin.Size = New System.Drawing.Size(148, 60)
        Me.btnLogin.TabIndex = 4
        Me.btnLogin.Text = "LOGIN"
        Me.btnLogin.UseVisualStyleBackColor = False
        '
        'user
        '
        Me.user.BackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(46, Byte), Integer))
        Me.user.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.user.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower
        Me.user.Font = New System.Drawing.Font("Verdana", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.user.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.user.Location = New System.Drawing.Point(45, 82)
        Me.user.MaxLength = 50
        Me.user.Name = "user"
        Me.user.Size = New System.Drawing.Size(352, 31)
        Me.user.TabIndex = 1
        '
        'password
        '
        Me.password.BackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(46, Byte), Integer))
        Me.password.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.password.Font = New System.Drawing.Font("Verdana", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.password.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.password.Location = New System.Drawing.Point(45, 164)
        Me.password.MaxLength = 50
        Me.password.Name = "password"
        Me.password.Size = New System.Drawing.Size(352, 31)
        Me.password.TabIndex = 2
        Me.password.UseSystemPasswordChar = True
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.BackColor = System.Drawing.Color.Transparent
        Me.CheckBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CheckBox1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(46, Byte), Integer))
        Me.CheckBox1.Location = New System.Drawing.Point(45, 201)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(59, 20)
        Me.CheckBox1.TabIndex = 3
        Me.CheckBox1.Text = "Show"
        Me.CheckBox1.UseVisualStyleBackColor = False
        Me.CheckBox1.Visible = False
        '
        'btnAbout
        '
        Me.btnAbout.BackColor = System.Drawing.Color.Transparent
        Me.btnAbout.BackgroundImage = Global.VotingSystem_Perez.My.Resources.Resources.icons8_info_48
        Me.btnAbout.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnAbout.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAbout.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAbout.ForeColor = System.Drawing.Color.Transparent
        Me.btnAbout.Location = New System.Drawing.Point(11, 701)
        Me.btnAbout.Name = "btnAbout"
        Me.btnAbout.Size = New System.Drawing.Size(30, 32)
        Me.btnAbout.TabIndex = 6
        Me.btnAbout.UseVisualStyleBackColor = False
        '
        'eye
        '
        Me.eye.BackColor = System.Drawing.Color.Transparent
        Me.eye.BackgroundImage = CType(resources.GetObject("eye.BackgroundImage"), System.Drawing.Image)
        Me.eye.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.eye.InitialImage = CType(resources.GetObject("eye.InitialImage"), System.Drawing.Image)
        Me.eye.Location = New System.Drawing.Point(352, 166)
        Me.eye.Name = "eye"
        Me.eye.Size = New System.Drawing.Size(43, 27)
        Me.eye.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.eye.TabIndex = 19
        Me.eye.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(46, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(42, 61)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(130, 18)
        Me.Label1.TabIndex = 20
        Me.Label1.Text = "email address:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(46, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(42, 143)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(92, 18)
        Me.Label2.TabIndex = 21
        Me.Label2.Text = "password:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label3.Location = New System.Drawing.Point(47, 715)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(166, 16)
        Me.Label3.TabIndex = 22
        Me.Label3.Text = "©2023 BSIT-3F Group 5"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(46, Byte), Integer))
        Me.Label9.Font = New System.Drawing.Font("Verdana", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(8, Byte), Integer))
        Me.Label9.Location = New System.Drawing.Point(-23, 73)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(577, 38)
        Me.Label9.TabIndex = 25
        Me.Label9.Text = "   Automated Student Council   "
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Verdana", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(46, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(176, 21)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(173, 32)
        Me.Label5.TabIndex = 24
        Me.Label5.Text = "GROUP #5"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(46, Byte), Integer))
        Me.Label4.Font = New System.Drawing.Font("Verdana", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(8, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(-15, 118)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(564, 38)
        Me.Label4.TabIndex = 26
        Me.Label4.Text = "             Voting System             "
        '
        'lblSwitchLogin
        '
        Me.lblSwitchLogin.AutoSize = True
        Me.lblSwitchLogin.BackColor = System.Drawing.Color.Transparent
        Me.lblSwitchLogin.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblSwitchLogin.Font = New System.Drawing.Font("Verdana", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSwitchLogin.ForeColor = System.Drawing.Color.MediumBlue
        Me.lblSwitchLogin.Location = New System.Drawing.Point(154, 615)
        Me.lblSwitchLogin.Name = "lblSwitchLogin"
        Me.lblSwitchLogin.Size = New System.Drawing.Size(204, 16)
        Me.lblSwitchLogin.TabIndex = 5
        Me.lblSwitchLogin.Text = "click here to login as admin"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.GroupBox1.Controls.Add(Me.btnUseRFID)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.eye)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.user)
        Me.GroupBox1.Controls.Add(Me.CheckBox1)
        Me.GroupBox1.Controls.Add(Me.btnLogin)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.password)
        Me.GroupBox1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(46, Byte), Integer))
        Me.GroupBox1.Location = New System.Drawing.Point(43, 226)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(443, 336)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'btnUseRFID
        '
        Me.btnUseRFID.BackColor = System.Drawing.Color.DarkCyan
        Me.btnUseRFID.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnUseRFID.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnUseRFID.Font = New System.Drawing.Font("Verdana", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUseRFID.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.btnUseRFID.Location = New System.Drawing.Point(302, 18)
        Me.btnUseRFID.Name = "btnUseRFID"
        Me.btnUseRFID.Size = New System.Drawing.Size(124, 34)
        Me.btnUseRFID.TabIndex = 42
        Me.btnUseRFID.Text = "Use RFID"
        Me.btnUseRFID.UseVisualStyleBackColor = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(46, Byte), Integer))
        Me.Label6.Location = New System.Drawing.Point(14, 14)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(154, 18)
        Me.Label6.TabIndex = 41
        Me.Label6.Text = "Login as Student"
        '
        'StdLogin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(232, Byte), Integer), CType(CType(232, Byte), Integer), CType(CType(232, Byte), Integer))
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.ClientSize = New System.Drawing.Size(524, 740)
        Me.Controls.Add(Me.lblSwitchLogin)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.btnAbout)
        Me.Controls.Add(Me.GroupBox1)
        Me.DoubleBuffered = True
        Me.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.MaximizeBox = False
        Me.Name = "StdLogin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "D"
        CType(Me.eye, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnLogin As Button
    Friend WithEvents user As TextBox
    Friend WithEvents password As TextBox
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents btnAbout As Button
    Friend WithEvents eye As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents lblSwitchLogin As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label6 As Label
    Friend WithEvents btnUseRFID As Button
End Class
