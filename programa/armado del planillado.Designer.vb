<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class armado_del_planillado
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
        Me.dgvplanillado = New System.Windows.Forms.DataGridView
        Me.lbltitulo = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.ComboBox1 = New System.Windows.Forms.ComboBox
        Me.Button1 = New System.Windows.Forms.Button
        Me.txb = New System.Windows.Forms.TextBox
        Me.ltvplanillado = New System.Windows.Forms.ListView
        Me.ColumnHeader1 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader2 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader3 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader4 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader5 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader6 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader7 = New System.Windows.Forms.ColumnHeader
        CType(Me.dgvplanillado, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvplanillado
        '
        Me.dgvplanillado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvplanillado.Location = New System.Drawing.Point(225, 77)
        Me.dgvplanillado.Name = "dgvplanillado"
        Me.dgvplanillado.Size = New System.Drawing.Size(332, 134)
        Me.dgvplanillado.TabIndex = 0
        '
        'lbltitulo
        '
        Me.lbltitulo.AutoSize = True
        Me.lbltitulo.BackColor = System.Drawing.Color.LemonChiffon
        Me.lbltitulo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbltitulo.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltitulo.Location = New System.Drawing.Point(12, 9)
        Me.lbltitulo.Name = "lbltitulo"
        Me.lbltitulo.Size = New System.Drawing.Size(283, 26)
        Me.lbltitulo.TabIndex = 53
        Me.lbltitulo.Text = "PLANILLADO DE HORARIOS"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Bookman Old Style", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(22, 61)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(64, 19)
        Me.Label1.TabIndex = 54
        Me.Label1.Text = "Turno:"
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"(Seleccione)", "Matutino", "Vespertino ", "Nocturno"})
        Me.ComboBox1.Location = New System.Drawing.Point(25, 91)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(153, 21)
        Me.ComboBox1.TabIndex = 55
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Franklin Gothic Medium", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(26, 254)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(163, 49)
        Me.Button1.TabIndex = 56
        Me.Button1.Text = "Generar planillado"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'txb
        '
        Me.txb.Location = New System.Drawing.Point(366, 36)
        Me.txb.Name = "txb"
        Me.txb.Size = New System.Drawing.Size(100, 20)
        Me.txb.TabIndex = 57
        '
        'ltvplanillado
        '
        Me.ltvplanillado.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader4, Me.ColumnHeader5, Me.ColumnHeader6, Me.ColumnHeader7})
        Me.ltvplanillado.GridLines = True
        Me.ltvplanillado.Location = New System.Drawing.Point(206, 231)
        Me.ltvplanillado.Name = "ltvplanillado"
        Me.ltvplanillado.Size = New System.Drawing.Size(439, 229)
        Me.ltvplanillado.TabIndex = 58
        Me.ltvplanillado.UseCompatibleStateImageBehavior = False
        Me.ltvplanillado.View = System.Windows.Forms.View.Details
        '
        'armado_del_planillado
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(708, 387)
        Me.Controls.Add(Me.ltvplanillado)
        Me.Controls.Add(Me.txb)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lbltitulo)
        Me.Controls.Add(Me.dgvplanillado)
        Me.Name = "armado_del_planillado"
        Me.Text = "armado_del_planillado"
        CType(Me.dgvplanillado, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dgvplanillado As System.Windows.Forms.DataGridView
    Friend WithEvents lbltitulo As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents txb As System.Windows.Forms.TextBox
    Friend WithEvents ltvplanillado As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader4 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader5 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader6 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader7 As System.Windows.Forms.ColumnHeader
End Class
