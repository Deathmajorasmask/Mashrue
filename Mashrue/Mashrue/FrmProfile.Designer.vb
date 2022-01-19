<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmProfile
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
        Me.cboUsuModDep = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cboUsuModRol = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.txtUsuModCon = New System.Windows.Forms.TextBox()
        Me.txtUsuModNom = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtUsuModEmail = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtUsuModTel = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtUsuModID = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cboUsuModDep
        '
        Me.cboUsuModDep.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboUsuModDep.Enabled = False
        Me.cboUsuModDep.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.cboUsuModDep.FormattingEnabled = True
        Me.cboUsuModDep.Location = New System.Drawing.Point(12, 347)
        Me.cboUsuModDep.Name = "cboUsuModDep"
        Me.cboUsuModDep.Size = New System.Drawing.Size(256, 21)
        Me.cboUsuModDep.TabIndex = 203
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 325)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(74, 13)
        Me.Label3.TabIndex = 202
        Me.Label3.Text = "Departamento"
        '
        'cboUsuModRol
        '
        Me.cboUsuModRol.Enabled = False
        Me.cboUsuModRol.FormattingEnabled = True
        Me.cboUsuModRol.Items.AddRange(New Object() {"Administrador", "Usuario", "Lider"})
        Me.cboUsuModRol.Location = New System.Drawing.Point(12, 295)
        Me.cboUsuModRol.Name = "cboUsuModRol"
        Me.cboUsuModRol.Size = New System.Drawing.Size(256, 21)
        Me.cboUsuModRol.TabIndex = 201
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 120)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(61, 13)
        Me.Label2.TabIndex = 200
        Me.Label2.Text = "Contraseña"
        '
        'PictureBox1
        '
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PictureBox1.Location = New System.Drawing.Point(299, 18)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(217, 217)
        Me.PictureBox1.TabIndex = 198
        Me.PictureBox1.TabStop = False
        '
        'txtUsuModCon
        '
        Me.txtUsuModCon.Location = New System.Drawing.Point(12, 142)
        Me.txtUsuModCon.Name = "txtUsuModCon"
        Me.txtUsuModCon.ReadOnly = True
        Me.txtUsuModCon.Size = New System.Drawing.Size(256, 20)
        Me.txtUsuModCon.TabIndex = 197
        '
        'txtUsuModNom
        '
        Me.txtUsuModNom.Location = New System.Drawing.Point(12, 91)
        Me.txtUsuModNom.Name = "txtUsuModNom"
        Me.txtUsuModNom.ReadOnly = True
        Me.txtUsuModNom.Size = New System.Drawing.Size(256, 20)
        Me.txtUsuModNom.TabIndex = 196
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(12, 273)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(56, 13)
        Me.Label7.TabIndex = 195
        Me.Label7.Text = "Rol en DB"
        '
        'txtUsuModEmail
        '
        Me.txtUsuModEmail.Location = New System.Drawing.Point(12, 244)
        Me.txtUsuModEmail.Name = "txtUsuModEmail"
        Me.txtUsuModEmail.ReadOnly = True
        Me.txtUsuModEmail.Size = New System.Drawing.Size(256, 20)
        Me.txtUsuModEmail.TabIndex = 194
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(12, 222)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(32, 13)
        Me.Label5.TabIndex = 193
        Me.Label5.Text = "Email"
        '
        'txtUsuModTel
        '
        Me.txtUsuModTel.Location = New System.Drawing.Point(12, 193)
        Me.txtUsuModTel.Name = "txtUsuModTel"
        Me.txtUsuModTel.ReadOnly = True
        Me.txtUsuModTel.Size = New System.Drawing.Size(256, 20)
        Me.txtUsuModTel.TabIndex = 192
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(12, 171)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(54, 13)
        Me.Label6.TabIndex = 191
        Me.Label6.Text = "Telefonos"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 69)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(44, 13)
        Me.Label4.TabIndex = 190
        Me.Label4.Text = "Nombre"
        '
        'txtUsuModID
        '
        Me.txtUsuModID.Location = New System.Drawing.Point(12, 40)
        Me.txtUsuModID.Name = "txtUsuModID"
        Me.txtUsuModID.ReadOnly = True
        Me.txtUsuModID.Size = New System.Drawing.Size(256, 20)
        Me.txtUsuModID.TabIndex = 189
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(72, 13)
        Me.Label1.TabIndex = 188
        Me.Label1.Text = "ID de Usuario"
        '
        'FrmProfile
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(528, 393)
        Me.Controls.Add(Me.cboUsuModDep)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.cboUsuModRol)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.txtUsuModCon)
        Me.Controls.Add(Me.txtUsuModNom)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtUsuModEmail)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtUsuModTel)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtUsuModID)
        Me.Controls.Add(Me.Label1)
        Me.Name = "FrmProfile"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Mi Perfil"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cboUsuModDep As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents cboUsuModRol As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents txtUsuModCon As TextBox
    Friend WithEvents txtUsuModNom As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents txtUsuModEmail As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtUsuModTel As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtUsuModID As TextBox
    Friend WithEvents Label1 As Label
End Class
