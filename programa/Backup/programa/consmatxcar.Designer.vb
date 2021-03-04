<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class consmatxcar
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
        Dim ListViewItem1 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New String() {"Inglés", "3", "Curricular", "Teórico"}, -1)
        Dim ListViewItem2 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New String() {"Matemática", "6", "Curricular", "Teórico"}, -1)
        Dim ListViewItem3 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New String() {"Sociología", "3", "Curricular", "Teórico"}, -1)
        Dim ListViewItem4 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New String() {"Filosofía", "3", "Curricular", "Teórico"}, -1)
        Dim ListViewItem5 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New String() {"Análisis y diseño de aplicaciones", "3", "Tecnológica", "Laboratorio"}, -1)
        Dim ListViewItem6 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New String() {"Programación", "3", "Tecnológica", "Laboratorio"}, -1)
        Dim ListViewItem7 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New String() {"Proyecto", "2", "Tecnológica", "Laboratorio"}, -1)
        Dim ListViewItem8 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New String() {"Sistema de base de datos", "3", "Tecnológica", "Laboratorio"}, -1)
        Dim ListViewItem9 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New String() {"Sistemas operativos", "3", "Tecnológica", "Laboratorio"}, -1)
        Dim ListViewItem10 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New String() {"Taller de Mantenimiento", "4", "Tecnológica", "Taller"}, -1)
        Dim ListViewItem11 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New String() {"Formación Empresarial", "3", "Tecnológica", "Teórico"}, -1)
        Me.lbltitulo = New System.Windows.Forms.Label
        Me.gbxsel = New System.Windows.Forms.GroupBox
        Me.Button5 = New System.Windows.Forms.Button
        Me.cmbaño = New System.Windows.Forms.ComboBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.cmbcarr = New System.Windows.Forms.ComboBox
        Me.lblrol = New System.Windows.Forms.Label
        Me.Button3 = New System.Windows.Forms.Button
        Me.lbltipou = New System.Windows.Forms.Label
        Me.btnatras = New System.Windows.Forms.Button
        Me.ltvmat = New System.Windows.Forms.ListView
        Me.Materia = New System.Windows.Forms.ColumnHeader
        Me.Año = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader2 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader3 = New System.Windows.Forms.ColumnHeader
        Me.gbxdatos = New System.Windows.Forms.GroupBox
        Me.lblañosel = New System.Windows.Forms.Label
        Me.lblturno = New System.Windows.Forms.Label
        Me.lblcarsel = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.gbxsel.SuspendLayout()
        Me.gbxdatos.SuspendLayout()
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
        Me.lbltitulo.Size = New System.Drawing.Size(266, 26)
        Me.lbltitulo.TabIndex = 50
        Me.lbltitulo.Text = "CONSULTA DE MATERIAS"
        '
        'gbxsel
        '
        Me.gbxsel.Controls.Add(Me.Button5)
        Me.gbxsel.Controls.Add(Me.cmbaño)
        Me.gbxsel.Controls.Add(Me.Label2)
        Me.gbxsel.Controls.Add(Me.Label3)
        Me.gbxsel.Controls.Add(Me.cmbcarr)
        Me.gbxsel.Location = New System.Drawing.Point(12, 59)
        Me.gbxsel.Name = "gbxsel"
        Me.gbxsel.Size = New System.Drawing.Size(287, 194)
        Me.gbxsel.TabIndex = 162
        Me.gbxsel.TabStop = False
        Me.gbxsel.Text = "Seleccionar"
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(190, 138)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(70, 26)
        Me.Button5.TabIndex = 156
        Me.Button5.Text = "Ingresar"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'cmbaño
        '
        Me.cmbaño.FormattingEnabled = True
        Me.cmbaño.Items.AddRange(New Object() {"(Seleccione)", "1°", "2°", "3°"})
        Me.cmbaño.Location = New System.Drawing.Point(23, 100)
        Me.cmbaño.Name = "cmbaño"
        Me.cmbaño.Size = New System.Drawing.Size(237, 21)
        Me.cmbaño.TabIndex = 155
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(23, 68)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(201, 16)
        Me.Label2.TabIndex = 154
        Me.Label2.Text = "Seleccione el año curricular"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(23, 16)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(237, 16)
        Me.Label3.TabIndex = 150
        Me.Label3.Text = "Seleccione la carrera a consultar"
        '
        'cmbcarr
        '
        Me.cmbcarr.FormattingEnabled = True
        Me.cmbcarr.Items.AddRange(New Object() {"(Seleccione)", "EMT INFORMÁTICA", "EMT ADMINISTRACIÓN", "EMP ADMINISTRACIÓN", "TECNICATURA EN REDES"})
        Me.cmbcarr.Location = New System.Drawing.Point(23, 35)
        Me.cmbcarr.Name = "cmbcarr"
        Me.cmbcarr.Size = New System.Drawing.Size(237, 21)
        Me.cmbcarr.TabIndex = 151
        '
        'lblrol
        '
        Me.lblrol.AutoSize = True
        Me.lblrol.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblrol.Location = New System.Drawing.Point(456, 9)
        Me.lblrol.Name = "lblrol"
        Me.lblrol.Size = New System.Drawing.Size(36, 16)
        Me.lblrol.TabIndex = 168
        Me.lblrol.Text = "Rol:"
        '
        'Button3
        '
        Me.Button3.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Location = New System.Drawing.Point(508, 28)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(102, 24)
        Me.Button3.TabIndex = 167
        Me.Button3.Text = "Cerrar sesión"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'lbltipou
        '
        Me.lbltipou.AutoSize = True
        Me.lbltipou.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltipou.Location = New System.Drawing.Point(498, 9)
        Me.lbltipou.Name = "lbltipou"
        Me.lbltipou.Size = New System.Drawing.Size(0, 16)
        Me.lbltipou.TabIndex = 166
        '
        'btnatras
        '
        Me.btnatras.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnatras.Location = New System.Drawing.Point(465, 308)
        Me.btnatras.Name = "btnatras"
        Me.btnatras.Size = New System.Drawing.Size(138, 26)
        Me.btnatras.TabIndex = 169
        Me.btnatras.Text = "ATRÁS"
        Me.btnatras.UseVisualStyleBackColor = True
        '
        'ltvmat
        '
        Me.ltvmat.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.Materia, Me.Año, Me.ColumnHeader2, Me.ColumnHeader3})
        Me.ltvmat.Items.AddRange(New System.Windows.Forms.ListViewItem() {ListViewItem1, ListViewItem2, ListViewItem3, ListViewItem4, ListViewItem5, ListViewItem6, ListViewItem7, ListViewItem8, ListViewItem9, ListViewItem10, ListViewItem11})
        Me.ltvmat.Location = New System.Drawing.Point(-13, 259)
        Me.ltvmat.Name = "ltvmat"
        Me.ltvmat.Size = New System.Drawing.Size(428, 203)
        Me.ltvmat.TabIndex = 171
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
        Me.Año.Width = 82
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Tipo_Mat"
        Me.ColumnHeader2.Width = 78
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Tipo Salón"
        Me.ColumnHeader3.Width = 95
        '
        'gbxdatos
        '
        Me.gbxdatos.Controls.Add(Me.lblañosel)
        Me.gbxdatos.Controls.Add(Me.lblturno)
        Me.gbxdatos.Controls.Add(Me.lblcarsel)
        Me.gbxdatos.Controls.Add(Me.Label1)
        Me.gbxdatos.Location = New System.Drawing.Point(59, 46)
        Me.gbxdatos.Name = "gbxdatos"
        Me.gbxdatos.Size = New System.Drawing.Size(433, 45)
        Me.gbxdatos.TabIndex = 172
        Me.gbxdatos.TabStop = False
        Me.gbxdatos.Text = "Consulta"
        '
        'lblañosel
        '
        Me.lblañosel.AutoSize = True
        Me.lblañosel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblañosel.Location = New System.Drawing.Point(314, 23)
        Me.lblañosel.Name = "lblañosel"
        Me.lblañosel.Size = New System.Drawing.Size(0, 16)
        Me.lblañosel.TabIndex = 166
        '
        'lblturno
        '
        Me.lblturno.AutoSize = True
        Me.lblturno.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblturno.Location = New System.Drawing.Point(269, 23)
        Me.lblturno.Name = "lblturno"
        Me.lblturno.Size = New System.Drawing.Size(39, 16)
        Me.lblturno.TabIndex = 165
        Me.lblturno.Text = "Año:"
        '
        'lblcarsel
        '
        Me.lblcarsel.AutoSize = True
        Me.lblcarsel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblcarsel.Location = New System.Drawing.Point(77, 23)
        Me.lblcarsel.Name = "lblcarsel"
        Me.lblcarsel.Size = New System.Drawing.Size(0, 16)
        Me.lblcarsel.TabIndex = 162
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(7, 23)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(64, 16)
        Me.Label1.TabIndex = 161
        Me.Label1.Text = "Carrera:"
        '
        'consmatxcar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(620, 356)
        Me.Controls.Add(Me.gbxdatos)
        Me.Controls.Add(Me.ltvmat)
        Me.Controls.Add(Me.btnatras)
        Me.Controls.Add(Me.lblrol)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.lbltipou)
        Me.Controls.Add(Me.gbxsel)
        Me.Controls.Add(Me.lbltitulo)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "consmatxcar"
        Me.Text = "S.I.B.A"
        Me.gbxsel.ResumeLayout(False)
        Me.gbxsel.PerformLayout()
        Me.gbxdatos.ResumeLayout(False)
        Me.gbxdatos.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lbltitulo As System.Windows.Forms.Label
    Friend WithEvents gbxsel As System.Windows.Forms.GroupBox
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents cmbaño As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents cmbcarr As System.Windows.Forms.ComboBox
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents lbltipou As System.Windows.Forms.Label
    Friend WithEvents btnatras As System.Windows.Forms.Button
    Friend WithEvents ltvmat As System.Windows.Forms.ListView
    Friend WithEvents Materia As System.Windows.Forms.ColumnHeader
    Friend WithEvents Año As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents lblrol As System.Windows.Forms.Label
    Friend WithEvents gbxdatos As System.Windows.Forms.GroupBox
    Friend WithEvents lblañosel As System.Windows.Forms.Label
    Friend WithEvents lblturno As System.Windows.Forms.Label
    Friend WithEvents lblcarsel As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
