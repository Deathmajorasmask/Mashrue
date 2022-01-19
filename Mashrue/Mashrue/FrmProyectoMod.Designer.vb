<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmProyectoMod
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
        Me.cboProModDep = New System.Windows.Forms.ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtProModHoras = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btnUsuDelComp = New System.Windows.Forms.Button()
        Me.btnUsuAddComp = New System.Windows.Forms.Button()
        Me.lstUsuModSel = New System.Windows.Forms.ListBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.lstUsuModDisp = New System.Windows.Forms.ListBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.dtpProModFEFinal = New System.Windows.Forms.DateTimePicker()
        Me.dtpProModFInicio = New System.Windows.Forms.DateTimePicker()
        Me.txtProModEnc = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtProModPres = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnProModOK = New System.Windows.Forms.Button()
        Me.txtProModNom = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtProModID = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnProModNext = New System.Windows.Forms.Button()
        Me.btnProModPrev = New System.Windows.Forms.Button()
        Me.lblUsuModTotalReg = New System.Windows.Forms.Label()
        Me.btnProModDEL = New System.Windows.Forms.Button()
        Me.dtpProModFREALFinal = New System.Windows.Forms.DateTimePicker()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtProHorasReales = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.lblestado = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'cboProModDep
        '
        Me.cboProModDep.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboProModDep.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.cboProModDep.FormattingEnabled = True
        Me.cboProModDep.Location = New System.Drawing.Point(185, 351)
        Me.cboProModDep.Name = "cboProModDep"
        Me.cboProModDep.Size = New System.Drawing.Size(239, 21)
        Me.cboProModDep.TabIndex = 222
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(65, 354)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(74, 13)
        Me.Label8.TabIndex = 221
        Me.Label8.Text = "Departamento"
        '
        'txtProModHoras
        '
        Me.txtProModHoras.Location = New System.Drawing.Point(185, 278)
        Me.txtProModHoras.Name = "txtProModHoras"
        Me.txtProModHoras.Size = New System.Drawing.Size(239, 20)
        Me.txtProModHoras.TabIndex = 220
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(65, 281)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(86, 13)
        Me.Label5.TabIndex = 219
        Me.Label5.Text = "Horas Estimadas"
        '
        'btnUsuDelComp
        '
        Me.btnUsuDelComp.Location = New System.Drawing.Point(444, 335)
        Me.btnUsuDelComp.Name = "btnUsuDelComp"
        Me.btnUsuDelComp.Size = New System.Drawing.Size(160, 23)
        Me.btnUsuDelComp.TabIndex = 218
        Me.btnUsuDelComp.Text = "Eliminar Comp."
        Me.btnUsuDelComp.UseVisualStyleBackColor = True
        '
        'btnUsuAddComp
        '
        Me.btnUsuAddComp.Location = New System.Drawing.Point(444, 308)
        Me.btnUsuAddComp.Name = "btnUsuAddComp"
        Me.btnUsuAddComp.Size = New System.Drawing.Size(160, 23)
        Me.btnUsuAddComp.TabIndex = 217
        Me.btnUsuAddComp.Text = "Agregar Comp."
        Me.btnUsuAddComp.UseVisualStyleBackColor = True
        '
        'lstUsuModSel
        '
        Me.lstUsuModSel.FormattingEnabled = True
        Me.lstUsuModSel.Location = New System.Drawing.Point(442, 379)
        Me.lstUsuModSel.Name = "lstUsuModSel"
        Me.lstUsuModSel.Size = New System.Drawing.Size(162, 134)
        Me.lstUsuModSel.TabIndex = 216
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(439, 363)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(139, 13)
        Me.Label12.TabIndex = 215
        Me.Label12.Text = "Compañeros Seleccionadas"
        '
        'lstUsuModDisp
        '
        Me.lstUsuModDisp.FormattingEnabled = True
        Me.lstUsuModDisp.Location = New System.Drawing.Point(443, 54)
        Me.lstUsuModDisp.Name = "lstUsuModDisp"
        Me.lstUsuModDisp.Size = New System.Drawing.Size(162, 238)
        Me.lstUsuModDisp.TabIndex = 214
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(440, 38)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(123, 13)
        Me.Label11.TabIndex = 213
        Me.Label11.Text = "Compañeros Disponibles"
        '
        'dtpProModFEFinal
        '
        Me.dtpProModFEFinal.CustomFormat = "yyyy-MM-dd"
        Me.dtpProModFEFinal.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpProModFEFinal.Location = New System.Drawing.Point(183, 195)
        Me.dtpProModFEFinal.Name = "dtpProModFEFinal"
        Me.dtpProModFEFinal.Size = New System.Drawing.Size(239, 20)
        Me.dtpProModFEFinal.TabIndex = 212
        '
        'dtpProModFInicio
        '
        Me.dtpProModFInicio.CustomFormat = "yyyy-MM-dd"
        Me.dtpProModFInicio.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpProModFInicio.Location = New System.Drawing.Point(183, 121)
        Me.dtpProModFInicio.Name = "dtpProModFInicio"
        Me.dtpProModFInicio.Size = New System.Drawing.Size(239, 20)
        Me.dtpProModFInicio.TabIndex = 211
        '
        'txtProModEnc
        '
        Me.txtProModEnc.Enabled = False
        Me.txtProModEnc.Location = New System.Drawing.Point(185, 389)
        Me.txtProModEnc.Name = "txtProModEnc"
        Me.txtProModEnc.Size = New System.Drawing.Size(239, 20)
        Me.txtProModEnc.TabIndex = 210
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(65, 392)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(81, 13)
        Me.Label7.TabIndex = 209
        Me.Label7.Text = "Encargado (Tú)"
        '
        'txtProModPres
        '
        Me.txtProModPres.Location = New System.Drawing.Point(183, 233)
        Me.txtProModPres.Name = "txtProModPres"
        Me.txtProModPres.Size = New System.Drawing.Size(239, 20)
        Me.txtProModPres.TabIndex = 208
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(63, 236)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(66, 13)
        Me.Label3.TabIndex = 207
        Me.Label3.Text = "Presupuesto"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(320, 488)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(104, 26)
        Me.Button1.TabIndex = 206
        Me.Button1.Text = "Cancelar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(63, 121)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(80, 13)
        Me.Label2.TabIndex = 205
        Me.Label2.Text = "Fecha de Inicio"
        '
        'btnProModOK
        '
        Me.btnProModOK.Location = New System.Drawing.Point(66, 452)
        Me.btnProModOK.Name = "btnProModOK"
        Me.btnProModOK.Size = New System.Drawing.Size(358, 30)
        Me.btnProModOK.TabIndex = 204
        Me.btnProModOK.Text = "Guardar Cambios"
        Me.btnProModOK.UseVisualStyleBackColor = True
        '
        'txtProModNom
        '
        Me.txtProModNom.Location = New System.Drawing.Point(183, 82)
        Me.txtProModNom.Name = "txtProModNom"
        Me.txtProModNom.Size = New System.Drawing.Size(239, 20)
        Me.txtProModNom.TabIndex = 203
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(63, 201)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(108, 13)
        Me.Label6.TabIndex = 202
        Me.Label6.Text = "Fecha Estimada Final"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(63, 85)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(44, 13)
        Me.Label4.TabIndex = 201
        Me.Label4.Text = "Nombre"
        '
        'txtProModID
        '
        Me.txtProModID.Location = New System.Drawing.Point(183, 47)
        Me.txtProModID.Name = "txtProModID"
        Me.txtProModID.Size = New System.Drawing.Size(239, 20)
        Me.txtProModID.TabIndex = 200
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(62, 50)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(78, 13)
        Me.Label1.TabIndex = 199
        Me.Label1.Text = "ID de Proyecto"
        '
        'btnProModNext
        '
        Me.btnProModNext.Location = New System.Drawing.Point(615, 38)
        Me.btnProModNext.Name = "btnProModNext"
        Me.btnProModNext.Size = New System.Drawing.Size(42, 476)
        Me.btnProModNext.TabIndex = 223
        Me.btnProModNext.Text = ">"
        Me.btnProModNext.UseVisualStyleBackColor = True
        '
        'btnProModPrev
        '
        Me.btnProModPrev.Location = New System.Drawing.Point(12, 37)
        Me.btnProModPrev.Name = "btnProModPrev"
        Me.btnProModPrev.Size = New System.Drawing.Size(42, 476)
        Me.btnProModPrev.TabIndex = 224
        Me.btnProModPrev.Text = "<"
        Me.btnProModPrev.UseVisualStyleBackColor = True
        '
        'lblUsuModTotalReg
        '
        Me.lblUsuModTotalReg.AutoSize = True
        Me.lblUsuModTotalReg.Location = New System.Drawing.Point(276, 9)
        Me.lblUsuModTotalReg.Name = "lblUsuModTotalReg"
        Me.lblUsuModTotalReg.Size = New System.Drawing.Size(103, 13)
        Me.lblUsuModTotalReg.TabIndex = 225
        Me.lblUsuModTotalReg.Text = "ID de Departamento"
        '
        'btnProModDEL
        '
        Me.btnProModDEL.Location = New System.Drawing.Point(68, 488)
        Me.btnProModDEL.Name = "btnProModDEL"
        Me.btnProModDEL.Size = New System.Drawing.Size(246, 25)
        Me.btnProModDEL.TabIndex = 226
        Me.btnProModDEL.Text = "Eliminar Registro"
        Me.btnProModDEL.UseVisualStyleBackColor = True
        '
        'dtpProModFREALFinal
        '
        Me.dtpProModFREALFinal.CustomFormat = "yyyy-MM-dd"
        Me.dtpProModFREALFinal.Enabled = False
        Me.dtpProModFREALFinal.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpProModFREALFinal.Location = New System.Drawing.Point(183, 157)
        Me.dtpProModFREALFinal.Name = "dtpProModFREALFinal"
        Me.dtpProModFREALFinal.Size = New System.Drawing.Size(239, 20)
        Me.dtpProModFREALFinal.TabIndex = 228
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(63, 157)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(87, 13)
        Me.Label9.TabIndex = 227
        Me.Label9.Text = "Fecha Finalizada"
        '
        'txtProHorasReales
        '
        Me.txtProHorasReales.Enabled = False
        Me.txtProHorasReales.Location = New System.Drawing.Point(185, 311)
        Me.txtProHorasReales.Name = "txtProHorasReales"
        Me.txtProHorasReales.Size = New System.Drawing.Size(239, 20)
        Me.txtProHorasReales.TabIndex = 230
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(65, 314)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(71, 13)
        Me.Label10.TabIndex = 229
        Me.Label10.Text = "Horas Reales"
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Location = New System.Drawing.Point(68, 429)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(121, 17)
        Me.CheckBox1.TabIndex = 231
        Me.CheckBox1.Text = "Estado del Proyecto"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'lblestado
        '
        Me.lblestado.AutoSize = True
        Me.lblestado.Location = New System.Drawing.Point(216, 429)
        Me.lblestado.Name = "lblestado"
        Me.lblestado.Size = New System.Drawing.Size(138, 13)
        Me.lblestado.TabIndex = 232
        Me.lblestado.Text = "Se encuentra actualmente: "
        '
        'FrmProyectoMod
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(670, 527)
        Me.Controls.Add(Me.lblestado)
        Me.Controls.Add(Me.CheckBox1)
        Me.Controls.Add(Me.txtProHorasReales)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.dtpProModFREALFinal)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.btnProModDEL)
        Me.Controls.Add(Me.lblUsuModTotalReg)
        Me.Controls.Add(Me.btnProModPrev)
        Me.Controls.Add(Me.btnProModNext)
        Me.Controls.Add(Me.cboProModDep)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txtProModHoras)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.btnUsuDelComp)
        Me.Controls.Add(Me.btnUsuAddComp)
        Me.Controls.Add(Me.lstUsuModSel)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.lstUsuModDisp)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.dtpProModFEFinal)
        Me.Controls.Add(Me.dtpProModFInicio)
        Me.Controls.Add(Me.txtProModEnc)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtProModPres)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnProModOK)
        Me.Controls.Add(Me.txtProModNom)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtProModID)
        Me.Controls.Add(Me.Label1)
        Me.Name = "FrmProyectoMod"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Modificar Mis proyectos"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cboProModDep As ComboBox
    Friend WithEvents Label8 As Label
    Friend WithEvents txtProModHoras As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents btnUsuDelComp As Button
    Friend WithEvents btnUsuAddComp As Button
    Friend WithEvents lstUsuModSel As ListBox
    Friend WithEvents Label12 As Label
    Friend WithEvents lstUsuModDisp As ListBox
    Friend WithEvents Label11 As Label
    Friend WithEvents dtpProModFEFinal As DateTimePicker
    Friend WithEvents dtpProModFInicio As DateTimePicker
    Friend WithEvents txtProModEnc As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents txtProModPres As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents btnProModOK As Button
    Friend WithEvents txtProModNom As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtProModID As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents btnProModNext As Button
    Friend WithEvents btnProModPrev As Button
    Friend WithEvents lblUsuModTotalReg As Label
    Friend WithEvents btnProModDEL As Button
    Friend WithEvents dtpProModFREALFinal As DateTimePicker
    Friend WithEvents Label9 As Label
    Friend WithEvents txtProHorasReales As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents lblestado As Label
End Class
