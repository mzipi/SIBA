<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class bajaDocente
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
        Me.btnelim = New System.Windows.Forms.Button
        Me.btnatras = New System.Windows.Forms.Button
        Me.lbltitulo = New System.Windows.Forms.Label
        Me.lblrol = New System.Windows.Forms.Label
        Me.btnclose = New System.Windows.Forms.Button
        Me.lbltipou = New System.Windows.Forms.Label
        Me.gbxdoc = New System.Windows.Forms.GroupBox
        Me.txtvac_hasta = New System.Windows.Forms.TextBox
        Me.txtvac_desde = New System.Windows.Forms.TextBox
        Me.cmbestfun = New System.Windows.Forms.ComboBox
        Me.cmbgrado = New System.Windows.Forms.ComboBox
        Me.lblestfun = New System.Windows.Forms.Label
        Me.txttel = New System.Windows.Forms.TextBox
        Me.txtant = New System.Windows.Forms.TextBox
        Me.txtformac = New System.Windows.Forms.TextBox
        Me.txtci = New System.Windows.Forms.TextBox
        Me.txtnombre = New System.Windows.Forms.TextBox
        Me.lbltel = New System.Windows.Forms.Label
        Me.lblformac = New System.Windows.Forms.Label
        Me.lblant = New System.Windows.Forms.Label
        Me.lblgrado = New System.Windows.Forms.Label
        Me.lblci = New System.Windows.Forms.Label
        Me.lblnombre = New System.Windows.Forms.Label
        Me.gbxdoc.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnelim
        '
        Me.btnelim.BackColor = System.Drawing.Color.Transparent
        Me.btnelim.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnelim.Location = New System.Drawing.Point(366, 126)
        Me.btnelim.Name = "btnelim"
        Me.btnelim.Size = New System.Drawing.Size(101, 22)
        Me.btnelim.TabIndex = 19
        Me.btnelim.Text = "Eliminar"
        Me.btnelim.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage
        Me.btnelim.UseVisualStyleBackColor = False
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
        'lbltitulo
        '
        Me.lbltitulo.AutoSize = True
        Me.lbltitulo.BackColor = System.Drawing.Color.LemonChiffon
        Me.lbltitulo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbltitulo.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltitulo.Location = New System.Drawing.Point(15, 9)
        Me.lbltitulo.Name = "lbltitulo"
        Me.lbltitulo.Size = New System.Drawing.Size(216, 26)
        Me.lbltitulo.TabIndex = 54
        Me.lbltitulo.Text = "BAJA DE DOCENTES"
        '
        'lblrol
        '
        Me.lblrol.AutoSize = True
        Me.lblrol.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblrol.Location = New System.Drawing.Point(337, 15)
        Me.lblrol.Name = "lblrol"
        Me.lblrol.Size = New System.Drawing.Size(36, 16)
        Me.lblrol.TabIndex = 74
        Me.lblrol.Text = "Rol:"
        '
        'btnclose
        '
        Me.btnclose.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnclose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnclose.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnclose.Location = New System.Drawing.Point(405, 34)
        Me.btnclose.Name = "btnclose"
        Me.btnclose.Size = New System.Drawing.Size(102, 24)
        Me.btnclose.TabIndex = 73
        Me.btnclose.Text = "Cerrar sesión"
        Me.btnclose.UseVisualStyleBackColor = True
        '
        'lbltipou
        '
        Me.lbltipou.AutoSize = True
        Me.lbltipou.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltipou.Location = New System.Drawing.Point(370, 15)
        Me.lbltipou.Name = "lbltipou"
        Me.lbltipou.Size = New System.Drawing.Size(137, 16)
        Me.lbltipou.TabIndex = 72
        Me.lbltipou.Text = "Secretario Escolar"
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
        Me.gbxdoc.Controls.Add(Me.lblestfun)
        Me.gbxdoc.Controls.Add(Me.txttel)
        Me.gbxdoc.Controls.Add(Me.txtant)
        Me.gbxdoc.Controls.Add(Me.txtformac)
        Me.gbxdoc.Controls.Add(Me.txtci)
        Me.gbxdoc.Controls.Add(Me.txtnombre)
        Me.gbxdoc.Controls.Add(Me.lbltel)
        Me.gbxdoc.Controls.Add(Me.lblformac)
        Me.gbxdoc.Controls.Add(Me.lblant)
        Me.gbxdoc.Controls.Add(Me.lblgrado)
        Me.gbxdoc.Controls.Add(Me.lblci)
        Me.gbxdoc.Controls.Add(Me.lblnombre)
        Me.gbxdoc.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbxdoc.Location = New System.Drawing.Point(15, 42)
        Me.gbxdoc.Name = "gbxdoc"
        Me.gbxdoc.Size = New System.Drawing.Size(259, 342)
        Me.gbxdoc.TabIndex = 75
        Me.gbxdoc.TabStop = False
        Me.gbxdoc.Text = "Docentes"
        '
        'txtvac_hasta
        '
        Me.txtvac_hasta.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtvac_hasta.Location = New System.Drawing.Point(123, 301)
        Me.txtvac_hasta.MaxLength = 2
        Me.txtvac_hasta.Name = "txtvac_hasta"
        Me.txtvac_hasta.Size = New System.Drawing.Size(94, 22)
        Me.txtvac_hasta.TabIndex = 18
        '
        'txtvac_desde
        '
        Me.txtvac_desde.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtvac_desde.Location = New System.Drawing.Point(9, 301)
        Me.txtvac_desde.MaxLength = 2
        Me.txtvac_desde.Name = "txtvac_desde"
        Me.txtvac_desde.Size = New System.Drawing.Size(94, 22)
        Me.txtvac_desde.TabIndex = 17
        '
        'cmbestfun
        '
        Me.cmbestfun.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbestfun.FormattingEnabled = True
        Me.cmbestfun.Items.AddRange(New Object() {"(Seleccione)", "Activo", "Licencia por Enfermedad", "Licencia  Maternal", "Art. 28", "Art.67", "Art.61", " "})
        Me.cmbestfun.Location = New System.Drawing.Point(9, 261)
        Me.cmbestfun.Name = "cmbestfun"
        Me.cmbestfun.Size = New System.Drawing.Size(218, 24)
        Me.cmbestfun.TabIndex = 16
        '
        'cmbgrado
        '
        Me.cmbgrado.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbgrado.FormattingEnabled = True
        Me.cmbgrado.Items.AddRange(New Object() {"(Seleccione)", "1", "2", "3", "4", "5", "6", "7"})
        Me.cmbgrado.Location = New System.Drawing.Point(109, 129)
        Me.cmbgrado.Name = "cmbgrado"
        Me.cmbgrado.Size = New System.Drawing.Size(121, 24)
        Me.cmbgrado.TabIndex = 15
        '
        'lblestfun
        '
        Me.lblestfun.AutoSize = True
        Me.lblestfun.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblestfun.Location = New System.Drawing.Point(6, 243)
        Me.lblestfun.Name = "lblestfun"
        Me.lblestfun.Size = New System.Drawing.Size(115, 16)
        Me.lblestfun.TabIndex = 13
        Me.lblestfun.Text = "Estado Funcional:"
        '
        'txttel
        '
        Me.txttel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txttel.Location = New System.Drawing.Point(9, 218)
        Me.txttel.MaxLength = 10
        Me.txttel.Name = "txttel"
        Me.txttel.Size = New System.Drawing.Size(218, 22)
        Me.txttel.TabIndex = 12
        '
        'txtant
        '
        Me.txtant.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtant.Location = New System.Drawing.Point(9, 129)
        Me.txtant.MaxLength = 2
        Me.txtant.Name = "txtant"
        Me.txtant.Size = New System.Drawing.Size(94, 22)
        Me.txtant.TabIndex = 11
        '
        'txtformac
        '
        Me.txtformac.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtformac.Location = New System.Drawing.Point(9, 173)
        Me.txtformac.Name = "txtformac"
        Me.txtformac.Size = New System.Drawing.Size(218, 22)
        Me.txtformac.TabIndex = 9
        '
        'txtci
        '
        Me.txtci.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtci.Location = New System.Drawing.Point(9, 85)
        Me.txtci.MaxLength = 10
        Me.txtci.Name = "txtci"
        Me.txtci.Size = New System.Drawing.Size(218, 22)
        Me.txtci.TabIndex = 7
        '
        'txtnombre
        '
        Me.txtnombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtnombre.Location = New System.Drawing.Point(9, 41)
        Me.txtnombre.Name = "txtnombre"
        Me.txtnombre.Size = New System.Drawing.Size(218, 22)
        Me.txtnombre.TabIndex = 6
        '
        'lbltel
        '
        Me.lbltel.AutoSize = True
        Me.lbltel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltel.Location = New System.Drawing.Point(6, 198)
        Me.lbltel.Name = "lbltel"
        Me.lbltel.Size = New System.Drawing.Size(65, 16)
        Me.lbltel.TabIndex = 5
        Me.lbltel.Text = "Teléfono:"
        '
        'lblformac
        '
        Me.lblformac.AutoSize = True
        Me.lblformac.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblformac.Location = New System.Drawing.Point(6, 154)
        Me.lblformac.Name = "lblformac"
        Me.lblformac.Size = New System.Drawing.Size(147, 16)
        Me.lblformac.TabIndex = 4
        Me.lblformac.Text = "Formación Academica:"
        '
        'lblant
        '
        Me.lblant.AutoSize = True
        Me.lblant.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblant.Location = New System.Drawing.Point(6, 110)
        Me.lblant.Name = "lblant"
        Me.lblant.Size = New System.Drawing.Size(80, 16)
        Me.lblant.TabIndex = 3
        Me.lblant.Text = "Antiguedad:"
        '
        'lblgrado
        '
        Me.lblgrado.AutoSize = True
        Me.lblgrado.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblgrado.Location = New System.Drawing.Point(120, 110)
        Me.lblgrado.Name = "lblgrado"
        Me.lblgrado.Size = New System.Drawing.Size(49, 16)
        Me.lblgrado.TabIndex = 2
        Me.lblgrado.Text = "Grado:"
        '
        'lblci
        '
        Me.lblci.AutoSize = True
        Me.lblci.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblci.Location = New System.Drawing.Point(6, 66)
        Me.lblci.Name = "lblci"
        Me.lblci.Size = New System.Drawing.Size(132, 16)
        Me.lblci.TabIndex = 1
        Me.lblci.Text = "Cedula de Identidad:"
        '
        'lblnombre
        '
        Me.lblnombre.AutoSize = True
        Me.lblnombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblnombre.Location = New System.Drawing.Point(6, 22)
        Me.lblnombre.Name = "lblnombre"
        Me.lblnombre.Size = New System.Drawing.Size(121, 16)
        Me.lblnombre.TabIndex = 0
        Me.lblnombre.Text = "Nombre Completo:"
        '
        'bajaDocente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(539, 396)
        Me.Controls.Add(Me.gbxdoc)
        Me.Controls.Add(Me.lblrol)
        Me.Controls.Add(Me.btnclose)
        Me.Controls.Add(Me.lbltipou)
        Me.Controls.Add(Me.lbltitulo)
        Me.Controls.Add(Me.btnelim)
        Me.Controls.Add(Me.btnatras)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "bajaDocente"
        Me.Text = "S.I.B.A"
        Me.gbxdoc.ResumeLayout(False)
        Me.gbxdoc.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnelim As System.Windows.Forms.Button
    Friend WithEvents btnatras As System.Windows.Forms.Button
    Friend WithEvents lbltitulo As System.Windows.Forms.Label
    Friend WithEvents lblrol As System.Windows.Forms.Label
    Friend WithEvents btnclose As System.Windows.Forms.Button
    Friend WithEvents lbltipou As System.Windows.Forms.Label
    Friend WithEvents gbxdoc As System.Windows.Forms.GroupBox
    Friend WithEvents txtvac_hasta As System.Windows.Forms.TextBox
    Friend WithEvents txtvac_desde As System.Windows.Forms.TextBox
    Friend WithEvents cmbestfun As System.Windows.Forms.ComboBox
    Friend WithEvents cmbgrado As System.Windows.Forms.ComboBox
    Friend WithEvents lblestfun As System.Windows.Forms.Label
    Friend WithEvents txttel As System.Windows.Forms.TextBox
    Friend WithEvents txtant As System.Windows.Forms.TextBox
    Friend WithEvents txtformac As System.Windows.Forms.TextBox
    Friend WithEvents txtci As System.Windows.Forms.TextBox
    Friend WithEvents txtnombre As System.Windows.Forms.TextBox
    Friend WithEvents lbltel As System.Windows.Forms.Label
    Friend WithEvents lblformac As System.Windows.Forms.Label
    Friend WithEvents lblant As System.Windows.Forms.Label
    Friend WithEvents lblgrado As System.Windows.Forms.Label
    Friend WithEvents lblci As System.Windows.Forms.Label
    Friend WithEvents lblnombre As System.Windows.Forms.Label
End Class

