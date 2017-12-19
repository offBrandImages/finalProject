<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class simonSays
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
        Me.picBlue = New System.Windows.Forms.PictureBox()
        Me.picYellow = New System.Windows.Forms.PictureBox()
        Me.picRed = New System.Windows.Forms.PictureBox()
        Me.picGreen = New System.Windows.Forms.PictureBox()
        Me.btnStartRound = New System.Windows.Forms.Button()
        Me.timerGreen = New System.Windows.Forms.Timer(Me.components)
        Me.timerBlue = New System.Windows.Forms.Timer(Me.components)
        Me.timerYellow = New System.Windows.Forms.Timer(Me.components)
        Me.timerRed = New System.Windows.Forms.Timer(Me.components)
        Me.mainTimer = New System.Windows.Forms.Timer(Me.components)
        Me.timerCleanUp = New System.Windows.Forms.Timer(Me.components)
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.picBlue, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picYellow, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picRed, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picGreen, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'picBlue
        '
        Me.picBlue.Image = Global.pong.My.Resources.Resources.blueDim
        Me.picBlue.Location = New System.Drawing.Point(139, 234)
        Me.picBlue.Name = "picBlue"
        Me.picBlue.Size = New System.Drawing.Size(100, 100)
        Me.picBlue.TabIndex = 3
        Me.picBlue.TabStop = False
        '
        'picYellow
        '
        Me.picYellow.Image = Global.pong.My.Resources.Resources.yellowDim
        Me.picYellow.Location = New System.Drawing.Point(245, 234)
        Me.picYellow.Name = "picYellow"
        Me.picYellow.Size = New System.Drawing.Size(100, 100)
        Me.picYellow.TabIndex = 2
        Me.picYellow.TabStop = False
        '
        'picRed
        '
        Me.picRed.Image = Global.pong.My.Resources.Resources.RedDim
        Me.picRed.Location = New System.Drawing.Point(139, 128)
        Me.picRed.Name = "picRed"
        Me.picRed.Size = New System.Drawing.Size(100, 100)
        Me.picRed.TabIndex = 1
        Me.picRed.TabStop = False
        '
        'picGreen
        '
        Me.picGreen.Image = Global.pong.My.Resources.Resources.greenDim
        Me.picGreen.Location = New System.Drawing.Point(33, 234)
        Me.picGreen.Name = "picGreen"
        Me.picGreen.Size = New System.Drawing.Size(100, 100)
        Me.picGreen.TabIndex = 0
        Me.picGreen.TabStop = False
        '
        'btnStartRound
        '
        Me.btnStartRound.Location = New System.Drawing.Point(396, 427)
        Me.btnStartRound.Name = "btnStartRound"
        Me.btnStartRound.Size = New System.Drawing.Size(75, 23)
        Me.btnStartRound.TabIndex = 4
        Me.btnStartRound.Text = "Start"
        Me.btnStartRound.UseVisualStyleBackColor = True
        '
        'timerGreen
        '
        Me.timerGreen.Interval = 500
        '
        'timerBlue
        '
        Me.timerBlue.Interval = 500
        '
        'timerYellow
        '
        Me.timerYellow.Interval = 500
        '
        'timerRed
        '
        Me.timerRed.Interval = 500
        '
        'mainTimer
        '
        Me.mainTimer.Interval = 500
        '
        'timerCleanUp
        '
        Me.timerCleanUp.Interval = 500
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(12, 427)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 5
        Me.Button1.Text = "List Array"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(93, 437)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(0, 13)
        Me.Label1.TabIndex = 6
        '
        'simonSays
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(484, 462)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.btnStartRound)
        Me.Controls.Add(Me.picBlue)
        Me.Controls.Add(Me.picYellow)
        Me.Controls.Add(Me.picRed)
        Me.Controls.Add(Me.picGreen)
        Me.Name = "simonSays"
        Me.Text = "simonSays"
        CType(Me.picBlue, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picYellow, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picRed, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picGreen, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents picGreen As System.Windows.Forms.PictureBox
    Friend WithEvents picRed As System.Windows.Forms.PictureBox
    Friend WithEvents picYellow As System.Windows.Forms.PictureBox
    Friend WithEvents picBlue As System.Windows.Forms.PictureBox
    Friend WithEvents btnStartRound As System.Windows.Forms.Button
    Friend WithEvents timerGreen As System.Windows.Forms.Timer
    Friend WithEvents timerBlue As System.Windows.Forms.Timer
    Friend WithEvents timerYellow As System.Windows.Forms.Timer
    Friend WithEvents timerRed As System.Windows.Forms.Timer
    Friend WithEvents mainTimer As System.Windows.Forms.Timer
    Friend WithEvents timerCleanUp As System.Windows.Forms.Timer
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
