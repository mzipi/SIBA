<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class menupdir
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(menupdir))
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.lbltitulo = New System.Windows.Forms.Label
        Me.lblsiba = New System.Windows.Forms.Label
        Me.btnclose = New System.Windows.Forms.Button
        Me.lblnombreu = New System.Windows.Forms.Label
        Me.lblrol = New System.Windows.Forms.Label
        Me.lblwelcome = New System.Windows.Forms.Label
        Me.lbltipou = New System.Windows.Forms.Label
        Me.lblhora = New System.Windows.Forms.Label
        Me.btnusuarios = New System.Windows.Forms.Button
        Me.pbxtipou = New System.Windows.Forms.PictureBox
        Me.pbxlogo = New System.Windows.Forms.PictureBox
        Me.lbldesarrollo = New System.Windows.Forms.Label
        Me.Button1 = New System.Windows.Forms.Button
        CType(Me.pbxtipou, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbxlogo, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.btnclose.Location = New System.Drawing.Point(549, 59)
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
        Me.lblnombreu.Location = New System.Drawing.Point(546, 18)
        Me.lblnombreu.Name = "lblnombreu"
        Me.lblnombreu.Size = New System.Drawing.Size(0, 16)
        Me.lblnombreu.TabIndex = 49
        '
        'lblrol
        '
        Me.lblrol.AutoSize = True
        Me.lblrol.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblrol.Location = New System.Drawing.Point(490, 40)
        Me.lblrol.Name = "lblrol"
        Me.lblrol.Size = New System.Drawing.Size(36, 16)
        Me.lblrol.TabIndex = 48
        Me.lblrol.Text = "Rol:"
        '
        'lblwelcome
        '
        Me.lblwelcome.AutoSize = True
        Me.lblwelcome.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblwelcome.Location = New System.Drawing.Point(418, 18)
        Me.lblwelcome.Name = "lblwelcome"
        Me.lblwelcome.Size = New System.Drawing.Size(108, 16)
        Me.lblwelcome.TabIndex = 47
        Me.lblwelcome.Text = "Bienvenida/o: "
        '
        'lbltipou
        '
        Me.lbltipou.AutoSize = True
        Me.lbltipou.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltipou.Location = New System.Drawing.Point(545, 40)
        Me.lbltipou.Name = "lbltipou"
        Me.lbltipou.Size = New System.Drawing.Size(63, 16)
        Me.lbltipou.TabIndex = 50
        Me.lbltipou.Text = "Director"
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
        Me.btnusuarios.Location = New System.Drawing.Point(21, 59)
        Me.btnusuarios.Name = "btnusuarios"
        Me.btnusuarios.Size = New System.Drawing.Size(224, 36)
        Me.btnusuarios.TabIndex = 52
        Me.btnusuarios.Text = "Planillado de horarios"
        Me.btnusuarios.UseVisualStyleBackColor = True
        '
        'pbxtipou
        '
        Me.pbxtipou.Image = CType(resources.GetObject("pbxtipou.Image"), System.Drawing.Image)
        Me.pbxtipou.Location = New System.Drawing.Point(21, 152)
        Me.pbxtipou.Name = "pbxtipou"
        Me.pbxtipou.Size = New System.Drawing.Size(224, 148)
        Me.pbxtipou.TabIndex = 53
        Me.pbxtipou.TabStop = False
        '
        'pbxlogo
        '
        Me.pbxlogo.Image = CType(resources.GetObject("pbxlogo.Image"), System.Drawing.Image)
        Me.pbxlogo.Location = New System.Drawing.Point(52, 319)
        Me.pbxlogo.Name = "pbxlogo"
        Me.pbxlogo.Size = New System.Drawing.Size(139, 52)
        Me.pbxlogo.TabIndex = 54
        Me.pbxlogo.TabStop = False
        '
        'lbldesarrollo
        '
        Me.lbldesarrollo.AutoSize = True
        Me.lbldesarrollo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbldesarrollo.Location = New System.Drawing.Point(18, 303)
        Me.lbldesarrollo.Name = "lbldesarrollo"
        Me.lbldesarrollo.Size = New System.Drawing.Size(185, 13)
        Me.lbldesarrollo.TabIndex = 55
        Me.lbldesarrollo.Text = "Desarrollo y mantenimiento por:"
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(21, 101)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(224, 36)
        Me.Button1.TabIndex = 56
        Me.Button1.Text = "Gestión de turnos y horarios"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'menupdir
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(672, 366)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.lbldesarrollo)
        Me.Controls.Add(Me.pbxlogo)
        Me.Controls.Add(Me.pbxtipou)
        Me.Controls.Add(Me.btnusuarios)
        Me.Controls.Add(Me.btnclose)
        Me.Controls.Add(Me.lblnombreu)
        Me.Controls.Add(Me.lblrol)
        Me.Controls.Add(Me.lblwelcome)
        Me.Controls.Add(Me.lbltipou)
        Me.Controls.Add(Me.lblhora)
        Me.Controls.Add(Me.lblsiba)
        Me.Controls.Add(Me.lbltitulo)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "menupdir"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "S.I.B.A"
        CType(Me.pbxtipou, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbxlogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents lbltitulo As System.Windows.Forms.Label
    Friend WithEvents lblsiba As System.Windows.Forms.Label
    Friend WithEvents btnclose As System.Windows.Forms.Button
    Friend WithEvents lblnombreu As System.Windows.Forms.Label
    Friend WithEvents lblrol As System.Windows.Forms.Label
    Friend WithEvents lblwelcome As System.Windows.Forms.Label
    Friend WithEvents lbltipou As System.Windows.Forms.Label
    Friend WithEvents lblhora As System.Windows.Forms.Label
    Friend WithEvents btnusuarios As System.Windows.Forms.Button
    Friend WithEvents pbxtipou As System.Windows.Forms.PictureBox
    Friend WithEvents pbxlogo As System.Windows.Forms.PictureBox
    Friend WithEvents lbldesarrollo As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
End Class

