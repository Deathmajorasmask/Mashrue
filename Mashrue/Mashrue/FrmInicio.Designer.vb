<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmInicio
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnIndexProHis = New System.Windows.Forms.Button()
        Me.btnIndexAdminActProy = New System.Windows.Forms.Button()
        Me.btnIndexProMod = New System.Windows.Forms.Button()
        Me.btnIndexProNew = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btnIndexAdminAct = New System.Windows.Forms.Button()
        Me.btnIndexActNew = New System.Windows.Forms.Button()
        Me.btnMyProfile = New System.Windows.Forms.Button()
        Me.btnIndexAdmin = New System.Windows.Forms.Button()
        Me.btnReportIndex = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(100, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Proyectos recientes"
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(15, 37)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(595, 363)
        Me.DataGridView1.TabIndex = 1
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnIndexProHis)
        Me.GroupBox1.Controls.Add(Me.btnIndexAdminActProy)
        Me.GroupBox1.Controls.Add(Me.btnIndexProMod)
        Me.GroupBox1.Controls.Add(Me.btnIndexProNew)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 420)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(597, 69)
        Me.GroupBox1.TabIndex = 4
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Proyecto"
        '
        'btnIndexProHis
        '
        Me.btnIndexProHis.Location = New System.Drawing.Point(457, 19)
        Me.btnIndexProHis.Name = "btnIndexProHis"
        Me.btnIndexProHis.Size = New System.Drawing.Size(134, 37)
        Me.btnIndexProHis.TabIndex = 7
        Me.btnIndexProHis.Text = "Historial"
        Me.btnIndexProHis.UseVisualStyleBackColor = True
        '
        'btnIndexAdminActProy
        '
        Me.btnIndexAdminActProy.Location = New System.Drawing.Point(306, 19)
        Me.btnIndexAdminActProy.Name = "btnIndexAdminActProy"
        Me.btnIndexAdminActProy.Size = New System.Drawing.Size(134, 37)
        Me.btnIndexAdminActProy.TabIndex = 6
        Me.btnIndexAdminActProy.Text = "Administrar"
        Me.btnIndexAdminActProy.UseVisualStyleBackColor = True
        '
        'btnIndexProMod
        '
        Me.btnIndexProMod.Location = New System.Drawing.Point(156, 19)
        Me.btnIndexProMod.Name = "btnIndexProMod"
        Me.btnIndexProMod.Size = New System.Drawing.Size(134, 37)
        Me.btnIndexProMod.TabIndex = 5
        Me.btnIndexProMod.Text = "Modificar existente"
        Me.btnIndexProMod.UseVisualStyleBackColor = True
        '
        'btnIndexProNew
        '
        Me.btnIndexProNew.Location = New System.Drawing.Point(6, 19)
        Me.btnIndexProNew.Name = "btnIndexProNew"
        Me.btnIndexProNew.Size = New System.Drawing.Size(134, 37)
        Me.btnIndexProNew.TabIndex = 0
        Me.btnIndexProNew.Text = "Nuevo"
        Me.btnIndexProNew.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.btnIndexAdminAct)
        Me.GroupBox2.Controls.Add(Me.btnIndexActNew)
        Me.GroupBox2.Location = New System.Drawing.Point(15, 510)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(302, 69)
        Me.GroupBox2.TabIndex = 5
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Actividad"
        '
        'btnIndexAdminAct
        '
        Me.btnIndexAdminAct.Location = New System.Drawing.Point(153, 19)
        Me.btnIndexAdminAct.Name = "btnIndexAdminAct"
        Me.btnIndexAdminAct.Size = New System.Drawing.Size(134, 37)
        Me.btnIndexAdminAct.TabIndex = 6
        Me.btnIndexAdminAct.Text = "Ver mis actividades"
        Me.btnIndexAdminAct.UseVisualStyleBackColor = True
        '
        'btnIndexActNew
        '
        Me.btnIndexActNew.Location = New System.Drawing.Point(6, 19)
        Me.btnIndexActNew.Name = "btnIndexActNew"
        Me.btnIndexActNew.Size = New System.Drawing.Size(134, 37)
        Me.btnIndexActNew.TabIndex = 0
        Me.btnIndexActNew.Text = "Registrar"
        Me.btnIndexActNew.UseVisualStyleBackColor = True
        '
        'btnMyProfile
        '
        Me.btnMyProfile.Location = New System.Drawing.Point(171, 585)
        Me.btnMyProfile.Name = "btnMyProfile"
        Me.btnMyProfile.Size = New System.Drawing.Size(432, 37)
        Me.btnMyProfile.TabIndex = 7
        Me.btnMyProfile.Text = "Mi cuenta"
        Me.btnMyProfile.UseVisualStyleBackColor = True
        '
        'btnIndexAdmin
        '
        Me.btnIndexAdmin.Location = New System.Drawing.Point(21, 585)
        Me.btnIndexAdmin.Name = "btnIndexAdmin"
        Me.btnIndexAdmin.Size = New System.Drawing.Size(134, 37)
        Me.btnIndexAdmin.TabIndex = 8
        Me.btnIndexAdmin.Text = "Opc. Administrador"
        Me.btnIndexAdmin.UseVisualStyleBackColor = True
        '
        'btnReportIndex
        '
        Me.btnReportIndex.Location = New System.Drawing.Point(469, 529)
        Me.btnReportIndex.Name = "btnReportIndex"
        Me.btnReportIndex.Size = New System.Drawing.Size(134, 37)
        Me.btnReportIndex.TabIndex = 9
        Me.btnReportIndex.Text = "Reportes"
        Me.btnReportIndex.UseVisualStyleBackColor = True
        '
        'FrmInicio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(622, 634)
        Me.Controls.Add(Me.btnReportIndex)
        Me.Controls.Add(Me.btnIndexAdmin)
        Me.Controls.Add(Me.btnMyProfile)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Label1)
        Me.Name = "FrmInicio"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Inicio"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btnIndexProHis As Button
    Friend WithEvents btnIndexAdminActProy As Button
    Friend WithEvents btnIndexProMod As Button
    Friend WithEvents btnIndexProNew As Button
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents btnIndexAdminAct As Button
    Friend WithEvents btnIndexActNew As Button
    Friend WithEvents btnMyProfile As Button
    Friend WithEvents btnIndexAdmin As Button
    Friend WithEvents btnReportIndex As Button
End Class
