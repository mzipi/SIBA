<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class modusuario
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
        Me.btnmod = New System.Windows.Forms.Button
        Me.btnatras = New System.Windows.Forms.Button
        Me.lbltitulo = New System.Windows.Forms.Label
        Me.lblrol = New System.Windows.Forms.Label
        Me.btnclose = New System.Windows.Forms.Button
        Me.lbltipou = New System.Windows.Forms.Label
        Me.gbxusuarios = New System.Windows.Forms.GroupBox
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
        Me.gbxusuarios.SuspendLayout()
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
        Me.btnatras.Text = "Atr�s"
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
        Me.lbltitulo.Size = New System.Drawing.Size(220, 26)
        Me.lbltitulo.TabIndex = 53
        Me.lbltitulo.Text = "MODIFICAR USUARIO"
        '
        'lblrol
        '
        Me.lblrol.AutoSize = True
        Me.lblrol.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblrol.Location = New System.Drawing.Point(391, 9)
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
        Me.btnclose.Text = "Cerrar sesi�n"
        Me.btnclose.UseVisualStyleBackColor = True
        '
        'lbltipou
        '
        Me.lbltipou.AutoSize = True
        Me.lbltipou.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltipou.Location = New System.Drawing.Point(430, 9)
        Me.lbltipou.Name = "lbltipou"
        Me.lbltipou.Size = New System.Drawing.Size(164, 16)
        Me.lbltipou.TabIndex = 69
        Me.lbltipou.Text = "Encargado inform�tico"
        '
        'gbxusuarios
        '
        Me.gbxusuarios.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
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
        Me.gbxusuarios.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbxusuarios.Location = New System.Drawing.Point(15, 55)
        Me.gbxusuarios.Name = "gbxusuarios"
        Me.gbxusuarios.Size = New System.Drawing.Size(244, 289)
        Me.gbxusuarios.TabIndex = 72
        Me.gbxusuarios.TabStop = False
        Me.gbxusuarios.Text = "Usuarios"
        '
        'lblemail
        '
        Me.lblemail.AutoSize = True
        Me.lblemail.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblemail.Location = New System.Drawing.Point(11, 244)
        Me.lblemail.Name = "lblemail"
        Me.lblemail.Size = New System.Drawing.Size(42, 16)
        Me.lblemail.TabIndex = 18
        Me.lblemail.Text = "Email"
        '
        'txtemail
        '
        Me.txtemail.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtemail.Location = New System.Drawing.Point(9, 261)
        Me.txtemail.Name = "txtemail"
        Me.txtemail.Size = New System.Drawing.Size(218, 22)
        Me.txtemail.TabIndex = 17
        '
        'txtreppass
        '
        Me.txtreppass.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtreppass.Location = New System.Drawing.Point(123, 219)
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
        Me.cmbperfil.Items.AddRange(New Object() {"(Seleccione)", "Adminstrativo", "Alumno", "Director", "Docente", "Encargado inform�tico", "Secretario Escolar"})
        Me.cmbperfil.Location = New System.Drawing.Point(6, 133)
        Me.cmbperfil.Name = "cmbperfil"
        Me.cmbperfil.Size = New System.Drawing.Size(221, 24)
        Me.cmbperfil.TabIndex = 15
        '
        'lblreppas
        '
        Me.lblreppas.AutoSize = True
        Me.lblreppas.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblreppas.Location = New System.Drawing.Point(120, 200)
        Me.lblreppas.Name = "lblreppas"
        Me.lblreppas.Size = New System.Drawing.Size(121, 16)
        Me.lblreppas.TabIndex = 13
        Me.lblreppas.Text = "Repita contrase�a:"
        '
        'txtpass
        '
        Me.txtpass.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtpass.Location = New System.Drawing.Point(9, 219)
        Me.txtpass.MaxLength = 12
        Me.txtpass.Name = "txtpass"
        Me.txtpass.Size = New System.Drawing.Size(104, 22)
        Me.txtpass.TabIndex = 12
        Me.txtpass.UseSystemPasswordChar = True
        '
        'txtnomusua
        '
        Me.txtnomusua.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtnomusua.Location = New System.Drawing.Point(9, 178)
        Me.txtnomusua.MaxLength = 25
        Me.txtnomusua.Name = "txtnomusua"
        Me.txtnomusua.Size = New System.Drawing.Size(218, 22)
        Me.txtnomusua.TabIndex = 9
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
        Me.txtnombre.MaxLength = 50
        Me.txtnombre.Name = "txtnombre"
        Me.txtnombre.Size = New System.Drawing.Size(218, 22)
        Me.txtnombre.TabIndex = 6
        '
        'lblpass
        '
        Me.lblpass.AutoSize = True
        Me.lblpass.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblpass.Location = New System.Drawing.Point(6, 200)
        Me.lblpass.Name = "lblpass"
        Me.lblpass.Size = New System.Drawing.Size(80, 16)
        Me.lblpass.TabIndex = 5
        Me.lblpass.Text = "Contrase�a:"
        '
        'lblnomusu
        '
        Me.lblnomusu.AutoSize = True
        Me.lblnomusu.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblnomusu.Location = New System.Drawing.Point(6, 160)
        Me.lblnomusu.Name = "lblnomusu"
        Me.lblnomusu.Size = New System.Drawing.Size(107, 16)
        Me.lblnomusu.TabIndex = 4
        Me.lblnomusu.Text = "Nombre usuario:"
        '
        'lblperfil
        '
        Me.lblperfil.AutoSize = True
        Me.lblperfil.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblperfil.Location = New System.Drawing.Point(6, 114)
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
        Me.lblci.Text = "Cedula de Identidad:"
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
        'modusuario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(620, 356)
        Me.Controls.Add(Me.gbxusuarios)
        Me.Controls.Add(Me.lblrol)
        Me.Controls.Add(Me.btnclose)
        Me.Controls.Add(Me.lbltipou)
        Me.Controls.Add(Me.lbltitulo)
        Me.Controls.Add(Me.btnmod)
        Me.Controls.Add(Me.btnatras)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "modusuario"
        Me.Text = "S.I.B.A"
        Me.gbxusuarios.ResumeLayout(False)
        Me.gbxusuarios.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnmod As System.Windows.Forms.Button
    Friend WithEvents btnatras As System.Windows.Forms.Button
    Friend WithEvents lbltitulo As System.Windows.Forms.Label
    Friend WithEvents lblrol As System.Windows.Forms.Label
    Friend WithEvents btnclose As System.Windows.Forms.Button
    Friend WithEvents lbltipou As System.Windows.Forms.Label
    Friend WithEvents gbxusuarios As System.Windows.Forms.GroupBox
    Friend WithEvents lblemail As System.Windows.Forms.Label
    Friend WithEvents txtemail As System.Windows.Forms.TextBox
    Friend WithEvents txtreppass As System.Windows.Forms.TextBox
    Friend WithEvents cmbperfil As System.Windows.Forms.ComboBox
    Friend WithEvents lblreppas As System.Windows.Forms.Label
    Friend WithEvents txtpass As System.Windows.Forms.TextBox
    Friend WithEvents txtnomusua As System.Windows.Forms.TextBox
    Friend WithEvents txtci As System.Windows.Forms.TextBox
    Friend WithEvents txtnombre As System.Windows.Forms.TextBox
    Friend WithEvents lblpass As System.Windows.Forms.Label
    Friend WithEvents lblnomusu As System.Windows.Forms.Label
    Friend WithEvents lblperfil As System.Windows.Forms.Label
    Friend WithEvents lblci As System.Windows.Forms.Label
    Friend WithEvents lblnombre As System.Windows.Forms.Label
End Class

