<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmDepartamentoMod
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
        Me.btnDepModCancel = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnDepModOK = New System.Windows.Forms.Button()
        Me.txtDepModDescp = New System.Windows.Forms.TextBox()
        Me.txtDepModNom = New System.Windows.Forms.TextBox()
        Me.txtDepModUb = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtDepModExt = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtDepModID = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnDepModPrev = New System.Windows.Forms.Button()
        Me.btnDepModNext = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btnDepModBusqOK = New System.Windows.Forms.Button()
        Me.txtDepModBusq = New System.Windows.Forms.TextBox()
        Me.cboDepModBusqCrit = New System.Windows.Forms.ComboBox()
        Me.lblDepModTotalReg = New System.Windows.Forms.Label()
        Me.btnDepModDelete = New System.Windows.Forms.Button()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnDepModCancel
        '
        Me.btnDepModCancel.Location = New System.Drawing.Point(62, 336)
        Me.btnDepModCancel.Name = "btnDepModCancel"
        Me.btnDepModCancel.Size = New System.Drawing.Size(358, 26)
        Me.btnDepModCancel.TabIndex = 160
        Me.btnDepModCancel.Text = "Cancelar"
        Me.btnDepModCancel.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(61, 114)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(63, 13)
        Me.Label2.TabIndex = 159
        Me.Label2.Text = "Descripcion"
        '
        'btnDepModOK
        '
        Me.btnDepModOK.Location = New System.Drawing.Point(62, 264)
        Me.btnDepModOK.Name = "btnDepModOK"
        Me.btnDepModOK.Size = New System.Drawing.Size(358, 30)
        Me.btnDepModOK.TabIndex = 158
        Me.btnDepModOK.Text = "Guardar Cambios"
        Me.btnDepModOK.UseVisualStyleBackColor = True
        '
        'txtDepModDescp
        '
        Me.txtDepModDescp.Location = New System.Drawing.Point(181, 111)
        Me.txtDepModDescp.Multiline = True
        Me.txtDepModDescp.Name = "txtDepModDescp"
        Me.txtDepModDescp.Size = New System.Drawing.Size(239, 66)
        Me.txtDepModDescp.TabIndex = 157
        '
        'txtDepModNom
        '
        Me.txtDepModNom.Location = New System.Drawing.Point(181, 75)
        Me.txtDepModNom.Name = "txtDepModNom"
        Me.txtDepModNom.Size = New System.Drawing.Size(239, 20)
        Me.txtDepModNom.TabIndex = 156
        '
        'txtDepModUb
        '
        Me.txtDepModUb.Location = New System.Drawing.Point(181, 226)
        Me.txtDepModUb.Name = "txtDepModUb"
        Me.txtDepModUb.Size = New System.Drawing.Size(239, 20)
        Me.txtDepModUb.TabIndex = 155
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(61, 229)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(55, 13)
        Me.Label5.TabIndex = 154
        Me.Label5.Text = "Ubicación"
        '
        'txtDepModExt
        '
        Me.txtDepModExt.Location = New System.Drawing.Point(181, 183)
        Me.txtDepModExt.Name = "txtDepModExt"
        Me.txtDepModExt.Size = New System.Drawing.Size(239, 20)
        Me.txtDepModExt.TabIndex = 153
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(61, 186)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(53, 13)
        Me.Label6.TabIndex = 152
        Me.Label6.Text = "Extension"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(61, 78)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(44, 13)
        Me.Label4.TabIndex = 151
        Me.Label4.Text = "Nombre"
        '
        'txtDepModID
        '
        Me.txtDepModID.Location = New System.Drawing.Point(181, 40)
        Me.txtDepModID.Name = "txtDepModID"
        Me.txtDepModID.Size = New System.Drawing.Size(239, 20)
        Me.txtDepModID.TabIndex = 150
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(60, 43)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(103, 13)
        Me.Label1.TabIndex = 149
        Me.Label1.Text = "ID de Departamento"
        '
        'btnDepModPrev
        '
        Me.btnDepModPrev.Location = New System.Drawing.Point(14, 39)
        Me.btnDepModPrev.Name = "btnDepModPrev"
        Me.btnDepModPrev.Size = New System.Drawing.Size(29, 239)
        Me.btnDepModPrev.TabIndex = 161
        Me.btnDepModPrev.Text = "<"
        Me.btnDepModPrev.UseVisualStyleBackColor = True
        '
        'btnDepModNext
        '
        Me.btnDepModNext.Location = New System.Drawing.Point(441, 39)
        Me.btnDepModNext.Name = "btnDepModNext"
        Me.btnDepModNext.Size = New System.Drawing.Size(29, 239)
        Me.btnDepModNext.TabIndex = 162
        Me.btnDepModNext.Text = ">"
        Me.btnDepModNext.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.btnDepModBusqOK)
        Me.GroupBox2.Controls.Add(Me.txtDepModBusq)
        Me.GroupBox2.Controls.Add(Me.cboDepModBusqCrit)
        Me.GroupBox2.Location = New System.Drawing.Point(33, 372)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(428, 99)
        Me.GroupBox2.TabIndex = 169
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Busqueda especifica"
        '
        'btnDepModBusqOK
        '
        Me.btnDepModBusqOK.Location = New System.Drawing.Point(16, 56)
        Me.btnDepModBusqOK.Name = "btnDepModBusqOK"
        Me.btnDepModBusqOK.Size = New System.Drawing.Size(396, 26)
        Me.btnDepModBusqOK.TabIndex = 2
        Me.btnDepModBusqOK.Text = "Buscar"
        Me.btnDepModBusqOK.UseVisualStyleBackColor = True
        '
        'txtDepModBusq
        '
        Me.txtDepModBusq.Location = New System.Drawing.Point(16, 30)
        Me.txtDepModBusq.Name = "txtDepModBusq"
        Me.txtDepModBusq.Size = New System.Drawing.Size(172, 20)
        Me.txtDepModBusq.TabIndex = 1
        '
        'cboDepModBusqCrit
        '
        Me.cboDepModBusqCrit.FormattingEnabled = True
        Me.cboDepModBusqCrit.Location = New System.Drawing.Point(235, 29)
        Me.cboDepModBusqCrit.Name = "cboDepModBusqCrit"
        Me.cboDepModBusqCrit.Size = New System.Drawing.Size(177, 21)
        Me.cboDepModBusqCrit.TabIndex = 0
        '
        'lblDepModTotalReg
        '
        Me.lblDepModTotalReg.AutoSize = True
        Me.lblDepModTotalReg.Location = New System.Drawing.Point(187, 9)
        Me.lblDepModTotalReg.Name = "lblDepModTotalReg"
        Me.lblDepModTotalReg.Size = New System.Drawing.Size(103, 13)
        Me.lblDepModTotalReg.TabIndex = 170
        Me.lblDepModTotalReg.Text = "ID de Departamento"
        '
        'btnDepModDelete
        '
        Me.btnDepModDelete.Location = New System.Drawing.Point(62, 304)
        Me.btnDepModDelete.Name = "btnDepModDelete"
        Me.btnDepModDelete.Size = New System.Drawing.Size(358, 26)
        Me.btnDepModDelete.TabIndex = 171
        Me.btnDepModDelete.Text = "Eliminar Registro"
        Me.btnDepModDelete.UseVisualStyleBackColor = True
        '
        'FrmDepartamentoMod
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(495, 484)
        Me.Controls.Add(Me.btnDepModDelete)
        Me.Controls.Add(Me.lblDepModTotalReg)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.btnDepModNext)
        Me.Controls.Add(Me.btnDepModPrev)
        Me.Controls.Add(Me.btnDepModCancel)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnDepModOK)
        Me.Controls.Add(Me.txtDepModDescp)
        Me.Controls.Add(Me.txtDepModNom)
        Me.Controls.Add(Me.txtDepModUb)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtDepModExt)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtDepModID)
        Me.Controls.Add(Me.Label1)
        Me.Name = "FrmDepartamentoMod"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Modificar Departamento"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnDepModCancel As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents btnDepModOK As Button
    Friend WithEvents txtDepModDescp As TextBox
    Friend WithEvents txtDepModNom As TextBox
    Friend WithEvents txtDepModUb As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtDepModExt As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtDepModID As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents btnDepModPrev As Button
    Friend WithEvents btnDepModNext As Button
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents btnDepModBusqOK As Button
    Friend WithEvents txtDepModBusq As TextBox
    Friend WithEvents cboDepModBusqCrit As ComboBox
    Friend WithEvents lblDepModTotalReg As Label
    Friend WithEvents btnDepModDelete As Button
End Class
