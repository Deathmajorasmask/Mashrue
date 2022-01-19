<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmDepartamento
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
        Me.btnDeptCancel = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnDeptAdd = New System.Windows.Forms.Button()
        Me.txtDepAddDescp = New System.Windows.Forms.TextBox()
        Me.txtDepAddNom = New System.Windows.Forms.TextBox()
        Me.txtDepAddUb = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtDepAddExt = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtDepAddID = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnDeptCancel
        '
        Me.btnDeptCancel.Location = New System.Drawing.Point(278, 330)
        Me.btnDeptCancel.Name = "btnDeptCancel"
        Me.btnDeptCancel.Size = New System.Drawing.Size(104, 26)
        Me.btnDeptCancel.TabIndex = 6
        Me.btnDeptCancel.Text = "Cancelar"
        Me.btnDeptCancel.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(23, 100)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(63, 13)
        Me.Label2.TabIndex = 146
        Me.Label2.Text = "Descripcion"
        '
        'btnDeptAdd
        '
        Me.btnDeptAdd.Location = New System.Drawing.Point(24, 294)
        Me.btnDeptAdd.Name = "btnDeptAdd"
        Me.btnDeptAdd.Size = New System.Drawing.Size(358, 30)
        Me.btnDeptAdd.TabIndex = 5
        Me.btnDeptAdd.Text = "Agregar Departamento"
        Me.btnDeptAdd.UseVisualStyleBackColor = True
        '
        'txtDepAddDescp
        '
        Me.txtDepAddDescp.Location = New System.Drawing.Point(143, 97)
        Me.txtDepAddDescp.Multiline = True
        Me.txtDepAddDescp.Name = "txtDepAddDescp"
        Me.txtDepAddDescp.Size = New System.Drawing.Size(239, 86)
        Me.txtDepAddDescp.TabIndex = 2
        '
        'txtDepAddNom
        '
        Me.txtDepAddNom.Location = New System.Drawing.Point(143, 61)
        Me.txtDepAddNom.Name = "txtDepAddNom"
        Me.txtDepAddNom.Size = New System.Drawing.Size(239, 20)
        Me.txtDepAddNom.TabIndex = 1
        '
        'txtDepAddUb
        '
        Me.txtDepAddUb.Location = New System.Drawing.Point(143, 243)
        Me.txtDepAddUb.Name = "txtDepAddUb"
        Me.txtDepAddUb.Size = New System.Drawing.Size(239, 20)
        Me.txtDepAddUb.TabIndex = 4
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(23, 246)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(55, 13)
        Me.Label5.TabIndex = 138
        Me.Label5.Text = "Ubicación"
        '
        'txtDepAddExt
        '
        Me.txtDepAddExt.Location = New System.Drawing.Point(143, 200)
        Me.txtDepAddExt.Name = "txtDepAddExt"
        Me.txtDepAddExt.Size = New System.Drawing.Size(239, 20)
        Me.txtDepAddExt.TabIndex = 3
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(23, 203)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(53, 13)
        Me.Label6.TabIndex = 136
        Me.Label6.Text = "Extension"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(23, 64)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(44, 13)
        Me.Label4.TabIndex = 135
        Me.Label4.Text = "Nombre"
        '
        'txtDepAddID
        '
        Me.txtDepAddID.Location = New System.Drawing.Point(143, 26)
        Me.txtDepAddID.Name = "txtDepAddID"
        Me.txtDepAddID.Size = New System.Drawing.Size(239, 20)
        Me.txtDepAddID.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(22, 29)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(103, 13)
        Me.Label1.TabIndex = 133
        Me.Label1.Text = "ID de Departamento"
        '
        'FrmDepartamento
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(415, 370)
        Me.Controls.Add(Me.btnDeptCancel)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnDeptAdd)
        Me.Controls.Add(Me.txtDepAddDescp)
        Me.Controls.Add(Me.txtDepAddNom)
        Me.Controls.Add(Me.txtDepAddUb)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtDepAddExt)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtDepAddID)
        Me.Controls.Add(Me.Label1)
        Me.Name = "FrmDepartamento"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Agregar Departamento"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnDeptCancel As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents btnDeptAdd As Button
    Friend WithEvents txtDepAddDescp As TextBox
    Friend WithEvents txtDepAddNom As TextBox
    Friend WithEvents txtDepAddUb As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtDepAddExt As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtDepAddID As TextBox
    Friend WithEvents Label1 As Label
End Class
