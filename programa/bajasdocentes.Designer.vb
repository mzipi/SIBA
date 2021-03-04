<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class bajasdocentes
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(bajasdocentes))
        Me.btning = New System.Windows.Forms.Button
        Me.btncancel = New System.Windows.Forms.Button
        Me.gbxhrsvac = New System.Windows.Forms.GroupBox
        Me.cmbmotivo = New System.Windows.Forms.ComboBox
        Me.dtpdesde = New System.Windows.Forms.DateTimePicker
        Me.txtmat = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.txtgrupo = New System.Windows.Forms.TextBox
        Me.txtnombre = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.lblestfun = New System.Windows.Forms.Label
        Me.lblant = New System.Windows.Forms.Label
        Me.lblnombre = New System.Windows.Forms.Label
        Me.lbltitulo = New System.Windows.Forms.Label
        Me.lblrol = New System.Windows.Forms.Label
        Me.btnclose = New System.Windows.Forms.Button
        Me.lbltipou = New System.Windows.Forms.Label
        Me.btnfin = New System.Windows.Forms.Button
        Me.txtidg = New System.Windows.Forms.TextBox
        Me.txtcod_mat = New System.Windows.Forms.TextBox
        Me.txtci = New System.Windows.Forms.TextBox
        Me.lblsiba = New System.Windows.Forms.Label
        Me.lbldesarrollo = New System.Windows.Forms.Label
        Me.pbxlogo = New System.Windows.Forms.PictureBox
        Me.txtest_fun = New System.Windows.Forms.TextBox
        Me.gbxhrsvac.SuspendLayout()
        CType(Me.pbxlogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btning
        '
        Me.btning.BackColor = System.Drawing.Color.Transparent
        Me.btning.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btning.Location = New System.Drawing.Point(413, 138)
        Me.btning.Name = "btning"
        Me.btning.Size = New System.Drawing.Size(101, 24)
        Me.btning.TabIndex = 19
        Me.btning.Text = "Baja"
        Me.btning.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage
        Me.btning.UseVisualStyleBackColor = False
        '
        'btncancel
        '
        Me.btncancel.BackColor = System.Drawing.Color.Transparent
        Me.btncancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btncancel.Location = New System.Drawing.Point(413, 179)
        Me.btncancel.Name = "btncancel"
        Me.btncancel.Size = New System.Drawing.Size(101, 22)
        Me.btncancel.TabIndex = 18
        Me.btncancel.Text = "Cancelar"
        Me.btncancel.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage
        Me.btncancel.UseVisualStyleBackColor = False
        '
        'gbxhrsvac
        '
        Me.gbxhrsvac.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbxhrsvac.Controls.Add(Me.cmbmotivo)
        Me.gbxhrsvac.Controls.Add(Me.dtpdesde)
        Me.gbxhrsvac.Controls.Add(Me.txtmat)
        Me.gbxhrsvac.Controls.Add(Me.Label3)
        Me.gbxhrsvac.Controls.Add(Me.txtgrupo)
        Me.gbxhrsvac.Controls.Add(Me.txtest_fun)
        Me.gbxhrsvac.Controls.Add(Me.txtnombre)
        Me.gbxhrsvac.Controls.Add(Me.Label2)
        Me.gbxhrsvac.Controls.Add(Me.Label1)
        Me.gbxhrsvac.Controls.Add(Me.lblestfun)
        Me.gbxhrsvac.Controls.Add(Me.lblant)
        Me.gbxhrsvac.Controls.Add(Me.lblnombre)
        Me.gbxhrsvac.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbxhrsvac.Location = New System.Drawing.Point(15, 47)
        Me.gbxhrsvac.Name = "gbxhrsvac"
        Me.gbxhrsvac.Size = New System.Drawing.Size(303, 285)
        Me.gbxhrsvac.TabIndex = 21
        Me.gbxhrsvac.TabStop = False
        Me.gbxhrsvac.Text = "Horas Vacantes"
        '
        'cmbmotivo
        '
        Me.cmbmotivo.FormattingEnabled = True
        Me.cmbmotivo.Items.AddRange(New Object() {"(Seleccione)", "Renuncia Total", "Renuncia Parcial", "Despido Total"})
        Me.cmbmotivo.Location = New System.Drawing.Point(6, 193)
        Me.cmbmotivo.Name = "cmbmotivo"
        Me.cmbmotivo.Size = New System.Drawing.Size(210, 28)
        Me.cmbmotivo.TabIndex = 31
        '
        'dtpdesde
        '
        Me.dtpdesde.CalendarFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpdesde.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpdesde.Location = New System.Drawing.Point(6, 250)
        Me.dtpdesde.Name = "dtpdesde"
        Me.dtpdesde.Size = New System.Drawing.Size(207, 22)
        Me.dtpdesde.TabIndex = 30
        '
        'txtmat
        '
        Me.txtmat.Location = New System.Drawing.Point(109, 145)
        Me.txtmat.Name = "txtmat"
        Me.txtmat.Size = New System.Drawing.Size(107, 26)
        Me.txtmat.TabIndex = 28
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(106, 126)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(64, 16)
        Me.Label3.TabIndex = 27
        Me.Label3.Text = "Materia:"
        '
        'txtgrupo
        '
        Me.txtgrupo.Location = New System.Drawing.Point(6, 145)
        Me.txtgrupo.Name = "txtgrupo"
        Me.txtgrupo.Size = New System.Drawing.Size(97, 26)
        Me.txtgrupo.TabIndex = 26
        '
        'txtnombre
        '
        Me.txtnombre.Location = New System.Drawing.Point(6, 47)
        Me.txtnombre.Name = "txtnombre"
        Me.txtnombre.Size = New System.Drawing.Size(210, 26)
        Me.txtnombre.TabIndex = 24
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(3, 174)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(58, 16)
        Me.Label2.TabIndex = 23
        Me.Label2.Text = "Motivo:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(3, 126)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(54, 16)
        Me.Label1.TabIndex = 21
        Me.Label1.Text = "Grupo:"
        '
        'lblestfun
        '
        Me.lblestfun.AutoSize = True
        Me.lblestfun.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblestfun.Location = New System.Drawing.Point(6, 76)
        Me.lblestfun.Name = "lblestfun"
        Me.lblestfun.Size = New System.Drawing.Size(132, 16)
        Me.lblestfun.TabIndex = 13
        Me.lblestfun.Text = "Estado Funcional:"
        '
        'lblant
        '
        Me.lblant.AutoSize = True
        Me.lblant.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblant.Location = New System.Drawing.Point(6, 224)
        Me.lblant.Name = "lblant"
        Me.lblant.Size = New System.Drawing.Size(58, 16)
        Me.lblant.TabIndex = 3
        Me.lblant.Text = "Desde:"
        '
        'lblnombre
        '
        Me.lblnombre.AutoSize = True
        Me.lblnombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblnombre.Location = New System.Drawing.Point(6, 28)
        Me.lblnombre.Name = "lblnombre"
        Me.lblnombre.Size = New System.Drawing.Size(129, 16)
        Me.lblnombre.TabIndex = 0
        Me.lblnombre.Text = "Nombre Docente:"
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
        Me.lbltitulo.TabIndex = 52
        Me.lbltitulo.Text = "BAJA DE DOCENTES"
        '
        'lblrol
        '
        Me.lblrol.AutoSize = True
        Me.lblrol.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblrol.Location = New System.Drawing.Point(455, 9)
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
        Me.lbltipou.Location = New System.Drawing.Point(497, 9)
        Me.lbltipou.Name = "lbltipou"
        Me.lbltipou.Size = New System.Drawing.Size(106, 16)
        Me.lbltipou.TabIndex = 69
        Me.lbltipou.Text = "Administrativo"
        '
        'btnfin
        '
        Me.btnfin.BackColor = System.Drawing.Color.Transparent
        Me.btnfin.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnfin.Location = New System.Drawing.Point(413, 218)
        Me.btnfin.Name = "btnfin"
        Me.btnfin.Size = New System.Drawing.Size(101, 22)
        Me.btnfin.TabIndex = 73
        Me.btnfin.Text = "Finalizar"
        Me.btnfin.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage
        Me.btnfin.UseVisualStyleBackColor = False
        '
        'txtidg
        '
        Me.txtidg.Location = New System.Drawing.Point(333, 323)
        Me.txtidg.Name = "txtidg"
        Me.txtidg.Size = New System.Drawing.Size(100, 20)
        Me.txtidg.TabIndex = 74
        '
        'txtcod_mat
        '
        Me.txtcod_mat.Location = New System.Drawing.Point(333, 349)
        Me.txtcod_mat.Name = "txtcod_mat"
        Me.txtcod_mat.Size = New System.Drawing.Size(100, 20)
        Me.txtcod_mat.TabIndex = 75
        '
        'txtci
        '
        Me.txtci.Location = New System.Drawing.Point(333, 297)
        Me.txtci.Name = "txtci"
        Me.txtci.Size = New System.Drawing.Size(100, 20)
        Me.txtci.TabIndex = 76
        '
        'lblsiba
        '
        Me.lblsiba.Font = New System.Drawing.Font("Pristina", 26.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblsiba.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblsiba.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblsiba.Location = New System.Drawing.Point(271, 9)
        Me.lblsiba.Name = "lblsiba"
        Me.lblsiba.Size = New System.Drawing.Size(129, 43)
        Me.lblsiba.TabIndex = 158
        Me.lblsiba.Text = "S.I.B.A."
        '
        'lbldesarrollo
        '
        Me.lbldesarrollo.AutoSize = True
        Me.lbldesarrollo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.lbldesarrollo.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lbldesarrollo.Location = New System.Drawing.Point(439, 304)
        Me.lbldesarrollo.Name = "lbldesarrollo"
        Me.lbldesarrollo.Size = New System.Drawing.Size(185, 13)
        Me.lbldesarrollo.TabIndex = 157
        Me.lbldesarrollo.Text = "Desarrollo y mantenimiento por:"
        '
        'pbxlogo
        '
        Me.pbxlogo.Image = CType(resources.GetObject("pbxlogo.Image"), System.Drawing.Image)
        Me.pbxlogo.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.pbxlogo.Location = New System.Drawing.Point(466, 325)
        Me.pbxlogo.Name = "pbxlogo"
        Me.pbxlogo.Size = New System.Drawing.Size(139, 44)
        Me.pbxlogo.TabIndex = 156
        Me.pbxlogo.TabStop = False
        '
        'txtest_fun
        '
        Me.txtest_fun.Location = New System.Drawing.Point(6, 95)
        Me.txtest_fun.Name = "txtest_fun"
        Me.txtest_fun.Size = New System.Drawing.Size(210, 26)
        Me.txtest_fun.TabIndex = 25
        '
        'altahrsvacantes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(634, 376)
        Me.Controls.Add(Me.lblsiba)
        Me.Controls.Add(Me.lbldesarrollo)
        Me.Controls.Add(Me.pbxlogo)
        Me.Controls.Add(Me.txtci)
        Me.Controls.Add(Me.txtcod_mat)
        Me.Controls.Add(Me.txtidg)
        Me.Controls.Add(Me.btnfin)
        Me.Controls.Add(Me.lblrol)
        Me.Controls.Add(Me.btnclose)
        Me.Controls.Add(Me.lbltipou)
        Me.Controls.Add(Me.lbltitulo)
        Me.Controls.Add(Me.gbxhrsvac)
        Me.Controls.Add(Me.btning)
        Me.Controls.Add(Me.btncancel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "altahrsvacantes"
        Me.Text = "S.I.B.A"
        Me.gbxhrsvac.ResumeLayout(False)
        Me.gbxhrsvac.PerformLayout()
        CType(Me.pbxlogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btning As System.Windows.Forms.Button
    Friend WithEvents btncancel As System.Windows.Forms.Button
    Friend WithEvents gbxhrsvac As System.Windows.Forms.GroupBox
    Friend WithEvents lblnombre As System.Windows.Forms.Label
    Friend WithEvents lbltitulo As System.Windows.Forms.Label
    Friend WithEvents lblrol As System.Windows.Forms.Label
    Friend WithEvents btnclose As System.Windows.Forms.Button
    Friend WithEvents lbltipou As System.Windows.Forms.Label
    Friend WithEvents lblestfun As System.Windows.Forms.Label
    Friend WithEvents btnfin As System.Windows.Forms.Button
    Friend WithEvents lblant As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtidg As System.Windows.Forms.TextBox
    Friend WithEvents txtcod_mat As System.Windows.Forms.TextBox
    Friend WithEvents txtci As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtnombre As System.Windows.Forms.TextBox
    Friend WithEvents dtpdesde As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtmat As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtgrupo As System.Windows.Forms.TextBox
    Friend WithEvents lblsiba As System.Windows.Forms.Label
    Friend WithEvents lbldesarrollo As System.Windows.Forms.Label
    Friend WithEvents pbxlogo As System.Windows.Forms.PictureBox
    Friend WithEvents cmbmotivo As System.Windows.Forms.ComboBox
    Friend WithEvents txtest_fun As System.Windows.Forms.TextBox
End Class

