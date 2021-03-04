<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ialtasalon
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
        Me.btnfinalizar = New System.Windows.Forms.Button
        Me.btncancelar = New System.Windows.Forms.Button
        Me.lblcod = New System.Windows.Forms.Label
        Me.lbltipo = New System.Windows.Forms.Label
        Me.lblnumero = New System.Windows.Forms.Label
        Me.txtcodigo = New System.Windows.Forms.TextBox
        Me.txtnumero = New System.Windows.Forms.TextBox
        Me.gbxsalon = New System.Windows.Forms.GroupBox
        Me.cmbtipo = New System.Windows.Forms.ComboBox
        Me.btnaceptar = New System.Windows.Forms.Button
        Me.lbltitulo = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Button3 = New System.Windows.Forms.Button
        Me.Label9 = New System.Windows.Forms.Label
        Me.gbxsalon.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnfinalizar
        '
        Me.btnfinalizar.BackColor = System.Drawing.Color.Transparent
        Me.btnfinalizar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnfinalizar.Location = New System.Drawing.Point(492, 311)
        Me.btnfinalizar.Name = "btnfinalizar"
        Me.btnfinalizar.Size = New System.Drawing.Size(101, 22)
        Me.btnfinalizar.TabIndex = 19
        Me.btnfinalizar.Text = "Finalize"
        Me.btnfinalizar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage
        Me.btnfinalizar.UseVisualStyleBackColor = False
        '
        'btncancelar
        '
        Me.btncancelar.BackColor = System.Drawing.Color.Transparent
        Me.btncancelar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btncancelar.Location = New System.Drawing.Point(9, 186)
        Me.btncancelar.Name = "btncancelar"
        Me.btncancelar.Size = New System.Drawing.Size(101, 22)
        Me.btncancelar.TabIndex = 18
        Me.btncancelar.Text = "Cancel"
        Me.btncancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage
        Me.btncancelar.UseVisualStyleBackColor = False
        '
        'lblcod
        '
        Me.lblcod.AutoSize = True
        Me.lblcod.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblcod.Location = New System.Drawing.Point(6, 40)
        Me.lblcod.Name = "lblcod"
        Me.lblcod.Size = New System.Drawing.Size(44, 16)
        Me.lblcod.TabIndex = 0
        Me.lblcod.Text = "Code:"
        '
        'lbltipo
        '
        Me.lbltipo.AutoSize = True
        Me.lbltipo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltipo.Location = New System.Drawing.Point(6, 80)
        Me.lbltipo.Name = "lbltipo"
        Me.lbltipo.Size = New System.Drawing.Size(43, 16)
        Me.lbltipo.TabIndex = 1
        Me.lbltipo.Text = "Type:"
        '
        'lblnumero
        '
        Me.lblnumero.AutoSize = True
        Me.lblnumero.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblnumero.Location = New System.Drawing.Point(6, 125)
        Me.lblnumero.Name = "lblnumero"
        Me.lblnumero.Size = New System.Drawing.Size(59, 16)
        Me.lblnumero.TabIndex = 3
        Me.lblnumero.Text = "Number:"
        '
        'txtcodigo
        '
        Me.txtcodigo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtcodigo.Location = New System.Drawing.Point(9, 59)
        Me.txtcodigo.MaxLength = 5
        Me.txtcodigo.Name = "txtcodigo"
        Me.txtcodigo.Size = New System.Drawing.Size(218, 22)
        Me.txtcodigo.TabIndex = 6
        '
        'txtnumero
        '
        Me.txtnumero.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtnumero.Location = New System.Drawing.Point(9, 144)
        Me.txtnumero.MaxLength = 3
        Me.txtnumero.Name = "txtnumero"
        Me.txtnumero.Size = New System.Drawing.Size(218, 22)
        Me.txtnumero.TabIndex = 11
        '
        'gbxsalon
        '
        Me.gbxsalon.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbxsalon.Controls.Add(Me.cmbtipo)
        Me.gbxsalon.Controls.Add(Me.btnaceptar)
        Me.gbxsalon.Controls.Add(Me.txtnumero)
        Me.gbxsalon.Controls.Add(Me.txtcodigo)
        Me.gbxsalon.Controls.Add(Me.lblnumero)
        Me.gbxsalon.Controls.Add(Me.lbltipo)
        Me.gbxsalon.Controls.Add(Me.lblcod)
        Me.gbxsalon.Controls.Add(Me.btncancelar)
        Me.gbxsalon.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbxsalon.Location = New System.Drawing.Point(15, 59)
        Me.gbxsalon.Name = "gbxsalon"
        Me.gbxsalon.Size = New System.Drawing.Size(267, 226)
        Me.gbxsalon.TabIndex = 22
        Me.gbxsalon.TabStop = False
        Me.gbxsalon.Text = "Classrooms"
        '
        'cmbtipo
        '
        Me.cmbtipo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbtipo.FormattingEnabled = True
        Me.cmbtipo.Items.AddRange(New Object() {"(Select)", "Theoretical", "Laboratory", "Workshop"})
        Me.cmbtipo.Location = New System.Drawing.Point(9, 99)
        Me.cmbtipo.Name = "cmbtipo"
        Me.cmbtipo.Size = New System.Drawing.Size(218, 24)
        Me.cmbtipo.TabIndex = 21
        '
        'btnaceptar
        '
        Me.btnaceptar.BackColor = System.Drawing.Color.Transparent
        Me.btnaceptar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnaceptar.Location = New System.Drawing.Point(164, 186)
        Me.btnaceptar.Name = "btnaceptar"
        Me.btnaceptar.Size = New System.Drawing.Size(101, 22)
        Me.btnaceptar.TabIndex = 20
        Me.btnaceptar.Text = "Accept"
        Me.btnaceptar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage
        Me.btnaceptar.UseVisualStyleBackColor = False
        '
        'lbltitulo
        '
        Me.lbltitulo.AutoSize = True
        Me.lbltitulo.BackColor = System.Drawing.Color.LemonChiffon
        Me.lbltitulo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbltitulo.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltitulo.Location = New System.Drawing.Point(15, 9)
        Me.lbltitulo.Name = "lbltitulo"
        Me.lbltitulo.Size = New System.Drawing.Size(240, 26)
        Me.lbltitulo.TabIndex = 50
        Me.lbltitulo.Text = "INGRESO DE SALONES"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(415, 9)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(45, 16)
        Me.Label4.TabIndex = 62
        Me.Label4.Text = "Role:"
        '
        'Button3
        '
        Me.Button3.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Location = New System.Drawing.Point(501, 28)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(102, 24)
        Me.Button3.TabIndex = 61
        Me.Button3.Text = "Log out"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(466, 9)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(127, 16)
        Me.Label9.TabIndex = 60
        Me.Label9.Text = "School Secretary"
        '
        'ialtasalon
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(620, 356)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.lbltitulo)
        Me.Controls.Add(Me.gbxsalon)
        Me.Controls.Add(Me.btnfinalizar)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "ialtasalon"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "S.I.B.A"
        Me.gbxsalon.ResumeLayout(False)
        Me.gbxsalon.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnfinalizar As System.Windows.Forms.Button
    Friend WithEvents btncancelar As System.Windows.Forms.Button
    Friend WithEvents lblcod As System.Windows.Forms.Label
    Friend WithEvents lbltipo As System.Windows.Forms.Label
    Friend WithEvents lblnumero As System.Windows.Forms.Label
    Friend WithEvents txtcodigo As System.Windows.Forms.TextBox
    Friend WithEvents txtnumero As System.Windows.Forms.TextBox
    Friend WithEvents gbxsalon As System.Windows.Forms.GroupBox
    Friend WithEvents lbltitulo As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents btnaceptar As System.Windows.Forms.Button
    Friend WithEvents cmbtipo As System.Windows.Forms.ComboBox
End Class
