Public Class altaCarrera

    Private Sub Label6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lbltitulo.Click

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnatras.Click
        If (accion = acciones.ingresar) Then
            txtnombre.Clear()
            cmbdur.SelectedIndex = 0

            
        End If

        If (accion = acciones.modificar Or accion = acciones.eliminar) Then

            abmcarreras.Show()
            Me.Close()

        End If
    End Sub

    Private Sub altaCarrera_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Select Case accion
            Case acciones.ingresar
                btnaceptar.Text = "Ingresar"
                lbltitulo.Text = "INGRESO DE CARRERA"
                cmbdur.SelectedIndex = 0

            Case acciones.modificar
                btnaceptar.Text = "Modificar"
                lbltitulo.Text = "MODIFICACIÓN DE CARRERA"
                txtnombre.Enabled = False


                With unacarrera
                    txtnombre.Text = .nombre_carr
                    cmbdur.SelectedItem = .duracion

                End With
            Case acciones.eliminar
                btnaceptar.Text = "Eliminar"
                lbltitulo.Text = "BAJA DE CARRERA"


                With unacarrera
                    txtnombre.Text = .nombre_carr
                    cmbdur.SelectedItem = .duracion
                End With
                txtnombre.Enabled = False
                cmbdur.Enabled = False
        End Select
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnaceptar.Click
        Dim control As Integer
        control = 0


        If (txtnombre.Text = "") Then
            MsgBox("Debe ingresar un nombre de carrera")
        End If
        If (cmbdur.SelectedIndex = 0) Then
            MsgBox("Debe seleccionar una duración")
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
                MsgBox("Ya existe una carrera ingresada con ese nombre")
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
                MsgBox("Existen Materias asociadas a esta carrera. Debe eliminar las materias asociadas a la carrera  para luego eliminar la carrera")
                control = 1
                abmcarreras.Show()
                Me.Close()

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
                MsgBox("Carrera ingresada exitosamente")
                control = 0
                cx.Close()
                abmcarreras.Show()
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
                MsgBox("Carrera modificada exitosamente")
                cx.Close()
                abmcarreras.Show()
                Me.Close()

            End If
        End If


        If (accion = acciones.eliminar) Then
            If (control <> 1) Then
                Dim sql As String = ""
                Dim cx As New Odbc.OdbcConnection
                Dim cm As New Odbc.OdbcCommand
                Select Case MsgBox("Está seguro de eliminar la carrera " + txtnombre.Text + "?", MsgBoxStyle.YesNo)
                    Case MsgBoxResult.Yes
                        sql = "DELETE FROM carreras WHERE nombre_carr= '" + txtnombre.Text + "'"
                        cx.ConnectionString = "FileDSN=c:\itechplus_sec.dsn;UID=techplus_sec;pwd=1234"
                        cx.Open()
                        cm.Connection = cx
                        cm.CommandText = sql
                        cm.ExecuteNonQuery()
                        MsgBox("Carrera eliminada exitosamente")
                        cx.Close()
                        abmcarreras.Show()
                        Me.Close()

                    Case MsgBoxResult.No
                        abmcarreras.Show()
                        Me.Close()

                End Select

            End If

        End If
    End Sub

    Private Sub btnclose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnclose.Click
        Select Case MsgBox("Desea cerrar sesión?", MsgBoxStyle.YesNo)
            Case MsgBoxResult.Yes
                txtnombre.Clear()
                cmbdur.SelectedIndex = 0

                login.txtusuario.clear()
                login.txtpass.clear()
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

    Private Sub txtnombre_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtnombre.TextChanged

    End Sub

    Private Sub cmbdur_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cmbdur.KeyPress
        If Char.IsLetter(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
        If (e.KeyChar < "0" Or e.KeyChar > "9") And e.KeyChar <> Chr(Keys.Back) Then
            e.KeyChar = ""
        End If
    End Sub

    Private Sub cmbdur_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbdur.SelectedIndexChanged

    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)


    End Sub

    Private Sub btnmenu_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnmenu.Click
        txtnombre.Clear()
        cmbdur.SelectedIndex = 0

        abmcarreras.Show()
        Me.Close()
    End Sub
End Class