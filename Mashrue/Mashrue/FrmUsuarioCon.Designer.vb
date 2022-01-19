<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmUsuarioCon
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
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.ComboBox6 = New System.Windows.Forms.ComboBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.dgvConsUsu = New System.Windows.Forms.DataGridView()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.ComboBox2 = New System.Windows.Forms.ComboBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.GroupBox2.SuspendLayout()
        CType(Me.dgvConsUsu, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Button5)
        Me.GroupBox2.Controls.Add(Me.TextBox4)
        Me.GroupBox2.Controls.Add(Me.ComboBox6)
        Me.GroupBox2.Location = New System.Drawing.Point(30, 366)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(582, 99)
        Me.GroupBox2.TabIndex = 168
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Busqueda especifica"
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(16, 56)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(560, 26)
        Me.Button5.TabIndex = 2
        Me.Button5.Text = "Buscar"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'TextBox4
        '
        Me.TextBox4.Location = New System.Drawing.Point(16, 30)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(356, 20)
        Me.TextBox4.TabIndex = 1
        '
        'ComboBox6
        '
        Me.ComboBox6.FormattingEnabled = True
        Me.ComboBox6.Location = New System.Drawing.Point(399, 30)
        Me.ComboBox6.Name = "ComboBox6"
        Me.ComboBox6.Size = New System.Drawing.Size(177, 21)
        Me.ComboBox6.TabIndex = 0
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(32, 573)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(582, 26)
        Me.Button1.TabIndex = 167
        Me.Button1.Text = "Salir"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'dgvConsUsu
        '
        Me.dgvConsUsu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvConsUsu.Location = New System.Drawing.Point(32, 26)
        Me.dgvConsUsu.Name = "dgvConsUsu"
        Me.dgvConsUsu.Size = New System.Drawing.Size(594, 334)
        Me.dgvConsUsu.TabIndex = 171
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.ComboBox2)
        Me.GroupBox1.Controls.Add(Me.Button2)
        Me.GroupBox1.Controls.Add(Me.ComboBox1)
        Me.GroupBox1.Location = New System.Drawing.Point(32, 471)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(582, 99)
        Me.GroupBox1.TabIndex = 172
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Ordenar"
        '
        'ComboBox2
        '
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Location = New System.Drawing.Point(16, 30)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(354, 21)
        Me.ComboBox2.TabIndex = 173
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(16, 56)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(560, 26)
        Me.Button2.TabIndex = 2
        Me.Button2.Text = "Buscar"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(399, 30)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(177, 21)
        Me.ComboBox1.TabIndex = 0
        '
        'FrmUsuarioCon
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(650, 611)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.dgvConsUsu)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.Button1)
        Me.Name = "FrmUsuarioCon"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Consulta de Usuarios"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.dgvConsUsu, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Button5 As Button
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents ComboBox6 As ComboBox
    Friend WithEvents Button1 As Button
    Friend WithEvents dgvConsUsu As DataGridView
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents ComboBox2 As ComboBox
    Friend WithEvents Button2 As Button
    Friend WithEvents ComboBox1 As ComboBox
End Class
