Public Class Main

    Private Sub Main_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Dim sql As String = "UPDATE t_judge SET status = 0 WHERE username = '" & lbl_judge_username.Text & "'"

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

        Login.Show()
    End Sub

    Private Sub pb_gown_MouseHover(sender As Object, e As EventArgs) Handles pb_gown.MouseHover
        pb_gown.BackgroundImage = CType(My.Resources.ResourceManager.GetObject("gown_hover"), Image)
    End Sub

    Private Sub pb_gown_MouseLeave(sender As Object, e As EventArgs) Handles pb_gown.MouseLeave
        pb_gown.BackgroundImage = CType(My.Resources.ResourceManager.GetObject("gown"), Image)
    End Sub

    Private Sub pb_interview_MouseHover(sender As Object, e As EventArgs) Handles pb_interview.MouseHover
        pb_interview.BackgroundImage = CType(My.Resources.ResourceManager.GetObject("interview_hover"), Image)
    End Sub

    Private Sub pb_interview_MouseLeave(sender As Object, e As EventArgs) Handles pb_interview.MouseLeave
        pb_interview.BackgroundImage = CType(My.Resources.ResourceManager.GetObject("interview"), Image)
    End Sub

    Private Sub pb_swimwear_MouseHover(sender As Object, e As EventArgs) Handles pb_swimwear.MouseHover
        pb_swimwear.BackgroundImage = CType(My.Resources.ResourceManager.GetObject("swimwear_hover"), Image)
    End Sub

    Private Sub pb_swimwear_MouseLeave(sender As Object, e As EventArgs) Handles pb_swimwear.MouseLeave
        pb_swimwear.BackgroundImage = CType(My.Resources.ResourceManager.GetObject("swimwear"), Image)
    End Sub

    Private Sub pb_talent_MouseHover(sender As Object, e As EventArgs) Handles pb_talent.MouseHover
        pb_talent.BackgroundImage = CType(My.Resources.ResourceManager.GetObject("talent_hover"), Image)
    End Sub

    Private Sub pb_talent_MouseLeave(sender As Object, e As EventArgs) Handles pb_talent.MouseLeave
        pb_talent.BackgroundImage = CType(My.Resources.ResourceManager.GetObject("talent"), Image)
    End Sub

    Private Sub pb_gown_Click(sender As Object, e As EventArgs) Handles pb_gown.Click
        CandidateList1.Show()
    End Sub
End Class