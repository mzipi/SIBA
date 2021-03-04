<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class sinDoc
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(sinDoc))
        Me.lblrol = New System.Windows.Forms.Label
        Me.btnclose = New System.Windows.Forms.Button
        Me.btnprint = New System.Windows.Forms.Button
        Me.btnatras = New System.Windows.Forms.Button
        Me.lbltitulo = New System.Windows.Forms.Label
        Me.gbxsel = New System.Windows.Forms.GroupBox
        Me.btning = New System.Windows.Forms.Button
        Me.cmbturno = New System.Windows.Forms.ComboBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.cmbcarr = New System.Windows.Forms.ComboBox
        Me.pbxgrupsindoc = New System.Windows.Forms.PictureBox
        Me.btngenrep = New System.Windows.Forms.Button
        Me.lbltipou = New System.Windows.Forms.Label
        Me.Button1 = New System.Windows.Forms.Button
        Me.gbxsel.SuspendLayout()
        CType(Me.pbxgrupsindoc, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblrol
        '
        Me.lblrol.AutoSize = True
        Me.lblrol.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblrol.Location = New System.Drawing.Point(565, 7)
        Me.lblrol.Name = "lblrol"
        Me.lblrol.Size = New System.Drawing.Size(36, 16)
        Me.lblrol.TabIndex = 171
        Me.lblrol.Text = "Rol:"
        '
        'btnclose
        '
        Me.btnclose.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnclose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnclose.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnclose.Location = New System.Drawing.Point(610, 26)
        Me.btnclose.Name = "btnclose"
        Me.btnclose.Size = New System.Drawing.Size(102, 24)
        Me.btnclose.TabIndex = 170
        Me.btnclose.Text = "Cerrar sesión"
        Me.btnclose.UseVisualStyleBackColor = True
        '
        'btnprint
        '
        Me.btnprint.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnprint.Location = New System.Drawing.Point(478, 229)
        Me.btnprint.Name = "btnprint"
        Me.btnprint.Size = New System.Drawing.Size(123, 27)
        Me.btnprint.TabIndex = 175
        Me.btnprint.Text = "Imprimir Tabla"
        Me.btnprint.UseVisualStyleBackColor = True
        '
        'btnatras
        '
        Me.btnatras.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnatras.Location = New System.Drawing.Point(478, 296)
        Me.btnatras.Name = "btnatras"
        Me.btnatras.Size = New System.Drawing.Size(123, 27)
        Me.btnatras.TabIndex = 177
        Me.btnatras.Text = "Atrás"
        Me.btnatras.UseVisualStyleBackColor = True
        '
        'lbltitulo
        '
        Me.lbltitulo.AutoSize = True
        Me.lbltitulo.BackColor = System.Drawing.Color.LemonChiffon
        Me.lbltitulo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbltitulo.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltitulo.Location = New System.Drawing.Point(12, 9)
        Me.lbltitulo.Name = "lbltitulo"
        Me.lbltitulo.Size = New System.Drawing.Size(358, 26)
        Me.lbltitulo.TabIndex = 51
        Me.lbltitulo.Text = "CONSULTA GRUPOS SIN DOCENTE"
        '
        'gbxsel
        '
        Me.gbxsel.Controls.Add(Me.btning)
        Me.gbxsel.Controls.Add(Me.cmbturno)
        Me.gbxsel.Controls.Add(Me.Label2)
        Me.gbxsel.Controls.Add(Me.Label3)
        Me.gbxsel.Controls.Add(Me.cmbcarr)
        Me.gbxsel.Location = New System.Drawing.Point(12, 69)
        Me.gbxsel.Name = "gbxsel"
        Me.gbxsel.Size = New System.Drawing.Size(287, 187)
        Me.gbxsel.TabIndex = 178
        Me.gbxsel.TabStop = False
        Me.gbxsel.Text = "Seleccionar"
        '
        'btning
        '
        Me.btning.Location = New System.Drawing.Point(190, 146)
        Me.btning.Name = "btning"
        Me.btning.Size = New System.Drawing.Size(70, 26)
        Me.btning.TabIndex = 156
        Me.btning.Text = "Ingresar"
        Me.btning.UseVisualStyleBackColor = True
        '
        'cmbturno
        '
        Me.cmbturno.FormattingEnabled = True
        Me.cmbturno.Items.AddRange(New Object() {"(Seleccione)", "Turno Matutino", "Turno Vespertino", "Turno Nocturno"})
        Me.cmbturno.Location = New System.Drawing.Point(23, 100)
        Me.cmbturno.Name = "cmbturno"
        Me.cmbturno.Size = New System.Drawing.Size(237, 21)
        Me.cmbturno.TabIndex = 155
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(23, 68)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(221, 16)
        Me.Label2.TabIndex = 154
        Me.Label2.Text = "Seleccione el turno a consultar"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(23, 16)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(237, 16)
        Me.Label3.TabIndex = 150
        Me.Label3.Text = "Seleccione la carrera a consultar"
        '
        'cmbcarr
        '
        Me.cmbcarr.FormattingEnabled = True
        Me.cmbcarr.Items.AddRange(New Object() {"(Seleccione)", "EMT INFORMÁTICA", "EMTADMINISTRACIÓN", "EMP ADMINISTRACIÓN", "TECNICATURA EN REDES"})
        Me.cmbcarr.Location = New System.Drawing.Point(23, 35)
        Me.cmbcarr.Name = "cmbcarr"
        Me.cmbcarr.Size = New System.Drawing.Size(237, 21)
        Me.cmbcarr.TabIndex = 151
        '
        'pbxgrupsindoc
        '
        Me.pbxgrupsindoc.Image = CType(resources.GetObject("pbxgrupsindoc.Image"), System.Drawing.Image)
        Me.pbxgrupsindoc.Location = New System.Drawing.Point(35, 262)
        Me.pbxgrupsindoc.Name = "pbxgrupsindoc"
        Me.pbxgrupsindoc.Size = New System.Drawing.Size(441, 327)
        Me.pbxgrupsindoc.TabIndex = 179
        Me.pbxgrupsindoc.TabStop = False
        '
        'btngenrep
        '
        Me.btngenrep.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btngenrep.Location = New System.Drawing.Point(478, 262)
        Me.btngenrep.Name = "btngenrep"
        Me.btngenrep.Size = New System.Drawing.Size(123, 27)
        Me.btngenrep.TabIndex = 180
        Me.btngenrep.Text = "Ver reporte"
        Me.btngenrep.UseVisualStyleBackColor = True
        '
        'lbltipou
        '
        Me.lbltipou.AutoSize = True
        Me.lbltipou.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltipou.Location = New System.Drawing.Point(575, 7)
        Me.lbltipou.Name = "lbltipou"
        Me.lbltipou.Size = New System.Drawing.Size(0, 16)
        Me.lbltipou.TabIndex = 169
        Me.lbltipou.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(554, 385)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(167, 23)
        Me.Button1.TabIndex = 181
        Me.Button1.Text = "MENÚ REPORTES"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'sinDoc
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(746, 426)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.btngenrep)
        Me.Controls.Add(Me.pbxgrupsindoc)
        Me.Controls.Add(Me.gbxsel)
        Me.Controls.Add(Me.btnatras)
        Me.Controls.Add(Me.btnprint)
        Me.Controls.Add(Me.lblrol)
        Me.Controls.Add(Me.btnclose)
        Me.Controls.Add(Me.lbltipou)
        Me.Controls.Add(Me.lbltitulo)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "sinDoc"
        Me.Text = "S.I.B.A"
        Me.gbxsel.ResumeLayout(False)
        Me.gbxsel.PerformLayout()
        CType(Me.pbxgrupsindoc, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblrol As System.Windows.Forms.Label
    Friend WithEvents btnclose As System.Windows.Forms.Button
    Friend WithEvents btnprint As System.Windows.Forms.Button
    Friend WithEvents btnatras As System.Windows.Forms.Button
    Friend WithEvents lbltitulo As System.Windows.Forms.Label
    Friend WithEvents gbxsel As System.Windows.Forms.GroupBox
    Friend WithEvents btning As System.Windows.Forms.Button
    Friend WithEvents cmbturno As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents cmbcarr As System.Windows.Forms.ComboBox
    Friend WithEvents pbxgrupsindoc As System.Windows.Forms.PictureBox
    Friend WithEvents btngenrep As System.Windows.Forms.Button
    Friend WithEvents lbltipou As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
End Class
