<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmAdminActividad
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
        Me.btnActAddCancel = New System.Windows.Forms.Button()
        Me.btnActAddOK = New System.Windows.Forms.Button()
        Me.txtActAddIDAct = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cboActADDTipo = New System.Windows.Forms.ComboBox()
        Me.txtActAddHoras = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.dtpActAddFEFinal = New System.Windows.Forms.DateTimePicker()
        Me.dtpActAddFInicio = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtActAddDescp = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtActAddID = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnActAddPrev = New System.Windows.Forms.Button()
        Me.btnActAddNext = New System.Windows.Forms.Button()
        Me.lblregistros = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnActAddCancel
        '
        Me.btnActAddCancel.Location = New System.Drawing.Point(281, 509)
        Me.btnActAddCancel.Name = "btnActAddCancel"
        Me.btnActAddCancel.Size = New System.Drawing.Size(100, 26)
        Me.btnActAddCancel.TabIndex = 10
        Me.btnActAddCancel.Text = "Cancel"
        Me.btnActAddCancel.UseVisualStyleBackColor = True
        '
        'btnActAddOK
        '
        Me.btnActAddOK.Location = New System.Drawing.Point(58, 477)
        Me.btnActAddOK.Name = "btnActAddOK"
        Me.btnActAddOK.Size = New System.Drawing.Size(323, 26)
        Me.btnActAddOK.TabIndex = 7
        Me.btnActAddOK.Text = "Validar Actividad"
        Me.btnActAddOK.UseVisualStyleBackColor = True
        '
        'txtActAddIDAct
        '
        Me.txtActAddIDAct.Location = New System.Drawing.Point(143, 75)
        Me.txtActAddIDAct.Name = "txtActAddIDAct"
        Me.txtActAddIDAct.ReadOnly = True
        Me.txtActAddIDAct.Size = New System.Drawing.Size(239, 20)
        Me.txtActAddIDAct.TabIndex = 1
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(49, 78)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(80, 13)
        Me.Label7.TabIndex = 215
        Me.Label7.Text = "ID de Actividad"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(55, 431)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(28, 13)
        Me.Label5.TabIndex = 214
        Me.Label5.Text = "Tipo"
        '
        'cboActADDTipo
        '
        Me.cboActADDTipo.Enabled = False
        Me.cboActADDTipo.FormattingEnabled = True
        Me.cboActADDTipo.Location = New System.Drawing.Point(175, 428)
        Me.cboActADDTipo.Name = "cboActADDTipo"
        Me.cboActADDTipo.Size = New System.Drawing.Size(207, 21)
        Me.cboActADDTipo.TabIndex = 6
        '
        'txtActAddHoras
        '
        Me.txtActAddHoras.Location = New System.Drawing.Point(175, 392)
        Me.txtActAddHoras.Name = "txtActAddHoras"
        Me.txtActAddHoras.ReadOnly = True
        Me.txtActAddHoras.Size = New System.Drawing.Size(207, 20)
        Me.txtActAddHoras.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(55, 395)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(85, 13)
        Me.Label3.TabIndex = 211
        Me.Label3.Text = "Horas estimadas"
        '
        'dtpActAddFEFinal
        '
        Me.dtpActAddFEFinal.CustomFormat = "yyyy-MM-dd"
        Me.dtpActAddFEFinal.Enabled = False
        Me.dtpActAddFEFinal.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpActAddFEFinal.Location = New System.Drawing.Point(175, 350)
        Me.dtpActAddFEFinal.Name = "dtpActAddFEFinal"
        Me.dtpActAddFEFinal.Size = New System.Drawing.Size(207, 20)
        Me.dtpActAddFEFinal.TabIndex = 4
        '
        'dtpActAddFInicio
        '
        Me.dtpActAddFInicio.CustomFormat = "yyyy-MM-dd"
        Me.dtpActAddFInicio.Enabled = False
        Me.dtpActAddFInicio.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpActAddFInicio.Location = New System.Drawing.Point(175, 314)
        Me.dtpActAddFInicio.Name = "dtpActAddFInicio"
        Me.dtpActAddFInicio.Size = New System.Drawing.Size(207, 20)
        Me.dtpActAddFInicio.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(55, 314)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(80, 13)
        Me.Label2.TabIndex = 208
        Me.Label2.Text = "Fecha de Inicio"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(55, 356)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(108, 13)
        Me.Label6.TabIndex = 207
        Me.Label6.Text = "Fecha Estimada Final"
        '
        'txtActAddDescp
        '
        Me.txtActAddDescp.Location = New System.Drawing.Point(53, 135)
        Me.txtActAddDescp.Multiline = True
        Me.txtActAddDescp.Name = "txtActAddDescp"
        Me.txtActAddDescp.ReadOnly = True
        Me.txtActAddDescp.Size = New System.Drawing.Size(329, 157)
        Me.txtActAddDescp.TabIndex = 2
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(50, 109)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(63, 13)
        Me.Label4.TabIndex = 205
        Me.Label4.Text = "Descripcion"
        '
        'txtActAddID
        '
        Me.txtActAddID.Location = New System.Drawing.Point(143, 40)
        Me.txtActAddID.Name = "txtActAddID"
        Me.txtActAddID.ReadOnly = True
        Me.txtActAddID.Size = New System.Drawing.Size(239, 20)
        Me.txtActAddID.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(49, 43)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(78, 13)
        Me.Label1.TabIndex = 203
        Me.Label1.Text = "ID de Proyecto"
        '
        'btnActAddPrev
        '
        Me.btnActAddPrev.Location = New System.Drawing.Point(7, 40)
        Me.btnActAddPrev.Name = "btnActAddPrev"
        Me.btnActAddPrev.Size = New System.Drawing.Size(30, 494)
        Me.btnActAddPrev.TabIndex = 8
        Me.btnActAddPrev.Text = "<"
        Me.btnActAddPrev.UseVisualStyleBackColor = True
        '
        'btnActAddNext
        '
        Me.btnActAddNext.Location = New System.Drawing.Point(401, 41)
        Me.btnActAddNext.Name = "btnActAddNext"
        Me.btnActAddNext.Size = New System.Drawing.Size(30, 494)
        Me.btnActAddNext.TabIndex = 9
        Me.btnActAddNext.Text = ">"
        Me.btnActAddNext.UseVisualStyleBackColor = True
        '
        'lblregistros
        '
        Me.lblregistros.AutoSize = True
        Me.lblregistros.Location = New System.Drawing.Point(172, 9)
        Me.lblregistros.Name = "lblregistros"
        Me.lblregistros.Size = New System.Drawing.Size(78, 13)
        Me.lblregistros.TabIndex = 221
        Me.lblregistros.Text = "ID de Proyecto"
        '
        'FrmAdminActividad
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(445, 544)
        Me.Controls.Add(Me.lblregistros)
        Me.Controls.Add(Me.btnActAddNext)
        Me.Controls.Add(Me.btnActAddPrev)
        Me.Controls.Add(Me.btnActAddCancel)
        Me.Controls.Add(Me.btnActAddOK)
        Me.Controls.Add(Me.txtActAddIDAct)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.cboActADDTipo)
        Me.Controls.Add(Me.txtActAddHoras)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.dtpActAddFEFinal)
        Me.Controls.Add(Me.dtpActAddFInicio)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtActAddDescp)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtActAddID)
        Me.Controls.Add(Me.Label1)
        Me.Name = "FrmAdminActividad"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Aprobación de Actividades"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnActAddCancel As Button
    Friend WithEvents btnActAddOK As Button
    Friend WithEvents txtActAddIDAct As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents cboActADDTipo As ComboBox
    Friend WithEvents txtActAddHoras As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents dtpActAddFEFinal As DateTimePicker
    Friend WithEvents dtpActAddFInicio As DateTimePicker
    Friend WithEvents Label2 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents txtActAddDescp As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtActAddID As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents btnActAddPrev As Button
    Friend WithEvents btnActAddNext As Button
    Friend WithEvents lblregistros As Label
End Class
