<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class asignarGrupo
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
        Dim ListViewItem1 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New String() {"001", "3", "I", "F", "Nocturno"}, -1, System.Drawing.Color.Empty, System.Drawing.SystemColors.Window, Nothing)
        Dim ListViewItem2 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New String() {"002", "3", "I", "G", "Nocturno"}, -1, System.Drawing.Color.Empty, System.Drawing.SystemColors.Window, Nothing)
        Dim ListViewItem3 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("")
        Dim ListViewItem4 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New String() {"Carambula Leonardo", "1234567"}, -1, System.Drawing.Color.Empty, System.Drawing.SystemColors.Window, Nothing)
        Dim ListViewItem5 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New String() {"Alvarellos, Danilo", "3456789"}, -1)
        Dim ListViewItem6 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New String() {"Inglés", "3", "Curricular", "Teórico"}, -1)
        Dim ListViewItem7 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New String() {"Matemática", "6", "Curricular", "Teórico"}, -1)
        Dim ListViewItem8 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New String() {"Sociología", "3", "Curricular", "Teórico"}, -1)
        Dim ListViewItem9 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New String() {"Filosofía", "3", "Curricular", "Teórico"}, -1)
        Dim ListViewItem10 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New String() {"Análisis y diseño de aplicaciones", "3", "Tecnológica", "Laboratorio"}, -1)
        Dim ListViewItem11 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New String() {"Programación", "3", "Tecnológica", "Laboratorio"}, -1)
        Dim ListViewItem12 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New String() {"Proyecto", "2", "Tecnológica", "Laboratorio"}, -1)
        Dim ListViewItem13 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New String() {"Sistema de base de datos", "3", "Tecnológica", "Laboratorio"}, -1, System.Drawing.Color.Empty, System.Drawing.SystemColors.Window, Nothing)
        Dim ListViewItem14 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New String() {"Sistemas operativos", "3", "Tecnológica", "Laboratorio"}, -1)
        Dim ListViewItem15 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New String() {"Taller de Mantenimiento", "4", "Tecnológica", "Taller"}, -1)
        Dim ListViewItem16 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New String() {"Formación Empresarial", "3", "Tecnológica", "Teórico"}, -1)
        Me.ltvgrupo = New System.Windows.Forms.ListView
        Me.ColumnHeader1 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader2 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader3 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader4 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader9 = New System.Windows.Forms.ColumnHeader
        Me.lbltitulo = New System.Windows.Forms.Label
        Me.ltvdoc = New System.Windows.Forms.ListView
        Me.ColumnHeader5 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader6 = New System.Windows.Forms.ColumnHeader
        Me.btnselec3 = New System.Windows.Forms.Button
        Me.lblgrupo = New System.Windows.Forms.Label
        Me.lbldoc = New System.Windows.Forms.Label
        Me.btnselec2 = New System.Windows.Forms.Button
        Me.lbldocee = New System.Windows.Forms.Label
        Me.lblgrupoe = New System.Windows.Forms.Label
        Me.btnselec1 = New System.Windows.Forms.Button
        Me.ltvmat = New System.Windows.Forms.ListView
        Me.Materia = New System.Windows.Forms.ColumnHeader
        Me.Año = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader7 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader8 = New System.Windows.Forms.ColumnHeader
        Me.lblmat = New System.Windows.Forms.Label
        Me.lblmate = New System.Windows.Forms.Label
        Me.btnatras = New System.Windows.Forms.Button
        Me.btnconf = New System.Windows.Forms.Button
        Me.lblrol = New System.Windows.Forms.Label
        Me.bnclose = New System.Windows.Forms.Button
        Me.lbltipou = New System.Windows.Forms.Label
        Me.lblfecha = New System.Windows.Forms.Label
        Me.lblfechaa = New System.Windows.Forms.Label
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.SuspendLayout()
        '
        'ltvgrupo
        '
        Me.ltvgrupo.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader4, Me.ColumnHeader9})
        Me.ltvgrupo.FullRowSelect = True
        Me.ltvgrupo.GridLines = True
        Me.ltvgrupo.Items.AddRange(New System.Windows.Forms.ListViewItem() {ListViewItem1, ListViewItem2, ListViewItem3})
        Me.ltvgrupo.Location = New System.Drawing.Point(282, 73)
        Me.ltvgrupo.Name = "ltvgrupo"
        Me.ltvgrupo.Size = New System.Drawing.Size(285, 175)
        Me.ltvgrupo.TabIndex = 28
        Me.ltvgrupo.UseCompatibleStateImageBehavior = False
        Me.ltvgrupo.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Código"
        Me.ColumnHeader1.Width = 56
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Año"
        Me.ColumnHeader2.Width = 55
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Curso"
        Me.ColumnHeader3.Width = 50
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "Letra"
        '
        'ColumnHeader9
        '
        Me.ColumnHeader9.Text = "Turno"
        '
        'lbltitulo
        '
        Me.lbltitulo.AutoSize = True
        Me.lbltitulo.BackColor = System.Drawing.Color.LemonChiffon
        Me.lbltitulo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbltitulo.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltitulo.Location = New System.Drawing.Point(12, 9)
        Me.lbltitulo.Name = "lbltitulo"
        Me.lbltitulo.Size = New System.Drawing.Size(306, 26)
        Me.lbltitulo.TabIndex = 53
        Me.lbltitulo.Text = "ASIGNAR GRUPO A DOCENTE"
        '
        'ltvdoc
        '
        Me.ltvdoc.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader5, Me.ColumnHeader6})
        Me.ltvdoc.FullRowSelect = True
        Me.ltvdoc.GridLines = True
        Me.ltvdoc.Items.AddRange(New System.Windows.Forms.ListViewItem() {ListViewItem4, ListViewItem5})
        Me.ltvdoc.Location = New System.Drawing.Point(18, 73)
        Me.ltvdoc.Name = "ltvdoc"
        Me.ltvdoc.Size = New System.Drawing.Size(227, 175)
        Me.ltvdoc.TabIndex = 54
        Me.ltvdoc.UseCompatibleStateImageBehavior = False
        Me.ltvdoc.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "Apellido Nombre"
        Me.ColumnHeader5.Width = 129
        '
        'ColumnHeader6
        '
        Me.ColumnHeader6.Text = "CI"
        Me.ColumnHeader6.Width = 95
        '
        'btnselec3
        '
        Me.btnselec3.Location = New System.Drawing.Point(12, 273)
        Me.btnselec3.Name = "btnselec3"
        Me.btnselec3.Size = New System.Drawing.Size(121, 28)
        Me.btnselec3.TabIndex = 55
        Me.btnselec3.Text = "Seleccionar"
        Me.btnselec3.UseVisualStyleBackColor = True
        '
        'lblgrupo
        '
        Me.lblgrupo.AutoSize = True
        Me.lblgrupo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblgrupo.Location = New System.Drawing.Point(279, 54)
        Me.lblgrupo.Name = "lblgrupo"
        Me.lblgrupo.Size = New System.Drawing.Size(54, 16)
        Me.lblgrupo.TabIndex = 56
        Me.lblgrupo.Text = "Grupo:"
        '
        'lbldoc
        '
        Me.lbldoc.AutoSize = True
        Me.lbldoc.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbldoc.Location = New System.Drawing.Point(12, 54)
        Me.lbldoc.Name = "lbldoc"
        Me.lbldoc.Size = New System.Drawing.Size(70, 16)
        Me.lbldoc.TabIndex = 57
        Me.lbldoc.Text = "Docente:"
        '
        'btnselec2
        '
        Me.btnselec2.Location = New System.Drawing.Point(282, 273)
        Me.btnselec2.Name = "btnselec2"
        Me.btnselec2.Size = New System.Drawing.Size(121, 28)
        Me.btnselec2.TabIndex = 58
        Me.btnselec2.Text = "Seleccionar"
        Me.btnselec2.UseVisualStyleBackColor = True
        '
        'lbldocee
        '
        Me.lbldocee.AutoSize = True
        Me.lbldocee.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbldocee.Location = New System.Drawing.Point(88, 54)
        Me.lbldocee.Name = "lbldocee"
        Me.lbldocee.Size = New System.Drawing.Size(0, 16)
        Me.lbldocee.TabIndex = 59
        '
        'lblgrupoe
        '
        Me.lblgrupoe.AutoSize = True
        Me.lblgrupoe.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblgrupoe.Location = New System.Drawing.Point(88, 73)
        Me.lblgrupoe.Name = "lblgrupoe"
        Me.lblgrupoe.Size = New System.Drawing.Size(31, 16)
        Me.lblgrupoe.TabIndex = 60
        Me.lblgrupoe.Text = "3IG"
        '
        'btnselec1
        '
        Me.btnselec1.Location = New System.Drawing.Point(197, 317)
        Me.btnselec1.Name = "btnselec1"
        Me.btnselec1.Size = New System.Drawing.Size(121, 28)
        Me.btnselec1.TabIndex = 61
        Me.btnselec1.Text = "Seleccionar"
        Me.btnselec1.UseVisualStyleBackColor = True
        '
        'ltvmat
        '
        Me.ltvmat.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.Materia, Me.Año, Me.ColumnHeader7, Me.ColumnHeader8})
        Me.ltvmat.FullRowSelect = True
        Me.ltvmat.Items.AddRange(New System.Windows.Forms.ListViewItem() {ListViewItem6, ListViewItem7, ListViewItem8, ListViewItem9, ListViewItem10, ListViewItem11, ListViewItem12, ListViewItem13, ListViewItem14, ListViewItem15, ListViewItem16})
        Me.ltvmat.Location = New System.Drawing.Point(226, 307)
        Me.ltvmat.Name = "ltvmat"
        Me.ltvmat.Size = New System.Drawing.Size(451, 184)
        Me.ltvmat.TabIndex = 62
        Me.ltvmat.UseCompatibleStateImageBehavior = False
        Me.ltvmat.View = System.Windows.Forms.View.Details
        '
        'Materia
        '
        Me.Materia.Text = "Materia"
        Me.Materia.Width = 169
        '
        'Año
        '
        Me.Año.Text = "Carga horaria"
        Me.Año.Width = 77
        '
        'ColumnHeader7
        '
        Me.ColumnHeader7.Text = "Tipo_Mat"
        Me.ColumnHeader7.Width = 78
        '
        'ColumnHeader8
        '
        Me.ColumnHeader8.Text = "Tipo Salón"
        Me.ColumnHeader8.Width = 83
        '
        'lblmat
        '
        Me.lblmat.AutoSize = True
        Me.lblmat.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblmat.Location = New System.Drawing.Point(12, 98)
        Me.lblmat.Name = "lblmat"
        Me.lblmat.Size = New System.Drawing.Size(64, 16)
        Me.lblmat.TabIndex = 63
        Me.lblmat.Text = "Materia:"
        '
        'lblmate
        '
        Me.lblmate.AutoSize = True
        Me.lblmate.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblmate.Location = New System.Drawing.Point(88, 98)
        Me.lblmate.Name = "lblmate"
        Me.lblmate.Size = New System.Drawing.Size(207, 16)
        Me.lblmate.TabIndex = 64
        Me.lblmate.Text = "Sistema de Base de datos III"
        '
        'btnatras
        '
        Me.btnatras.Location = New System.Drawing.Point(12, 317)
        Me.btnatras.Name = "btnatras"
        Me.btnatras.Size = New System.Drawing.Size(121, 28)
        Me.btnatras.TabIndex = 65
        Me.btnatras.Text = "Finalizar"
        Me.btnatras.UseVisualStyleBackColor = True
        '
        'btnconf
        '
        Me.btnconf.Location = New System.Drawing.Point(12, 273)
        Me.btnconf.Name = "btnconf"
        Me.btnconf.Size = New System.Drawing.Size(121, 28)
        Me.btnconf.TabIndex = 66
        Me.btnconf.Text = "Ingresar"
        Me.btnconf.UseVisualStyleBackColor = True
        '
        'lblrol
        '
        Me.lblrol.AutoSize = True
        Me.lblrol.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblrol.Location = New System.Drawing.Point(411, 9)
        Me.lblrol.Name = "lblrol"
        Me.lblrol.Size = New System.Drawing.Size(36, 16)
        Me.lblrol.TabIndex = 144
        Me.lblrol.Text = "Rol:"
        '
        'bnclose
        '
        Me.bnclose.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.bnclose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bnclose.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bnclose.Location = New System.Drawing.Point(475, 28)
        Me.bnclose.Name = "bnclose"
        Me.bnclose.Size = New System.Drawing.Size(105, 24)
        Me.bnclose.TabIndex = 143
        Me.bnclose.Text = "Cerrar sesión"
        Me.bnclose.UseVisualStyleBackColor = True
        '
        'lbltipou
        '
        Me.lbltipou.AutoSize = True
        Me.lbltipou.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltipou.Location = New System.Drawing.Point(443, 9)
        Me.lbltipou.Name = "lbltipou"
        Me.lbltipou.Size = New System.Drawing.Size(137, 16)
        Me.lbltipou.TabIndex = 142
        Me.lbltipou.Text = "Secretario Escolar"
        '
        'lblfecha
        '
        Me.lblfecha.AutoSize = True
        Me.lblfecha.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblfecha.Location = New System.Drawing.Point(12, 123)
        Me.lblfecha.Name = "lblfecha"
        Me.lblfecha.Size = New System.Drawing.Size(55, 16)
        Me.lblfecha.TabIndex = 146
        Me.lblfecha.Text = "Fecha:"
        '
        'lblfechaa
        '
        Me.lblfechaa.AutoSize = True
        Me.lblfechaa.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblfechaa.Location = New System.Drawing.Point(88, 123)
        Me.lblfechaa.Name = "lblfechaa"
        Me.lblfechaa.Size = New System.Drawing.Size(0, 16)
        Me.lblfechaa.TabIndex = 147
        '
        'asignarGrupo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(592, 357)
        Me.Controls.Add(Me.lblfechaa)
        Me.Controls.Add(Me.lblfecha)
        Me.Controls.Add(Me.lblrol)
        Me.Controls.Add(Me.bnclose)
        Me.Controls.Add(Me.lbltipou)
        Me.Controls.Add(Me.btnconf)
        Me.Controls.Add(Me.btnatras)
        Me.Controls.Add(Me.lblmate)
        Me.Controls.Add(Me.lblmat)
        Me.Controls.Add(Me.ltvmat)
        Me.Controls.Add(Me.btnselec1)
        Me.Controls.Add(Me.lblgrupoe)
        Me.Controls.Add(Me.lbldocee)
        Me.Controls.Add(Me.btnselec2)
        Me.Controls.Add(Me.lbldoc)
        Me.Controls.Add(Me.lblgrupo)
        Me.Controls.Add(Me.btnselec3)
        Me.Controls.Add(Me.ltvdoc)
        Me.Controls.Add(Me.lbltitulo)
        Me.Controls.Add(Me.ltvgrupo)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "asignarGrupo"
        Me.Text = "S.I.B.A."
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ltvgrupo As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader4 As System.Windows.Forms.ColumnHeader
    Friend WithEvents lbltitulo As System.Windows.Forms.Label
    Friend WithEvents ltvdoc As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader5 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader6 As System.Windows.Forms.ColumnHeader
    Friend WithEvents btnselec3 As System.Windows.Forms.Button
    Friend WithEvents lblgrupo As System.Windows.Forms.Label
    Friend WithEvents lbldoc As System.Windows.Forms.Label
    Friend WithEvents btnselec2 As System.Windows.Forms.Button
    Friend WithEvents lbldocee As System.Windows.Forms.Label
    Friend WithEvents lblgrupoe As System.Windows.Forms.Label
    Friend WithEvents btnselec1 As System.Windows.Forms.Button
    Friend WithEvents ltvmat As System.Windows.Forms.ListView
    Friend WithEvents Materia As System.Windows.Forms.ColumnHeader
    Friend WithEvents Año As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader7 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader8 As System.Windows.Forms.ColumnHeader
    Friend WithEvents lblmat As System.Windows.Forms.Label
    Friend WithEvents lblmate As System.Windows.Forms.Label
    Friend WithEvents btnatras As System.Windows.Forms.Button
    Friend WithEvents btnconf As System.Windows.Forms.Button
    Friend WithEvents lblrol As System.Windows.Forms.Label
    Friend WithEvents bnclose As System.Windows.Forms.Button
    Friend WithEvents lbltipou As System.Windows.Forms.Label
    Friend WithEvents lblfecha As System.Windows.Forms.Label
    Friend WithEvents lblfechaa As System.Windows.Forms.Label
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents ColumnHeader9 As System.Windows.Forms.ColumnHeader
End Class
