<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FinishedGame
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
        Me.lblWinngingMessage = New System.Windows.Forms.Label()
        Me.btnStart = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblWinngingMessage
        '
        Me.lblWinngingMessage.Font = New System.Drawing.Font("Buxton Sketch", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblWinngingMessage.Location = New System.Drawing.Point(12, 24)
        Me.lblWinngingMessage.Name = "lblWinngingMessage"
        Me.lblWinngingMessage.Size = New System.Drawing.Size(510, 128)
        Me.lblWinngingMessage.TabIndex = 0
        '
        'btnStart
        '
        Me.btnStart.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnStart.Font = New System.Drawing.Font("Buxton Sketch", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnStart.ForeColor = System.Drawing.Color.Transparent
        Me.btnStart.Image = Global.Shooting_Game.My.Resources.Resources.gold_wood_sign_clipart
        Me.btnStart.Location = New System.Drawing.Point(45, 193)
        Me.btnStart.Name = "btnStart"
        Me.btnStart.Size = New System.Drawing.Size(218, 57)
        Me.btnStart.TabIndex = 1
        Me.btnStart.Text = "To Main Menu"
        Me.btnStart.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button1.Font = New System.Drawing.Font("Buxton Sketch", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.Transparent
        Me.Button1.Image = Global.Shooting_Game.My.Resources.Resources.gold_wood_sign_clipart
        Me.Button1.Location = New System.Drawing.Point(284, 193)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(218, 57)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "Try Again"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'FinishedGame
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.ClientSize = New System.Drawing.Size(548, 262)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.btnStart)
        Me.Controls.Add(Me.lblWinngingMessage)
        Me.Name = "FinishedGame"
        Me.Text = "Game Completed!"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lblWinngingMessage As System.Windows.Forms.Label
    Friend WithEvents btnStart As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
End Class
