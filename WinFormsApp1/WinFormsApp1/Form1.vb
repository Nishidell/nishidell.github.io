Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MyBase.CenterToScreen()
    End Sub
    Dim firstNum As Double
    Dim operation As String
    Private Sub btn1_Click(sender As Object, e As EventArgs) Handles btn1.Click
        txtDisplay.Text &= "1"
    End Sub

    Private Sub btn2_Click(sender As Object, e As EventArgs) Handles btn2.Click
        txtDisplay.Text &= "2"
    End Sub

    Private Sub btn3_Click(sender As Object, e As EventArgs) Handles btn3.Click
        txtDisplay.Text &= "3"
    End Sub

    Private Sub btn4_Click(sender As Object, e As EventArgs) Handles btn4.Click
        txtDisplay.Text &= "4"
    End Sub

    Private Sub btn5_Click(sender As Object, e As EventArgs) Handles btn5.Click
        txtDisplay.Text &= "5"
    End Sub

    Private Sub btn6_Click(sender As Object, e As EventArgs) Handles btn6.Click
        txtDisplay.Text &= "6"
    End Sub

    Private Sub btn7_Click(sender As Object, e As EventArgs) Handles btn7.Click
        txtDisplay.Text &= "7"
    End Sub

    Private Sub btn8_Click(sender As Object, e As EventArgs) Handles btn8.Click
        txtDisplay.Text &= "8"
    End Sub

    Private Sub btn9_Click(sender As Object, e As EventArgs) Handles btn9.Click
        txtDisplay.Text &= "9"
    End Sub

    Private Sub btn0_Click(sender As Object, e As EventArgs) Handles btn0.Click
        txtDisplay.Text &= "0"
    End Sub

    Private Sub btndot_Click(sender As Object, e As EventArgs) Handles btndot.Click
        txtDisplay.Text &= "."
    End Sub
    Private Sub btnadd_Click(sender As Object, e As EventArgs) Handles btnadd.Click
        firstNum = CDbl(txtDisplay.Text)
        operation = "+"
        txtDisplay.Text = ""
    End Sub

    Private Sub btnresult_Click(sender As Object, e As EventArgs) Handles btnresult.Click
        Dim secondNum As Double = CDbl(txtDisplay.Text)
        Dim result As Double

        If operation = "+" Then
            result = firstNum + secondNum
        ElseIf operation = "-" Then
            result = firstNum - secondNum
        ElseIf operation = "*" Then
            result = firstNum * secondNum
        ElseIf operation = "/" Then
            result = firstNum / secondNum
        End If


        txtDisplay.Text = result.ToString()
    End Sub

    Private Sub btnsubtract_Click(sender As Object, e As EventArgs) Handles btnsubtract.Click
        firstNum = CDbl(txtDisplay.Text)
        operation = "-"
        txtDisplay.Text = ""
    End Sub

    Private Sub txtDisplay_TextChanged(sender As Object, e As EventArgs) Handles txtDisplay.TextChanged

    End Sub

    Private Sub btnmultiply_Click(sender As Object, e As EventArgs) Handles btnmultiply.Click
        firstNum = CDbl(txtDisplay.Text)
        operation = "*"
        txtDisplay.Text = ""
    End Sub

    Private Sub btndivide_Click(sender As Object, e As EventArgs) Handles btndivide.Click
        firstNum = CDbl(txtDisplay.Text)
        operation = "/"
        txtDisplay.Text = ""
    End Sub

    Private Sub btnclear_Click(sender As Object, e As EventArgs) Handles btnclear.Click
        txtDisplay.Text = ""
    End Sub
End Class
