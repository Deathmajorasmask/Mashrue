<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmTipo
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
        Me.btnTActCancel = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnTActOK = New System.Windows.Forms.Button()
        Me.txtTActAddDescp = New System.Windows.Forms.TextBox()
        Me.txtTActAddNom = New System.Windows.Forms.TextBox()
        Me.txtTActAddHour = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtTActAddID = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnTActCancel
        '
        Me.btnTActCancel.Location = New System.Drawing.Point(283, 267)
        Me.btnTActCancel.Name = "btnTActCancel"
        Me.btnTActCancel.Size = New System.Drawing.Size(104, 26)
        Me.btnTActCancel.TabIndex = 160
        Me.btnTActCancel.Text = "Cancelar"
        Me.btnTActCancel.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(28, 105)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(63, 13)
        Me.Label2.TabIndex = 159
        Me.Label2.Text = "Descripcion"
        '
        'btnTActOK
        '
        Me.btnTActOK.Location = New System.Drawing.Point(29, 231)
        Me.btnTActOK.Name = "btnTActOK"
        Me.btnTActOK.Size = New System.Drawing.Size(358, 30)
        Me.btnTActOK.TabIndex = 158
        Me.btnTActOK.Text = "Agregar Usuario"
        Me.btnTActOK.UseVisualStyleBackColor = True
        '
        'txtTActAddDescp
        '
        Me.txtTActAddDescp.Location = New System.Drawing.Point(148, 102)
        Me.txtTActAddDescp.Multiline = True
        Me.txtTActAddDescp.Name = "txtTActAddDescp"
        Me.txtTActAddDescp.Size = New System.Drawing.Size(239, 72)
        Me.txtTActAddDescp.TabIndex = 157
        '
        'txtTActAddNom
        '
        Me.txtTActAddNom.Location = New System.Drawing.Point(148, 66)
        Me.txtTActAddNom.Name = "txtTActAddNom"
        Me.txtTActAddNom.Size = New System.Drawing.Size(239, 20)
        Me.txtTActAddNom.TabIndex = 156
        '
        'txtTActAddHour
        '
        Me.txtTActAddHour.Location = New System.Drawing.Point(148, 180)
        Me.txtTActAddHour.Name = "txtTActAddHour"
        Me.txtTActAddHour.Size = New System.Drawing.Size(239, 20)
        Me.txtTActAddHour.TabIndex = 153
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(28, 183)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(78, 13)
        Me.Label6.TabIndex = 152
        Me.Label6.Text = "Costo por Hora"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(28, 69)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(44, 13)
        Me.Label4.TabIndex = 151
        Me.Label4.Text = "Nombre"
        '
        'txtTActAddID
        '
        Me.txtTActAddID.Location = New System.Drawing.Point(148, 31)
        Me.txtTActAddID.Name = "txtTActAddID"
        Me.txtTActAddID.Size = New System.Drawing.Size(239, 20)
        Me.txtTActAddID.TabIndex = 150
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(27, 34)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(80, 13)
        Me.Label1.TabIndex = 149
        Me.Label1.Text = "ID de Actividad"
        '
        'FrmTipo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(419, 321)
        Me.Controls.Add(Me.btnTActCancel)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnTActOK)
        Me.Controls.Add(Me.txtTActAddDescp)
        Me.Controls.Add(Me.txtTActAddNom)
        Me.Controls.Add(Me.txtTActAddHour)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtTActAddID)
        Me.Controls.Add(Me.Label1)
        Me.Name = "FrmTipo"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Agregar Tipo de Actividad"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnTActCancel As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents btnTActOK As Button
    Friend WithEvents txtTActAddDescp As TextBox
    Friend WithEvents txtTActAddNom As TextBox
    Friend WithEvents txtTActAddHour As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtTActAddID As TextBox
    Friend WithEvents Label1 As Label
End Class
