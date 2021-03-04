<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class altaMateria
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
        Dim lbltipou As System.Windows.Forms.Label
        Me.cmbcarr = New System.Windows.Forms.ComboBox
        Me.btncont = New System.Windows.Forms.Button
        Me.lbldial3 = New System.Windows.Forms.Label
        Me.cmbaño = New System.Windows.Forms.ComboBox
        Me.lbltitulo = New System.Windows.Forms.Label
        Me.gbxmat = New System.Windows.Forms.GroupBox
        Me.gbxedit = New System.Windows.Forms.GroupBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.Label11 = New System.Windows.Forms.Label
        Me.Label12 = New System.Windows.Forms.Label
        Me.lblver = New System.Windows.Forms.Label
        Me.txtaño = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.cmbcargah = New System.Windows.Forms.ComboBox
        Me.cmbtipo = New System.Windows.Forms.ComboBox
        Me.txtnombre = New System.Windows.Forms.TextBox
        Me.txtcod = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.btnaceptar = New System.Windows.Forms.Button
        Me.btnatras = New System.Windows.Forms.Button
        Me.lblrol = New System.Windows.Forms.Label
        Me.btnclose = New System.Windows.Forms.Button
        Me.gbxdatos = New System.Windows.Forms.GroupBox
        Me.lbldial2 = New System.Windows.Forms.Label
        Me.lbldial1 = New System.Windows.Forms.Label
        Me.txtcarga = New System.Windows.Forms.TextBox
        Me.txtcodigo = New System.Windows.Forms.TextBox
        Me.Button1 = New System.Windows.Forms.Button
        Me.lblsiba = New System.Windows.Forms.Label
        Me.cmbnomcarr = New System.Windows.Forms.ComboBox
        lbltipou = New System.Windows.Forms.Label
        Me.gbxmat.SuspendLayout()
        Me.gbxedit.SuspendLayout()
        Me.gbxdatos.SuspendLayout()
        Me.SuspendLayout()
        '
        'lbltipou
        '
        lbltipou.AutoSize = True
        lbltipou.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        lbltipou.Location = New System.Drawing.Point(466, 9)
        lbltipou.Name = "lbltipou"
        lbltipou.Size = New System.Drawing.Size(137, 16)
        lbltipou.TabIndex = 139
        lbltipou.Text = "Secretario Escolar"
        '
        'cmbcarr
        '
        Me.cmbcarr.FormattingEnabled = True
        Me.cmbcarr.Location = New System.Drawing.Point(5, 72)
        Me.cmbcarr.Name = "cmbcarr"
        Me.cmbcarr.Size = New System.Drawing.Size(204, 28)
        Me.cmbcarr.TabIndex = 124
        '
        'btncont
        '
        Me.btncont.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btncont.Location = New System.Drawing.Point(122, 180)
        Me.btncont.Name = "btncont"
        Me.btncont.Size = New System.Drawing.Size(87, 26)
        Me.btncont.TabIndex = 133
        Me.btncont.Text = "Continuar"
        Me.btncont.UseVisualStyleBackColor = True
        '
        'lbldial3
        '
        Me.lbldial3.AutoSize = True
        Me.lbldial3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbldial3.Location = New System.Drawing.Point(6, 121)
        Me.lbldial3.Name = "lbldial3"
        Me.lbldial3.Size = New System.Drawing.Size(193, 16)
        Me.lbldial3.TabIndex = 132
        Me.lbldial3.Text = "Seleccione el año escolar "
        '
        'cmbaño
        '
        Me.cmbaño.FormattingEnabled = True
        Me.cmbaño.Location = New System.Drawing.Point(5, 140)
        Me.cmbaño.Name = "cmbaño"
        Me.cmbaño.Size = New System.Drawing.Size(204, 28)
        Me.cmbaño.TabIndex = 131
        '
        'lbltitulo
        '
        Me.lbltitulo.AutoSize = True
        Me.lbltitulo.BackColor = System.Drawing.Color.LemonChiffon
        Me.lbltitulo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbltitulo.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltitulo.Location = New System.Drawing.Point(2, 9)
        Me.lbltitulo.Name = "lbltitulo"
        Me.lbltitulo.Size = New System.Drawing.Size(304, 26)
        Me.lbltitulo.TabIndex = 135
        Me.lbltitulo.Text = "MODIFICACIÓN DE MATERIAS"
        '
        'gbxmat
        '
        Me.gbxmat.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbxmat.Controls.Add(Me.cmbnomcarr)
        Me.gbxmat.Controls.Add(Me.gbxedit)
        Me.gbxmat.Controls.Add(Me.txtaño)
        Me.gbxmat.Controls.Add(Me.Label1)
        Me.gbxmat.Controls.Add(Me.cmbcargah)
        Me.gbxmat.Controls.Add(Me.cmbtipo)
        Me.gbxmat.Controls.Add(Me.txtnombre)
        Me.gbxmat.Controls.Add(Me.txtcod)
        Me.gbxmat.Controls.Add(Me.Label2)
        Me.gbxmat.Controls.Add(Me.Label5)
        Me.gbxmat.Controls.Add(Me.Label4)
        Me.gbxmat.Controls.Add(Me.Label3)
        Me.gbxmat.Controls.Add(Me.Label7)
        Me.gbxmat.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbxmat.Location = New System.Drawing.Point(277, 140)
        Me.gbxmat.Name = "gbxmat"
        Me.gbxmat.Size = New System.Drawing.Size(351, 231)
        Me.gbxmat.TabIndex = 138
        Me.gbxmat.TabStop = False
        Me.gbxmat.Text = "Materias"
        '
        'gbxedit
        '
        Me.gbxedit.Controls.Add(Me.Label6)
        Me.gbxedit.Controls.Add(Me.Label10)
        Me.gbxedit.Controls.Add(Me.Label11)
        Me.gbxedit.Controls.Add(Me.Label12)
        Me.gbxedit.Controls.Add(Me.lblver)
        Me.gbxedit.Location = New System.Drawing.Point(258, 40)
        Me.gbxedit.Name = "gbxedit"
        Me.gbxedit.Size = New System.Drawing.Size(72, 181)
        Me.gbxedit.TabIndex = 142
        Me.gbxedit.TabStop = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(6, 18)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(49, 16)
        Me.Label6.TabIndex = 23
        Me.Label6.Text = "Editar"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(6, 150)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(49, 16)
        Me.Label10.TabIndex = 26
        Me.Label10.Text = "Editar"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(6, 106)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(49, 16)
        Me.Label11.TabIndex = 25
        Me.Label11.Text = "Editar"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(6, 62)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(49, 16)
        Me.Label12.TabIndex = 24
        Me.Label12.Text = "Editar"
        '
        'lblver
        '
        Me.lblver.AutoSize = True
        Me.lblver.Location = New System.Drawing.Point(23, 152)
        Me.lblver.Name = "lblver"
        Me.lblver.Size = New System.Drawing.Size(0, 16)
        Me.lblver.TabIndex = 19
        '
        'txtaño
        '
        Me.txtaño.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtaño.Location = New System.Drawing.Point(133, 58)
        Me.txtaño.Name = "txtaño"
        Me.txtaño.ReadOnly = True
        Me.txtaño.Size = New System.Drawing.Size(118, 22)
        Me.txtaño.TabIndex = 14
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(130, 40)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(35, 16)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "Año:"
        '
        'cmbcargah
        '
        Me.cmbcargah.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbcargah.FormattingEnabled = True
        Me.cmbcargah.Items.AddRange(New Object() {"(Seleccione)", "2", "3", "4", "5", "6"})
        Me.cmbcargah.Location = New System.Drawing.Point(132, 140)
        Me.cmbcargah.Name = "cmbcargah"
        Me.cmbcargah.Size = New System.Drawing.Size(118, 21)
        Me.cmbcargah.TabIndex = 12
        '
        'cmbtipo
        '
        Me.cmbtipo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbtipo.FormattingEnabled = True
        Me.cmbtipo.Items.AddRange(New Object() {"(Seleccione)", "Tecnológica", "Equivalencia"})
        Me.cmbtipo.Location = New System.Drawing.Point(9, 138)
        Me.cmbtipo.Name = "cmbtipo"
        Me.cmbtipo.Size = New System.Drawing.Size(118, 21)
        Me.cmbtipo.TabIndex = 11
        '
        'txtnombre
        '
        Me.txtnombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtnombre.Location = New System.Drawing.Point(9, 98)
        Me.txtnombre.Name = "txtnombre"
        Me.txtnombre.Size = New System.Drawing.Size(241, 22)
        Me.txtnombre.TabIndex = 7
        '
        'txtcod
        '
        Me.txtcod.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtcod.Location = New System.Drawing.Point(9, 58)
        Me.txtcod.Name = "txtcod"
        Me.txtcod.Size = New System.Drawing.Size(118, 22)
        Me.txtcod.TabIndex = 6
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(6, 170)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(106, 16)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Nombre carrera:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(6, 120)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(39, 16)
        Me.Label5.TabIndex = 3
        Me.Label5.Text = "Tipo:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(130, 120)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(96, 16)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Carga Horaria:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(6, 80)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(60, 16)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Nombre:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(6, 40)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(55, 16)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = "Código:"
        '
        'btnaceptar
        '
        Me.btnaceptar.BackColor = System.Drawing.Color.Transparent
        Me.btnaceptar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnaceptar.Location = New System.Drawing.Point(425, 140)
        Me.btnaceptar.Name = "btnaceptar"
        Me.btnaceptar.Size = New System.Drawing.Size(101, 22)
        Me.btnaceptar.TabIndex = 137
        Me.btnaceptar.Text = "Ingresar"
        Me.btnaceptar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage
        Me.btnaceptar.UseVisualStyleBackColor = False
        '
        'btnatras
        '
        Me.btnatras.BackColor = System.Drawing.Color.Transparent
        Me.btnatras.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnatras.Location = New System.Drawing.Point(425, 181)
        Me.btnatras.Name = "btnatras"
        Me.btnatras.Size = New System.Drawing.Size(101, 22)
        Me.btnatras.TabIndex = 136
        Me.btnatras.Text = "Finalizar"
        Me.btnatras.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage
        Me.btnatras.UseVisualStyleBackColor = False
        '
        'lblrol
        '
        Me.lblrol.AutoSize = True
        Me.lblrol.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblrol.Location = New System.Drawing.Point(434, 9)
        Me.lblrol.Name = "lblrol"
        Me.lblrol.Size = New System.Drawing.Size(36, 16)
        Me.lblrol.TabIndex = 141
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
        Me.btnclose.TabIndex = 140
        Me.btnclose.Text = "Cerrar sesión"
        Me.btnclose.UseVisualStyleBackColor = True
        '
        'gbxdatos
        '
        Me.gbxdatos.Controls.Add(Me.lbldial2)
        Me.gbxdatos.Controls.Add(Me.lbldial1)
        Me.gbxdatos.Controls.Add(Me.btncont)
        Me.gbxdatos.Controls.Add(Me.lbldial3)
        Me.gbxdatos.Controls.Add(Me.cmbaño)
        Me.gbxdatos.Controls.Add(Me.cmbcarr)
        Me.gbxdatos.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbxdatos.Location = New System.Drawing.Point(15, 52)
        Me.gbxdatos.Name = "gbxdatos"
        Me.gbxdatos.Size = New System.Drawing.Size(235, 222)
        Me.gbxdatos.TabIndex = 142
        Me.gbxdatos.TabStop = False
        Me.gbxdatos.Text = "Datos"
        '
        'lbldial2
        '
        Me.lbldial2.AutoSize = True
        Me.lbldial2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbldial2.Location = New System.Drawing.Point(6, 53)
        Me.lbldial2.Name = "lbldial2"
        Me.lbldial2.Size = New System.Drawing.Size(208, 16)
        Me.lbldial2.TabIndex = 136
        Me.lbldial2.Text = "se le asignarán las materias "
        '
        'lbldial1
        '
        Me.lbldial1.AutoSize = True
        Me.lbldial1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbldial1.Location = New System.Drawing.Point(6, 16)
        Me.lbldial1.Name = "lbldial1"
        Me.lbldial1.Size = New System.Drawing.Size(220, 16)
        Me.lbldial1.TabIndex = 135
        Me.lbldial1.Text = "Seleccione la carrera a la cual"
        '
        'txtcarga
        '
        Me.txtcarga.Location = New System.Drawing.Point(293, 68)
        Me.txtcarga.Name = "txtcarga"
        Me.txtcarga.Size = New System.Drawing.Size(100, 20)
        Me.txtcarga.TabIndex = 143
        '
        'txtcodigo
        '
        Me.txtcodigo.Location = New System.Drawing.Point(293, 89)
        Me.txtcodigo.Name = "txtcodigo"
        Me.txtcodigo.Size = New System.Drawing.Size(100, 20)
        Me.txtcodigo.TabIndex = 144
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.Red
        Me.Button1.Location = New System.Drawing.Point(15, 316)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(202, 24)
        Me.Button1.TabIndex = 145
        Me.Button1.Text = "Administrador Materias"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'lblsiba
        '
        Me.lblsiba.Font = New System.Drawing.Font("Pristina", 26.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblsiba.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblsiba.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblsiba.Location = New System.Drawing.Point(306, 9)
        Me.lblsiba.Name = "lblsiba"
        Me.lblsiba.Size = New System.Drawing.Size(129, 43)
        Me.lblsiba.TabIndex = 146
        Me.lblsiba.Text = "S.I.B.A."
        '
        'cmbnomcarr
        '
        Me.cmbnomcarr.FormattingEnabled = True
        Me.cmbnomcarr.Items.AddRange(New Object() {"(Seleccione)", "EMT Informática", "EMT Administración"})
        Me.cmbnomcarr.Location = New System.Drawing.Point(9, 190)
        Me.cmbnomcarr.Name = "cmbnomcarr"
        Me.cmbnomcarr.Size = New System.Drawing.Size(242, 24)
        Me.cmbnomcarr.TabIndex = 147
        '
        'altaMateria
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(620, 356)
        Me.Controls.Add(Me.lblsiba)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.txtcodigo)
        Me.Controls.Add(Me.txtcarga)
        Me.Controls.Add(Me.gbxdatos)
        Me.Controls.Add(Me.lblrol)
        Me.Controls.Add(Me.btnclose)
        Me.Controls.Add(lbltipou)
        Me.Controls.Add(Me.gbxmat)
        Me.Controls.Add(Me.btnaceptar)
        Me.Controls.Add(Me.btnatras)
        Me.Controls.Add(Me.lbltitulo)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "altaMateria"
        Me.ShowInTaskbar = False
        Me.Text = "S.I.B.A"
        Me.gbxmat.ResumeLayout(False)
        Me.gbxmat.PerformLayout()
        Me.gbxedit.ResumeLayout(False)
        Me.gbxedit.PerformLayout()
        Me.gbxdatos.ResumeLayout(False)
        Me.gbxdatos.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cmbcarr As System.Windows.Forms.ComboBox
    Friend WithEvents btncont As System.Windows.Forms.Button
    Friend WithEvents lbldial3 As System.Windows.Forms.Label
    Friend WithEvents cmbaño As System.Windows.Forms.ComboBox
    Friend WithEvents lbltitulo As System.Windows.Forms.Label
    Friend WithEvents gbxmat As System.Windows.Forms.GroupBox
    Friend WithEvents txtnombre As System.Windows.Forms.TextBox
    Friend WithEvents txtcod As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents btnaceptar As System.Windows.Forms.Button
    Friend WithEvents btnatras As System.Windows.Forms.Button
    Friend WithEvents cmbcargah As System.Windows.Forms.ComboBox
    Friend WithEvents cmbtipo As System.Windows.Forms.ComboBox
    Friend WithEvents lblrol As System.Windows.Forms.Label
    Friend WithEvents btnclose As System.Windows.Forms.Button
    Friend WithEvents txtaño As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents gbxedit As System.Windows.Forms.GroupBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents lblver As System.Windows.Forms.Label
    Friend WithEvents gbxdatos As System.Windows.Forms.GroupBox
    Friend WithEvents lbldial2 As System.Windows.Forms.Label
    Friend WithEvents lbldial1 As System.Windows.Forms.Label
    Friend WithEvents txtcarga As System.Windows.Forms.TextBox
    Friend WithEvents txtcodigo As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents lblsiba As System.Windows.Forms.Label
    Friend WithEvents cmbnomcarr As System.Windows.Forms.ComboBox
End Class
