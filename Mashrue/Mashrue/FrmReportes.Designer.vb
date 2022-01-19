<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmReportes
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
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnConsOne = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.ComboBox2 = New System.Windows.Forms.ComboBox()
        Me.btnConsultaTwo = New System.Windows.Forms.Button()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.dtpReportesFin = New System.Windows.Forms.DateTimePicker()
        Me.dtpReportesIni = New System.Windows.Forms.DateTimePicker()
        Me.btnConsThree = New System.Windows.Forms.Button()
        Me.btnConRetrasados = New System.Windows.Forms.Button()
        Me.ComboBox3 = New System.Windows.Forms.ComboBox()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(12, 12)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(628, 299)
        Me.DataGridView1.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 326)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(11, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "*"
        '
        'btnConsOne
        '
        Me.btnConsOne.Location = New System.Drawing.Point(422, 19)
        Me.btnConsOne.Name = "btnConsOne"
        Me.btnConsOne.Size = New System.Drawing.Size(179, 34)
        Me.btnConsOne.TabIndex = 2
        Me.btnConsOne.Text = "Calcula las horas del proyecto seleccionado"
        Me.btnConsOne.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.ComboBox1)
        Me.GroupBox1.Controls.Add(Me.btnConsOne)
        Me.GroupBox1.Location = New System.Drawing.Point(15, 436)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(607, 69)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Consulta de Horas de mis proyectos"
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(21, 29)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(235, 21)
        Me.ComboBox1.TabIndex = 3
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.ComboBox3)
        Me.GroupBox2.Controls.Add(Me.ComboBox2)
        Me.GroupBox2.Controls.Add(Me.btnConsultaTwo)
        Me.GroupBox2.Location = New System.Drawing.Point(15, 524)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(607, 69)
        Me.GroupBox2.TabIndex = 4
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Consulta las horas por colaborador"
        '
        'ComboBox2
        '
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Location = New System.Drawing.Point(21, 29)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(187, 21)
        Me.ComboBox2.TabIndex = 3
        '
        'btnConsultaTwo
        '
        Me.btnConsultaTwo.Location = New System.Drawing.Point(422, 19)
        Me.btnConsultaTwo.Name = "btnConsultaTwo"
        Me.btnConsultaTwo.Size = New System.Drawing.Size(179, 34)
        Me.btnConsultaTwo.TabIndex = 2
        Me.btnConsultaTwo.Text = "Calcula las horas del colaborador seleccionado"
        Me.btnConsultaTwo.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Label3)
        Me.GroupBox3.Controls.Add(Me.Label2)
        Me.GroupBox3.Controls.Add(Me.dtpReportesFin)
        Me.GroupBox3.Controls.Add(Me.dtpReportesIni)
        Me.GroupBox3.Controls.Add(Me.btnConsThree)
        Me.GroupBox3.Location = New System.Drawing.Point(15, 351)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(607, 69)
        Me.GroupBox3.TabIndex = 5
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Presupuestos Vs Real"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(215, 33)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(59, 13)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Termina el:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(27, 33)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(46, 13)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Inicia el:"
        '
        'dtpReportesFin
        '
        Me.dtpReportesFin.CustomFormat = "yyyy-MM-dd"
        Me.dtpReportesFin.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpReportesFin.Location = New System.Drawing.Point(276, 33)
        Me.dtpReportesFin.Name = "dtpReportesFin"
        Me.dtpReportesFin.Size = New System.Drawing.Size(129, 20)
        Me.dtpReportesFin.TabIndex = 7
        '
        'dtpReportesIni
        '
        Me.dtpReportesIni.CustomFormat = "yyyy-MM-dd"
        Me.dtpReportesIni.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpReportesIni.Location = New System.Drawing.Point(79, 33)
        Me.dtpReportesIni.Name = "dtpReportesIni"
        Me.dtpReportesIni.Size = New System.Drawing.Size(129, 20)
        Me.dtpReportesIni.TabIndex = 3
        '
        'btnConsThree
        '
        Me.btnConsThree.Location = New System.Drawing.Point(422, 19)
        Me.btnConsThree.Name = "btnConsThree"
        Me.btnConsThree.Size = New System.Drawing.Size(179, 34)
        Me.btnConsThree.TabIndex = 2
        Me.btnConsThree.Text = "Ver las diferencias"
        Me.btnConsThree.UseVisualStyleBackColor = True
        '
        'btnConRetrasados
        '
        Me.btnConRetrasados.Location = New System.Drawing.Point(437, 317)
        Me.btnConRetrasados.Name = "btnConRetrasados"
        Me.btnConRetrasados.Size = New System.Drawing.Size(179, 28)
        Me.btnConRetrasados.TabIndex = 6
        Me.btnConRetrasados.Text = "Proyecto retrasados"
        Me.btnConRetrasados.UseVisualStyleBackColor = True
        '
        'ComboBox3
        '
        Me.ComboBox3.FormattingEnabled = True
        Me.ComboBox3.Location = New System.Drawing.Point(214, 29)
        Me.ComboBox3.Name = "ComboBox3"
        Me.ComboBox3.Size = New System.Drawing.Size(191, 21)
        Me.ComboBox3.TabIndex = 7
        '
        'FrmReportes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(652, 614)
        Me.Controls.Add(Me.btnConRetrasados)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "FrmReportes"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Reporte"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents btnConsOne As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents ComboBox2 As ComboBox
    Friend WithEvents btnConsultaTwo As Button
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents Label2 As Label
    Friend WithEvents dtpReportesIni As DateTimePicker
    Friend WithEvents btnConsThree As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents dtpReportesFin As DateTimePicker
    Friend WithEvents btnConRetrasados As Button
    Friend WithEvents ComboBox3 As ComboBox
End Class
