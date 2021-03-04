<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class menupei
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
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.lbltitulo = New System.Windows.Forms.Label
        Me.btndisp = New System.Windows.Forms.Button
        Me.btnrrhh = New System.Windows.Forms.Button
        Me.btncarr = New System.Windows.Forms.Button
        Me.btnrepor = New System.Windows.Forms.Button
        Me.btntyh = New System.Windows.Forms.Button
        Me.lblsiba = New System.Windows.Forms.Label
        Me.btnclose = New System.Windows.Forms.Button
        Me.lblnombreu = New System.Windows.Forms.Label
        Me.lblrol = New System.Windows.Forms.Label
        Me.lblwelcome = New System.Windows.Forms.Label
        Me.lbltipou = New System.Windows.Forms.Label
        Me.lblhora = New System.Windows.Forms.Label
        Me.btnusuarios = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'Timer1
        '
        Me.Timer1.Interval = 1000
        '
        'lbltitulo
        '
        Me.lbltitulo.AutoSize = True
        Me.lbltitulo.Font = New System.Drawing.Font("Bookman Old Style", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltitulo.ForeColor = System.Drawing.Color.Blue
        Me.lbltitulo.Location = New System.Drawing.Point(12, 18)
        Me.lbltitulo.Name = "lbltitulo"
        Me.lbltitulo.Size = New System.Drawing.Size(235, 28)
        Me.lbltitulo.TabIndex = 6
        Me.lbltitulo.Text = "MENU PRINCIPAL"
        '
        'btndisp
        '
        Me.btndisp.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btndisp.Location = New System.Drawing.Point(12, 64)
        Me.btndisp.Name = "btndisp"
        Me.btndisp.Size = New System.Drawing.Size(226, 23)
        Me.btndisp.TabIndex = 7
        Me.btndisp.Text = "Disponibilidad locativa"
        Me.btndisp.UseVisualStyleBackColor = True
        '
        'btnrrhh
        '
        Me.btnrrhh.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnrrhh.Location = New System.Drawing.Point(12, 104)
        Me.btnrrhh.Name = "btnrrhh"
        Me.btnrrhh.Size = New System.Drawing.Size(226, 23)
        Me.btnrrhh.TabIndex = 8
        Me.btnrrhh.Text = "Gestión de RR.HH"
        Me.btnrrhh.UseVisualStyleBackColor = True
        '
        'btncarr
        '
        Me.btncarr.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btncarr.Location = New System.Drawing.Point(12, 144)
        Me.btncarr.Name = "btncarr"
        Me.btncarr.Size = New System.Drawing.Size(226, 23)
        Me.btncarr.TabIndex = 9
        Me.btncarr.Text = "Gestión de carreras"
        Me.btncarr.UseVisualStyleBackColor = True
        '
        'btnrepor
        '
        Me.btnrepor.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnrepor.Location = New System.Drawing.Point(12, 224)
        Me.btnrepor.Name = "btnrepor"
        Me.btnrepor.Size = New System.Drawing.Size(226, 23)
        Me.btnrepor.TabIndex = 10
        Me.btnrepor.Text = "Sección Reportes"
        Me.btnrepor.UseVisualStyleBackColor = True
        '
        'btntyh
        '
        Me.btntyh.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btntyh.Location = New System.Drawing.Point(12, 184)
        Me.btntyh.Name = "btntyh"
        Me.btntyh.Size = New System.Drawing.Size(225, 23)
        Me.btntyh.TabIndex = 42
        Me.btntyh.Text = "Gestión de Turnos y Horarios"
        Me.btntyh.UseVisualStyleBackColor = True
        '
        'lblsiba
        '
        Me.lblsiba.AutoSize = True
        Me.lblsiba.Font = New System.Drawing.Font("Pristina", 72.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblsiba.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblsiba.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblsiba.Location = New System.Drawing.Point(289, 231)
        Me.lblsiba.Name = "lblsiba"
        Me.lblsiba.Size = New System.Drawing.Size(352, 126)
        Me.lblsiba.TabIndex = 45
        Me.lblsiba.Text = "S.I.B.A."
        '
        'btnclose
        '
        Me.btnclose.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnclose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnclose.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnclose.Location = New System.Drawing.Point(515, 65)
        Me.btnclose.Name = "btnclose"
        Me.btnclose.Size = New System.Drawing.Size(102, 24)
        Me.btnclose.TabIndex = 51
        Me.btnclose.Text = "Cerrar sesión"
        Me.btnclose.UseVisualStyleBackColor = True
        '
        'lblnombreu
        '
        Me.lblnombreu.AutoSize = True
        Me.lblnombreu.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblnombreu.Location = New System.Drawing.Point(503, 30)
        Me.lblnombreu.Name = "lblnombreu"
        Me.lblnombreu.Size = New System.Drawing.Size(0, 16)
        Me.lblnombreu.TabIndex = 49
        '
        'lblrol
        '
        Me.lblrol.AutoSize = True
        Me.lblrol.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblrol.Location = New System.Drawing.Point(379, 46)
        Me.lblrol.Name = "lblrol"
        Me.lblrol.Size = New System.Drawing.Size(36, 16)
        Me.lblrol.TabIndex = 48
        Me.lblrol.Text = "Rol:"
        '
        'lblwelcome
        '
        Me.lblwelcome.AutoSize = True
        Me.lblwelcome.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblwelcome.Location = New System.Drawing.Point(379, 18)
        Me.lblwelcome.Name = "lblwelcome"
        Me.lblwelcome.Size = New System.Drawing.Size(108, 16)
        Me.lblwelcome.TabIndex = 47
        Me.lblwelcome.Text = "Bienvenida/o: "
        '
        'lbltipou
        '
        Me.lbltipou.AutoSize = True
        Me.lbltipou.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltipou.Location = New System.Drawing.Point(421, 46)
        Me.lbltipou.Name = "lbltipou"
        Me.lbltipou.Size = New System.Drawing.Size(164, 16)
        Me.lbltipou.TabIndex = 50
        Me.lbltipou.Text = "Encargado informático"
        '
        'lblhora
        '
        Me.lblhora.AutoSize = True
        Me.lblhora.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblhora.Location = New System.Drawing.Point(455, 9)
        Me.lblhora.Name = "lblhora"
        Me.lblhora.Size = New System.Drawing.Size(0, 16)
        Me.lblhora.TabIndex = 46
        '
        'btnusuarios
        '
        Me.btnusuarios.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnusuarios.Location = New System.Drawing.Point(12, 264)
        Me.btnusuarios.Name = "btnusuarios"
        Me.btnusuarios.Size = New System.Drawing.Size(226, 23)
        Me.btnusuarios.TabIndex = 52
        Me.btnusuarios.Text = "Gestión Usuarios"
        Me.btnusuarios.UseVisualStyleBackColor = True
        '
        'menupei
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(644, 366)
        Me.Controls.Add(Me.btnusuarios)
        Me.Controls.Add(Me.btnclose)
        Me.Controls.Add(Me.lblnombreu)
        Me.Controls.Add(Me.lblrol)
        Me.Controls.Add(Me.lblwelcome)
        Me.Controls.Add(Me.lbltipou)
        Me.Controls.Add(Me.lblhora)
        Me.Controls.Add(Me.lblsiba)
        Me.Controls.Add(Me.btntyh)
        Me.Controls.Add(Me.btnrrhh)
        Me.Controls.Add(Me.btnrepor)
        Me.Controls.Add(Me.btncarr)
        Me.Controls.Add(Me.btndisp)
        Me.Controls.Add(Me.lbltitulo)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "menupei"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "S.I.B.A."
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents lbltitulo As System.Windows.Forms.Label
    Friend WithEvents btndisp As System.Windows.Forms.Button
    Friend WithEvents btnrrhh As System.Windows.Forms.Button
    Friend WithEvents btncarr As System.Windows.Forms.Button
    Friend WithEvents btnrepor As System.Windows.Forms.Button
    Friend WithEvents btntyh As System.Windows.Forms.Button
    Friend WithEvents lblsiba As System.Windows.Forms.Label
    Friend WithEvents btnclose As System.Windows.Forms.Button
    Friend WithEvents lblnombreu As System.Windows.Forms.Label
    Friend WithEvents lblrol As System.Windows.Forms.Label
    Friend WithEvents lblwelcome As System.Windows.Forms.Label
    Friend WithEvents lbltipou As System.Windows.Forms.Label
    Friend WithEvents lblhora As System.Windows.Forms.Label
    Friend WithEvents btnusuarios As System.Windows.Forms.Button
End Class
