Imports MySql.Data.MySqlClient

Module Functions

    Public com As New MySqlCommand
    Public reader As MySqlDataReader

    Public Function isEnabled(ByVal eventName As String)
        Dim enabled As Boolean = False
        Dim sql As String = "SELECT enable FROM t_event WHERE name = '" & eventName & "'"

        Try
            Connect.constring.Open()
            Functions.com.Connection = Connect.constring
            Functions.com.CommandText = sql
            Functions.reader = Functions.com.ExecuteReader

            While reader.Read
                If reader.HasRows Then
                    enabled = reader(0)
                End If
            End While
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            Connect.constring.Close()
        End Try

        Return enabled
    End Function

    Public Function isExist(ByVal sql As String) As Boolean
        Dim exist As Boolean = False

        Try
            Connect.constring.Open()
            com.Connection = Connect.constring
            com.CommandText = sql
            reader = com.ExecuteReader

            While reader.Read
                If reader.HasRows Then
                    exist = True
                    Exit While
                End If
            End While
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            Connect.constring.Close()
        End Try

        Return exist
    End Function

    Public Function getId(ByVal sql As String) As Integer
        Dim id As Integer

        Try
            Connect.constring.Open()
            com.Connection = Connect.constring
            com.CommandText = sql
            reader = com.ExecuteReader

            While reader.Read
                If reader.HasRows Then
                    id = reader(0)
                End If
            End While
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            Connect.constring.Close()
        End Try

        Return id
    End Function

    Public Function getScore(ByVal candidateId As Integer, ByVal table As String) As Double
        Dim score As Double = 0.0
        Dim sql As String = "SELECT score FROM " & table & " WHERE candidate_id = '" & candidateId & "' AND judge_id = '" & Main.lbl_judge_id.Text & "'"

        Try
            Connect.constring.Open()
            Functions.com.Connection = Connect.constring
            Functions.com.CommandText = sql
            Functions.reader = Functions.com.ExecuteReader

            While reader.Read
                If reader.HasRows Then
                    score = Format(reader(0), "0.00")
                End If
            End While
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            Connect.constring.Close()
        End Try

        Return score
    End Function

    Public Function isEliminationEnabled() As Boolean
        Dim isEnabled As Boolean = False
        Dim sql As String = "SELECT enable FROM t_event WHERE name = 'Elimination'"

        Try
            Connect.constring.Open()
            com.Connection = Connect.constring
            com.CommandText = sql
            reader = com.ExecuteReader

            While reader.Read
                If reader.HasRows Then
                    isEnabled = reader(0)
                End If
            End While
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            Connect.constring.Close()
        End Try

        Return isEnabled
    End Function

End Module
