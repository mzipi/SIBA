<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ihorasturdir
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.lbltitulo = New System.Windows.Forms.Label
        Me.btnclose = New System.Windows.Forms.Button
        Me.lblrol = New System.Windows.Forms.Label
        Me.lbltipou = New System.Windows.Forms.Label
        Me.lblhora = New System.Windows.Forms.Label
        Me.btnmenu = New System.Windows.Forms.Button
        Me.gbxsel = New System.Windows.Forms.GroupBox
        Me.btncons = New System.Windows.Forms.Button
        Me.cmbturno = New System.Windows.Forms.ComboBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.dgvhorastur = New System.Windows.Forms.DataGridView
        Me.txtid_turno = New System.Windows.Forms.TextBox
        Me.lblsiba = New System.Windows.Forms.Label
        Me.lbldesarrollo = New System.Windows.Forms.Label
        Me.pbxlogo = New System.Windows.Forms.PictureBox
        Me.gbxsel.SuspendLayout()
        CType(Me.dgvhorastur, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbxlogo, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.lbltitulo.Size = New System.Drawing.Size(169, 26)
        Me.lbltitulo.TabIndex = 50
        Me.lbltitulo.Text = "Turns and Hours"
        '
        'btnclose
        '
        Me.btnclose.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnclose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnclose.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnclose.Location = New System.Drawing.Point(629, 28)
        Me.btnclose.Name = "btnclose"
        Me.btnclose.Size = New System.Drawing.Size(102, 24)
        Me.btnclose.TabIndex = 59
        Me.btnclose.Text = "Log out"
        Me.btnclose.UseVisualStyleBackColor = True
        '
        'lblrol
        '
        Me.lblrol.AutoSize = True
        Me.lblrol.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblrol.Location = New System.Drawing.Point(626, 9)
        Me.lblrol.Name = "lblrol"
        Me.lblrol.Size = New System.Drawing.Size(45, 16)
        Me.lblrol.TabIndex = 56
        Me.lblrol.Text = "Role:"
        '
        'lbltipou
        '
        Me.lbltipou.AutoSize = True
        Me.lbltipou.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltipou.Location = New System.Drawing.Point(668, 9)
        Me.lbltipou.Name = "lbltipou"
        Me.lbltipou.Size = New System.Drawing.Size(63, 16)
        Me.lbltipou.TabIndex = 58
        Me.lbltipou.Text = "Director"
        '
        'lblhora
        '
        Me.lblhora.AutoSize = True
        Me.lblhora.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblhora.Location = New System.Drawing.Point(558, 0)
        Me.lblhora.Name = "lblhora"
        Me.lblhora.Size = New System.Drawing.Size(0, 16)
        Me.lblhora.TabIndex = 54
        '
        'btnmenu
        '
        Me.btnmenu.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnmenu.Location = New System.Drawing.Point(471, 450)
        Me.btnmenu.Name = "btnmenu"
        Me.btnmenu.Size = New System.Drawing.Size(207, 23)
        Me.btnmenu.TabIndex = 60
        Me.btnmenu.Text = "MENÚ PRINCIPAL"
        Me.btnmenu.UseVisualStyleBackColor = True
        '
        'gbxsel
        '
        Me.gbxsel.Controls.Add(Me.btncons)
        Me.gbxsel.Controls.Add(Me.cmbturno)
        Me.gbxsel.Controls.Add(Me.Label1)
        Me.gbxsel.Location = New System.Drawing.Point(12, 54)
        Me.gbxsel.Name = "gbxsel"
        Me.gbxsel.Size = New System.Drawing.Size(268, 118)
        Me.gbxsel.TabIndex = 63
        Me.gbxsel.TabStop = False
        Me.gbxsel.Text = "Select"
        '
        'btncons
        '
        Me.btncons.Location = New System.Drawing.Point(150, 83)
        Me.btncons.Name = "btncons"
        Me.btncons.Size = New System.Drawing.Size(98, 29)
        Me.btncons.TabIndex = 2
        Me.btncons.Text = "Consult"
        Me.btncons.UseVisualStyleBackColor = True
        '
        'cmbturno
        '
        Me.cmbturno.FormattingEnabled = True
        Me.cmbturno.Items.AddRange(New Object() {"(Seleccione)", "Matutino", "Vespertino", "Nocturno"})
        Me.cmbturno.Location = New System.Drawing.Point(9, 47)
        Me.cmbturno.Name = "cmbturno"
        Me.cmbturno.Size = New System.Drawing.Size(239, 21)
        Me.cmbturno.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(6, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(197, 18)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Select the turn to consult"
        '
        'dgvhorastur
        '
        Me.dgvhorastur.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvhorastur.Location = New System.Drawing.Point(296, 92)
        Me.dgvhorastur.Name = "dgvhorastur"
        Me.dgvhorastur.Size = New System.Drawing.Size(382, 265)
        Me.dgvhorastur.TabIndex = 64
        '
        'txtid_turno
        '
        Me.txtid_turno.Location = New System.Drawing.Point(58, 202)
        Me.txtid_turno.Name = "txtid_turno"
        Me.txtid_turno.Size = New System.Drawing.Size(62, 20)
        Me.txtid_turno.TabIndex = 65
        '
        'lblsiba
        '
        Me.lblsiba.Font = New System.Drawing.Font("Pristina", 26.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblsiba.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblsiba.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblsiba.Location = New System.Drawing.Point(319, 9)
        Me.lblsiba.Name = "lblsiba"
        Me.lblsiba.Size = New System.Drawing.Size(136, 43)
        Me.lblsiba.TabIndex = 154
        Me.lblsiba.Text = "S.I.B.A."
        '
        'lbldesarrollo
        '
        Me.lbldesarrollo.AutoSize = True
        Me.lbldesarrollo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.lbldesarrollo.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lbldesarrollo.Location = New System.Drawing.Point(12, 293)
        Me.lbldesarrollo.Name = "lbldesarrollo"
        Me.lbldesarrollo.Size = New System.Drawing.Size(186, 13)
        Me.lbldesarrollo.TabIndex = 153
        Me.lbldesarrollo.Text = "Development and maintenance:"
        '
        'pbxlogo
        '
        Me.pbxlogo.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.pbxlogo.Location = New System.Drawing.Point(21, 313)
        Me.pbxlogo.Name = "pbxlogo"
        Me.pbxlogo.Size = New System.Drawing.Size(139, 44)
        Me.pbxlogo.TabIndex = 152
        Me.pbxlogo.TabStop = False
        '
        'ihorasturdir
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(767, 526)
        Me.Controls.Add(Me.lblsiba)
        Me.Controls.Add(Me.lbldesarrollo)
        Me.Controls.Add(Me.pbxlogo)
        Me.Controls.Add(Me.txtid_turno)
        Me.Controls.Add(Me.dgvhorastur)
        Me.Controls.Add(Me.gbxsel)
        Me.Controls.Add(Me.btnmenu)
        Me.Controls.Add(Me.btnclose)
        Me.Controls.Add(Me.lblrol)
        Me.Controls.Add(Me.lbltipou)
        Me.Controls.Add(Me.lblhora)
        Me.Controls.Add(Me.lbltitulo)
        Me.Name = "ihorasturdir"
        Me.Text = "S.I.B.A"
        Me.gbxsel.ResumeLayout(False)
        Me.gbxsel.PerformLayout()
        CType(Me.dgvhorastur, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbxlogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lbltitulo As System.Windows.Forms.Label
    Friend WithEvents btnclose As System.Windows.Forms.Button
    Friend WithEvents lblrol As System.Windows.Forms.Label
    Friend WithEvents lbltipou As System.Windows.Forms.Label
    Friend WithEvents lblhora As System.Windows.Forms.Label
    Friend WithEvents btnmenu As System.Windows.Forms.Button
    Friend WithEvents gbxsel As System.Windows.Forms.GroupBox
    Friend WithEvents btncons As System.Windows.Forms.Button
    Friend WithEvents cmbturno As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents dgvhorastur As System.Windows.Forms.DataGridView
    Friend WithEvents txtid_turno As System.Windows.Forms.TextBox
    Friend WithEvents lblsiba As System.Windows.Forms.Label
    Friend WithEvents lbldesarrollo As System.Windows.Forms.Label
    Friend WithEvents pbxlogo As System.Windows.Forms.PictureBox
End Class

