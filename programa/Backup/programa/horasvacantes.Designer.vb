<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class horasvacantes
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(horasvacantes))
        Me.lbltitulo = New System.Windows.Forms.Label
        Me.lblrol = New System.Windows.Forms.Label
        Me.btnclose = New System.Windows.Forms.Button
        Me.lbltipou = New System.Windows.Forms.Label
        Me.btngenrep = New System.Windows.Forms.Button
        Me.btnatras = New System.Windows.Forms.Button
        Me.pbxhorasvacantes = New System.Windows.Forms.PictureBox
        Me.btnprint = New System.Windows.Forms.Button
        Me.gbxsel = New System.Windows.Forms.GroupBox
        Me.cmbturno = New System.Windows.Forms.ComboBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.btning = New System.Windows.Forms.Button
        Me.cmbdia = New System.Windows.Forms.ComboBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.cmbcar = New System.Windows.Forms.ComboBox
        CType(Me.pbxhorasvacantes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbxsel.SuspendLayout()
        Me.SuspendLayout()
        '
        'lbltitulo
        '
        Me.lbltitulo.AutoSize = True
        Me.lbltitulo.BackColor = System.Drawing.Color.LemonChiffon
        Me.lbltitulo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbltitulo.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltitulo.Location = New System.Drawing.Point(12, 9)
        Me.lbltitulo.Name = "lbltitulo"
        Me.lbltitulo.Size = New System.Drawing.Size(317, 26)
        Me.lbltitulo.TabIndex = 51
        Me.lbltitulo.Text = "CONSULTA HORAS VACANTES"
        '
        'lblrol
        '
        Me.lblrol.AutoSize = True
        Me.lblrol.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblrol.Location = New System.Drawing.Point(539, 9)
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
        Me.btnclose.Location = New System.Drawing.Point(616, 28)
        Me.btnclose.Name = "btnclose"
        Me.btnclose.Size = New System.Drawing.Size(102, 24)
        Me.btnclose.TabIndex = 170
        Me.btnclose.Text = "Cerrar sesión"
        Me.btnclose.UseVisualStyleBackColor = True
        '
        'lbltipou
        '
        Me.lbltipou.AutoSize = True
        Me.lbltipou.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltipou.Location = New System.Drawing.Point(581, 9)
        Me.lbltipou.Name = "lbltipou"
        Me.lbltipou.Size = New System.Drawing.Size(137, 16)
        Me.lbltipou.TabIndex = 169
        Me.lbltipou.Text = "Secretario Escolar"
        '
        'btngenrep
        '
        Me.btngenrep.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btngenrep.Location = New System.Drawing.Point(548, 309)
        Me.btngenrep.Name = "btngenrep"
        Me.btngenrep.Size = New System.Drawing.Size(123, 27)
        Me.btngenrep.TabIndex = 175
        Me.btngenrep.Text = "Ver reporte"
        Me.btngenrep.UseVisualStyleBackColor = True
        '
        'btnatras
        '
        Me.btnatras.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnatras.Location = New System.Drawing.Point(548, 342)
        Me.btnatras.Name = "btnatras"
        Me.btnatras.Size = New System.Drawing.Size(123, 27)
        Me.btnatras.TabIndex = 177
        Me.btnatras.Text = "Atrás"
        Me.btnatras.UseVisualStyleBackColor = True
        '
        'pbxhorasvacantes
        '
        Me.pbxhorasvacantes.Image = CType(resources.GetObject("pbxhorasvacantes.Image"), System.Drawing.Image)
        Me.pbxhorasvacantes.Location = New System.Drawing.Point(123, 177)
        Me.pbxhorasvacantes.Name = "pbxhorasvacantes"
        Me.pbxhorasvacantes.Size = New System.Drawing.Size(464, 308)
        Me.pbxhorasvacantes.TabIndex = 178
        Me.pbxhorasvacantes.TabStop = False
        '
        'btnprint
        '
        Me.btnprint.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnprint.Location = New System.Drawing.Point(548, 276)
        Me.btnprint.Name = "btnprint"
        Me.btnprint.Size = New System.Drawing.Size(123, 27)
        Me.btnprint.TabIndex = 179
        Me.btnprint.Text = "Imprimir Tabla"
        Me.btnprint.UseVisualStyleBackColor = True
        '
        'gbxsel
        '
        Me.gbxsel.Controls.Add(Me.cmbturno)
        Me.gbxsel.Controls.Add(Me.Label7)
        Me.gbxsel.Controls.Add(Me.btning)
        Me.gbxsel.Controls.Add(Me.cmbdia)
        Me.gbxsel.Controls.Add(Me.Label2)
        Me.gbxsel.Controls.Add(Me.Label3)
        Me.gbxsel.Controls.Add(Me.cmbcar)
        Me.gbxsel.Location = New System.Drawing.Point(12, 65)
        Me.gbxsel.Name = "gbxsel"
        Me.gbxsel.Size = New System.Drawing.Size(287, 268)
        Me.gbxsel.TabIndex = 180
        Me.gbxsel.TabStop = False
        Me.gbxsel.Text = "Seleccionar"
        '
        'cmbturno
        '
        Me.cmbturno.FormattingEnabled = True
        Me.cmbturno.Items.AddRange(New Object() {"(Seleccione)", "Matutino", "Vespertino", "Nocturno"})
        Me.cmbturno.Location = New System.Drawing.Point(23, 108)
        Me.cmbturno.Name = "cmbturno"
        Me.cmbturno.Size = New System.Drawing.Size(221, 21)
        Me.cmbturno.TabIndex = 158
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(23, 79)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(221, 16)
        Me.Label7.TabIndex = 157
        Me.Label7.Text = "Seleccione el turno a consultar"
        '
        'btning
        '
        Me.btning.Location = New System.Drawing.Point(174, 224)
        Me.btning.Name = "btning"
        Me.btning.Size = New System.Drawing.Size(70, 26)
        Me.btning.TabIndex = 156
        Me.btning.Text = "Ingresar"
        Me.btning.UseVisualStyleBackColor = True
        '
        'cmbdia
        '
        Me.cmbdia.FormattingEnabled = True
        Me.cmbdia.Items.AddRange(New Object() {"(Seleccione)", "Lunes", "Martes", "Miércoles", "Jueves", "Viernes ", "Sábado"})
        Me.cmbdia.Location = New System.Drawing.Point(26, 174)
        Me.cmbdia.Name = "cmbdia"
        Me.cmbdia.Size = New System.Drawing.Size(218, 21)
        Me.cmbdia.TabIndex = 155
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(23, 142)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(209, 16)
        Me.Label2.TabIndex = 154
        Me.Label2.Text = "Seleccione el día a consultar"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(20, 16)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(237, 16)
        Me.Label3.TabIndex = 150
        Me.Label3.Text = "Seleccione la carrera a consultar"
        '
        'cmbcar
        '
        Me.cmbcar.FormattingEnabled = True
        Me.cmbcar.Items.AddRange(New Object() {"(Seleccione)", "EMT Administración", "EMP Administración", "EMT Informática", "Tecnicatura en Redes"})
        Me.cmbcar.Location = New System.Drawing.Point(23, 35)
        Me.cmbcar.Name = "cmbcar"
        Me.cmbcar.Size = New System.Drawing.Size(221, 21)
        Me.cmbcar.TabIndex = 151
        '
        'horasvacantes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(731, 499)
        Me.Controls.Add(Me.gbxsel)
        Me.Controls.Add(Me.btnprint)
        Me.Controls.Add(Me.pbxhorasvacantes)
        Me.Controls.Add(Me.btnatras)
        Me.Controls.Add(Me.btngenrep)
        Me.Controls.Add(Me.lblrol)
        Me.Controls.Add(Me.btnclose)
        Me.Controls.Add(Me.lbltipou)
        Me.Controls.Add(Me.lbltitulo)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "horasvacantes"
        Me.Text = "S.I.B.A"
        CType(Me.pbxhorasvacantes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbxsel.ResumeLayout(False)
        Me.gbxsel.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lbltitulo As System.Windows.Forms.Label
    Friend WithEvents lblrol As System.Windows.Forms.Label
    Friend WithEvents btnclose As System.Windows.Forms.Button
    Friend WithEvents lbltipou As System.Windows.Forms.Label
    Friend WithEvents btngenrep As System.Windows.Forms.Button
    Friend WithEvents btnatras As System.Windows.Forms.Button
    Friend WithEvents pbxhorasvacantes As System.Windows.Forms.PictureBox
    Friend WithEvents btnprint As System.Windows.Forms.Button
    Friend WithEvents gbxsel As System.Windows.Forms.GroupBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents btning As System.Windows.Forms.Button
    Friend WithEvents cmbdia As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents cmbcar As System.Windows.Forms.ComboBox
    Friend WithEvents cmbturno As System.Windows.Forms.ComboBox
End Class
