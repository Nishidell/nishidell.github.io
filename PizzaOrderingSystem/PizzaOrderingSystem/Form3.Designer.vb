<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LoginForm
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
        txt_username = New TextBox()
        txt_password = New TextBox()
        Label2 = New Label()
        Label3 = New Label()
        btn_login = New Button()
        btn_directSignUp = New LinkLabel()
        Label4 = New Label()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("MV Boli", 24F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(146, 9)
        Label1.Margin = New Padding(4, 0, 4, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(116, 41)
        Label1.TabIndex = 0
        Label1.Text = "LOGIN"
        ' 
        ' txt_username
        ' 
        txt_username.Location = New Point(98, 105)
        txt_username.Margin = New Padding(4, 2, 4, 2)
        txt_username.Multiline = True
        txt_username.Name = "txt_username"
        txt_username.Size = New Size(215, 34)
        txt_username.TabIndex = 1
        ' 
        ' txt_password
        ' 
        txt_password.Location = New Point(98, 182)
        txt_password.Margin = New Padding(4, 2, 4, 2)
        txt_password.Multiline = True
        txt_password.Name = "txt_password"
        txt_password.PasswordChar = "*"c
        txt_password.Size = New Size(215, 34)
        txt_password.TabIndex = 2
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(166, 81)
        Label2.Margin = New Padding(4, 0, 4, 0)
        Label2.Name = "Label2"
        Label2.Size = New Size(81, 21)
        Label2.TabIndex = 3
        Label2.Text = "Username"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(166, 159)
        Label3.Margin = New Padding(4, 0, 4, 0)
        Label3.Name = "Label3"
        Label3.Size = New Size(76, 21)
        Label3.TabIndex = 4
        Label3.Text = "Password"
        ' 
        ' btn_login
        ' 
        btn_login.BackColor = Color.BlanchedAlmond
        btn_login.Font = New Font("Ink Free", 11.9999981F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btn_login.Location = New Point(146, 239)
        btn_login.Margin = New Padding(4, 2, 4, 2)
        btn_login.Name = "btn_login"
        btn_login.Size = New Size(124, 38)
        btn_login.TabIndex = 5
        btn_login.Text = "Login"
        btn_login.UseVisualStyleBackColor = False
        ' 
        ' btn_directSignUp
        ' 
        btn_directSignUp.AutoSize = True
        btn_directSignUp.Font = New Font("Arial", 9.75F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        btn_directSignUp.Location = New Point(255, 291)
        btn_directSignUp.Margin = New Padding(4, 0, 4, 0)
        btn_directSignUp.Name = "btn_directSignUp"
        btn_directSignUp.Size = New Size(57, 16)
        btn_directSignUp.TabIndex = 6
        btn_directSignUp.TabStop = True
        btn_directSignUp.Text = "Sign Up"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label4.Location = New Point(97, 291)
        Label4.Margin = New Padding(4, 0, 4, 0)
        Label4.Name = "Label4"
        Label4.Size = New Size(145, 16)
        Label4.TabIndex = 7
        Label4.Text = "Don't have account yet?"
        ' 
        ' LoginForm
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.Linen
        ClientSize = New Size(402, 425)
        Controls.Add(Label4)
        Controls.Add(btn_directSignUp)
        Controls.Add(btn_login)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(txt_password)
        Controls.Add(txt_username)
        Controls.Add(Label1)
        Margin = New Padding(4, 2, 4, 2)
        Name = "LoginForm"
        Text = "Login Form"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txt_username As TextBox
    Friend WithEvents txt_password As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents btn_login As Button
    Friend WithEvents btn_directSignUp As LinkLabel
    Friend WithEvents Label4 As Label
End Class
