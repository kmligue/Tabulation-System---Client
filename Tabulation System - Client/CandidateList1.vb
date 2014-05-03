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

    End Sub

    Private Sub ListView_Click(sender As Object, e As EventArgs) Handles ListView.Click
        pb_main.BackgroundImage = Image.FromFile(Application.StartupPath & "\Images\" & ListView.SelectedItems(0).Text & ".jpg")
    End Sub

    Private Sub btn_next_Click(sender As Object, e As EventArgs) Handles btn_next.Click
        count += 1

        If count >= ListView.Items.Count Then
            count -= 1

            ListView.Items(count - 1).Selected = False
            ListView.Items(count).Selected = True
            ListView.Select()
            Exit Sub
        End If

        ListView.Items(count - 1).Selected = False
        ListView.Items(count).Selected = True
        ListView.Select()

        pb_main.BackgroundImage = Image.FromFile(Application.StartupPath & "\Images\" & ListView.SelectedItems(0).Text & ".jpg")
    End Sub

    Private Sub btn_prev_Click(sender As Object, e As EventArgs) Handles btn_prev.Click
        count -= 1

        If count < 0 Then
            count += 1

            ListView.Items(count + 1).Selected = False
            ListView.Items(count).Selected = True
            ListView.Select()
            Exit Sub
        End If

        ListView.Items(count + 1).Selected = False
        ListView.Items(count).Selected = True
        ListView.Select()

        pb_main.BackgroundImage = Image.FromFile(Application.StartupPath & "\Images\" & ListView.SelectedItems(0).Text & ".jpg")
    End Sub
End Class