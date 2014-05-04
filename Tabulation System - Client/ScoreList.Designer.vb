<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ScoreList
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
        Me.DataGridView = New System.Windows.Forms.DataGridView()
        Me.lbl_font = New System.Windows.Forms.Label()
        Me.number = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.candidate_image = New System.Windows.Forms.DataGridViewImageColumn()
        Me.candidate_name = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.score = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.DataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView
        '
        Me.DataGridView.AllowUserToAddRows = False
        Me.DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.number, Me.candidate_image, Me.candidate_name, Me.score})
        Me.DataGridView.Location = New System.Drawing.Point(12, 12)
        Me.DataGridView.Name = "DataGridView"
        Me.DataGridView.RowTemplate.Height = 150
        Me.DataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView.Size = New System.Drawing.Size(541, 510)
        Me.DataGridView.TabIndex = 0
        '
        'lbl_font
        '
        Me.lbl_font.AutoSize = True
        Me.lbl_font.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_font.Location = New System.Drawing.Point(138, 499)
        Me.lbl_font.Name = "lbl_font"
        Me.lbl_font.Size = New System.Drawing.Size(37, 20)
        Me.lbl_font.TabIndex = 1
        Me.lbl_font.Text = "font"
        Me.lbl_font.Visible = False
        '
        'number
        '
        Me.number.HeaderText = "Number"
        Me.number.Name = "number"
        Me.number.ReadOnly = True
        Me.number.Width = 80
        '
        'candidate_image
        '
        Me.candidate_image.HeaderText = "Image"
        Me.candidate_image.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Stretch
        Me.candidate_image.Name = "candidate_image"
        Me.candidate_image.ReadOnly = True
        '
        'candidate_name
        '
        Me.candidate_name.HeaderText = "Name"
        Me.candidate_name.Name = "candidate_name"
        Me.candidate_name.ReadOnly = True
        Me.candidate_name.Width = 230
        '
        'score
        '
        Me.score.HeaderText = "Score"
        Me.score.Name = "score"
        Me.score.ReadOnly = True
        '
        'ScoreList
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(565, 534)
        Me.Controls.Add(Me.lbl_font)
        Me.Controls.Add(Me.DataGridView)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "ScoreList"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ScoreList"
        Me.TopMost = True
        CType(Me.DataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents lbl_font As System.Windows.Forms.Label
    Friend WithEvents number As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents candidate_image As System.Windows.Forms.DataGridViewImageColumn
    Friend WithEvents candidate_name As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents score As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
