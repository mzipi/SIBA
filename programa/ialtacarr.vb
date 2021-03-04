Public Class ialtacarr

    Private Sub ialtacarr_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        txtnombrecarrera.Visible = False
        Select Case accion
            Case acciones.ingresar
                btnaceptar.Text = "Insert"
                lbltitulo.Text = "ENTRY CAREER"
                cmbdur.SelectedIndex = 0

            Case acciones.modificar
                btnaceptar.Text = ""
                lbltitulo.Text = "CHANGE CAREER "


                With unacarrera
                    txtnombre.Text = .nombre_carr
                    cmbdur.SelectedItem = .duracion
                    txtnombrecarrera.Text = .nombre_carr
                End With
            Case acciones.eliminar
                btnaceptar.Text = "Delete"
                lbltitulo.Text = "LOW CAREER"


                With unacarrera
                    txtnombre.Text = .nombre_carr
                    cmbdur.SelectedItem = .duracion
                End With
                txtnombre.Enabled = False
                cmbdur.Enabled = False
        End Select
    End Sub

    Private Sub btnclose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnclose.Click
        Select Case MsgBox("Do you want close this session?", MsgBoxStyle.YesNo)
            Case MsgBoxResult.Yes
                txtnombre.Clear()
                cmbdur.SelectedIndex = 0

                login.txtusuario.Clear()
                login.txtpass.Clear()
                login.Show()
                Me.Hide()
            Case MsgBoxResult.No
                Me.Hide()
                Me.Show()
        End Select
    End Sub

    Private Sub txtnombre_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtnombre.KeyPress
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

    Private Sub btnaceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnaceptar.Click
        Dim control As Integer
        control = 0


        If (txtnombre.Text = "") Then
            MsgBox("You must enter a name for career")
        End If
        If (cmbdur.SelectedIndex = 0) Then
            MsgBox("You must select a duration")
        End If


        'controla que no se repita el cod carrera al ingresar
        If (accion = acciones.ingresar And txtnombre.Text <> "" And cmbdur.SelectedIndex <> 0) Then
            Dim cx As New Odbc.OdbcConnection
            Dim cm As New Odbc.OdbcCommand
            Dim da As New Odbc.OdbcDataAdapter
            Dim ds As New Data.DataSet

            cx.ConnectionString = "FileDSN=c:\itechplus_sec.dsn;UID=techplus_sec;pwd=1234"
            cx.Open()
            cm.Connection = cx
            cm.CommandText = "SELECT nombre_carr FROM carreras where  nombre_carr ='" + txtnombre.Text + "'"
            cm.ExecuteNonQuery()
            da.SelectCommand = cm
            da.Fill(ds, "carreras")

            If ds.Tables("carreras").Rows.Count > 0 Then
                MsgBox("Career entered already exists with that name")
                control = 1
            End If
            cx.Close()
        End If

        'controla no se repita la carrera al modificar

        If (accion = acciones.modificar And txtnombrecarrera.Text <> txtnombre.Text) Then
            Dim cx As New Odbc.OdbcConnection
            Dim cm As New Odbc.OdbcCommand
            Dim da As New Odbc.OdbcDataAdapter
            Dim ds As New Data.DataSet

            cx.ConnectionString = "FileDSN=c:\itechplus_sec.dsn;UID=techplus_sec;pwd=1234"
            cx.Open()
            cm.Connection = cx
            cm.CommandText = "SELECT nombre_carrera FROM carreras where nombre_carr ='" + txtnombre.Text + "'"
            cm.ExecuteNonQuery()
            da.SelectCommand = cm
            da.Fill(ds, "carreras")

            If ds.Tables("carreras").Rows.Count > 0 Then
                MsgBox("Career entered already exists with that name, you must enter a different name career")
                control = 1
            End If
            cx.Close()

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
            cm.CommandText = "SELECT * FROM materias where nombre_carr ='" + txtnombre.Text + "'"
            cm.ExecuteNonQuery()
            da.SelectCommand = cm
            da.Fill(ds, "materias")

            If ds.Tables("materias").Rows.Count > 0 Then
                MsgBox("There are Subjects associated with this career. You must remove the subjects associated With the career and then remove the career")
                control = 1
            End If
            cx.Close()
        End If






        If (accion = acciones.ingresar) Then

            If (txtnombre.Text <> "" And cmbdur.SelectedIndex <> 0 And control <> 1) Then
                Dim sql As String = ""
                Dim cx As New Odbc.OdbcConnection
                Dim cm As New Odbc.OdbcCommand


                sql = "INSERT INTO carreras VALUES ('" + txtnombre.Text + "',"
                sql += cmbdur.SelectedItem + ")"
                cx.ConnectionString = "FileDSN=c:\itechplus_sec.dsn;UID=techplus_sec;pwd=1234"
                cx.Open()
                cm.Connection = cx
                cm.CommandText = sql
                cm.ExecuteNonQuery()
                MsgBox("Career entered")
                control = 0
                cx.Close()
                iabmcarr.Show()
                Me.Close()
            End If
        End If

        If (accion = acciones.modificar) Then

            If (txtnombre.Text <> "" And cmbdur.SelectedIndex <> 0 And control <> 1) Then
                Dim sql As String = ""
                Dim cx As New Odbc.OdbcConnection
                Dim cm As New Odbc.OdbcCommand

                sql = "UPDATE carreras SET "
                sql += "nombre_carr = '" + txtnombre.Text + " ',"
                sql += "duracion=" + cmbdur.SelectedItem + ""
                sql += " WHERE nombre_carr = '" + unacarrera.nombre_carr.ToString + "'"
                cx.ConnectionString = "FileDSN=c:\itechplus_sec.dsn;UID=techplus_sec;pwd=1234"
                cx.Open()
                cm.Connection = cx
                cm.CommandText = sql
                cm.ExecuteNonQuery()
                MsgBox("Career modified")
                cx.Close()
                iabmcarr.Show()
                Me.Close()

            End If
        End If


        If (accion = acciones.eliminar) Then
            If (control <> 1) Then
                Dim sql As String = ""
                Dim cx As New Odbc.OdbcConnection
                Dim cm As New Odbc.OdbcCommand
                Select Case MsgBox("Are you sure to eliminate this career " + txtnombre.Text + "?", MsgBoxStyle.YesNo)
                    Case MsgBoxResult.Yes
                        sql = "DELETE FROM carreras WHERE nombre_carr= '" + txtnombre.Text + "'"
                        cx.ConnectionString = "FileDSN=c:\itechplus_sec.dsn;UID=techplus_sec;pwd=1234"
                        cx.Open()
                        cm.Connection = cx
                        cm.CommandText = sql
                        cm.ExecuteNonQuery()
                        MsgBox("Career deleted")
                        cx.Close()
                        iabmcarr.Show()
                        Me.Close()

                    Case MsgBoxResult.No
                        iabmcarr.Show()
                        Me.Close()

                End Select

            End If

        End If
    End Sub

    Private Sub btnatras_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnatras.Click
        If (accion = acciones.ingresar) Then
            txtnombre.Clear()
            cmbdur.SelectedIndex = 0

            iabmcarr.Show()
            Me.Close()

        End If

        If (accion = acciones.modificar Or accion = acciones.eliminar) Then

            iabmcarr.Show()
            Me.Close()

        End If
    End Sub
End Class