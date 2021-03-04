<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class iabmsalon
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.btnmod = New System.Windows.Forms.Button
        Me.btndefcarr = New System.Windows.Forms.Button
        Me.btnbaja = New System.Windows.Forms.Button
        Me.btnalta = New System.Windows.Forms.Button
        Me.btnatras = New System.Windows.Forms.Button
        Me.lbltitulo = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.btnclose = New System.Windows.Forms.Button
        Me.lblrol = New System.Windows.Forms.Label
        Me.dgvsalon = New System.Windows.Forms.DataGridView
        CType(Me.dgvsalon, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnmod
        '
        Me.btnmod.BackColor = System.Drawing.Color.Transparent
        Me.btnmod.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnmod.Location = New System.Drawing.Point(18, 116)
        Me.btnmod.Name = "btnmod"
        Me.btnmod.Size = New System.Drawing.Size(101, 28)
        Me.btnmod.TabIndex = 29
        Me.btnmod.Text = "Modify"
        Me.btnmod.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage
        Me.btnmod.UseVisualStyleBackColor = False
        '
        'btndefcarr
        '
        Me.btndefcarr.BackColor = System.Drawing.Color.Transparent
        Me.btndefcarr.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btndefcarr.Location = New System.Drawing.Point(18, 315)
        Me.btndefcarr.Name = "btndefcarr"
        Me.btndefcarr.Size = New System.Drawing.Size(134, 32)
        Me.btndefcarr.TabIndex = 31
        Me.btndefcarr.Text = "Define careers"
        Me.btndefcarr.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage
        Me.btndefcarr.UseVisualStyleBackColor = False
        '
        'btnbaja
        '
        Me.btnbaja.BackColor = System.Drawing.Color.Transparent
        Me.btnbaja.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnbaja.Location = New System.Drawing.Point(18, 150)
        Me.btnbaja.Name = "btnbaja"
        Me.btnbaja.Size = New System.Drawing.Size(101, 28)
        Me.btnbaja.TabIndex = 32
        Me.btnbaja.Text = "Delete"
        Me.btnbaja.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage
        Me.btnbaja.UseVisualStyleBackColor = False
        '
        'btnalta
        '
        Me.btnalta.BackColor = System.Drawing.Color.Transparent
        Me.btnalta.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnalta.Location = New System.Drawing.Point(18, 82)
        Me.btnalta.Name = "btnalta"
        Me.btnalta.Size = New System.Drawing.Size(101, 28)
        Me.btnalta.TabIndex = 33
        Me.btnalta.Text = "Log on"
        Me.btnalta.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage
        Me.btnalta.UseVisualStyleBackColor = False
        '
        'btnatras
        '
        Me.btnatras.BackColor = System.Drawing.Color.Transparent
        Me.btnatras.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnatras.Location = New System.Drawing.Point(399, 315)
        Me.btnatras.Name = "btnatras"
        Me.btnatras.Size = New System.Drawing.Size(101, 32)
        Me.btnatras.TabIndex = 34
        Me.btnatras.Text = "Back"
        Me.btnatras.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage
        Me.btnatras.UseVisualStyleBackColor = False
        '
        'lbltitulo
        '
        Me.lbltitulo.AutoSize = True
        Me.lbltitulo.BackColor = System.Drawing.Color.LemonChiffon
        Me.lbltitulo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbltitulo.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltitulo.Location = New System.Drawing.Point(18, 9)
        Me.lbltitulo.Name = "lbltitulo"
        Me.lbltitulo.Size = New System.Drawing.Size(294, 26)
        Me.lbltitulo.TabIndex = 50
        Me.lbltitulo.Text = "CLASSROOM MANAGEMENT"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(411, 9)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(45, 16)
        Me.Label3.TabIndex = 58
        Me.Label3.Text = "Role:"
        '
        'btnclose
        '
        Me.btnclose.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnclose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnclose.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnclose.Location = New System.Drawing.Point(497, 28)
        Me.btnclose.Name = "btnclose"
        Me.btnclose.Size = New System.Drawing.Size(102, 24)
        Me.btnclose.TabIndex = 57
        Me.btnclose.Text = "Log out"
        Me.btnclose.UseVisualStyleBackColor = True
        '
        'lblrol
        '
        Me.lblrol.AutoSize = True
        Me.lblrol.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblrol.Location = New System.Drawing.Point(462, 9)
        Me.lblrol.Name = "lblrol"
        Me.lblrol.Size = New System.Drawing.Size(127, 16)
        Me.lblrol.TabIndex = 56
        Me.lblrol.Text = "School Secretary"
        '
        'dgvsalon
        '
        Me.dgvsalon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.IndianRed
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvsalon.DefaultCellStyle = DataGridViewCellStyle1
        Me.dgvsalon.Location = New System.Drawing.Point(171, 82)
        Me.dgvsalon.MultiSelect = False
        Me.dgvsalon.Name = "dgvsalon"
        Me.dgvsalon.ReadOnly = True
        Me.dgvsalon.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvsalon.Size = New System.Drawing.Size(376, 206)
        Me.dgvsalon.TabIndex = 59
        '
        'iabmsalon
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(620, 356)
        Me.Controls.Add(Me.dgvsalon)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.btnclose)
        Me.Controls.Add(Me.lblrol)
        Me.Controls.Add(Me.lbltitulo)
        Me.Controls.Add(Me.btnatras)
        Me.Controls.Add(Me.btnalta)
        Me.Controls.Add(Me.btnbaja)
        Me.Controls.Add(Me.btndefcarr)
        Me.Controls.Add(Me.btnmod)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "iabmsalon"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "S.I.B.A"
        CType(Me.dgvsalon, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnmod As System.Windows.Forms.Button
    Friend WithEvents btndefcarr As System.Windows.Forms.Button
    Friend WithEvents btnbaja As System.Windows.Forms.Button
    Friend WithEvents btnalta As System.Windows.Forms.Button
    Friend WithEvents btnatras As System.Windows.Forms.Button
    Friend WithEvents lbltitulo As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents btnclose As System.Windows.Forms.Button
    Friend WithEvents lblrol As System.Windows.Forms.Label
    Friend WithEvents dgvsalon As System.Windows.Forms.DataGridView
End Class