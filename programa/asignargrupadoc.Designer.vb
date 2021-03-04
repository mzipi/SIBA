<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class asignarGrupo
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
        Me.components = New System.ComponentModel.Container
        Me.lbltitulo = New System.Windows.Forms.Label
        Me.btnatras = New System.Windows.Forms.Button
        Me.btnconf = New System.Windows.Forms.Button
        Me.lblrol = New System.Windows.Forms.Label
        Me.lbltipou = New System.Windows.Forms.Label
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.lbldocee = New System.Windows.Forms.Label
        Me.bnclose = New System.Windows.Forms.Button
        Me.lblfechaa = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.cmbdocente = New System.Windows.Forms.ComboBox
        Me.cmbcarrera = New System.Windows.Forms.ComboBox
        Me.cmbgrupos = New System.Windows.Forms.ComboBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.cmbturno = New System.Windows.Forms.ComboBox
        Me.cmbmat = New System.Windows.Forms.ComboBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.txtidturno = New System.Windows.Forms.TextBox
        Me.txtaño = New System.Windows.Forms.TextBox
        Me.txtcodgrupo = New System.Windows.Forms.TextBox
        Me.txtcodmat = New System.Windows.Forms.TextBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.dtpfecha = New System.Windows.Forms.DateTimePicker
        Me.txtcidoc = New System.Windows.Forms.TextBox
        Me.SuspendLayout()
        '
        'lbltitulo
        '
        Me.lbltitulo.AutoSize = True
        Me.lbltitulo.BackColor = System.Drawing.Color.LemonChiffon
        Me.lbltitulo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbltitulo.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltitulo.Location = New System.Drawing.Point(12, 9)
        Me.lbltitulo.Name = "lbltitulo"
        Me.lbltitulo.Size = New System.Drawing.Size(306, 26)
        Me.lbltitulo.TabIndex = 53
        Me.lbltitulo.Text = "ASIGNAR GRUPO A DOCENTE"
        '
        'btnatras
        '
        Me.btnatras.Location = New System.Drawing.Point(12, 299)
        Me.btnatras.Name = "btnatras"
        Me.btnatras.Size = New System.Drawing.Size(125, 28)
        Me.btnatras.TabIndex = 65
        Me.btnatras.Text = "Administrador Docente"
        Me.btnatras.UseVisualStyleBackColor = True
        '
        'btnconf
        '
        Me.btnconf.Location = New System.Drawing.Point(197, 239)
        Me.btnconf.Name = "btnconf"
        Me.btnconf.Size = New System.Drawing.Size(121, 28)
        Me.btnconf.TabIndex = 66
        Me.btnconf.Text = "Asignar Docente"
        Me.btnconf.UseVisualStyleBackColor = True
        '
        'lblrol
        '
        Me.lblrol.AutoSize = True
        Me.lblrol.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblrol.Location = New System.Drawing.Point(411, 9)
        Me.lblrol.Name = "lblrol"
        Me.lblrol.Size = New System.Drawing.Size(36, 16)
        Me.lblrol.TabIndex = 144
        Me.lblrol.Text = "Rol:"
        '
        'lbltipou
        '
        Me.lbltipou.AutoSize = True
        Me.lbltipou.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltipou.Location = New System.Drawing.Point(443, 9)
        Me.lbltipou.Name = "lbltipou"
        Me.lbltipou.Size = New System.Drawing.Size(137, 16)
        Me.lbltipou.TabIndex = 142
        Me.lbltipou.Text = "Secretario Escolar"
        '
        'lbldocee
        '
        Me.lbldocee.AutoSize = True
        Me.lbldocee.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbldocee.Location = New System.Drawing.Point(523, 137)
        Me.lbldocee.Name = "lbldocee"
        Me.lbldocee.Size = New System.Drawing.Size(0, 16)
        Me.lbldocee.TabIndex = 59
        '
        'bnclose
        '
        Me.bnclose.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.bnclose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bnclose.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bnclose.Location = New System.Drawing.Point(475, 28)
        Me.bnclose.Name = "bnclose"
        Me.bnclose.Size = New System.Drawing.Size(105, 24)
        Me.bnclose.TabIndex = 143
        Me.bnclose.Text = "Cerrar sesión"
        Me.bnclose.UseVisualStyleBackColor = True
        '
        'lblfechaa
        '
        Me.lblfechaa.AutoSize = True
        Me.lblfechaa.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblfechaa.Location = New System.Drawing.Point(509, 108)
        Me.lblfechaa.Name = "lblfechaa"
        Me.lblfechaa.Size = New System.Drawing.Size(0, 16)
        Me.lblfechaa.TabIndex = 147
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(27, 57)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(129, 16)
        Me.Label1.TabIndex = 148
        Me.Label1.Text = "Nombre Docente:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(27, 108)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(64, 16)
        Me.Label2.TabIndex = 149
        Me.Label2.Text = "Carrera:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(27, 138)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(54, 16)
        Me.Label3.TabIndex = 150
        Me.Label3.Text = "Grupo:"
        '
        'cmbdocente
        '
        Me.cmbdocente.FormattingEnabled = True
        Me.cmbdocente.Location = New System.Drawing.Point(162, 56)
        Me.cmbdocente.Name = "cmbdocente"
        Me.cmbdocente.Size = New System.Drawing.Size(156, 21)
        Me.cmbdocente.TabIndex = 151
        '
        'cmbcarrera
        '
        Me.cmbcarrera.FormattingEnabled = True
        Me.cmbcarrera.Location = New System.Drawing.Point(162, 110)
        Me.cmbcarrera.Name = "cmbcarrera"
        Me.cmbcarrera.Size = New System.Drawing.Size(156, 21)
        Me.cmbcarrera.TabIndex = 152
        '
        'cmbgrupos
        '
        Me.cmbgrupos.FormattingEnabled = True
        Me.cmbgrupos.Location = New System.Drawing.Point(162, 136)
        Me.cmbgrupos.Name = "cmbgrupos"
        Me.cmbgrupos.Size = New System.Drawing.Size(156, 21)
        Me.cmbgrupos.TabIndex = 153
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(27, 84)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(52, 16)
        Me.Label4.TabIndex = 154
        Me.Label4.Text = "Turno:"
        '
        'cmbturno
        '
        Me.cmbturno.FormattingEnabled = True
        Me.cmbturno.Location = New System.Drawing.Point(162, 83)
        Me.cmbturno.Name = "cmbturno"
        Me.cmbturno.Size = New System.Drawing.Size(156, 21)
        Me.cmbturno.TabIndex = 155
        '
        'cmbmat
        '
        Me.cmbmat.FormattingEnabled = True
        Me.cmbmat.Location = New System.Drawing.Point(162, 163)
        Me.cmbmat.Name = "cmbmat"
        Me.cmbmat.Size = New System.Drawing.Size(156, 21)
        Me.cmbmat.TabIndex = 156
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(27, 168)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(64, 16)
        Me.Label5.TabIndex = 157
        Me.Label5.Text = "Materia:"
        '
        'txtidturno
        '
        Me.txtidturno.Location = New System.Drawing.Point(520, 273)
        Me.txtidturno.Name = "txtidturno"
        Me.txtidturno.Size = New System.Drawing.Size(60, 20)
        Me.txtidturno.TabIndex = 158
        '
        'txtaño
        '
        Me.txtaño.Location = New System.Drawing.Point(519, 247)
        Me.txtaño.Name = "txtaño"
        Me.txtaño.Size = New System.Drawing.Size(61, 20)
        Me.txtaño.TabIndex = 159
        '
        'txtcodgrupo
        '
        Me.txtcodgrupo.Location = New System.Drawing.Point(520, 299)
        Me.txtcodgrupo.Name = "txtcodgrupo"
        Me.txtcodgrupo.Size = New System.Drawing.Size(52, 20)
        Me.txtcodgrupo.TabIndex = 160
        '
        'txtcodmat
        '
        Me.txtcodmat.Location = New System.Drawing.Point(519, 325)
        Me.txtcodmat.Name = "txtcodmat"
        Me.txtcodmat.Size = New System.Drawing.Size(52, 20)
        Me.txtcodmat.TabIndex = 161
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(27, 195)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(55, 16)
        Me.Label6.TabIndex = 162
        Me.Label6.Text = "Fecha:"
        '
        'dtpfecha
        '
        Me.dtpfecha.CustomFormat = """dd/MM/yyyy"""
        Me.dtpfecha.Location = New System.Drawing.Point(162, 195)
        Me.dtpfecha.Name = "dtpfecha"
        Me.dtpfecha.Size = New System.Drawing.Size(156, 20)
        Me.dtpfecha.TabIndex = 163
        Me.dtpfecha.Value = New Date(2013, 10, 23, 0, 0, 0, 0)
        '
        'txtcidoc
        '
        Me.txtcidoc.Location = New System.Drawing.Point(517, 221)
        Me.txtcidoc.Name = "txtcidoc"
        Me.txtcidoc.Size = New System.Drawing.Size(54, 20)
        Me.txtcidoc.TabIndex = 164
        '
        'asignarGrupo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(620, 356)
        Me.Controls.Add(Me.txtcidoc)
        Me.Controls.Add(Me.dtpfecha)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtcodmat)
        Me.Controls.Add(Me.txtcodgrupo)
        Me.Controls.Add(Me.txtaño)
        Me.Controls.Add(Me.txtidturno)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.cmbmat)
        Me.Controls.Add(Me.cmbturno)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.cmbgrupos)
        Me.Controls.Add(Me.cmbcarrera)
        Me.Controls.Add(Me.cmbdocente)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblfechaa)
        Me.Controls.Add(Me.lblrol)
        Me.Controls.Add(Me.bnclose)
        Me.Controls.Add(Me.lbltipou)
        Me.Controls.Add(Me.btnconf)
        Me.Controls.Add(Me.btnatras)
        Me.Controls.Add(Me.lbldocee)
        Me.Controls.Add(Me.lbltitulo)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "asignarGrupo"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "S.I.B.A."
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lbltitulo As System.Windows.Forms.Label
    Friend WithEvents btnatras As System.Windows.Forms.Button
    Friend WithEvents btnconf As System.Windows.Forms.Button
    Friend WithEvents lblrol As System.Windows.Forms.Label
    Friend WithEvents lbltipou As System.Windows.Forms.Label
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents lbldocee As System.Windows.Forms.Label
    Friend WithEvents bnclose As System.Windows.Forms.Button
    Friend WithEvents lblfechaa As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents cmbdocente As System.Windows.Forms.ComboBox
    Friend WithEvents cmbcarrera As System.Windows.Forms.ComboBox
    Friend WithEvents cmbgrupos As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents cmbturno As System.Windows.Forms.ComboBox
    Friend WithEvents cmbmat As System.Windows.Forms.ComboBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtaño As System.Windows.Forms.TextBox
    Friend WithEvents txtidturno As System.Windows.Forms.TextBox
    Friend WithEvents txtcodgrupo As System.Windows.Forms.TextBox
    Friend WithEvents txtcodmat As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents dtpfecha As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtcidoc As System.Windows.Forms.TextBox
End Class
