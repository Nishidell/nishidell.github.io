<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SignUpForm
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
        Label1 = New Label()
        txt_firstname1 = New TextBox()
        txt_address1 = New TextBox()
        txt_lastname1 = New TextBox()
        txt_username1 = New TextBox()
        txt_password1 = New TextBox()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        Label6 = New Label()
        btn_signup = New Button()
        Button1 = New Button()
        Label7 = New Label()
        txt_pwdchecker = New TextBox()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("MV Boli", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(164, 21)
        Label1.Name = "Label1"
        Label1.Size = New Size(244, 31)
        Label1.TabIndex = 0
        Label1.Text = "CREATE ACCOUNT"
        ' 
        ' txt_firstname1
        ' 
        txt_firstname1.Location = New Point(313, 111)
        txt_firstname1.Multiline = True
        txt_firstname1.Name = "txt_firstname1"
        txt_firstname1.Size = New Size(174, 30)
        txt_firstname1.TabIndex = 1
        ' 
        ' txt_address1
        ' 
        txt_address1.Location = New Point(313, 238)
        txt_address1.Multiline = True
        txt_address1.Name = "txt_address1"
        txt_address1.Size = New Size(174, 30)
        txt_address1.TabIndex = 2
        ' 
        ' txt_lastname1
        ' 
        txt_lastname1.Location = New Point(313, 172)
        txt_lastname1.Multiline = True
        txt_lastname1.Name = "txt_lastname1"
        txt_lastname1.Size = New Size(174, 30)
        txt_lastname1.TabIndex = 3
        ' 
        ' txt_username1
        ' 
        txt_username1.Location = New Point(90, 111)
        txt_username1.Multiline = True
        txt_username1.Name = "txt_username1"
        txt_username1.Size = New Size(158, 30)
        txt_username1.TabIndex = 4
        ' 
        ' txt_password1
        ' 
        txt_password1.Location = New Point(90, 172)
        txt_password1.Multiline = True
        txt_password1.Name = "txt_password1"
        txt_password1.PasswordChar = "*"c
        txt_password1.Size = New Size(158, 30)
        txt_password1.TabIndex = 5
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(131, 87)
        Label2.Name = "Label2"
        Label2.Size = New Size(84, 21)
        Label2.TabIndex = 6
        Label2.Text = "Username:"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(136, 148)
        Label3.Name = "Label3"
        Label3.Size = New Size(79, 21)
        Label3.TabIndex = 7
        Label3.Text = "Password:"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label4.Location = New Point(357, 87)
        Label4.Name = "Label4"
        Label4.Size = New Size(86, 21)
        Label4.TabIndex = 8
        Label4.Text = "First Name"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label5.Location = New Point(357, 148)
        Label5.Name = "Label5"
        Label5.Size = New Size(84, 21)
        Label5.TabIndex = 9
        Label5.Text = "Last Name"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label6.Location = New Point(366, 214)
        Label6.Name = "Label6"
        Label6.Size = New Size(66, 21)
        Label6.TabIndex = 10
        Label6.Text = "Address"
        ' 
        ' btn_signup
        ' 
        btn_signup.BackColor = Color.BlanchedAlmond
        btn_signup.Font = New Font("Ink Free", 9.75F, FontStyle.Bold)
        btn_signup.Location = New Point(215, 290)
        btn_signup.Name = "btn_signup"
        btn_signup.Size = New Size(124, 41)
        btn_signup.TabIndex = 11
        btn_signup.Text = "Sign Up"
        btn_signup.UseVisualStyleBackColor = False
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.BlanchedAlmond
        Button1.Font = New Font("Ink Free", 9.75F, FontStyle.Bold)
        Button1.Location = New Point(12, 12)
        Button1.Name = "Button1"
        Button1.Size = New Size(99, 41)
        Button1.TabIndex = 12
        Button1.Text = "Return to Login"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label7.Location = New Point(102, 217)
        Label7.Name = "Label7"
        Label7.Size = New Size(137, 21)
        Label7.TabIndex = 14
        Label7.Text = "Confirm Password"
        ' 
        ' txt_pwdchecker
        ' 
        txt_pwdchecker.Location = New Point(90, 241)
        txt_pwdchecker.Multiline = True
        txt_pwdchecker.Name = "txt_pwdchecker"
        txt_pwdchecker.PasswordChar = "*"c
        txt_pwdchecker.Size = New Size(158, 30)
        txt_pwdchecker.TabIndex = 13
        ' 
        ' SignUpForm
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.Linen
        ClientSize = New Size(543, 450)
        Controls.Add(Label7)
        Controls.Add(txt_pwdchecker)
        Controls.Add(Button1)
        Controls.Add(btn_signup)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(txt_password1)
        Controls.Add(txt_username1)
        Controls.Add(txt_lastname1)
        Controls.Add(txt_address1)
        Controls.Add(txt_firstname1)
        Controls.Add(Label1)
        Name = "SignUpForm"
        Text = "Sign Up"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txt_firstname1 As TextBox
    Friend WithEvents txt_address1 As TextBox
    Friend WithEvents txt_lastname1 As TextBox
    Friend WithEvents txt_username1 As TextBox
    Friend WithEvents txt_password1 As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents btn_signup As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Label7 As Label
    Friend WithEvents txt_pwdchecker As TextBox
End Class
