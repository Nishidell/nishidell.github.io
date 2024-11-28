<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        pb_pizza2 = New PictureBox()
        Label1 = New Label()
        lb_price2 = New Label()
        lb_sizePrice = New Label()
        Label4 = New Label()
        lb_qty = New Label()
        Label6 = New Label()
        Label2 = New Label()
        lb_totalPayment = New Label()
        Button1 = New Button()
        Label3 = New Label()
        btn_return = New Button()
        Panel1 = New Panel()
        CType(pb_pizza2, ComponentModel.ISupportInitialize).BeginInit()
        Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' pb_pizza2
        ' 
        pb_pizza2.BackgroundImageLayout = ImageLayout.Stretch
        pb_pizza2.Location = New Point(74, 24)
        pb_pizza2.Name = "pb_pizza2"
        pb_pizza2.Size = New Size(189, 151)
        pb_pizza2.TabIndex = 0
        pb_pizza2.TabStop = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Ink Free", 11.9999981F, FontStyle.Bold)
        Label1.Location = New Point(20, 17)
        Label1.Name = "Label1"
        Label1.Size = New Size(97, 20)
        Label1.TabIndex = 1
        Label1.Text = "Pizza Price:"
        ' 
        ' lb_price2
        ' 
        lb_price2.AutoSize = True
        lb_price2.Font = New Font("Ink Free", 11.9999981F, FontStyle.Bold)
        lb_price2.Location = New Point(123, 17)
        lb_price2.Name = "lb_price2"
        lb_price2.Size = New Size(27, 20)
        lb_price2.TabIndex = 2
        lb_price2.Text = "---"
        ' 
        ' lb_sizePrice
        ' 
        lb_sizePrice.AutoSize = True
        lb_sizePrice.Font = New Font("Ink Free", 11.9999981F, FontStyle.Bold)
        lb_sizePrice.Location = New Point(121, 48)
        lb_sizePrice.Name = "lb_sizePrice"
        lb_sizePrice.Size = New Size(27, 20)
        lb_sizePrice.TabIndex = 4
        lb_sizePrice.Text = "---"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Ink Free", 11.9999981F, FontStyle.Bold)
        Label4.Location = New Point(20, 48)
        Label4.Name = "Label4"
        Label4.Size = New Size(87, 20)
        Label4.TabIndex = 3
        Label4.Text = "Size Price:"
        ' 
        ' lb_qty
        ' 
        lb_qty.AutoSize = True
        lb_qty.Font = New Font("Ink Free", 11.9999981F, FontStyle.Bold)
        lb_qty.Location = New Point(121, 83)
        lb_qty.Name = "lb_qty"
        lb_qty.Size = New Size(27, 20)
        lb_qty.TabIndex = 6
        lb_qty.Text = "---"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Ink Free", 11.9999981F, FontStyle.Bold)
        Label6.Location = New Point(20, 83)
        Label6.Name = "Label6"
        Label6.Size = New Size(81, 20)
        Label6.TabIndex = 5
        Label6.Text = "Quantity:"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Ink Free", 11.9999981F, FontStyle.Bold)
        Label2.Location = New Point(113, 326)
        Label2.Name = "Label2"
        Label2.Size = New Size(122, 20)
        Label2.TabIndex = 7
        Label2.Text = "Total Payment"
        ' 
        ' lb_totalPayment
        ' 
        lb_totalPayment.AutoSize = True
        lb_totalPayment.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lb_totalPayment.ForeColor = Color.Red
        lb_totalPayment.Location = New Point(153, 346)
        lb_totalPayment.Name = "lb_totalPayment"
        lb_totalPayment.Size = New Size(28, 21)
        lb_totalPayment.TabIndex = 8
        lb_totalPayment.Text = "---"
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.BlanchedAlmond
        Button1.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button1.Location = New Point(112, 384)
        Button1.Name = "Button1"
        Button1.Size = New Size(114, 37)
        Button1.TabIndex = 9
        Button1.Text = "PAY NOW"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Ink Free", 11.9999981F, FontStyle.Bold)
        Label3.Location = New Point(112, 178)
        Label3.Name = "Label3"
        Label3.Size = New Size(120, 20)
        Label3.TabIndex = 10
        Label3.Text = "Cost Summary"
        ' 
        ' btn_return
        ' 
        btn_return.BackColor = Color.BlanchedAlmond
        btn_return.Font = New Font("Ink Free", 8.249999F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btn_return.Location = New Point(-5, -3)
        btn_return.Name = "btn_return"
        btn_return.Size = New Size(64, 30)
        btn_return.TabIndex = 11
        btn_return.Text = "Go Back"
        btn_return.UseVisualStyleBackColor = False
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.BlanchedAlmond
        Panel1.Controls.Add(lb_qty)
        Panel1.Controls.Add(Label6)
        Panel1.Controls.Add(lb_sizePrice)
        Panel1.Controls.Add(Label4)
        Panel1.Controls.Add(lb_price2)
        Panel1.Controls.Add(Label1)
        Panel1.Location = New Point(74, 200)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(185, 123)
        Panel1.TabIndex = 12
        ' 
        ' Form2
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.Linen
        ClientSize = New Size(324, 430)
        Controls.Add(Panel1)
        Controls.Add(btn_return)
        Controls.Add(Label3)
        Controls.Add(Button1)
        Controls.Add(lb_totalPayment)
        Controls.Add(Label2)
        Controls.Add(pb_pizza2)
        Name = "Form2"
        Text = "Form2"
        CType(pb_pizza2, ComponentModel.ISupportInitialize).EndInit()
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents pb_pizza2 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents lb_price2 As Label
    Friend WithEvents lb_sizePrice As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents lb_qty As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents lb_totalPayment As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents btn_return As Button
    Friend WithEvents Panel1 As Panel
End Class
