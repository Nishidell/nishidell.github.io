<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Label1 = New Label()
        EmployeeID = New TextBox()
        Label2 = New Label()
        Label3 = New Label()
        RatePerHour = New TextBox()
        Label4 = New Label()
        HoursPerDay = New TextBox()
        Label5 = New Label()
        DaysWork = New TextBox()
        Label6 = New Label()
        TotalTax = New TextBox()
        btnCalculate = New Button()
        Label7 = New Label()
        GrossSalary = New TextBox()
        Label8 = New Label()
        TotalDeduction = New TextBox()
        Label9 = New Label()
        NetSalary = New TextBox()
        Panel1 = New Panel()
        Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Georgia", 26.25F, FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.MidnightBlue
        Label1.Location = New Point(152, 9)
        Label1.Name = "Label1"
        Label1.Size = New Size(257, 41)
        Label1.TabIndex = 0
        Label1.Text = "Payroll System"
        ' 
        ' EmployeeID
        ' 
        EmployeeID.Location = New Point(125, 25)
        EmployeeID.MaxLength = 4
        EmployeeID.Multiline = True
        EmployeeID.Name = "EmployeeID"
        EmployeeID.Size = New Size(106, 27)
        EmployeeID.TabIndex = 1
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(39, 28)
        Label2.Name = "Label2"
        Label2.Size = New Size(73, 15)
        Label2.TabIndex = 5
        Label2.Text = "Employee ID"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(39, 74)
        Label3.Name = "Label3"
        Label3.Size = New Size(80, 15)
        Label3.TabIndex = 7
        Label3.Text = "Rate Per Hour"
        ' 
        ' RatePerHour
        ' 
        RatePerHour.Location = New Point(125, 71)
        RatePerHour.Multiline = True
        RatePerHour.Name = "RatePerHour"
        RatePerHour.Size = New Size(106, 27)
        RatePerHour.TabIndex = 6
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(39, 118)
        Label4.Name = "Label4"
        Label4.Size = New Size(82, 15)
        Label4.TabIndex = 9
        Label4.Text = "Hours Per Day"
        ' 
        ' HoursPerDay
        ' 
        HoursPerDay.Location = New Point(125, 115)
        HoursPerDay.Multiline = True
        HoursPerDay.Name = "HoursPerDay"
        HoursPerDay.Size = New Size(106, 27)
        HoursPerDay.TabIndex = 8
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(39, 170)
        Label5.Name = "Label5"
        Label5.Size = New Size(85, 15)
        Label5.TabIndex = 11
        Label5.Text = "No. Days Work"
        ' 
        ' DaysWork
        ' 
        DaysWork.Location = New Point(125, 167)
        DaysWork.Multiline = True
        DaysWork.Name = "DaysWork"
        DaysWork.Size = New Size(106, 27)
        DaysWork.TabIndex = 10
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(39, 214)
        Label6.Name = "Label6"
        Label6.Size = New Size(68, 15)
        Label6.TabIndex = 13
        Label6.Text = "Total % Tax "
        ' 
        ' TotalTax
        ' 
        TotalTax.Location = New Point(125, 211)
        TotalTax.Multiline = True
        TotalTax.Name = "TotalTax"
        TotalTax.Size = New Size(106, 27)
        TotalTax.TabIndex = 12
        ' 
        ' btnCalculate
        ' 
        btnCalculate.BackColor = Color.MidnightBlue
        btnCalculate.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnCalculate.ForeColor = SystemColors.Info
        btnCalculate.Location = New Point(213, 339)
        btnCalculate.Name = "btnCalculate"
        btnCalculate.Size = New Size(131, 40)
        btnCalculate.TabIndex = 14
        btnCalculate.Text = "Calculate"
        btnCalculate.UseVisualStyleBackColor = False
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(300, 137)
        Label7.Name = "Label7"
        Label7.Size = New Size(70, 15)
        Label7.TabIndex = 16
        Label7.Text = "Gross Salary"
        ' 
        ' GrossSalary
        ' 
        GrossSalary.Location = New Point(396, 134)
        GrossSalary.Multiline = True
        GrossSalary.Name = "GrossSalary"
        GrossSalary.Size = New Size(106, 27)
        GrossSalary.TabIndex = 15
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Location = New Point(300, 181)
        Label8.Name = "Label8"
        Label8.Size = New Size(90, 15)
        Label8.TabIndex = 18
        Label8.Text = "Total Deduction"
        ' 
        ' TotalDeduction
        ' 
        TotalDeduction.Location = New Point(396, 178)
        TotalDeduction.Multiline = True
        TotalDeduction.Name = "TotalDeduction"
        TotalDeduction.Size = New Size(106, 27)
        TotalDeduction.TabIndex = 17
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Location = New Point(300, 233)
        Label9.Name = "Label9"
        Label9.Size = New Size(60, 15)
        Label9.TabIndex = 20
        Label9.Text = "Net Salary"
        ' 
        ' NetSalary
        ' 
        NetSalary.Location = New Point(396, 230)
        NetSalary.Multiline = True
        NetSalary.Name = "NetSalary"
        NetSalary.Size = New Size(106, 27)
        NetSalary.TabIndex = 19
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = SystemColors.Info
        Panel1.Controls.Add(Label6)
        Panel1.Controls.Add(TotalTax)
        Panel1.Controls.Add(Label5)
        Panel1.Controls.Add(DaysWork)
        Panel1.Controls.Add(Label4)
        Panel1.Controls.Add(HoursPerDay)
        Panel1.Controls.Add(Label3)
        Panel1.Controls.Add(RatePerHour)
        Panel1.Controls.Add(Label2)
        Panel1.Controls.Add(EmployeeID)
        Panel1.Location = New Point(27, 62)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(267, 262)
        Panel1.TabIndex = 21
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.Linen
        ClientSize = New Size(527, 391)
        Controls.Add(Panel1)
        Controls.Add(Label9)
        Controls.Add(NetSalary)
        Controls.Add(Label8)
        Controls.Add(TotalDeduction)
        Controls.Add(Label7)
        Controls.Add(GrossSalary)
        Controls.Add(btnCalculate)
        Controls.Add(Label1)
        Name = "Form1"
        Text = "Form1"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents EmployeeID As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents RatePerHour As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents HoursPerDay As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents DaysWork As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents TotalTax As TextBox
    Friend WithEvents btnCalculate As Button
    Friend WithEvents Label7 As Label
    Friend WithEvents GrossSalary As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents TotalDeduction As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents NetSalary As TextBox
    Friend WithEvents Panel1 As Panel

End Class
