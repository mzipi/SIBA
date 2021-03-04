Public Class ialtagrupo

    Private Sub Label5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label5.Click

    End Sub

    Private Sub btnclose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnclose.Click
        Select Case MsgBox("Do you want close this session?", MsgBoxStyle.YesNo)
            Case MsgBoxResult.Yes

                txtcodgrupo.Clear()
                cmbturno.SelectedIndex = 0

                txtcurso.Clear()
                txtletra.Clear()
                gbxgrup.Visible = False


                cmbcarrera.Visible = True
                cmbcarrera.SelectedIndex = 0
                cmbaño.Visible = False
                cmbaño.SelectedIndex = 0

                login.txtusuario.Clear()
                login.txtpass.Clear()
                login.Show()
                Me.Hide()
            Case MsgBoxResult.No
                Me.Hide()
                Me.Show()
        End Select
    End Sub

    Private Sub btnaceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnaceptar.Click
        Dim control As Integer
        control = 0
        txtcurso.Text = UCase(txtcurso.Text)
        txtletra.Text = UCase(txtletra.Text)

        'controla que no se repita el cod grupo al ingresar
        If (accion = acciones.ingresar) Then
            Dim cx As New Odbc.OdbcConnection
            Dim cm As New Odbc.OdbcCommand
            Dim da As New Odbc.OdbcDataAdapter
            Dim ds As New Data.DataSet

            cx.ConnectionString = "FileDSN=c:\itechplus_sec.dsn;UID=techplus_sec;pwd=1234"
            cx.Open()
            cm.Connection = cx
            'cm.CommandText = "SELECT idg FROM grupos where  idg =" + txtcodgrupo.Text
            cm.CommandText = "SELECT idg FROM grupos where  curso ='" + txtcurso.Text + "' and anio= " + cmbaño.SelectedItem + " and letra ='" + txtletra.Text + "'"

            cm.ExecuteNonQuery()
            da.SelectCommand = cm
            da.Fill(ds, "grupos")

            If ds.Tables("grupos").Rows.Count > 0 Then
                MsgBox("Group already exists with this combination")
                control = 1
            End If
        End If






        'controla no se repita codigo del grupo al modificar

        If (accion = acciones.modificar And txtcodigo.Text <> txtcodgrupo.Text) Then
            Dim cx As New Odbc.OdbcConnection
            Dim cm As New Odbc.OdbcCommand
            Dim da As New Odbc.OdbcDataAdapter
            Dim ds As New Data.DataSet

            cx.ConnectionString = "FileDSN=c:\itechplus_sec.dsn;UID=techplus_sec;pwd=1234"
            cx.Open()
            cm.Connection = cx
            cm.CommandText = "SELECT idg FROM grupos where idg =" + txtcodgrupo.Text
            cm.ExecuteNonQuery()
            da.SelectCommand = cm
            da.Fill(ds, "grupos")

            If ds.Tables("grupos").Rows.Count > 0 Then
                MsgBox("Group entered already exists with that code, you must enter a different code group")
                control = 1
            End If
        End If


        'controla no tengo datos asociados al momento de eliminar


        If (accion = acciones.eliminar) Then
            Dim cx As New Odbc.OdbcConnection
            Dim cm As New Odbc.OdbcCommand
            Dim da As New Odbc.OdbcDataAdapter
            Dim ds As New Data.DataSet

            cx.ConnectionString = "FileDSN=c:\itechplus_sec.dsn;UID=techplus_sec;pwd=1234"
            cx.Open()
            cm.Connection = cx
            cm.CommandText = "SELECT * FROM asignados where idg =" + txtcodgrupo.Text
            cm.ExecuteNonQuery()
            da.SelectCommand = cm
            da.Fill(ds, "grupos")

            If ds.Tables("grupos").Rows.Count > 0 Then
                MsgBox("There are teachers associated with this group. You must remove the teachers associated with the group and then remove the group")
                control = 1

            End If
        End If


        If (accion = acciones.eliminar) Then
            Dim cx As New Odbc.OdbcConnection
            Dim cm As New Odbc.OdbcCommand
            Dim da As New Odbc.OdbcDataAdapter
            Dim ds As New Data.DataSet

            cx.ConnectionString = "FileDSN=c:\itechplus_sec.dsn;UID=techplus_sec;pwd=1234"
            cx.Open()
            cm.Connection = cx
            cm.CommandText = "SELECT * FROM realizan where idg =" + txtcodgrupo.Text
            cm.ExecuteNonQuery()
            da.SelectCommand = cm
            da.Fill(ds, "realizan")

            If ds.Tables("realizan").Rows.Count > 0 Then
                MsgBox("There are data associated with this group. You must remove the data associated with the group and then remove the group")
                control = 1

            End If
        End If






        If (cmbturno.SelectedIndex = 0) Then
            MsgBox("You must select a turn")

        End If
        If (txtcodgrupo.Text = "") Then
            MsgBox("You must select a group code")
        End If
        If (txtcurso.Text = "") Then
            MsgBox("You must entry a letter to identify the career")

        End If
        If (txtletra.Text = "") Then
            MsgBox("You must entry a letter to identify the group")

        End If

        If accion = acciones.ingresar Or accion = acciones.modificar Then

            Dim cx As New Odbc.OdbcConnection
            Dim cm As New Odbc.OdbcCommand
            Dim da As New Odbc.OdbcDataAdapter
            Dim ds As New DataSet
            Dim dr As Odbc.OdbcDataReader

            Try
                cx.ConnectionString = "FileDSN=c:\itechplus_sec.dsn;UID=techplus_sec;pwd=1234"
                cx.Open()
                cm.Connection = cx
                cm.CommandText = "SELECT id_turno FROM turno where nombre_turno='" + cmbturno.SelectedItem + "'"
                cm.ExecuteNonQuery()
                da.SelectCommand = cm
                da.Fill(ds, "turno")
                dr = cm.ExecuteReader
                While dr.Read
                    txtid_turno.Text = dr.GetString(0)
                End While
                dr.Close()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try

        End If


        If accion = acciones.ingresar Then

            If (txtletra.Text <> "" And txtcurso.Text <> "" And control <> 1 And txtcodgrupo.Text <> "" And cmbturno.SelectedIndex <> 0 And txtid_turno.Text <> "") Then
                Dim sql As String = ""
                Dim cx As New Odbc.OdbcConnection
                Dim cm As New Odbc.OdbcCommand


                sql = "INSERT INTO grupos VALUES (" + txtcodgrupo.Text + ","
                sql += cmbaño.SelectedItem + ",'"
                sql += txtcurso.Text + "','"
                sql += txtletra.Text + "',"
                sql += txtid_turno.Text + ",'"
                sql += cmbcarrera.SelectedItem + "')"

                cx.ConnectionString = "FileDSN=c:\itechplus_sec.dsn;UID=techplus_sec;pwd=1234"
                cx.Open()
                cm.Connection = cx
                cm.CommandText = sql
                cm.ExecuteNonQuery()
                MsgBox("Group entered")
                control = 0


                iabmgrupo.Show()
                Me.Close()

            End If
        End If




        '        ingresogrupo2.lblgrupaing.Text = cmbaño.SelectedItem + txtcurso.Text + txtletra.Text


        'modifica datos de grupo


        If accion = acciones.modificar Then
            MsgBox("control=" + control.ToString)
            If (txtletra.Text <> "" And txtcurso.Text <> "" And control <> 1 And txtcodgrupo.Text <> "" And cmbturno.SelectedIndex <> 0 And txtid_turno.Text <> "") Then

                Dim sql As String = ""
                Dim cx As New Odbc.OdbcConnection
                Dim cm As New Odbc.OdbcCommand

                sql = "UPDATE grupos SET "
                sql += "idg = " + txtcodgrupo.Text + ","
                sql += "anio=" + cmbaño.SelectedItem + ","
                sql += "curso='" + txtcurso.Text + "',"
                sql += "letra='" + txtletra.Text + "',"
                sql += "id_turno=" + txtid_turno.Text + ","
                sql += "nombre_carr='" + cmbcarrera.SelectedItem + "'"
                sql += " where idg = " + ungrupo.idg.ToString
                MsgBox("Group modified")
                control = 0
                cx.ConnectionString = "FileDSN=c:\itechplus_sec.dsn;UID=techplus_sec;pwd=1234"
                cx.Open()
                cm.Connection = cx
                cm.CommandText = sql
                cm.ExecuteNonQuery()
                iabmgrupo.Show()
                Me.Close()

            End If
        End If




        If accion = acciones.eliminar Then

            If (control <> 1) Then
                Dim sql As String = ""
                Dim cx As New Odbc.OdbcConnection
                Dim cm As New Odbc.OdbcCommand
                Select Case MsgBox("Are you sure to eliminate this group " + cmbaño.SelectedItem + txtcurso.Text + txtletra.Text + "?", MsgBoxStyle.YesNo)
                    Case MsgBoxResult.Yes
                        sql = "DELETE FROM grupos WHERE idg= " + txtcodgrupo.Text
                        cx.ConnectionString = "FileDSN=c:\itechplus_sec.dsn;UID=techplus_sec;pwd=1234"
                        cx.Open()
                        cm.Connection = cx
                        cm.CommandText = sql
                        cm.ExecuteNonQuery()
                        MsgBox("Group deleted")

                        iabmgrupo.Show()
                        Me.Close()

                    Case MsgBoxResult.No
                        iabmgrupo.Show()
                        Me.Close()

                End Select

            End If

        End If




        'txtcodgrupo.Clear()
        'cmbturno.SelectedIndex = 0
        'gbxgrup.Visible = False



        '      cmbcarrera.SelectedIndex = 0
        '     cmbaño.Visible = True
        '    cmbaño.SelectedIndex = 0


        '  txtcurso.Clear()
        ' txtletra.Clear()
        ' End If
    End Sub


    Private Sub btnsiba_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsiba.Click
        txtcodgrupo.Clear()
        cmbturno.SelectedIndex = 0
        txtcurso.Clear()
        txtletra.Clear()
        gbxgrup.Visible = False


        cmbcarrera.Visible = True
        cmbcarrera.SelectedIndex = 0
        cmbaño.Visible = False
        cmbaño.SelectedIndex = 0


        imenupse.Show()
        Me.Close()

    End Sub

    Private Sub btnabmgrup_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnabmgrup.Click
        txtcodgrupo.Clear()
        cmbturno.SelectedIndex = 0

        txtcurso.Clear()
        txtletra.Clear()
        gbxgrup.Visible = False



        cmbcarrera.Visible = True
        cmbcarrera.SelectedIndex = 0
        cmbaño.Visible = True
        cmbaño.SelectedIndex = 0

        iabmgrupo.Show()
        Me.Close()
    End Sub

    Private Sub ialtagrupo_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        txtid_turno.Visible = False
        txtnomturno.Visible = False
        txtaño.Visible = False
        txtcodigo.Visible = False




        Select Case accion
            Case acciones.ingresar
                btnaceptar.Text = "Insert"
                lbltitulo.Text = "ENTRY GROUPS"
                cmbturno.SelectedIndex = 0
                cmbcarrera.SelectedIndex = 0
                cmbaño.SelectedIndex = 0






            Case acciones.modificar
                btnaceptar.Text = "Modify"
                lbltitulo.Text = "CHANGE GROUPS"
                With ungrupo
                    txtcodigo.Text = .idg
                    txtcodgrupo.Text = .idg
                    txtcurso.Text = .curso
                    txtletra.Text = .letra
                    cmbcarrera.SelectedItem = .nombre_carr
                    txtid_turno.Text = .id_turno
                    txtaño.Text = .anio



                End With
                ' txtcodgrupo.Enabled = False
                '        txtcurso.Enabled = False
                '       cmbaño.Enabled = False
                '      txtletra.Enabled = False
                '     cmbcarrera.Enabled = False


                Dim cx As New Odbc.OdbcConnection
                Dim cm As New Odbc.OdbcCommand
                Dim da As New Odbc.OdbcDataAdapter
                Dim ds As New DataSet
                Dim dr As Odbc.OdbcDataReader

                'Try
                cx.ConnectionString = "FileDSN=c:\itechplus_sec.dsn;UID=techplus_sec;pwd=1234"
                cx.Open()
                cm.CommandText = "SELECT nombre_turno FROM turno where id_turno=" + txtid_turno.Text
                cm.Connection = cx
                cm.ExecuteNonQuery()
                da.SelectCommand = cm
                da.Fill(ds, "turno")
                dr = cm.ExecuteReader
                While dr.Read
                    txtnomturno.Text = dr.GetString(0)
                End While
                dr.Close()


                cmbturno.SelectedItem = txtnomturno.Text

                cmbaño.SelectedItem = txtaño.Text


            Case acciones.eliminar
                btnaceptar.Text = "Delete"
                lbltitulo.Text = "LOW GROUPS"

                With ungrupo
                    txtcodigo.Text = .idg
                    txtcodgrupo.Text = .idg
                    txtcurso.Text = .curso
                    txtletra.Text = .letra
                    cmbcarrera.SelectedItem = .nombre_carr
                    txtid_turno.Text = .id_turno
                    txtaño.Text = .anio


                End With
                txtcodgrupo.Enabled = False
                txtcurso.Enabled = False
                cmbaño.Enabled = False
                txtletra.Enabled = False
                cmbcarrera.Enabled = False
                cmbturno.Enabled = False

                Dim cx As New Odbc.OdbcConnection
                Dim cm As New Odbc.OdbcCommand
                Dim da As New Odbc.OdbcDataAdapter
                Dim ds As New DataSet
                Dim dr As Odbc.OdbcDataReader

                'Try
                cx.ConnectionString = "FileDSN=c:\itechplus_sec.dsn;UID=techplus_sec;pwd=1234"
                cx.Open()
                cm.CommandText = "SELECT nombre_turno FROM turno where id_turno=" + txtid_turno.Text
                cm.Connection = cx
                cm.ExecuteNonQuery()
                da.SelectCommand = cm
                da.Fill(ds, "turno")
                dr = cm.ExecuteReader
                While dr.Read
                    txtnomturno.Text = dr.GetString(0)
                End While
                dr.Close()


                cmbturno.SelectedItem = txtnomturno.Text

                cmbaño.SelectedItem = txtaño.Text



        End Select

    End Sub
End Class