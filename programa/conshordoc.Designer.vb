<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class conshordoc
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
        Me.lblcons = New System.Windows.Forms.Button
        Me.btnatras = New System.Windows.Forms.Button
        Me.lbltitulo = New System.Windows.Forms.Label
        Me.lblrol = New System.Windows.Forms.Label
        Me.btbclose = New System.Windows.Forms.Button
        Me.lbltipou = New System.Windows.Forms.Label
        Me.lblnombre = New System.Windows.Forms.Label
        Me.cmbdocente = New System.Windows.Forms.ComboBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.cmbtipo = New System.Windows.Forms.ComboBox
        Me.gbxhordoc = New System.Windows.Forms.GroupBox
        Me.dgvhordoc = New System.Windows.Forms.DataGridView
        Me.txtci = New System.Windows.Forms.TextBox
        Me.btnmenu = New System.Windows.Forms.Button
        Me.btncons = New System.Windows.Forms.Button
        Me.gbxhordoc.SuspendLayout()
        CType(Me.dgvhordoc, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblcons
        '
        Me.lblcons.BackColor = System.Drawing.Color.Transparent
        Me.lblcons.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblcons.Location = New System.Drawing.Point(174, 87)
        Me.lblcons.Name = "lblcons"
        Me.lblcons.Size = New System.Drawing.Size(101, 32)
        Me.lblcons.TabIndex = 46
        Me.lblcons.Text = "Consultar"
        Me.lblcons.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage
        Me.lblcons.UseVisualStyleBackColor = False
        '
        'btnatras
        '
        Me.btnatras.BackColor = System.Drawing.Color.Transparent
        Me.btnatras.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnatras.Location = New System.Drawing.Point(67, 87)
        Me.btnatras.Name = "btnatras"
        Me.btnatras.Size = New System.Drawing.Size(101, 32)
        Me.btnatras.TabIndex = 47
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
        Me.lbltitulo.Location = New System.Drawing.Point(9, 9)
        Me.lbltitulo.Name = "lbltitulo"
        Me.lbltitulo.Size = New System.Drawing.Size(262, 26)
        Me.lbltitulo.TabIndex = 48
        Me.lbltitulo.Text = "CONSULTA DE HORARIO "
        '
        'lblrol
        '
        Me.lblrol.AutoSize = True
        Me.lblrol.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblrol.Location = New System.Drawing.Point(449, 9)
        Me.lblrol.Name = "lblrol"
        Me.lblrol.Size = New System.Drawing.Size(36, 16)
        Me.lblrol.TabIndex = 61
        Me.lblrol.Text = "Rol:"
        '
        'btbclose
        '
        Me.btbclose.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btbclose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btbclose.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btbclose.Location = New System.Drawing.Point(494, 28)
        Me.btbclose.Name = "btbclose"
        Me.btbclose.Size = New System.Drawing.Size(102, 24)
        Me.btbclose.TabIndex = 60
        Me.btbclose.Text = "Cerrar sesión"
        Me.btbclose.UseVisualStyleBackColor = True
        '
        'lbltipou
        '
        Me.lbltipou.AutoSize = True
        Me.lbltipou.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltipou.Location = New System.Drawing.Point(491, 9)
        Me.lbltipou.Name = "lbltipou"
        Me.lbltipou.Size = New System.Drawing.Size(0, 16)
        Me.lbltipou.TabIndex = 59
        '
        'lblnombre
        '
        Me.lblnombre.AutoSize = True
        Me.lblnombre.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblnombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblnombre.Location = New System.Drawing.Point(3, 17)
        Me.lblnombre.Name = "lblnombre"
        Me.lblnombre.Size = New System.Drawing.Size(131, 18)
        Me.lblnombre.TabIndex = 41
        Me.lblnombre.Text = "Nombre Docente:"
        '
        'cmbdocente
        '
        Me.cmbdocente.FormattingEnabled = True
        Me.cmbdocente.Location = New System.Drawing.Point(150, 17)
        Me.cmbdocente.Name = "cmbdocente"
        Me.cmbdocente.Size = New System.Drawing.Size(125, 24)
        Me.cmbdocente.TabIndex = 62
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(0, 47)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(110, 18)
        Me.Label1.TabIndex = 63
        Me.Label1.Text = "Tipo Consulta:"
        '
        'cmbtipo
        '
        Me.cmbtipo.FormattingEnabled = True
        Me.cmbtipo.Items.AddRange(New Object() {"(Seleccione)", "Todos los turnos", "Matutino", "Vespertino", "Nocturno", " "})
        Me.cmbtipo.Location = New System.Drawing.Point(150, 47)
        Me.cmbtipo.Name = "cmbtipo"
        Me.cmbtipo.Size = New System.Drawing.Size(125, 24)
        Me.cmbtipo.TabIndex = 64
        '
        'gbxhordoc
        '
        Me.gbxhordoc.Controls.Add(Me.cmbtipo)
        Me.gbxhordoc.Controls.Add(Me.Label1)
        Me.gbxhordoc.Controls.Add(Me.cmbdocente)
        Me.gbxhordoc.Controls.Add(Me.btnatras)
        Me.gbxhordoc.Controls.Add(Me.lblcons)
        Me.gbxhordoc.Controls.Add(Me.lblnombre)
        Me.gbxhordoc.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbxhordoc.Location = New System.Drawing.Point(9, 55)
        Me.gbxhordoc.Name = "gbxhordoc"
        Me.gbxhordoc.Size = New System.Drawing.Size(292, 137)
        Me.gbxhordoc.TabIndex = 65
        Me.gbxhordoc.TabStop = False
        Me.gbxhordoc.Text = "Horarios Docente"
        '
        'dgvhordoc
        '
        Me.dgvhordoc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvhordoc.Location = New System.Drawing.Point(115, 250)
        Me.dgvhordoc.Name = "dgvhordoc"
        Me.dgvhordoc.Size = New System.Drawing.Size(222, 175)
        Me.dgvhordoc.TabIndex = 66
        '
        'txtci
        '
        Me.txtci.Location = New System.Drawing.Point(329, 78)
        Me.txtci.Name = "txtci"
        Me.txtci.Size = New System.Drawing.Size(100, 20)
        Me.txtci.TabIndex = 67
        '
        'btnmenu
        '
        Me.btnmenu.Location = New System.Drawing.Point(452, 333)
        Me.btnmenu.Name = "btnmenu"
        Me.btnmenu.Size = New System.Drawing.Size(144, 31)
        Me.btnmenu.TabIndex = 68
        Me.btnmenu.Text = "MENU PRINCIPAL"
        Me.btnmenu.UseVisualStyleBackColor = True
        '
        'btncons
        '
        Me.btncons.Location = New System.Drawing.Point(452, 296)
        Me.btncons.Name = "btncons"
        Me.btncons.Size = New System.Drawing.Size(144, 31)
        Me.btncons.TabIndex = 69
        Me.btncons.Text = "REALIZAR CONSULTA"
        Me.btncons.UseVisualStyleBackColor = True
        '
        'conshordoc
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(624, 376)
        Me.Controls.Add(Me.btncons)
        Me.Controls.Add(Me.btnmenu)
        Me.Controls.Add(Me.txtci)
        Me.Controls.Add(Me.dgvhordoc)
        Me.Controls.Add(Me.gbxhordoc)
        Me.Controls.Add(Me.lblrol)
        Me.Controls.Add(Me.btbclose)
        Me.Controls.Add(Me.lbltipou)
        Me.Controls.Add(Me.lbltitulo)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "conshordoc"
        Me.Text = "S.I.B.A"
        Me.gbxhordoc.ResumeLayout(False)
        Me.gbxhordoc.PerformLayout()
        CType(Me.dgvhordoc, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblcons As System.Windows.Forms.Button
    Friend WithEvents btnatras As System.Windows.Forms.Button
    Friend WithEvents lbltitulo As System.Windows.Forms.Label
    Friend WithEvents lblrol As System.Windows.Forms.Label
    Friend WithEvents btbclose As System.Windows.Forms.Button
    Friend WithEvents lbltipou As System.Windows.Forms.Label
    Friend WithEvents lblnombre As System.Windows.Forms.Label
    Friend WithEvents cmbdocente As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cmbtipo As System.Windows.Forms.ComboBox
    Friend WithEvents gbxhordoc As System.Windows.Forms.GroupBox
    Friend WithEvents dgvhordoc As System.Windows.Forms.DataGridView
    Friend WithEvents txtci As System.Windows.Forms.TextBox
    Friend WithEvents btnmenu As System.Windows.Forms.Button
    Friend WithEvents btncons As System.Windows.Forms.Button
End Class
