Imports System.IO

Public Class CandidateList1

    Private Sub CandidateList1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim counter As Integer = 0
        Dim item As New ListViewItem

        For Each path As String In Directory.GetFiles(Application.StartupPath & "\Images\")
            ImageList.Images.Add(Image.FromFile(path))
            item.ImageIndex = counter
            item = ListView.Items.Add("asdf", counter)
            counter += 1
        Next

    End Sub
End Class