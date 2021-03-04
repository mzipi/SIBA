<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class planilladodir
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(planilladodir))
        Me.pbxplancomp = New System.Windows.Forms.PictureBox
        Me.lbltitulo = New System.Windows.Forms.Label
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.btnno = New System.Windows.Forms.Button
        Me.btnsi = New System.Windows.Forms.Button
        Me.btnclose = New System.Windows.Forms.Button
        Me.lblrol = New System.Windows.Forms.Label
        Me.lbltipou = New System.Windows.Forms.Label
        Me.lblhora = New System.Windows.Forms.Label
        Me.btnmenu = New System.Windows.Forms.Button
        Me.gbxobs = New System.Windows.Forms.GroupBox
        Me.txtobs = New System.Windows.Forms.TextBox
        Me.btnenv = New System.Windows.Forms.Button
        CType(Me.pbxplancomp, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.gbxobs.SuspendLayout()
        Me.SuspendLayout()
        '
        'pbxplancomp
        '
        Me.pbxplancomp.Image = CType(resources.GetObject("pbxplancomp.Image"), System.Drawing.Image)
        Me.pbxplancomp.Location = New System.Drawing.Point(12, 62)
        Me.pbxplancomp.Name = "pbxplancomp"
        Me.pbxplancomp.Size = New System.Drawing.Size(495, 325)
        Me.pbxplancomp.TabIndex = 1
        Me.pbxplancomp.TabStop = False
        '
        'lbltitulo
        '
        Me.lbltitulo.AutoSize = True
        Me.lbltitulo.BackColor = System.Drawing.Color.LemonChiffon
        Me.lbltitulo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbltitulo.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltitulo.Location = New System.Drawing.Point(12, 9)
        Me.lbltitulo.Name = "lbltitulo"
        Me.lbltitulo.Size = New System.Drawing.Size(264, 26)
        Me.lbltitulo.TabIndex = 50
        Me.lbltitulo.Text = "VALIDACIÓN PLANILLADO"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnno)
        Me.GroupBox1.Controls.Add(Me.btnsi)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(294, 404)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(213, 55)
        Me.GroupBox1.TabIndex = 53
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Validación"
        '
        'btnno
        '
        Me.btnno.Location = New System.Drawing.Point(122, 21)
        Me.btnno.Name = "btnno"
        Me.btnno.Size = New System.Drawing.Size(75, 23)
        Me.btnno.TabIndex = 64
        Me.btnno.Text = "No"
        Me.btnno.UseVisualStyleBackColor = True
        '
        'btnsi
        '
        Me.btnsi.Location = New System.Drawing.Point(18, 21)
        Me.btnsi.Name = "btnsi"
        Me.btnsi.Size = New System.Drawing.Size(75, 23)
        Me.btnsi.TabIndex = 63
        Me.btnsi.Text = "Si"
        Me.btnsi.UseVisualStyleBackColor = True
        '
        'btnclose
        '
        Me.btnclose.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnclose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnclose.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnclose.Location = New System.Drawing.Point(629, 28)
        Me.btnclose.Name = "btnclose"
        Me.btnclose.Size = New System.Drawing.Size(102, 24)
        Me.btnclose.TabIndex = 59
        Me.btnclose.Text = "Cerrar sesión"
        Me.btnclose.UseVisualStyleBackColor = True
        '
        'lblrol
        '
        Me.lblrol.AutoSize = True
        Me.lblrol.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblrol.Location = New System.Drawing.Point(626, 9)
        Me.lblrol.Name = "lblrol"
        Me.lblrol.Size = New System.Drawing.Size(36, 16)
        Me.lblrol.TabIndex = 56
        Me.lblrol.Text = "Rol:"
        '
        'lbltipou
        '
        Me.lbltipou.AutoSize = True
        Me.lbltipou.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltipou.Location = New System.Drawing.Point(668, 9)
        Me.lbltipou.Name = "lbltipou"
        Me.lbltipou.Size = New System.Drawing.Size(63, 16)
        Me.lbltipou.TabIndex = 58
        Me.lbltipou.Text = "Director"
        '
        'lblhora
        '
        Me.lblhora.AutoSize = True
        Me.lblhora.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblhora.Location = New System.Drawing.Point(558, 0)
        Me.lblhora.Name = "lblhora"
        Me.lblhora.Size = New System.Drawing.Size(0, 16)
        Me.lblhora.TabIndex = 54
        '
        'btnmenu
        '
        Me.btnmenu.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnmenu.Location = New System.Drawing.Point(524, 436)
        Me.btnmenu.Name = "btnmenu"
        Me.btnmenu.Size = New System.Drawing.Size(207, 23)
        Me.btnmenu.TabIndex = 60
        Me.btnmenu.Text = "MENÚ PRINCIPAL"
        Me.btnmenu.UseVisualStyleBackColor = True
        '
        'gbxobs
        '
        Me.gbxobs.Controls.Add(Me.txtobs)
        Me.gbxobs.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbxobs.Location = New System.Drawing.Point(524, 80)
        Me.gbxobs.Name = "gbxobs"
        Me.gbxobs.Size = New System.Drawing.Size(207, 267)
        Me.gbxobs.TabIndex = 61
        Me.gbxobs.TabStop = False
        Me.gbxobs.Text = "Observaciones"
        '
        'txtobs
        '
        Me.txtobs.Location = New System.Drawing.Point(6, 21)
        Me.txtobs.Multiline = True
        Me.txtobs.Name = "txtobs"
        Me.txtobs.Size = New System.Drawing.Size(190, 232)
        Me.txtobs.TabIndex = 0
        '
        'btnenv
        '
        Me.btnenv.Enabled = False
        Me.btnenv.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnenv.Location = New System.Drawing.Point(524, 404)
        Me.btnenv.Name = "btnenv"
        Me.btnenv.Size = New System.Drawing.Size(207, 23)
        Me.btnenv.TabIndex = 62
        Me.btnenv.Text = "ENVIAR OBSERVACIONES"
        Me.btnenv.UseVisualStyleBackColor = True
        '
        'planilladodir
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(767, 526)
        Me.Controls.Add(Me.btnenv)
        Me.Controls.Add(Me.gbxobs)
        Me.Controls.Add(Me.btnmenu)
        Me.Controls.Add(Me.btnclose)
        Me.Controls.Add(Me.lblrol)
        Me.Controls.Add(Me.lbltipou)
        Me.Controls.Add(Me.lblhora)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.lbltitulo)
        Me.Controls.Add(Me.pbxplancomp)
        Me.Name = "planilladodir"
        Me.Text = "S.I.B.A"
        CType(Me.pbxplancomp, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.gbxobs.ResumeLayout(False)
        Me.gbxobs.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents pbxplancomp As System.Windows.Forms.PictureBox
    Friend WithEvents lbltitulo As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents btnclose As System.Windows.Forms.Button
    Friend WithEvents lblrol As System.Windows.Forms.Label
    Friend WithEvents lbltipou As System.Windows.Forms.Label
    Friend WithEvents lblhora As System.Windows.Forms.Label
    Friend WithEvents gbxobs As System.Windows.Forms.GroupBox
    Friend WithEvents txtobs As System.Windows.Forms.TextBox
    Friend WithEvents btnenv As System.Windows.Forms.Button
    Friend WithEvents btnno As System.Windows.Forms.Button
    Friend WithEvents btnsi As System.Windows.Forms.Button
    Friend WithEvents btnmenu As System.Windows.Forms.Button
End Class
