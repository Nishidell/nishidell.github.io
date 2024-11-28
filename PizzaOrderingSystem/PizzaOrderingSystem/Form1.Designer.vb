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
        pb_pizza1 = New PictureBox()
        rb_pizza1 = New RadioButton()
        rb_pizza2 = New RadioButton()
        rb_pizza3 = New RadioButton()
        rb_pizza4 = New RadioButton()
        Panel1 = New Panel()
        rb_size1 = New RadioButton()
        rb_size2 = New RadioButton()
        rb_size3 = New RadioButton()
        Label1 = New Label()
        numeric_qty = New NumericUpDown()
        Label2 = New Label()
        btn_placeOrder = New Button()
        Panel2 = New Panel()
        Label3 = New Label()
        lb_price1 = New Label()
        Label4 = New Label()
        CType(pb_pizza1, ComponentModel.ISupportInitialize).BeginInit()
        Panel1.SuspendLayout()
        CType(numeric_qty, ComponentModel.ISupportInitialize).BeginInit()
        Panel2.SuspendLayout()
        SuspendLayout()
        ' 
        ' pb_pizza1
        ' 
        pb_pizza1.BackgroundImage = My.Resources.Resources.question
        pb_pizza1.BackgroundImageLayout = ImageLayout.Stretch
        pb_pizza1.Location = New Point(335, 52)
        pb_pizza1.Name = "pb_pizza1"
        pb_pizza1.Size = New Size(238, 194)
        pb_pizza1.TabIndex = 0
        pb_pizza1.TabStop = False
        ' 
        ' rb_pizza1
        ' 
        rb_pizza1.AutoSize = True
        rb_pizza1.Font = New Font("Ink Free", 11.9999981F, FontStyle.Bold)
        rb_pizza1.Location = New Point(46, 21)
        rb_pizza1.Name = "rb_pizza1"
        rb_pizza1.Size = New Size(152, 24)
        rb_pizza1.TabIndex = 1
        rb_pizza1.Text = "Ham and Cheeze"
        rb_pizza1.UseVisualStyleBackColor = True
        ' 
        ' rb_pizza2
        ' 
        rb_pizza2.AutoSize = True
        rb_pizza2.Font = New Font("Ink Free", 11.9999981F, FontStyle.Bold)
        rb_pizza2.Location = New Point(46, 65)
        rb_pizza2.Name = "rb_pizza2"
        rb_pizza2.Size = New Size(146, 24)
        rb_pizza2.TabIndex = 2
        rb_pizza2.Text = "Pepperoni Pizza"
        rb_pizza2.UseVisualStyleBackColor = True
        ' 
        ' rb_pizza3
        ' 
        rb_pizza3.AutoSize = True
        rb_pizza3.Font = New Font("Ink Free", 11.9999981F, FontStyle.Bold)
        rb_pizza3.Location = New Point(46, 108)
        rb_pizza3.Name = "rb_pizza3"
        rb_pizza3.Size = New Size(141, 24)
        rb_pizza3.TabIndex = 3
        rb_pizza3.Text = "Hawaiian Pizza"
        rb_pizza3.UseVisualStyleBackColor = True
        ' 
        ' rb_pizza4
        ' 
        rb_pizza4.AutoSize = True
        rb_pizza4.Font = New Font("Ink Free", 11.9999981F, FontStyle.Bold)
        rb_pizza4.Location = New Point(46, 153)
        rb_pizza4.Name = "rb_pizza4"
        rb_pizza4.Size = New Size(152, 24)
        rb_pizza4.TabIndex = 4
        rb_pizza4.Text = "Mushroom Pizza"
        rb_pizza4.UseVisualStyleBackColor = True
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.BlanchedAlmond
        Panel1.Controls.Add(rb_pizza4)
        Panel1.Controls.Add(rb_pizza3)
        Panel1.Controls.Add(rb_pizza2)
        Panel1.Controls.Add(rb_pizza1)
        Panel1.Location = New Point(45, 52)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(241, 194)
        Panel1.TabIndex = 5
        ' 
        ' rb_size1
        ' 
        rb_size1.AutoSize = True
        rb_size1.Font = New Font("Ink Free", 11.9999981F, FontStyle.Bold)
        rb_size1.Location = New Point(104, 16)
        rb_size1.Name = "rb_size1"
        rb_size1.Size = New Size(67, 24)
        rb_size1.TabIndex = 6
        rb_size1.TabStop = True
        rb_size1.Text = "Small"
        rb_size1.UseVisualStyleBackColor = True
        ' 
        ' rb_size2
        ' 
        rb_size2.AutoSize = True
        rb_size2.Font = New Font("Ink Free", 11.9999981F, FontStyle.Bold)
        rb_size2.Location = New Point(104, 46)
        rb_size2.Name = "rb_size2"
        rb_size2.Size = New Size(84, 24)
        rb_size2.TabIndex = 7
        rb_size2.TabStop = True
        rb_size2.Text = "Medium"
        rb_size2.TextAlign = ContentAlignment.TopCenter
        rb_size2.UseVisualStyleBackColor = True
        ' 
        ' rb_size3
        ' 
        rb_size3.AutoSize = True
        rb_size3.Font = New Font("Ink Free", 11.9999981F, FontStyle.Bold)
        rb_size3.Location = New Point(104, 81)
        rb_size3.Name = "rb_size3"
        rb_size3.Size = New Size(72, 24)
        rb_size3.TabIndex = 8
        rb_size3.TabStop = True
        rb_size3.Text = "Large"
        rb_size3.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Ink Free", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(18, 46)
        Label1.Name = "Label1"
        Label1.Size = New Size(59, 30)
        Label1.TabIndex = 9
        Label1.Text = "Size"
        ' 
        ' numeric_qty
        ' 
        numeric_qty.BackColor = SystemColors.Window
        numeric_qty.BorderStyle = BorderStyle.FixedSingle
        numeric_qty.ImeMode = ImeMode.NoControl
        numeric_qty.Location = New Point(448, 284)
        numeric_qty.Name = "numeric_qty"
        numeric_qty.Size = New Size(83, 22)
        numeric_qty.TabIndex = 10
        numeric_qty.TextAlign = HorizontalAlignment.Center
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Ink Free", 11.9999981F, FontStyle.Bold)
        Label2.Location = New Point(353, 284)
        Label2.Name = "Label2"
        Label2.Size = New Size(77, 20)
        Label2.TabIndex = 11
        Label2.Text = "Quantity"
        ' 
        ' btn_placeOrder
        ' 
        btn_placeOrder.BackColor = Color.BlanchedAlmond
        btn_placeOrder.Font = New Font("Ink Free", 11.9999981F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btn_placeOrder.Location = New Point(370, 333)
        btn_placeOrder.Name = "btn_placeOrder"
        btn_placeOrder.Size = New Size(161, 50)
        btn_placeOrder.TabIndex = 12
        btn_placeOrder.Text = "Place Order"
        btn_placeOrder.UseVisualStyleBackColor = False
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.BlanchedAlmond
        Panel2.Controls.Add(Label1)
        Panel2.Controls.Add(rb_size3)
        Panel2.Controls.Add(rb_size2)
        Panel2.Controls.Add(rb_size1)
        Panel2.Location = New Point(50, 268)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(235, 119)
        Panel2.TabIndex = 13
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Ink Free", 11.9999981F, FontStyle.Bold)
        Label3.Location = New Point(373, 258)
        Label3.Name = "Label3"
        Label3.Size = New Size(50, 20)
        Label3.TabIndex = 14
        Label3.Text = "Price:"
        ' 
        ' lb_price1
        ' 
        lb_price1.AutoSize = True
        lb_price1.Font = New Font("Ink Free", 11.9999981F, FontStyle.Bold)
        lb_price1.Location = New Point(437, 258)
        lb_price1.Name = "lb_price1"
        lb_price1.Size = New Size(27, 20)
        lb_price1.TabIndex = 15
        lb_price1.Text = "---"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Ink Free", 21.7499962F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label4.Location = New Point(135, 9)
        Label4.Name = "Label4"
        Label4.Size = New Size(316, 36)
        Label4.TabIndex = 16
        Label4.Text = "Pizza Ordering System"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.Linen
        ClientSize = New Size(603, 399)
        Controls.Add(Label4)
        Controls.Add(lb_price1)
        Controls.Add(Label3)
        Controls.Add(Panel2)
        Controls.Add(btn_placeOrder)
        Controls.Add(Label2)
        Controls.Add(numeric_qty)
        Controls.Add(Panel1)
        Controls.Add(pb_pizza1)
        Font = New Font("Ink Free", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Name = "Form1"
        Text = "Form1"
        CType(pb_pizza1, ComponentModel.ISupportInitialize).EndInit()
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        CType(numeric_qty, ComponentModel.ISupportInitialize).EndInit()
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents pb_pizza1 As PictureBox
    Friend WithEvents rb_pizza1 As RadioButton
    Friend WithEvents rb_pizza2 As RadioButton
    Friend WithEvents rb_pizza3 As RadioButton
    Friend WithEvents rb_pizza4 As RadioButton
    Friend WithEvents Panel1 As Panel
    Friend WithEvents rb_size1 As RadioButton
    Friend WithEvents rb_size2 As RadioButton
    Friend WithEvents rb_size3 As RadioButton
    Friend WithEvents Label1 As Label
    Friend WithEvents numeric_qty As NumericUpDown
    Friend WithEvents Label2 As Label
    Friend WithEvents btn_placeOrder As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents lb_price1 As Label
    Friend WithEvents Label4 As Label

End Class
