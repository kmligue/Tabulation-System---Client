Public Class CandidateList2

    Private Sub CandidateList2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim counter As Integer = 0
        Dim item As New ListViewItem
        Dim sql As String = "SELECT name, image FROM t_candidate ORDER BY number ASC"

        ImageList.Images.Clear()
        ListView.Items.Clear()

        Try
            Connect.constring.Open()
            Functions.com.Connection = Connect.constring
            Functions.com.CommandText = sql
            Functions.reader = Functions.com.ExecuteReader

            While reader.Read
                If reader.HasRows Then

                    ImageList.Images.Add(Image.FromFile(Application.StartupPath & "\Images\" & reader(1)))
                    item = ListView.Items.Add(reader(0), counter)
                    counter += 1

                End If
            End While
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            Connect.constring.Close()
        End Try

        ListView.Items(0).Selected = True
        ListView.Select()

        pb_main.BackgroundImage = Image.FromFile(Application.StartupPath & "\Images\" & ListView.SelectedItems(0).Text & ".jpg")

        'Dim score As Double = Functions.getScore(Functions.getId("SELECT id FROM t_candidate WHERE name = '" & ListView.SelectedItems(0).Text & "'"), "t_" & lbl_event.Text)

        '' get score if available
        'If Not score = 0.0 Then
        '    txt_score.Text = score
        'End If
    End Sub
End Class