Public Class Form1

    Dim obj2 As New Form2
    Dim price As Integer
    Dim sizePrice As Integer
    Dim quantity As Integer
    Dim totalPayment As Integer
    Private Sub rb_pizza1_CheckedChanged(sender As Object, e As EventArgs) Handles rb_pizza1.CheckedChanged
        pb_pizza1.BackgroundImage = My.Resources.ham_and_cheee
        price = 125
        lb_price1.Text = price
        obj2.lb_price2.Text = price
    End Sub

    Private Sub rb_pizza2_CheckedChanged(sender As Object, e As EventArgs) Handles rb_pizza2.CheckedChanged
        pb_pizza1.BackgroundImage = My.Resources.pepperoni
        price = 150
        lb_price1.Text = price
        obj2.lb_price2.Text = price
    End Sub

    Private Sub rb_pizza3_CheckedChanged(sender As Object, e As EventArgs) Handles rb_pizza3.CheckedChanged
        pb_pizza1.BackgroundImage = My.Resources.hawaiian
        price = 175
        lb_price1.Text = price
        obj2.lb_price2.Text = price
    End Sub

    Private Sub rb_pizza4_CheckedChanged(sender As Object, e As EventArgs) Handles rb_pizza4.CheckedChanged
        pb_pizza1.BackgroundImage = My.Resources.mushroom
        price = 200
        lb_price1.Text = price
        obj2.lb_price2.Text = price
    End Sub

    Private Sub btn_placeOrder_Click(sender As Object, e As EventArgs) Handles btn_placeOrder.Click
        Me.Hide()
        obj2.Show()

        obj2.pb_pizza2.BackgroundImage = pb_pizza1.BackgroundImage
        quantity = numeric_qty.Value
        obj2.lb_qty.Text = quantity

        totalPayment = (price + sizePrice) * quantity
        obj2.lb_totalPayment.Text = totalPayment

    End Sub

    Private Sub rb_size1_CheckedChanged(sender As Object, e As EventArgs) Handles rb_size1.CheckedChanged
        sizePrice = 0
        obj2.lb_sizePrice.Text = sizePrice
    End Sub

    Private Sub rb_size2_CheckedChanged(sender As Object, e As EventArgs) Handles rb_size2.CheckedChanged
        sizePrice = 50
        obj2.lb_sizePrice.Text = sizePrice
    End Sub

    Private Sub rb_size3_CheckedChanged(sender As Object, e As EventArgs) Handles rb_size3.CheckedChanged
        sizePrice = 100
        obj2.lb_sizePrice.Text = sizePrice
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
