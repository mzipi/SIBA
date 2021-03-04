<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class disploc
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
        Me.lblhora = New System.Windows.Forms.Label
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Label2 = New System.Windows.Forms.Label
        Me.lblrol = New System.Windows.Forms.Label
        Me.lblnombreu = New System.Windows.Forms.Label
        Me.lbltipou = New System.Windows.Forms.Label
        Me.lblclose = New System.Windows.Forms.Button
        Me.lbltitulo = New System.Windows.Forms.Label
        Me.rbndefinir = New System.Windows.Forms.RadioButton
        Me.rbnmodificar = New System.Windows.Forms.RadioButton
        Me.lblsiba = New System.Windows.Forms.Label
        Me.SuspendLayout()
        '
        'lblhora
        '
        Me.lblhora.AutoSize = True
        Me.lblhora.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblhora.Location = New System.Drawing.Point(457, 9)
        Me.lblhora.Name = "lblhora"
        Me.lblhora.Size = New System.Drawing.Size(55, 16)
        Me.lblhora.TabIndex = 0
        Me.lblhora.Text = "Label1"
        '
        'Timer1
        '
        Me.Timer1.Interval = 1000
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(391, 30)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(108, 16)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Bienvenida/o: "
        '
        'lblrol
        '
        Me.lblrol.AutoSize = True
        Me.lblrol.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblrol.Location = New System.Drawing.Point(395, 55)
        Me.lblrol.Name = "lblrol"
        Me.lblrol.Size = New System.Drawing.Size(36, 16)
        Me.lblrol.TabIndex = 3
        Me.lblrol.Text = "Rol:"
        '
        'lblnombreu
        '
        Me.lblnombreu.AutoSize = True
        Me.lblnombreu.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblnombreu.Location = New System.Drawing.Point(505, 30)
        Me.lblnombreu.Name = "lblnombreu"
        Me.lblnombreu.Size = New System.Drawing.Size(55, 16)
        Me.lblnombreu.TabIndex = 4
        Me.lblnombreu.Text = "Label4"
        '
        'lbltipou
        '
        Me.lbltipou.AutoSize = True
        Me.lbltipou.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltipou.Location = New System.Drawing.Point(437, 55)
        Me.lbltipou.Name = "lbltipou"
        Me.lbltipou.Size = New System.Drawing.Size(182, 16)
        Me.lbltipou.TabIndex = 5
        Me.lbltipou.Text = "Secretario Administrativo"
        '
        'lblclose
        '
        Me.lblclose.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.lblclose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblclose.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblclose.Location = New System.Drawing.Point(508, 74)
        Me.lblclose.Name = "lblclose"
        Me.lblclose.Size = New System.Drawing.Size(102, 24)
        Me.lblclose.TabIndex = 43
        Me.lblclose.Text = "Cerrar sesión"
        Me.lblclose.UseVisualStyleBackColor = True
        '
        'lbltitulo
        '
        Me.lbltitulo.AutoSize = True
        Me.lbltitulo.BackColor = System.Drawing.Color.LemonChiffon
        Me.lbltitulo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbltitulo.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltitulo.Location = New System.Drawing.Point(12, 20)
        Me.lbltitulo.Name = "lbltitulo"
        Me.lbltitulo.Size = New System.Drawing.Size(276, 26)
        Me.lbltitulo.TabIndex = 52
        Me.lbltitulo.Text = "DISPONIBILIDAD LOCATIVA"
        '
        'rbndefinir
        '
        Me.rbndefinir.AutoSize = True
        Me.rbndefinir.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbndefinir.Location = New System.Drawing.Point(12, 92)
        Me.rbndefinir.Name = "rbndefinir"
        Me.rbndefinir.Size = New System.Drawing.Size(160, 20)
        Me.rbndefinir.TabIndex = 53
        Me.rbndefinir.TabStop = True
        Me.rbndefinir.Text = "DEFINIR SALONES"
        Me.rbndefinir.UseVisualStyleBackColor = True
        '
        'rbnmodificar
        '
        Me.rbnmodificar.AutoSize = True
        Me.rbnmodificar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbnmodificar.Location = New System.Drawing.Point(12, 129)
        Me.rbnmodificar.Name = "rbnmodificar"
        Me.rbnmodificar.Size = New System.Drawing.Size(182, 20)
        Me.rbnmodificar.TabIndex = 54
        Me.rbnmodificar.TabStop = True
        Me.rbnmodificar.Text = "MODIFICAR SALONES"
        Me.rbnmodificar.UseVisualStyleBackColor = True
        '
        'lblsiba
        '
        Me.lblsiba.AutoSize = True
        Me.lblsiba.Font = New System.Drawing.Font("Pristina", 72.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblsiba.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblsiba.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblsiba.Location = New System.Drawing.Point(258, 153)
        Me.lblsiba.Name = "lblsiba"
        Me.lblsiba.Size = New System.Drawing.Size(352, 126)
        Me.lblsiba.TabIndex = 55
        Me.lblsiba.Text = "S.I.B.A."
        '
        'disploc
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(622, 366)
        Me.Controls.Add(Me.lblsiba)
        Me.Controls.Add(Me.rbnmodificar)
        Me.Controls.Add(Me.rbndefinir)
        Me.Controls.Add(Me.lbltitulo)
        Me.Controls.Add(Me.lblclose)
        Me.Controls.Add(Me.lblnombreu)
        Me.Controls.Add(Me.lblrol)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lbltipou)
        Me.Controls.Add(Me.lblhora)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "disploc"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "S.I.B.A."
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblhora As System.Windows.Forms.Label
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lblrol As System.Windows.Forms.Label
    Friend WithEvents lblnombreu As System.Windows.Forms.Label
    Friend WithEvents lbltipou As System.Windows.Forms.Label
    Friend WithEvents lblclose As System.Windows.Forms.Button
    Friend WithEvents lbltitulo As System.Windows.Forms.Label
    Friend WithEvents rbndefinir As System.Windows.Forms.RadioButton
    Friend WithEvents rbnmodificar As System.Windows.Forms.RadioButton
    Friend WithEvents lblsiba As System.Windows.Forms.Label
End Class
