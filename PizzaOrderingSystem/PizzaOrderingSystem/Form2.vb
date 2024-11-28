Public Class Form2

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim totalpayment As Integer
        Dim payment As Integer
        Dim change As Integer
        payment = InputBox("Please Enter your Amount of Cash for Payment", "Payment Form")

        totalpayment = lb_totalPayment.Text

        change = totalpayment - payment

        MsgBox("Your change is: " & Math.Abs(change))


    End Sub

    Private Sub btn_return_Click(sender As Object, e As EventArgs) Handles btn_return.Click
        Me.Hide()
        Form1.Show()
    End Sub

End Class