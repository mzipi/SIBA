<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class iabmhoras
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
        Me.bnbaja = New System.Windows.Forms.Button
        Me.lbltitulo = New System.Windows.Forms.Label
        Me.btnalta = New System.Windows.Forms.Button
        Me.btnbaja = New System.Windows.Forms.Button
        Me.btnmod = New System.Windows.Forms.Button
        Me.lblrol = New System.Windows.Forms.Label
        Me.btnclose = New System.Windows.Forms.Button
        Me.lbltipou = New System.Windows.Forms.Label
        Me.dgvhoras = New System.Windows.Forms.DataGridView
        CType(Me.dgvhoras, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'bnbaja
        '
        Me.bnbaja.BackColor = System.Drawing.Color.Transparent
        Me.bnbaja.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bnbaja.Location = New System.Drawing.Point(382, 302)
        Me.bnbaja.Name = "bnbaja"
        Me.bnbaja.Size = New System.Drawing.Size(101, 22)
        Me.bnbaja.TabIndex = 18
        Me.bnbaja.Text = "Back"
        Me.bnbaja.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage
        Me.bnbaja.UseVisualStyleBackColor = False
        '
        'lbltitulo
        '
        Me.lbltitulo.AutoSize = True
        Me.lbltitulo.BackColor = System.Drawing.Color.LemonChiffon
        Me.lbltitulo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbltitulo.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltitulo.Location = New System.Drawing.Point(18, 9)
        Me.lbltitulo.Name = "lbltitulo"
        Me.lbltitulo.Size = New System.Drawing.Size(238, 26)
        Me.lbltitulo.TabIndex = 54
        Me.lbltitulo.Text = "HOURS MANAGEMENT"
        '
        'btnalta
        '
        Me.btnalta.BackColor = System.Drawing.Color.Transparent
        Me.btnalta.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnalta.Location = New System.Drawing.Point(15, 65)
        Me.btnalta.Name = "btnalta"
        Me.btnalta.Size = New System.Drawing.Size(101, 28)
        Me.btnalta.TabIndex = 73
        Me.btnalta.Text = "Log on"
        Me.btnalta.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage
        Me.btnalta.UseVisualStyleBackColor = False
        '
        'btnbaja
        '
        Me.btnbaja.BackColor = System.Drawing.Color.Transparent
        Me.btnbaja.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnbaja.Location = New System.Drawing.Point(15, 135)
        Me.btnbaja.Name = "btnbaja"
        Me.btnbaja.Size = New System.Drawing.Size(101, 28)
        Me.btnbaja.TabIndex = 72
        Me.btnbaja.Text = "Delete"
        Me.btnbaja.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage
        Me.btnbaja.UseVisualStyleBackColor = False
        '
        'btnmod
        '
        Me.btnmod.BackColor = System.Drawing.Color.Transparent
        Me.btnmod.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnmod.Location = New System.Drawing.Point(15, 100)
        Me.btnmod.Name = "btnmod"
        Me.btnmod.Size = New System.Drawing.Size(101, 28)
        Me.btnmod.TabIndex = 71
        Me.btnmod.Text = "Modify"
        Me.btnmod.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage
        Me.btnmod.UseVisualStyleBackColor = False
        '
        'lblrol
        '
        Me.lblrol.AutoSize = True
        Me.lblrol.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblrol.Location = New System.Drawing.Point(414, 9)
        Me.lblrol.Name = "lblrol"
        Me.lblrol.Size = New System.Drawing.Size(45, 16)
        Me.lblrol.TabIndex = 76
        Me.lblrol.Text = "Role:"
        '
        'btnclose
        '
        Me.btnclose.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnclose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnclose.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnclose.Location = New System.Drawing.Point(491, 28)
        Me.btnclose.Name = "btnclose"
        Me.btnclose.Size = New System.Drawing.Size(102, 24)
        Me.btnclose.TabIndex = 75
        Me.btnclose.Text = "Log out"
        Me.btnclose.UseVisualStyleBackColor = True
        '
        'lbltipou
        '
        Me.lbltipou.AutoSize = True
        Me.lbltipou.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltipou.Location = New System.Drawing.Point(456, 9)
        Me.lbltipou.Name = "lbltipou"
        Me.lbltipou.Size = New System.Drawing.Size(127, 16)
        Me.lbltipou.TabIndex = 74
        Me.lbltipou.Text = "School Secretary"
        '
        'dgvhoras
        '
        Me.dgvhoras.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvhoras.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvhoras.Location = New System.Drawing.Point(147, 65)
        Me.dgvhoras.MultiSelect = False
        Me.dgvhoras.Name = "dgvhoras"
        Me.dgvhoras.ReadOnly = True
        Me.dgvhoras.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvhoras.Size = New System.Drawing.Size(446, 219)
        Me.dgvhoras.TabIndex = 77
        '
        'iabmhoras
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(616, 336)
        Me.Controls.Add(Me.dgvhoras)
        Me.Controls.Add(Me.lblrol)
        Me.Controls.Add(Me.btnclose)
        Me.Controls.Add(Me.lbltipou)
        Me.Controls.Add(Me.btnalta)
        Me.Controls.Add(Me.btnbaja)
        Me.Controls.Add(Me.btnmod)
        Me.Controls.Add(Me.lbltitulo)
        Me.Controls.Add(Me.bnbaja)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "iabmhoras"
        Me.Text = "S.I.B.A"
        CType(Me.dgvhoras, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents bnbaja As System.Windows.Forms.Button
    Friend WithEvents lbltitulo As System.Windows.Forms.Label
    Friend WithEvents btnalta As System.Windows.Forms.Button
    Friend WithEvents btnbaja As System.Windows.Forms.Button
    Friend WithEvents btnmod As System.Windows.Forms.Button
    Friend WithEvents lblrol As System.Windows.Forms.Label
    Friend WithEvents btnclose As System.Windows.Forms.Button
    Friend WithEvents lbltipou As System.Windows.Forms.Label
    Friend WithEvents dgvhoras As System.Windows.Forms.DataGridView
End Class
