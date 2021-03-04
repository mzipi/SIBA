<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class asignhoramat
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
        Dim ListViewItem8 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New String() {"Sistema de base de datos", "3", "Tecnológica", "Laboratorio"}, -1, System.Drawing.Color.Empty, System.Drawing.SystemColors.Window, Nothing)
        Dim ListViewItem9 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New String() {"Sistemas operativos", "3", "Tecnológica", "Laboratorio"}, -1)
        Dim ListViewItem10 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New String() {"Taller de Mantenimiento", "4", "Tecnológica", "Taller"}, -1)
        Dim ListViewItem11 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New String() {"Formación Empresarial", "3", "Tecnológica", "Teórico"}, -1)
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.lbldiasel = New System.Windows.Forms.Label
        Me.btnsel = New System.Windows.Forms.Button
        Me.ltvmat = New System.Windows.Forms.ListView
        Me.Materia = New System.Windows.Forms.ColumnHeader
        Me.Año = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader7 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader8 = New System.Windows.Forms.ColumnHeader
        Me.Label5 = New System.Windows.Forms.Label
        Me.lblmatsel = New System.Windows.Forms.Label
        Me.btnatras = New System.Windows.Forms.Button
        Me.btnconf = New System.Windows.Forms.Button
        Me.Label8 = New System.Windows.Forms.Label
        Me.Button6 = New System.Windows.Forms.Button
        Me.Label9 = New System.Windows.Forms.Label
        Me.lbldia = New System.Windows.Forms.Label
        Me.lblgrupsel = New System.Windows.Forms.Label
        Me.Label12 = New System.Windows.Forms.Label
        Me.cmbcarrera = New System.Windows.Forms.ComboBox
        Me.gbxsel = New System.Windows.Forms.GroupBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.cmbgrupoele = New System.Windows.Forms.ComboBox
        Me.txtnum = New System.Windows.Forms.TextBox
        Me.cmbdia = New System.Windows.Forms.ComboBox
        Me.Label14 = New System.Windows.Forms.Label
        Me.Button7 = New System.Windows.Forms.Button
        Me.cmbgrupo = New System.Windows.Forms.Label
        Me.lblhora = New System.Windows.Forms.Label
        Me.lblhorassel = New System.Windows.Forms.Label
        Me.gbxsel.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.LemonChiffon
        Me.Label6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(12, 9)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(297, 26)
        Me.Label6.TabIndex = 53
        Me.Label6.Text = "ASIGNAR HORAS A MATERIA"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 77)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(54, 16)
        Me.Label1.TabIndex = 56
        Me.Label1.Text = "Grupo:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(147, 54)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(54, 16)
        Me.Label2.TabIndex = 57
        Me.Label2.Text = "Horas:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(88, 54)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(40, 16)
        Me.Label3.TabIndex = 59
        Me.Label3.Text = "1,2,3"
        '
        'lbldiasel
        '
        Me.lbldiasel.AutoSize = True
        Me.lbldiasel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbldiasel.Location = New System.Drawing.Point(88, 100)
        Me.lbldiasel.Name = "lbldiasel"
        Me.lbldiasel.Size = New System.Drawing.Size(49, 16)
        Me.lbldiasel.TabIndex = 60
        Me.lbldiasel.Text = "Lunes"
        '
        'btnsel
        '
        Me.btnsel.Location = New System.Drawing.Point(168, 273)
        Me.btnsel.Name = "btnsel"
        Me.btnsel.Size = New System.Drawing.Size(121, 28)
        Me.btnsel.TabIndex = 61
        Me.btnsel.Text = "Seleccionar"
        Me.btnsel.UseVisualStyleBackColor = True
        '
        'ltvmat
        '
        Me.ltvmat.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.Materia, Me.Año, Me.ColumnHeader7, Me.ColumnHeader8})
        Me.ltvmat.FullRowSelect = True
        Me.ltvmat.Items.AddRange(New System.Windows.Forms.ListViewItem() {ListViewItem1, ListViewItem2, ListViewItem3, ListViewItem4, ListViewItem5, ListViewItem6, ListViewItem7, ListViewItem8, ListViewItem9, ListViewItem10, ListViewItem11})
        Me.ltvmat.Location = New System.Drawing.Point(12, 76)
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
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(12, 57)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(64, 16)
        Me.Label5.TabIndex = 63
        Me.Label5.Text = "Materia:"
        '
        'lblmatsel
        '
        Me.lblmatsel.AutoSize = True
        Me.lblmatsel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblmatsel.Location = New System.Drawing.Point(82, 57)
        Me.lblmatsel.Name = "lblmatsel"
        Me.lblmatsel.Size = New System.Drawing.Size(207, 16)
        Me.lblmatsel.TabIndex = 64
        Me.lblmatsel.Text = "Sistema de Base de datos III"
        '
        'btnatras
        '
        Me.btnatras.Location = New System.Drawing.Point(12, 317)
        Me.btnatras.Name = "btnatras"
        Me.btnatras.Size = New System.Drawing.Size(121, 28)
        Me.btnatras.TabIndex = 65
        Me.btnatras.Text = "Atrás"
        Me.btnatras.UseVisualStyleBackColor = True
        '
        'btnconf
        '
        Me.btnconf.Location = New System.Drawing.Point(16, 273)
        Me.btnconf.Name = "btnconf"
        Me.btnconf.Size = New System.Drawing.Size(121, 28)
        Me.btnconf.TabIndex = 66
        Me.btnconf.Text = "Confirmar"
        Me.btnconf.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(404, 9)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(36, 16)
        Me.Label8.TabIndex = 144
        Me.Label8.Text = "Rol:"
        '
        'Button6
        '
        Me.Button6.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button6.Location = New System.Drawing.Point(475, 28)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(105, 24)
        Me.Button6.TabIndex = 143
        Me.Button6.Text = "Cerrar sesión"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(443, 9)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(137, 16)
        Me.Label9.TabIndex = 142
        Me.Label9.Text = "Secretario Escolar"
        '
        'lbldia
        '
        Me.lbldia.AutoSize = True
        Me.lbldia.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbldia.Location = New System.Drawing.Point(12, 100)
        Me.lbldia.Name = "lbldia"
        Me.lbldia.Size = New System.Drawing.Size(44, 16)
        Me.lbldia.TabIndex = 145
        Me.lbldia.Text = "Días:"
        '
        'lblgrupsel
        '
        Me.lblgrupsel.AutoSize = True
        Me.lblgrupsel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblgrupsel.Location = New System.Drawing.Point(88, 77)
        Me.lblgrupsel.Name = "lblgrupsel"
        Me.lblgrupsel.Size = New System.Drawing.Size(36, 16)
        Me.lblgrupsel.TabIndex = 146
        Me.lblgrupsel.Text = "3°IG"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(12, 118)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(202, 16)
        Me.Label12.TabIndex = 158
        Me.Label12.Text = "Ingrese número/os de horas"
        '
        'cmbcarrera
        '
        Me.cmbcarrera.FormattingEnabled = True
        Me.cmbcarrera.Items.AddRange(New Object() {"(Seleccione)", "EMT Informática", "EMT Administración", "EMP Administración", "Tecnicatura en Redes"})
        Me.cmbcarrera.Location = New System.Drawing.Point(15, 35)
        Me.cmbcarrera.Name = "cmbcarrera"
        Me.cmbcarrera.Size = New System.Drawing.Size(237, 21)
        Me.cmbcarrera.TabIndex = 157
        '
        'gbxsel
        '
        Me.gbxsel.Controls.Add(Me.Label7)
        Me.gbxsel.Controls.Add(Me.cmbgrupoele)
        Me.gbxsel.Controls.Add(Me.txtnum)
        Me.gbxsel.Controls.Add(Me.cmbdia)
        Me.gbxsel.Controls.Add(Me.Label14)
        Me.gbxsel.Controls.Add(Me.Button7)
        Me.gbxsel.Controls.Add(Me.Label12)
        Me.gbxsel.Controls.Add(Me.cmbcarrera)
        Me.gbxsel.Controls.Add(Me.cmbgrupo)
        Me.gbxsel.Location = New System.Drawing.Point(316, 54)
        Me.gbxsel.Name = "gbxsel"
        Me.gbxsel.Size = New System.Drawing.Size(275, 253)
        Me.gbxsel.TabIndex = 160
        Me.gbxsel.TabStop = False
        Me.gbxsel.Text = "Seleccionar"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(12, 173)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(130, 16)
        Me.Label7.TabIndex = 165
        Me.Label7.Text = "Seleccione grupo"
        '
        'cmbgrupoele
        '
        Me.cmbgrupoele.FormattingEnabled = True
        Me.cmbgrupoele.Items.AddRange(New Object() {"(Seleccione)", "1°IF", "1°IG", "2°IA", "3°IF", ""})
        Me.cmbgrupoele.Location = New System.Drawing.Point(15, 192)
        Me.cmbgrupoele.Name = "cmbgrupoele"
        Me.cmbgrupoele.Size = New System.Drawing.Size(237, 21)
        Me.cmbgrupoele.TabIndex = 164
        '
        'txtnum
        '
        Me.txtnum.Location = New System.Drawing.Point(15, 138)
        Me.txtnum.MaxLength = 20
        Me.txtnum.Name = "txtnum"
        Me.txtnum.Size = New System.Drawing.Size(237, 20)
        Me.txtnum.TabIndex = 163
        '
        'cmbdia
        '
        Me.cmbdia.FormattingEnabled = True
        Me.cmbdia.Items.AddRange(New Object() {"(Seleccione)", "Lunes ", "Martes", "Miércoles", "Jueves", "Viernes", "Sabado"})
        Me.cmbdia.Location = New System.Drawing.Point(15, 82)
        Me.cmbdia.Name = "cmbdia"
        Me.cmbdia.Size = New System.Drawing.Size(237, 21)
        Me.cmbdia.TabIndex = 162
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(12, 63)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(112, 16)
        Me.Label14.TabIndex = 161
        Me.Label14.Text = "Seleccione día"
        '
        'Button7
        '
        Me.Button7.Location = New System.Drawing.Point(131, 219)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(121, 28)
        Me.Button7.TabIndex = 160
        Me.Button7.Text = "Continuar"
        Me.Button7.UseVisualStyleBackColor = True
        '
        'cmbgrupo
        '
        Me.cmbgrupo.AutoSize = True
        Me.cmbgrupo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbgrupo.Location = New System.Drawing.Point(12, 16)
        Me.cmbgrupo.Name = "cmbgrupo"
        Me.cmbgrupo.Size = New System.Drawing.Size(157, 16)
        Me.cmbgrupo.TabIndex = 156
        Me.cmbgrupo.Text = "Seleccione la carrera"
        '
        'lblhora
        '
        Me.lblhora.AutoSize = True
        Me.lblhora.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblhora.Location = New System.Drawing.Point(12, 126)
        Me.lblhora.Name = "lblhora"
        Me.lblhora.Size = New System.Drawing.Size(54, 16)
        Me.lblhora.TabIndex = 161
        Me.lblhora.Text = "Horas:"
        '
        'lblhorassel
        '
        Me.lblhorassel.AutoSize = True
        Me.lblhorassel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblhorassel.Location = New System.Drawing.Point(88, 126)
        Me.lblhorassel.Name = "lblhorassel"
        Me.lblhorassel.Size = New System.Drawing.Size(40, 16)
        Me.lblhorassel.TabIndex = 162
        Me.lblhorassel.Text = "1,2,3"
        '
        'asignhoramat
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(592, 357)
        Me.Controls.Add(Me.lblhorassel)
        Me.Controls.Add(Me.lblhora)
        Me.Controls.Add(Me.gbxsel)
        Me.Controls.Add(Me.lblgrupsel)
        Me.Controls.Add(Me.lbldia)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.ltvmat)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.btnconf)
        Me.Controls.Add(Me.btnatras)
        Me.Controls.Add(Me.lblmatsel)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.btnsel)
        Me.Controls.Add(Me.lbldiasel)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label6)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "asignhoramat"
        Me.Text = "S.I.B.A."
        Me.gbxsel.ResumeLayout(False)
        Me.gbxsel.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents lbldiasel As System.Windows.Forms.Label
    Friend WithEvents btnsel As System.Windows.Forms.Button
    Friend WithEvents ltvmat As System.Windows.Forms.ListView
    Friend WithEvents Materia As System.Windows.Forms.ColumnHeader
    Friend WithEvents Año As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader7 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader8 As System.Windows.Forms.ColumnHeader
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents lblmatsel As System.Windows.Forms.Label
    Friend WithEvents btnatras As System.Windows.Forms.Button
    Friend WithEvents btnconf As System.Windows.Forms.Button
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Button6 As System.Windows.Forms.Button
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents lbldia As System.Windows.Forms.Label
    Friend WithEvents lblgrupsel As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents cmbcarrera As System.Windows.Forms.ComboBox
    Friend WithEvents gbxsel As System.Windows.Forms.GroupBox
    Friend WithEvents Button7 As System.Windows.Forms.Button
    Friend WithEvents cmbdia As System.Windows.Forms.ComboBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents lblhora As System.Windows.Forms.Label
    Friend WithEvents lblhorassel As System.Windows.Forms.Label
    Friend WithEvents txtnum As System.Windows.Forms.TextBox
    Friend WithEvents cmbgrupo As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents cmbgrupoele As System.Windows.Forms.ComboBox
End Class
