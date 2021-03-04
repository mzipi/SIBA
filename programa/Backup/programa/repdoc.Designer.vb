<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class repDoc
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(repDoc))
        Me.lblcodigo = New System.Windows.Forms.Label
        Me.lblnombre = New System.Windows.Forms.Label
        Me.lblturno = New System.Windows.Forms.Label
        Me.lblcoddoc = New System.Windows.Forms.Label
        Me.lblnomcompleto = New System.Windows.Forms.Label
        Me.lblidturno = New System.Windows.Forms.Label
        Me.pbxhordoc = New System.Windows.Forms.PictureBox
        Me.btnatras = New System.Windows.Forms.Button
        Me.btnprint = New System.Windows.Forms.Button
        Me.lbltitulo = New System.Windows.Forms.Label
        Me.lblrol = New System.Windows.Forms.Label
        Me.btnclose = New System.Windows.Forms.Button
        Me.lbltipou = New System.Windows.Forms.Label
        CType(Me.pbxhordoc, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblcodigo
        '
        Me.lblcodigo.AutoSize = True
        Me.lblcodigo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblcodigo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblcodigo.Location = New System.Drawing.Point(9, 58)
        Me.lblcodigo.Name = "lblcodigo"
        Me.lblcodigo.Size = New System.Drawing.Size(150, 18)
        Me.lblcodigo.TabIndex = 1
        Me.lblcodigo.Text = "Cédula de Identidad"
        '
        'lblnombre
        '
        Me.lblnombre.AutoSize = True
        Me.lblnombre.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblnombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblnombre.Location = New System.Drawing.Point(9, 88)
        Me.lblnombre.Name = "lblnombre"
        Me.lblnombre.Size = New System.Drawing.Size(139, 18)
        Me.lblnombre.TabIndex = 2
        Me.lblnombre.Text = "Apellido, Nombre: "
        '
        'lblturno
        '
        Me.lblturno.AutoSize = True
        Me.lblturno.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblturno.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblturno.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblturno.Location = New System.Drawing.Point(9, 118)
        Me.lblturno.Name = "lblturno"
        Me.lblturno.Size = New System.Drawing.Size(54, 18)
        Me.lblturno.TabIndex = 3
        Me.lblturno.Text = "Turno:"
        '
        'lblcoddoc
        '
        Me.lblcoddoc.AutoSize = True
        Me.lblcoddoc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblcoddoc.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblcoddoc.Location = New System.Drawing.Point(166, 58)
        Me.lblcoddoc.Name = "lblcoddoc"
        Me.lblcoddoc.Size = New System.Drawing.Size(2, 18)
        Me.lblcoddoc.TabIndex = 4
        '
        'lblnomcompleto
        '
        Me.lblnomcompleto.AutoSize = True
        Me.lblnomcompleto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblnomcompleto.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblnomcompleto.Location = New System.Drawing.Point(166, 88)
        Me.lblnomcompleto.Name = "lblnomcompleto"
        Me.lblnomcompleto.Size = New System.Drawing.Size(2, 18)
        Me.lblnomcompleto.TabIndex = 5
        '
        'lblidturno
        '
        Me.lblidturno.AutoSize = True
        Me.lblidturno.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblidturno.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblidturno.Location = New System.Drawing.Point(166, 118)
        Me.lblidturno.Name = "lblidturno"
        Me.lblidturno.Size = New System.Drawing.Size(2, 18)
        Me.lblidturno.TabIndex = 6
        '
        'pbxhordoc
        '
        Me.pbxhordoc.Image = CType(resources.GetObject("pbxhordoc.Image"), System.Drawing.Image)
        Me.pbxhordoc.Location = New System.Drawing.Point(12, 168)
        Me.pbxhordoc.Name = "pbxhordoc"
        Me.pbxhordoc.Size = New System.Drawing.Size(814, 140)
        Me.pbxhordoc.TabIndex = 39
        Me.pbxhordoc.TabStop = False
        '
        'btnatras
        '
        Me.btnatras.BackColor = System.Drawing.Color.Transparent
        Me.btnatras.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnatras.Location = New System.Drawing.Point(612, 325)
        Me.btnatras.Name = "btnatras"
        Me.btnatras.Size = New System.Drawing.Size(101, 32)
        Me.btnatras.TabIndex = 40
        Me.btnatras.Text = "Atrás"
        Me.btnatras.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage
        Me.btnatras.UseVisualStyleBackColor = False
        '
        'btnprint
        '
        Me.btnprint.BackColor = System.Drawing.Color.Transparent
        Me.btnprint.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnprint.Location = New System.Drawing.Point(728, 325)
        Me.btnprint.Name = "btnprint"
        Me.btnprint.Size = New System.Drawing.Size(101, 32)
        Me.btnprint.TabIndex = 41
        Me.btnprint.Text = "Imprimir"
        Me.btnprint.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage
        Me.btnprint.UseVisualStyleBackColor = False
        '
        'lbltitulo
        '
        Me.lbltitulo.AutoSize = True
        Me.lbltitulo.BackColor = System.Drawing.Color.LemonChiffon
        Me.lbltitulo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbltitulo.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltitulo.Location = New System.Drawing.Point(12, 9)
        Me.lbltitulo.Name = "lbltitulo"
        Me.lbltitulo.Size = New System.Drawing.Size(337, 26)
        Me.lbltitulo.TabIndex = 49
        Me.lbltitulo.Text = "HORARIO SEMANAL POR TURNO"
        '
        'lblrol
        '
        Me.lblrol.AutoSize = True
        Me.lblrol.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblrol.Location = New System.Drawing.Point(668, 9)
        Me.lblrol.Name = "lblrol"
        Me.lblrol.Size = New System.Drawing.Size(36, 16)
        Me.lblrol.TabIndex = 64
        Me.lblrol.Text = "Rol:"
        '
        'btnclose
        '
        Me.btnclose.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnclose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnclose.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnclose.Location = New System.Drawing.Point(724, 28)
        Me.btnclose.Name = "btnclose"
        Me.btnclose.Size = New System.Drawing.Size(102, 24)
        Me.btnclose.TabIndex = 63
        Me.btnclose.Text = "Cerrar sesión"
        Me.btnclose.UseVisualStyleBackColor = True
        '
        'lbltipou
        '
        Me.lbltipou.AutoSize = True
        Me.lbltipou.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltipou.Location = New System.Drawing.Point(710, 9)
        Me.lbltipou.Name = "lbltipou"
        Me.lbltipou.Size = New System.Drawing.Size(0, 16)
        Me.lbltipou.TabIndex = 62
        '
        'repDoc
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(852, 401)
        Me.Controls.Add(Me.lblrol)
        Me.Controls.Add(Me.btnclose)
        Me.Controls.Add(Me.lbltipou)
        Me.Controls.Add(Me.lbltitulo)
        Me.Controls.Add(Me.btnprint)
        Me.Controls.Add(Me.btnatras)
        Me.Controls.Add(Me.pbxhordoc)
        Me.Controls.Add(Me.lblidturno)
        Me.Controls.Add(Me.lblnomcompleto)
        Me.Controls.Add(Me.lblcoddoc)
        Me.Controls.Add(Me.lblturno)
        Me.Controls.Add(Me.lblnombre)
        Me.Controls.Add(Me.lblcodigo)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "repDoc"
        Me.Text = "S.I.B.A"
        CType(Me.pbxhordoc, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblcodigo As System.Windows.Forms.Label
    Friend WithEvents lblnombre As System.Windows.Forms.Label
    Friend WithEvents lblturno As System.Windows.Forms.Label
    Friend WithEvents lblcoddoc As System.Windows.Forms.Label
    Friend WithEvents lblnomcompleto As System.Windows.Forms.Label
    Friend WithEvents lblidturno As System.Windows.Forms.Label
    Friend WithEvents pbxhordoc As System.Windows.Forms.PictureBox
    Friend WithEvents btnatras As System.Windows.Forms.Button
    Friend WithEvents btnprint As System.Windows.Forms.Button
    Friend WithEvents lbltitulo As System.Windows.Forms.Label
    Friend WithEvents lblrol As System.Windows.Forms.Label
    Friend WithEvents btnclose As System.Windows.Forms.Button
    Friend WithEvents lbltipou As System.Windows.Forms.Label
End Class
