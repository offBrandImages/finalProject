<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.picBallMain = New System.Windows.Forms.PictureBox()
        Me.picPaddle2 = New System.Windows.Forms.PictureBox()
        Me.picPaddle1 = New System.Windows.Forms.PictureBox()
        CType(Me.picBallMain, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picPaddle2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picPaddle1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'picBallMain
        '
        Me.picBallMain.Image = Global.pong.My.Resources.Resources.ball
        Me.picBallMain.Location = New System.Drawing.Point(372, 176)
        Me.picBallMain.Name = "picBallMain"
        Me.picBallMain.Size = New System.Drawing.Size(24, 24)
        Me.picBallMain.TabIndex = 2
        Me.picBallMain.TabStop = False
        '
        'picPaddle2
        '
        Me.picPaddle2.Image = Global.pong.My.Resources.Resources.Paddle
        Me.picPaddle2.Location = New System.Drawing.Point(862, 12)
        Me.picPaddle2.Name = "picPaddle2"
        Me.picPaddle2.Size = New System.Drawing.Size(10, 50)
        Me.picPaddle2.TabIndex = 1
        Me.picPaddle2.TabStop = False
        '
        'picPaddle1
        '
        Me.picPaddle1.Image = Global.pong.My.Resources.Resources.Paddle
        Me.picPaddle1.Location = New System.Drawing.Point(12, 12)
        Me.picPaddle1.Name = "picPaddle1"
        Me.picPaddle1.Size = New System.Drawing.Size(10, 50)
        Me.picPaddle1.TabIndex = 0
        Me.picPaddle1.TabStop = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(884, 412)
        Me.Controls.Add(Me.picBallMain)
        Me.Controls.Add(Me.picPaddle2)
        Me.Controls.Add(Me.picPaddle1)
        Me.Name = "Form1"
        Me.Text = "Pong"
        CType(Me.picBallMain, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picPaddle2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picPaddle1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents picPaddle1 As System.Windows.Forms.PictureBox
    Friend WithEvents picPaddle2 As System.Windows.Forms.PictureBox
    Friend WithEvents picBallMain As System.Windows.Forms.PictureBox

End Class
