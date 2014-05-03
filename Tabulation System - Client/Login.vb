Public Class Login

    Private Sub btn_login_Click(sender As Object, e As EventArgs) Handles btn_login.Click
        Dim sql As String = "SELECT * FROM t_judge WHERE username = '" & txt_username.Text & "' AND password = '" & txt_password.Text & "'"
        Dim userFound As Boolean = False
        
        Try
            Connect.constring.Open()
            Functions.com.Connection = Connect.constring
            Functions.com.CommandText = sql
            Functions.reader = Functions.com.ExecuteReader

            While reader.Read
                If reader.HasRows Then
                    userFound = True
                End If
            End While
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            Connect.constring.Close()
        End Try

        If userFound = True Then

            If isJudgeLogin(txt_username.Text) = True Then
                MsgBox("Judge already login")
                Exit Sub
            End If

            sql = "UPDATE t_judge SET status = 1 WHERE username = '" & txt_username.Text & "'"

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

            Me.Hide()

            If Functions.isEliminationEnabled() = True Then
                CandidateList2.Show()
            Else
                Main.lbl_judge_id.Text = Functions.getId("SELECT id FROM t_judge WHERE username = '" & txt_username.Text & "'")
                Main.Show()
            End If

        Else
            MsgBox("User not found!")
        End If
    End Sub

    Private Function isJudgeLogin(ByVal username As String) As Boolean
        Dim isLogin As Boolean = False
        Dim sql As String = "SELECT status FROM t_judge WHERE username = '" & username & "'"

        Try
            Connect.constring.Open()
            Functions.com.Connection = Connect.constring
            Functions.com.CommandText = sql
            Functions.reader = Functions.com.ExecuteReader

            While reader.Read
                If reader.HasRows Then
                    If reader(0) = "1" Then
                        isLogin = True
                    End If
                End If
            End While
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            Connect.constring.Close()
        End Try

        Return isLogin
    End Function

    Private Sub Login_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Connect.constring.Close()
    End Sub
End Class
