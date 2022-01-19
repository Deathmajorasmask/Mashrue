<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmDepartamentoCon
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.cboConsDepOrd = New System.Windows.Forms.ComboBox()
        Me.btnConsDepOrdOK = New System.Windows.Forms.Button()
        Me.cboConsDepOrdParam = New System.Windows.Forms.ComboBox()
        Me.dgvConsDep = New System.Windows.Forms.DataGridView()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btnConsDepBusqOK = New System.Windows.Forms.Button()
        Me.txtConsDepBusq = New System.Windows.Forms.TextBox()
        Me.cboConsDepBusqParam = New System.Windows.Forms.ComboBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgvConsDep, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.cboConsDepOrd)
        Me.GroupBox1.Controls.Add(Me.btnConsDepOrdOK)
        Me.GroupBox1.Controls.Add(Me.cboConsDepOrdParam)
        Me.GroupBox1.Location = New System.Drawing.Point(15, 452)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(582, 99)
        Me.GroupBox1.TabIndex = 176
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Ordenar"
        '
        'cboConsDepOrd
        '
        Me.cboConsDepOrd.FormattingEnabled = True
        Me.cboConsDepOrd.Location = New System.Drawing.Point(16, 30)
        Me.cboConsDepOrd.Name = "cboConsDepOrd"
        Me.cboConsDepOrd.Size = New System.Drawing.Size(354, 21)
        Me.cboConsDepOrd.TabIndex = 173
        '
        'btnConsDepOrdOK
        '
        Me.btnConsDepOrdOK.Location = New System.Drawing.Point(16, 56)
        Me.btnConsDepOrdOK.Name = "btnConsDepOrdOK"
        Me.btnConsDepOrdOK.Size = New System.Drawing.Size(560, 26)
        Me.btnConsDepOrdOK.TabIndex = 2
        Me.btnConsDepOrdOK.Text = "Buscar"
        Me.btnConsDepOrdOK.UseVisualStyleBackColor = True
        '
        'cboConsDepOrdParam
        '
        Me.cboConsDepOrdParam.FormattingEnabled = True
        Me.cboConsDepOrdParam.Location = New System.Drawing.Point(399, 30)
        Me.cboConsDepOrdParam.Name = "cboConsDepOrdParam"
        Me.cboConsDepOrdParam.Size = New System.Drawing.Size(177, 21)
        Me.cboConsDepOrdParam.TabIndex = 0
        '
        'dgvConsDep
        '
        Me.dgvConsDep.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvConsDep.Location = New System.Drawing.Point(15, 7)
        Me.dgvConsDep.Name = "dgvConsDep"
        Me.dgvConsDep.Size = New System.Drawing.Size(594, 334)
        Me.dgvConsDep.TabIndex = 175
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.btnConsDepBusqOK)
        Me.GroupBox2.Controls.Add(Me.txtConsDepBusq)
        Me.GroupBox2.Controls.Add(Me.cboConsDepBusqParam)
        Me.GroupBox2.Location = New System.Drawing.Point(13, 347)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(582, 99)
        Me.GroupBox2.TabIndex = 174
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Busqueda especifica"
        '
        'btnConsDepBusqOK
        '
        Me.btnConsDepBusqOK.Location = New System.Drawing.Point(16, 56)
        Me.btnConsDepBusqOK.Name = "btnConsDepBusqOK"
        Me.btnConsDepBusqOK.Size = New System.Drawing.Size(560, 26)
        Me.btnConsDepBusqOK.TabIndex = 2
        Me.btnConsDepBusqOK.Text = "Buscar"
        Me.btnConsDepBusqOK.UseVisualStyleBackColor = True
        '
        'txtConsDepBusq
        '
        Me.txtConsDepBusq.Location = New System.Drawing.Point(16, 30)
        Me.txtConsDepBusq.Name = "txtConsDepBusq"
        Me.txtConsDepBusq.Size = New System.Drawing.Size(356, 20)
        Me.txtConsDepBusq.TabIndex = 1
        '
        'cboConsDepBusqParam
        '
        Me.cboConsDepBusqParam.FormattingEnabled = True
        Me.cboConsDepBusqParam.Location = New System.Drawing.Point(399, 30)
        Me.cboConsDepBusqParam.Name = "cboConsDepBusqParam"
        Me.cboConsDepBusqParam.Size = New System.Drawing.Size(177, 21)
        Me.cboConsDepBusqParam.TabIndex = 0
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(15, 554)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(582, 26)
        Me.Button1.TabIndex = 173
        Me.Button1.Text = "Salir"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'FrmDepartamentoCon
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(623, 586)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.dgvConsDep)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.Button1)
        Me.Name = "FrmDepartamentoCon"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Consulta Departamento"
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.dgvConsDep, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents cboConsDepOrd As ComboBox
    Friend WithEvents btnConsDepOrdOK As Button
    Friend WithEvents cboConsDepOrdParam As ComboBox
    Friend WithEvents dgvConsDep As DataGridView
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents btnConsDepBusqOK As Button
    Friend WithEvents txtConsDepBusq As TextBox
    Friend WithEvents cboConsDepBusqParam As ComboBox
    Friend WithEvents Button1 As Button
End Class
