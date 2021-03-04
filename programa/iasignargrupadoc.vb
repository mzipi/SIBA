Public Class iasignargrupadoc

    Dim cont As Integer


    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Form27_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        txtaño.Visible = False
        txtidturno.Visible = False
        txtcodmat.Visible = False
        txtcodgrupo.Visible = False

        Timer1.Start()

        Dim cx As New Odbc.OdbcConnection
        Dim cm As New Odbc.OdbcCommand
        Dim da As New Odbc.OdbcDataAdapter
        Dim ds As New DataSet
        Dim dr As Odbc.OdbcDataReader
        cx.ConnectionString = "FileDSN=c:\itechplus_sec.dsn;UID=techplus_sec;pwd=1234"
        cx.Open()

        cm.CommandText = "SELECT nombre_completo from docentes"
        cm.Connection = cx

        dr = cm.ExecuteReader
        cmbdocente.Items.Add("(Seleccione)")
        While dr.Read
            cmbdocente.Items.Add(dr.GetString(0))
        End While
        cmbdocente.SelectedIndex = 0
        dr.Close()
        cx.Close()


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

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnconf.Click

        'comienza la asignación del docente
        If (cmbdocente.SelectedIndex <> 0 And cmbturno.SelectedIndex <> 0 And cmbgrupos.SelectedIndex <> 0 And cmbcarrera.SelectedIndex <> 0 And cmbmat.SelectedIndex <> 0) Then

            Dim cx As New Odbc.OdbcConnection
            Dim cm As New Odbc.OdbcCommand
            Dim da As New Odbc.OdbcDataAdapter
            Dim ds As New Data.DataSet

            cx.ConnectionString = "FileDSN=c:\itechplus_sec.dsn;UID=techplus_sec;pwd=1234"
            cx.Open()
            cm.Connection = cx
            cm.CommandText = "SELECT idg,cod_materia FROM tienen where idg=" + txtcodgrupo.Text + " and cod_materia='" + txtcodmat.Text + "'"
            cm.ExecuteNonQuery()
            da.SelectCommand = cm
            da.Fill(ds, "tienen")

            If ds.Tables("tienen").Rows.Count = 0 Then
                Select Case MsgBox("The subject is not associated with the Group. You want associate the subject to assign the teacher  ." + cmbdocente.SelectedItem + "?", MsgBoxStyle.YesNo)
                    Case MsgBoxResult.Yes
                        Dim sql As String = ""
                        Dim cx2 As New Odbc.OdbcConnection
                        Dim cm2 As New Odbc.OdbcCommand
                        ' se ingresan datos en la tabla tienen (grupo materia)
                        sql = "INSERT INTO tienen VALUES (" + txtcodgrupo.Text + ",'"
                        sql += txtcodmat.Text + "')"
                        cx2.ConnectionString = "FileDSN=c:\itechplus_sec.dsn;UID=techplus_sec;pwd=1234"
                        cx2.Open()
                        cm2.Connection = cx2
                        cm2.CommandText = sql
                        cm2.ExecuteNonQuery()
                        cx2.Close()

                        MsgBox("Group associated subject successfully. Teacher will be assigned.")

                        Dim sql2 As String = ""
                        Dim cx3 As New Odbc.OdbcConnection
                        Dim cm3 As New Odbc.OdbcCommand

                        sql2 = "INSERT INTO asignados (ci, idg,cod_materia,fecha) values (" + txtcidoc.Text + ","
                        sql2 += txtcodgrupo.Text + ",'"
                        sql2 += txtcodmat.Text + "','" + dtpfecha.Value.ToString("dd/mm/yyyy") + "')"
                        cx3.ConnectionString = "FileDSN=c:\itechplus_sec.dsn;UID=techplus_sec;pwd=1234"
                        cx3.Open()
                        cm3.Connection = cx3
                        cm3.CommandText = sql2
                        cm3.ExecuteNonQuery()
                        cx3.Close()

                        MsgBox("Teacher assigned successfully")

                        abmdocentes.Show()
                        Me.Close()
                        cmbdocente.Items.Clear()
                        cmbturno.Items.Clear()
                        cmbcarrera.Items.Clear()
                        cmbgrupos.Items.Clear()
                        cmbmat.Items.Clear()

                    Case MsgBoxResult.No
                        MsgBox("No teacher will be assigned to the group and requested the subject,because they are not associates with the group the subject")

                        abmdocentes.Show()
                        Me.Close()
                        cmbdocente.Items.Clear()
                        cmbturno.Items.Clear()
                        cmbcarrera.Items.Clear()
                        cmbgrupos.Items.Clear()
                        cmbmat.Items.Clear()

                End Select

            Else
                MsgBox("Already the subject is associated with the group. Will check if you can assign the teacher")

                'se verifica que ya no tenga un docente asignado


                Dim cx4 As New Odbc.OdbcConnection
                Dim cm4 As New Odbc.OdbcCommand
                Dim da4 As New Odbc.OdbcDataAdapter
                Dim ds4 As New Data.DataSet

                cx4.ConnectionString = "FileDSN=c:\itechplus_sec.dsn;UID=techplus_sec;pwd=1234"
                cx4.Open()
                cm4.Connection = cx4
                cm4.CommandText = "SELECT * from asignados  where ci ='" + txtcidoc.Text + "' and idg=" + txtcodgrupo.Text + " and cod_materia='" + txtcodmat.Text + "' and estado= 'Ocupado'"
                cm4.ExecuteNonQuery()
                da4.SelectCommand = cm4
                da4.Fill(ds4, "docente")
                'si ya existe un docente asignado vuelve al abmdocentes
                If ds4.Tables("docente").Rows.Count > 0 Then
                    MsgBox("There is already a teacher assigned to that group. Check the data")
                    cx4.Close()
                    abmdocentes.Show()
                    Me.Close()
                    cmbdocente.Items.Clear()
                    cmbturno.Items.Clear()
                    cmbcarrera.Items.Clear()
                    cmbgrupos.Items.Clear()
                    cmbmat.Items.Clear()

                Else
                    'si no existe docente asignado lo ingresa

                    Dim sql2 As String = ""
                    Dim cx3 As New Odbc.OdbcConnection
                    Dim cm3 As New Odbc.OdbcCommand

                    sql2 = "INSERT INTO asignados (ci, idg,cod_materia,fecha) values (" + txtcidoc.Text + ","
                    sql2 += txtcodgrupo.Text + ",'"
                    sql2 += txtcodmat.Text + "','" + dtpfecha.Value.ToString("MM/dd/yyyy") + "')"
                    cx3.ConnectionString = "FileDSN=c:\itechplus_sec.dsn;UID=techplus_sec;pwd=1234"
                    cx3.Open()
                    cm3.Connection = cx3
                    cm3.CommandText = sql2
                    cm3.ExecuteNonQuery()
                    cx3.Close()

                    MsgBox("Teacher assigned successfully")

                    abmdocentes.Show()
                    Me.Close()
                    cmbdocente.Items.Clear()
                    cmbturno.Items.Clear()
                    cmbcarrera.Items.Clear()
                    cmbgrupos.Items.Clear()
                    cmbmat.Items.Clear()



                End If
                cx.Close()
            End If

        End If

    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnatras.Click

        cmbdocente.Items.Clear()
        cmbturno.Items.Clear()
        cmbcarrera.Items.Clear()
        cmbgrupos.Items.Clear()
        cmbmat.Items.Clear()



        iabmdoc.Show()


        Me.Hide()
    End Sub


    Private Sub Label9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lbltipou.Click

    End Sub

    Public Sub lblmate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)


    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bnclose.Click
        Select Case MsgBox("Do you want to close this session?", MsgBoxStyle.YesNo)
            Case MsgBoxResult.Yes

                login.txtpass.Clear()
                login.txtusuario.Clear()

                login.Show()
                Me.Close()
            Case MsgBoxResult.No
                Me.Hide()
                Me.Show()
        End Select
    End Sub

    Private Sub lblfecha_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub


    Private Sub lblfechaa_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblfechaa.Click

    End Sub

    Private Sub cmbcarrera_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbcarrera.SelectedIndexChanged
        cmbgrupos.Items.Clear()
        Dim cx As New Odbc.OdbcConnection
        Dim cm As New Odbc.OdbcCommand
        Dim da As New Odbc.OdbcDataAdapter
        Dim ds As New DataSet
        Dim dr As Odbc.OdbcDataReader
        cx.ConnectionString = "FileDSN=c:\itechplus_sec.dsn;UID=techplus_sec;pwd=1234"
        cx.Open()

        cm.CommandText = "SELECT anio||' '||curso||letra from grupos, turno where nombre_carr='" + cmbcarrera.SelectedItem + "' and grupos.id_turno= " + txtidturno.Text + " and turno.id_turno=" + txtidturno.Text
        cm.Connection = cx

        dr = cm.ExecuteReader
        cmbgrupos.Items.Add("(Seleccione)")
        While dr.Read
            cmbgrupos.Items.Add(dr.GetString(0))
        End While
        cmbgrupos.SelectedIndex = 0
        dr.Close()
        cx.Close()


    End Sub

    Private Sub cmbgrupos_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbgrupos.SelectedIndexChanged
        cmbmat.Items.Clear()

        Dim cx2 As New Odbc.OdbcConnection
        Dim cm2 As New Odbc.OdbcCommand
        Dim lector As Odbc.OdbcDataReader
        cx2.ConnectionString = "FileDSN=c:\itechplus_sec.dsn;UID=techplus_sec;pwd=1234"
        cx2.Open()

        cm2.CommandText = "SELECT idg from grupos where anio||' '||curso||letra='" + cmbgrupos.SelectedItem + "'"
        cm2.Connection = cx2
        lector = cm2.ExecuteReader()
        If lector.HasRows Then
            txtcodgrupo.Text = lector.GetString(0)
            cx2.Close()
        End If

        Dim cx3 As New Odbc.OdbcConnection
        Dim cm3 As New Odbc.OdbcCommand
        Dim lector2 As Odbc.OdbcDataReader

        cx3.ConnectionString = "FileDSN=c:\itechplus_sec.dsn;UID=techplus_sec;pwd=1234"
        cx3.Open()

        cm3.CommandText = "SELECT anio from grupos where anio||' '||curso||letra='" + cmbgrupos.SelectedItem + "'"
        cm3.Connection = cx3
        lector2 = cm3.ExecuteReader()
        If lector2.HasRows Then
            txtaño.Text = lector2.GetString(0)
            cx3.Close()
        End If



        If (txtaño.Text <> "") Then

            Dim cx5 As New Odbc.OdbcConnection
            Dim cm5 As New Odbc.OdbcCommand
            Dim da5 As New Odbc.OdbcDataAdapter
            Dim ds5 As New DataSet
            Dim dr5 As Odbc.OdbcDataReader
            cx5.ConnectionString = "FileDSN=c:\itechplus_sec.dsn;UID=techplus_sec;pwd=1234"
            cx5.Open()

            cm5.CommandText = "SELECT distinct nombre_mat from materias,grupos,turno where materias.nombre_carr='" + cmbcarrera.SelectedItem + "' and grupos.anio= " + txtaño.Text + " and materias.anio_de_la_materia= " + txtaño.Text + " and turno.id_turno =" + txtidturno.Text + " and grupos.id_turno =" + txtidturno.Text
            cm5.Connection = cx5

            dr5 = cm5.ExecuteReader
            cmbmat.Items.Add("(Seleccione)")
            While dr5.Read
                cmbmat.Items.Add(dr5.GetString(0))
            End While
            cmbmat.SelectedIndex = 0
            dr5.Close()
            cx5.Close()
        End If
    End Sub

    Private Sub cmbturno_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbturno.SelectedIndexChanged

        Dim cx2 As New Odbc.OdbcConnection
        Dim cm2 As New Odbc.OdbcCommand
        Dim lector As Odbc.OdbcDataReader

        cx2.ConnectionString = "FileDSN=c:\itechplus_sec.dsn;UID=techplus_sec;pwd=1234"
        cx2.Open()

        cm2.CommandText = "SELECT id_turno from turno where nombre_turno='" + cmbturno.SelectedItem + "'"
        cm2.Connection = cx2
        lector = cm2.ExecuteReader()
        If lector.HasRows Then
            txtidturno.Text = lector.GetString(0)

            cx2.Close()

        End If


    End Sub

    Private Sub cmbdocente_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbdocente.SelectedIndexChanged
        Dim cx As New Odbc.OdbcConnection
        Dim cm As New Odbc.OdbcCommand
        Dim lector As Odbc.OdbcDataReader

        cx.ConnectionString = "FileDSN=c:\itechplus_sec.dsn;UID=techplus_sec;pwd=1234"
        cx.Open()

        cm.CommandText = "SELECT ci  from docentes where nombre_completo='" + cmbdocente.SelectedItem + "'"
        cm.Connection = cx
        lector = cm.ExecuteReader()
        If lector.HasRows Then
            txtcidoc.Text = lector.GetString(0)

            cx.Close()

        End If


    End Sub

    Private Sub cmbmat_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbmat.SelectedIndexChanged
        Dim cx2 As New Odbc.OdbcConnection
        Dim cm2 As New Odbc.OdbcCommand
        Dim lector As Odbc.OdbcDataReader

        cx2.ConnectionString = "FileDSN=c:\itechplus_sec.dsn;UID=techplus_sec;pwd=1234"
        cx2.Open()

        cm2.CommandText = "SELECT cod_materia from materias where nombre_carr='" + cmbcarrera.SelectedItem + "' and anio_de_la_materia= " + txtaño.Text + " and nombre_mat='" + cmbmat.SelectedItem + "'"

        cm2.Connection = cx2
        lector = cm2.ExecuteReader()
        If lector.HasRows Then
            txtcodmat.Text = lector.GetString(0)

            cx2.Close()

        End If


    End Sub
End Class