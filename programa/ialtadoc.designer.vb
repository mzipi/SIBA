<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ialtadoc
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
        Me.components = New System.ComponentModel.Container
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ialtadoc))
        Me.btnaceptar = New System.Windows.Forms.Button
        Me.btncancel = New System.Windows.Forms.Button
        Me.gbxdoc = New System.Windows.Forms.GroupBox
        Me.lbldatos_Ci = New System.Windows.Forms.Label
        Me.gbxedit = New System.Windows.Forms.GroupBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.lblver = New System.Windows.Forms.Label
        Me.cmbcatdoc = New System.Windows.Forms.ComboBox
        Me.txttel = New System.Windows.Forms.TextBox
        Me.txtant = New System.Windows.Forms.TextBox
        Me.txtformac = New System.Windows.Forms.TextBox
        Me.txtci = New System.Windows.Forms.TextBox
        Me.txtnombre = New System.Windows.Forms.TextBox
        Me.lbltel = New System.Windows.Forms.Label
        Me.lblformac = New System.Windows.Forms.Label
        Me.lblant = New System.Windows.Forms.Label
        Me.lblgrado = New System.Windows.Forms.Label
        Me.lblci = New System.Windows.Forms.Label
        Me.lblnombre = New System.Windows.Forms.Label
        Me.lbltitulo = New System.Windows.Forms.Label
        Me.lblrol = New System.Windows.Forms.Label
        Me.btnclose = New System.Windows.Forms.Button
        Me.lbltipou = New System.Windows.Forms.Label
        Me.btnfin = New System.Windows.Forms.Button
        Me.calcgrado = New System.Windows.Forms.TextBox
        Me.txtcedula = New System.Windows.Forms.TextBox
        Me.ttci = New System.Windows.Forms.ToolTip(Me.components)
        Me.btncont = New System.Windows.Forms.Button
        Me.btnver = New System.Windows.Forms.Button
        Me.dgvdoc = New System.Windows.Forms.DataGridView
        Me.btnmenu = New System.Windows.Forms.Button
        Me.lblsiba = New System.Windows.Forms.Label
        Me.lbldesarrollo = New System.Windows.Forms.Label
        Me.pbxlogo = New System.Windows.Forms.PictureBox
        Me.gbxdoc.SuspendLayout()
        Me.gbxedit.SuspendLayout()
        CType(Me.dgvdoc, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbxlogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnaceptar
        '
        Me.btnaceptar.BackColor = System.Drawing.Color.Transparent
        Me.btnaceptar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnaceptar.Location = New System.Drawing.Point(366, 153)
        Me.btnaceptar.Name = "btnaceptar"
        Me.btnaceptar.Size = New System.Drawing.Size(101, 24)
        Me.btnaceptar.TabIndex = 19
        Me.btnaceptar.Text = "Insert"
        Me.btnaceptar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage
        Me.btnaceptar.UseVisualStyleBackColor = False
        '
        'btncancel
        '
        Me.btncancel.BackColor = System.Drawing.Color.Transparent
        Me.btncancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btncancel.Location = New System.Drawing.Point(366, 193)
        Me.btncancel.Name = "btncancel"
        Me.btncancel.Size = New System.Drawing.Size(101, 22)
        Me.btncancel.TabIndex = 18
        Me.btncancel.Text = "Cancel"
        Me.btncancel.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage
        Me.btncancel.UseVisualStyleBackColor = False
        '
        'gbxdoc
        '
        Me.gbxdoc.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.gbxdoc.Controls.Add(Me.lbldatos_Ci)
        Me.gbxdoc.Controls.Add(Me.gbxedit)
        Me.gbxdoc.Controls.Add(Me.cmbcatdoc)
        Me.gbxdoc.Controls.Add(Me.txttel)
        Me.gbxdoc.Controls.Add(Me.txtant)
        Me.gbxdoc.Controls.Add(Me.txtformac)
        Me.gbxdoc.Controls.Add(Me.txtci)
        Me.gbxdoc.Controls.Add(Me.txtnombre)
        Me.gbxdoc.Controls.Add(Me.lbltel)
        Me.gbxdoc.Controls.Add(Me.lblformac)
        Me.gbxdoc.Controls.Add(Me.lblant)
        Me.gbxdoc.Controls.Add(Me.lblgrado)
        Me.gbxdoc.Controls.Add(Me.lblci)
        Me.gbxdoc.Controls.Add(Me.lblnombre)
        Me.gbxdoc.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbxdoc.Location = New System.Drawing.Point(15, 80)
        Me.gbxdoc.Name = "gbxdoc"
        Me.gbxdoc.Size = New System.Drawing.Size(320, 269)
        Me.gbxdoc.TabIndex = 21
        Me.gbxdoc.TabStop = False
        Me.gbxdoc.Text = "Teachers"
        '
        'lbldatos_Ci
        '
        Me.lbldatos_Ci.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.lbldatos_Ci.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbldatos_Ci.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbldatos_Ci.Location = New System.Drawing.Point(156, 85)
        Me.lbldatos_Ci.Name = "lbldatos_Ci"
        Me.lbldatos_Ci.Size = New System.Drawing.Size(71, 22)
        Me.lbldatos_Ci.TabIndex = 82
        Me.lbldatos_Ci.Text = "Formato"
        Me.lbldatos_Ci.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'gbxedit
        '
        Me.gbxedit.Controls.Add(Me.Label1)
        Me.gbxedit.Controls.Add(Me.Label6)
        Me.gbxedit.Controls.Add(Me.Label4)
        Me.gbxedit.Controls.Add(Me.Label3)
        Me.gbxedit.Controls.Add(Me.Label2)
        Me.gbxedit.Controls.Add(Me.lblver)
        Me.gbxedit.Location = New System.Drawing.Point(236, 25)
        Me.gbxedit.Name = "gbxedit"
        Me.gbxedit.Size = New System.Drawing.Size(72, 230)
        Me.gbxedit.TabIndex = 29
        Me.gbxedit.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(51, 20)
        Me.Label1.TabIndex = 23
        Me.Label1.Text = "Editar"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(6, 195)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(51, 20)
        Me.Label6.TabIndex = 28
        Me.Label6.Text = "Editar"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(6, 150)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(51, 20)
        Me.Label4.TabIndex = 26
        Me.Label4.Text = "Editar"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 106)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(51, 20)
        Me.Label3.TabIndex = 25
        Me.Label3.Text = "Editar"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 62)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(51, 20)
        Me.Label2.TabIndex = 24
        Me.Label2.Text = "Editar"
        '
        'lblver
        '
        Me.lblver.AutoSize = True
        Me.lblver.Location = New System.Drawing.Point(23, 152)
        Me.lblver.Name = "lblver"
        Me.lblver.Size = New System.Drawing.Size(0, 20)
        Me.lblver.TabIndex = 19
        '
        'cmbcatdoc
        '
        Me.cmbcatdoc.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbcatdoc.FormattingEnabled = True
        Me.cmbcatdoc.Items.AddRange(New Object() {"(Seleccione)", "Efectivo", "Interino", "Suplente"})
        Me.cmbcatdoc.Location = New System.Drawing.Point(109, 129)
        Me.cmbcatdoc.Name = "cmbcatdoc"
        Me.cmbcatdoc.Size = New System.Drawing.Size(121, 24)
        Me.cmbcatdoc.TabIndex = 15
        '
        'txttel
        '
        Me.txttel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txttel.Location = New System.Drawing.Point(9, 218)
        Me.txttel.MaxLength = 10
        Me.txttel.Name = "txttel"
        Me.txttel.Size = New System.Drawing.Size(218, 22)
        Me.txttel.TabIndex = 12
        '
        'txtant
        '
        Me.txtant.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtant.Location = New System.Drawing.Point(9, 129)
        Me.txtant.MaxLength = 2
        Me.txtant.Name = "txtant"
        Me.txtant.Size = New System.Drawing.Size(94, 22)
        Me.txtant.TabIndex = 11
        '
        'txtformac
        '
        Me.txtformac.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtformac.Location = New System.Drawing.Point(9, 173)
        Me.txtformac.Name = "txtformac"
        Me.txtformac.Size = New System.Drawing.Size(218, 22)
        Me.txtformac.TabIndex = 9
        '
        'txtci
        '
        Me.txtci.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.txtci.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtci.Location = New System.Drawing.Point(9, 85)
        Me.txtci.MaxLength = 8
        Me.txtci.Name = "txtci"
        Me.txtci.Size = New System.Drawing.Size(218, 22)
        Me.txtci.TabIndex = 7
        '
        'txtnombre
        '
        Me.txtnombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtnombre.Location = New System.Drawing.Point(9, 41)
        Me.txtnombre.Name = "txtnombre"
        Me.txtnombre.Size = New System.Drawing.Size(218, 22)
        Me.txtnombre.TabIndex = 6
        '
        'lbltel
        '
        Me.lbltel.AutoSize = True
        Me.lbltel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltel.Location = New System.Drawing.Point(6, 198)
        Me.lbltel.Name = "lbltel"
        Me.lbltel.Size = New System.Drawing.Size(50, 16)
        Me.lbltel.TabIndex = 5
        Me.lbltel.Text = "Phone:"
        '
        'lblformac
        '
        Me.lblformac.AutoSize = True
        Me.lblformac.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblformac.Location = New System.Drawing.Point(6, 154)
        Me.lblformac.Name = "lblformac"
        Me.lblformac.Size = New System.Drawing.Size(124, 16)
        Me.lblformac.TabIndex = 4
        Me.lblformac.Text = "Academic Training:"
        '
        'lblant
        '
        Me.lblant.AutoSize = True
        Me.lblant.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblant.Location = New System.Drawing.Point(6, 110)
        Me.lblant.Name = "lblant"
        Me.lblant.Size = New System.Drawing.Size(61, 16)
        Me.lblant.TabIndex = 3
        Me.lblant.Text = "Antiquity:"
        '
        'lblgrado
        '
        Me.lblgrado.AutoSize = True
        Me.lblgrado.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblgrado.Location = New System.Drawing.Point(109, 110)
        Me.lblgrado.Name = "lblgrado"
        Me.lblgrado.Size = New System.Drawing.Size(126, 16)
        Me.lblgrado.TabIndex = 2
        Me.lblgrado.Text = "Teaching Category:"
        '
        'lblci
        '
        Me.lblci.AutoSize = True
        Me.lblci.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblci.Location = New System.Drawing.Point(6, 66)
        Me.lblci.Name = "lblci"
        Me.lblci.Size = New System.Drawing.Size(72, 16)
        Me.lblci.TabIndex = 1
        Me.lblci.Text = "Document:"
        '
        'lblnombre
        '
        Me.lblnombre.AutoSize = True
        Me.lblnombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblnombre.Location = New System.Drawing.Point(6, 22)
        Me.lblnombre.Name = "lblnombre"
        Me.lblnombre.Size = New System.Drawing.Size(117, 16)
        Me.lblnombre.TabIndex = 0
        Me.lblnombre.Text = "Completed Name:"
        '
        'lbltitulo
        '
        Me.lbltitulo.AutoSize = True
        Me.lbltitulo.BackColor = System.Drawing.Color.LemonChiffon
        Me.lbltitulo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbltitulo.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltitulo.Location = New System.Drawing.Point(15, 9)
        Me.lbltitulo.Name = "lbltitulo"
        Me.lbltitulo.Size = New System.Drawing.Size(244, 26)
        Me.lbltitulo.TabIndex = 52
        Me.lbltitulo.Text = "INGRESO DE DOCENTE"
        '
        'lblrol
        '
        Me.lblrol.AutoSize = True
        Me.lblrol.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblrol.Location = New System.Drawing.Point(417, 9)
        Me.lblrol.Name = "lblrol"
        Me.lblrol.Size = New System.Drawing.Size(45, 16)
        Me.lblrol.TabIndex = 71
        Me.lblrol.Text = "Role:"
        '
        'btnclose
        '
        Me.btnclose.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnclose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnclose.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnclose.Location = New System.Drawing.Point(501, 28)
        Me.btnclose.Name = "btnclose"
        Me.btnclose.Size = New System.Drawing.Size(102, 24)
        Me.btnclose.TabIndex = 70
        Me.btnclose.Text = "Log out"
        Me.btnclose.UseVisualStyleBackColor = True
        '
        'lbltipou
        '
        Me.lbltipou.AutoSize = True
        Me.lbltipou.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltipou.Location = New System.Drawing.Point(466, 9)
        Me.lbltipou.Name = "lbltipou"
        Me.lbltipou.Size = New System.Drawing.Size(127, 16)
        Me.lbltipou.TabIndex = 69
        Me.lbltipou.Text = "School Secretary"
        '
        'btnfin
        '
        Me.btnfin.BackColor = System.Drawing.Color.Transparent
        Me.btnfin.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnfin.Location = New System.Drawing.Point(366, 233)
        Me.btnfin.Name = "btnfin"
        Me.btnfin.Size = New System.Drawing.Size(101, 22)
        Me.btnfin.TabIndex = 73
        Me.btnfin.Text = "Finalize"
        Me.btnfin.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage
        Me.btnfin.UseVisualStyleBackColor = False
        '
        'calcgrado
        '
        Me.calcgrado.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.calcgrado.Location = New System.Drawing.Point(311, 9)
        Me.calcgrado.Name = "calcgrado"
        Me.calcgrado.Size = New System.Drawing.Size(100, 20)
        Me.calcgrado.TabIndex = 74
        '
        'txtcedula
        '
        Me.txtcedula.Location = New System.Drawing.Point(366, 55)
        Me.txtcedula.Name = "txtcedula"
        Me.txtcedula.Size = New System.Drawing.Size(100, 20)
        Me.txtcedula.TabIndex = 75
        '
        'ttci
        '
        '
        'btncont
        '
        Me.btncont.Location = New System.Drawing.Point(483, 340)
        Me.btncont.Name = "btncont"
        Me.btncont.Size = New System.Drawing.Size(120, 23)
        Me.btncont.TabIndex = 78
        Me.btncont.Text = "Continue"
        Me.btncont.UseVisualStyleBackColor = True
        '
        'btnver
        '
        Me.btnver.Location = New System.Drawing.Point(456, 340)
        Me.btnver.Name = "btnver"
        Me.btnver.Size = New System.Drawing.Size(120, 23)
        Me.btnver.TabIndex = 77
        Me.btnver.Text = "Verify entry"
        Me.btnver.UseVisualStyleBackColor = True
        '
        'dgvdoc
        '
        Me.dgvdoc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvdoc.Location = New System.Drawing.Point(473, 80)
        Me.dgvdoc.MultiSelect = False
        Me.dgvdoc.Name = "dgvdoc"
        Me.dgvdoc.ReadOnly = True
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.IndianRed
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvdoc.RowHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgvdoc.RowHeadersWidth = 30
        Me.dgvdoc.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvdoc.Size = New System.Drawing.Size(198, 110)
        Me.dgvdoc.TabIndex = 79
        '
        'btnmenu
        '
        Me.btnmenu.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnmenu.ForeColor = System.Drawing.Color.Red
        Me.btnmenu.Location = New System.Drawing.Point(15, 355)
        Me.btnmenu.Name = "btnmenu"
        Me.btnmenu.Size = New System.Drawing.Size(162, 23)
        Me.btnmenu.TabIndex = 81
        Me.btnmenu.Text = "Menú Docentes"
        Me.btnmenu.UseVisualStyleBackColor = True
        '
        'lblsiba
        '
        Me.lblsiba.Font = New System.Drawing.Font("Pristina", 26.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblsiba.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblsiba.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblsiba.Location = New System.Drawing.Point(265, 9)
        Me.lblsiba.Name = "lblsiba"
        Me.lblsiba.Size = New System.Drawing.Size(136, 43)
        Me.lblsiba.TabIndex = 154
        Me.lblsiba.Text = "S.I.B.A."
        '
        'lbldesarrollo
        '
        Me.lbldesarrollo.AutoSize = True
        Me.lbldesarrollo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.lbldesarrollo.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lbldesarrollo.Location = New System.Drawing.Point(433, 320)
        Me.lbldesarrollo.Name = "lbldesarrollo"
        Me.lbldesarrollo.Size = New System.Drawing.Size(186, 13)
        Me.lbldesarrollo.TabIndex = 153
        Me.lbldesarrollo.Text = "Development and maintenance:"
        '
        'pbxlogo
        '
        Me.pbxlogo.Image = CType(resources.GetObject("pbxlogo.Image"), System.Drawing.Image)
        Me.pbxlogo.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.pbxlogo.Location = New System.Drawing.Point(469, 339)
        Me.pbxlogo.Name = "pbxlogo"
        Me.pbxlogo.Size = New System.Drawing.Size(139, 44)
        Me.pbxlogo.TabIndex = 152
        Me.pbxlogo.TabStop = False
        '
        'ialtadoc
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(620, 386)
        Me.Controls.Add(Me.lblsiba)
        Me.Controls.Add(Me.lbldesarrollo)
        Me.Controls.Add(Me.pbxlogo)
        Me.Controls.Add(Me.btnmenu)
        Me.Controls.Add(Me.dgvdoc)
        Me.Controls.Add(Me.btncont)
        Me.Controls.Add(Me.btnver)
        Me.Controls.Add(Me.txtcedula)
        Me.Controls.Add(Me.calcgrado)
        Me.Controls.Add(Me.btnfin)
        Me.Controls.Add(Me.lblrol)
        Me.Controls.Add(Me.btnclose)
        Me.Controls.Add(Me.lbltipou)
        Me.Controls.Add(Me.lbltitulo)
        Me.Controls.Add(Me.gbxdoc)
        Me.Controls.Add(Me.btnaceptar)
        Me.Controls.Add(Me.btncancel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "ialtadoc"
        Me.Text = "S.I.B.A"
        Me.gbxdoc.ResumeLayout(False)
        Me.gbxdoc.PerformLayout()
        Me.gbxedit.ResumeLayout(False)
        Me.gbxedit.PerformLayout()
        CType(Me.dgvdoc, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbxlogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnaceptar As System.Windows.Forms.Button
    Friend WithEvents btncancel As System.Windows.Forms.Button
    Friend WithEvents gbxdoc As System.Windows.Forms.GroupBox
    Friend WithEvents txttel As System.Windows.Forms.TextBox
    Friend WithEvents txtant As System.Windows.Forms.TextBox
    Friend WithEvents txtformac As System.Windows.Forms.TextBox
    Friend WithEvents txtci As System.Windows.Forms.TextBox
    Friend WithEvents txtnombre As System.Windows.Forms.TextBox
    Friend WithEvents lbltel As System.Windows.Forms.Label
    Friend WithEvents lblformac As System.Windows.Forms.Label
    Friend WithEvents lblant As System.Windows.Forms.Label
    Friend WithEvents lblgrado As System.Windows.Forms.Label
    Friend WithEvents lblci As System.Windows.Forms.Label
    Friend WithEvents lblnombre As System.Windows.Forms.Label
    Friend WithEvents lbltitulo As System.Windows.Forms.Label
    Friend WithEvents lblrol As System.Windows.Forms.Label
    Friend WithEvents btnclose As System.Windows.Forms.Button
    Friend WithEvents lbltipou As System.Windows.Forms.Label
    Friend WithEvents btnfin As System.Windows.Forms.Button
    Friend WithEvents cmbcatdoc As System.Windows.Forms.ComboBox
    Friend WithEvents calcgrado As System.Windows.Forms.TextBox
    Friend WithEvents txtcedula As System.Windows.Forms.TextBox
    Friend WithEvents gbxedit As System.Windows.Forms.GroupBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lblver As System.Windows.Forms.Label
    Friend WithEvents lbldatos_Ci As System.Windows.Forms.Label
    Friend WithEvents ttci As System.Windows.Forms.ToolTip
    Friend WithEvents btncont As System.Windows.Forms.Button
    Friend WithEvents btnver As System.Windows.Forms.Button
    Friend WithEvents dgvdoc As System.Windows.Forms.DataGridView
    Friend WithEvents btnmenu As System.Windows.Forms.Button
    Friend WithEvents lblsiba As System.Windows.Forms.Label
    Friend WithEvents lbldesarrollo As System.Windows.Forms.Label
    Friend WithEvents pbxlogo As System.Windows.Forms.PictureBox
End Class

