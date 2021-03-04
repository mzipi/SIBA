Public Class asignhoramat

    Private Sub Form49_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        cmbaño.SelectedIndex = 0
        'carga datos de carreras existentes
        Dim cx2 As New Odbc.OdbcConnection
        Dim cm2 As New Odbc.OdbcCommand
        Dim da2 As New Odbc.OdbcDataAdapter
        Dim ds2 As New DataSet
        Dim dr2 As Odbc.OdbcDataReader
        cx2.ConnectionString = "FileDSN=c:\itechplus_sec.dsn;UID=techplus_sec;pwd=1234"
        cx2.Open()

        cm2.CommandText = "SELECT nombre_carr  from carreras"
        cm2.Connection = cx2
        dr2 = cm2.ExecuteReader
        cmbcarrera.Items.Add("(Seleccione)")
        While dr2.Read
            cmbcarrera.Items.Add(dr2.GetString(0))

        End While
        cmbcarrera.SelectedIndex = 0
        dr2.Close()
        cx2.Close()

        Dim cx3 As New Odbc.OdbcConnection
        Dim cm3 As New Odbc.OdbcCommand
        Dim da3 As New Odbc.OdbcDataAdapter
        Dim ds3 As New DataSet
        Dim dr3 As Odbc.OdbcDataReader
        cx3.ConnectionString = "FileDSN=c:\itechplus_sec.dsn;UID=techplus_sec;pwd=1234"
        cx3.Open()

        cm3.CommandText = "SELECT nombre_turno from turno"
        cm3.Connection = cx3

        dr3 = cm3.ExecuteReader
        cmbturno.Items.Add("(Seleccione)")
        While dr3.Read
            cmbturno.Items.Add(dr3.GetString(0))
            cmbturno.SelectedIndex = 0
        End While
        cmbturno.SelectedIndex = 0

        dr3.Close()
        cx3.Close()



        
        End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        
        
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        gbxsel.Visible = True
        gbxsel.SetBounds(15, 92, 275, 209)



    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        If (cmbcarrera.SelectedIndex = 0) Then
            MsgBox("Debe seleccionar una carrera")
        End If
        If (cmbgrupoele.SelectedIndex = 0) Then
            MsgBox("Debe seleccionar un grupo")
        End If
        If (cmbdia.SelectedIndex = 0) Then
            MsgBox("Debe seleccionar un día")
        End If
        If (cmbhoras.SelectedIndex <> 0) Then
            MsgBox("Debe ingresar el/los numero/s de hora/s")
        End If
        If (cmbcarrera.SelectedIndex <> 0 And cmbdia.SelectedIndex <> 0 And cmbgrupoele.SelectedIndex <> 0 And cmbhoras.SelectedIndex <> 0) Then

            gbxsel.Visible = False

        End If



    End Sub

    Private Sub Label16_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

        MsgBox("Ha ingresado la información correctamente")
        gbxsel.Visible = False
        cmbgrupoele.SelectedIndex = 0
        cmbdia.SelectedIndex = 0
        cmbcarrera.SelectedIndex = 0
        
    End Sub
    Private Sub Label12_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        gbxsel.Visible = False
        cmbgrupoele.SelectedIndex = 0
        cmbdia.SelectedIndex = 0
        cmbcarrera.SelectedIndex = 0
        abmMateria.Show()
        Me.Hide()
    End Sub

    
    
    Private Sub ComboBox4_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cmbcarrera.KeyPress
        If (e.KeyChar < "0" Or e.KeyChar > "9") And e.KeyChar <> Chr(Keys.Back) Then
            e.KeyChar = ""
        End If
        If Char.IsLetter(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If

    End Sub

    Private Sub ComboBox4_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbcarrera.SelectedIndexChanged
        ' Dim i As Integer
        'Dim f As Integer
        'f = 1

        'If cmbcarrera.SelectedIndex <> 0 Then
        ' Dim cx2 As New Odbc.OdbcConnection
        ' Dim cm2 As New Odbc.OdbcCommand
        ' Dim lector As Odbc.OdbcDataReader
        ' cx2.ConnectionString = "FileDSN=c:\itechplus_sec.dsn;UID=techplus_sec;pwd=1234"
        ' cx2.Open()

        ' cm2.CommandText = "SELECT duracion from carreras where nombre_carr='" + cmbcarrera.SelectedItem + "'"
        ' cm2.Connection = cx2
        'lector = cm2.ExecuteReader()
        'cmbaño.Items.Add("(Seleccione)")
        ' If lector.HasRows Then
        ' i = lector.GetString(0)

        ' While (f <= I)
        'cmbaño.Items.Add((f))
        'f += 1

        ' End While

        'cmbaño.SelectedIndex = 0
        'cx2.Close()
        'End If


        '   End If

        If cmbcarrera.SelectedIndex <> 0 Then
            Dim cx32 As New Odbc.OdbcConnection
            Dim cm32 As New Odbc.OdbcCommand
            Dim da32 As New Odbc.OdbcDataAdapter
            Dim ds32 As New DataSet
            Dim dr32 As Odbc.OdbcDataReader

            cx32.ConnectionString = "FileDSN=c:\itechplus_sec.dsn;UID=techplus_sec;pwd=1234"

            cx32.Open()
            cm32.CommandText = "select nombre_mat from materias where materias.nombre_carr='" + cmbcarrera.SelectedItem + "' and materias.anio_de_la_materia=" + cmbaño.SelectedIndex
            cm32.Connection = cx32
            dr32 = cm32.ExecuteReader
            cmbmat.Items.Add("(Seleccione)")
            While dr32.Read
                cmbmat.Items.Add(dr32.GetString(0))

            End While
            cmbmat.SelectedIndex = 0
            dr32.Close()
            cx32.Close()

        End If

    End Sub

    Private Sub ComboBox1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)

        If (e.KeyChar < "0" Or e.KeyChar > "9") And e.KeyChar <> Chr(Keys.Back) Then
            e.KeyChar = ""
        End If
        If Char.IsLetter(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim cx2 As New Odbc.OdbcConnection
        Dim cm2 As New Odbc.OdbcCommand
        Dim da2 As New Odbc.OdbcDataAdapter
        Dim ds2 As New DataSet
        Dim dr2 As Odbc.OdbcDataReader
        cx2.ConnectionString = "FileDSN=c:\itechplus_sec.dsn;UID=techplus_sec;pwd=1234"
        cx2.Open()

        cm2.CommandText = "select distinct inicio||' ' ||fin from horas,se_divide,turno where turno.id_turno=" + txtid_turno.Text + " and se_divide.id_turno=" + txtid_turno.Text + " and horas.id_horas=se_divide.id_horas"
        cm2.Connection = cx2
        dr2 = cm2.ExecuteReader
        cmbhoras.Items.Add("(Seleccione)")
        While dr2.Read
            cmbhoras.Items.Add(dr2.GetString(0))

        End While
        cmbhoras.SelectedIndex = 0
        dr2.Close()
        cx2.Close()



    End Sub

    Private Sub TextBox1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf e.KeyChar = "," Then
            e.Handled = False
        ElseIf e.KeyChar = ":" Then
            e.Handled = False
        ElseIf e.KeyChar = " " Then
            e.Handled = False

        Else
            e.Handled = True
        End If
    End Sub


    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)



    End Sub

    Private Sub Label7_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label7.Click

    End Sub

    Private Sub cmbgrupoele_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cmbgrupoele.KeyPress
        If (e.KeyChar < "0" Or e.KeyChar > "9") And e.KeyChar <> Chr(Keys.Back) Then
            e.KeyChar = ""
        End If
        If Char.IsLetter(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbgrupoele.SelectedIndexChanged

    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        Select Case MsgBox("Desea cerrar sesión?", MsgBoxStyle.YesNo)
            Case MsgBoxResult.Yes
                gbxsel.Visible = False
                cmbgrupoele.SelectedIndex = 0
                cmbdia.SelectedIndex = 0
                cmbcarrera.SelectedIndex = 0
                cmbhoras.SelectedIndex = 0

                login.txtpass.clear()

                login.txtusuario.clear()
                login.Show()
                Me.Hide()
            Case MsgBoxResult.No
                Me.Hide()
                Me.Show()
        End Select
    End Sub

    Private Sub Label8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label8.Click

    End Sub

   
    Private Sub ComboBox1_SelectedIndexChanged_2(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbaño.SelectedIndexChanged

        If (cmbaño.SelectedIndex <> 0) Then
            Dim año As Integer
            año = cmbaño.SelectedItem
            cmbgrupoele.Items.Clear()

            If cmbaño.SelectedIndex <> 0 Then
                Dim cx7 As New Odbc.OdbcConnection
                Dim cm7 As New Odbc.OdbcCommand
                Dim da7 As New Odbc.OdbcDataAdapter
                Dim ds7 As New DataSet
                Dim dr7 As Odbc.OdbcDataReader
                cx7.ConnectionString = "FileDSN=c:\itechplus_sec.dsn;UID=techplus_sec;pwd=1234"
                cx7.Open()
                cm7.CommandText = "select distinct anio||curso||letra from grupos g, materias m, carreras c where  m.nombre_carr='" + cmbcarrera.SelectedItem + "' and m.anio_de_la_materia = " + cmbaño.SelectedItem + "and g.anio= m.anio_de_la_materia and m.nombre_carr= c.nombre_carr and g.nombre_carr=m.nombre_carr"
                cm7.Connection = cx7
                dr7 = cm7.ExecuteReader
                cmbgrupoele.Items.Add("(Seleccione)")
                While dr7.Read
                    cmbgrupoele.Items.Add(dr7.GetString(0))

                End While
                cmbgrupoele.SelectedIndex = 0
                dr7.Close()
                cx7.Close()

            End If

        End If




    End Sub

    Private Sub cmbturno_SelectedIndexChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbturno.SelectedIndexChanged
        Dim cx2 As New Odbc.OdbcConnection
        Dim cm2 As New Odbc.OdbcCommand
        Dim lector As Odbc.OdbcDataReader
        cx2.ConnectionString = "FileDSN=c:\itechplus_sec.dsn;UID=techplus_sec;pwd=1234"
        cx2.Open()

        cm2.CommandText = "select id_turno from turno where nombre_turno='" + cmbturno.SelectedItem + "'"
        cm2.Connection = cx2
        lector = cm2.ExecuteReader()
        If lector.HasRows Then
            txtid_turno.Text = lector.GetString(0)
            cx2.Close()
        End If


    End Sub

    Private Sub cmbmat_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbmat.SelectedIndexChanged

    End Sub

    Private Sub cmbdia_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbdia.SelectedIndexChanged
        Dim cx7 As New Odbc.OdbcConnection
        Dim cm7 As New Odbc.OdbcCommand
        Dim da7 As New Odbc.OdbcDataAdapter
        Dim ds7 As New DataSet
        Dim dr7 As Odbc.OdbcDataReader
        cx7.ConnectionString = "FileDSN=c:\itechplus_sec.dsn;UID=techplus_sec;pwd=1234"
        cx7.Open()

        cm7.CommandText = "select distinct  dia,inicio,fin nombre_turno from horas, turno,se_divide where horas.id_horas = se_divide.id_horas And turno.id_turno = se_divide.id_turno and turno.id_turno=" + txtid_turno.Text

        cm7.Connection = cx7
        dr7 = cm7.ExecuteReader
        cmbhoras.Items.Add("(Seleccione)")
        While dr7.Read
            cmbhoras.Items.Add(dr7.GetString(0))

        End While
        cmbhoras.SelectedIndex = 0
        dr7.Close()
        cx7.Close()


    End Sub

    Private Sub GroupBox1_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox1.Enter

    End Sub
End Class