<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CandidateList2
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
        Me.pb_main = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.ImageList = New System.Windows.Forms.ImageList(Me.components)
        Me.txt_score2 = New System.Windows.Forms.TextBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.btn_save = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.txt_score1 = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ListView = New System.Windows.Forms.ListView()
        Me.lbl_judge_id = New System.Windows.Forms.Label()
        Me.lbl_event_id = New System.Windows.Forms.Label()
        CType(Me.pb_main, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pb_main
        '
        Me.pb_main.BackColor = System.Drawing.Color.Transparent
        Me.pb_main.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pb_main.Location = New System.Drawing.Point(514, 110)
        Me.pb_main.Name = "pb_main"
        Me.pb_main.Size = New System.Drawing.Size(319, 348)
        Me.pb_main.TabIndex = 6
        Me.pb_main.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.BackgroundImage = Global.Tabulation_System___Client.My.Resources.Resources.frame
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.ImageLocation = ""
        Me.PictureBox1.Location = New System.Drawing.Point(510, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(327, 449)
        Me.PictureBox1.TabIndex = 5
        Me.PictureBox1.TabStop = False
        '
        'ImageList
        '
        Me.ImageList.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit
        Me.ImageList.ImageSize = New System.Drawing.Size(180, 180)
        Me.ImageList.TransparentColor = System.Drawing.Color.Transparent
        '
        'txt_score2
        '
        Me.txt_score2.BackColor = System.Drawing.Color.White
        Me.txt_score2.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txt_score2.Font = New System.Drawing.Font("Microsoft Sans Serif", 47.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_score2.Location = New System.Drawing.Point(1068, 384)
        Me.txt_score2.Name = "txt_score2"
        Me.txt_score2.Size = New System.Drawing.Size(100, 72)
        Me.txt_score2.TabIndex = 8
        Me.txt_score2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox2.BackgroundImage = Global.Tabulation_System___Client.My.Resources.Resources.textbox_border
        Me.PictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox2.Location = New System.Drawing.Point(1064, 378)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(108, 83)
        Me.PictureBox2.TabIndex = 7
        Me.PictureBox2.TabStop = False
        '
        'btn_save
        '
        Me.btn_save.BackgroundImage = Global.Tabulation_System___Client.My.Resources.Resources.SAVE
        Me.btn_save.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_save.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_save.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_save.Location = New System.Drawing.Point(609, 467)
        Me.btn_save.Name = "btn_save"
        Me.btn_save.Size = New System.Drawing.Size(134, 48)
        Me.btn_save.TabIndex = 9
        Me.btn_save.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 30.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(919, 299)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(143, 46)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "Score:"
        '
        'PictureBox3
        '
        Me.PictureBox3.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox3.BackgroundImage = Global.Tabulation_System___Client.My.Resources.Resources.textbox_border
        Me.PictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox3.Location = New System.Drawing.Point(1064, 277)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(108, 83)
        Me.PictureBox3.TabIndex = 7
        Me.PictureBox3.TabStop = False
        '
        'txt_score1
        '
        Me.txt_score1.BackColor = System.Drawing.Color.White
        Me.txt_score1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txt_score1.Font = New System.Drawing.Font("Microsoft Sans Serif", 47.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_score1.Location = New System.Drawing.Point(1068, 283)
        Me.txt_score1.Name = "txt_score1"
        Me.txt_score1.Size = New System.Drawing.Size(100, 72)
        Me.txt_score1.TabIndex = 8
        Me.txt_score1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 30.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(1177, 299)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(90, 46)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "/ 50"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 30.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(1178, 402)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(90, 46)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "/ 50"
        '
        'ListView
        '
        Me.ListView.BackgroundImage = Global.Tabulation_System___Client.My.Resources.Resources.listview_background
        Me.ListView.BackgroundImageTiled = True
        Me.ListView.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListView.ForeColor = System.Drawing.Color.White
        Me.ListView.FullRowSelect = True
        Me.ListView.LargeImageList = Me.ImageList
        Me.ListView.Location = New System.Drawing.Point(98, 526)
        Me.ListView.Name = "ListView"
        Me.ListView.Size = New System.Drawing.Size(1169, 230)
        Me.ListView.SmallImageList = Me.ImageList
        Me.ListView.TabIndex = 12
        Me.ListView.UseCompatibleStateImageBehavior = False
        '
        'lbl_judge_id
        '
        Me.lbl_judge_id.AutoSize = True
        Me.lbl_judge_id.Location = New System.Drawing.Point(12, 9)
        Me.lbl_judge_id.Name = "lbl_judge_id"
        Me.lbl_judge_id.Size = New System.Drawing.Size(44, 13)
        Me.lbl_judge_id.TabIndex = 13
        Me.lbl_judge_id.Text = "judge id"
        Me.lbl_judge_id.Visible = False
        '
        'lbl_event_id
        '
        Me.lbl_event_id.AutoSize = True
        Me.lbl_event_id.Location = New System.Drawing.Point(13, 41)
        Me.lbl_event_id.Name = "lbl_event_id"
        Me.lbl_event_id.Size = New System.Drawing.Size(48, 13)
        Me.lbl_event_id.TabIndex = 14
        Me.lbl_event_id.Text = "event_id"
        Me.lbl_event_id.Visible = False
        '
        'CandidateList2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Tabulation_System___Client.My.Resources.Resources.background
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1366, 768)
        Me.Controls.Add(Me.lbl_event_id)
        Me.Controls.Add(Me.lbl_judge_id)
        Me.Controls.Add(Me.ListView)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btn_save)
        Me.Controls.Add(Me.txt_score1)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.txt_score2)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.pb_main)
        Me.Controls.Add(Me.PictureBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "CandidateList2"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "CandidateList2"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.pb_main, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents pb_main As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents ImageList As System.Windows.Forms.ImageList
    Friend WithEvents txt_score2 As System.Windows.Forms.TextBox
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents btn_save As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents PictureBox3 As System.Windows.Forms.PictureBox
    Friend WithEvents txt_score1 As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents ListView As System.Windows.Forms.ListView
    Friend WithEvents lbl_judge_id As System.Windows.Forms.Label
    Friend WithEvents lbl_event_id As System.Windows.Forms.Label
End Class
