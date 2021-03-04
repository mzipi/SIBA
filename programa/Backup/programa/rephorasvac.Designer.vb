<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class rephorasvac
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
        Dim ListViewItem1 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New String() {"1°IL", "1,2,3", "Jueves", "19:15", "2O:55", "Electricidad I", "Enfermedad"}, -1)
        Dim ListViewItem2 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New String() {"1°IM", "4,5,6", "Jueves", "21:55", "23:15", "Electricidad I", "Enfermedad"}, -1)
        Dim ListViewItem3 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New String() {"2°IH", "1,2,3", "Jueves", "19:15", "20:55", "Sist de Base de Datos I", "Art.76"}, -1)
        Me.lbltitulo = New System.Windows.Forms.Label
        Me.lblrol = New System.Windows.Forms.Label
        Me.btnclose = New System.Windows.Forms.Button
        Me.lbltipou = New System.Windows.Forms.Label
        Me.lblrepgen = New System.Windows.Forms.Label
        Me.lblfecha = New System.Windows.Forms.Label
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.btnatras = New System.Windows.Forms.Button
        Me.btnprint = New System.Windows.Forms.Button
        Me.ltvrepgen = New System.Windows.Forms.ListView
        Me.ColumnHeader1 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader2 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader7 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader3 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader4 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader5 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader6 = New System.Windows.Forms.ColumnHeader
        Me.btnmenu = New System.Windows.Forms.Button
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
        Me.lbltitulo.Size = New System.Drawing.Size(305, 26)
        Me.lbltitulo.TabIndex = 177
        Me.lbltitulo.Text = "REPORTE HORAS VACANTES"
        '
        'lblrol
        '
        Me.lblrol.AutoSize = True
        Me.lblrol.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblrol.Location = New System.Drawing.Point(599, 9)
        Me.lblrol.Name = "lblrol"
        Me.lblrol.Size = New System.Drawing.Size(36, 16)
        Me.lblrol.TabIndex = 182
        Me.lblrol.Text = "Rol:"
        '
        'btnclose
        '
        Me.btnclose.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnclose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnclose.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnclose.Location = New System.Drawing.Point(665, 28)
        Me.btnclose.Name = "btnclose"
        Me.btnclose.Size = New System.Drawing.Size(102, 24)
        Me.btnclose.TabIndex = 181
        Me.btnclose.Text = "Cerrar sesión"
        Me.btnclose.UseVisualStyleBackColor = True
        '
        'lbltipou
        '
        Me.lbltipou.AutoSize = True
        Me.lbltipou.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltipou.Location = New System.Drawing.Point(638, 9)
        Me.lbltipou.Name = "lbltipou"
        Me.lbltipou.Size = New System.Drawing.Size(136, 16)
        Me.lbltipou.TabIndex = 180
        Me.lbltipou.Text = "Secretario escolar"
        '
        'lblrepgen
        '
        Me.lblrepgen.AutoSize = True
        Me.lblrepgen.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblrepgen.Location = New System.Drawing.Point(12, 56)
        Me.lblrepgen.Name = "lblrepgen"
        Me.lblrepgen.Size = New System.Drawing.Size(178, 16)
        Me.lblrepgen.TabIndex = 187
        Me.lblrepgen.Text = "REPORTE GENERADO: "
        '
        'lblfecha
        '
        Me.lblfecha.AutoSize = True
        Me.lblfecha.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblfecha.Location = New System.Drawing.Point(252, 56)
        Me.lblfecha.Name = "lblfecha"
        Me.lblfecha.Size = New System.Drawing.Size(0, 16)
        Me.lblfecha.TabIndex = 186
        '
        'Timer1
        '
        '
        'btnatras
        '
        Me.btnatras.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnatras.Location = New System.Drawing.Point(602, 235)
        Me.btnatras.Name = "btnatras"
        Me.btnatras.Size = New System.Drawing.Size(123, 27)
        Me.btnatras.TabIndex = 189
        Me.btnatras.Text = "Atrás"
        Me.btnatras.UseVisualStyleBackColor = True
        '
        'btnprint
        '
        Me.btnprint.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnprint.Location = New System.Drawing.Point(602, 202)
        Me.btnprint.Name = "btnprint"
        Me.btnprint.Size = New System.Drawing.Size(123, 27)
        Me.btnprint.TabIndex = 188
        Me.btnprint.Text = "Imprimir Reporte"
        Me.btnprint.UseVisualStyleBackColor = True
        '
        'ltvrepgen
        '
        Me.ltvrepgen.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader7, Me.ColumnHeader3, Me.ColumnHeader4, Me.ColumnHeader5, Me.ColumnHeader6})
        Me.ltvrepgen.GridLines = True
        Me.ltvrepgen.Items.AddRange(New System.Windows.Forms.ListViewItem() {ListViewItem1, ListViewItem2, ListViewItem3})
        Me.ltvrepgen.Location = New System.Drawing.Point(12, 89)
        Me.ltvrepgen.Name = "ltvrepgen"
        Me.ltvrepgen.Size = New System.Drawing.Size(557, 212)
        Me.ltvrepgen.TabIndex = 191
        Me.ltvrepgen.UseCompatibleStateImageBehavior = False
        Me.ltvrepgen.View = System.Windows.Forms.View.Details
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
        'ColumnHeader6
        '
        Me.ColumnHeader6.Text = "Estado Funcional"
        Me.ColumnHeader6.Width = 99
        '
        'btnmenu
        '
        Me.btnmenu.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnmenu.Location = New System.Drawing.Point(602, 274)
        Me.btnmenu.Name = "btnmenu"
        Me.btnmenu.Size = New System.Drawing.Size(123, 27)
        Me.btnmenu.TabIndex = 192
        Me.btnmenu.Text = "MENÚ REPORTES"
        Me.btnmenu.UseVisualStyleBackColor = True
        '
        'rephorasvac
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(779, 337)
        Me.Controls.Add(Me.btnmenu)
        Me.Controls.Add(Me.ltvrepgen)
        Me.Controls.Add(Me.btnatras)
        Me.Controls.Add(Me.btnprint)
        Me.Controls.Add(Me.lblrepgen)
        Me.Controls.Add(Me.lblfecha)
        Me.Controls.Add(Me.lblrol)
        Me.Controls.Add(Me.btnclose)
        Me.Controls.Add(Me.lbltipou)
        Me.Controls.Add(Me.lbltitulo)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "rephorasvac"
        Me.Text = "S.I.B.A"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lbltitulo As System.Windows.Forms.Label
    Friend WithEvents lblrol As System.Windows.Forms.Label
    Friend WithEvents btnclose As System.Windows.Forms.Button
    Friend WithEvents lbltipou As System.Windows.Forms.Label
    Friend WithEvents lblrepgen As System.Windows.Forms.Label
    Friend WithEvents lblfecha As System.Windows.Forms.Label
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents btnatras As System.Windows.Forms.Button
    Friend WithEvents btnprint As System.Windows.Forms.Button
    Friend WithEvents ltvrepgen As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader7 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader4 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader5 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader6 As System.Windows.Forms.ColumnHeader
    Friend WithEvents btnmenu As System.Windows.Forms.Button
End Class
