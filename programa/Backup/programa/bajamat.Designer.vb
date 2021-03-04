<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class bajamat
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
        Dim ListViewItem1 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New String() {"Mat3", "Matemática", "EMT Informatica"}, -1, System.Drawing.Color.Empty, System.Drawing.SystemColors.Window, Nothing)
        Dim ListViewItem2 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("")
        Me.btnelim = New System.Windows.Forms.Button
        Me.btnatras = New System.Windows.Forms.Button
        Me.ltvmat = New System.Windows.Forms.ListView
        Me.ColumnHeader1 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader2 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader3 = New System.Windows.Forms.ColumnHeader
        Me.lbltitulo = New System.Windows.Forms.Label
        Me.lblrol = New System.Windows.Forms.Label
        Me.btnclose = New System.Windows.Forms.Button
        Me.lblipou = New System.Windows.Forms.Label
        Me.SuspendLayout()
        '
        'btnelim
        '
        Me.btnelim.BackColor = System.Drawing.Color.Transparent
        Me.btnelim.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnelim.Location = New System.Drawing.Point(366, 124)
        Me.btnelim.Name = "btnelim"
        Me.btnelim.Size = New System.Drawing.Size(101, 22)
        Me.btnelim.TabIndex = 19
        Me.btnelim.Text = "Eliminar"
        Me.btnelim.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage
        Me.btnelim.UseVisualStyleBackColor = False
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
        'ltvmat
        '
        Me.ltvmat.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3})
        Me.ltvmat.FullRowSelect = True
        Me.ltvmat.GridLines = True
        Me.ltvmat.Items.AddRange(New System.Windows.Forms.ListViewItem() {ListViewItem1, ListViewItem2})
        Me.ltvmat.Location = New System.Drawing.Point(15, 75)
        Me.ltvmat.Name = "ltvmat"
        Me.ltvmat.Size = New System.Drawing.Size(252, 175)
        Me.ltvmat.TabIndex = 28
        Me.ltvmat.UseCompatibleStateImageBehavior = False
        Me.ltvmat.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Código"
        Me.ColumnHeader1.Width = 59
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Nombre"
        Me.ColumnHeader2.Width = 81
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Carrera"
        Me.ColumnHeader3.Width = 103
        '
        'lbltitulo
        '
        Me.lbltitulo.AutoSize = True
        Me.lbltitulo.BackColor = System.Drawing.Color.LemonChiffon
        Me.lbltitulo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbltitulo.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltitulo.Location = New System.Drawing.Point(15, 9)
        Me.lbltitulo.Name = "lbltitulo"
        Me.lbltitulo.Size = New System.Drawing.Size(207, 26)
        Me.lbltitulo.TabIndex = 137
        Me.lbltitulo.Text = "BAJA DE MATERIAS"
        '
        'lblrol
        '
        Me.lblrol.AutoSize = True
        Me.lblrol.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblrol.Location = New System.Drawing.Point(335, 15)
        Me.lblrol.Name = "lblrol"
        Me.lblrol.Size = New System.Drawing.Size(36, 16)
        Me.lblrol.TabIndex = 140
        Me.lblrol.Text = "Rol:"
        '
        'btnclose
        '
        Me.btnclose.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnclose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnclose.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnclose.Location = New System.Drawing.Point(403, 34)
        Me.btnclose.Name = "btnclose"
        Me.btnclose.Size = New System.Drawing.Size(102, 24)
        Me.btnclose.TabIndex = 139
        Me.btnclose.Text = "Cerrar sesión"
        Me.btnclose.UseVisualStyleBackColor = True
        '
        'lblipou
        '
        Me.lblipou.AutoSize = True
        Me.lblipou.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblipou.Location = New System.Drawing.Point(368, 15)
        Me.lblipou.Name = "lblipou"
        Me.lblipou.Size = New System.Drawing.Size(137, 16)
        Me.lblipou.TabIndex = 138
        Me.lblipou.Text = "Secretario Escolar"
        '
        'bajamat
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(528, 343)
        Me.Controls.Add(Me.lblrol)
        Me.Controls.Add(Me.btnclose)
        Me.Controls.Add(Me.lblipou)
        Me.Controls.Add(Me.lbltitulo)
        Me.Controls.Add(Me.ltvmat)
        Me.Controls.Add(Me.btnelim)
        Me.Controls.Add(Me.btnatras)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "bajamat"
        Me.Text = "S.I.B.A"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnelim As System.Windows.Forms.Button
    Friend WithEvents btnatras As System.Windows.Forms.Button
    Friend WithEvents ltvmat As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents lbltitulo As System.Windows.Forms.Label
    Friend WithEvents lblrol As System.Windows.Forms.Label
    Friend WithEvents btnclose As System.Windows.Forms.Button
    Friend WithEvents lblipou As System.Windows.Forms.Label
End Class
