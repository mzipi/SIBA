<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class consplanalum
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(consplanalum))
        Me.pbxplancomp = New System.Windows.Forms.PictureBox
        Me.lbltitulo = New System.Windows.Forms.Label
        Me.cmbturno = New System.Windows.Forms.ComboBox
        Me.Label10 = New System.Windows.Forms.Label
        Me.gbxopc = New System.Windows.Forms.GroupBox
        Me.btnhorcomp = New System.Windows.Forms.Button
        Me.btngrupdia = New System.Windows.Forms.Button
        Me.gbxdatos = New System.Windows.Forms.GroupBox
        Me.lbltursel = New System.Windows.Forms.Label
        Me.lblturno = New System.Windows.Forms.Label
        Me.lbldiasel = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.gbxsel = New System.Windows.Forms.GroupBox
        Me.btning = New System.Windows.Forms.Button
        Me.cmbdia = New System.Windows.Forms.ComboBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.btnatras = New System.Windows.Forms.Button
        Me.lblrol = New System.Windows.Forms.Label
        Me.btnclose = New System.Windows.Forms.Button
        Me.lbltipou = New System.Windows.Forms.Label
        Me.btnmenu = New System.Windows.Forms.Button
        CType(Me.pbxplancomp, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbxopc.SuspendLayout()
        Me.gbxdatos.SuspendLayout()
        Me.gbxsel.SuspendLayout()
        Me.SuspendLayout()
        '
        'pbxplancomp
        '
        Me.pbxplancomp.Image = CType(resources.GetObject("pbxplancomp.Image"), System.Drawing.Image)
        Me.pbxplancomp.Location = New System.Drawing.Point(200, 107)
        Me.pbxplancomp.Name = "pbxplancomp"
        Me.pbxplancomp.Size = New System.Drawing.Size(495, 344)
        Me.pbxplancomp.TabIndex = 0
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
        Me.lbltitulo.Size = New System.Drawing.Size(286, 26)
        Me.lbltitulo.TabIndex = 49
        Me.lbltitulo.Text = "CONSULTA DE PLANILLADO"
        '
        'cmbturno
        '
        Me.cmbturno.FormattingEnabled = True
        Me.cmbturno.Items.AddRange(New Object() {"(Seleccione)", "Matutino ", "Vespertino ", "Nocturno"})
        Me.cmbturno.Location = New System.Drawing.Point(23, 35)
        Me.cmbturno.Name = "cmbturno"
        Me.cmbturno.Size = New System.Drawing.Size(237, 21)
        Me.cmbturno.TabIndex = 151
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(23, 16)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(221, 16)
        Me.Label10.TabIndex = 150
        Me.Label10.Text = "Seleccione el turno a consultar"
        '
        'gbxopc
        '
        Me.gbxopc.Controls.Add(Me.btnhorcomp)
        Me.gbxopc.Controls.Add(Me.btngrupdia)
        Me.gbxopc.Location = New System.Drawing.Point(27, 67)
        Me.gbxopc.Name = "gbxopc"
        Me.gbxopc.Size = New System.Drawing.Size(280, 113)
        Me.gbxopc.TabIndex = 155
        Me.gbxopc.TabStop = False
        Me.gbxopc.Text = "Opciones"
        '
        'btnhorcomp
        '
        Me.btnhorcomp.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnhorcomp.Location = New System.Drawing.Point(15, 62)
        Me.btnhorcomp.Name = "btnhorcomp"
        Me.btnhorcomp.Size = New System.Drawing.Size(240, 23)
        Me.btnhorcomp.TabIndex = 2
        Me.btnhorcomp.Text = "Planillado de grupo por día"
        Me.btnhorcomp.UseVisualStyleBackColor = True
        '
        'btngrupdia
        '
        Me.btngrupdia.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btngrupdia.Location = New System.Drawing.Point(15, 33)
        Me.btngrupdia.Name = "btngrupdia"
        Me.btngrupdia.Size = New System.Drawing.Size(240, 23)
        Me.btngrupdia.TabIndex = 1
        Me.btngrupdia.Text = "Planillado de horario completo"
        Me.btngrupdia.UseVisualStyleBackColor = True
        '
        'gbxdatos
        '
        Me.gbxdatos.BackColor = System.Drawing.SystemColors.Control
        Me.gbxdatos.Controls.Add(Me.lbltursel)
        Me.gbxdatos.Controls.Add(Me.lblturno)
        Me.gbxdatos.Controls.Add(Me.lbldiasel)
        Me.gbxdatos.Controls.Add(Me.Label3)
        Me.gbxdatos.ForeColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.gbxdatos.Location = New System.Drawing.Point(227, 38)
        Me.gbxdatos.Name = "gbxdatos"
        Me.gbxdatos.Size = New System.Drawing.Size(519, 45)
        Me.gbxdatos.TabIndex = 162
        Me.gbxdatos.TabStop = False
        Me.gbxdatos.Text = "Consulta"
        '
        'lbltursel
        '
        Me.lbltursel.AutoSize = True
        Me.lbltursel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltursel.Location = New System.Drawing.Point(374, 23)
        Me.lbltursel.Name = "lbltursel"
        Me.lbltursel.Size = New System.Drawing.Size(0, 16)
        Me.lbltursel.TabIndex = 166
        '
        'lblturno
        '
        Me.lblturno.AutoSize = True
        Me.lblturno.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblturno.Location = New System.Drawing.Point(269, 21)
        Me.lblturno.Name = "lblturno"
        Me.lblturno.Size = New System.Drawing.Size(52, 16)
        Me.lblturno.TabIndex = 165
        Me.lblturno.Text = "Turno:"
        '
        'lbldiasel
        '
        Me.lbldiasel.AutoSize = True
        Me.lbldiasel.BackColor = System.Drawing.SystemColors.Control
        Me.lbldiasel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbldiasel.Location = New System.Drawing.Point(87, 23)
        Me.lbldiasel.Name = "lbldiasel"
        Me.lbldiasel.Size = New System.Drawing.Size(0, 16)
        Me.lbldiasel.TabIndex = 162
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(22, 21)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(44, 16)
        Me.Label3.TabIndex = 161
        Me.Label3.Text = "Día:  "
        '
        'gbxsel
        '
        Me.gbxsel.Controls.Add(Me.btning)
        Me.gbxsel.Controls.Add(Me.cmbdia)
        Me.gbxsel.Controls.Add(Me.Label1)
        Me.gbxsel.Controls.Add(Me.Label10)
        Me.gbxsel.Controls.Add(Me.cmbturno)
        Me.gbxsel.Location = New System.Drawing.Point(27, 214)
        Me.gbxsel.Name = "gbxsel"
        Me.gbxsel.Size = New System.Drawing.Size(280, 197)
        Me.gbxsel.TabIndex = 156
        Me.gbxsel.TabStop = False
        Me.gbxsel.Text = "Seleccionar"
        '
        'btning
        '
        Me.btning.Location = New System.Drawing.Point(190, 157)
        Me.btning.Name = "btning"
        Me.btning.Size = New System.Drawing.Size(70, 26)
        Me.btning.TabIndex = 156
        Me.btning.Text = "Ingresar"
        Me.btning.UseVisualStyleBackColor = True
        '
        'cmbdia
        '
        Me.cmbdia.FormattingEnabled = True
        Me.cmbdia.Items.AddRange(New Object() {"(Seleccione)", "Lunes", "Martes", "Miércoles", "Jueves", "Viernes", "Sábado"})
        Me.cmbdia.Location = New System.Drawing.Point(23, 98)
        Me.cmbdia.Name = "cmbdia"
        Me.cmbdia.Size = New System.Drawing.Size(237, 21)
        Me.cmbdia.TabIndex = 155
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(23, 69)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(209, 16)
        Me.Label1.TabIndex = 154
        Me.Label1.Text = "Seleccione el día a consultar"
        '
        'btnatras
        '
        Me.btnatras.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnatras.Location = New System.Drawing.Point(608, 457)
        Me.btnatras.Name = "btnatras"
        Me.btnatras.Size = New System.Drawing.Size(138, 26)
        Me.btnatras.TabIndex = 156
        Me.btnatras.Text = "ATRÁS"
        Me.btnatras.UseVisualStyleBackColor = True
        '
        'lblrol
        '
        Me.lblrol.AutoSize = True
        Me.lblrol.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblrol.Location = New System.Drawing.Point(555, 9)
        Me.lblrol.Name = "lblrol"
        Me.lblrol.Size = New System.Drawing.Size(36, 16)
        Me.lblrol.TabIndex = 159
        Me.lblrol.Text = "Rol:"
        '
        'btnclose
        '
        Me.btnclose.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnclose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnclose.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnclose.Location = New System.Drawing.Point(632, 28)
        Me.btnclose.Name = "btnclose"
        Me.btnclose.Size = New System.Drawing.Size(102, 24)
        Me.btnclose.TabIndex = 158
        Me.btnclose.Text = "Cerrar sesión"
        Me.btnclose.UseVisualStyleBackColor = True
        '
        'lbltipou
        '
        Me.lbltipou.AutoSize = True
        Me.lbltipou.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltipou.Location = New System.Drawing.Point(597, 9)
        Me.lbltipou.Name = "lbltipou"
        Me.lbltipou.Size = New System.Drawing.Size(0, 16)
        Me.lbltipou.TabIndex = 157
        '
        'btnmenu
        '
        Me.btnmenu.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnmenu.Location = New System.Drawing.Point(27, 473)
        Me.btnmenu.Name = "btnmenu"
        Me.btnmenu.Size = New System.Drawing.Size(154, 26)
        Me.btnmenu.TabIndex = 160
        Me.btnmenu.Text = "MENÚ REPORTES"
        Me.btnmenu.UseVisualStyleBackColor = True
        '
        'consplanalum
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(769, 536)
        Me.Controls.Add(Me.gbxdatos)
        Me.Controls.Add(Me.btnmenu)
        Me.Controls.Add(Me.lblrol)
        Me.Controls.Add(Me.gbxsel)
        Me.Controls.Add(Me.pbxplancomp)
        Me.Controls.Add(Me.btnclose)
        Me.Controls.Add(Me.lbltipou)
        Me.Controls.Add(Me.btnatras)
        Me.Controls.Add(Me.gbxopc)
        Me.Controls.Add(Me.lbltitulo)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "consplanalum"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "S.I.B.A"
        CType(Me.pbxplancomp, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbxopc.ResumeLayout(False)
        Me.gbxdatos.ResumeLayout(False)
        Me.gbxdatos.PerformLayout()
        Me.gbxsel.ResumeLayout(False)
        Me.gbxsel.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents pbxplancomp As System.Windows.Forms.PictureBox
    Friend WithEvents lbltitulo As System.Windows.Forms.Label
    Friend WithEvents cmbturno As System.Windows.Forms.ComboBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents gbxopc As System.Windows.Forms.GroupBox
    Friend WithEvents gbxsel As System.Windows.Forms.GroupBox
    Friend WithEvents cmbdia As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnatras As System.Windows.Forms.Button
    Friend WithEvents lblrol As System.Windows.Forms.Label
    Friend WithEvents btnclose As System.Windows.Forms.Button
    Friend WithEvents lbltipou As System.Windows.Forms.Label
    Friend WithEvents btnmenu As System.Windows.Forms.Button
    Friend WithEvents btnhorcomp As System.Windows.Forms.Button
    Friend WithEvents btngrupdia As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents gbxdatos As System.Windows.Forms.GroupBox
    Friend WithEvents lbldiasel As System.Windows.Forms.Label
    Friend WithEvents lbltursel As System.Windows.Forms.Label
    Friend WithEvents lblturno As System.Windows.Forms.Label
    Friend WithEvents btning As System.Windows.Forms.Button
End Class
