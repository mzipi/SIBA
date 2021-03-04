<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class altagrupo
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
        Me.lblsalon = New System.Windows.Forms.Label
        Me.lbltitulo = New System.Windows.Forms.Label
        Me.lblrol = New System.Windows.Forms.Label
        Me.btnclose = New System.Windows.Forms.Button
        Me.lbltipou = New System.Windows.Forms.Label
        Me.btnsiba = New System.Windows.Forms.Button
        Me.btnabmgrup = New System.Windows.Forms.Button
        Me.gbxgrup = New System.Windows.Forms.GroupBox
        Me.cmbturno = New System.Windows.Forms.ComboBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label15 = New System.Windows.Forms.Label
        Me.txtcurso = New System.Windows.Forms.TextBox
        Me.txtletra = New System.Windows.Forms.TextBox
        Me.txtcodgrupo = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.btnaceptar = New System.Windows.Forms.Button
        Me.Label3 = New System.Windows.Forms.Label
        Me.btncancel = New System.Windows.Forms.Button
        Me.Label2 = New System.Windows.Forms.Label
        Me.cmbcarrera = New System.Windows.Forms.ComboBox
        Me.cmbaño = New System.Windows.Forms.ComboBox
        Me.gbxgrup.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblsalon
        '
        Me.lblsalon.AutoSize = True
        Me.lblsalon.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblsalon.Location = New System.Drawing.Point(255, 52)
        Me.lblsalon.Name = "lblsalon"
        Me.lblsalon.Size = New System.Drawing.Size(0, 16)
        Me.lblsalon.TabIndex = 132
        Me.lblsalon.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lbltitulo
        '
        Me.lbltitulo.AutoSize = True
        Me.lbltitulo.BackColor = System.Drawing.Color.LemonChiffon
        Me.lbltitulo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbltitulo.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltitulo.Location = New System.Drawing.Point(15, 9)
        Me.lbltitulo.Name = "lbltitulo"
        Me.lbltitulo.Size = New System.Drawing.Size(229, 26)
        Me.lbltitulo.TabIndex = 119
        Me.lbltitulo.Text = "INGRESO DE GRUPOS"
        '
        'lblrol
        '
        Me.lblrol.AutoSize = True
        Me.lblrol.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblrol.Location = New System.Drawing.Point(422, 9)
        Me.lblrol.Name = "lblrol"
        Me.lblrol.Size = New System.Drawing.Size(36, 16)
        Me.lblrol.TabIndex = 126
        Me.lblrol.Text = "Rol:"
        '
        'btnclose
        '
        Me.btnclose.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnclose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnclose.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnclose.Location = New System.Drawing.Point(499, 28)
        Me.btnclose.Name = "btnclose"
        Me.btnclose.Size = New System.Drawing.Size(102, 24)
        Me.btnclose.TabIndex = 125
        Me.btnclose.Text = "Cerrar sesión"
        Me.btnclose.UseVisualStyleBackColor = True
        '
        'lbltipou
        '
        Me.lbltipou.AutoSize = True
        Me.lbltipou.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltipou.Location = New System.Drawing.Point(464, 9)
        Me.lbltipou.Name = "lbltipou"
        Me.lbltipou.Size = New System.Drawing.Size(137, 16)
        Me.lbltipou.TabIndex = 124
        Me.lbltipou.Text = "Secretario Escolar"
        '
        'btnsiba
        '
        Me.btnsiba.BackColor = System.Drawing.Color.Transparent
        Me.btnsiba.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnsiba.Location = New System.Drawing.Point(477, 264)
        Me.btnsiba.Name = "btnsiba"
        Me.btnsiba.Size = New System.Drawing.Size(124, 22)
        Me.btnsiba.TabIndex = 121
        Me.btnsiba.Text = "MENU SIBA"
        Me.btnsiba.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage
        Me.btnsiba.UseVisualStyleBackColor = False
        '
        'btnabmgrup
        '
        Me.btnabmgrup.BackColor = System.Drawing.Color.Transparent
        Me.btnabmgrup.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnabmgrup.Location = New System.Drawing.Point(477, 292)
        Me.btnabmgrup.Name = "btnabmgrup"
        Me.btnabmgrup.Size = New System.Drawing.Size(124, 25)
        Me.btnabmgrup.TabIndex = 120
        Me.btnabmgrup.Text = "ADMIN GRUPOS"
        Me.btnabmgrup.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage
        Me.btnabmgrup.UseVisualStyleBackColor = False
        '
        'gbxgrup
        '
        Me.gbxgrup.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbxgrup.Controls.Add(Me.cmbturno)
        Me.gbxgrup.Controls.Add(Me.Label1)
        Me.gbxgrup.Controls.Add(Me.Label15)
        Me.gbxgrup.Controls.Add(Me.txtcurso)
        Me.gbxgrup.Controls.Add(Me.txtletra)
        Me.gbxgrup.Controls.Add(Me.txtcodgrupo)
        Me.gbxgrup.Controls.Add(Me.cmbaño)
        Me.gbxgrup.Controls.Add(Me.Label5)
        Me.gbxgrup.Controls.Add(Me.Label4)
        Me.gbxgrup.Controls.Add(Me.btnaceptar)
        Me.gbxgrup.Controls.Add(Me.Label3)
        Me.gbxgrup.Controls.Add(Me.btncancel)
        Me.gbxgrup.Controls.Add(Me.cmbcarrera)
        Me.gbxgrup.Controls.Add(Me.Label2)
        Me.gbxgrup.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbxgrup.Location = New System.Drawing.Point(15, 52)
        Me.gbxgrup.Name = "gbxgrup"
        Me.gbxgrup.Size = New System.Drawing.Size(270, 296)
        Me.gbxgrup.TabIndex = 133
        Me.gbxgrup.TabStop = False
        Me.gbxgrup.Text = "Complete el formulario"
        '
        'cmbturno
        '
        Me.cmbturno.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbturno.FormattingEnabled = True
        Me.cmbturno.Items.AddRange(New Object() {"(Seleccione)", "Matutino", "Vespertino", "Nocturno"})
        Me.cmbturno.Location = New System.Drawing.Point(126, 111)
        Me.cmbturno.Name = "cmbturno"
        Me.cmbturno.Size = New System.Drawing.Size(127, 24)
        Me.cmbturno.TabIndex = 23
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(123, 92)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(46, 16)
        Me.Label1.TabIndex = 22
        Me.Label1.Text = "Turno:"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(6, 32)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(106, 16)
        Me.Label15.TabIndex = 21
        Me.Label15.Text = "Nombre carrera:"
        '
        'txtcurso
        '
        Me.txtcurso.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtcurso.Location = New System.Drawing.Point(126, 157)
        Me.txtcurso.MaxLength = 2
        Me.txtcurso.Name = "txtcurso"
        Me.txtcurso.Size = New System.Drawing.Size(52, 22)
        Me.txtcurso.TabIndex = 11
        '
        'txtletra
        '
        Me.txtletra.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtletra.Location = New System.Drawing.Point(201, 157)
        Me.txtletra.MaxLength = 2
        Me.txtletra.Name = "txtletra"
        Me.txtletra.Size = New System.Drawing.Size(52, 22)
        Me.txtletra.TabIndex = 10
        '
        'txtcodgrupo
        '
        Me.txtcodgrupo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtcodgrupo.Location = New System.Drawing.Point(9, 111)
        Me.txtcodgrupo.MaxLength = 6
        Me.txtcodgrupo.Name = "txtcodgrupo"
        Me.txtcodgrupo.Size = New System.Drawing.Size(85, 22)
        Me.txtcodgrupo.TabIndex = 6
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(123, 138)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(46, 16)
        Me.Label5.TabIndex = 3
        Me.Label5.Text = "Curso:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(199, 138)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(41, 16)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Letra:"
        '
        'btnaceptar
        '
        Me.btnaceptar.BackColor = System.Drawing.Color.Transparent
        Me.btnaceptar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnaceptar.Location = New System.Drawing.Point(152, 197)
        Me.btnaceptar.Name = "btnaceptar"
        Me.btnaceptar.Size = New System.Drawing.Size(101, 22)
        Me.btnaceptar.TabIndex = 19
        Me.btnaceptar.Text = "Aceptar"
        Me.btnaceptar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage
        Me.btnaceptar.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(6, 133)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(35, 16)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Año:"
        '
        'btncancel
        '
        Me.btncancel.BackColor = System.Drawing.Color.Transparent
        Me.btncancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btncancel.Location = New System.Drawing.Point(9, 197)
        Me.btncancel.Name = "btncancel"
        Me.btncancel.Size = New System.Drawing.Size(101, 22)
        Me.btncancel.TabIndex = 18
        Me.btncancel.Text = "Cancelar"
        Me.btncancel.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage
        Me.btncancel.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(6, 92)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(93, 16)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Código grupo:"
        '
        'cmbcarrera
        '
        Me.cmbcarrera.FormattingEnabled = True
        Me.cmbcarrera.Items.AddRange(New Object() {"(Seleccione)", "EMT Administración", "EMP Administración", "EMT Informática", "Tecnicatura en Redes"})
        Me.cmbcarrera.Location = New System.Drawing.Point(9, 52)
        Me.cmbcarrera.Name = "cmbcarrera"
        Me.cmbcarrera.Size = New System.Drawing.Size(244, 28)
        Me.cmbcarrera.TabIndex = 120
        '
        'cmbaño
        '
        Me.cmbaño.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbaño.FormattingEnabled = True
        Me.cmbaño.Items.AddRange(New Object() {"(Seleccione)", "1°", "2°", "3°"})
        Me.cmbaño.Location = New System.Drawing.Point(9, 152)
        Me.cmbaño.Name = "cmbaño"
        Me.cmbaño.Size = New System.Drawing.Size(85, 24)
        Me.cmbaño.TabIndex = 128
        '
        'altagrupo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(620, 356)
        Me.Controls.Add(Me.gbxgrup)
        Me.Controls.Add(Me.btnabmgrup)
        Me.Controls.Add(Me.btnsiba)
        Me.Controls.Add(Me.lblsalon)
        Me.Controls.Add(Me.lblrol)
        Me.Controls.Add(Me.btnclose)
        Me.Controls.Add(Me.lbltipou)
        Me.Controls.Add(Me.lbltitulo)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "altagrupo"
        Me.Text = "S.I.B.A"
        Me.gbxgrup.ResumeLayout(False)
        Me.gbxgrup.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lbltitulo As System.Windows.Forms.Label
    Friend WithEvents lblrol As System.Windows.Forms.Label
    Friend WithEvents btnclose As System.Windows.Forms.Button
    Friend WithEvents lbltipou As System.Windows.Forms.Label
    Friend WithEvents lblsalon As System.Windows.Forms.Label
    Friend WithEvents btnsiba As System.Windows.Forms.Button
    Friend WithEvents btnabmgrup As System.Windows.Forms.Button
    Friend WithEvents gbxgrup As System.Windows.Forms.GroupBox
    Friend WithEvents cmbturno As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents txtcurso As System.Windows.Forms.TextBox
    Friend WithEvents txtletra As System.Windows.Forms.TextBox
    Friend WithEvents txtcodgrupo As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents btnaceptar As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents btncancel As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cmbaño As System.Windows.Forms.ComboBox
    Friend WithEvents cmbcarrera As System.Windows.Forms.ComboBox
End Class
