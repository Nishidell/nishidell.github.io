Public Class Dashboard
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles btn_create.Click
        Try
            create("INSERT INTO userinfo (username,pwd,firstname,lastname,address) values ('" & txt_username2.Text & "','" & txt_password2.Text & "','" & txt_firstname2.Text & "','" & txt_lastname2.Text & "','" & txt_address2.Text & "')")
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub btn_refresh_Click(sender As Object, e As EventArgs) Handles btn_refresh.Click
        Try
            reload("SELECT * FROM userinfo", dtg)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub btn_update_Click(sender As Object, e As EventArgs) Handles btn_update.Click
        Try
            updates("UPDATE userinfo set id = '" & txt_id2.Text & "',username = '" & txt_username2.Text & "',pwd = '" & txt_password2.Text & "',firstname = '" & txt_firstname2.Text & "',lastname = '" & txt_lastname2.Text & "',address = '" & txt_address2.Text & "' WHERE id = '" & txt_id2.Text & "'")
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub dtg_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dtg.CellContentClick
        txt_id2.Text = dtg.CurrentRow.Cells(0).Value
        txt_username2.Text = dtg.CurrentRow.Cells(1).Value
        txt_password2.Text = dtg.CurrentRow.Cells(2).Value
        txt_firstname2.Text = dtg.CurrentRow.Cells(3).Value
        txt_lastname2.Text = dtg.CurrentRow.Cells(4).Value
        txt_address2.Text = dtg.CurrentRow.Cells(5).Value
    End Sub

    Private Sub btn_delete_Click(sender As Object, e As EventArgs) Handles btn_delete.Click
        Try
            delete("DELETE FROM userinfo WHERE id = '" & txt_id2.Text & "'")
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        txt_id2.Text = ""
        txt_username2.Text = ""
        txt_password2.Text = ""
        txt_firstname2.Text = ""
        txt_lastname2.Text = ""
        txt_address2.Text = ""
    End Sub

    Private Sub Button3_Click_1(sender As Object, e As EventArgs) Handles btn_logout.Click
        LoginForm.Show()
        Me.Hide()
    End Sub

    Private Sub Dashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class