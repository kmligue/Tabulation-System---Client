Public Class CandidateList2

    Private Sub CandidateList2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim counter As Integer = 0
        Dim item As New ListViewItem
        Dim sql As String = "SELECT name, image FROM t_candidate WHERE top = 1 ORDER BY number ASC"

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

        Dim score1 As Double = getScore1(Functions.getId("SELECT id FROM t_candidate WHERE name = '" & ListView.SelectedItems(0).Text & "'"))
        Dim score2 As Double = getScore2(Functions.getId("SELECT id FROM t_candidate WHERE name = '" & ListView.SelectedItems(0).Text & "'"))

        ' get score if available
        If Not score1 = 0.0 Then
            txt_score1.Text = score1
        End If

        If Not score2 = 0.0 Then
            txt_score2.Text = score2
        End If
    End Sub

    Private Function getScore1(ByVal candidateId As Integer) As Double
        Dim score As Double = 0.0
        Dim sql As String = "SELECT score1 FROM t_final WHERE candidate_id = '" & candidateId & "' AND judge_id = '" & lbl_judge_id.Text & "' AND score1 <> 'null'"

        Try
            Connect.constring.Open()
            Functions.com.Connection = Connect.constring
            Functions.com.CommandText = sql
            Functions.reader = Functions.com.ExecuteReader

            While reader.Read
                If reader.HasRows Then
                    score = reader(0)
                End If
            End While
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            Connect.constring.Close()
        End Try

        Return score
    End Function

    Private Function getScore2(ByVal candidateId As Integer) As Double
        Dim score As Double = 0.0
        Dim sql As String = "SELECT score2 FROM t_final WHERE candidate_id = '" & candidateId & "' AND judge_id = '" & lbl_judge_id.Text & "' AND score2 <> 'null'"

        Try
            Connect.constring.Open()
            Functions.com.Connection = Connect.constring
            Functions.com.CommandText = sql
            Functions.reader = Functions.com.ExecuteReader

            While reader.Read
                If reader.HasRows Then
                    score = reader(0)
                End If
            End While
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            Connect.constring.Close()
        End Try

        Return score
    End Function

    Private Sub CandidateList2_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Dim sql As String = "UPDATE t_judge SET status = 0 WHERE id = '" & lbl_judge_id.Text & "'"

        Try
            Connect.constring.Open()
            Functions.com.Connection = Connect.constring
            Functions.com.CommandText = sql
            Functions.com.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            Connect.constring.Close()
            Login.Show()
        End Try
    End Sub

    Private Sub ListView_Click(sender As Object, e As EventArgs) Handles ListView.Click
        pb_main.BackgroundImage = Image.FromFile(Application.StartupPath & "\Images\" & ListView.SelectedItems(0).Text & ".jpg")

        txt_score1.Text = ""
        txt_score2.Text = ""

        Dim score1 As Double = getScore1(Functions.getId("SELECT id FROM t_candidate WHERE name = '" & ListView.SelectedItems(0).Text & "'"))
        Dim score2 As Double = getScore2(Functions.getId("SELECT id FROM t_candidate WHERE name = '" & ListView.SelectedItems(0).Text & "'"))

        ' get score if available
        If Not score1 = 0.0 Then
            txt_score1.Text = score1
        End If

        If Not score2 = 0.0 Then
            txt_score2.Text = score2
        End If
    End Sub

    Private Sub inputScore1(ByVal score As String, ByVal candidateId As Integer)
        Dim sql As String

        If Functions.isExist("SELECT * FROM t_final WHERE candidate_id = '" & candidateId & "' AND judge_id = '" & lbl_judge_id.Text & "'") Then
            sql = "UPDATE t_final SET score1 = '" & score & "' WHERE candidate_id = '" & candidateId & "' AND judge_id = '" & lbl_judge_id.Text & "'"
        Else
            sql = "INSERT INTO t_final(judge_id, event_id, candidate_id, score1) VALUES('" & lbl_judge_id.Text & "', '" & lbl_event_id.Text & "', '" & candidateId & "', '" & score & "')"
        End If

        Try
            Connect.constring.Open()
            Functions.com.Connection = Connect.constring
            Functions.com.CommandText = sql
            Functions.com.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            Connect.constring.Close()
        End Try
    End Sub

    Private Sub inputScore2(ByVal score As String, ByVal candidateId As Integer)
        Dim sql As String

        If Functions.isExist("SELECT * FROM t_final WHERE candidate_id = '" & candidateId & "' AND judge_id = '" & lbl_judge_id.Text & "'") Then
            sql = "UPDATE t_final SET score2 = '" & score & "' WHERE candidate_id = '" & candidateId & "' AND judge_id = '" & lbl_judge_id.Text & "'"
        Else
            sql = "INSERT INTO t_final(judge_id, event_id, candidate_id, score2) VALUES('" & lbl_judge_id.Text & "', '" & lbl_event_id.Text & "', '" & candidateId & "', '" & score & "')"
        End If

        Try
            Connect.constring.Open()
            Functions.com.Connection = Connect.constring
            Functions.com.CommandText = sql
            Functions.com.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            Connect.constring.Close()
        End Try
    End Sub

    Private Sub btn_save_Click(sender As Object, e As EventArgs) Handles btn_save.Click

        If Not txt_score1.Text = "" Then
            Dim candidateId As Integer = Functions.getId("SELECT id FROM t_candidate WHERE name = '" & ListView.SelectedItems(0).Text & "'")

            inputScore1(txt_score1.Text, candidateId)
        End If

        If Not txt_score2.Text = "" Then
            Dim candidateId As Integer = Functions.getId("SELECT id FROM t_candidate WHERE name = '" & ListView.SelectedItems(0).Text & "'")

            inputScore2(txt_score2.Text, candidateId)
        End If
    End Sub

    Private Sub txt_score1_KeyUp(sender As Object, e As KeyEventArgs) Handles txt_score1.KeyUp
        If Not IsNumeric(txt_score1.Text) Or Val(txt_score1.Text) > 50 Then
            MsgBox("Error")
            txt_score1.Text = ""
        End If
    End Sub

    Private Sub txt_score2_KeyUp(sender As Object, e As KeyEventArgs) Handles txt_score2.KeyUp
        If Not IsNumeric(txt_score2.Text) Or Val(txt_score2.Text) > 50 Then
            MsgBox("Error")
            txt_score2.Text = ""
        End If
    End Sub
End Class