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
        Me.lbldial1 = New System.Windows.Forms.Label
        Me.cmbcarr = New System.Windows.Forms.ComboBox
        Me.btncont = New System.Windows.Forms.Button
        Me.lbldial3 = New System.Windows.Forms.Label
        Me.cmba�o = New System.Windows.Forms.ComboBox
        Me.lbldial2 = New System.Windows.Forms.Label
        Me.lbltitulo = New System.Windows.Forms.Label
        Me.gbxmat = New System.Windows.Forms.GroupBox
        Me.txta�o = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.cmbcargah = New System.Windows.Forms.ComboBox
        Me.cmbtipo = New System.Windows.Forms.ComboBox
        Me.txtnomcar = New System.Windows.Forms.TextBox
        Me.txtnombre = New System.Windows.Forms.TextBox
        Me.txtcod = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.btning = New System.Windows.Forms.Button
        Me.btnatras = New System.Windows.Forms.Button
        Me.lblrol = New System.Windows.Forms.Label
        Me.btnclose = New System.Windows.Forms.Button
        lbltipou = New System.Windows.Forms.Label
        Me.gbxmat.SuspendLayout()
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
        'lbldial1
        '
        Me.lbldial1.AutoSize = True
        Me.lbldial1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbldial1.Location = New System.Drawing.Point(20, 45)
        Me.lbldial1.Name = "lbldial1"
        Me.lbldial1.Size = New System.Drawing.Size(220, 16)
        Me.lbldial1.TabIndex = 123
        Me.lbldial1.Text = "Seleccione la carrera a la cual"
        '
        'cmbcarr
        '
        Me.cmbcarr.FormattingEnabled = True
        Me.cmbcarr.Items.AddRange(New Object() {"(Seleccione)", "EMT Administraci�n", "EMP Administraci�n", "EMT Inform�tica", "Tecnicatura en Redes"})
        Me.cmbcarr.Location = New System.Drawing.Point(20, 96)
        Me.cmbcarr.Name = "cmbcarr"
        Me.cmbcarr.Size = New System.Drawing.Size(204, 21)
        Me.cmbcarr.TabIndex = 124
        '
        'btncont
        '
        Me.btncont.Location = New System.Drawing.Point(153, 204)
        Me.btncont.Name = "btncont"
        Me.btncont.Size = New System.Drawing.Size(70, 26)
        Me.btncont.TabIndex = 133
        Me.btncont.Text = "Continuar"
        Me.btncont.UseVisualStyleBackColor = True
        '
        'lbldial3
        '
        Me.lbldial3.AutoSize = True
        Me.lbldial3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbldial3.Location = New System.Drawing.Point(20, 138)
        Me.lbldial3.Name = "lbldial3"
        Me.lbldial3.Size = New System.Drawing.Size(193, 16)
        Me.lbldial3.TabIndex = 132
        Me.lbldial3.Text = "Seleccione el a�o escolar "
        '
        'cmba�o
        '
        Me.cmba�o.FormattingEnabled = True
        Me.cmba�o.Items.AddRange(New Object() {"(Seleccione)", "1�", "2�", "3�"})
        Me.cmba�o.Location = New System.Drawing.Point(20, 171)
        Me.cmba�o.Name = "cmba�o"
        Me.cmba�o.Size = New System.Drawing.Size(204, 21)
        Me.cmba�o.TabIndex = 131
        '
        'lbldial2
        '
        Me.lbldial2.AutoSize = True
        Me.lbldial2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbldial2.Location = New System.Drawing.Point(20, 70)
        Me.lbldial2.Name = "lbldial2"
        Me.lbldial2.Size = New System.Drawing.Size(208, 16)
        Me.lbldial2.TabIndex = 134
        Me.lbldial2.Text = "se le asignar�n las materias "
        '
        'lbltitulo
        '
        Me.lbltitulo.AutoSize = True
        Me.lbltitulo.BackColor = System.Drawing.Color.LemonChiffon
        Me.lbltitulo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbltitulo.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltitulo.Location = New System.Drawing.Point(15, 9)
        Me.lbltitulo.Name = "lbltitulo"
        Me.lbltitulo.Size = New System.Drawing.Size(248, 26)
        Me.lbltitulo.TabIndex = 135
        Me.lbltitulo.Text = "INGRESO DE MATERIAS"
        '
        'gbxmat
        '
        Me.gbxmat.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbxmat.Controls.Add(Me.txta�o)
        Me.gbxmat.Controls.Add(Me.Label1)
        Me.gbxmat.Controls.Add(Me.cmbcargah)
        Me.gbxmat.Controls.Add(Me.cmbtipo)
        Me.gbxmat.Controls.Add(Me.txtnomcar)
        Me.gbxmat.Controls.Add(Me.txtnombre)
        Me.gbxmat.Controls.Add(Me.txtcod)
        Me.gbxmat.Controls.Add(Me.Label2)
        Me.gbxmat.Controls.Add(Me.Label5)
        Me.gbxmat.Controls.Add(Me.Label4)
        Me.gbxmat.Controls.Add(Me.Label3)
        Me.gbxmat.Controls.Add(Me.Label7)
        Me.gbxmat.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbxmat.Location = New System.Drawing.Point(262, 248)
        Me.gbxmat.Name = "gbxmat"
        Me.gbxmat.Size = New System.Drawing.Size(283, 216)
        Me.gbxmat.TabIndex = 138
        Me.gbxmat.TabStop = False
        Me.gbxmat.Text = "Ingresar"
        '
        'txta�o
        '
        Me.txta�o.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txta�o.Location = New System.Drawing.Point(133, 58)
        Me.txta�o.Name = "txta�o"
        Me.txta�o.ReadOnly = True
        Me.txta�o.Size = New System.Drawing.Size(118, 22)
        Me.txta�o.TabIndex = 14
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(130, 40)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(35, 16)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "A�o:"
        '
        'cmbcargah
        '
        Me.cmbcargah.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbcargah.FormattingEnabled = True
        Me.cmbcargah.Items.AddRange(New Object() {"(Seleccione)", "2 ", "3", "4", "5", "6"})
        Me.cmbcargah.Location = New System.Drawing.Point(132, 140)
        Me.cmbcargah.Name = "cmbcargah"
        Me.cmbcargah.Size = New System.Drawing.Size(118, 21)
        Me.cmbcargah.TabIndex = 12
        '
        'cmbtipo
        '
        Me.cmbtipo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbtipo.FormattingEnabled = True
        Me.cmbtipo.Items.AddRange(New Object() {"(Seleccione)", "Tecnol�gica", "Equivalencia"})
        Me.cmbtipo.Location = New System.Drawing.Point(9, 138)
        Me.cmbtipo.Name = "cmbtipo"
        Me.cmbtipo.Size = New System.Drawing.Size(118, 21)
        Me.cmbtipo.TabIndex = 11
        '
        'txtnomcar
        '
        Me.txtnomcar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtnomcar.Location = New System.Drawing.Point(9, 189)
        Me.txtnomcar.Name = "txtnomcar"
        Me.txtnomcar.ReadOnly = True
        Me.txtnomcar.Size = New System.Drawing.Size(241, 22)
        Me.txtnomcar.TabIndex = 9
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
        Me.Label7.Text = "C�digo:"
        '
        'btning
        '
        Me.btning.BackColor = System.Drawing.Color.Transparent
        Me.btning.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btning.Location = New System.Drawing.Point(425, 140)
        Me.btning.Name = "btning"
        Me.btning.Size = New System.Drawing.Size(101, 22)
        Me.btning.TabIndex = 137
        Me.btning.Text = "Ingresar"
        Me.btning.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage
        Me.btning.UseVisualStyleBackColor = False
        '
        'btnatras
        '
        Me.btnatras.BackColor = System.Drawing.Color.Transparent
        Me.btnatras.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnatras.Location = New System.Drawing.Point(425, 181)
        Me.btnatras.Name = "btnatras"
        Me.btnatras.Size = New System.Drawing.Size(101, 22)
        Me.btnatras.TabIndex = 136
        Me.btnatras.Text = "Atr�s"
        Me.btnatras.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage
        Me.btnatras.UseVisualStyleBackColor = False
        '
        'lblrol
        '
        Me.lblrol.AutoSize = True
        Me.lblrol.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblrol.Location = New System.Drawing.Point(424, 9)
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
        Me.btnclose.Text = "Cerrar sesi�n"
        Me.btnclose.UseVisualStyleBackColor = True
        '
        'altaMateria
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(620, 356)
        Me.Controls.Add(Me.lblrol)
        Me.Controls.Add(Me.btnclose)
        Me.Controls.Add(lbltipou)
        Me.Controls.Add(Me.gbxmat)
        Me.Controls.Add(Me.btning)
        Me.Controls.Add(Me.btnatras)
        Me.Controls.Add(Me.lbltitulo)
        Me.Controls.Add(Me.lbldial2)
        Me.Controls.Add(Me.btncont)
        Me.Controls.Add(Me.lbldial3)
        Me.Controls.Add(Me.cmba�o)
        Me.Controls.Add(Me.cmbcarr)
        Me.Controls.Add(Me.lbldial1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "altaMateria"
        Me.ShowInTaskbar = False
        Me.Text = "S.I.B.A"
        Me.gbxmat.ResumeLayout(False)
        Me.gbxmat.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lbldial1 As System.Windows.Forms.Label
    Friend WithEvents cmbcarr As System.Windows.Forms.ComboBox
    Friend WithEvents btncont As System.Windows.Forms.Button
    Friend WithEvents lbldial3 As System.Windows.Forms.Label
    Friend WithEvents cmba�o As System.Windows.Forms.ComboBox
    Friend WithEvents lbldial2 As System.Windows.Forms.Label
    Friend WithEvents lbltitulo As System.Windows.Forms.Label
    Friend WithEvents gbxmat As System.Windows.Forms.GroupBox
    Friend WithEvents txtnomcar As System.Windows.Forms.TextBox
    Friend WithEvents txtnombre As System.Windows.Forms.TextBox
    Friend WithEvents txtcod As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents btning As System.Windows.Forms.Button
    Friend WithEvents btnatras As System.Windows.Forms.Button
    Friend WithEvents cmbcargah As System.Windows.Forms.ComboBox
    Friend WithEvents cmbtipo As System.Windows.Forms.ComboBox
    Friend WithEvents lblrol As System.Windows.Forms.Label
    Friend WithEvents btnclose As System.Windows.Forms.Button
    Friend WithEvents txta�o As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
