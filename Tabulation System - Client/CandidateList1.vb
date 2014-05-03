Imports System.IO

Public Class CandidateList1

    Dim count As Integer = 0

    Private Sub CandidateList1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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

        Dim score As Double = Functions.getScore(Functions.getId("SELECT id FROM t_candidate WHERE name = '" & ListView.SelectedItems(0).Text & "'"), "t_" & lbl_event.Text)

        ' get score if available
        If Not score = 0.0 Then
            txt_score.Text = score
        End If

    End Sub

    Private Sub ListView_Click(sender As Object, e As EventArgs) Handles ListView.Click
        pb_main.BackgroundImage = Image.FromFile(Application.StartupPath & "\Images\" & ListView.SelectedItems(0).Text & ".jpg")

        count = ListView.SelectedItems(0).Index

        Dim score As Double = Functions.getScore(Functions.getId("SELECT id FROM t_candidate WHERE name = '" & ListView.SelectedItems(0).Text & "'"), "t_" & lbl_event.Text)

        ' get score if available
        If Not score = 0.0 Then
            txt_score.Text = score
        End If
    End Sub

    Private Sub btn_next_Click(sender As Object, e As EventArgs) Handles btn_next.Click

        ' checks if score is inputted
        If Not txt_score.Text = "" Then
            ' save inputted score
            Dim candidateId As Integer = Functions.getId("SELECT id FROM t_candidate WHERE name = '" & ListView.Items(count).Text & "'")

            inputScore(txt_score.Text, candidateId, "t_" & lbl_event.Text.ToLower)
            txt_score.Text = ""
        End If

        count += 1

        If count >= ListView.Items.Count Then
            count -= 1

            ListView.SelectedItems.Clear()
            ListView.Items(count).Selected = True
            ListView.Select()
        Else
            ListView.SelectedItems.Clear()
            ListView.Items(count).Selected = True
            ListView.Select()
        End If



        pb_main.BackgroundImage = Image.FromFile(Application.StartupPath & "\Images\" & ListView.SelectedItems(0).Text & ".jpg")

        Dim score As Double = Functions.getScore(Functions.getId("SELECT id FROM t_candidate WHERE name = '" & ListView.SelectedItems(0).Text & "'"), "t_" & lbl_event.Text.ToLower)

        ' get score if available
        If Not score = 0.0 Then
            txt_score.Text = score
        End If
    End Sub

    Private Sub btn_prev_Click(sender As Object, e As EventArgs) Handles btn_prev.Click

        ' checks if score is inputted
        If Not txt_score.Text = "" Then
            ' save inputted score
            Dim candidateId As Integer = Functions.getId("SELECT id FROM t_candidate WHERE name = '" & ListView.Items(count).Text & "'")

            inputScore(txt_score.Text, candidateId, "t_" & lbl_event.Text.ToLower)
            txt_score.Text = ""
        End If

        count -= 1

        If count < 0 Then
            count += 1

            ListView.SelectedItems.Clear()
            ListView.Items(count).Selected = True
            ListView.Select()
        Else
            ListView.SelectedItems.Clear()
            ListView.Items(count).Selected = True
            ListView.Select()
        End If



        pb_main.BackgroundImage = Image.FromFile(Application.StartupPath & "\Images\" & ListView.SelectedItems(0).Text & ".jpg")

        Dim score As Double = Functions.getScore(Functions.getId("SELECT id FROM t_candidate WHERE name = '" & ListView.SelectedItems(0).Text & "'"), "t_" & lbl_event.Text.ToLower)

        ' get score if available
        If Not score = 0.0 Then
            txt_score.Text = score
        End If
    End Sub

    Private Sub CandidateList1_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        Main.Show()
        Me.Hide()
    End Sub

    Private Sub inputScore(ByVal score As String, ByVal candidateId As Integer, ByVal table As String)
        Dim sql As String

        If Functions.isExist("SELECT * FROM " & table & " WHERE candidate_id = '" & candidateId & "' AND judge_id = '" & Main.lbl_judge_id.Text & "'") = True Then
            sql = "UPDATE " & table & " SET score = '" & score & "' WHERE candidate_id = '" & candidateId & "' AND judge_id = '" & Main.lbl_judge_id.Text & "'"
        Else
            sql = "INSERT INTO " & table & "(judge_id, event_id, candidate_id, score) VALUES('" & Main.lbl_judge_id.Text & "', '" & Main.lbl_event_id.Text & "', '" & candidateId & "', '" & score & "')"
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

    Private Sub txt_score_KeyUp(sender As Object, e As KeyEventArgs) Handles txt_score.KeyUp
        If Not IsNumeric(txt_score.Text) Or Val(txt_score.Text) > 10 Then
            MsgBox("Error")
            txt_score.Text = ""
        End If
    End Sub
End Class