<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Main
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
        Me.lbl_judge_id = New System.Windows.Forms.Label()
        Me.pb_gown = New System.Windows.Forms.PictureBox()
        Me.pb_interview = New System.Windows.Forms.PictureBox()
        Me.pb_swimwear = New System.Windows.Forms.PictureBox()
        Me.pb_talent = New System.Windows.Forms.PictureBox()
        Me.lbl_event_id = New System.Windows.Forms.Label()
        CType(Me.pb_gown, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pb_interview, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pb_swimwear, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pb_talent, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lbl_judge_id
        '
        Me.lbl_judge_id.AutoSize = True
        Me.lbl_judge_id.Location = New System.Drawing.Point(850, 20)
        Me.lbl_judge_id.Name = "lbl_judge_id"
        Me.lbl_judge_id.Size = New System.Drawing.Size(44, 13)
        Me.lbl_judge_id.TabIndex = 0
        Me.lbl_judge_id.Text = "judge id"
        Me.lbl_judge_id.Visible = False
        '
        'pb_gown
        '
        Me.pb_gown.BackColor = System.Drawing.Color.Transparent
        Me.pb_gown.BackgroundImage = Global.Tabulation_System___Client.My.Resources.Resources.gown
        Me.pb_gown.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pb_gown.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pb_gown.Location = New System.Drawing.Point(434, 63)
        Me.pb_gown.Name = "pb_gown"
        Me.pb_gown.Size = New System.Drawing.Size(222, 326)
        Me.pb_gown.TabIndex = 1
        Me.pb_gown.TabStop = False
        '
        'pb_interview
        '
        Me.pb_interview.BackColor = System.Drawing.Color.Transparent
        Me.pb_interview.BackgroundImage = Global.Tabulation_System___Client.My.Resources.Resources.interview
        Me.pb_interview.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pb_interview.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pb_interview.Location = New System.Drawing.Point(751, 63)
        Me.pb_interview.Name = "pb_interview"
        Me.pb_interview.Size = New System.Drawing.Size(222, 326)
        Me.pb_interview.TabIndex = 1
        Me.pb_interview.TabStop = False
        '
        'pb_swimwear
        '
        Me.pb_swimwear.BackColor = System.Drawing.Color.Transparent
        Me.pb_swimwear.BackgroundImage = Global.Tabulation_System___Client.My.Resources.Resources.swimwear
        Me.pb_swimwear.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pb_swimwear.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pb_swimwear.Location = New System.Drawing.Point(434, 383)
        Me.pb_swimwear.Name = "pb_swimwear"
        Me.pb_swimwear.Size = New System.Drawing.Size(222, 326)
        Me.pb_swimwear.TabIndex = 1
        Me.pb_swimwear.TabStop = False
        '
        'pb_talent
        '
        Me.pb_talent.BackColor = System.Drawing.Color.Transparent
        Me.pb_talent.BackgroundImage = Global.Tabulation_System___Client.My.Resources.Resources.talent
        Me.pb_talent.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pb_talent.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pb_talent.Location = New System.Drawing.Point(751, 383)
        Me.pb_talent.Name = "pb_talent"
        Me.pb_talent.Size = New System.Drawing.Size(222, 326)
        Me.pb_talent.TabIndex = 1
        Me.pb_talent.TabStop = False
        '
        'lbl_event_id
        '
        Me.lbl_event_id.AutoSize = True
        Me.lbl_event_id.Location = New System.Drawing.Point(697, 20)
        Me.lbl_event_id.Name = "lbl_event_id"
        Me.lbl_event_id.Size = New System.Drawing.Size(45, 13)
        Me.lbl_event_id.TabIndex = 2
        Me.lbl_event_id.Text = "event id"
        Me.lbl_event_id.Visible = False
        '
        'Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Tabulation_System___Client.My.Resources.Resources.background
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1024, 768)
        Me.Controls.Add(Me.lbl_event_id)
        Me.Controls.Add(Me.pb_swimwear)
        Me.Controls.Add(Me.pb_talent)
        Me.Controls.Add(Me.pb_interview)
        Me.Controls.Add(Me.pb_gown)
        Me.Controls.Add(Me.lbl_judge_id)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Main"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Main"
        CType(Me.pb_gown, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pb_interview, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pb_swimwear, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pb_talent, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lbl_judge_id As System.Windows.Forms.Label
    Friend WithEvents pb_gown As System.Windows.Forms.PictureBox
    Friend WithEvents pb_interview As System.Windows.Forms.PictureBox
    Friend WithEvents pb_swimwear As System.Windows.Forms.PictureBox
    Friend WithEvents pb_talent As System.Windows.Forms.PictureBox
    Friend WithEvents lbl_event_id As System.Windows.Forms.Label
End Class
