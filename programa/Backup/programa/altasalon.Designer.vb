<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class altasalon
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
        Me.btnfinalizar = New System.Windows.Forms.Button
        Me.btncancelar = New System.Windows.Forms.Button
        Me.lblcod = New System.Windows.Forms.Label
        Me.lbltipo = New System.Windows.Forms.Label
        Me.lblnumero = New System.Windows.Forms.Label
        Me.txtcodigo = New System.Windows.Forms.TextBox
        Me.txtnumero = New System.Windows.Forms.TextBox
        Me.gbxsalon = New System.Windows.Forms.GroupBox
        Me.cmbtipo = New System.Windows.Forms.ComboBox
        Me.btnaceptar = New System.Windows.Forms.Button
        Me.lbltitulo = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.txtlaboratorio = New System.Windows.Forms.TextBox
        Me.txttaller = New System.Windows.Forms.TextBox
        Me.lbltall = New System.Windows.Forms.Label
        Me.lbllab = New System.Windows.Forms.Label
        Me.lblteo = New System.Windows.Forms.Label
        Me.txtteorico = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Button3 = New System.Windows.Forms.Button
        Me.Label9 = New System.Windows.Forms.Label
        Me.gbxcant = New System.Windows.Forms.GroupBox
        Me.gbxsalon.SuspendLayout()
        Me.gbxcant.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnfinalizar
        '
        Me.btnfinalizar.BackColor = System.Drawing.Color.Transparent
        Me.btnfinalizar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnfinalizar.Location = New System.Drawing.Point(443, 289)
        Me.btnfinalizar.Name = "btnfinalizar"
        Me.btnfinalizar.Size = New System.Drawing.Size(101, 22)
        Me.btnfinalizar.TabIndex = 19
        Me.btnfinalizar.Text = "Finalizar"
        Me.btnfinalizar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage
        Me.btnfinalizar.UseVisualStyleBackColor = False
        '
        'btncancelar
        '
        Me.btncancelar.BackColor = System.Drawing.Color.Transparent
        Me.btncancelar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btncancelar.Location = New System.Drawing.Point(9, 186)
        Me.btncancelar.Name = "btncancelar"
        Me.btncancelar.Size = New System.Drawing.Size(101, 22)
        Me.btncancelar.TabIndex = 18
        Me.btncancelar.Text = "Cancelar"
        Me.btncancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage
        Me.btncancelar.UseVisualStyleBackColor = False
        '
        'lblcod
        '
        Me.lblcod.AutoSize = True
        Me.lblcod.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblcod.Location = New System.Drawing.Point(6, 40)
        Me.lblcod.Name = "lblcod"
        Me.lblcod.Size = New System.Drawing.Size(55, 16)
        Me.lblcod.TabIndex = 0
        Me.lblcod.Text = "Código:"
        '
        'lbltipo
        '
        Me.lbltipo.AutoSize = True
        Me.lbltipo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltipo.Location = New System.Drawing.Point(6, 80)
        Me.lbltipo.Name = "lbltipo"
        Me.lbltipo.Size = New System.Drawing.Size(39, 16)
        Me.lbltipo.TabIndex = 1
        Me.lbltipo.Text = "Tipo:"
        '
        'lblnumero
        '
        Me.lblnumero.AutoSize = True
        Me.lblnumero.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblnumero.Location = New System.Drawing.Point(6, 125)
        Me.lblnumero.Name = "lblnumero"
        Me.lblnumero.Size = New System.Drawing.Size(59, 16)
        Me.lblnumero.TabIndex = 3
        Me.lblnumero.Text = "Número:"
        '
        'txtcodigo
        '
        Me.txtcodigo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtcodigo.Location = New System.Drawing.Point(9, 59)
        Me.txtcodigo.MaxLength = 5
        Me.txtcodigo.Name = "txtcodigo"
        Me.txtcodigo.Size = New System.Drawing.Size(218, 22)
        Me.txtcodigo.TabIndex = 6
        '
        'txtnumero
        '
        Me.txtnumero.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtnumero.Location = New System.Drawing.Point(9, 144)
        Me.txtnumero.MaxLength = 3
        Me.txtnumero.Name = "txtnumero"
        Me.txtnumero.Size = New System.Drawing.Size(218, 22)
        Me.txtnumero.TabIndex = 11
        '
        'gbxsalon
        '
        Me.gbxsalon.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbxsalon.Controls.Add(Me.cmbtipo)
        Me.gbxsalon.Controls.Add(Me.btnaceptar)
        Me.gbxsalon.Controls.Add(Me.txtnumero)
        Me.gbxsalon.Controls.Add(Me.txtcodigo)
        Me.gbxsalon.Controls.Add(Me.lblnumero)
        Me.gbxsalon.Controls.Add(Me.lbltipo)
        Me.gbxsalon.Controls.Add(Me.lblcod)
        Me.gbxsalon.Controls.Add(Me.btncancelar)
        Me.gbxsalon.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbxsalon.Location = New System.Drawing.Point(279, 58)
        Me.gbxsalon.Name = "gbxsalon"
        Me.gbxsalon.Size = New System.Drawing.Size(271, 214)
        Me.gbxsalon.TabIndex = 22
        Me.gbxsalon.TabStop = False
        Me.gbxsalon.Text = "Salones"
        '
        'cmbtipo
        '
        Me.cmbtipo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbtipo.FormattingEnabled = True
        Me.cmbtipo.Items.AddRange(New Object() {"(Seleccione)", "Teorico", "Laboratorio", "Taller"})
        Me.cmbtipo.Location = New System.Drawing.Point(9, 99)
        Me.cmbtipo.Name = "cmbtipo"
        Me.cmbtipo.Size = New System.Drawing.Size(218, 24)
        Me.cmbtipo.TabIndex = 21
        '
        'btnaceptar
        '
        Me.btnaceptar.BackColor = System.Drawing.Color.Transparent
        Me.btnaceptar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnaceptar.Location = New System.Drawing.Point(164, 186)
        Me.btnaceptar.Name = "btnaceptar"
        Me.btnaceptar.Size = New System.Drawing.Size(101, 22)
        Me.btnaceptar.TabIndex = 20
        Me.btnaceptar.Text = "Aceptar"
        Me.btnaceptar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage
        Me.btnaceptar.UseVisualStyleBackColor = False
        '
        'lbltitulo
        '
        Me.lbltitulo.AutoSize = True
        Me.lbltitulo.BackColor = System.Drawing.Color.LemonChiffon
        Me.lbltitulo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbltitulo.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltitulo.Location = New System.Drawing.Point(15, 9)
        Me.lbltitulo.Name = "lbltitulo"
        Me.lbltitulo.Size = New System.Drawing.Size(240, 26)
        Me.lbltitulo.TabIndex = 50
        Me.lbltitulo.Text = "INGRESO DE SALONES"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(117, 66)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(0, 13)
        Me.Label8.TabIndex = 58
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(111, 66)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(0, 13)
        Me.Label7.TabIndex = 57
        '
        'txtlaboratorio
        '
        Me.txtlaboratorio.Location = New System.Drawing.Point(168, 115)
        Me.txtlaboratorio.Name = "txtlaboratorio"
        Me.txtlaboratorio.ReadOnly = True
        Me.txtlaboratorio.Size = New System.Drawing.Size(36, 20)
        Me.txtlaboratorio.TabIndex = 56
        Me.txtlaboratorio.Text = "4"
        Me.txtlaboratorio.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txttaller
        '
        Me.txttaller.Location = New System.Drawing.Point(168, 153)
        Me.txttaller.Name = "txttaller"
        Me.txttaller.ReadOnly = True
        Me.txttaller.Size = New System.Drawing.Size(36, 20)
        Me.txttaller.TabIndex = 55
        Me.txttaller.Text = "4"
        Me.txttaller.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lbltall
        '
        Me.lbltall.AutoSize = True
        Me.lbltall.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltall.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lbltall.Location = New System.Drawing.Point(3, 153)
        Me.lbltall.Name = "lbltall"
        Me.lbltall.Size = New System.Drawing.Size(85, 16)
        Me.lbltall.TabIndex = 54
        Me.lbltall.Text = "TALLERES"
        '
        'lbllab
        '
        Me.lbllab.AutoSize = True
        Me.lbllab.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbllab.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lbllab.Location = New System.Drawing.Point(3, 113)
        Me.lbllab.Name = "lbllab"
        Me.lbllab.Size = New System.Drawing.Size(125, 16)
        Me.lbllab.TabIndex = 53
        Me.lbllab.Text = "LABORATORIOS"
        '
        'lblteo
        '
        Me.lblteo.AutoSize = True
        Me.lblteo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblteo.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblteo.Location = New System.Drawing.Point(3, 73)
        Me.lblteo.Name = "lblteo"
        Me.lblteo.Size = New System.Drawing.Size(159, 16)
        Me.lblteo.TabIndex = 52
        Me.lblteo.Text = "SALONES TEÓRICOS"
        '
        'txtteorico
        '
        Me.txtteorico.Location = New System.Drawing.Point(168, 73)
        Me.txtteorico.Name = "txtteorico"
        Me.txtteorico.ReadOnly = True
        Me.txtteorico.Size = New System.Drawing.Size(36, 20)
        Me.txtteorico.TabIndex = 51
        Me.txtteorico.Text = "4"
        Me.txtteorico.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(3, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(180, 16)
        Me.Label1.TabIndex = 59
        Me.Label1.Text = "Usted puede dar de alta:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(424, 9)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(36, 16)
        Me.Label4.TabIndex = 62
        Me.Label4.Text = "Rol:"
        '
        'Button3
        '
        Me.Button3.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Location = New System.Drawing.Point(501, 28)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(102, 24)
        Me.Button3.TabIndex = 61
        Me.Button3.Text = "Cerrar sesión"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(466, 9)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(137, 16)
        Me.Label9.TabIndex = 60
        Me.Label9.Text = "Secretario Escolar"
        '
        'gbxcant
        '
        Me.gbxcant.Controls.Add(Me.Label1)
        Me.gbxcant.Controls.Add(Me.Label8)
        Me.gbxcant.Controls.Add(Me.Label7)
        Me.gbxcant.Controls.Add(Me.txtlaboratorio)
        Me.gbxcant.Controls.Add(Me.txttaller)
        Me.gbxcant.Controls.Add(Me.lbltall)
        Me.gbxcant.Controls.Add(Me.lbllab)
        Me.gbxcant.Controls.Add(Me.lblteo)
        Me.gbxcant.Controls.Add(Me.txtteorico)
        Me.gbxcant.Location = New System.Drawing.Point(15, 58)
        Me.gbxcant.Name = "gbxcant"
        Me.gbxcant.Size = New System.Drawing.Size(245, 238)
        Me.gbxcant.TabIndex = 63
        Me.gbxcant.TabStop = False
        Me.gbxcant.Text = "Cantidad disponible"
        '
        'altasalon
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(624, 376)
        Me.Controls.Add(Me.gbxcant)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.lbltitulo)
        Me.Controls.Add(Me.gbxsalon)
        Me.Controls.Add(Me.btnfinalizar)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "altasalon"
        Me.Text = "S.I.B.A"
        Me.gbxsalon.ResumeLayout(False)
        Me.gbxsalon.PerformLayout()
        Me.gbxcant.ResumeLayout(False)
        Me.gbxcant.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnfinalizar As System.Windows.Forms.Button
    Friend WithEvents btncancelar As System.Windows.Forms.Button
    Friend WithEvents lblcod As System.Windows.Forms.Label
    Friend WithEvents lbltipo As System.Windows.Forms.Label
    Friend WithEvents lblnumero As System.Windows.Forms.Label
    Friend WithEvents txtcodigo As System.Windows.Forms.TextBox
    Friend WithEvents txtnumero As System.Windows.Forms.TextBox
    Friend WithEvents gbxsalon As System.Windows.Forms.GroupBox
    Friend WithEvents lbltitulo As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtlaboratorio As System.Windows.Forms.TextBox
    Friend WithEvents txttaller As System.Windows.Forms.TextBox
    Friend WithEvents lbltall As System.Windows.Forms.Label
    Friend WithEvents lbllab As System.Windows.Forms.Label
    Friend WithEvents lblteo As System.Windows.Forms.Label
    Friend WithEvents txtteorico As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents btnaceptar As System.Windows.Forms.Button
    Friend WithEvents cmbtipo As System.Windows.Forms.ComboBox
    Friend WithEvents gbxcant As System.Windows.Forms.GroupBox
End Class
