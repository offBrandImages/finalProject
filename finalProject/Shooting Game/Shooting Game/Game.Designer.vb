<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Game
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
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer3 = New System.Windows.Forms.Timer(Me.components)
        Me.picEasy = New System.Windows.Forms.PictureBox()
        Me.picSmall3 = New System.Windows.Forms.PictureBox()
        Me.picSmall1 = New System.Windows.Forms.PictureBox()
        Me.picSmall2 = New System.Windows.Forms.PictureBox()
        Me.picMedium = New System.Windows.Forms.PictureBox()
        Me.btnStart = New System.Windows.Forms.Button()
        Me.picMedium2 = New System.Windows.Forms.PictureBox()
        Me.picFlamOne = New System.Windows.Forms.PictureBox()
        Me.lblScore = New System.Windows.Forms.Label()
        Me.lblInstructions = New System.Windows.Forms.Label()
        Me.lblTimer = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.picEasy, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picSmall3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picSmall1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picSmall2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picMedium, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picMedium2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picFlamOne, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Timer1
        '
        Me.Timer1.Interval = 1000
        '
        'Timer2
        '
        Me.Timer2.Interval = 750
        '
        'Timer3
        '
        Me.Timer3.Interval = 450
        '
        'picEasy
        '
        Me.picEasy.Image = Global.Shooting_Game.My.Resources.Resources.source
        Me.picEasy.Location = New System.Drawing.Point(-2, 170)
        Me.picEasy.Name = "picEasy"
        Me.picEasy.Size = New System.Drawing.Size(111, 106)
        Me.picEasy.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picEasy.TabIndex = 3
        Me.picEasy.TabStop = False
        '
        'picSmall3
        '
        Me.picSmall3.Image = Global.Shooting_Game.My.Resources.Resources.giphy
        Me.picSmall3.Location = New System.Drawing.Point(732, 23)
        Me.picSmall3.Name = "picSmall3"
        Me.picSmall3.Size = New System.Drawing.Size(35, 42)
        Me.picSmall3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picSmall3.TabIndex = 5
        Me.picSmall3.TabStop = False
        '
        'picSmall1
        '
        Me.picSmall1.Image = Global.Shooting_Game.My.Resources.Resources.animatedDuck
        Me.picSmall1.Location = New System.Drawing.Point(-2, -1)
        Me.picSmall1.Name = "picSmall1"
        Me.picSmall1.Size = New System.Drawing.Size(35, 42)
        Me.picSmall1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picSmall1.TabIndex = 1
        Me.picSmall1.TabStop = False
        '
        'picSmall2
        '
        Me.picSmall2.Image = Global.Shooting_Game.My.Resources.Resources._1332726940807_dancing_duck
        Me.picSmall2.Location = New System.Drawing.Point(-2, 104)
        Me.picSmall2.Name = "picSmall2"
        Me.picSmall2.Size = New System.Drawing.Size(35, 42)
        Me.picSmall2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picSmall2.TabIndex = 4
        Me.picSmall2.TabStop = False
        '
        'picMedium
        '
        Me.picMedium.Image = Global.Shooting_Game.My.Resources.Resources.e5d00baeaaccf954ac275cc8de990a45
        Me.picMedium.Location = New System.Drawing.Point(-2, 23)
        Me.picMedium.Name = "picMedium"
        Me.picMedium.Size = New System.Drawing.Size(66, 109)
        Me.picMedium.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picMedium.TabIndex = 2
        Me.picMedium.TabStop = False
        '
        'btnStart
        '
        Me.btnStart.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnStart.Font = New System.Drawing.Font("Buxton Sketch", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnStart.ForeColor = System.Drawing.Color.Transparent
        Me.btnStart.Image = Global.Shooting_Game.My.Resources.Resources.gold_wood_sign_clipart
        Me.btnStart.Location = New System.Drawing.Point(252, 358)
        Me.btnStart.Name = "btnStart"
        Me.btnStart.Size = New System.Drawing.Size(259, 82)
        Me.btnStart.TabIndex = 0
        Me.btnStart.Text = "Start Game"
        Me.btnStart.UseVisualStyleBackColor = False
        '
        'picMedium2
        '
        Me.picMedium2.Image = Global.Shooting_Game.My.Resources.Resources._513804_657ba
        Me.picMedium2.Location = New System.Drawing.Point(705, 104)
        Me.picMedium2.Name = "picMedium2"
        Me.picMedium2.Size = New System.Drawing.Size(62, 67)
        Me.picMedium2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picMedium2.TabIndex = 6
        Me.picMedium2.TabStop = False
        '
        'picFlamOne
        '
        Me.picFlamOne.Image = Global.Shooting_Game.My.Resources.Resources.flamingoanimation_8
        Me.picFlamOne.Location = New System.Drawing.Point(-2, 331)
        Me.picFlamOne.Name = "picFlamOne"
        Me.picFlamOne.Size = New System.Drawing.Size(128, 124)
        Me.picFlamOne.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picFlamOne.TabIndex = 9
        Me.picFlamOne.TabStop = False
        '
        'lblScore
        '
        Me.lblScore.AutoSize = True
        Me.lblScore.Font = New System.Drawing.Font("Buxton Sketch", 72.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblScore.Location = New System.Drawing.Point(307, 104)
        Me.lblScore.Name = "lblScore"
        Me.lblScore.Size = New System.Drawing.Size(0, 119)
        Me.lblScore.TabIndex = 10
        Me.lblScore.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblInstructions
        '
        Me.lblInstructions.AutoSize = True
        Me.lblInstructions.Font = New System.Drawing.Font("Buxton Sketch", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInstructions.Location = New System.Drawing.Point(164, 28)
        Me.lblInstructions.Name = "lblInstructions"
        Me.lblInstructions.Size = New System.Drawing.Size(476, 104)
        Me.lblInstructions.TabIndex = 11
        Me.lblInstructions.Text = "Point and click to shoot a duck!" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "If you reach 24 points, you are a duck hunting " & _
    "master!" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Press Start Game to begin" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "You will have 15 Seconds."
        Me.lblInstructions.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblTimer
        '
        Me.lblTimer.AutoSize = True
        Me.lblTimer.Font = New System.Drawing.Font("Buxton Sketch", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTimer.Location = New System.Drawing.Point(394, 329)
        Me.lblTimer.Name = "lblTimer"
        Me.lblTimer.Size = New System.Drawing.Size(30, 26)
        Me.lblTimer.TabIndex = 12
        Me.lblTimer.Text = "15"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Buxton Sketch", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(322, 329)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(66, 26)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "Timer:"
        '
        'Game
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.ClientSize = New System.Drawing.Size(780, 452)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblTimer)
        Me.Controls.Add(Me.lblInstructions)
        Me.Controls.Add(Me.picEasy)
        Me.Controls.Add(Me.picSmall3)
        Me.Controls.Add(Me.picSmall1)
        Me.Controls.Add(Me.picSmall2)
        Me.Controls.Add(Me.picMedium)
        Me.Controls.Add(Me.btnStart)
        Me.Controls.Add(Me.picMedium2)
        Me.Controls.Add(Me.picFlamOne)
        Me.Controls.Add(Me.lblScore)
        Me.Cursor = System.Windows.Forms.Cursors.Cross
        Me.Name = "Game"
        Me.Text = "Shooting Spectacular Duck Hunt"
        CType(Me.picEasy, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picSmall3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picSmall1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picSmall2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picMedium, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picMedium2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picFlamOne, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnStart As System.Windows.Forms.Button
    Friend WithEvents picSmall1 As System.Windows.Forms.PictureBox
    Friend WithEvents picMedium As System.Windows.Forms.PictureBox
    Friend WithEvents picEasy As System.Windows.Forms.PictureBox
    Friend WithEvents picSmall2 As System.Windows.Forms.PictureBox
    Friend WithEvents picSmall3 As System.Windows.Forms.PictureBox
    Friend WithEvents picMedium2 As System.Windows.Forms.PictureBox
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents Timer2 As System.Windows.Forms.Timer
    Friend WithEvents Timer3 As System.Windows.Forms.Timer
    Friend WithEvents picFlamOne As System.Windows.Forms.PictureBox
    Friend WithEvents lblScore As System.Windows.Forms.Label
    Friend WithEvents lblInstructions As System.Windows.Forms.Label
    Friend WithEvents lblTimer As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label

End Class
