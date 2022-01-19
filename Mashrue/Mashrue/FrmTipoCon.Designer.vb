<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmTipoCon
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
        Me.cboConsTActOrd = New System.Windows.Forms.ComboBox()
        Me.btnConsTActOrdOK = New System.Windows.Forms.Button()
        Me.cboConsTActOrdParam = New System.Windows.Forms.ComboBox()
        Me.dgvConsTAct = New System.Windows.Forms.DataGridView()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btnConsTActBusqOK = New System.Windows.Forms.Button()
        Me.txtConsTActBusq = New System.Windows.Forms.TextBox()
        Me.cboConsTActBusqParam = New System.Windows.Forms.ComboBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgvConsTAct, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.cboConsTActOrd)
        Me.GroupBox1.Controls.Add(Me.btnConsTActOrdOK)
        Me.GroupBox1.Controls.Add(Me.cboConsTActOrdParam)
        Me.GroupBox1.Location = New System.Drawing.Point(11, 455)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(582, 99)
        Me.GroupBox1.TabIndex = 180
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Ordenar"
        '
        'cboConsTActOrd
        '
        Me.cboConsTActOrd.FormattingEnabled = True
        Me.cboConsTActOrd.Location = New System.Drawing.Point(16, 30)
        Me.cboConsTActOrd.Name = "cboConsTActOrd"
        Me.cboConsTActOrd.Size = New System.Drawing.Size(354, 21)
        Me.cboConsTActOrd.TabIndex = 173
        '
        'btnConsTActOrdOK
        '
        Me.btnConsTActOrdOK.Location = New System.Drawing.Point(16, 56)
        Me.btnConsTActOrdOK.Name = "btnConsTActOrdOK"
        Me.btnConsTActOrdOK.Size = New System.Drawing.Size(560, 26)
        Me.btnConsTActOrdOK.TabIndex = 2
        Me.btnConsTActOrdOK.Text = "Buscar"
        Me.btnConsTActOrdOK.UseVisualStyleBackColor = True
        '
        'cboConsTActOrdParam
        '
        Me.cboConsTActOrdParam.FormattingEnabled = True
        Me.cboConsTActOrdParam.Location = New System.Drawing.Point(399, 30)
        Me.cboConsTActOrdParam.Name = "cboConsTActOrdParam"
        Me.cboConsTActOrdParam.Size = New System.Drawing.Size(177, 21)
        Me.cboConsTActOrdParam.TabIndex = 0
        '
        'dgvConsTAct
        '
        Me.dgvConsTAct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvConsTAct.Location = New System.Drawing.Point(11, 10)
        Me.dgvConsTAct.Name = "dgvConsTAct"
        Me.dgvConsTAct.Size = New System.Drawing.Size(594, 334)
        Me.dgvConsTAct.TabIndex = 179
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.btnConsTActBusqOK)
        Me.GroupBox2.Controls.Add(Me.txtConsTActBusq)
        Me.GroupBox2.Controls.Add(Me.cboConsTActBusqParam)
        Me.GroupBox2.Location = New System.Drawing.Point(9, 350)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(582, 99)
        Me.GroupBox2.TabIndex = 178
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Busqueda especifica"
        '
        'btnConsTActBusqOK
        '
        Me.btnConsTActBusqOK.Location = New System.Drawing.Point(16, 56)
        Me.btnConsTActBusqOK.Name = "btnConsTActBusqOK"
        Me.btnConsTActBusqOK.Size = New System.Drawing.Size(560, 26)
        Me.btnConsTActBusqOK.TabIndex = 2
        Me.btnConsTActBusqOK.Text = "Buscar"
        Me.btnConsTActBusqOK.UseVisualStyleBackColor = True
        '
        'txtConsTActBusq
        '
        Me.txtConsTActBusq.Location = New System.Drawing.Point(16, 30)
        Me.txtConsTActBusq.Name = "txtConsTActBusq"
        Me.txtConsTActBusq.Size = New System.Drawing.Size(356, 20)
        Me.txtConsTActBusq.TabIndex = 1
        '
        'cboConsTActBusqParam
        '
        Me.cboConsTActBusqParam.FormattingEnabled = True
        Me.cboConsTActBusqParam.Location = New System.Drawing.Point(399, 30)
        Me.cboConsTActBusqParam.Name = "cboConsTActBusqParam"
        Me.cboConsTActBusqParam.Size = New System.Drawing.Size(177, 21)
        Me.cboConsTActBusqParam.TabIndex = 0
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(11, 557)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(582, 26)
        Me.Button1.TabIndex = 177
        Me.Button1.Text = "Salir"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'FrmTipoCon
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(614, 592)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.dgvConsTAct)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.Button1)
        Me.Name = "FrmTipoCon"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Consultar T.Actividad"
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.dgvConsTAct, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents cboConsTActOrd As ComboBox
    Friend WithEvents btnConsTActOrdOK As Button
    Friend WithEvents cboConsTActOrdParam As ComboBox
    Friend WithEvents dgvConsTAct As DataGridView
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents btnConsTActBusqOK As Button
    Friend WithEvents txtConsTActBusq As TextBox
    Friend WithEvents cboConsTActBusqParam As ComboBox
    Friend WithEvents Button1 As Button
End Class
