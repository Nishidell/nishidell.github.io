Imports System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel
Imports MySql.Data.MySqlClient

Public Class LoginForm
    Private Sub btn_login_Click(sender As Object, e As EventArgs) Handles btn_login.Click
        strcon.Open()
        Try
            Using cmd
                cmd.Connection = strcon
                cmd.CommandText = "SELECT previlege FROM userinfo WHERE username = @username AND pwd = @password"


                cmd.Parameters.Clear()


                cmd.Parameters.AddWithValue("@username", txt_username.Text)
                cmd.Parameters.AddWithValue("@password", txt_password.Text)


                Dim userRole As Object = cmd.ExecuteScalar()

                If userRole IsNot Nothing Then
                    MessageBox.Show("Login Successfully")
                    Me.Hide()

                    If userRole.ToString() = "Admin" Then
                        Dashboard.Show()
                    Else

                        Form1.Show()
                    End If
                Else
                    MessageBox.Show("Invalid username or password")
                End If
            End Using
        Catch ex As Exception
            MessageBox.Show("Error Occurred: " & ex.Message)
        Finally
            strcon.Close()
        End Try
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles btn_directSignUp.LinkClicked
        SignUpForm.Show()
        Me.Hide()
    End Sub

    Private Sub LoginForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class