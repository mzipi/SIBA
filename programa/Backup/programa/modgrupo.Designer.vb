<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class modgrupo
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
        Me.gbxgrup = New System.Windows.Forms.GroupBox
        Me.lblcodcarr = New System.Windows.Forms.Label
        Me.txtnomcarr = New System.Windows.Forms.TextBox
        Me.txtcurso = New System.Windows.Forms.TextBox
        Me.txtletra = New System.Windows.Forms.TextBox
        Me.txtaño = New System.Windows.Forms.TextBox
        Me.txtcodgrup = New System.Windows.Forms.TextBox
        Me.lblcurso = New System.Windows.Forms.Label
        Me.lblletra = New System.Windows.Forms.Label
        Me.lblaño = New System.Windows.Forms.Label
        Me.lblcodgrup = New System.Windows.Forms.Label
        Me.lblrol = New System.Windows.Forms.Label
        Me.btnclose = New System.Windows.Forms.Button
        Me.lbltipou = New System.Windows.Forms.Label
        Me.gbxgrup.SuspendLayout()
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
        Me.btnatras.Text = "Atrás"
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
        Me.lbltitulo.Size = New System.Drawing.Size(208, 26)
        Me.lbltitulo.TabIndex = 52
        Me.lbltitulo.Text = "MODIFICAR GRUPO "
        '
        'gbxgrup
        '
        Me.gbxgrup.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbxgrup.Controls.Add(Me.lblcodcarr)
        Me.gbxgrup.Controls.Add(Me.txtnomcarr)
        Me.gbxgrup.Controls.Add(Me.txtcurso)
        Me.gbxgrup.Controls.Add(Me.txtletra)
        Me.gbxgrup.Controls.Add(Me.txtaño)
        Me.gbxgrup.Controls.Add(Me.txtcodgrup)
        Me.gbxgrup.Controls.Add(Me.lblcurso)
        Me.gbxgrup.Controls.Add(Me.lblletra)
        Me.gbxgrup.Controls.Add(Me.lblaño)
        Me.gbxgrup.Controls.Add(Me.lblcodgrup)
        Me.gbxgrup.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbxgrup.Location = New System.Drawing.Point(15, 75)
        Me.gbxgrup.Name = "gbxgrup"
        Me.gbxgrup.Size = New System.Drawing.Size(271, 223)
        Me.gbxgrup.TabIndex = 53
        Me.gbxgrup.TabStop = False
        Me.gbxgrup.Text = "Complete el formulario"
        '
        'lblcodcarr
        '
        Me.lblcodcarr.AutoSize = True
        Me.lblcodcarr.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblcodcarr.Location = New System.Drawing.Point(6, 32)
        Me.lblcodcarr.Name = "lblcodcarr"
        Me.lblcodcarr.Size = New System.Drawing.Size(106, 16)
        Me.lblcodcarr.TabIndex = 21
        Me.lblcodcarr.Text = "Nombre carrera:"
        '
        'txtnomcarr
        '
        Me.txtnomcarr.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtnomcarr.Location = New System.Drawing.Point(6, 51)
        Me.txtnomcarr.MaxLength = 25
        Me.txtnomcarr.Name = "txtnomcarr"
        Me.txtnomcarr.Size = New System.Drawing.Size(218, 22)
        Me.txtnomcarr.TabIndex = 20
        Me.txtnomcarr.Text = "EMT Informática"
        '
        'txtcurso
        '
        Me.txtcurso.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtcurso.Location = New System.Drawing.Point(9, 175)
        Me.txtcurso.MaxLength = 2
        Me.txtcurso.Name = "txtcurso"
        Me.txtcurso.Size = New System.Drawing.Size(118, 22)
        Me.txtcurso.TabIndex = 11
        Me.txtcurso.Text = "I"
        '
        'txtletra
        '
        Me.txtletra.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtletra.Location = New System.Drawing.Point(133, 175)
        Me.txtletra.MaxLength = 2
        Me.txtletra.Name = "txtletra"
        Me.txtletra.Size = New System.Drawing.Size(94, 22)
        Me.txtletra.TabIndex = 10
        Me.txtletra.Text = "K"
        '
        'txtaño
        '
        Me.txtaño.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtaño.Location = New System.Drawing.Point(9, 135)
        Me.txtaño.MaxLength = 2
        Me.txtaño.Name = "txtaño"
        Me.txtaño.Size = New System.Drawing.Size(218, 22)
        Me.txtaño.TabIndex = 7
        Me.txtaño.Text = "3"
        '
        'txtcodgrup
        '
        Me.txtcodgrup.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtcodgrup.Location = New System.Drawing.Point(9, 95)
        Me.txtcodgrup.MaxLength = 6
        Me.txtcodgrup.Name = "txtcodgrup"
        Me.txtcodgrup.Size = New System.Drawing.Size(218, 22)
        Me.txtcodgrup.TabIndex = 6
        Me.txtcodgrup.Text = "101"
        '
        'lblcurso
        '
        Me.lblcurso.AutoSize = True
        Me.lblcurso.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblcurso.Location = New System.Drawing.Point(6, 157)
        Me.lblcurso.Name = "lblcurso"
        Me.lblcurso.Size = New System.Drawing.Size(46, 16)
        Me.lblcurso.TabIndex = 3
        Me.lblcurso.Text = "Curso:"
        '
        'lblletra
        '
        Me.lblletra.AutoSize = True
        Me.lblletra.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblletra.Location = New System.Drawing.Point(130, 157)
        Me.lblletra.Name = "lblletra"
        Me.lblletra.Size = New System.Drawing.Size(41, 16)
        Me.lblletra.TabIndex = 2
        Me.lblletra.Text = "Letra:"
        '
        'lblaño
        '
        Me.lblaño.AutoSize = True
        Me.lblaño.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblaño.Location = New System.Drawing.Point(6, 117)
        Me.lblaño.Name = "lblaño"
        Me.lblaño.Size = New System.Drawing.Size(35, 16)
        Me.lblaño.TabIndex = 1
        Me.lblaño.Text = "Año:"
        '
        'lblcodgrup
        '
        Me.lblcodgrup.AutoSize = True
        Me.lblcodgrup.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblcodgrup.Location = New System.Drawing.Point(6, 76)
        Me.lblcodgrup.Name = "lblcodgrup"
        Me.lblcodgrup.Size = New System.Drawing.Size(93, 16)
        Me.lblcodgrup.TabIndex = 0
        Me.lblcodgrup.Text = "Código grupo:"
        '
        'lblrol
        '
        Me.lblrol.AutoSize = True
        Me.lblrol.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblrol.Location = New System.Drawing.Point(338, 9)
        Me.lblrol.Name = "lblrol"
        Me.lblrol.Size = New System.Drawing.Size(36, 16)
        Me.lblrol.TabIndex = 68
        Me.lblrol.Text = "Rol:"
        '
        'btnclose
        '
        Me.btnclose.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnclose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnclose.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnclose.Location = New System.Drawing.Point(405, 28)
        Me.btnclose.Name = "btnclose"
        Me.btnclose.Size = New System.Drawing.Size(102, 24)
        Me.btnclose.TabIndex = 67
        Me.btnclose.Text = "Cerrar sesión"
        Me.btnclose.UseVisualStyleBackColor = True
        '
        'lbltipou
        '
        Me.lbltipou.AutoSize = True
        Me.lbltipou.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltipou.Location = New System.Drawing.Point(370, 9)
        Me.lbltipou.Name = "lbltipou"
        Me.lbltipou.Size = New System.Drawing.Size(137, 16)
        Me.lbltipou.TabIndex = 66
        Me.lbltipou.Text = "Secretario Escolar"
        '
        'modgrupo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(526, 333)
        Me.Controls.Add(Me.lblrol)
        Me.Controls.Add(Me.btnclose)
        Me.Controls.Add(Me.lbltipou)
        Me.Controls.Add(Me.gbxgrup)
        Me.Controls.Add(Me.lbltitulo)
        Me.Controls.Add(Me.btnmod)
        Me.Controls.Add(Me.btnatras)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MinimizeBox = False
        Me.Name = "modgrupo"
        Me.Text = "S.I.B.A"
        Me.gbxgrup.ResumeLayout(False)
        Me.gbxgrup.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnmod As System.Windows.Forms.Button
    Friend WithEvents btnatras As System.Windows.Forms.Button
    Friend WithEvents lbltitulo As System.Windows.Forms.Label
    Friend WithEvents gbxgrup As System.Windows.Forms.GroupBox
    Friend WithEvents lblcodcarr As System.Windows.Forms.Label
    Friend WithEvents txtnomcarr As System.Windows.Forms.TextBox
    Friend WithEvents txtcurso As System.Windows.Forms.TextBox
    Friend WithEvents txtletra As System.Windows.Forms.TextBox
    Friend WithEvents txtaño As System.Windows.Forms.TextBox
    Friend WithEvents txtcodgrup As System.Windows.Forms.TextBox
    Friend WithEvents lblcurso As System.Windows.Forms.Label
    Friend WithEvents lblletra As System.Windows.Forms.Label
    Friend WithEvents lblaño As System.Windows.Forms.Label
    Friend WithEvents lblcodgrup As System.Windows.Forms.Label
    Friend WithEvents lblrol As System.Windows.Forms.Label
    Friend WithEvents btnclose As System.Windows.Forms.Button
    Friend WithEvents lbltipou As System.Windows.Forms.Label
End Class
