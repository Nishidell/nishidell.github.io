Public Class SignUpForm
    Private Sub btn_signup_Click(sender As Object, e As EventArgs) Handles btn_signup.Click
        For Each item As Control In Me.Controls
            If (TypeOf item Is TextBox) Then
                If item.Text = "" Then
                    MessageBox.Show("All fields are required!")
                    Return
                End If
            End If

        Next

        If txt_pwdchecker.Text = txt_password1.Text Then
            Try
                create("INSERT INTO userinfo (username,pwd,firstname,lastname,address) values ('" & txt_username1.Text & "','" & txt_password1.Text & "','" & txt_firstname1.Text & "','" & txt_lastname1.Text & "','" & txt_address1.Text & "')")
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        Else
            MessageBox.Show("Password do not Match")
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        LoginForm.Show()
    End Sub

End Class