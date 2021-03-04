<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class abmusuario
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
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(abmusuario))
        Me.lbltitulo = New System.Windows.Forms.Label
        Me.btnalta = New System.Windows.Forms.Button
        Me.btnbaja = New System.Windows.Forms.Button
        Me.btnmod = New System.Windows.Forms.Button
        Me.lblrol = New System.Windows.Forms.Label
        Me.btnclose = New System.Windows.Forms.Button
        Me.lbltipou = New System.Windows.Forms.Label
        Me.btnatras = New System.Windows.Forms.Button
        Me.dgvusuarios = New System.Windows.Forms.DataGridView
        Me.txtnomusua = New System.Windows.Forms.TextBox
        Me.txtnombre = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.lbldesarrollo = New System.Windows.Forms.Label
        Me.pbxlogo = New System.Windows.Forms.PictureBox
        CType(Me.dgvusuarios, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbxlogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lbltitulo
        '
        Me.lbltitulo.AutoSize = True
        Me.lbltitulo.BackColor = System.Drawing.Color.LemonChiffon
        Me.lbltitulo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbltitulo.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltitulo.Location = New System.Drawing.Point(18, 9)
        Me.lbltitulo.Name = "lbltitulo"
        Me.lbltitulo.Size = New System.Drawing.Size(323, 26)
        Me.lbltitulo.TabIndex = 52
        Me.lbltitulo.Text = "ADMINISTRADOR DE USUARIOS"
        '
        'btnalta
        '
        Me.btnalta.BackColor = System.Drawing.Color.Transparent
        Me.btnalta.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnalta.Location = New System.Drawing.Point(18, 105)
        Me.btnalta.Name = "btnalta"
        Me.btnalta.Size = New System.Drawing.Size(101, 28)
        Me.btnalta.TabIndex = 67
        Me.btnalta.Text = "Alta"
        Me.btnalta.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage
        Me.btnalta.UseVisualStyleBackColor = False
        '
        'btnbaja
        '
        Me.btnbaja.BackColor = System.Drawing.Color.Transparent
        Me.btnbaja.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnbaja.Location = New System.Drawing.Point(18, 175)
        Me.btnbaja.Name = "btnbaja"
        Me.btnbaja.Size = New System.Drawing.Size(101, 28)
        Me.btnbaja.TabIndex = 66
        Me.btnbaja.Text = "Baja"
        Me.btnbaja.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage
        Me.btnbaja.UseVisualStyleBackColor = False
        '
        'btnmod
        '
        Me.btnmod.BackColor = System.Drawing.Color.Transparent
        Me.btnmod.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnmod.Location = New System.Drawing.Point(18, 140)
        Me.btnmod.Name = "btnmod"
        Me.btnmod.Size = New System.Drawing.Size(101, 28)
        Me.btnmod.TabIndex = 65
        Me.btnmod.Text = "Modificar"
        Me.btnmod.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage
        Me.btnmod.UseVisualStyleBackColor = False
        '
        'lblrol
        '
        Me.lblrol.AutoSize = True
        Me.lblrol.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblrol.Location = New System.Drawing.Point(393, 15)
        Me.lblrol.Name = "lblrol"
        Me.lblrol.Size = New System.Drawing.Size(36, 16)
        Me.lblrol.TabIndex = 70
        Me.lblrol.Text = "Rol:"
        '
        'btnclose
        '
        Me.btnclose.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnclose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnclose.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnclose.Location = New System.Drawing.Point(497, 40)
        Me.btnclose.Name = "btnclose"
        Me.btnclose.Size = New System.Drawing.Size(102, 24)
        Me.btnclose.TabIndex = 69
        Me.btnclose.Text = "Cerrar sesión"
        Me.btnclose.UseVisualStyleBackColor = True
        '
        'lbltipou
        '
        Me.lbltipou.AutoSize = True
        Me.lbltipou.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltipou.Location = New System.Drawing.Point(435, 15)
        Me.lbltipou.Name = "lbltipou"
        Me.lbltipou.Size = New System.Drawing.Size(164, 16)
        Me.lbltipou.TabIndex = 68
        Me.lbltipou.Text = "Encargado informático" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'btnatras
        '
        Me.btnatras.BackColor = System.Drawing.Color.Transparent
        Me.btnatras.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnatras.ForeColor = System.Drawing.Color.Red
        Me.btnatras.Location = New System.Drawing.Point(12, 318)
        Me.btnatras.Name = "btnatras"
        Me.btnatras.Size = New System.Drawing.Size(168, 24)
        Me.btnatras.TabIndex = 71
        Me.btnatras.Text = "Menú Principal"
        Me.btnatras.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage
        Me.btnatras.UseVisualStyleBackColor = False
        '
        'dgvusuarios
        '
        Me.dgvusuarios.AllowUserToAddRows = False
        Me.dgvusuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.IndianRed
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvusuarios.DefaultCellStyle = DataGridViewCellStyle3
        Me.dgvusuarios.GridColor = System.Drawing.SystemColors.ControlDarkDark
        Me.dgvusuarios.Location = New System.Drawing.Point(125, 105)
        Me.dgvusuarios.Name = "dgvusuarios"
        Me.dgvusuarios.ReadOnly = True
        Me.dgvusuarios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvusuarios.Size = New System.Drawing.Size(439, 169)
        Me.dgvusuarios.TabIndex = 72
        '
        'txtnomusua
        '
        Me.txtnomusua.Location = New System.Drawing.Point(125, 70)
        Me.txtnomusua.Name = "txtnomusua"
        Me.txtnomusua.Size = New System.Drawing.Size(100, 20)
        Me.txtnomusua.TabIndex = 74
        '
        'txtnombre
        '
        Me.txtnombre.Location = New System.Drawing.Point(279, 70)
        Me.txtnombre.Name = "txtnombre"
        Me.txtnombre.Size = New System.Drawing.Size(100, 20)
        Me.txtnombre.TabIndex = 75
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(276, 54)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(54, 13)
        Me.Label1.TabIndex = 76
        Me.Label1.Text = "Nombre:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(122, 54)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(54, 13)
        Me.Label2.TabIndex = 77
        Me.Label2.Text = "Usuario:"
        '
        'lbldesarrollo
        '
        Me.lbldesarrollo.AutoSize = True
        Me.lbldesarrollo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.lbldesarrollo.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lbldesarrollo.Location = New System.Drawing.Point(424, 284)
        Me.lbldesarrollo.Name = "lbldesarrollo"
        Me.lbldesarrollo.Size = New System.Drawing.Size(185, 13)
        Me.lbldesarrollo.TabIndex = 150
        Me.lbldesarrollo.Text = "Desarrollo y mantenimiento por:"
        '
        'pbxlogo
        '
        Me.pbxlogo.Image = CType(resources.GetObject("pbxlogo.Image"), System.Drawing.Image)
        Me.pbxlogo.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.pbxlogo.Location = New System.Drawing.Point(453, 308)
        Me.pbxlogo.Name = "pbxlogo"
        Me.pbxlogo.Size = New System.Drawing.Size(139, 36)
        Me.pbxlogo.TabIndex = 149
        Me.pbxlogo.TabStop = False
        '
        'abmusuario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(620, 356)
        Me.Controls.Add(Me.lbldesarrollo)
        Me.Controls.Add(Me.pbxlogo)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtnombre)
        Me.Controls.Add(Me.txtnomusua)
        Me.Controls.Add(Me.dgvusuarios)
        Me.Controls.Add(Me.btnatras)
        Me.Controls.Add(Me.lblrol)
        Me.Controls.Add(Me.btnclose)
        Me.Controls.Add(Me.lbltipou)
        Me.Controls.Add(Me.btnalta)
        Me.Controls.Add(Me.btnbaja)
        Me.Controls.Add(Me.btnmod)
        Me.Controls.Add(Me.lbltitulo)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "abmusuario"
        Me.Text = "S.I.B.A."
        CType(Me.dgvusuarios, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbxlogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lbltitulo As System.Windows.Forms.Label
    Friend WithEvents btnalta As System.Windows.Forms.Button
    Friend WithEvents btnbaja As System.Windows.Forms.Button
    Friend WithEvents btnmod As System.Windows.Forms.Button
    Friend WithEvents lblrol As System.Windows.Forms.Label
    Friend WithEvents btnclose As System.Windows.Forms.Button
    Friend WithEvents lbltipou As System.Windows.Forms.Label
    Friend WithEvents btnatras As System.Windows.Forms.Button
    Friend WithEvents dgvusuarios As System.Windows.Forms.DataGridView
    Friend WithEvents txtnomusua As System.Windows.Forms.TextBox
    Friend WithEvents txtnombre As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lbldesarrollo As System.Windows.Forms.Label
    Friend WithEvents pbxlogo As System.Windows.Forms.PictureBox
End Class

