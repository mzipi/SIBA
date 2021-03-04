<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class modhoras
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
        Me.btnmod = New System.Windows.Forms.Button
        Me.btnatras = New System.Windows.Forms.Button
        Me.lbltitulo = New System.Windows.Forms.Label
        Me.lblrol = New System.Windows.Forms.Label
        Me.btnclose = New System.Windows.Forms.Button
        Me.lbltipou = New System.Windows.Forms.Label
        Me.gbxdoc = New System.Windows.Forms.GroupBox
        Me.cmbdia = New System.Windows.Forms.ComboBox
        Me.txtcodhora = New System.Windows.Forms.TextBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.txthoraini = New System.Windows.Forms.TextBox
        Me.txthorafin = New System.Windows.Forms.TextBox
        Me.txtnumero = New System.Windows.Forms.TextBox
        Me.txtcodturno = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.gbxdoc.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnmod
        '
        Me.btnmod.BackColor = System.Drawing.Color.Transparent
        Me.btnmod.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnmod.Location = New System.Drawing.Point(366, 133)
        Me.btnmod.Name = "btnmod"
        Me.btnmod.Size = New System.Drawing.Size(101, 22)
        Me.btnmod.TabIndex = 19
        Me.btnmod.Text = "Modificar"
        Me.btnmod.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage
        Me.btnmod.UseVisualStyleBackColor = False
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
        Me.lbltitulo.Size = New System.Drawing.Size(202, 26)
        Me.lbltitulo.TabIndex = 52
        Me.lbltitulo.Text = "MODIFICAR HORAS"
        '
        'lblrol
        '
        Me.lblrol.AutoSize = True
        Me.lblrol.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblrol.Location = New System.Drawing.Point(328, 9)
        Me.lblrol.Name = "lblrol"
        Me.lblrol.Size = New System.Drawing.Size(36, 16)
        Me.lblrol.TabIndex = 68
        Me.lblrol.Text = "Rol:"
        '
        'btnclose
        '
        Me.btnclose.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnclose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnclose.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnclose.Location = New System.Drawing.Point(405, 28)
        Me.btnclose.Name = "btnclose"
        Me.btnclose.Size = New System.Drawing.Size(102, 24)
        Me.btnclose.TabIndex = 67
        Me.btnclose.Text = "Cerrar sesión"
        Me.btnclose.UseVisualStyleBackColor = True
        '
        'lbltipou
        '
        Me.lbltipou.AutoSize = True
        Me.lbltipou.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltipou.Location = New System.Drawing.Point(370, 9)
        Me.lbltipou.Name = "lbltipou"
        Me.lbltipou.Size = New System.Drawing.Size(137, 16)
        Me.lbltipou.TabIndex = 66
        Me.lbltipou.Text = "Secretario Escolar"
        '
        'gbxdoc
        '
        Me.gbxdoc.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbxdoc.Controls.Add(Me.cmbdia)
        Me.gbxdoc.Controls.Add(Me.txtcodhora)
        Me.gbxdoc.Controls.Add(Me.Label7)
        Me.gbxdoc.Controls.Add(Me.Label1)
        Me.gbxdoc.Controls.Add(Me.txthoraini)
        Me.gbxdoc.Controls.Add(Me.txthorafin)
        Me.gbxdoc.Controls.Add(Me.txtnumero)
        Me.gbxdoc.Controls.Add(Me.txtcodturno)
        Me.gbxdoc.Controls.Add(Me.Label5)
        Me.gbxdoc.Controls.Add(Me.Label2)
        Me.gbxdoc.Controls.Add(Me.Label3)
        Me.gbxdoc.Controls.Add(Me.Label8)
        Me.gbxdoc.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbxdoc.Location = New System.Drawing.Point(15, 65)
        Me.gbxdoc.Name = "gbxdoc"
        Me.gbxdoc.Size = New System.Drawing.Size(271, 255)
        Me.gbxdoc.TabIndex = 149
        Me.gbxdoc.TabStop = False
        Me.gbxdoc.Text = "Horas"
        '
        'cmbdia
        '
        Me.cmbdia.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbdia.FormattingEnabled = True
        Me.cmbdia.Items.AddRange(New Object() {"(Seleccione)", "Lunes", "Martes", "Miércoles", "Jueves", "Viernes", "Sábado"})
        Me.cmbdia.Location = New System.Drawing.Point(6, 175)
        Me.cmbdia.Name = "cmbdia"
        Me.cmbdia.Size = New System.Drawing.Size(221, 24)
        Me.cmbdia.TabIndex = 16
        Me.cmbdia.Text = "Sábado"
        '
        'txtcodhora
        '
        Me.txtcodhora.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtcodhora.Location = New System.Drawing.Point(6, 41)
        Me.txtcodhora.MaxLength = 6
        Me.txtcodhora.Name = "txtcodhora"
        Me.txtcodhora.Size = New System.Drawing.Size(221, 22)
        Me.txtcodhora.TabIndex = 15
        Me.txtcodhora.Text = "005"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(6, 22)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(85, 16)
        Me.Label7.TabIndex = 14
        Me.Label7.Text = "Código hora:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(6, 156)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(32, 16)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "Día:"
        '
        'txthoraini
        '
        Me.txthoraini.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txthoraini.Location = New System.Drawing.Point(6, 219)
        Me.txthoraini.MaxLength = 5
        Me.txthoraini.Name = "txthoraini"
        Me.txthoraini.Size = New System.Drawing.Size(118, 22)
        Me.txthoraini.TabIndex = 11
        Me.txthoraini.Text = "15:35"
        '
        'txthorafin
        '
        Me.txthorafin.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txthorafin.Location = New System.Drawing.Point(133, 219)
        Me.txthorafin.MaxLength = 5
        Me.txthorafin.Name = "txthorafin"
        Me.txthorafin.Size = New System.Drawing.Size(94, 22)
        Me.txthorafin.TabIndex = 10
        Me.txthorafin.Text = "16:15"
        '
        'txtnumero
        '
        Me.txtnumero.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtnumero.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.txtnumero.Location = New System.Drawing.Point(6, 131)
        Me.txtnumero.MaxLength = 2
        Me.txtnumero.Name = "txtnumero"
        Me.txtnumero.Size = New System.Drawing.Size(221, 22)
        Me.txtnumero.TabIndex = 7
        Me.txtnumero.Text = "4"
        '
        'txtcodturno
        '
        Me.txtcodturno.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtcodturno.Location = New System.Drawing.Point(6, 87)
        Me.txtcodturno.MaxLength = 6
        Me.txtcodturno.Name = "txtcodturno"
        Me.txtcodturno.Size = New System.Drawing.Size(221, 22)
        Me.txtcodturno.TabIndex = 6
        Me.txtcodturno.Text = "3"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(6, 200)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(78, 16)
        Me.Label5.TabIndex = 3
        Me.Label5.Text = "Hora inicial:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(130, 200)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(73, 16)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Hora Final:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(6, 112)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(59, 16)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Número:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(6, 68)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(87, 16)
        Me.Label8.TabIndex = 0
        Me.Label8.Text = "Código turno:"
        '
        'modhoras
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(528, 343)
        Me.Controls.Add(Me.gbxdoc)
        Me.Controls.Add(Me.lblrol)
        Me.Controls.Add(Me.btnclose)
        Me.Controls.Add(Me.lbltipou)
        Me.Controls.Add(Me.lbltitulo)
        Me.Controls.Add(Me.btnmod)
        Me.Controls.Add(Me.btnatras)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "modhoras"
        Me.Text = "S.I.B.A"
        Me.gbxdoc.ResumeLayout(False)
        Me.gbxdoc.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnmod As System.Windows.Forms.Button
    Friend WithEvents btnatras As System.Windows.Forms.Button
    Friend WithEvents lbltitulo As System.Windows.Forms.Label
    Friend WithEvents lblrol As System.Windows.Forms.Label
    Friend WithEvents btnclose As System.Windows.Forms.Button
    Friend WithEvents lbltipou As System.Windows.Forms.Label
    Friend WithEvents gbxdoc As System.Windows.Forms.GroupBox
    Friend WithEvents cmbdia As System.Windows.Forms.ComboBox
    Friend WithEvents txtcodhora As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txthoraini As System.Windows.Forms.TextBox
    Friend WithEvents txthorafin As System.Windows.Forms.TextBox
    Friend WithEvents txtnumero As System.Windows.Forms.TextBox
    Friend WithEvents txtcodturno As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
End Class
