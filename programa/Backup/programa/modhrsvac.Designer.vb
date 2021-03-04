<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class modhrsvac
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
        Me.lblrol = New System.Windows.Forms.Label
        Me.btnclose = New System.Windows.Forms.Button
        Me.lbltipou = New System.Windows.Forms.Label
        Me.gbxhrsvac = New System.Windows.Forms.GroupBox
        Me.dtphasta = New System.Windows.Forms.DateTimePicker
        Me.dtpdesde = New System.Windows.Forms.DateTimePicker
        Me.cmbestfunc = New System.Windows.Forms.ComboBox
        Me.lblestfun = New System.Windows.Forms.Label
        Me.txtci = New System.Windows.Forms.TextBox
        Me.txtnombredoc = New System.Windows.Forms.TextBox
        Me.lblant = New System.Windows.Forms.Label
        Me.lblgrado = New System.Windows.Forms.Label
        Me.lblci = New System.Windows.Forms.Label
        Me.lblnombre = New System.Windows.Forms.Label
        Me.gbxhrsvac.SuspendLayout()
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
        Me.lbltitulo.Size = New System.Drawing.Size(319, 26)
        Me.lbltitulo.TabIndex = 52
        Me.lbltitulo.Text = "MODIFICAR HORAS VACANTES"
        '
        'lblrol
        '
        Me.lblrol.AutoSize = True
        Me.lblrol.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblrol.Location = New System.Drawing.Point(415, 15)
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
        Me.btnclose.Location = New System.Drawing.Point(461, 34)
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
        Me.lbltipou.Location = New System.Drawing.Point(457, 15)
        Me.lbltipou.Name = "lbltipou"
        Me.lbltipou.Size = New System.Drawing.Size(106, 16)
        Me.lbltipou.TabIndex = 66
        Me.lbltipou.Text = "Administrativo"
        '
        'gbxhrsvac
        '
        Me.gbxhrsvac.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbxhrsvac.Controls.Add(Me.dtphasta)
        Me.gbxhrsvac.Controls.Add(Me.dtpdesde)
        Me.gbxhrsvac.Controls.Add(Me.cmbestfunc)
        Me.gbxhrsvac.Controls.Add(Me.lblestfun)
        Me.gbxhrsvac.Controls.Add(Me.txtci)
        Me.gbxhrsvac.Controls.Add(Me.txtnombredoc)
        Me.gbxhrsvac.Controls.Add(Me.lblant)
        Me.gbxhrsvac.Controls.Add(Me.lblgrado)
        Me.gbxhrsvac.Controls.Add(Me.lblci)
        Me.gbxhrsvac.Controls.Add(Me.lblnombre)
        Me.gbxhrsvac.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbxhrsvac.Location = New System.Drawing.Point(15, 52)
        Me.gbxhrsvac.Name = "gbxhrsvac"
        Me.gbxhrsvac.Size = New System.Drawing.Size(279, 269)
        Me.gbxhrsvac.TabIndex = 69
        Me.gbxhrsvac.TabStop = False
        Me.gbxhrsvac.Text = "Horas Vacantes"
        '
        'dtphasta
        '
        Me.dtphasta.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtphasta.Location = New System.Drawing.Point(6, 184)
        Me.dtphasta.Name = "dtphasta"
        Me.dtphasta.Size = New System.Drawing.Size(248, 22)
        Me.dtphasta.TabIndex = 18
        '
        'dtpdesde
        '
        Me.dtpdesde.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpdesde.Location = New System.Drawing.Point(6, 142)
        Me.dtpdesde.Name = "dtpdesde"
        Me.dtpdesde.Size = New System.Drawing.Size(248, 22)
        Me.dtpdesde.TabIndex = 17
        '
        'cmbestfunc
        '
        Me.cmbestfunc.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbestfunc.FormattingEnabled = True
        Me.cmbestfunc.Items.AddRange(New Object() {"(Seleccione)", "Activo", "Licencia por Enfermedad", "Licencia  Maternal", "Art. 28", "Art.67", "Art.61 ", "Renuncia", "Despido"})
        Me.cmbestfunc.Location = New System.Drawing.Point(9, 226)
        Me.cmbestfunc.Name = "cmbestfunc"
        Me.cmbestfunc.Size = New System.Drawing.Size(245, 24)
        Me.cmbestfunc.TabIndex = 16
        '
        'lblestfun
        '
        Me.lblestfun.AutoSize = True
        Me.lblestfun.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblestfun.Location = New System.Drawing.Point(6, 208)
        Me.lblestfun.Name = "lblestfun"
        Me.lblestfun.Size = New System.Drawing.Size(115, 16)
        Me.lblestfun.TabIndex = 13
        Me.lblestfun.Text = "Estado Funcional:"
        '
        'txtci
        '
        Me.txtci.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtci.Location = New System.Drawing.Point(9, 100)
        Me.txtci.MaxLength = 10
        Me.txtci.Name = "txtci"
        Me.txtci.Size = New System.Drawing.Size(245, 22)
        Me.txtci.TabIndex = 7
        '
        'txtnombredoc
        '
        Me.txtnombredoc.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtnombredoc.Location = New System.Drawing.Point(9, 58)
        Me.txtnombredoc.MaxLength = 50
        Me.txtnombredoc.Name = "txtnombredoc"
        Me.txtnombredoc.Size = New System.Drawing.Size(245, 22)
        Me.txtnombredoc.TabIndex = 6
        '
        'lblant
        '
        Me.lblant.AutoSize = True
        Me.lblant.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblant.Location = New System.Drawing.Point(6, 124)
        Me.lblant.Name = "lblant"
        Me.lblant.Size = New System.Drawing.Size(52, 16)
        Me.lblant.TabIndex = 3
        Me.lblant.Text = "Desde:"
        '
        'lblgrado
        '
        Me.lblgrado.AutoSize = True
        Me.lblgrado.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblgrado.Location = New System.Drawing.Point(6, 166)
        Me.lblgrado.Name = "lblgrado"
        Me.lblgrado.Size = New System.Drawing.Size(47, 16)
        Me.lblgrado.TabIndex = 2
        Me.lblgrado.Text = "Hasta:"
        '
        'lblci
        '
        Me.lblci.AutoSize = True
        Me.lblci.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblci.Location = New System.Drawing.Point(6, 82)
        Me.lblci.Name = "lblci"
        Me.lblci.Size = New System.Drawing.Size(132, 16)
        Me.lblci.TabIndex = 1
        Me.lblci.Text = "Cedula de Identidad:"
        '
        'lblnombre
        '
        Me.lblnombre.AutoSize = True
        Me.lblnombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblnombre.Location = New System.Drawing.Point(6, 40)
        Me.lblnombre.Name = "lblnombre"
        Me.lblnombre.Size = New System.Drawing.Size(114, 16)
        Me.lblnombre.TabIndex = 0
        Me.lblnombre.Text = "Nombre Docente:"
        '
        'modhrsvac
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(575, 343)
        Me.Controls.Add(Me.gbxhrsvac)
        Me.Controls.Add(Me.lblrol)
        Me.Controls.Add(Me.btnclose)
        Me.Controls.Add(Me.lbltipou)
        Me.Controls.Add(Me.lbltitulo)
        Me.Controls.Add(Me.btnmod)
        Me.Controls.Add(Me.btnatras)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "modhrsvac"
        Me.Text = "S.I.B.A"
        Me.gbxhrsvac.ResumeLayout(False)
        Me.gbxhrsvac.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnmod As System.Windows.Forms.Button
    Friend WithEvents btnatras As System.Windows.Forms.Button
    Friend WithEvents lbltitulo As System.Windows.Forms.Label
    Friend WithEvents lblrol As System.Windows.Forms.Label
    Friend WithEvents btnclose As System.Windows.Forms.Button
    Friend WithEvents lbltipou As System.Windows.Forms.Label
    Friend WithEvents gbxhrsvac As System.Windows.Forms.GroupBox
    Friend WithEvents dtphasta As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpdesde As System.Windows.Forms.DateTimePicker
    Friend WithEvents cmbestfunc As System.Windows.Forms.ComboBox
    Friend WithEvents lblestfun As System.Windows.Forms.Label
    Friend WithEvents txtci As System.Windows.Forms.TextBox
    Friend WithEvents txtnombredoc As System.Windows.Forms.TextBox
    Friend WithEvents lblant As System.Windows.Forms.Label
    Friend WithEvents lblgrado As System.Windows.Forms.Label
    Friend WithEvents lblci As System.Windows.Forms.Label
    Friend WithEvents lblnombre As System.Windows.Forms.Label
End Class
