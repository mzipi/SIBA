<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class consplanalumdia
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(consplanalumdia))
        Me.Label5 = New System.Windows.Forms.Label
        Me.gbxsel = New System.Windows.Forms.GroupBox
        Me.cmbgrupo = New System.Windows.Forms.ComboBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.btning = New System.Windows.Forms.Button
        Me.cmbdia = New System.Windows.Forms.ComboBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.cmbturno = New System.Windows.Forms.ComboBox
        Me.pbxplanalum = New System.Windows.Forms.PictureBox
        Me.lblrol = New System.Windows.Forms.Label
        Me.btnclose = New System.Windows.Forms.Button
        Me.lbltipou = New System.Windows.Forms.Label
        Me.btnatras = New System.Windows.Forms.Button
        Me.gbxdatos = New System.Windows.Forms.GroupBox
        Me.lblgrupsel = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.lbltursel = New System.Windows.Forms.Label
        Me.lblturno = New System.Windows.Forms.Label
        Me.lbldiasel = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.btnmenu = New System.Windows.Forms.Button
        Me.gbxsel.SuspendLayout()
        CType(Me.pbxplanalum, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbxdatos.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.LemonChiffon
        Me.Label5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(12, 9)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(286, 26)
        Me.Label5.TabIndex = 50
        Me.Label5.Text = "CONSULTA DE PLANILLADO"
        '
        'gbxsel
        '
        Me.gbxsel.Controls.Add(Me.cmbgrupo)
        Me.gbxsel.Controls.Add(Me.Label7)
        Me.gbxsel.Controls.Add(Me.btning)
        Me.gbxsel.Controls.Add(Me.cmbdia)
        Me.gbxsel.Controls.Add(Me.Label2)
        Me.gbxsel.Controls.Add(Me.Label3)
        Me.gbxsel.Controls.Add(Me.cmbturno)
        Me.gbxsel.Location = New System.Drawing.Point(12, 72)
        Me.gbxsel.Name = "gbxsel"
        Me.gbxsel.Size = New System.Drawing.Size(287, 268)
        Me.gbxsel.TabIndex = 161
        Me.gbxsel.TabStop = False
        Me.gbxsel.Text = "Seleccionar"
        '
        'cmbgrupo
        '
        Me.cmbgrupo.FormattingEnabled = True
        Me.cmbgrupo.Items.AddRange(New Object() {"(Seleccione)", "1°IO", "1°IP", "2°IJ", "3°IF", "3°IG"})
        Me.cmbgrupo.Location = New System.Drawing.Point(26, 107)
        Me.cmbgrupo.Name = "cmbgrupo"
        Me.cmbgrupo.Size = New System.Drawing.Size(221, 21)
        Me.cmbgrupo.TabIndex = 158
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(23, 79)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(227, 16)
        Me.Label7.TabIndex = 157
        Me.Label7.Text = "Seleccione el grupo a consultar"
        '
        'btning
        '
        Me.btning.Location = New System.Drawing.Point(162, 215)
        Me.btning.Name = "btning"
        Me.btning.Size = New System.Drawing.Size(70, 26)
        Me.btning.TabIndex = 156
        Me.btning.Text = "Ingresar"
        Me.btning.UseVisualStyleBackColor = True
        '
        'cmbdia
        '
        Me.cmbdia.FormattingEnabled = True
        Me.cmbdia.Items.AddRange(New Object() {"(Seleccione)", "Lunes", "Martes", "Miércoles", "Jueves", "Viernes", "Sábado"})
        Me.cmbdia.Location = New System.Drawing.Point(26, 174)
        Me.cmbdia.Name = "cmbdia"
        Me.cmbdia.Size = New System.Drawing.Size(218, 21)
        Me.cmbdia.TabIndex = 155
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(23, 142)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(209, 16)
        Me.Label2.TabIndex = 154
        Me.Label2.Text = "Seleccione el día a consultar"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(20, 16)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(221, 16)
        Me.Label3.TabIndex = 150
        Me.Label3.Text = "Seleccione el turno a consultar"
        '
        'cmbturno
        '
        Me.cmbturno.FormattingEnabled = True
        Me.cmbturno.Items.AddRange(New Object() {"(Seleccione)", " Matutino ", "Vespertino ", "Nocturno"})
        Me.cmbturno.Location = New System.Drawing.Point(23, 35)
        Me.cmbturno.Name = "cmbturno"
        Me.cmbturno.Size = New System.Drawing.Size(221, 21)
        Me.cmbturno.TabIndex = 151
        '
        'pbxplanalum
        '
        Me.pbxplanalum.Image = CType(resources.GetObject("pbxplanalum.Image"), System.Drawing.Image)
        Me.pbxplanalum.Location = New System.Drawing.Point(216, 163)
        Me.pbxplanalum.Name = "pbxplanalum"
        Me.pbxplanalum.Size = New System.Drawing.Size(754, 104)
        Me.pbxplanalum.TabIndex = 162
        Me.pbxplanalum.TabStop = False
        '
        'lblrol
        '
        Me.lblrol.AutoSize = True
        Me.lblrol.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblrol.Location = New System.Drawing.Point(582, 9)
        Me.lblrol.Name = "lblrol"
        Me.lblrol.Size = New System.Drawing.Size(36, 16)
        Me.lblrol.TabIndex = 165
        Me.lblrol.Text = "Rol:"
        '
        'btnclose
        '
        Me.btnclose.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnclose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnclose.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnclose.Location = New System.Drawing.Point(647, 28)
        Me.btnclose.Name = "btnclose"
        Me.btnclose.Size = New System.Drawing.Size(102, 24)
        Me.btnclose.TabIndex = 164
        Me.btnclose.Text = "Cerrar sesión"
        Me.btnclose.UseVisualStyleBackColor = True
        '
        'lbltipou
        '
        Me.lbltipou.AutoSize = True
        Me.lbltipou.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltipou.Location = New System.Drawing.Point(624, 9)
        Me.lbltipou.Name = "lbltipou"
        Me.lbltipou.Size = New System.Drawing.Size(0, 16)
        Me.lbltipou.TabIndex = 163
        '
        'btnatras
        '
        Me.btnatras.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnatras.Location = New System.Drawing.Point(611, 352)
        Me.btnatras.Name = "btnatras"
        Me.btnatras.Size = New System.Drawing.Size(138, 26)
        Me.btnatras.TabIndex = 166
        Me.btnatras.Text = "ATRÁS"
        Me.btnatras.UseVisualStyleBackColor = True
        '
        'gbxdatos
        '
        Me.gbxdatos.Controls.Add(Me.lblgrupsel)
        Me.gbxdatos.Controls.Add(Me.Label4)
        Me.gbxdatos.Controls.Add(Me.lbltursel)
        Me.gbxdatos.Controls.Add(Me.lblturno)
        Me.gbxdatos.Controls.Add(Me.lbldiasel)
        Me.gbxdatos.Controls.Add(Me.Label1)
        Me.gbxdatos.Location = New System.Drawing.Point(191, 56)
        Me.gbxdatos.Name = "gbxdatos"
        Me.gbxdatos.Size = New System.Drawing.Size(472, 45)
        Me.gbxdatos.TabIndex = 167
        Me.gbxdatos.TabStop = False
        Me.gbxdatos.Text = "Consulta"
        '
        'lblgrupsel
        '
        Me.lblgrupsel.AutoSize = True
        Me.lblgrupsel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblgrupsel.Location = New System.Drawing.Point(400, 23)
        Me.lblgrupsel.Name = "lblgrupsel"
        Me.lblgrupsel.Size = New System.Drawing.Size(0, 16)
        Me.lblgrupsel.TabIndex = 168
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(340, 23)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(54, 16)
        Me.Label4.TabIndex = 167
        Me.Label4.Text = "Grupo:"
        '
        'lbltursel
        '
        Me.lbltursel.AutoSize = True
        Me.lbltursel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltursel.Location = New System.Drawing.Point(222, 23)
        Me.lbltursel.Name = "lbltursel"
        Me.lbltursel.Size = New System.Drawing.Size(0, 16)
        Me.lbltursel.TabIndex = 166
        '
        'lblturno
        '
        Me.lblturno.AutoSize = True
        Me.lblturno.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblturno.Location = New System.Drawing.Point(164, 23)
        Me.lblturno.Name = "lblturno"
        Me.lblturno.Size = New System.Drawing.Size(52, 16)
        Me.lblturno.TabIndex = 165
        Me.lblturno.Text = "Turno:"
        '
        'lbldiasel
        '
        Me.lbldiasel.AutoSize = True
        Me.lbldiasel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbldiasel.Location = New System.Drawing.Point(72, 23)
        Me.lbldiasel.Name = "lbldiasel"
        Me.lbldiasel.Size = New System.Drawing.Size(0, 16)
        Me.lbldiasel.TabIndex = 162
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(22, 23)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(44, 16)
        Me.Label1.TabIndex = 161
        Me.Label1.Text = "Día:  "
        '
        'btnmenu
        '
        Me.btnmenu.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnmenu.Location = New System.Drawing.Point(12, 352)
        Me.btnmenu.Name = "btnmenu"
        Me.btnmenu.Size = New System.Drawing.Size(154, 26)
        Me.btnmenu.TabIndex = 168
        Me.btnmenu.Text = "MENÚ REPORTES"
        Me.btnmenu.UseVisualStyleBackColor = True
        '
        'consplanalumdia
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(767, 391)
        Me.Controls.Add(Me.btnmenu)
        Me.Controls.Add(Me.gbxdatos)
        Me.Controls.Add(Me.btnatras)
        Me.Controls.Add(Me.lblrol)
        Me.Controls.Add(Me.btnclose)
        Me.Controls.Add(Me.lbltipou)
        Me.Controls.Add(Me.pbxplanalum)
        Me.Controls.Add(Me.gbxsel)
        Me.Controls.Add(Me.Label5)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "consplanalumdia"
        Me.gbxsel.ResumeLayout(False)
        Me.gbxsel.PerformLayout()
        CType(Me.pbxplanalum, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbxdatos.ResumeLayout(False)
        Me.gbxdatos.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents gbxsel As System.Windows.Forms.GroupBox
    Friend WithEvents cmbgrupo As System.Windows.Forms.ComboBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents btning As System.Windows.Forms.Button
    Friend WithEvents cmbdia As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents cmbturno As System.Windows.Forms.ComboBox
    Friend WithEvents pbxplanalum As System.Windows.Forms.PictureBox
    Friend WithEvents lblrol As System.Windows.Forms.Label
    Friend WithEvents btnclose As System.Windows.Forms.Button
    Friend WithEvents lbltipou As System.Windows.Forms.Label
    Friend WithEvents btnatras As System.Windows.Forms.Button
    Friend WithEvents gbxdatos As System.Windows.Forms.GroupBox
    Friend WithEvents lbltursel As System.Windows.Forms.Label
    Friend WithEvents lblturno As System.Windows.Forms.Label
    Friend WithEvents lbldiasel As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnmenu As System.Windows.Forms.Button
    Friend WithEvents lblgrupsel As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
End Class
