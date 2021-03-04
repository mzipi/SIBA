<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class altaturno
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(altaturno))
        Me.btnaceptar = New System.Windows.Forms.Button
        Me.btnatras = New System.Windows.Forms.Button
        Me.gbxturno = New System.Windows.Forms.GroupBox
        Me.txtnombre = New System.Windows.Forms.TextBox
        Me.txtcod = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.lbltitulo = New System.Windows.Forms.Label
        Me.lblrol = New System.Windows.Forms.Label
        Me.btnclose = New System.Windows.Forms.Button
        Me.lbltipou = New System.Windows.Forms.Label
        Me.lbldesarrollo = New System.Windows.Forms.Label
        Me.pbxlogo = New System.Windows.Forms.PictureBox
        Me.lblsiba = New System.Windows.Forms.Label
        Me.btnmenu = New System.Windows.Forms.Button
        Me.gbxturno.SuspendLayout()
        CType(Me.pbxlogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnaceptar
        '
        Me.btnaceptar.BackColor = System.Drawing.Color.Transparent
        Me.btnaceptar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnaceptar.ForeColor = System.Drawing.Color.Red
        Me.btnaceptar.Location = New System.Drawing.Point(126, 150)
        Me.btnaceptar.Name = "btnaceptar"
        Me.btnaceptar.Size = New System.Drawing.Size(101, 24)
        Me.btnaceptar.TabIndex = 3
        Me.btnaceptar.Text = "Ingresar"
        Me.btnaceptar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage
        Me.btnaceptar.UseVisualStyleBackColor = False
        '
        'btnatras
        '
        Me.btnatras.BackColor = System.Drawing.Color.Transparent
        Me.btnatras.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnatras.ForeColor = System.Drawing.Color.Red
        Me.btnatras.Location = New System.Drawing.Point(9, 149)
        Me.btnatras.Name = "btnatras"
        Me.btnatras.Size = New System.Drawing.Size(101, 24)
        Me.btnatras.TabIndex = 4
        Me.btnatras.Text = "Finalizar"
        Me.btnatras.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage
        Me.btnatras.UseVisualStyleBackColor = False
        '
        'gbxturno
        '
        Me.gbxturno.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbxturno.Controls.Add(Me.txtnombre)
        Me.gbxturno.Controls.Add(Me.txtcod)
        Me.gbxturno.Controls.Add(Me.Label3)
        Me.gbxturno.Controls.Add(Me.Label2)
        Me.gbxturno.Controls.Add(Me.btnaceptar)
        Me.gbxturno.Controls.Add(Me.btnatras)
        Me.gbxturno.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbxturno.Location = New System.Drawing.Point(16, 55)
        Me.gbxturno.Name = "gbxturno"
        Me.gbxturno.Size = New System.Drawing.Size(258, 177)
        Me.gbxturno.TabIndex = 21
        Me.gbxturno.TabStop = False
        Me.gbxturno.Text = "Turno"
        '
        'txtnombre
        '
        Me.txtnombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtnombre.Location = New System.Drawing.Point(9, 100)
        Me.txtnombre.MaxLength = 15
        Me.txtnombre.Name = "txtnombre"
        Me.txtnombre.Size = New System.Drawing.Size(218, 22)
        Me.txtnombre.TabIndex = 2
        '
        'txtcod
        '
        Me.txtcod.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtcod.Location = New System.Drawing.Point(9, 45)
        Me.txtcod.MaxLength = 6
        Me.txtcod.Name = "txtcod"
        Me.txtcod.Size = New System.Drawing.Size(218, 22)
        Me.txtcod.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(6, 80)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(67, 16)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Nombre:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(6, 25)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(62, 16)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Código:"
        '
        'lbltitulo
        '
        Me.lbltitulo.AutoSize = True
        Me.lbltitulo.BackColor = System.Drawing.Color.LemonChiffon
        Me.lbltitulo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbltitulo.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltitulo.Location = New System.Drawing.Point(16, 9)
        Me.lbltitulo.Name = "lbltitulo"
        Me.lbltitulo.Size = New System.Drawing.Size(216, 26)
        Me.lbltitulo.TabIndex = 136
        Me.lbltitulo.Text = "INGRESO DE TURNO"
        '
        'lblrol
        '
        Me.lblrol.AutoSize = True
        Me.lblrol.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblrol.Location = New System.Drawing.Point(389, 9)
        Me.lblrol.Name = "lblrol"
        Me.lblrol.Size = New System.Drawing.Size(36, 16)
        Me.lblrol.TabIndex = 144
        Me.lblrol.Text = "Rol:"
        '
        'btnclose
        '
        Me.btnclose.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnclose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnclose.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnclose.Location = New System.Drawing.Point(461, 28)
        Me.btnclose.Name = "btnclose"
        Me.btnclose.Size = New System.Drawing.Size(102, 24)
        Me.btnclose.TabIndex = 5
        Me.btnclose.Text = "Cerrar sesión"
        Me.btnclose.UseVisualStyleBackColor = True
        '
        'lbltipou
        '
        Me.lbltipou.AutoSize = True
        Me.lbltipou.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltipou.Location = New System.Drawing.Point(426, 9)
        Me.lbltipou.Name = "lbltipou"
        Me.lbltipou.Size = New System.Drawing.Size(137, 16)
        Me.lbltipou.TabIndex = 142
        Me.lbltipou.Text = "Secretario Escolar"
        '
        'lbldesarrollo
        '
        Me.lbldesarrollo.AutoSize = True
        Me.lbldesarrollo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.lbldesarrollo.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lbldesarrollo.Location = New System.Drawing.Point(363, 277)
        Me.lbldesarrollo.Name = "lbldesarrollo"
        Me.lbldesarrollo.Size = New System.Drawing.Size(185, 13)
        Me.lbldesarrollo.TabIndex = 147
        Me.lbldesarrollo.Text = "Desarrollo y mantenimiento por:"
        '
        'pbxlogo
        '
        Me.pbxlogo.Image = CType(resources.GetObject("pbxlogo.Image"), System.Drawing.Image)
        Me.pbxlogo.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.pbxlogo.Location = New System.Drawing.Point(392, 293)
        Me.pbxlogo.Name = "pbxlogo"
        Me.pbxlogo.Size = New System.Drawing.Size(139, 44)
        Me.pbxlogo.TabIndex = 146
        Me.pbxlogo.TabStop = False
        '
        'lblsiba
        '
        Me.lblsiba.Font = New System.Drawing.Font("Pristina", 26.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblsiba.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblsiba.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblsiba.Location = New System.Drawing.Point(238, 9)
        Me.lblsiba.Name = "lblsiba"
        Me.lblsiba.Size = New System.Drawing.Size(136, 43)
        Me.lblsiba.TabIndex = 148
        Me.lblsiba.Text = "S.I.B.A."
        '
        'btnmenu
        '
        Me.btnmenu.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnmenu.ForeColor = System.Drawing.Color.Red
        Me.btnmenu.Location = New System.Drawing.Point(24, 303)
        Me.btnmenu.Name = "btnmenu"
        Me.btnmenu.Size = New System.Drawing.Size(162, 22)
        Me.btnmenu.TabIndex = 149
        Me.btnmenu.Text = "Administrador Turno"
        Me.btnmenu.UseVisualStyleBackColor = True
        '
        'altaturno
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(584, 358)
        Me.Controls.Add(Me.btnmenu)
        Me.Controls.Add(Me.lblsiba)
        Me.Controls.Add(Me.lbldesarrollo)
        Me.Controls.Add(Me.pbxlogo)
        Me.Controls.Add(Me.lblrol)
        Me.Controls.Add(Me.btnclose)
        Me.Controls.Add(Me.lbltipou)
        Me.Controls.Add(Me.lbltitulo)
        Me.Controls.Add(Me.gbxturno)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "altaturno"
        Me.Text = "S.I.B.A"
        Me.gbxturno.ResumeLayout(False)
        Me.gbxturno.PerformLayout()
        CType(Me.pbxlogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnaceptar As System.Windows.Forms.Button
    Friend WithEvents btnatras As System.Windows.Forms.Button
    Friend WithEvents gbxturno As System.Windows.Forms.GroupBox
    Friend WithEvents txtnombre As System.Windows.Forms.TextBox
    Friend WithEvents txtcod As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lbltitulo As System.Windows.Forms.Label
    Friend WithEvents lblrol As System.Windows.Forms.Label
    Friend WithEvents btnclose As System.Windows.Forms.Button
    Friend WithEvents lbltipou As System.Windows.Forms.Label
    Friend WithEvents lbldesarrollo As System.Windows.Forms.Label
    Friend WithEvents pbxlogo As System.Windows.Forms.PictureBox
    Friend WithEvents lblsiba As System.Windows.Forms.Label
    Friend WithEvents btnmenu As System.Windows.Forms.Button
End Class

