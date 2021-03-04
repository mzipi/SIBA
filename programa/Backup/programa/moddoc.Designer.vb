<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class modDocente
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
        Me.btnmod = New System.Windows.Forms.Button
        Me.btnatras = New System.Windows.Forms.Button
        Me.gbxdoc = New System.Windows.Forms.GroupBox
        Me.txtvac_hasta = New System.Windows.Forms.TextBox
        Me.txtvac_desde = New System.Windows.Forms.TextBox
        Me.cmbestfun = New System.Windows.Forms.ComboBox
        Me.cmbgrado = New System.Windows.Forms.ComboBox
        Me.Label10 = New System.Windows.Forms.Label
        Me.txttel = New System.Windows.Forms.TextBox
        Me.txtant = New System.Windows.Forms.TextBox
        Me.txtformac = New System.Windows.Forms.TextBox
        Me.txtci = New System.Windows.Forms.TextBox
        Me.txtnombre = New System.Windows.Forms.TextBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.lbltitulo = New System.Windows.Forms.Label
        Me.lblrol = New System.Windows.Forms.Label
        Me.btnclose = New System.Windows.Forms.Button
        Me.lbltipou = New System.Windows.Forms.Label
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.gbxdoc.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnmod
        '
        Me.btnmod.BackColor = System.Drawing.Color.Transparent
        Me.btnmod.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnmod.Location = New System.Drawing.Point(366, 133)
        Me.btnmod.Name = "btnmod"
        Me.btnmod.Size = New System.Drawing.Size(101, 22)
        Me.btnmod.TabIndex = 19
        Me.btnmod.Text = "Modificar"
        Me.btnmod.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage
        Me.btnmod.UseVisualStyleBackColor = False
        '
        'btnatras
        '
        Me.btnatras.BackColor = System.Drawing.Color.Transparent
        Me.btnatras.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnatras.Location = New System.Drawing.Point(366, 174)
        Me.btnatras.Name = "btnatras"
        Me.btnatras.Size = New System.Drawing.Size(101, 22)
        Me.btnatras.TabIndex = 18
        Me.btnatras.Text = "Atrás"
        Me.btnatras.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage
        Me.btnatras.UseVisualStyleBackColor = False
        '
        'gbxdoc
        '
        Me.gbxdoc.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbxdoc.Controls.Add(Me.txtvac_hasta)
        Me.gbxdoc.Controls.Add(Me.txtvac_desde)
        Me.gbxdoc.Controls.Add(Me.cmbestfun)
        Me.gbxdoc.Controls.Add(Me.cmbgrado)
        Me.gbxdoc.Controls.Add(Me.Label10)
        Me.gbxdoc.Controls.Add(Me.txttel)
        Me.gbxdoc.Controls.Add(Me.txtant)
        Me.gbxdoc.Controls.Add(Me.txtformac)
        Me.gbxdoc.Controls.Add(Me.txtci)
        Me.gbxdoc.Controls.Add(Me.txtnombre)
        Me.gbxdoc.Controls.Add(Me.Label7)
        Me.gbxdoc.Controls.Add(Me.Label6)
        Me.gbxdoc.Controls.Add(Me.Label5)
        Me.gbxdoc.Controls.Add(Me.Label4)
        Me.gbxdoc.Controls.Add(Me.Label3)
        Me.gbxdoc.Controls.Add(Me.Label2)
        Me.gbxdoc.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbxdoc.Location = New System.Drawing.Point(15, 55)
        Me.gbxdoc.Name = "gbxdoc"
        Me.gbxdoc.Size = New System.Drawing.Size(240, 329)
        Me.gbxdoc.TabIndex = 21
        Me.gbxdoc.TabStop = False
        Me.gbxdoc.Text = "Docentes"
        '
        'txtvac_hasta
        '
        Me.txtvac_hasta.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtvac_hasta.Location = New System.Drawing.Point(133, 301)
        Me.txtvac_hasta.MaxLength = 2
        Me.txtvac_hasta.Name = "txtvac_hasta"
        Me.txtvac_hasta.Size = New System.Drawing.Size(94, 22)
        Me.txtvac_hasta.TabIndex = 20
        '
        'txtvac_desde
        '
        Me.txtvac_desde.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtvac_desde.Location = New System.Drawing.Point(9, 301)
        Me.txtvac_desde.MaxLength = 2
        Me.txtvac_desde.Name = "txtvac_desde"
        Me.txtvac_desde.Size = New System.Drawing.Size(94, 22)
        Me.txtvac_desde.TabIndex = 19
        '
        'cmbestfun
        '
        Me.cmbestfun.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbestfun.FormattingEnabled = True
        Me.cmbestfun.Items.AddRange(New Object() {"(Seleccione)", "Activo", "Art 70.1", "Art 70.2"})
        Me.cmbestfun.Location = New System.Drawing.Point(9, 262)
        Me.cmbestfun.Name = "cmbestfun"
        Me.cmbestfun.Size = New System.Drawing.Size(218, 24)
        Me.cmbestfun.TabIndex = 18
        '
        'cmbgrado
        '
        Me.cmbgrado.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbgrado.FormattingEnabled = True
        Me.cmbgrado.Items.AddRange(New Object() {"(Seleccione)", "1", "2", "3", "4", "5", "6", "7"})
        Me.cmbgrado.Location = New System.Drawing.Point(133, 138)
        Me.cmbgrado.Name = "cmbgrado"
        Me.cmbgrado.Size = New System.Drawing.Size(94, 24)
        Me.cmbgrado.TabIndex = 17
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(6, 243)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(115, 16)
        Me.Label10.TabIndex = 15
        Me.Label10.Text = "Estado Funcional:"
        '
        'txttel
        '
        Me.txttel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txttel.Location = New System.Drawing.Point(9, 218)
        Me.txttel.MaxLength = 10
        Me.txttel.Name = "txttel"
        Me.txttel.Size = New System.Drawing.Size(218, 22)
        Me.txttel.TabIndex = 12
        Me.txttel.Text = "22222222"
        '
        'txtant
        '
        Me.txtant.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtant.Location = New System.Drawing.Point(9, 138)
        Me.txtant.MaxLength = 2
        Me.txtant.Name = "txtant"
        Me.txtant.Size = New System.Drawing.Size(94, 22)
        Me.txtant.TabIndex = 11
        Me.txtant.Text = "8"
        '
        'txtformac
        '
        Me.txtformac.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtformac.Location = New System.Drawing.Point(9, 178)
        Me.txtformac.Name = "txtformac"
        Me.txtformac.Size = New System.Drawing.Size(218, 22)
        Me.txtformac.TabIndex = 9
        Me.txtformac.Text = "Ingeniero"
        '
        'txtci
        '
        Me.txtci.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtci.Location = New System.Drawing.Point(9, 98)
        Me.txtci.MaxLength = 10
        Me.txtci.Name = "txtci"
        Me.txtci.Size = New System.Drawing.Size(218, 22)
        Me.txtci.TabIndex = 7
        Me.txtci.Text = "1234567"
        '
        'txtnombre
        '
        Me.txtnombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtnombre.Location = New System.Drawing.Point(9, 58)
        Me.txtnombre.MaxLength = 50
        Me.txtnombre.Name = "txtnombre"
        Me.txtnombre.Size = New System.Drawing.Size(218, 22)
        Me.txtnombre.TabIndex = 6
        Me.txtnombre.Text = "Carámbula Leonardo"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(6, 200)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(65, 16)
        Me.Label7.TabIndex = 5
        Me.Label7.Text = "Teléfono:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(6, 160)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(147, 16)
        Me.Label6.TabIndex = 4
        Me.Label6.Text = "Formación Academica:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(6, 120)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(80, 16)
        Me.Label5.TabIndex = 3
        Me.Label5.Text = "Antiguedad:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(130, 120)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(49, 16)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Grado:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(6, 80)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(132, 16)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Cedula de Identidad:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(6, 40)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(121, 16)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Nombre Completo:"
        '
        'lbltitulo
        '
        Me.lbltitulo.AutoSize = True
        Me.lbltitulo.BackColor = System.Drawing.Color.LemonChiffon
        Me.lbltitulo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbltitulo.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltitulo.Location = New System.Drawing.Point(15, 9)
        Me.lbltitulo.Name = "lbltitulo"
        Me.lbltitulo.Size = New System.Drawing.Size(230, 26)
        Me.lbltitulo.TabIndex = 53
        Me.lbltitulo.Text = "MODIFICAR DOCENTE"
        '
        'lblrol
        '
        Me.lblrol.AutoSize = True
        Me.lblrol.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblrol.Location = New System.Drawing.Point(424, 9)
        Me.lblrol.Name = "lblrol"
        Me.lblrol.Size = New System.Drawing.Size(36, 16)
        Me.lblrol.TabIndex = 71
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
        Me.btnclose.TabIndex = 70
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
        Me.lbltipou.TabIndex = 69
        Me.lbltipou.Text = "Secretario Escolar"
        '
        'ToolTip1
        '
        Me.ToolTip1.IsBalloon = True
        '
        'modDocente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(620, 396)
        Me.Controls.Add(Me.lblrol)
        Me.Controls.Add(Me.btnclose)
        Me.Controls.Add(Me.lbltipou)
        Me.Controls.Add(Me.lbltitulo)
        Me.Controls.Add(Me.gbxdoc)
        Me.Controls.Add(Me.btnmod)
        Me.Controls.Add(Me.btnatras)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "modDocente"
        Me.Text = "S.I.B.A"
        Me.gbxdoc.ResumeLayout(False)
        Me.gbxdoc.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnmod As System.Windows.Forms.Button
    Friend WithEvents btnatras As System.Windows.Forms.Button
    Friend WithEvents gbxdoc As System.Windows.Forms.GroupBox
    Friend WithEvents txttel As System.Windows.Forms.TextBox
    Friend WithEvents txtant As System.Windows.Forms.TextBox
    Friend WithEvents txtformac As System.Windows.Forms.TextBox
    Friend WithEvents txtci As System.Windows.Forms.TextBox
    Friend WithEvents txtnombre As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lbltitulo As System.Windows.Forms.Label
    Friend WithEvents lblrol As System.Windows.Forms.Label
    Friend WithEvents btnclose As System.Windows.Forms.Button
    Friend WithEvents lbltipou As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents cmbgrado As System.Windows.Forms.ComboBox
    Friend WithEvents cmbestfun As System.Windows.Forms.ComboBox
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents txtvac_hasta As System.Windows.Forms.TextBox
    Friend WithEvents txtvac_desde As System.Windows.Forms.TextBox
End Class

