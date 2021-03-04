Public Class altagrupo


    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If (cmbcarrera.SelectedIndex = 0) Then
            MsgBox("Debe seleccionar una carrera")
        End If
        If (txtcodgrupo.Text = "") Then
            MsgBox("Debe ingresar un c�digo de grupo")
        End If
        If (cmbturno.SelectedIndex = 0) Then
            MsgBox("Debe seleccionar un turno")

        End If

        If (cmba�o.SelectedIndex = 0) Then
            MsgBox("Debe seleccionar el a�o al que pertenecer� el grupo")

        End If

        If (txtcurso.Text = "") Then
            MsgBox("Debe ingresar el curso al que pertenece el grupo")

        End If

        If (txtletra.Text = "") Then
            MsgBox("Debe ingresar una letra para identificar al grupo")

        End If

        If (txtletra.Text <> "" And txtcurso.Text <> "" And cmba�o.SelectedIndex <> 0 And cmbturno.SelectedIndex <> 0 And txtcodgrupo.Text <> "" And cmbcarrera.SelectedIndex <> 0) Then
            MsgBox("Se continuar� validando disponibilidad")


            gbxgrup.Visible = False

            lblsalon.Visible = True
            lblsalon.Text = cmba�o.SelectedItem + txtcurso.Text + txtletra.Text


        End If


    End Sub

    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        

    End Sub

    Private Sub Form18_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        txtid_turno.Visible = False
        txtnomturno.Visible = False
        txta�o.Visible = False

        Select Case accion
            Case acciones.ingresar
                btnaceptar.Text = "Ingresar"
                lbltitulo.Text = "INGRESO DE GRUPO"
                cmbturno.SelectedIndex = 0
                cmbcarrera.SelectedIndex = 0
                cmba�o.SelectedIndex = 0






            Case acciones.modificar
                btnaceptar.Text = "Modificar"
                lbltitulo.Text = "MODIFICACI�N DE GRUPO"
                With ungrupo

                    txtcodgrupo.Text = .idg
                    txtcurso.Text = .curso
                    txtletra.Text = .letra
                    cmbcarrera.SelectedItem = .nombre_carr
                    txtid_turno.Text = .id_turno
                    txta�o.Text = .anio

                    

                End With
          

                Dim cx As New Odbc.OdbcConnection
                Dim cm As New Odbc.OdbcCommand
                Dim da As New Odbc.OdbcDataAdapter
                Dim ds As New DataSet
                Dim dr As Odbc.OdbcDataReader

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

                cmba�o.SelectedItem = txta�o.Text


            Case acciones.eliminar
                btnaceptar.Text = "Eliminar"
                lbltitulo.Text = "BAJA DE GRUPO"

                With ungrupo
                    txtcodgrupo.Text = .idg
                    txtcurso.Text = .curso
                    txtletra.Text = .letra
                    cmbcarrera.SelectedItem = .nombre_carr
                    txtid_turno.Text = .id_turno
                    txta�o.Text = .anio


                End With
                txtcodgrupo.Enabled = False
                txtcurso.Enabled = False
                cmba�o.Enabled = False
                txtletra.Enabled = False
                cmbcarrera.Enabled = False
                cmbturno.Enabled = False

                Dim cx As New Odbc.OdbcConnection
                Dim cm As New Odbc.OdbcCommand
                Dim da As New Odbc.OdbcDataAdapter
                Dim ds As New DataSet
                Dim dr As Odbc.OdbcDataReader

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

                cmba�o.SelectedItem = txta�o.Text



        End Select



        




    End Sub

    Private Sub GroupBox1_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Label11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub TextBox14_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

        gbxgrup.Visible = False

    End Sub

    Private Sub Button5_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)
        btnabmgrup.Visible = True
    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

        txtcodgrupo.Clear()
        cmbturno.SelectedIndex = 0
        txtcurso.Clear()
        txtletra.Clear()
        gbxgrup.Visible = False


        cmbcarrera.Visible = True
        cmbcarrera.SelectedIndex = 0
        cmba�o.Visible = False
        cmba�o.SelectedIndex = 0


        menupse.Show()
        Me.Close()

    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnabmgrup.Click


        txtcodgrupo.Clear()
        cmbturno.SelectedIndex = 0

        txtcurso.Clear()
        txtletra.Clear()
        gbxgrup.Visible = False



        cmbcarrera.Visible = True
        cmbcarrera.SelectedIndex = 0
        cmba�o.Visible = True
        cmba�o.SelectedIndex = 0

        abmGrupo.Show()
        Me.Close()

    End Sub

    Private Sub txtcodgrupo_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub btncancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

        txtcodgrupo.Clear()
        cmbturno.SelectedIndex = 0

        txtcurso.Clear()
        txtletra.Clear()
    End Sub

    Private Sub lblingreso_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub txta�o_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)

        If (e.KeyChar < "0" Or e.KeyChar > "9") And e.KeyChar <> Chr(Keys.Back) Then
            e.KeyChar = ""
        End If
    End Sub

    Private Sub txta�o_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub txtcurso_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If Char.IsLetter(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub txtcurso_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub txtletra_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If Char.IsLetter(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub txtletra_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub gbxgrup_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub cmbcarrera_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cmbcarrera.KeyPress
        If (e.KeyChar < "0" Or e.KeyChar > "9") And e.KeyChar <> Chr(Keys.Back) Then
            e.KeyChar = ""
        End If
        If Char.IsLetter(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsSeparator(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub cmbcarrera_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbcarrera.SelectedIndexChanged

    End Sub

    Private Sub txtcodgrupo_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtcodgrupo.KeyPress
        If (e.KeyChar < "0" Or e.KeyChar > "9") And e.KeyChar <> Chr(Keys.Back) Then
            e.KeyChar = ""
        End If
    End Sub

    Private Sub txtcodgrupo_TextChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtcodgrupo.TextChanged

    End Sub

    Private Sub cmbturno_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cmbturno.KeyPress
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

    Private Sub cmbturno_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbturno.SelectedIndexChanged

    End Sub

    Private Sub txta�o_KeyPress1(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If (e.KeyChar < "0" Or e.KeyChar > "9") And e.KeyChar <> Chr(Keys.Back) Then
            e.KeyChar = ""
        End If
    End Sub

    Private Sub txta�o_TextChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub txtletra_KeyPress1(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtletra.KeyPress
        If Char.IsLetter(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub txtletra_TextChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtletra.TextChanged

    End Sub

    Private Sub txtcurso_KeyPress1(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtcurso.KeyPress

        If Char.IsLetter(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub txtcurso_TextChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtcurso.TextChanged

    End Sub

    Private Sub btncancel_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btncancel.Click

        If (accion = acciones.ingresar) Then
            cmbcarrera.SelectedIndex = 0
            txtcodgrupo.Clear()
            cmbturno.SelectedIndex = 0
            cmba�o.SelectedIndex = 0
            txtcurso.Clear()
            txtletra.Clear()

            abmGrupo.Show()
            Me.Close()
        End If

        If (accion = acciones.eliminar Or accion = acciones.modificar) Then

            abmGrupo.Show()
            Me.Close()
        End If


    End Sub

    Private Sub btnaceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnaceptar.Click
        Dim controla As Integer
        controla = 0
        If (cmbcarrera.SelectedIndex = 0) Then
            MsgBox("Debe seleccionar una carrera")

        End If
        If (txtcodgrupo.Text = "") Then
            MsgBox("Debe ingresar un c�digo de grupo")

        End If
        If (cmbturno.SelectedIndex = 0) Then
            MsgBox("Debe seleccionar un  turno")

        End If

        If (cmba�o.SelectedIndex = 0) Then
            MsgBox("Debe ingresar un a�o para el grupo")

        End If

        If (txtcurso.Text = "") Then
            MsgBox("Debe ingresar una letra para identificar el curso")

        End If

        If (txtletra.Text = "") Then
            MsgBox("Debe ingresar una letra para identificar al grupo")

        End If


        If (cmbcarrera.SelectedIndex <> 0 And txtcodgrupo.Text <> "" And cmbturno.SelectedIndex <> 0 And cmba�o.SelectedIndex <> 0 And txtcurso.Text <> "" And txtletra.Text <> "") Then






            'controla que no se repita el cod grupo al ingresar
            If (accion = acciones.ingresar) Then
                Dim cx As New Odbc.OdbcConnection
                Dim cm As New Odbc.OdbcCommand
                Dim da As New Odbc.OdbcDataAdapter
                Dim ds As New Data.DataSet

                cx.ConnectionString = "FileDSN=c:\itechplus_sec.dsn;UID=techplus_sec;pwd=1234"
                cx.Open()
                cm.Connection = cx

                cm.CommandText = "SELECT idg FROM grupos where  curso ='" + txtcurso.Text + "' and anio= " + cmba�o.SelectedItem + " and letra ='" + txtletra.Text + "'"

                cm.ExecuteNonQuery()
                da.SelectCommand = cm
                da.Fill(ds, "grupos")

                If ds.Tables("grupos").Rows.Count > 0 Then
                    MsgBox("Ya existe un grupo ingresado con esa  combinaci�n")
                    controla = 1
                End If
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
                MsgBox("Existen docentes asociados a este grupo. Debe eliminar los docentes asociados al grupo para luego eliminar el grupo")
                controla = 1

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
                MsgBox("Existen datos asociados a este grupo. Debe eliminar los datos asociados al grupo para luego eliminar el grupo")
                controla = 1

            End If
        End If






        If (cmbturno.SelectedIndex = 0) Then
            MsgBox("Debe seleccionar un turno")

        End If
        If (txtcodgrupo.Text = "") Then
            MsgBox("Debe ingresar un c�digo de grupo")
        End If
        If (txtcurso.Text = "") Then
            MsgBox("Debe ingresar una letra para identificar la carrera")

        End If
        If (txtletra.Text = "") Then
            MsgBox("Debe ingresar una letra para identificar el grupo")

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

            If (txtletra.Text <> "" And txtcurso.Text <> "" And controla <> 1 And txtcodgrupo.Text <> "" And cmbturno.SelectedIndex <> 0 And txtid_turno.Text <> "") Then
                Dim sql As String = ""
                Dim cx As New Odbc.OdbcConnection
                Dim cm As New Odbc.OdbcCommand


                sql = "INSERT INTO grupos VALUES (" + txtcodgrupo.Text + ","
                sql += cmba�o.SelectedItem + ",'"
                sql += txtcurso.Text + "','"
                sql += txtletra.Text + "',"
                sql += txtid_turno.Text + ",'"
                sql += cmbcarrera.SelectedItem + "')"

                cx.ConnectionString = "FileDSN=c:\itechplus_sec.dsn;UID=techplus_sec;pwd=1234"
                cx.Open()
                cm.Connection = cx
                cm.CommandText = sql
                cm.ExecuteNonQuery()
                MsgBox("Grupo  ingresado exitosamente")
                controla = 0


                abmGrupo.Show()
                Me.Close()

            End If
        End If




        '        ingresogrupo2.lblgrupaing.Text = cmba�o.SelectedItem + txtcurso.Text + txtletra.Text


        'modifica datos de grupo


        If accion = acciones.modificar Then
            If (txtletra.Text <> "" And txtcurso.Text <> "" And controla <> 1 And txtcodgrupo.Text <> "" And cmbturno.SelectedIndex <> 0 And txtid_turno.Text <> "") Then

                Dim sql As String = ""
                Dim cx As New Odbc.OdbcConnection
                Dim cm As New Odbc.OdbcCommand

                sql = "UPDATE grupos SET "
                sql += "idg = " + txtcodgrupo.Text + ","
                sql += "anio=" + cmba�o.SelectedItem + ","
                sql += "curso='" + txtcurso.Text + "',"
                sql += "letra='" + txtletra.Text + "',"
                sql += "id_turno=" + txtid_turno.Text + ","
                sql += "nombre_carr='" + cmbcarrera.SelectedItem + "'"
                sql += " where idg = " + ungrupo.idg.ToString
                MsgBox("Grupo modificado exitosamente")
                controla = 0
                cx.ConnectionString = "FileDSN=c:\itechplus_sec.dsn;UID=techplus_sec;pwd=1234"
                cx.Open()
                cm.Connection = cx
                cm.CommandText = sql
                cm.ExecuteNonQuery()
                abmGrupo.Show()
                Me.Close()

            End If
        End If




        If accion = acciones.eliminar Then

            If (controla <> 1) Then
                Dim sql As String = ""
                Dim cx As New Odbc.OdbcConnection
                Dim cm As New Odbc.OdbcCommand
                Select Case MsgBox("Est� seguro de eliminar el grupo " + cmba�o.SelectedItem + txtcurso.Text + txtletra.Text + "?", MsgBoxStyle.YesNo)
                    Case MsgBoxResult.Yes
                        sql = "DELETE FROM grupos WHERE idg= " + txtcodgrupo.Text
                        cx.ConnectionString = "FileDSN=c:\itechplus_sec.dsn;UID=techplus_sec;pwd=1234"
                        cx.Open()
                        cm.Connection = cx
                        cm.CommandText = sql
                        cm.ExecuteNonQuery()
                        MsgBox("Grupo eliminado exitosamente")

                        abmGrupo.Show()
                        Me.Close()

                    Case MsgBoxResult.No
                        abmGrupo.Show()
                        Me.Close()

                End Select

            End If

        End If




        'txtcodgrupo.Clear()
        'cmbturno.SelectedIndex = 0
        'gbxgrup.Visible = False



        '      cmbcarrera.SelectedIndex = 0
        '     cmba�o.Visible = True
        '    cmba�o.SelectedIndex = 0


        '  txtcurso.Clear()
        ' txtletra.Clear()
        ' End If
    End Sub

    Private Sub cmba�o_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cmba�o.KeyPress
        If (e.KeyChar < "0" Or e.KeyChar > "9") And e.KeyChar <> Chr(Keys.Back) Then
            e.KeyChar = ""
        End If
        If Char.IsLetter(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsSeparator(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub cmba�o_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmba�o.SelectedIndexChanged

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnclose.Click
        Select Case MsgBox("Desea cerrar sesi�n?", MsgBoxStyle.YesNo)
            Case MsgBoxResult.Yes

                txtcodgrupo.Clear()
                cmbturno.SelectedIndex = 0

                txtcurso.Clear()
                txtletra.Clear()
                gbxgrup.Visible = False


                cmbcarrera.Visible = True
                cmbcarrera.SelectedIndex = 0
                cmba�o.Visible = False
                cmba�o.SelectedIndex = 0

                login.txtusuario.clear()
                login.txtpass.clear()
                login.Show()
                Me.Hide()
            Case MsgBoxResult.No
                Me.Hide()
                Me.Show()
        End Select

    End Sub

    Private Sub lbltipou_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lbltipou.Click

    End Sub

    Private Sub lblrol_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblrol.Click

    End Sub

    Private Sub txtcons_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtid_turno.TextChanged

    End Sub
End Class