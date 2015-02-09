<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmUtilityTool : Inherits System.Windows.Forms.Form

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
        Me.bttConnect = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtPath = New System.Windows.Forms.TextBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.bttGenerate = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtServer = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtUserId = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtDatabase = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.tvwDB = New System.Windows.Forms.TreeView()
        Me.ckoVB = New System.Windows.Forms.CheckBox()
        Me.ckoCSharp = New System.Windows.Forms.CheckBox()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.tabGenerateDB = New System.Windows.Forms.TabPage()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.ckoStore = New System.Windows.Forms.CheckBox()
        Me.ckoTableName = New System.Windows.Forms.CheckBox()
        Me.ckoTableClass = New System.Windows.Forms.CheckBox()
        Me.tabEncryptPassword = New System.Windows.Forms.TabPage()
        Me.bttDecryption = New System.Windows.Forms.Button()
        Me.bttEncryption = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtResult = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtInput = New System.Windows.Forms.TextBox()
        Me.GroupBox1.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.tabGenerateDB.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.tabEncryptPassword.SuspendLayout()
        Me.SuspendLayout()
        '
        'bttConnect
        '
        Me.bttConnect.Location = New System.Drawing.Point(127, 160)
        Me.bttConnect.Name = "bttConnect"
        Me.bttConnect.Size = New System.Drawing.Size(75, 25)
        Me.bttConnect.TabIndex = 4
        Me.bttConnect.Text = "Connect"
        Me.bttConnect.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(37, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(37, 14)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Folder"
        '
        'txtPath
        '
        Me.txtPath.Location = New System.Drawing.Point(77, 18)
        Me.txtPath.Name = "txtPath"
        Me.txtPath.Size = New System.Drawing.Size(322, 20)
        Me.txtPath.TabIndex = 0
        Me.txtPath.Text = "D:\WinForm\AllOne\AllOne\LibEntity\Entity"
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(405, 16)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 25)
        Me.Button2.TabIndex = 1
        Me.Button2.Text = "..."
        Me.Button2.UseVisualStyleBackColor = True
        '
        'bttGenerate
        '
        Me.bttGenerate.Location = New System.Drawing.Point(204, 376)
        Me.bttGenerate.Name = "bttGenerate"
        Me.bttGenerate.Size = New System.Drawing.Size(75, 25)
        Me.bttGenerate.TabIndex = 3
        Me.bttGenerate.Text = "Generate"
        Me.bttGenerate.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(27, 20)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(40, 14)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Server"
        '
        'txtServer
        '
        Me.txtServer.Location = New System.Drawing.Point(90, 20)
        Me.txtServer.Name = "txtServer"
        Me.txtServer.Size = New System.Drawing.Size(206, 20)
        Me.txtServer.TabIndex = 0
        Me.txtServer.Text = ".\sqlexpress"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtPassword)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.txtUserId)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.txtDatabase)
        Me.GroupBox1.Controls.Add(Me.bttConnect)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.txtServer)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Location = New System.Drawing.Point(77, 58)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(322, 195)
        Me.GroupBox1.TabIndex = 7
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Server"
        '
        'txtPassword
        '
        Me.txtPassword.Location = New System.Drawing.Point(90, 127)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.Size = New System.Drawing.Size(206, 20)
        Me.txtPassword.TabIndex = 3
        Me.txtPassword.Text = "P@ssw0rd"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(27, 127)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(57, 14)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "Password"
        '
        'txtUserId
        '
        Me.txtUserId.Location = New System.Drawing.Point(90, 92)
        Me.txtUserId.Name = "txtUserId"
        Me.txtUserId.Size = New System.Drawing.Size(206, 20)
        Me.txtUserId.TabIndex = 2
        Me.txtUserId.Text = "sa"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(27, 92)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(39, 14)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "UserID"
        '
        'txtDatabase
        '
        Me.txtDatabase.Location = New System.Drawing.Point(90, 56)
        Me.txtDatabase.Name = "txtDatabase"
        Me.txtDatabase.Size = New System.Drawing.Size(206, 20)
        Me.txtDatabase.TabIndex = 1
        Me.txtDatabase.Text = "AllOne"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(27, 56)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(53, 14)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Database"
        '
        'tvwDB
        '
        Me.tvwDB.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.tvwDB.CheckBoxes = True
        Me.tvwDB.Location = New System.Drawing.Point(405, 58)
        Me.tvwDB.Name = "tvwDB"
        Me.tvwDB.Size = New System.Drawing.Size(268, 482)
        Me.tvwDB.TabIndex = 2
        '
        'ckoVB
        '
        Me.ckoVB.AutoSize = True
        Me.ckoVB.Location = New System.Drawing.Point(30, 17)
        Me.ckoVB.Name = "ckoVB"
        Me.ckoVB.Size = New System.Drawing.Size(59, 18)
        Me.ckoVB.TabIndex = 8
        Me.ckoVB.Text = "VB.net"
        Me.ckoVB.UseVisualStyleBackColor = True
        '
        'ckoCSharp
        '
        Me.ckoCSharp.AutoSize = True
        Me.ckoCSharp.Location = New System.Drawing.Point(127, 17)
        Me.ckoCSharp.Name = "ckoCSharp"
        Me.ckoCSharp.Size = New System.Drawing.Size(57, 18)
        Me.ckoCSharp.TabIndex = 9
        Me.ckoCSharp.Text = "C#.net"
        Me.ckoCSharp.UseVisualStyleBackColor = True
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.tabGenerateDB)
        Me.TabControl1.Controls.Add(Me.tabEncryptPassword)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.Location = New System.Drawing.Point(0, 0)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(696, 577)
        Me.TabControl1.TabIndex = 10
        '
        'tabGenerateDB
        '
        Me.tabGenerateDB.Controls.Add(Me.GroupBox3)
        Me.tabGenerateDB.Controls.Add(Me.GroupBox2)
        Me.tabGenerateDB.Controls.Add(Me.txtPath)
        Me.tabGenerateDB.Controls.Add(Me.Label1)
        Me.tabGenerateDB.Controls.Add(Me.Button2)
        Me.tabGenerateDB.Controls.Add(Me.tvwDB)
        Me.tabGenerateDB.Controls.Add(Me.bttGenerate)
        Me.tabGenerateDB.Controls.Add(Me.GroupBox1)
        Me.tabGenerateDB.Location = New System.Drawing.Point(4, 23)
        Me.tabGenerateDB.Name = "tabGenerateDB"
        Me.tabGenerateDB.Padding = New System.Windows.Forms.Padding(3)
        Me.tabGenerateDB.Size = New System.Drawing.Size(688, 550)
        Me.tabGenerateDB.TabIndex = 0
        Me.tabGenerateDB.Text = "Gernerate DB"
        Me.tabGenerateDB.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.ckoCSharp)
        Me.GroupBox3.Controls.Add(Me.ckoVB)
        Me.GroupBox3.Location = New System.Drawing.Point(77, 260)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(322, 42)
        Me.GroupBox3.TabIndex = 11
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Language"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.ckoStore)
        Me.GroupBox2.Controls.Add(Me.ckoTableName)
        Me.GroupBox2.Controls.Add(Me.ckoTableClass)
        Me.GroupBox2.Location = New System.Drawing.Point(77, 308)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(322, 42)
        Me.GroupBox2.TabIndex = 10
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Type"
        '
        'ckoStore
        '
        Me.ckoStore.AutoSize = True
        Me.ckoStore.Location = New System.Drawing.Point(215, 17)
        Me.ckoStore.Name = "ckoStore"
        Me.ckoStore.Size = New System.Drawing.Size(111, 18)
        Me.ckoStore.TabIndex = 2
        Me.ckoStore.Text = "Store procedures"
        Me.ckoStore.UseVisualStyleBackColor = True
        '
        'ckoTableName
        '
        Me.ckoTableName.AutoSize = True
        Me.ckoTableName.Location = New System.Drawing.Point(127, 17)
        Me.ckoTableName.Name = "ckoTableName"
        Me.ckoTableName.Size = New System.Drawing.Size(78, 18)
        Me.ckoTableName.TabIndex = 1
        Me.ckoTableName.Text = "TableName"
        Me.ckoTableName.UseVisualStyleBackColor = True
        '
        'ckoTableClass
        '
        Me.ckoTableClass.AutoSize = True
        Me.ckoTableClass.Location = New System.Drawing.Point(30, 17)
        Me.ckoTableClass.Name = "ckoTableClass"
        Me.ckoTableClass.Size = New System.Drawing.Size(78, 18)
        Me.ckoTableClass.TabIndex = 0
        Me.ckoTableClass.Text = "TableClass"
        Me.ckoTableClass.UseVisualStyleBackColor = True
        '
        'tabEncryptPassword
        '
        Me.tabEncryptPassword.Controls.Add(Me.bttDecryption)
        Me.tabEncryptPassword.Controls.Add(Me.bttEncryption)
        Me.tabEncryptPassword.Controls.Add(Me.Label7)
        Me.tabEncryptPassword.Controls.Add(Me.txtResult)
        Me.tabEncryptPassword.Controls.Add(Me.Label6)
        Me.tabEncryptPassword.Controls.Add(Me.txtInput)
        Me.tabEncryptPassword.Location = New System.Drawing.Point(4, 23)
        Me.tabEncryptPassword.Name = "tabEncryptPassword"
        Me.tabEncryptPassword.Padding = New System.Windows.Forms.Padding(3)
        Me.tabEncryptPassword.Size = New System.Drawing.Size(688, 550)
        Me.tabEncryptPassword.TabIndex = 1
        Me.tabEncryptPassword.Text = "Encrypt Password"
        Me.tabEncryptPassword.UseVisualStyleBackColor = True
        '
        'bttDecryption
        '
        Me.bttDecryption.Location = New System.Drawing.Point(188, 170)
        Me.bttDecryption.Name = "bttDecryption"
        Me.bttDecryption.Size = New System.Drawing.Size(75, 25)
        Me.bttDecryption.TabIndex = 5
        Me.bttDecryption.Text = "Decryption"
        Me.bttDecryption.UseVisualStyleBackColor = True
        '
        'bttEncryption
        '
        Me.bttEncryption.Location = New System.Drawing.Point(62, 170)
        Me.bttEncryption.Name = "bttEncryption"
        Me.bttEncryption.Size = New System.Drawing.Size(75, 25)
        Me.bttEncryption.TabIndex = 4
        Me.bttEncryption.Text = "Encryption"
        Me.bttEncryption.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(59, 96)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(58, 14)
        Me.Label7.TabIndex = 3
        Me.Label7.Text = "Result text"
        '
        'txtResult
        '
        Me.txtResult.Location = New System.Drawing.Point(62, 113)
        Me.txtResult.Name = "txtResult"
        Me.txtResult.Size = New System.Drawing.Size(429, 20)
        Me.txtResult.TabIndex = 2
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(59, 37)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(51, 14)
        Me.Label6.TabIndex = 1
        Me.Label6.Text = "Input text"
        '
        'txtInput
        '
        Me.txtInput.Location = New System.Drawing.Point(62, 54)
        Me.txtInput.Name = "txtInput"
        Me.txtInput.Size = New System.Drawing.Size(429, 20)
        Me.txtInput.TabIndex = 0
        '
        'FrmUtilityTool
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(696, 577)
        Me.Controls.Add(Me.TabControl1)
        Me.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "FrmUtilityTool"
        Me.Tag = "0009"
        Me.Text = "Utility Tool"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.TabControl1.ResumeLayout(False)
        Me.tabGenerateDB.ResumeLayout(False)
        Me.tabGenerateDB.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.tabEncryptPassword.ResumeLayout(False)
        Me.tabEncryptPassword.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents bttConnect As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtPath As System.Windows.Forms.TextBox
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents bttGenerate As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtServer As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txtPassword As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtUserId As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtDatabase As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents tvwDB As System.Windows.Forms.TreeView
    Friend WithEvents ckoVB As System.Windows.Forms.CheckBox
    Friend WithEvents ckoCSharp As System.Windows.Forms.CheckBox
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents tabGenerateDB As System.Windows.Forms.TabPage
    Friend WithEvents tabEncryptPassword As System.Windows.Forms.TabPage
    Friend WithEvents bttEncryption As System.Windows.Forms.Button
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtResult As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtInput As System.Windows.Forms.TextBox
    Friend WithEvents bttDecryption As System.Windows.Forms.Button
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents ckoStore As System.Windows.Forms.CheckBox
    Friend WithEvents ckoTableName As System.Windows.Forms.CheckBox
    Friend WithEvents ckoTableClass As System.Windows.Forms.CheckBox

End Class
