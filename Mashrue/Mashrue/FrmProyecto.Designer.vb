<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmProyecto
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
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnProAddOK = New System.Windows.Forms.Button()
        Me.txtProAddNom = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtProAddID = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtProAddPres = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtProAddEnc = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.dtpProAddFInicio = New System.Windows.Forms.DateTimePicker()
        Me.dtpProAddFEFinal = New System.Windows.Forms.DateTimePicker()
        Me.btnUsuDelComp = New System.Windows.Forms.Button()
        Me.btnUsuAddComp = New System.Windows.Forms.Button()
        Me.lstUsuAddSel = New System.Windows.Forms.ListBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.lstUsuAddDisp = New System.Windows.Forms.ListBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtProAddHoras = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cboProModDep = New System.Windows.Forms.ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(276, 467)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(104, 26)
        Me.Button1.TabIndex = 180
        Me.Button1.Text = "Cancelar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(19, 100)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(80, 13)
        Me.Label2.TabIndex = 179
        Me.Label2.Text = "Fecha de Inicio"
        '
        'btnProAddOK
        '
        Me.btnProAddOK.Location = New System.Drawing.Point(22, 431)
        Me.btnProAddOK.Name = "btnProAddOK"
        Me.btnProAddOK.Size = New System.Drawing.Size(358, 30)
        Me.btnProAddOK.TabIndex = 178
        Me.btnProAddOK.Text = "Agregar Proyectos"
        Me.btnProAddOK.UseVisualStyleBackColor = True
        '
        'txtProAddNom
        '
        Me.txtProAddNom.Location = New System.Drawing.Point(139, 61)
        Me.txtProAddNom.Name = "txtProAddNom"
        Me.txtProAddNom.Size = New System.Drawing.Size(239, 20)
        Me.txtProAddNom.TabIndex = 176
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(19, 180)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(108, 13)
        Me.Label6.TabIndex = 174
        Me.Label6.Text = "Fecha Estimada Final"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(19, 64)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(44, 13)
        Me.Label4.TabIndex = 173
        Me.Label4.Text = "Nombre"
        '
        'txtProAddID
        '
        Me.txtProAddID.Location = New System.Drawing.Point(139, 26)
        Me.txtProAddID.Name = "txtProAddID"
        Me.txtProAddID.Size = New System.Drawing.Size(239, 20)
        Me.txtProAddID.TabIndex = 172
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(18, 29)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(78, 13)
        Me.Label1.TabIndex = 171
        Me.Label1.Text = "ID de Proyecto"
        '
        'txtProAddPres
        '
        Me.txtProAddPres.Location = New System.Drawing.Point(139, 244)
        Me.txtProAddPres.Name = "txtProAddPres"
        Me.txtProAddPres.Size = New System.Drawing.Size(239, 20)
        Me.txtProAddPres.TabIndex = 182
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(19, 247)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(66, 13)
        Me.Label3.TabIndex = 181
        Me.Label3.Text = "Presupuesto"
        '
        'txtProAddEnc
        '
        Me.txtProAddEnc.Location = New System.Drawing.Point(139, 377)
        Me.txtProAddEnc.Name = "txtProAddEnc"
        Me.txtProAddEnc.Size = New System.Drawing.Size(239, 20)
        Me.txtProAddEnc.TabIndex = 186
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(19, 380)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(81, 13)
        Me.Label7.TabIndex = 185
        Me.Label7.Text = "Encargado (Tú)"
        '
        'dtpProAddFInicio
        '
        Me.dtpProAddFInicio.CustomFormat = "yyyy-MM-dd"
        Me.dtpProAddFInicio.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpProAddFInicio.Location = New System.Drawing.Point(139, 100)
        Me.dtpProAddFInicio.Name = "dtpProAddFInicio"
        Me.dtpProAddFInicio.Size = New System.Drawing.Size(239, 20)
        Me.dtpProAddFInicio.TabIndex = 187
        '
        'dtpProAddFEFinal
        '
        Me.dtpProAddFEFinal.CustomFormat = "yyyy-MM-dd"
        Me.dtpProAddFEFinal.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpProAddFEFinal.Location = New System.Drawing.Point(139, 174)
        Me.dtpProAddFEFinal.Name = "dtpProAddFEFinal"
        Me.dtpProAddFEFinal.Size = New System.Drawing.Size(239, 20)
        Me.dtpProAddFEFinal.TabIndex = 188
        '
        'btnUsuDelComp
        '
        Me.btnUsuDelComp.Location = New System.Drawing.Point(400, 314)
        Me.btnUsuDelComp.Name = "btnUsuDelComp"
        Me.btnUsuDelComp.Size = New System.Drawing.Size(160, 23)
        Me.btnUsuDelComp.TabIndex = 194
        Me.btnUsuDelComp.Text = "Eliminar Comp."
        Me.btnUsuDelComp.UseVisualStyleBackColor = True
        '
        'btnUsuAddComp
        '
        Me.btnUsuAddComp.Location = New System.Drawing.Point(400, 287)
        Me.btnUsuAddComp.Name = "btnUsuAddComp"
        Me.btnUsuAddComp.Size = New System.Drawing.Size(160, 23)
        Me.btnUsuAddComp.TabIndex = 193
        Me.btnUsuAddComp.Text = "Agregar Comp."
        Me.btnUsuAddComp.UseVisualStyleBackColor = True
        '
        'lstUsuAddSel
        '
        Me.lstUsuAddSel.FormattingEnabled = True
        Me.lstUsuAddSel.Location = New System.Drawing.Point(398, 358)
        Me.lstUsuAddSel.Name = "lstUsuAddSel"
        Me.lstUsuAddSel.Size = New System.Drawing.Size(162, 134)
        Me.lstUsuAddSel.TabIndex = 192
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(395, 342)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(139, 13)
        Me.Label12.TabIndex = 191
        Me.Label12.Text = "Compañeros Seleccionadas"
        '
        'lstUsuAddDisp
        '
        Me.lstUsuAddDisp.FormattingEnabled = True
        Me.lstUsuAddDisp.Location = New System.Drawing.Point(399, 33)
        Me.lstUsuAddDisp.Name = "lstUsuAddDisp"
        Me.lstUsuAddDisp.Size = New System.Drawing.Size(162, 238)
        Me.lstUsuAddDisp.TabIndex = 190
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(396, 17)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(123, 13)
        Me.Label11.TabIndex = 189
        Me.Label11.Text = "Compañeros Disponibles"
        '
        'txtProAddHoras
        '
        Me.txtProAddHoras.Location = New System.Drawing.Point(141, 289)
        Me.txtProAddHoras.Name = "txtProAddHoras"
        Me.txtProAddHoras.Size = New System.Drawing.Size(239, 20)
        Me.txtProAddHoras.TabIndex = 196
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(21, 292)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(86, 13)
        Me.Label5.TabIndex = 195
        Me.Label5.Text = "Horas Estimadas"
        '
        'cboProModDep
        '
        Me.cboProModDep.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboProModDep.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.cboProModDep.FormattingEnabled = True
        Me.cboProModDep.Location = New System.Drawing.Point(139, 339)
        Me.cboProModDep.Name = "cboProModDep"
        Me.cboProModDep.Size = New System.Drawing.Size(239, 21)
        Me.cboProModDep.TabIndex = 198
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(19, 342)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(74, 13)
        Me.Label8.TabIndex = 197
        Me.Label8.Text = "Departamento"
        '
        'FrmProyecto
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(595, 525)
        Me.Controls.Add(Me.cboProModDep)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txtProAddHoras)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.btnUsuDelComp)
        Me.Controls.Add(Me.btnUsuAddComp)
        Me.Controls.Add(Me.lstUsuAddSel)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.lstUsuAddDisp)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.dtpProAddFEFinal)
        Me.Controls.Add(Me.dtpProAddFInicio)
        Me.Controls.Add(Me.txtProAddEnc)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtProAddPres)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnProAddOK)
        Me.Controls.Add(Me.txtProAddNom)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtProAddID)
        Me.Controls.Add(Me.Label1)
        Me.Name = "FrmProyecto"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Agregar Proyecto"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents btnProAddOK As Button
    Friend WithEvents txtProAddNom As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtProAddID As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtProAddPres As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtProAddEnc As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents dtpProAddFInicio As DateTimePicker
    Friend WithEvents dtpProAddFEFinal As DateTimePicker
    Friend WithEvents btnUsuDelComp As Button
    Friend WithEvents btnUsuAddComp As Button
    Friend WithEvents lstUsuAddSel As ListBox
    Friend WithEvents Label12 As Label
    Friend WithEvents lstUsuAddDisp As ListBox
    Friend WithEvents Label11 As Label
    Friend WithEvents txtProAddHoras As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents cboProModDep As ComboBox
    Friend WithEvents Label8 As Label
End Class
