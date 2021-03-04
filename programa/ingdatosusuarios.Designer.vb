<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ingdatosusuarios
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
        Me.btnaceptar = New System.Windows.Forms.Button
        Me.btncancel = New System.Windows.Forms.Button
        Me.gbxusuarios = New System.Windows.Forms.GroupBox
        Me.gbxedit = New System.Windows.Forms.GroupBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.btnreset = New System.Windows.Forms.Button
        Me.lblver = New System.Windows.Forms.Label
        Me.lbldatos_Ci = New System.Windows.Forms.Label
        Me.btndisponibilidadonibilidad = New System.Windows.Forms.Button
        Me.lblemail = New System.Windows.Forms.Label
        Me.txtemail = New System.Windows.Forms.TextBox
        Me.txtreppass = New System.Windows.Forms.TextBox
        Me.cmbperfil = New System.Windows.Forms.ComboBox
        Me.lblreppas = New System.Windows.Forms.Label
        Me.txtpass = New System.Windows.Forms.TextBox
        Me.txtnomusua = New System.Windows.Forms.TextBox
        Me.txtci = New System.Windows.Forms.TextBox
        Me.txtnombre = New System.Windows.Forms.TextBox
        Me.lblpass = New System.Windows.Forms.Label
        Me.lblnomusu = New System.Windows.Forms.Label
        Me.lblperfil = New System.Windows.Forms.Label
        Me.lblci = New System.Windows.Forms.Label
        Me.lblnombre = New System.Windows.Forms.Label
        Me.lbltitulo = New System.Windows.Forms.Label
        Me.lblrol = New System.Windows.Forms.Label
        Me.btnclose = New System.Windows.Forms.Button
        Me.lbltipou = New System.Windows.Forms.Label
        Me.btnfin = New System.Windows.Forms.Button
        Me.btnver = New System.Windows.Forms.Button
        Me.dgvusuarios = New System.Windows.Forms.DataGridView
        Me.btncont = New System.Windows.Forms.Button
        Me.gbxver = New System.Windows.Forms.GroupBox
        Me.ttdisp = New System.Windows.Forms.ToolTip(Me.components)
        Me.txtnombreusuario = New System.Windows.Forms.TextBox
        Me.ttDatos_ci = New System.Windows.Forms.ToolTip(Me.components)
        Me.gbxusuarios.SuspendLayout()
        Me.gbxedit.SuspendLayout()
        CType(Me.dgvusuarios, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnaceptar
        '
        Me.btnaceptar.BackColor = System.Drawing.Color.Transparent
        Me.btnaceptar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnaceptar.Location = New System.Drawing.Point(366, 143)
        Me.btnaceptar.Name = "btnaceptar"
        Me.btnaceptar.Size = New System.Drawing.Size(101, 24)
        Me.btnaceptar.TabIndex = 19
        Me.btnaceptar.Text = "Ingresar"
        Me.btnaceptar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage
        Me.btnaceptar.UseVisualStyleBackColor = False
        '
        'btncancel
        '
        Me.btncancel.BackColor = System.Drawing.Color.Transparent
        Me.btncancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btncancel.Location = New System.Drawing.Point(366, 193)
        Me.btncancel.Name = "btncancel"
        Me.btncancel.Size = New System.Drawing.Size(101, 22)
        Me.btncancel.TabIndex = 18
        Me.btncancel.Text = "Cancelar"
        Me.btncancel.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage
        Me.btncancel.UseVisualStyleBackColor = False
        '
        'gbxusuarios
        '
        Me.gbxusuarios.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbxusuarios.Controls.Add(Me.gbxedit)
        Me.gbxusuarios.Controls.Add(Me.lbldatos_Ci)
        Me.gbxusuarios.Controls.Add(Me.btndisponibilidadonibilidad)
        Me.gbxusuarios.Controls.Add(Me.lblemail)
        Me.gbxusuarios.Controls.Add(Me.txtemail)
        Me.gbxusuarios.Controls.Add(Me.txtreppass)
        Me.gbxusuarios.Controls.Add(Me.cmbperfil)
        Me.gbxusuarios.Controls.Add(Me.lblreppas)
        Me.gbxusuarios.Controls.Add(Me.txtpass)
        Me.gbxusuarios.Controls.Add(Me.txtnomusua)
        Me.gbxusuarios.Controls.Add(Me.txtci)
        Me.gbxusuarios.Controls.Add(Me.txtnombre)
        Me.gbxusuarios.Controls.Add(Me.lblpass)
        Me.gbxusuarios.Controls.Add(Me.lblnomusu)
        Me.gbxusuarios.Controls.Add(Me.lblperfil)
        Me.gbxusuarios.Controls.Add(Me.lblci)
        Me.gbxusuarios.Controls.Add(Me.lblnombre)
        Me.gbxusuarios.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbxusuarios.Location = New System.Drawing.Point(12, 49)
        Me.gbxusuarios.Name = "gbxusuarios"
        Me.gbxusuarios.Size = New System.Drawing.Size(304, 290)
        Me.gbxusuarios.TabIndex = 21
        Me.gbxusuarios.TabStop = False
        Me.gbxusuarios.Text = "Usuarios"
        '
        'gbxedit
        '
        Me.gbxedit.Controls.Add(Me.Label5)
        Me.gbxedit.Controls.Add(Me.Label4)
        Me.gbxedit.Controls.Add(Me.Label3)
        Me.gbxedit.Controls.Add(Me.btnreset)
        Me.gbxedit.Controls.Add(Me.lblver)
        Me.gbxedit.Location = New System.Drawing.Point(230, 25)
        Me.gbxedit.Name = "gbxedit"
        Me.gbxedit.Size = New System.Drawing.Size(72, 275)
        Me.gbxedit.TabIndex = 28
        Me.gbxedit.TabStop = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(4, 236)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(57, 20)
        Me.Label5.TabIndex = 27
        Me.Label5.Text = "Editar"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(6, 153)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(57, 20)
        Me.Label4.TabIndex = 26
        Me.Label4.Text = "Editar"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 101)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(57, 20)
        Me.Label3.TabIndex = 25
        Me.Label3.Text = "Editar"
        '
        'btnreset
        '
        Me.btnreset.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnreset.Location = New System.Drawing.Point(8, 193)
        Me.btnreset.Name = "btnreset"
        Me.btnreset.Size = New System.Drawing.Size(55, 23)
        Me.btnreset.TabIndex = 21
        Me.btnreset.Text = "Reset"
        Me.btnreset.UseVisualStyleBackColor = True
        '
        'lblver
        '
        Me.lblver.AutoSize = True
        Me.lblver.Location = New System.Drawing.Point(23, 152)
        Me.lblver.Name = "lblver"
        Me.lblver.Size = New System.Drawing.Size(0, 20)
        Me.lblver.TabIndex = 19
        '
        'lbldatos_Ci
        '
        Me.lbldatos_Ci.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.lbldatos_Ci.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbldatos_Ci.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbldatos_Ci.Location = New System.Drawing.Point(153, 85)
        Me.lbldatos_Ci.Name = "lbldatos_Ci"
        Me.lbldatos_Ci.Size = New System.Drawing.Size(71, 22)
        Me.lbldatos_Ci.TabIndex = 81
        Me.lbldatos_Ci.Text = "Formato"
        Me.lbldatos_Ci.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btndisponibilidadonibilidad
        '
        Me.btndisponibilidadonibilidad.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btndisponibilidadonibilidad.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btndisponibilidadonibilidad.Location = New System.Drawing.Point(168, 175)
        Me.btndisponibilidadonibilidad.Name = "btndisponibilidadonibilidad"
        Me.btndisponibilidadonibilidad.Size = New System.Drawing.Size(56, 23)
        Me.btndisponibilidadonibilidad.TabIndex = 79
        Me.btndisponibilidadonibilidad.Text = "?"
        Me.btndisponibilidadonibilidad.UseVisualStyleBackColor = False
        '
        'lblemail
        '
        Me.lblemail.AutoSize = True
        Me.lblemail.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblemail.Location = New System.Drawing.Point(6, 245)
        Me.lblemail.Name = "lblemail"
        Me.lblemail.Size = New System.Drawing.Size(42, 16)
        Me.lblemail.TabIndex = 18
        Me.lblemail.Text = "Email"
        '
        'txtemail
        '
        Me.txtemail.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtemail.Location = New System.Drawing.Point(6, 264)
        Me.txtemail.MaxLength = 40
        Me.txtemail.Name = "txtemail"
        Me.txtemail.Size = New System.Drawing.Size(218, 22)
        Me.txtemail.TabIndex = 17
        '
        'txtreppass
        '
        Me.txtreppass.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtreppass.Location = New System.Drawing.Point(120, 218)
        Me.txtreppass.MaxLength = 12
        Me.txtreppass.Name = "txtreppass"
        Me.txtreppass.Size = New System.Drawing.Size(104, 22)
        Me.txtreppass.TabIndex = 16
        Me.txtreppass.UseSystemPasswordChar = True
        '
        'cmbperfil
        '
        Me.cmbperfil.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbperfil.FormattingEnabled = True
        Me.cmbperfil.Items.AddRange(New Object() {"(Seleccione)", "Administrativo", "Alumno", "Director", "Docente", "Encargado Informático", "Secretario Escolar"})
        Me.cmbperfil.Location = New System.Drawing.Point(6, 129)
        Me.cmbperfil.Name = "cmbperfil"
        Me.cmbperfil.Size = New System.Drawing.Size(221, 24)
        Me.cmbperfil.TabIndex = 3
        '
        'lblreppas
        '
        Me.lblreppas.AutoSize = True
        Me.lblreppas.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblreppas.Location = New System.Drawing.Point(111, 201)
        Me.lblreppas.Name = "lblreppas"
        Me.lblreppas.Size = New System.Drawing.Size(121, 16)
        Me.lblreppas.TabIndex = 13
        Me.lblreppas.Text = "Repita contraseña:"
        '
        'txtpass
        '
        Me.txtpass.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtpass.Location = New System.Drawing.Point(6, 220)
        Me.txtpass.MaxLength = 12
        Me.txtpass.Name = "txtpass"
        Me.txtpass.Size = New System.Drawing.Size(104, 22)
        Me.txtpass.TabIndex = 12
        Me.txtpass.UseSystemPasswordChar = True
        '
        'txtnomusua
        '
        Me.txtnomusua.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtnomusua.Location = New System.Drawing.Point(6, 175)
        Me.txtnomusua.MaxLength = 25
        Me.txtnomusua.Name = "txtnomusua"
        Me.txtnomusua.Size = New System.Drawing.Size(218, 22)
        Me.txtnomusua.TabIndex = 4
        '
        'txtci
        '
        Me.txtci.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtci.Location = New System.Drawing.Point(6, 85)
        Me.txtci.MaxLength = 8
        Me.txtci.Name = "txtci"
        Me.txtci.Size = New System.Drawing.Size(218, 22)
        Me.txtci.TabIndex = 2
        '
        'txtnombre
        '
        Me.txtnombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtnombre.Location = New System.Drawing.Point(6, 41)
        Me.txtnombre.MaxLength = 50
        Me.txtnombre.Name = "txtnombre"
        Me.txtnombre.Size = New System.Drawing.Size(218, 22)
        Me.txtnombre.TabIndex = 1
        '
        'lblpass
        '
        Me.lblpass.AutoSize = True
        Me.lblpass.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblpass.Location = New System.Drawing.Point(6, 200)
        Me.lblpass.Name = "lblpass"
        Me.lblpass.Size = New System.Drawing.Size(80, 16)
        Me.lblpass.TabIndex = 5
        Me.lblpass.Text = "Contraseña:"
        '
        'lblnomusu
        '
        Me.lblnomusu.AutoSize = True
        Me.lblnomusu.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblnomusu.Location = New System.Drawing.Point(6, 156)
        Me.lblnomusu.Name = "lblnomusu"
        Me.lblnomusu.Size = New System.Drawing.Size(107, 16)
        Me.lblnomusu.TabIndex = 4
        Me.lblnomusu.Text = "Nombre usuario:"
        '
        'lblperfil
        '
        Me.lblperfil.AutoSize = True
        Me.lblperfil.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblperfil.Location = New System.Drawing.Point(6, 110)
        Me.lblperfil.Name = "lblperfil"
        Me.lblperfil.Size = New System.Drawing.Size(85, 16)
        Me.lblperfil.TabIndex = 3
        Me.lblperfil.Text = "Perfil usuario"
        '
        'lblci
        '
        Me.lblci.AutoSize = True
        Me.lblci.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblci.Location = New System.Drawing.Point(6, 66)
        Me.lblci.Name = "lblci"
        Me.lblci.Size = New System.Drawing.Size(132, 16)
        Me.lblci.TabIndex = 1
        Me.lblci.Text = "Cédula de Identidad:"
        '
        'lblnombre
        '
        Me.lblnombre.AutoSize = True
        Me.lblnombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblnombre.Location = New System.Drawing.Point(6, 22)
        Me.lblnombre.Name = "lblnombre"
        Me.lblnombre.Size = New System.Drawing.Size(120, 16)
        Me.lblnombre.TabIndex = 0
        Me.lblnombre.Text = "Nombre y Apellido"
        '
        'lbltitulo
        '
        Me.lbltitulo.AutoSize = True
        Me.lbltitulo.BackColor = System.Drawing.Color.LemonChiffon
        Me.lbltitulo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbltitulo.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltitulo.Location = New System.Drawing.Point(15, 9)
        Me.lbltitulo.Name = "lbltitulo"
        Me.lbltitulo.Size = New System.Drawing.Size(234, 26)
        Me.lbltitulo.TabIndex = 52
        Me.lbltitulo.Text = "INGRESO DE USUARIO"
        '
        'lblrol
        '
        Me.lblrol.AutoSize = True
        Me.lblrol.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblrol.Location = New System.Drawing.Point(434, 9)
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
        Me.btnclose.Location = New System.Drawing.Point(535, 28)
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
        Me.lbltipou.Location = New System.Drawing.Point(473, 9)
        Me.lbltipou.Name = "lbltipou"
        Me.lbltipou.Size = New System.Drawing.Size(164, 16)
        Me.lbltipou.TabIndex = 69
        Me.lbltipou.Text = "Encargado informático"
        '
        'btnfin
        '
        Me.btnfin.BackColor = System.Drawing.Color.Transparent
        Me.btnfin.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnfin.Location = New System.Drawing.Point(366, 233)
        Me.btnfin.Name = "btnfin"
        Me.btnfin.Size = New System.Drawing.Size(101, 22)
        Me.btnfin.TabIndex = 73
        Me.btnfin.Text = "Finalizar"
        Me.btnfin.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage
        Me.btnfin.UseVisualStyleBackColor = False
        '
        'btnver
        '
        Me.btnver.Location = New System.Drawing.Point(474, 316)
        Me.btnver.Name = "btnver"
        Me.btnver.Size = New System.Drawing.Size(120, 23)
        Me.btnver.TabIndex = 74
        Me.btnver.Text = "Verificar ingreso" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.btnver.UseVisualStyleBackColor = True
        '
        'dgvusuarios
        '
        Me.dgvusuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvusuarios.Location = New System.Drawing.Point(474, 143)
        Me.dgvusuarios.Name = "dgvusuarios"
        Me.dgvusuarios.ReadOnly = True
        Me.dgvusuarios.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken
        Me.dgvusuarios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvusuarios.Size = New System.Drawing.Size(188, 70)
        Me.dgvusuarios.TabIndex = 75
        '
        'btncont
        '
        Me.btncont.Location = New System.Drawing.Point(501, 316)
        Me.btncont.Name = "btncont"
        Me.btncont.Size = New System.Drawing.Size(120, 23)
        Me.btncont.TabIndex = 76
        Me.btncont.Text = "Continuar ingresando"
        Me.btncont.UseVisualStyleBackColor = True
        '
        'gbxver
        '
        Me.gbxver.Location = New System.Drawing.Point(442, 49)
        Me.gbxver.Name = "gbxver"
        Me.gbxver.Size = New System.Drawing.Size(161, 82)
        Me.gbxver.TabIndex = 77
        Me.gbxver.TabStop = False
        '
        'ttdisp
        '
        Me.ttdisp.AutomaticDelay = 300
        Me.ttdisp.AutoPopDelay = 3000
        Me.ttdisp.ForeColor = System.Drawing.Color.Crimson
        Me.ttdisp.InitialDelay = 200
        Me.ttdisp.IsBalloon = True
        Me.ttdisp.ReshowDelay = 30
        Me.ttdisp.ShowAlways = True
        Me.ttdisp.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info
        '
        'txtnombreusuario
        '
        Me.txtnombreusuario.Location = New System.Drawing.Point(266, 23)
        Me.txtnombreusuario.Name = "txtnombreusuario"
        Me.txtnombreusuario.Size = New System.Drawing.Size(94, 20)
        Me.txtnombreusuario.TabIndex = 78
        '
        'ingdatosusuarios
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(649, 378)
        Me.Controls.Add(Me.btncont)
        Me.Controls.Add(Me.txtnombreusuario)
        Me.Controls.Add(Me.dgvusuarios)
        Me.Controls.Add(Me.btnaceptar)
        Me.Controls.Add(Me.gbxver)
        Me.Controls.Add(Me.btnver)
        Me.Controls.Add(Me.btnfin)
        Me.Controls.Add(Me.lblrol)
        Me.Controls.Add(Me.btnclose)
        Me.Controls.Add(Me.lbltipou)
        Me.Controls.Add(Me.lbltitulo)
        Me.Controls.Add(Me.gbxusuarios)
        Me.Controls.Add(Me.btncancel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "ingdatosusuarios"
        Me.Text = "S.I.B.A"
        Me.gbxusuarios.ResumeLayout(False)
        Me.gbxusuarios.PerformLayout()
        Me.gbxedit.ResumeLayout(False)
        Me.gbxedit.PerformLayout()
        CType(Me.dgvusuarios, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnaceptar As System.Windows.Forms.Button
    Friend WithEvents btncancel As System.Windows.Forms.Button
    Friend WithEvents gbxusuarios As System.Windows.Forms.GroupBox
    Friend WithEvents txtpass As System.Windows.Forms.TextBox
    Friend WithEvents txtnomusua As System.Windows.Forms.TextBox
    Friend WithEvents txtci As System.Windows.Forms.TextBox
    Friend WithEvents txtnombre As System.Windows.Forms.TextBox
    Friend WithEvents lblpass As System.Windows.Forms.Label
    Friend WithEvents lblnomusu As System.Windows.Forms.Label
    Friend WithEvents lblci As System.Windows.Forms.Label
    Friend WithEvents lblnombre As System.Windows.Forms.Label
    Friend WithEvents lbltitulo As System.Windows.Forms.Label
    Friend WithEvents lblrol As System.Windows.Forms.Label
    Friend WithEvents btnclose As System.Windows.Forms.Button
    Friend WithEvents lbltipou As System.Windows.Forms.Label
    Friend WithEvents lblreppas As System.Windows.Forms.Label
    Friend WithEvents btnfin As System.Windows.Forms.Button
    Friend WithEvents cmbperfil As System.Windows.Forms.ComboBox
    Friend WithEvents lblperfil As System.Windows.Forms.Label
    Friend WithEvents lblemail As System.Windows.Forms.Label
    Friend WithEvents txtemail As System.Windows.Forms.TextBox
    Friend WithEvents txtreppass As System.Windows.Forms.TextBox
    Friend WithEvents btnver As System.Windows.Forms.Button
    Friend WithEvents dgvusuarios As System.Windows.Forms.DataGridView
    Friend WithEvents btncont As System.Windows.Forms.Button
    Friend WithEvents gbxver As System.Windows.Forms.GroupBox
    Friend WithEvents lblver As System.Windows.Forms.Label

    Friend WithEvents ttdisp As System.Windows.Forms.ToolTip
    Friend WithEvents btnreset As System.Windows.Forms.Button
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents gbxedit As System.Windows.Forms.GroupBox
    Friend WithEvents txtnombreusuario As System.Windows.Forms.TextBox
    Friend WithEvents btndisponibilidadonibilidad As System.Windows.Forms.Button
    Friend WithEvents ttDatos_ci As System.Windows.Forms.ToolTip
    Friend WithEvents lbldatos_Ci As System.Windows.Forms.Label
End Class

