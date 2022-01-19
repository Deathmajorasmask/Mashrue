<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmActividad
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
        Me.txtActAddDescp = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtActAddID = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dtpActAddFEFinal = New System.Windows.Forms.DateTimePicker()
        Me.dtpActAddFInicio = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtActAddHoras = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.dtgActAddProyectos = New System.Windows.Forms.DataGridView()
        Me.cboActADDTipo = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtActAddIDAct = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.btnActAddOK = New System.Windows.Forms.Button()
        Me.btnActAddCancel = New System.Windows.Forms.Button()
        CType(Me.dtgActAddProyectos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtActAddDescp
        '
        Me.txtActAddDescp.Location = New System.Drawing.Point(22, 122)
        Me.txtActAddDescp.Multiline = True
        Me.txtActAddDescp.Name = "txtActAddDescp"
        Me.txtActAddDescp.Size = New System.Drawing.Size(329, 157)
        Me.txtActAddDescp.TabIndex = 2
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(19, 96)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(63, 13)
        Me.Label4.TabIndex = 179
        Me.Label4.Text = "Descripcion"
        '
        'txtActAddID
        '
        Me.txtActAddID.Location = New System.Drawing.Point(112, 27)
        Me.txtActAddID.Name = "txtActAddID"
        Me.txtActAddID.Size = New System.Drawing.Size(239, 20)
        Me.txtActAddID.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(18, 30)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(78, 13)
        Me.Label1.TabIndex = 177
        Me.Label1.Text = "ID de Proyecto"
        '
        'dtpActAddFEFinal
        '
        Me.dtpActAddFEFinal.CustomFormat = "yyyy-MM-dd"
        Me.dtpActAddFEFinal.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpActAddFEFinal.Location = New System.Drawing.Point(144, 337)
        Me.dtpActAddFEFinal.Name = "dtpActAddFEFinal"
        Me.dtpActAddFEFinal.Size = New System.Drawing.Size(207, 20)
        Me.dtpActAddFEFinal.TabIndex = 4
        '
        'dtpActAddFInicio
        '
        Me.dtpActAddFInicio.CustomFormat = "yyyy-MM-dd"
        Me.dtpActAddFInicio.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpActAddFInicio.Location = New System.Drawing.Point(144, 301)
        Me.dtpActAddFInicio.Name = "dtpActAddFInicio"
        Me.dtpActAddFInicio.Size = New System.Drawing.Size(207, 20)
        Me.dtpActAddFInicio.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(24, 301)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(80, 13)
        Me.Label2.TabIndex = 190
        Me.Label2.Text = "Fecha de Inicio"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(24, 343)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(108, 13)
        Me.Label6.TabIndex = 189
        Me.Label6.Text = "Fecha Estimada Final"
        '
        'txtActAddHoras
        '
        Me.txtActAddHoras.Location = New System.Drawing.Point(144, 379)
        Me.txtActAddHoras.Name = "txtActAddHoras"
        Me.txtActAddHoras.Size = New System.Drawing.Size(207, 20)
        Me.txtActAddHoras.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(24, 382)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(85, 13)
        Me.Label3.TabIndex = 193
        Me.Label3.Text = "Horas estimadas"
        '
        'dtgActAddProyectos
        '
        Me.dtgActAddProyectos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtgActAddProyectos.Location = New System.Drawing.Point(392, 27)
        Me.dtgActAddProyectos.Name = "dtgActAddProyectos"
        Me.dtgActAddProyectos.Size = New System.Drawing.Size(242, 493)
        Me.dtgActAddProyectos.TabIndex = 7
        '
        'cboActADDTipo
        '
        Me.cboActADDTipo.FormattingEnabled = True
        Me.cboActADDTipo.Location = New System.Drawing.Point(144, 415)
        Me.cboActADDTipo.Name = "cboActADDTipo"
        Me.cboActADDTipo.Size = New System.Drawing.Size(207, 21)
        Me.cboActADDTipo.TabIndex = 6
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(24, 418)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(28, 13)
        Me.Label5.TabIndex = 198
        Me.Label5.Text = "Tipo"
        '
        'txtActAddIDAct
        '
        Me.txtActAddIDAct.Location = New System.Drawing.Point(112, 62)
        Me.txtActAddIDAct.Name = "txtActAddIDAct"
        Me.txtActAddIDAct.Size = New System.Drawing.Size(239, 20)
        Me.txtActAddIDAct.TabIndex = 1
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(18, 65)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(80, 13)
        Me.Label7.TabIndex = 199
        Me.Label7.Text = "ID de Actividad"
        '
        'btnActAddOK
        '
        Me.btnActAddOK.Location = New System.Drawing.Point(27, 464)
        Me.btnActAddOK.Name = "btnActAddOK"
        Me.btnActAddOK.Size = New System.Drawing.Size(323, 26)
        Me.btnActAddOK.TabIndex = 8
        Me.btnActAddOK.Text = "Registrar Actividad"
        Me.btnActAddOK.UseVisualStyleBackColor = True
        '
        'btnActAddCancel
        '
        Me.btnActAddCancel.Location = New System.Drawing.Point(250, 496)
        Me.btnActAddCancel.Name = "btnActAddCancel"
        Me.btnActAddCancel.Size = New System.Drawing.Size(100, 26)
        Me.btnActAddCancel.TabIndex = 9
        Me.btnActAddCancel.Text = "Cancel"
        Me.btnActAddCancel.UseVisualStyleBackColor = True
        '
        'FrmActividad
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(665, 532)
        Me.Controls.Add(Me.btnActAddCancel)
        Me.Controls.Add(Me.btnActAddOK)
        Me.Controls.Add(Me.txtActAddIDAct)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.cboActADDTipo)
        Me.Controls.Add(Me.dtgActAddProyectos)
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
        Me.Name = "FrmActividad"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Agregar Actividad"
        CType(Me.dtgActAddProyectos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtActAddDescp As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtActAddID As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents dtpActAddFEFinal As DateTimePicker
    Friend WithEvents dtpActAddFInicio As DateTimePicker
    Friend WithEvents Label2 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents txtActAddHoras As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents dtgActAddProyectos As DataGridView
    Friend WithEvents cboActADDTipo As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtActAddIDAct As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents btnActAddOK As Button
    Friend WithEvents btnActAddCancel As Button
End Class
