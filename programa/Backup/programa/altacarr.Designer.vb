<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class altaCarrera
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.btnaceptar = New System.Windows.Forms.Button
        Me.btnatras = New System.Windows.Forms.Button
        Me.gbxcar = New System.Windows.Forms.GroupBox
        Me.cmbdur = New System.Windows.Forms.ComboBox
        Me.txtnombre = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.lbltitulo = New System.Windows.Forms.Label
        Me.lblrol = New System.Windows.Forms.Label
        Me.btnclose = New System.Windows.Forms.Button
        Me.lbltipou = New System.Windows.Forms.Label
        Me.gbxcar.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnaceptar
        '
        Me.btnaceptar.BackColor = System.Drawing.Color.Transparent
        Me.btnaceptar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnaceptar.Location = New System.Drawing.Point(366, 162)
        Me.btnaceptar.Name = "btnaceptar"
        Me.btnaceptar.Size = New System.Drawing.Size(101, 22)
        Me.btnaceptar.TabIndex = 19
        Me.btnaceptar.Text = "Ingresar"
        Me.btnaceptar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage
        Me.btnaceptar.UseVisualStyleBackColor = False
        '
        'btnatras
        '
        Me.btnatras.BackColor = System.Drawing.Color.Transparent
        Me.btnatras.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnatras.Location = New System.Drawing.Point(366, 208)
        Me.btnatras.Name = "btnatras"
        Me.btnatras.Size = New System.Drawing.Size(101, 22)
        Me.btnatras.TabIndex = 18
        Me.btnatras.Text = "Finalizar"
        Me.btnatras.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage
        Me.btnatras.UseVisualStyleBackColor = False
        '
        'gbxcar
        '
        Me.gbxcar.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbxcar.Controls.Add(Me.cmbdur)
        Me.gbxcar.Controls.Add(Me.txtnombre)
        Me.gbxcar.Controls.Add(Me.Label3)
        Me.gbxcar.Controls.Add(Me.Label2)
        Me.gbxcar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbxcar.Location = New System.Drawing.Point(15, 75)
        Me.gbxcar.Name = "gbxcar"
        Me.gbxcar.Size = New System.Drawing.Size(271, 164)
        Me.gbxcar.TabIndex = 21
        Me.gbxcar.TabStop = False
        Me.gbxcar.Text = "Carreras"
        '
        'cmbdur
        '
        Me.cmbdur.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbdur.FormattingEnabled = True
        Me.cmbdur.Items.AddRange(New Object() {"(Seleccione)", "1 ", "2 ", "3", "4 "})
        Me.cmbdur.Location = New System.Drawing.Point(9, 119)
        Me.cmbdur.Name = "cmbdur"
        Me.cmbdur.Size = New System.Drawing.Size(218, 24)
        Me.cmbdur.TabIndex = 7
        '
        'txtnombre
        '
        Me.txtnombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtnombre.Location = New System.Drawing.Point(9, 66)
        Me.txtnombre.Name = "txtnombre"
        Me.txtnombre.Size = New System.Drawing.Size(218, 22)
        Me.txtnombre.TabIndex = 6
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(6, 87)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(65, 16)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Duración:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(6, 40)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(60, 16)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Nombre:"
        '
        'lbltitulo
        '
        Me.lbltitulo.AutoSize = True
        Me.lbltitulo.BackColor = System.Drawing.Color.LemonChiffon
        Me.lbltitulo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbltitulo.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltitulo.Location = New System.Drawing.Point(15, 9)
        Me.lbltitulo.Name = "lbltitulo"
        Me.lbltitulo.Size = New System.Drawing.Size(255, 26)
        Me.lbltitulo.TabIndex = 51
        Me.lbltitulo.Text = "INGRESO DE CARRERAS"
        '
        'lblrol
        '
        Me.lblrol.AutoSize = True
        Me.lblrol.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblrol.Location = New System.Drawing.Point(424, 9)
        Me.lblrol.Name = "lblrol"
        Me.lblrol.Size = New System.Drawing.Size(36, 16)
        Me.lblrol.TabIndex = 68
        Me.lblrol.Text = "Rol:"
        '
        'btnclose
        '
        Me.btnclose.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnclose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnclose.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnclose.Location = New System.Drawing.Point(501, 28)
        Me.btnclose.Name = "btnclose"
        Me.btnclose.Size = New System.Drawing.Size(102, 24)
        Me.btnclose.TabIndex = 67
        Me.btnclose.Text = "Cerrar sesión"
        Me.btnclose.UseVisualStyleBackColor = True
        '
        'lbltipou
        '
        Me.lbltipou.AutoSize = True
        Me.lbltipou.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltipou.Location = New System.Drawing.Point(466, 9)
        Me.lbltipou.Name = "lbltipou"
        Me.lbltipou.Size = New System.Drawing.Size(137, 16)
        Me.lbltipou.TabIndex = 66
        Me.lbltipou.Text = "Secretario Escolar"
        '
        'altaCarrera
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(622, 366)
        Me.Controls.Add(Me.lblrol)
        Me.Controls.Add(Me.btnclose)
        Me.Controls.Add(Me.lbltipou)
        Me.Controls.Add(Me.lbltitulo)
        Me.Controls.Add(Me.gbxcar)
        Me.Controls.Add(Me.btnaceptar)
        Me.Controls.Add(Me.btnatras)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "altaCarrera"
        Me.Text = "S.I.B.A"
        Me.gbxcar.ResumeLayout(False)
        Me.gbxcar.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnaceptar As System.Windows.Forms.Button
    Friend WithEvents btnatras As System.Windows.Forms.Button
    Friend WithEvents gbxcar As System.Windows.Forms.GroupBox
    Friend WithEvents txtnombre As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lbltitulo As System.Windows.Forms.Label
    Friend WithEvents lblrol As System.Windows.Forms.Label
    Friend WithEvents btnclose As System.Windows.Forms.Button
    Friend WithEvents lbltipou As System.Windows.Forms.Label
    Friend WithEvents cmbdur As System.Windows.Forms.ComboBox
End Class
