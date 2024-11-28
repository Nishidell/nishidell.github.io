Imports System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel
Imports MySql.Data.MySqlClient

Module dbconnect
    Public Function strconnection() As MySqlConnection
        Return New MySqlConnection("server = localhost;user id = root;password = ;database = pizza_db")
    End Function
    Public strcon As MySqlConnection = strconnection()

    Public result As String
    Public cmd As New MySqlCommand
    Public da As New MySqlDataAdapter
    Public dt As New DataTable

    Public Sub create(ByVal sql As String)
        Try
            strcon.Open()
            With cmd
                .Connection = strcon
                .CommandText = sql
                result = cmd.ExecuteNonQuery
                If result = 0 Then
                    MessageBox.Show("Failed", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else
                    MessageBox.Show("DATA SAVED", "SUCCESS", MessageBoxButtons.OK, MessageBoxIcon.Information)

                End If

            End With
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            strcon.Close()
        End Try
    End Sub

    Public Sub reload(ByVal sql As String, ByVal dtg As Object)
        Try
            dt = New DataTable
            strcon.Open()
            With cmd
                .Connection = strcon
                .CommandText = sql
            End With
            da.SelectCommand = cmd
            da.Fill(dt)
            dtg.datasource = dt
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            strcon.Close()
            da.Dispose()
        End Try
    End Sub

    Public Sub updates(ByVal sql As String)
        Try
            strcon.Open()
            With cmd
                .Connection = strcon
                .CommandText = sql

                result = cmd.ExecuteNonQuery
                If result = 0 Then
                    MessageBox.Show("Failed to Update ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else
                    MessageBox.Show("Data Updated successfuly", "SUCCESS", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If

            End With
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            strcon.Close()
        End Try
    End Sub

    Public Sub delete(ByVal sql As String)
        Try
            strcon.Open()
            With cmd
                .Connection = strcon
                .CommandText = sql

                result = cmd.ExecuteNonQuery
                If result = 0 Then
                    MessageBox.Show("Failed to Delete ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else
                    MessageBox.Show("Data Deleted Successfuly", "SUCCESS", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If

            End With
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            strcon.Close()
        End Try
    End Sub

    'Public Sub login(ByVal sql As String)
    '    Try
    '        strcon.Open()
    '        With cmd
    '            .Connection = strcon
    '            .CommandText = sql

    '            result = cmd.ExecuteScalar

    '            If result = 0 Then
    '                MessageBox.Show("Failed to Login ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information)
    '            Else
    '                MessageBox.Show("Login Successfuly", "SUCCESS", MessageBoxButtons.OK, MessageBoxIcon.Information)
    '            End If

    '        End With
    '    Catch ex As Exception
    '        MessageBox.Show(ex.Message)
    '    Finally
    '        strcon.Close()
    '    End Try
    'End Sub
End Module
