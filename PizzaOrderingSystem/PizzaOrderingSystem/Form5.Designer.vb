<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Dashboard
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
        dtg = New DataGridView()
        txt_firstname2 = New TextBox()
        Label2 = New Label()
        Label3 = New Label()
        txt_lastname2 = New TextBox()
        Label4 = New Label()
        txt_address2 = New TextBox()
        Label5 = New Label()
        txt_password2 = New TextBox()
        Label6 = New Label()
        txt_username2 = New TextBox()
        btn_refresh = New Button()
        btn_update = New Button()
        btn_create = New Button()
        btn_delete = New Button()
        Label7 = New Label()
        txt_id2 = New TextBox()
        Button1 = New Button()
        btn_logout = New Button()
        CType(dtg, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("MV Boli", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(218, 13)
        Label1.Name = "Label1"
        Label1.Size = New Size(272, 31)
        Label1.TabIndex = 1
        Label1.Text = "ADMIN DASHBOARD"
        ' 
        ' dtg
        ' 
        dtg.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dtg.Location = New Point(250, 87)
        dtg.Name = "dtg"
        dtg.Size = New Size(391, 168)
        dtg.TabIndex = 2
        ' 
        ' txt_firstname2
        ' 
        txt_firstname2.Location = New Point(112, 174)
        txt_firstname2.Name = "txt_firstname2"
        txt_firstname2.Size = New Size(114, 22)
        txt_firstname2.TabIndex = 3
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(32, 174)
        Label2.Name = "Label2"
        Label2.Size = New Size(75, 15)
        Label2.TabIndex = 4
        Label2.Text = "First Name"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(32, 203)
        Label3.Name = "Label3"
        Label3.Size = New Size(72, 15)
        Label3.TabIndex = 6
        Label3.Text = "Last Name"
        ' 
        ' txt_lastname2
        ' 
        txt_lastname2.Location = New Point(112, 203)
        txt_lastname2.Name = "txt_lastname2"
        txt_lastname2.Size = New Size(114, 22)
        txt_lastname2.TabIndex = 5
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(32, 232)
        Label4.Name = "Label4"
        Label4.Size = New Size(54, 15)
        Label4.TabIndex = 8
        Label4.Text = "Address"
        ' 
        ' txt_address2
        ' 
        txt_address2.Location = New Point(112, 232)
        txt_address2.Name = "txt_address2"
        txt_address2.Size = New Size(114, 22)
        txt_address2.TabIndex = 7
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(32, 145)
        Label5.Name = "Label5"
        Label5.Size = New Size(63, 15)
        Label5.TabIndex = 12
        Label5.Text = "Password"
        ' 
        ' txt_password2
        ' 
        txt_password2.Location = New Point(112, 145)
        txt_password2.Name = "txt_password2"
        txt_password2.Size = New Size(114, 22)
        txt_password2.TabIndex = 11
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(32, 116)
        Label6.Name = "Label6"
        Label6.Size = New Size(66, 15)
        Label6.TabIndex = 10
        Label6.Text = "Username"
        ' 
        ' txt_username2
        ' 
        txt_username2.Location = New Point(112, 116)
        txt_username2.Name = "txt_username2"
        txt_username2.Size = New Size(114, 22)
        txt_username2.TabIndex = 9
        ' 
        ' btn_refresh
        ' 
        btn_refresh.BackColor = Color.BlanchedAlmond
        btn_refresh.Font = New Font("MV Boli", 9F)
        btn_refresh.Location = New Point(543, 261)
        btn_refresh.Name = "btn_refresh"
        btn_refresh.Size = New Size(98, 32)
        btn_refresh.TabIndex = 13
        btn_refresh.Text = "REFRESH"
        btn_refresh.UseVisualStyleBackColor = False
        ' 
        ' btn_update
        ' 
        btn_update.BackColor = Color.BlanchedAlmond
        btn_update.Font = New Font("MV Boli", 9F)
        btn_update.Location = New Point(32, 319)
        btn_update.Name = "btn_update"
        btn_update.Size = New Size(98, 32)
        btn_update.TabIndex = 14
        btn_update.Text = "UPDATE"
        btn_update.UseVisualStyleBackColor = False
        ' 
        ' btn_create
        ' 
        btn_create.BackColor = Color.BlanchedAlmond
        btn_create.Font = New Font("MV Boli", 9F)
        btn_create.Location = New Point(32, 281)
        btn_create.Name = "btn_create"
        btn_create.Size = New Size(98, 32)
        btn_create.TabIndex = 15
        btn_create.Text = "CREATE"
        btn_create.UseVisualStyleBackColor = False
        ' 
        ' btn_delete
        ' 
        btn_delete.BackColor = Color.BlanchedAlmond
        btn_delete.Font = New Font("MV Boli", 9F)
        btn_delete.Location = New Point(137, 319)
        btn_delete.Name = "btn_delete"
        btn_delete.Size = New Size(98, 32)
        btn_delete.TabIndex = 16
        btn_delete.Text = "DELETE"
        btn_delete.UseVisualStyleBackColor = False
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(53, 90)
        Label7.Name = "Label7"
        Label7.Size = New Size(25, 15)
        Label7.TabIndex = 18
        Label7.Text = "ID"
        ' 
        ' txt_id2
        ' 
        txt_id2.Enabled = False
        txt_id2.Location = New Point(112, 87)
        txt_id2.Name = "txt_id2"
        txt_id2.Size = New Size(114, 22)
        txt_id2.TabIndex = 17
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.BlanchedAlmond
        Button1.Font = New Font("MV Boli", 9F)
        Button1.Location = New Point(137, 281)
        Button1.Name = "Button1"
        Button1.Size = New Size(98, 32)
        Button1.TabIndex = 19
        Button1.Text = "CLEAR TEXT"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' btn_logout
        ' 
        btn_logout.BackColor = Color.BlanchedAlmond
        btn_logout.Font = New Font("MV Boli", 9F)
        btn_logout.Location = New Point(14, 12)
        btn_logout.Name = "btn_logout"
        btn_logout.Size = New Size(98, 32)
        btn_logout.TabIndex = 21
        btn_logout.Text = "LOG OUT"
        btn_logout.UseVisualStyleBackColor = False
        ' 
        ' Dashboard
        ' 
        AutoScaleDimensions = New SizeF(8F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.Linen
        ClientSize = New Size(669, 361)
        Controls.Add(btn_logout)
        Controls.Add(Button1)
        Controls.Add(Label7)
        Controls.Add(txt_id2)
        Controls.Add(btn_delete)
        Controls.Add(btn_create)
        Controls.Add(btn_update)
        Controls.Add(btn_refresh)
        Controls.Add(Label5)
        Controls.Add(txt_password2)
        Controls.Add(Label6)
        Controls.Add(txt_username2)
        Controls.Add(Label4)
        Controls.Add(txt_address2)
        Controls.Add(Label3)
        Controls.Add(txt_lastname2)
        Controls.Add(Label2)
        Controls.Add(txt_firstname2)
        Controls.Add(dtg)
        Controls.Add(Label1)
        Font = New Font("Ink Free", 9F, FontStyle.Bold)
        Name = "Dashboard"
        Text = "Dashboard"
        CType(dtg, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents dtg As DataGridView
    Friend WithEvents txt_firstname2 As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txt_lastname2 As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txt_address2 As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txt_password2 As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txt_username2 As TextBox
    Friend WithEvents btn_refresh As Button
    Friend WithEvents btn_update As Button
    Friend WithEvents btn_create As Button
    Friend WithEvents btn_delete As Button
    Friend WithEvents Label7 As Label
    Friend WithEvents txt_id2 As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents btn_logout As Button
End Class
