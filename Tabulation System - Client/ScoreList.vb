Public Class ScoreList

    Private Sub ScoreList_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DataGridView.Font = lbl_font.Font
    End Sub

    Public Sub populateDGV(ByVal sql As String)
        Dim row As String()
        Dim rowCnt As Integer = 0
        DataGridView.Rows.Clear()

        Try
            Connect.constring.Open()
            Functions.com.Connection = Connect.constring
            Functions.com.CommandText = sql
            Functions.reader = Functions.com.ExecuteReader

            While reader.Read
                If reader.HasRows Then
                    row = New String() {reader(0), Nothing, reader(2), Format(reader(3), "0.00")}

                    DataGridView.Rows.Add(row)
                    DataGridView.Rows(rowCnt).Cells(1).Value = Image.FromFile(Application.StartupPath & "\Images\" & reader(1))

                    rowCnt += 1
                End If
            End While
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            Connect.constring.Close()
        End Try
    End Sub
End Class