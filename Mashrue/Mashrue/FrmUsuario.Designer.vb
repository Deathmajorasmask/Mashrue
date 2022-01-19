<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmUsuario
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
        Me.txtUsuAddCon = New System.Windows.Forms.TextBox()
        Me.txtUsuAddNom = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtUsuAddEmail = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtUsuAddTel = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtUsuAddID = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnUsuImg = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btnUsuAdd = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cboUsuAgrRol = New System.Windows.Forms.ComboBox()
        Me.btnUsuCancel = New System.Windows.Forms.Button()
        Me.cboUsuAgrDep = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtUsuAddCon
        '
        Me.txtUsuAddCon.Location = New System.Drawing.Point(120, 106)
        Me.txtUsuAddCon.Name = "txtUsuAddCon"
        Me.txtUsuAddCon.Size = New System.Drawing.Size(256, 20)
        Me.txtUsuAddCon.TabIndex = 125
        '
        'txtUsuAddNom
        '
        Me.txtUsuAddNom.Location = New System.Drawing.Point(120, 70)
        Me.txtUsuAddNom.Name = "txtUsuAddNom"
        Me.txtUsuAddNom.Size = New System.Drawing.Size(256, 20)
        Me.txtUsuAddNom.TabIndex = 123
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(36, 231)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(56, 13)
        Me.Label7.TabIndex = 121
        Me.Label7.Text = "Rol en DB"
        '
        'txtUsuAddEmail
        '
        Me.txtUsuAddEmail.Location = New System.Drawing.Point(120, 193)
        Me.txtUsuAddEmail.Name = "txtUsuAddEmail"
        Me.txtUsuAddEmail.Size = New System.Drawing.Size(256, 20)
        Me.txtUsuAddEmail.TabIndex = 120
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(36, 196)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(32, 13)
        Me.Label5.TabIndex = 119
        Me.Label5.Text = "Email"
        '
        'txtUsuAddTel
        '
        Me.txtUsuAddTel.Location = New System.Drawing.Point(120, 150)
        Me.txtUsuAddTel.Name = "txtUsuAddTel"
        Me.txtUsuAddTel.Size = New System.Drawing.Size(256, 20)
        Me.txtUsuAddTel.TabIndex = 118
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(36, 153)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(54, 13)
        Me.Label6.TabIndex = 117
        Me.Label6.Text = "Telefonos"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(36, 73)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(44, 13)
        Me.Label4.TabIndex = 116
        Me.Label4.Text = "Nombre"
        '
        'txtUsuAddID
        '
        Me.txtUsuAddID.Location = New System.Drawing.Point(120, 35)
        Me.txtUsuAddID.Name = "txtUsuAddID"
        Me.txtUsuAddID.Size = New System.Drawing.Size(256, 20)
        Me.txtUsuAddID.TabIndex = 115
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(35, 38)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(72, 13)
        Me.Label1.TabIndex = 114
        Me.Label1.Text = "ID de Usuario"
        '
        'btnUsuImg
        '
        Me.btnUsuImg.Location = New System.Drawing.Point(406, 255)
        Me.btnUsuImg.Name = "btnUsuImg"
        Me.btnUsuImg.Size = New System.Drawing.Size(193, 27)
        Me.btnUsuImg.TabIndex = 129
        Me.btnUsuImg.Text = "Agregar Imagen"
        Me.btnUsuImg.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PictureBox1.Location = New System.Drawing.Point(403, 32)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(195, 212)
        Me.PictureBox1.TabIndex = 128
        Me.PictureBox1.TabStop = False
        '
        'btnUsuAdd
        '
        Me.btnUsuAdd.Location = New System.Drawing.Point(38, 293)
        Me.btnUsuAdd.Name = "btnUsuAdd"
        Me.btnUsuAdd.Size = New System.Drawing.Size(561, 30)
        Me.btnUsuAdd.TabIndex = 127
        Me.btnUsuAdd.Text = "Agregar Usuario"
        Me.btnUsuAdd.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(36, 109)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(61, 13)
        Me.Label2.TabIndex = 130
        Me.Label2.Text = "Contraseña"
        '
        'cboUsuAgrRol
        '
        Me.cboUsuAgrRol.FormattingEnabled = True
        Me.cboUsuAgrRol.Items.AddRange(New Object() {"Administrador", "Usuario", "Lider"})
        Me.cboUsuAgrRol.Location = New System.Drawing.Point(120, 228)
        Me.cboUsuAgrRol.Name = "cboUsuAgrRol"
        Me.cboUsuAgrRol.Size = New System.Drawing.Size(256, 21)
        Me.cboUsuAgrRol.TabIndex = 131
        '
        'btnUsuCancel
        '
        Me.btnUsuCancel.Location = New System.Drawing.Point(494, 329)
        Me.btnUsuCancel.Name = "btnUsuCancel"
        Me.btnUsuCancel.Size = New System.Drawing.Size(104, 26)
        Me.btnUsuCancel.TabIndex = 132
        Me.btnUsuCancel.Text = "Cancelar"
        Me.btnUsuCancel.UseVisualStyleBackColor = True
        '
        'cboUsuAgrDep
        '
        Me.cboUsuAgrDep.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboUsuAgrDep.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.cboUsuAgrDep.FormattingEnabled = True
        Me.cboUsuAgrDep.Location = New System.Drawing.Point(120, 259)
        Me.cboUsuAgrDep.Name = "cboUsuAgrDep"
        Me.cboUsuAgrDep.Size = New System.Drawing.Size(256, 21)
        Me.cboUsuAgrDep.TabIndex = 134
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(36, 262)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(74, 13)
        Me.Label3.TabIndex = 133
        Me.Label3.Text = "Departamento"
        '
        'FrmUsuario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(648, 367)
        Me.Controls.Add(Me.cboUsuAgrDep)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.btnUsuCancel)
        Me.Controls.Add(Me.cboUsuAgrRol)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnUsuImg)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.btnUsuAdd)
        Me.Controls.Add(Me.txtUsuAddCon)
        Me.Controls.Add(Me.txtUsuAddNom)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtUsuAddEmail)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtUsuAddTel)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtUsuAddID)
        Me.Controls.Add(Me.Label1)
        Me.Name = "FrmUsuario"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Agregar Usuario"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtUsuAddCon As TextBox
    Friend WithEvents txtUsuAddNom As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents txtUsuAddEmail As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtUsuAddTel As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtUsuAddID As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents btnUsuImg As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents btnUsuAdd As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents cboUsuAgrRol As ComboBox
    Friend WithEvents btnUsuCancel As Button
    Friend WithEvents cboUsuAgrDep As ComboBox
    Friend WithEvents Label3 As Label
End Class
