<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class conshordoc
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
        Me.lblturno = New System.Windows.Forms.Label
        Me.lblnombre = New System.Windows.Forms.Label
        Me.lblcodoc = New System.Windows.Forms.Label
        Me.cmbturno = New System.Windows.Forms.ComboBox
        Me.lblcons = New System.Windows.Forms.Button
        Me.btnatras = New System.Windows.Forms.Button
        Me.lbltitulo = New System.Windows.Forms.Label
        Me.txtci = New System.Windows.Forms.TextBox
        Me.txtnombre = New System.Windows.Forms.TextBox
        Me.lblrol = New System.Windows.Forms.Label
        Me.btbclose = New System.Windows.Forms.Button
        Me.lbltipou = New System.Windows.Forms.Label
        Me.SuspendLayout()
        '
        'lblturno
        '
        Me.lblturno.AutoSize = True
        Me.lblturno.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblturno.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblturno.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblturno.Location = New System.Drawing.Point(9, 118)
        Me.lblturno.Name = "lblturno"
        Me.lblturno.Size = New System.Drawing.Size(54, 18)
        Me.lblturno.TabIndex = 42
        Me.lblturno.Text = "Turno:"
        '
        'lblnombre
        '
        Me.lblnombre.AutoSize = True
        Me.lblnombre.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblnombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblnombre.Location = New System.Drawing.Point(9, 88)
        Me.lblnombre.Name = "lblnombre"
        Me.lblnombre.Size = New System.Drawing.Size(139, 18)
        Me.lblnombre.TabIndex = 41
        Me.lblnombre.Text = "Apellido, Nombre: "
        '
        'lblcodoc
        '
        Me.lblcodoc.AutoSize = True
        Me.lblcodoc.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblcodoc.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblcodoc.Location = New System.Drawing.Point(9, 58)
        Me.lblcodoc.Name = "lblcodoc"
        Me.lblcodoc.Size = New System.Drawing.Size(150, 18)
        Me.lblcodoc.TabIndex = 40
        Me.lblcodoc.Text = "Cédula de identidad"
        '
        'cmbturno
        '
        Me.cmbturno.FormattingEnabled = True
        Me.cmbturno.Items.AddRange(New Object() {"(Seleccione)", "Matutino", "Vespertino", "Nocturno"})
        Me.cmbturno.Location = New System.Drawing.Point(160, 118)
        Me.cmbturno.Name = "cmbturno"
        Me.cmbturno.Size = New System.Drawing.Size(121, 21)
        Me.cmbturno.TabIndex = 45
        '
        'lblcons
        '
        Me.lblcons.BackColor = System.Drawing.Color.Transparent
        Me.lblcons.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblcons.Location = New System.Drawing.Point(180, 190)
        Me.lblcons.Name = "lblcons"
        Me.lblcons.Size = New System.Drawing.Size(101, 32)
        Me.lblcons.TabIndex = 46
        Me.lblcons.Text = "Consultar"
        Me.lblcons.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage
        Me.lblcons.UseVisualStyleBackColor = False
        '
        'btnatras
        '
        Me.btnatras.BackColor = System.Drawing.Color.Transparent
        Me.btnatras.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnatras.Location = New System.Drawing.Point(73, 190)
        Me.btnatras.Name = "btnatras"
        Me.btnatras.Size = New System.Drawing.Size(101, 32)
        Me.btnatras.TabIndex = 47
        Me.btnatras.Text = "Atrás"
        Me.btnatras.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage
        Me.btnatras.UseVisualStyleBackColor = False
        '
        'lbltitulo
        '
        Me.lbltitulo.AutoSize = True
        Me.lbltitulo.BackColor = System.Drawing.Color.LemonChiffon
        Me.lbltitulo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbltitulo.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltitulo.Location = New System.Drawing.Point(9, 9)
        Me.lbltitulo.Name = "lbltitulo"
        Me.lbltitulo.Size = New System.Drawing.Size(262, 26)
        Me.lbltitulo.TabIndex = 48
        Me.lbltitulo.Text = "CONSULTA DE HORARIO "
        '
        'txtci
        '
        Me.txtci.Location = New System.Drawing.Point(160, 58)
        Me.txtci.MaxLength = 10
        Me.txtci.Name = "txtci"
        Me.txtci.Size = New System.Drawing.Size(121, 20)
        Me.txtci.TabIndex = 51
        '
        'txtnombre
        '
        Me.txtnombre.Location = New System.Drawing.Point(160, 85)
        Me.txtnombre.MaxLength = 25
        Me.txtnombre.Name = "txtnombre"
        Me.txtnombre.Size = New System.Drawing.Size(121, 20)
        Me.txtnombre.TabIndex = 52
        '
        'lblrol
        '
        Me.lblrol.AutoSize = True
        Me.lblrol.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblrol.Location = New System.Drawing.Point(449, 9)
        Me.lblrol.Name = "lblrol"
        Me.lblrol.Size = New System.Drawing.Size(36, 16)
        Me.lblrol.TabIndex = 61
        Me.lblrol.Text = "Rol:"
        '
        'btbclose
        '
        Me.btbclose.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btbclose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btbclose.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btbclose.Location = New System.Drawing.Point(494, 28)
        Me.btbclose.Name = "btbclose"
        Me.btbclose.Size = New System.Drawing.Size(102, 24)
        Me.btbclose.TabIndex = 60
        Me.btbclose.Text = "Cerrar sesión"
        Me.btbclose.UseVisualStyleBackColor = True
        '
        'lbltipou
        '
        Me.lbltipou.AutoSize = True
        Me.lbltipou.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltipou.Location = New System.Drawing.Point(491, 9)
        Me.lbltipou.Name = "lbltipou"
        Me.lbltipou.Size = New System.Drawing.Size(0, 16)
        Me.lbltipou.TabIndex = 59
        '
        'conshordoc
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(624, 376)
        Me.Controls.Add(Me.lblrol)
        Me.Controls.Add(Me.btbclose)
        Me.Controls.Add(Me.lbltipou)
        Me.Controls.Add(Me.txtnombre)
        Me.Controls.Add(Me.txtci)
        Me.Controls.Add(Me.lbltitulo)
        Me.Controls.Add(Me.btnatras)
        Me.Controls.Add(Me.lblcons)
        Me.Controls.Add(Me.cmbturno)
        Me.Controls.Add(Me.lblturno)
        Me.Controls.Add(Me.lblnombre)
        Me.Controls.Add(Me.lblcodoc)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "conshordoc"
        Me.Text = "S.I.B.A"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblturno As System.Windows.Forms.Label
    Friend WithEvents lblnombre As System.Windows.Forms.Label
    Friend WithEvents lblcodoc As System.Windows.Forms.Label
    Friend WithEvents cmbturno As System.Windows.Forms.ComboBox
    Friend WithEvents lblcons As System.Windows.Forms.Button
    Friend WithEvents btnatras As System.Windows.Forms.Button
    Friend WithEvents lbltitulo As System.Windows.Forms.Label
    Friend WithEvents txtci As System.Windows.Forms.TextBox
    Friend WithEvents txtnombre As System.Windows.Forms.TextBox
    Friend WithEvents lblrol As System.Windows.Forms.Label
    Friend WithEvents btbclose As System.Windows.Forms.Button
    Friend WithEvents lbltipou As System.Windows.Forms.Label
End Class
