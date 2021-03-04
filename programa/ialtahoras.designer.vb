<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ialtahoras
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
        Me.lbltitulo = New System.Windows.Forms.Label
        Me.lblrol = New System.Windows.Forms.Label
        Me.btnclose = New System.Windows.Forms.Button
        Me.lbltipou = New System.Windows.Forms.Label
        Me.Label14 = New System.Windows.Forms.Label
        Me.cmbturno = New System.Windows.Forms.ComboBox
        Me.Label10 = New System.Windows.Forms.Label
        Me.gbxhoras = New System.Windows.Forms.GroupBox
        Me.cmbturnomod = New System.Windows.Forms.ComboBox
        Me.cmbdia = New System.Windows.Forms.ComboBox
        Me.txtcodhora = New System.Windows.Forms.TextBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.txthoraini = New System.Windows.Forms.TextBox
        Me.txthorafin = New System.Windows.Forms.TextBox
        Me.txtnumero = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.lblnombre = New System.Windows.Forms.Label
        Me.Button4 = New System.Windows.Forms.Button
        Me.btnaceptar = New System.Windows.Forms.Button
        Me.btnatras = New System.Windows.Forms.Button
        Me.gbxselturno = New System.Windows.Forms.GroupBox
        Me.txt_idturno = New System.Windows.Forms.TextBox
        Me.gbxhoras.SuspendLayout()
        Me.gbxselturno.SuspendLayout()
        Me.SuspendLayout()
        '
        'lbltitulo
        '
        Me.lbltitulo.AutoSize = True
        Me.lbltitulo.BackColor = System.Drawing.Color.LemonChiffon
        Me.lbltitulo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbltitulo.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltitulo.Location = New System.Drawing.Point(15, 9)
        Me.lbltitulo.Name = "lbltitulo"
        Me.lbltitulo.Size = New System.Drawing.Size(216, 26)
        Me.lbltitulo.TabIndex = 136
        Me.lbltitulo.Text = "INGRESO DE HORAS"
        '
        'lblrol
        '
        Me.lblrol.AutoSize = True
        Me.lblrol.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblrol.Location = New System.Drawing.Point(417, 9)
        Me.lblrol.Name = "lblrol"
        Me.lblrol.Size = New System.Drawing.Size(45, 16)
        Me.lblrol.TabIndex = 144
        Me.lblrol.Text = "Role:"
        '
        'btnclose
        '
        Me.btnclose.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnclose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnclose.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnclose.Location = New System.Drawing.Point(495, 28)
        Me.btnclose.Name = "btnclose"
        Me.btnclose.Size = New System.Drawing.Size(102, 24)
        Me.btnclose.TabIndex = 143
        Me.btnclose.Text = "Log out"
        Me.btnclose.UseVisualStyleBackColor = True
        '
        'lbltipou
        '
        Me.lbltipou.AutoSize = True
        Me.lbltipou.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltipou.Location = New System.Drawing.Point(460, 9)
        Me.lbltipou.Name = "lbltipou"
        Me.lbltipou.Size = New System.Drawing.Size(127, 16)
        Me.lbltipou.TabIndex = 142
        Me.lbltipou.Text = "School Secretary"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(6, 41)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(136, 16)
        Me.Label14.TabIndex = 147
        Me.Label14.Text = "hours be assigned"
        '
        'cmbturno
        '
        Me.cmbturno.FormattingEnabled = True
        Me.cmbturno.Items.AddRange(New Object() {"(Seleccione)", "Matutino", "Vespertino", "Nocturno"})
        Me.cmbturno.Location = New System.Drawing.Point(4, 69)
        Me.cmbturno.Name = "cmbturno"
        Me.cmbturno.Size = New System.Drawing.Size(204, 21)
        Me.cmbturno.TabIndex = 146
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(4, 16)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(148, 16)
        Me.Label10.TabIndex = 145
        Me.Label10.Text = "Select the turn which"
        '
        'gbxhoras
        '
        Me.gbxhoras.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbxhoras.Controls.Add(Me.cmbturnomod)
        Me.gbxhoras.Controls.Add(Me.cmbdia)
        Me.gbxhoras.Controls.Add(Me.txtcodhora)
        Me.gbxhoras.Controls.Add(Me.Label7)
        Me.gbxhoras.Controls.Add(Me.Label6)
        Me.gbxhoras.Controls.Add(Me.txthoraini)
        Me.gbxhoras.Controls.Add(Me.txthorafin)
        Me.gbxhoras.Controls.Add(Me.txtnumero)
        Me.gbxhoras.Controls.Add(Me.Label5)
        Me.gbxhoras.Controls.Add(Me.Label4)
        Me.gbxhoras.Controls.Add(Me.Label3)
        Me.gbxhoras.Controls.Add(Me.lblnombre)
        Me.gbxhoras.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbxhoras.Location = New System.Drawing.Point(243, 58)
        Me.gbxhoras.Name = "gbxhoras"
        Me.gbxhoras.Size = New System.Drawing.Size(271, 255)
        Me.gbxhoras.TabIndex = 148
        Me.gbxhoras.TabStop = False
        Me.gbxhoras.Text = "Hours"
        '
        'cmbturnomod
        '
        Me.cmbturnomod.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.cmbturnomod.FormattingEnabled = True
        Me.cmbturnomod.Items.AddRange(New Object() {"(Seleccione)", "Matutino", "Vespertino", "Nocturno"})
        Me.cmbturnomod.Location = New System.Drawing.Point(6, 87)
        Me.cmbturnomod.Name = "cmbturnomod"
        Me.cmbturnomod.Size = New System.Drawing.Size(213, 24)
        Me.cmbturnomod.TabIndex = 152
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
        '
        'txtcodhora
        '
        Me.txtcodhora.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtcodhora.Location = New System.Drawing.Point(6, 41)
        Me.txtcodhora.MaxLength = 6
        Me.txtcodhora.Name = "txtcodhora"
        Me.txtcodhora.Size = New System.Drawing.Size(221, 22)
        Me.txtcodhora.TabIndex = 15
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(6, 22)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(83, 16)
        Me.Label7.TabIndex = 14
        Me.Label7.Text = "Hours Code:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(6, 156)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(36, 16)
        Me.Label6.TabIndex = 13
        Me.Label6.Text = "Day:"
        '
        'txthoraini
        '
        Me.txthoraini.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txthoraini.Location = New System.Drawing.Point(6, 219)
        Me.txthoraini.MaxLength = 5
        Me.txthoraini.Name = "txthoraini"
        Me.txthoraini.Size = New System.Drawing.Size(118, 22)
        Me.txthoraini.TabIndex = 11
        '
        'txthorafin
        '
        Me.txthorafin.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txthorafin.Location = New System.Drawing.Point(133, 219)
        Me.txthorafin.MaxLength = 5
        Me.txthorafin.Name = "txthorafin"
        Me.txthorafin.Size = New System.Drawing.Size(94, 22)
        Me.txthorafin.TabIndex = 10
        '
        'txtnumero
        '
        Me.txtnumero.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtnumero.Location = New System.Drawing.Point(6, 131)
        Me.txtnumero.MaxLength = 1
        Me.txtnumero.Name = "txtnumero"
        Me.txtnumero.Size = New System.Drawing.Size(221, 22)
        Me.txtnumero.TabIndex = 7
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(6, 200)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(63, 16)
        Me.Label5.TabIndex = 3
        Me.Label5.Text = "Star time:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(130, 200)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(69, 16)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "End Time:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(6, 112)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(91, 16)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Hour Number:"
        '
        'lblnombre
        '
        Me.lblnombre.AutoSize = True
        Me.lblnombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblnombre.Location = New System.Drawing.Point(6, 68)
        Me.lblnombre.Name = "lblnombre"
        Me.lblnombre.Size = New System.Drawing.Size(78, 16)
        Me.lblnombre.TabIndex = 0
        Me.lblnombre.Text = "Turn Name:"
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(138, 96)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(70, 26)
        Me.Button4.TabIndex = 149
        Me.Button4.Text = "Continue"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'btnaceptar
        '
        Me.btnaceptar.BackColor = System.Drawing.Color.Transparent
        Me.btnaceptar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnaceptar.Location = New System.Drawing.Point(425, 140)
        Me.btnaceptar.Name = "btnaceptar"
        Me.btnaceptar.Size = New System.Drawing.Size(101, 22)
        Me.btnaceptar.TabIndex = 139
        Me.btnaceptar.Text = "Insert"
        Me.btnaceptar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage
        Me.btnaceptar.UseVisualStyleBackColor = False
        '
        'btnatras
        '
        Me.btnatras.BackColor = System.Drawing.Color.Transparent
        Me.btnatras.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnatras.Location = New System.Drawing.Point(425, 181)
        Me.btnatras.Name = "btnatras"
        Me.btnatras.Size = New System.Drawing.Size(101, 22)
        Me.btnatras.TabIndex = 138
        Me.btnatras.Text = "Finalize"
        Me.btnatras.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage
        Me.btnatras.UseVisualStyleBackColor = False
        '
        'gbxselturno
        '
        Me.gbxselturno.Controls.Add(Me.Button4)
        Me.gbxselturno.Controls.Add(Me.Label14)
        Me.gbxselturno.Controls.Add(Me.cmbturno)
        Me.gbxselturno.Controls.Add(Me.Label10)
        Me.gbxselturno.Location = New System.Drawing.Point(15, 47)
        Me.gbxselturno.Name = "gbxselturno"
        Me.gbxselturno.Size = New System.Drawing.Size(222, 128)
        Me.gbxselturno.TabIndex = 150
        Me.gbxselturno.TabStop = False
        Me.gbxselturno.Text = "Select a turns"
        '
        'txt_idturno
        '
        Me.txt_idturno.Location = New System.Drawing.Point(287, 15)
        Me.txt_idturno.Name = "txt_idturno"
        Me.txt_idturno.Size = New System.Drawing.Size(100, 20)
        Me.txt_idturno.TabIndex = 151
        '
        'ialtahoras
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(618, 346)
        Me.Controls.Add(Me.txt_idturno)
        Me.Controls.Add(Me.gbxselturno)
        Me.Controls.Add(Me.btnaceptar)
        Me.Controls.Add(Me.btnatras)
        Me.Controls.Add(Me.gbxhoras)
        Me.Controls.Add(Me.lblrol)
        Me.Controls.Add(Me.btnclose)
        Me.Controls.Add(Me.lbltipou)
        Me.Controls.Add(Me.lbltitulo)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "ialtahoras"
        Me.Text = "S.I.B.A"
        Me.gbxhoras.ResumeLayout(False)
        Me.gbxhoras.PerformLayout()
        Me.gbxselturno.ResumeLayout(False)
        Me.gbxselturno.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lbltitulo As System.Windows.Forms.Label
    Friend WithEvents lblrol As System.Windows.Forms.Label
    Friend WithEvents btnclose As System.Windows.Forms.Button
    Friend WithEvents lbltipou As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents cmbturno As System.Windows.Forms.ComboBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents gbxhoras As System.Windows.Forms.GroupBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txthoraini As System.Windows.Forms.TextBox
    Friend WithEvents txthorafin As System.Windows.Forms.TextBox
    Friend WithEvents txtnumero As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents lblnombre As System.Windows.Forms.Label
    Friend WithEvents txtcodhora As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents btnaceptar As System.Windows.Forms.Button
    Friend WithEvents btnatras As System.Windows.Forms.Button
    Friend WithEvents cmbdia As System.Windows.Forms.ComboBox
    Friend WithEvents gbxselturno As System.Windows.Forms.GroupBox
    Friend WithEvents txt_idturno As System.Windows.Forms.TextBox
    Friend WithEvents cmbturnomod As System.Windows.Forms.ComboBox
End Class
