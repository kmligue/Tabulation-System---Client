﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CandidateList1
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
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.ListView = New System.Windows.Forms.ListView()
        Me.ImageList = New System.Windows.Forms.ImageList(Me.components)
        Me.pb_main = New System.Windows.Forms.PictureBox()
        Me.btn_prev = New System.Windows.Forms.Button()
        Me.btn_next = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pb_main, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.BackgroundImage = Global.Tabulation_System___Client.My.Resources.Resources.frame
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.ImageLocation = ""
        Me.PictureBox1.Location = New System.Drawing.Point(355, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(303, 505)
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox2.BackgroundImage = Global.Tabulation_System___Client.My.Resources.Resources.textbox_border
        Me.PictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox2.Location = New System.Drawing.Point(436, 532)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(139, 83)
        Me.PictureBox2.TabIndex = 1
        Me.PictureBox2.TabStop = False
        '
        'TextBox1
        '
        Me.TextBox1.BackColor = System.Drawing.Color.White
        Me.TextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 47.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(440, 538)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(131, 72)
        Me.TextBox1.TabIndex = 2
        Me.TextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'ListView
        '
        Me.ListView.BackgroundImage = Global.Tabulation_System___Client.My.Resources.Resources.listview_background
        Me.ListView.BackgroundImageTiled = True
        Me.ListView.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.ListView.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListView.ForeColor = System.Drawing.Color.White
        Me.ListView.LargeImageList = Me.ImageList
        Me.ListView.Location = New System.Drawing.Point(677, 0)
        Me.ListView.Name = "ListView"
        Me.ListView.Size = New System.Drawing.Size(348, 768)
        Me.ListView.SmallImageList = Me.ImageList
        Me.ListView.TabIndex = 3
        Me.ListView.UseCompatibleStateImageBehavior = False
        '
        'ImageList
        '
        Me.ImageList.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit
        Me.ImageList.ImageSize = New System.Drawing.Size(120, 200)
        Me.ImageList.TransparentColor = System.Drawing.Color.Transparent
        '
        'pb_main
        '
        Me.pb_main.BackColor = System.Drawing.Color.Transparent
        Me.pb_main.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pb_main.Location = New System.Drawing.Point(359, 112)
        Me.pb_main.Name = "pb_main"
        Me.pb_main.Size = New System.Drawing.Size(295, 402)
        Me.pb_main.TabIndex = 4
        Me.pb_main.TabStop = False
        '
        'btn_prev
        '
        Me.btn_prev.BackgroundImage = Global.Tabulation_System___Client.My.Resources.Resources.btn_prev
        Me.btn_prev.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_prev.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_prev.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_prev.Location = New System.Drawing.Point(355, 645)
        Me.btn_prev.Name = "btn_prev"
        Me.btn_prev.Size = New System.Drawing.Size(134, 48)
        Me.btn_prev.TabIndex = 5
        Me.btn_prev.UseVisualStyleBackColor = True
        '
        'btn_next
        '
        Me.btn_next.BackgroundImage = Global.Tabulation_System___Client.My.Resources.Resources.btn_next
        Me.btn_next.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_next.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_next.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_next.Location = New System.Drawing.Point(524, 645)
        Me.btn_next.Name = "btn_next"
        Me.btn_next.Size = New System.Drawing.Size(134, 48)
        Me.btn_next.TabIndex = 5
        Me.btn_next.UseVisualStyleBackColor = True
        '
        'CandidateList1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Tabulation_System___Client.My.Resources.Resources.background
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1024, 768)
        Me.Controls.Add(Me.btn_next)
        Me.Controls.Add(Me.btn_prev)
        Me.Controls.Add(Me.pb_main)
        Me.Controls.Add(Me.ListView)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "CandidateList1"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "CandidateList1"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pb_main, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents ListView As System.Windows.Forms.ListView
    Friend WithEvents ImageList As System.Windows.Forms.ImageList
    Friend WithEvents pb_main As System.Windows.Forms.PictureBox
    Friend WithEvents btn_prev As System.Windows.Forms.Button
    Friend WithEvents btn_next As System.Windows.Forms.Button
End Class
