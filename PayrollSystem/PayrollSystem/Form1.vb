Public Class Form1

    Dim rate, hours, days, tax, salaryGross, taxDeduction, salaryNet As Integer

    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        rate = RatePerHour.Text
        hours = HoursPerDay.Text
        days = DaysWork.Text
        tax = TotalTax.Text

        salaryGross = (rate * hours) * days
        GrossSalary.Text = salaryGross

        taxDeduction = salaryGross * (tax / 100)
        TotalDeduction.Text = taxDeduction

        salaryNet = salaryGross - taxDeduction
        NetSalary.Text = salaryNet

    End Sub
End Class
