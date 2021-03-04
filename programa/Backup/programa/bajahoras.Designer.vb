<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class bajahoras
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
        Dim ListViewItem3 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New String() {"005", "4", "Sábado", "15:35", "16:15"}, -1, System.Drawing.Color.Empty, System.Drawing.SystemColors.Window, Nothing)
        Dim ListViewItem4 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("")
        Me.btnelim = New System.Windows.Forms.Button
        Me.btnatras = New System.Windows.Forms.Button
        Me.lbltitulo = New System.Windows.Forms.Label
        Me.lblrol = New System.Windows.Forms.Label
        Me.Button5 = New System.Windows.Forms.Button
        Me.lbltipou = New System.Windows.Forms.Label
        Me.ltvhoras = New System.Windows.Forms.ListView
        Me.ColumnHeader1 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader2 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader3 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader4 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader5 = New System.Windows.Forms.ColumnHeader
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
        'lbltitulo
        '
        Me.lbltitulo.AutoSize = True
        Me.lbltitulo.BackColor = System.Drawing.Color.LemonChiffon
        Me.lbltitulo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbltitulo.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltitulo.Location = New System.Drawing.Point(15, 9)
        Me.lbltitulo.Name = "lbltitulo"
        Me.lbltitulo.Size = New System.Drawing.Size(175, 26)
        Me.lbltitulo.TabIndex = 137
        Me.lbltitulo.Text = "BAJA DE HORAS"
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
        'Button5
        '
        Me.Button5.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button5.Location = New System.Drawing.Point(403, 34)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(102, 24)
        Me.Button5.TabIndex = 139
        Me.Button5.Text = "Cerrar sesión"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'lbltipou
        '
        Me.lbltipou.AutoSize = True
        Me.lbltipou.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltipou.Location = New System.Drawing.Point(368, 15)
        Me.lbltipou.Name = "lbltipou"
        Me.lbltipou.Size = New System.Drawing.Size(137, 16)
        Me.lbltipou.TabIndex = 138
        Me.lbltipou.Text = "Secretario Escolar"
        '
        'ltvhoras
        '
        Me.ltvhoras.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader4, Me.ColumnHeader5})
        Me.ltvhoras.FullRowSelect = True
        Me.ltvhoras.GridLines = True
        Me.ltvhoras.Items.AddRange(New System.Windows.Forms.ListViewItem() {ListViewItem3, ListViewItem4})
        Me.ltvhoras.Location = New System.Drawing.Point(15, 65)
        Me.ltvhoras.Name = "ltvhoras"
        Me.ltvhoras.Size = New System.Drawing.Size(322, 175)
        Me.ltvhoras.TabIndex = 141
        Me.ltvhoras.UseCompatibleStateImageBehavior = False
        Me.ltvhoras.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Código"
        Me.ColumnHeader1.Width = 55
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Número"
        Me.ColumnHeader2.Width = 56
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Día"
        Me.ColumnHeader3.Width = 61
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "Hora inicial"
        Me.ColumnHeader4.Width = 75
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "Hora final"
        '
        'bajahoras
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(528, 343)
        Me.Controls.Add(Me.ltvhoras)
        Me.Controls.Add(Me.lblrol)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.lbltipou)
        Me.Controls.Add(Me.lbltitulo)
        Me.Controls.Add(Me.btnelim)
        Me.Controls.Add(Me.btnatras)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "bajahoras"
        Me.Text = "S.I.B.A"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnelim As System.Windows.Forms.Button
    Friend WithEvents btnatras As System.Windows.Forms.Button
    Friend WithEvents lbltitulo As System.Windows.Forms.Label
    Friend WithEvents lblrol As System.Windows.Forms.Label
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents lbltipou As System.Windows.Forms.Label
    Friend WithEvents ltvhoras As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader4 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader5 As System.Windows.Forms.ColumnHeader
End Class

