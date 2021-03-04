<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form28
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
        Me.ListView1 = New System.Windows.Forms.ListView
        Me.Materia = New System.Windows.Forms.ColumnHeader
        Me.Año = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader2 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader3 = New System.Windows.Forms.ColumnHeader
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.SuspendLayout()
        '
        'ListView1
        '
        Me.ListView1.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.Materia, Me.Año, Me.ColumnHeader2, Me.ColumnHeader3})
        Me.ListView1.Items.AddRange(New System.Windows.Forms.ListViewItem() {ListViewItem1, ListViewItem2, ListViewItem3, ListViewItem4, ListViewItem5, ListViewItem6, ListViewItem7, ListViewItem8, ListViewItem9, ListViewItem10, ListViewItem11})
        Me.ListView1.Location = New System.Drawing.Point(40, 41)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(451, 184)
        Me.ListView1.TabIndex = 0
        Me.ListView1.UseCompatibleStateImageBehavior = False
        Me.ListView1.View = System.Windows.Forms.View.Details
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
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Tipo_Mat"
        Me.ColumnHeader2.Width = 78
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Tipo Salón"
        Me.ColumnHeader3.Width = 83
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(37, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(137, 16)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "3° EMT Informática"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(37, 228)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(140, 16)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Horas Teóricas: 18"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(37, 256)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(158, 16)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Horas Laboratorio: 14"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(37, 283)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(111, 16)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Horas Taller: 4"
        '
        'Form28
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(545, 308)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ListView1)
        Me.Name = "Form28"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ListView1 As System.Windows.Forms.ListView
    Friend WithEvents Materia As System.Windows.Forms.ColumnHeader
    Friend WithEvents Año As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label

End Class

