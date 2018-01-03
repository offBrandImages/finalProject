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
        Me.components = New System.ComponentModel.Container()
        Me.btnStart = New System.Windows.Forms.Button()
        Me.picSmall1 = New System.Windows.Forms.PictureBox()
        Me.picMedium = New System.Windows.Forms.PictureBox()
        Me.picEasy = New System.Windows.Forms.PictureBox()
        Me.picSmall2 = New System.Windows.Forms.PictureBox()
        Me.picSmall3 = New System.Windows.Forms.PictureBox()
        Me.picMedium2 = New System.Windows.Forms.PictureBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        CType(Me.picSmall1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picMedium, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picEasy, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picSmall2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picSmall3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picMedium2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnStart
        '
        Me.btnStart.Location = New System.Drawing.Point(113, 266)
        Me.btnStart.Name = "btnStart"
        Me.btnStart.Size = New System.Drawing.Size(119, 41)
        Me.btnStart.TabIndex = 0
        Me.btnStart.Text = "Button1"
        Me.btnStart.UseVisualStyleBackColor = True
        '
        'picSmall1
        '
        Me.picSmall1.Image = Global.Shooting_Game.My.Resources.Resources.leadbrook_clay_logo
        Me.picSmall1.Location = New System.Drawing.Point(-2, -1)
        Me.picSmall1.Name = "picSmall1"
        Me.picSmall1.Size = New System.Drawing.Size(35, 42)
        Me.picSmall1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picSmall1.TabIndex = 1
        Me.picSmall1.TabStop = False
        '
        'picMedium
        '
        Me.picMedium.Image = Global.Shooting_Game.My.Resources.Resources.leadbrook_clay_logo
        Me.picMedium.Location = New System.Drawing.Point(-2, 37)
        Me.picMedium.Name = "picMedium"
        Me.picMedium.Size = New System.Drawing.Size(62, 67)
        Me.picMedium.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picMedium.TabIndex = 2
        Me.picMedium.TabStop = False
        '
        'picEasy
        '
        Me.picEasy.Image = Global.Shooting_Game.My.Resources.Resources.leadbrook_clay_logo
        Me.picEasy.Location = New System.Drawing.Point(-2, 143)
        Me.picEasy.Name = "picEasy"
        Me.picEasy.Size = New System.Drawing.Size(101, 86)
        Me.picEasy.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picEasy.TabIndex = 3
        Me.picEasy.TabStop = False
        '
        'picSmall2
        '
        Me.picSmall2.Image = Global.Shooting_Game.My.Resources.Resources.leadbrook_clay_logo
        Me.picSmall2.Location = New System.Drawing.Point(-2, 104)
        Me.picSmall2.Name = "picSmall2"
        Me.picSmall2.Size = New System.Drawing.Size(35, 42)
        Me.picSmall2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picSmall2.TabIndex = 4
        Me.picSmall2.TabStop = False
        '
        'picSmall3
        '
        Me.picSmall3.Image = Global.Shooting_Game.My.Resources.Resources.leadbrook_clay_logo
        Me.picSmall3.Location = New System.Drawing.Point(732, 23)
        Me.picSmall3.Name = "picSmall3"
        Me.picSmall3.Size = New System.Drawing.Size(35, 42)
        Me.picSmall3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picSmall3.TabIndex = 5
        Me.picSmall3.TabStop = False
        '
        'picMedium2
        '
        Me.picMedium2.Image = Global.Shooting_Game.My.Resources.Resources.leadbrook_clay_logo
        Me.picMedium2.Location = New System.Drawing.Point(705, 104)
        Me.picMedium2.Name = "picMedium2"
        Me.picMedium2.Size = New System.Drawing.Size(62, 67)
        Me.picMedium2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picMedium2.TabIndex = 6
        Me.picMedium2.TabStop = False
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 1000
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(764, 346)
        Me.Controls.Add(Me.picMedium2)
        Me.Controls.Add(Me.picSmall3)
        Me.Controls.Add(Me.picSmall2)
        Me.Controls.Add(Me.picEasy)
        Me.Controls.Add(Me.picMedium)
        Me.Controls.Add(Me.picSmall1)
        Me.Controls.Add(Me.btnStart)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.picSmall1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picMedium, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picEasy, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picSmall2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picSmall3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picMedium2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnStart As System.Windows.Forms.Button
    Friend WithEvents picSmall1 As System.Windows.Forms.PictureBox
    Friend WithEvents picMedium As System.Windows.Forms.PictureBox
    Friend WithEvents picEasy As System.Windows.Forms.PictureBox
    Friend WithEvents picSmall2 As System.Windows.Forms.PictureBox
    Friend WithEvents picSmall3 As System.Windows.Forms.PictureBox
    Friend WithEvents picMedium2 As System.Windows.Forms.PictureBox
    Friend WithEvents Timer1 As System.Windows.Forms.Timer

End Class
