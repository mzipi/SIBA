<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class repgrupsindoc
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
        Me.components = New System.ComponentModel.Container
        Dim ListViewItem4 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New String() {"1°IL", "1,2,3", "Jueves", "19:15", "2O:55", "Electricidad I"}, -1)
        Dim ListViewItem5 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New String() {"1°IM", "4,5,6", "Jueves", "21:55", "23:15", "Electricidad I"}, -1)
        Dim ListViewItem6 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New String() {"2°IH", "1,2,3", "Jueves", "19:15", "20:55", "Sist de Base de Datos I"}, -1)
        Me.ltvgrupsindoc = New System.Windows.Forms.ListView
        Me.ColumnHeader1 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader2 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader7 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader3 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader4 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader5 = New System.Windows.Forms.ColumnHeader
        Me.lbltitulo = New System.Windows.Forms.Label
        Me.lblrol = New System.Windows.Forms.Label
        Me.btnclose = New System.Windows.Forms.Button
        Me.lbltipou = New System.Windows.Forms.Label
        Me.btnatras = New System.Windows.Forms.Button
        Me.btnprint = New System.Windows.Forms.Button
        Me.lblfecha = New System.Windows.Forms.Label
        Me.lblrepgen = New System.Windows.Forms.Label
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.btnmenu = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'ltvgrupsindoc
        '
        Me.ltvgrupsindoc.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader7, Me.ColumnHeader3, Me.ColumnHeader4, Me.ColumnHeader5})
        Me.ltvgrupsindoc.GridLines = True
        Me.ltvgrupsindoc.Items.AddRange(New System.Windows.Forms.ListViewItem() {ListViewItem4, ListViewItem5, ListViewItem6})
        Me.ltvgrupsindoc.Location = New System.Drawing.Point(12, 102)
        Me.ltvgrupsindoc.Name = "ltvgrupsindoc"
        Me.ltvgrupsindoc.Size = New System.Drawing.Size(459, 212)
        Me.ltvgrupsindoc.TabIndex = 175
        Me.ltvgrupsindoc.UseCompatibleStateImageBehavior = False
        Me.ltvgrupsindoc.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Grupo"
        Me.ColumnHeader1.Width = 61
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.DisplayIndex = 2
        Me.ColumnHeader2.Text = "N° hora"
        '
        'ColumnHeader7
        '
        Me.ColumnHeader7.DisplayIndex = 1
        Me.ColumnHeader7.Text = "Día"
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Hora Inicio"
        Me.ColumnHeader3.Width = 78
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "Hora fin"
        Me.ColumnHeader4.Width = 68
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "Materia"
        Me.ColumnHeader5.Width = 126
        '
        'lbltitulo
        '
        Me.lbltitulo.AutoSize = True
        Me.lbltitulo.BackColor = System.Drawing.Color.LemonChiffon
        Me.lbltitulo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbltitulo.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltitulo.Location = New System.Drawing.Point(12, 9)
        Me.lbltitulo.Name = "lbltitulo"
        Me.lbltitulo.Size = New System.Drawing.Size(346, 26)
        Me.lbltitulo.TabIndex = 176
        Me.lbltitulo.Text = "REPORTE GRUPOS SIN DOCENTE"
        '
        'lblrol
        '
        Me.lblrol.AutoSize = True
        Me.lblrol.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblrol.Location = New System.Drawing.Point(584, 9)
        Me.lblrol.Name = "lblrol"
        Me.lblrol.Size = New System.Drawing.Size(36, 16)
        Me.lblrol.TabIndex = 179
        Me.lblrol.Text = "Rol:"
        '
        'btnclose
        '
        Me.btnclose.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnclose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnclose.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnclose.Location = New System.Drawing.Point(653, 28)
        Me.btnclose.Name = "btnclose"
        Me.btnclose.Size = New System.Drawing.Size(102, 24)
        Me.btnclose.TabIndex = 178
        Me.btnclose.Text = "Cerrar sesión"
        Me.btnclose.UseVisualStyleBackColor = True
        '
        'lbltipou
        '
        Me.lbltipou.AutoSize = True
        Me.lbltipou.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltipou.Location = New System.Drawing.Point(623, 9)
        Me.lbltipou.Name = "lbltipou"
        Me.lbltipou.Size = New System.Drawing.Size(0, 16)
        Me.lbltipou.TabIndex = 177
        '
        'btnatras
        '
        Me.btnatras.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnatras.Location = New System.Drawing.Point(514, 232)
        Me.btnatras.Name = "btnatras"
        Me.btnatras.Size = New System.Drawing.Size(123, 27)
        Me.btnatras.TabIndex = 182
        Me.btnatras.Text = "Atrás"
        Me.btnatras.UseVisualStyleBackColor = True
        '
        'btnprint
        '
        Me.btnprint.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnprint.Location = New System.Drawing.Point(514, 199)
        Me.btnprint.Name = "btnprint"
        Me.btnprint.Size = New System.Drawing.Size(123, 27)
        Me.btnprint.TabIndex = 181
        Me.btnprint.Text = "Imprimir Reporte"
        Me.btnprint.UseVisualStyleBackColor = True
        '
        'lblfecha
        '
        Me.lblfecha.AutoSize = True
        Me.lblfecha.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblfecha.Location = New System.Drawing.Point(252, 59)
        Me.lblfecha.Name = "lblfecha"
        Me.lblfecha.Size = New System.Drawing.Size(0, 16)
        Me.lblfecha.TabIndex = 184
        '
        'lblrepgen
        '
        Me.lblrepgen.AutoSize = True
        Me.lblrepgen.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblrepgen.Location = New System.Drawing.Point(12, 59)
        Me.lblrepgen.Name = "lblrepgen"
        Me.lblrepgen.Size = New System.Drawing.Size(178, 16)
        Me.lblrepgen.TabIndex = 185
        Me.lblrepgen.Text = "REPORTE GENERADO: "
        '
        'Timer1
        '
        '
        'btnmenu
        '
        Me.btnmenu.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnmenu.Location = New System.Drawing.Point(514, 265)
        Me.btnmenu.Name = "btnmenu"
        Me.btnmenu.Size = New System.Drawing.Size(123, 27)
        Me.btnmenu.TabIndex = 186
        Me.btnmenu.Text = "MENÚ REPORTES"
        Me.btnmenu.UseVisualStyleBackColor = True
        '
        'repgrupsindoc
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(767, 347)
        Me.Controls.Add(Me.btnmenu)
        Me.Controls.Add(Me.lblrepgen)
        Me.Controls.Add(Me.lblfecha)
        Me.Controls.Add(Me.btnatras)
        Me.Controls.Add(Me.btnprint)
        Me.Controls.Add(Me.lblrol)
        Me.Controls.Add(Me.btnclose)
        Me.Controls.Add(Me.lbltipou)
        Me.Controls.Add(Me.lbltitulo)
        Me.Controls.Add(Me.ltvgrupsindoc)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "repgrupsindoc"
        Me.Text = "S.I.B.A"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ltvgrupsindoc As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader7 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader4 As System.Windows.Forms.ColumnHeader
    Friend WithEvents lbltitulo As System.Windows.Forms.Label
    Friend WithEvents lblrol As System.Windows.Forms.Label
    Friend WithEvents btnclose As System.Windows.Forms.Button
    Friend WithEvents lbltipou As System.Windows.Forms.Label
    Friend WithEvents ColumnHeader5 As System.Windows.Forms.ColumnHeader
    Friend WithEvents btnatras As System.Windows.Forms.Button
    Friend WithEvents btnprint As System.Windows.Forms.Button
    Friend WithEvents lblfecha As System.Windows.Forms.Label
    Friend WithEvents lblrepgen As System.Windows.Forms.Label
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents btnmenu As System.Windows.Forms.Button
End Class
