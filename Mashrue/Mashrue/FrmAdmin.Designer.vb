<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmAdmin
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
        Me.Button5 = New System.Windows.Forms.Button()
        Me.btnAdminConUsu = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnAdminModUsu = New System.Windows.Forms.Button()
        Me.btnAdminAddUsu = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btnAdminModDep = New System.Windows.Forms.Button()
        Me.btnAdminConDep = New System.Windows.Forms.Button()
        Me.btnAdminAddDep = New System.Windows.Forms.Button()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.btnAdminModTAct = New System.Windows.Forms.Button()
        Me.btnAdminConTAct = New System.Windows.Forms.Button()
        Me.btnAdminAddTAct = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(57, 515)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(360, 23)
        Me.Button5.TabIndex = 9
        Me.Button5.Text = "Cancelar"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'btnAdminConUsu
        '
        Me.btnAdminConUsu.Location = New System.Drawing.Point(20, 92)
        Me.btnAdminConUsu.Name = "btnAdminConUsu"
        Me.btnAdminConUsu.Size = New System.Drawing.Size(351, 26)
        Me.btnAdminConUsu.TabIndex = 2
        Me.btnAdminConUsu.Text = "Consultas"
        Me.btnAdminConUsu.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnAdminModUsu)
        Me.GroupBox1.Controls.Add(Me.btnAdminConUsu)
        Me.GroupBox1.Controls.Add(Me.btnAdminAddUsu)
        Me.GroupBox1.Location = New System.Drawing.Point(46, 36)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(393, 142)
        Me.GroupBox1.TabIndex = 5
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Usuarios"
        '
        'btnAdminModUsu
        '
        Me.btnAdminModUsu.Location = New System.Drawing.Point(20, 29)
        Me.btnAdminModUsu.Name = "btnAdminModUsu"
        Me.btnAdminModUsu.Size = New System.Drawing.Size(351, 26)
        Me.btnAdminModUsu.TabIndex = 0
        Me.btnAdminModUsu.Text = "Modificación"
        Me.btnAdminModUsu.UseVisualStyleBackColor = True
        '
        'btnAdminAddUsu
        '
        Me.btnAdminAddUsu.Location = New System.Drawing.Point(20, 61)
        Me.btnAdminAddUsu.Name = "btnAdminAddUsu"
        Me.btnAdminAddUsu.Size = New System.Drawing.Size(351, 25)
        Me.btnAdminAddUsu.TabIndex = 1
        Me.btnAdminAddUsu.Text = "Agregar"
        Me.btnAdminAddUsu.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.btnAdminModDep)
        Me.GroupBox2.Controls.Add(Me.btnAdminConDep)
        Me.GroupBox2.Controls.Add(Me.btnAdminAddDep)
        Me.GroupBox2.Location = New System.Drawing.Point(46, 197)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(393, 142)
        Me.GroupBox2.TabIndex = 9
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Departamentos"
        '
        'btnAdminModDep
        '
        Me.btnAdminModDep.Location = New System.Drawing.Point(20, 29)
        Me.btnAdminModDep.Name = "btnAdminModDep"
        Me.btnAdminModDep.Size = New System.Drawing.Size(351, 26)
        Me.btnAdminModDep.TabIndex = 3
        Me.btnAdminModDep.Text = "Modificación"
        Me.btnAdminModDep.UseVisualStyleBackColor = True
        '
        'btnAdminConDep
        '
        Me.btnAdminConDep.Location = New System.Drawing.Point(20, 92)
        Me.btnAdminConDep.Name = "btnAdminConDep"
        Me.btnAdminConDep.Size = New System.Drawing.Size(351, 26)
        Me.btnAdminConDep.TabIndex = 5
        Me.btnAdminConDep.Text = "Consultas"
        Me.btnAdminConDep.UseVisualStyleBackColor = True
        '
        'btnAdminAddDep
        '
        Me.btnAdminAddDep.Location = New System.Drawing.Point(20, 61)
        Me.btnAdminAddDep.Name = "btnAdminAddDep"
        Me.btnAdminAddDep.Size = New System.Drawing.Size(351, 25)
        Me.btnAdminAddDep.TabIndex = 4
        Me.btnAdminAddDep.Text = "Agregar"
        Me.btnAdminAddDep.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.btnAdminModTAct)
        Me.GroupBox3.Controls.Add(Me.btnAdminConTAct)
        Me.GroupBox3.Controls.Add(Me.btnAdminAddTAct)
        Me.GroupBox3.Location = New System.Drawing.Point(46, 350)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(393, 142)
        Me.GroupBox3.TabIndex = 10
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Tipos de Actividad"
        '
        'btnAdminModTAct
        '
        Me.btnAdminModTAct.Location = New System.Drawing.Point(20, 29)
        Me.btnAdminModTAct.Name = "btnAdminModTAct"
        Me.btnAdminModTAct.Size = New System.Drawing.Size(351, 26)
        Me.btnAdminModTAct.TabIndex = 6
        Me.btnAdminModTAct.Text = "Modificación"
        Me.btnAdminModTAct.UseVisualStyleBackColor = True
        '
        'btnAdminConTAct
        '
        Me.btnAdminConTAct.Location = New System.Drawing.Point(20, 92)
        Me.btnAdminConTAct.Name = "btnAdminConTAct"
        Me.btnAdminConTAct.Size = New System.Drawing.Size(351, 26)
        Me.btnAdminConTAct.TabIndex = 8
        Me.btnAdminConTAct.Text = "Consultas"
        Me.btnAdminConTAct.UseVisualStyleBackColor = True
        '
        'btnAdminAddTAct
        '
        Me.btnAdminAddTAct.Location = New System.Drawing.Point(20, 61)
        Me.btnAdminAddTAct.Name = "btnAdminAddTAct"
        Me.btnAdminAddTAct.Size = New System.Drawing.Size(351, 25)
        Me.btnAdminAddTAct.TabIndex = 7
        Me.btnAdminAddTAct.Text = "Agregar"
        Me.btnAdminAddTAct.UseVisualStyleBackColor = True
        '
        'FrmAdmin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(469, 560)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "FrmAdmin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Panel de Administrador"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Button5 As Button
    Friend WithEvents btnAdminConUsu As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btnAdminModUsu As Button
    Friend WithEvents btnAdminAddUsu As Button
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents btnAdminModDep As Button
    Friend WithEvents btnAdminConDep As Button
    Friend WithEvents btnAdminAddDep As Button
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents btnAdminModTAct As Button
    Friend WithEvents btnAdminConTAct As Button
    Friend WithEvents btnAdminAddTAct As Button
End Class
