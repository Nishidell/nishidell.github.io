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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        txtDisplay = New TextBox()
        btn1 = New Button()
        btn2 = New Button()
        btn3 = New Button()
        btn4 = New Button()
        btn5 = New Button()
        btn6 = New Button()
        btn7 = New Button()
        btn8 = New Button()
        btn9 = New Button()
        btn0 = New Button()
        btnadd = New Button()
        btnsubtract = New Button()
        btnmultiply = New Button()
        btndivide = New Button()
        btnresult = New Button()
        btndot = New Button()
        btn00 = New Button()
        btnclear = New Button()
        SuspendLayout()
        ' 
        ' txtDisplay
        ' 
        txtDisplay.BackColor = SystemColors.Info
        txtDisplay.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        txtDisplay.Location = New Point(32, 12)
        txtDisplay.Multiline = True
        txtDisplay.Name = "txtDisplay"
        txtDisplay.Size = New Size(359, 63)
        txtDisplay.TabIndex = 0
        ' 
        ' btn1
        ' 
        btn1.BackColor = SystemColors.ButtonFace
        btn1.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        btn1.Location = New Point(31, 152)
        btn1.Name = "btn1"
        btn1.Size = New Size(68, 41)
        btn1.TabIndex = 1
        btn1.Text = "1"
        btn1.UseVisualStyleBackColor = False
        ' 
        ' btn2
        ' 
        btn2.BackColor = SystemColors.ButtonFace
        btn2.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        btn2.Location = New Point(132, 152)
        btn2.Name = "btn2"
        btn2.Size = New Size(75, 41)
        btn2.TabIndex = 2
        btn2.Text = "2"
        btn2.UseVisualStyleBackColor = False
        ' 
        ' btn3
        ' 
        btn3.BackColor = SystemColors.ButtonFace
        btn3.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        btn3.Location = New Point(233, 152)
        btn3.Name = "btn3"
        btn3.Size = New Size(71, 41)
        btn3.TabIndex = 3
        btn3.Text = "3"
        btn3.UseVisualStyleBackColor = False
        ' 
        ' btn4
        ' 
        btn4.BackColor = SystemColors.ButtonFace
        btn4.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        btn4.Location = New Point(30, 212)
        btn4.Name = "btn4"
        btn4.Size = New Size(69, 41)
        btn4.TabIndex = 4
        btn4.Text = "4"
        btn4.UseVisualStyleBackColor = False
        ' 
        ' btn5
        ' 
        btn5.BackColor = SystemColors.ButtonFace
        btn5.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        btn5.Location = New Point(132, 212)
        btn5.Name = "btn5"
        btn5.Size = New Size(75, 41)
        btn5.TabIndex = 5
        btn5.Text = "5"
        btn5.UseVisualStyleBackColor = False
        ' 
        ' btn6
        ' 
        btn6.BackColor = SystemColors.ButtonFace
        btn6.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        btn6.Location = New Point(233, 212)
        btn6.Name = "btn6"
        btn6.Size = New Size(71, 41)
        btn6.TabIndex = 6
        btn6.Text = "6"
        btn6.UseVisualStyleBackColor = False
        ' 
        ' btn7
        ' 
        btn7.BackColor = SystemColors.ButtonFace
        btn7.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        btn7.Location = New Point(30, 272)
        btn7.Name = "btn7"
        btn7.Size = New Size(69, 41)
        btn7.TabIndex = 7
        btn7.Text = "7"
        btn7.UseVisualStyleBackColor = False
        ' 
        ' btn8
        ' 
        btn8.BackColor = SystemColors.ButtonFace
        btn8.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        btn8.Location = New Point(132, 272)
        btn8.Name = "btn8"
        btn8.Size = New Size(75, 41)
        btn8.TabIndex = 8
        btn8.Text = "8"
        btn8.UseVisualStyleBackColor = False
        ' 
        ' btn9
        ' 
        btn9.BackColor = SystemColors.ButtonFace
        btn9.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        btn9.Location = New Point(233, 272)
        btn9.Name = "btn9"
        btn9.Size = New Size(71, 41)
        btn9.TabIndex = 9
        btn9.Text = "9"
        btn9.UseVisualStyleBackColor = False
        ' 
        ' btn0
        ' 
        btn0.BackColor = SystemColors.ButtonFace
        btn0.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        btn0.Location = New Point(132, 335)
        btn0.Name = "btn0"
        btn0.Size = New Size(75, 40)
        btn0.TabIndex = 10
        btn0.Text = "0"
        btn0.UseVisualStyleBackColor = False
        ' 
        ' btnadd
        ' 
        btnadd.BackColor = Color.FromArgb(CByte(255), CByte(192), CByte(128))
        btnadd.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        btnadd.Location = New Point(325, 97)
        btnadd.Name = "btnadd"
        btnadd.Size = New Size(66, 41)
        btnadd.TabIndex = 13
        btnadd.Text = "+"
        btnadd.UseVisualStyleBackColor = False
        ' 
        ' btnsubtract
        ' 
        btnsubtract.BackColor = Color.FromArgb(CByte(255), CByte(192), CByte(128))
        btnsubtract.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        btnsubtract.Location = New Point(325, 153)
        btnsubtract.Name = "btnsubtract"
        btnsubtract.Size = New Size(65, 40)
        btnsubtract.TabIndex = 14
        btnsubtract.Text = "-"
        btnsubtract.UseVisualStyleBackColor = False
        ' 
        ' btnmultiply
        ' 
        btnmultiply.BackColor = Color.FromArgb(CByte(255), CByte(192), CByte(128))
        btnmultiply.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        btnmultiply.Location = New Point(324, 212)
        btnmultiply.Name = "btnmultiply"
        btnmultiply.Size = New Size(66, 41)
        btnmultiply.TabIndex = 15
        btnmultiply.Text = "x"
        btnmultiply.UseVisualStyleBackColor = False
        ' 
        ' btndivide
        ' 
        btndivide.BackColor = Color.FromArgb(CByte(255), CByte(192), CByte(128))
        btndivide.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        btndivide.Location = New Point(324, 273)
        btndivide.Name = "btndivide"
        btndivide.Size = New Size(66, 40)
        btndivide.TabIndex = 16
        btndivide.Text = "÷"
        btndivide.UseVisualStyleBackColor = False
        ' 
        ' btnresult
        ' 
        btnresult.BackColor = SystemColors.ButtonFace
        btnresult.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        btnresult.Location = New Point(324, 336)
        btnresult.Name = "btnresult"
        btnresult.Size = New Size(67, 40)
        btnresult.TabIndex = 17
        btnresult.Text = "="
        btnresult.UseVisualStyleBackColor = False
        ' 
        ' btndot
        ' 
        btndot.BackColor = SystemColors.ButtonFace
        btndot.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        btndot.Location = New Point(231, 335)
        btndot.Name = "btndot"
        btndot.Size = New Size(73, 40)
        btndot.TabIndex = 18
        btndot.Text = "."
        btndot.UseVisualStyleBackColor = False
        ' 
        ' btn00
        ' 
        btn00.BackColor = SystemColors.ButtonFace
        btn00.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        btn00.Location = New Point(30, 335)
        btn00.Name = "btn00"
        btn00.Size = New Size(69, 41)
        btn00.TabIndex = 19
        btn00.Text = "00"
        btn00.UseVisualStyleBackColor = False
        ' 
        ' btnclear
        ' 
        btnclear.BackColor = SystemColors.ButtonFace
        btnclear.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        btnclear.Location = New Point(231, 96)
        btnclear.Name = "btnclear"
        btnclear.Size = New Size(72, 44)
        btnclear.TabIndex = 20
        btnclear.Text = "CE"
        btnclear.UseVisualStyleBackColor = False
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ControlLightLight
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(425, 459)
        Controls.Add(btnclear)
        Controls.Add(btn00)
        Controls.Add(btndot)
        Controls.Add(btnresult)
        Controls.Add(btndivide)
        Controls.Add(btnmultiply)
        Controls.Add(btnsubtract)
        Controls.Add(btnadd)
        Controls.Add(btn0)
        Controls.Add(btn9)
        Controls.Add(btn8)
        Controls.Add(btn7)
        Controls.Add(btn6)
        Controls.Add(btn5)
        Controls.Add(btn4)
        Controls.Add(btn3)
        Controls.Add(btn2)
        Controls.Add(btn1)
        Controls.Add(txtDisplay)
        Name = "Form1"
        StartPosition = FormStartPosition.CenterParent
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents txtDisplay As TextBox
    Friend WithEvents btn1 As Button
    Friend WithEvents btn2 As Button
    Friend WithEvents btn3 As Button
    Friend WithEvents btn4 As Button
    Friend WithEvents btn5 As Button
    Friend WithEvents btn6 As Button
    Friend WithEvents btn7 As Button
    Friend WithEvents btn8 As Button
    Friend WithEvents btn9 As Button
    Friend WithEvents btn0 As Button
    Friend WithEvents btnadd As Button
    Friend WithEvents btnsubtract As Button
    Friend WithEvents btnmultiply As Button
    Friend WithEvents btndivide As Button
    Friend WithEvents btnresult As Button
    Friend WithEvents btndot As Button
    Friend WithEvents btn00 As Button
    Friend WithEvents btnclear As Button

End Class
