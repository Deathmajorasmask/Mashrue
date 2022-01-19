<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmTipoMod
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
        Me.btnTActModCancel = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnCompDelete = New System.Windows.Forms.Button()
        Me.txtTActModDescp = New System.Windows.Forms.TextBox()
        Me.txtTActModNom = New System.Windows.Forms.TextBox()
        Me.txtTActModHour = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtTActModID = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnTActModPrev = New System.Windows.Forms.Button()
        Me.btnTActModNext = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btnTActModBusqOK = New System.Windows.Forms.Button()
        Me.txtTActModBusq = New System.Windows.Forms.TextBox()
        Me.cboTActModBusqCrit = New System.Windows.Forms.ComboBox()
        Me.lblTActModTotalReg = New System.Windows.Forms.Label()
        Me.btnTActModDelete = New System.Windows.Forms.Button()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnTActModCancel
        '
        Me.btnTActModCancel.Location = New System.Drawing.Point(334, 275)
        Me.btnTActModCancel.Name = "btnTActModCancel"
        Me.btnTActModCancel.Size = New System.Drawing.Size(104, 26)
        Me.btnTActModCancel.TabIndex = 6
        Me.btnTActModCancel.Text = "Cancelar"
        Me.btnTActModCancel.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(79, 111)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(63, 13)
        Me.Label2.TabIndex = 169
        Me.Label2.Text = "Descripcion"
        '
        'btnCompDelete
        '
        Me.btnCompDelete.Location = New System.Drawing.Point(80, 203)
        Me.btnCompDelete.Name = "btnCompDelete"
        Me.btnCompDelete.Size = New System.Drawing.Size(358, 30)
        Me.btnCompDelete.TabIndex = 4
        Me.btnCompDelete.Text = "Guardar Cambios"
        Me.btnCompDelete.UseVisualStyleBackColor = True
        '
        'txtTActModDescp
        '
        Me.txtTActModDescp.Location = New System.Drawing.Point(199, 108)
        Me.txtTActModDescp.Name = "txtTActModDescp"
        Me.txtTActModDescp.Size = New System.Drawing.Size(239, 20)
        Me.txtTActModDescp.TabIndex = 2
        '
        'txtTActModNom
        '
        Me.txtTActModNom.Location = New System.Drawing.Point(199, 72)
        Me.txtTActModNom.Name = "txtTActModNom"
        Me.txtTActModNom.Size = New System.Drawing.Size(239, 20)
        Me.txtTActModNom.TabIndex = 1
        '
        'txtTActModHour
        '
        Me.txtTActModHour.Location = New System.Drawing.Point(199, 152)
        Me.txtTActModHour.Name = "txtTActModHour"
        Me.txtTActModHour.Size = New System.Drawing.Size(239, 20)
        Me.txtTActModHour.TabIndex = 3
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(79, 155)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(78, 13)
        Me.Label6.TabIndex = 164
        Me.Label6.Text = "Costo por Hora"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(79, 75)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(44, 13)
        Me.Label4.TabIndex = 163
        Me.Label4.Text = "Nombre"
        '
        'txtTActModID
        '
        Me.txtTActModID.Location = New System.Drawing.Point(199, 37)
        Me.txtTActModID.Name = "txtTActModID"
        Me.txtTActModID.Size = New System.Drawing.Size(239, 20)
        Me.txtTActModID.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(78, 40)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(80, 13)
        Me.Label1.TabIndex = 161
        Me.Label1.Text = "ID de Actividad"
        '
        'btnTActModPrev
        '
        Me.btnTActModPrev.Location = New System.Drawing.Point(19, 37)
        Me.btnTActModPrev.Name = "btnTActModPrev"
        Me.btnTActModPrev.Size = New System.Drawing.Size(34, 191)
        Me.btnTActModPrev.TabIndex = 8
        Me.btnTActModPrev.Text = "<"
        Me.btnTActModPrev.UseVisualStyleBackColor = True
        '
        'btnTActModNext
        '
        Me.btnTActModNext.Location = New System.Drawing.Point(460, 37)
        Me.btnTActModNext.Name = "btnTActModNext"
        Me.btnTActModNext.Size = New System.Drawing.Size(34, 191)
        Me.btnTActModNext.TabIndex = 7
        Me.btnTActModNext.Text = ">"
        Me.btnTActModNext.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.btnTActModBusqOK)
        Me.GroupBox2.Controls.Add(Me.txtTActModBusq)
        Me.GroupBox2.Controls.Add(Me.cboTActModBusqCrit)
        Me.GroupBox2.Location = New System.Drawing.Point(42, 308)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(428, 99)
        Me.GroupBox2.TabIndex = 173
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Busqueda especifica"
        '
        'btnTActModBusqOK
        '
        Me.btnTActModBusqOK.Location = New System.Drawing.Point(16, 56)
        Me.btnTActModBusqOK.Name = "btnTActModBusqOK"
        Me.btnTActModBusqOK.Size = New System.Drawing.Size(396, 26)
        Me.btnTActModBusqOK.TabIndex = 11
        Me.btnTActModBusqOK.Text = "Buscar"
        Me.btnTActModBusqOK.UseVisualStyleBackColor = True
        '
        'txtTActModBusq
        '
        Me.txtTActModBusq.Location = New System.Drawing.Point(16, 30)
        Me.txtTActModBusq.Name = "txtTActModBusq"
        Me.txtTActModBusq.Size = New System.Drawing.Size(172, 20)
        Me.txtTActModBusq.TabIndex = 9
        '
        'cboTActModBusqCrit
        '
        Me.cboTActModBusqCrit.FormattingEnabled = True
        Me.cboTActModBusqCrit.Location = New System.Drawing.Point(235, 29)
        Me.cboTActModBusqCrit.Name = "cboTActModBusqCrit"
        Me.cboTActModBusqCrit.Size = New System.Drawing.Size(177, 21)
        Me.cboTActModBusqCrit.TabIndex = 10
        '
        'lblTActModTotalReg
        '
        Me.lblTActModTotalReg.AutoSize = True
        Me.lblTActModTotalReg.Location = New System.Drawing.Point(180, 9)
        Me.lblTActModTotalReg.Name = "lblTActModTotalReg"
        Me.lblTActModTotalReg.Size = New System.Drawing.Size(103, 13)
        Me.lblTActModTotalReg.TabIndex = 174
        Me.lblTActModTotalReg.Text = "ID de Departamento"
        '
        'btnTActModDelete
        '
        Me.btnTActModDelete.Location = New System.Drawing.Point(80, 239)
        Me.btnTActModDelete.Name = "btnTActModDelete"
        Me.btnTActModDelete.Size = New System.Drawing.Size(358, 26)
        Me.btnTActModDelete.TabIndex = 5
        Me.btnTActModDelete.Text = "Eliminar Registro"
        Me.btnTActModDelete.UseVisualStyleBackColor = True
        '
        'FrmTipoMod
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(506, 421)
        Me.Controls.Add(Me.btnTActModDelete)
        Me.Controls.Add(Me.lblTActModTotalReg)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.btnTActModNext)
        Me.Controls.Add(Me.btnTActModPrev)
        Me.Controls.Add(Me.btnTActModCancel)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnCompDelete)
        Me.Controls.Add(Me.txtTActModDescp)
        Me.Controls.Add(Me.txtTActModNom)
        Me.Controls.Add(Me.txtTActModHour)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtTActModID)
        Me.Controls.Add(Me.Label1)
        Me.Name = "FrmTipoMod"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Modificar T.Actividad"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnTActModCancel As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents btnCompDelete As Button
    Friend WithEvents txtTActModDescp As TextBox
    Friend WithEvents txtTActModNom As TextBox
    Friend WithEvents txtTActModHour As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtTActModID As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents btnTActModPrev As Button
    Friend WithEvents btnTActModNext As Button
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents btnTActModBusqOK As Button
    Friend WithEvents txtTActModBusq As TextBox
    Friend WithEvents cboTActModBusqCrit As ComboBox
    Friend WithEvents lblTActModTotalReg As Label
    Friend WithEvents btnTActModDelete As Button
End Class
