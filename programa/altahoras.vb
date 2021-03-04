Public Class altahoras


    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        If (cmbturno.SelectedIndex = 0) Then
            MsgBox("Debe seleccionar un turno")

        End If

        If (cmbturno.SelectedIndex > 0) Then
            cmbturnomod.SelectedItem = cmbturno.SelectedItem
            gbxhoras.Visible = True
            gbxhoras.SetBounds(15, 47, 271, 255)
            gbxselturno.Visible = False
            btnatras.Visible = True
            btnaceptar.Visible = True

        End If
    End Sub

    Private Sub Form38_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        cmbdia.SelectedIndex = 0
        cmbturno.SelectedIndex = 0
        txtid_turno.Visible = False

        Select Case accion

            Case acciones.ingresar
                gbxselturno.Visible = True
                gbxhoras.Visible = False
                btnaceptar.Text = "Ingresar"
                lbltitulo.Text = "INGRESO DE HORA"
                cmbturnomod.Enabled = False
                btnaceptar.Visible = False
                btnatras.Visible = False


            Case acciones.modificar

                txtcodhora.Enabled = False
                btnaceptar.Visible = True
                btnatras.Visible = True
                gbxselturno.Visible = False
                gbxhoras.Visible = True
                gbxhoras.SetBounds(15, 47, 271, 255)

                btnaceptar.Text = "Modificar"
                lbltitulo.Text = "MODIFICACIÓN DE HORA"


                With unahora
                    txtcodhora.Text = .id_horas
                    txtnumero.Text = .num_horas
                    cmbdia.SelectedItem = .dia
                    txthoraini.Text = Format(.inicio, "HH:mm")
                    txthorafin.Text = Format(.fin, "HH:mm")
                    cmbturnomod.SelectedItem = .nombre_turno
                    txtid_turno.Text = .id_turno

                End With
            Case acciones.eliminar
                gbxselturno.Visible = False
                gbxhoras.Visible = True
                gbxhoras.SetBounds(15, 47, 271, 255)
                btnaceptar.Visible = True
                btnatras.Visible = True
                btnaceptar.Text = "Eliminar"
                lbltitulo.Text = "BAJA DE HORA"

                With unahora
                    txtcodhora.Text = .id_horas
                    txtnumero.Text = .num_horas
                    cmbdia.SelectedItem = .dia
                    txthoraini.Text = Format(.inicio, "HH:mm")
                    txthorafin.Text = Format(.fin, "HH:mm")
                    cmbturnomod.SelectedItem = .nombre_turno
                End With

                txtcodhora.Enabled = False
                txtnumero.Enabled = False
                cmbdia.Enabled = False
                txthoraini.Enabled = False
                txthorafin.Enabled = False
                cmbturnomod.Enabled = False



        End Select


    End Sub

    Private Sub gbxdoc_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles gbxhoras.Enter

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnatras.Click
        abmhoras.Show()
        Me.Close()

        btnatras.Visible = False
        btnaceptar.Visible = False
        gbxhoras.Visible = False
        cmbturno.SelectedIndex = 0


    End Sub

    Private Sub btnclose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnclose.Click
        Select Case MsgBox("Desea cerrar sesión?", MsgBoxStyle.YesNo)
            Case MsgBoxResult.Yes
                btnatras.Visible = False
                btnaceptar.Visible = False
                Label10.Visible = True
                Label14.Visible = True
                cmbturno.Visible = True
                Button4.Visible = True
                gbxhoras.Visible = False
                txthorafin.Clear()
                txthoraini.Clear()
                cmbdia.SelectedIndex = 0
                txtnumero.Clear()
                cmbturnomod.SelectedIndex = 0
                txtcodhora.Clear()
                login.txtusuario.clear()
                login.txtpass.clear()
                login.Show()
                Me.Hide()
            Case MsgBoxResult.No

                Me.Show()
        End Select
    End Sub

    Private Sub btningresar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnaceptar.Click

        If (txtcodhora.Text = "") Then
            MsgBox("Debe ingresar un código de hora")
        End If
        If (cmbturnomod.SelectedIndex = 0) Then
            MsgBox("Debe seleccionar un nombre de turno")
        End If
        If (txtnumero.Text = "") Then
            MsgBox("Debe ingresar un número para la hora")
        End If
        If (cmbdia.SelectedIndex = 0) Then
            MsgBox("Debe ingresar un día para la hora")
        End If
        If (txthoraini.Text = "") Then
            MsgBox("Debe ingresar una hora de inico")
        End If
        If (txthorafin.Text = "") Then
            MsgBox("Debe ingresar una hora de finalización")
        End If

        If (cmbturnomod.SelectedIndex <> 0) Then

            Dim cx2 As New Odbc.OdbcConnection
            Dim cm2 As New Odbc.OdbcCommand
            Dim lector As Odbc.OdbcDataReader
            cx2.ConnectionString = "FileDSN=c:\itechplus_sec.dsn;UID=techplus_sec;pwd=1234"
            cx2.Open()

            cm2.CommandText = "SELECT id_turno from turno where nombre_turno='" + cmbturnomod.SelectedItem + "'"
            cm2.Connection = cx2
            lector = cm2.ExecuteReader()
            If lector.HasRows Then
                txtid_turno.Text = lector.GetString(0)
                cx2.Close()
            End If
        End If

        Dim control As Integer
        control = 0

        'controla que no se repita el cod de horas al ingresar
        If (accion = acciones.ingresar And txthorafin.Text <> "" And txthoraini.Text <> "" And cmbdia.SelectedIndex <> 0 And txtnumero.Text <> "" And cmbturnomod.SelectedIndex <> 0 And txtcodhora.Text <> "" And txtid_turno.Text <> "" And control <> 1) Then

            Dim cx As New Odbc.OdbcConnection
            Dim cm As New Odbc.OdbcCommand
            Dim da As New Odbc.OdbcDataAdapter
            Dim ds As New Data.DataSet

            cx.ConnectionString = "FileDSN=c:\itechplus_sec.dsn;UID=techplus_sec;pwd=1234"
            cx.Open()
            cm.Connection = cx
            cm.CommandText = "SELECT id_horas FROM horas where id_horas=" + txtcodhora.Text
            cm.ExecuteNonQuery()
            da.SelectCommand = cm
            da.Fill(ds, "hora")

            If ds.Tables("hora").Rows.Count > 0 Then
                MsgBox("Ya existe una hora ingresada con ese código")
                control = 1
            End If
            cx.Close()
        End If





        If (txthorafin.Text <> "" And txthoraini.Text <> "" And cmbdia.SelectedIndex <> 0 And txtnumero.Text <> "" And cmbturnomod.SelectedIndex <> 0 And txtcodhora.Text <> "" And txtid_turno.Text <> "" And control <> 1) Then

            Select Case accion
                Case acciones.ingresar
                    Dim sql As String = ""
                    Dim cx As New Odbc.OdbcConnection
                    Dim cm As New Odbc.OdbcCommand

                    sql = "INSERT INTO horas VALUES (" + txtcodhora.Text + ","
                    sql += txtnumero.Text + ",'" + cmbdia.SelectedItem + " ','"
                    sql += txthoraini.Text + "','" + txthorafin.Text + "')"



                    cx.ConnectionString = "FileDSN=c:\itechplus_sec.dsn;UID=techplus_sec;pwd=1234"
                    cx.Open()
                    cm.Connection = cx
                    cm.CommandText = sql
                    cm.ExecuteNonQuery()
                    MsgBox("Hora ingresada exitosamente")

                    sql = "INSERT INTO se_divide VALUES (" + txtid_turno.Text + ","
                    sql += txtcodhora.Text + ")"

                    txthorafin.Clear()
                    txthoraini.Clear()
                    cmbdia.SelectedIndex = 0
                    txtnumero.Clear()
                    cmbturnomod.SelectedIndex = 0
                    txtcodhora.Clear()

                    cm.Connection = cx
                    cm.CommandText = sql
                    cm.ExecuteNonQuery()

                Case acciones.modificar
                    Dim sql As String = ""
                    Dim cx As New Odbc.OdbcConnection
                    Dim cm As New Odbc.OdbcCommand

                    sql = "UPDATE horas SET "
                    sql += "id_horas = " + txtcodhora.Text + ","
                    sql += "num_hora=" + txtnumero.Text + ","
                    sql += "dia='" + cmbdia.SelectedItem + "',"
                    sql += "inicio='" + txthoraini.Text + "',"
                    sql += "fin='" + txthorafin.Text + "'"
                    sql += " WHERE id_horas = " + unahora.id_horas.ToString
                    MsgBox("Hora  modificada exitosamente")

                    cx.ConnectionString = "FileDSN=c:\itechplus_sec.dsn;UID=techplus_sec;pwd=1234"
                    cx.Open()
                    cm.Connection = cx
                    cm.CommandText = sql
                    cm.ExecuteNonQuery()

                    sql = "UPDATE se_divide SET "
                    sql += "id_turno= " + txtid_turno.Text + ","
                    sql += "id_horas=" + txtcodhora.Text
                    sql += " where id_horas=" + unahora.id_horas.ToString

                    cm.Connection = cx
                    cm.CommandText = sql
                    cm.ExecuteNonQuery()





                Case acciones.eliminar
                    Dim sql As String = ""
                    Dim cx As New Odbc.OdbcConnection
                    Dim cm As New Odbc.OdbcCommand

                    sql = "DELETE FROM se_divide where id_horas=  " + txtcodhora.Text

                    cx.ConnectionString = "FileDSN=c:\itechplus_sec.dsn;UID=techplus_sec;pwd=1234"
                    cx.Open()
                    cm.Connection = cx
                    cm.CommandText = sql
                    cm.ExecuteNonQuery()

                    sql = "DELETE FROM horas WHERE id_horas= " + txtcodhora.Text
                    MsgBox("Hora eliminada exitosamente")
                    cm.Connection = cx
                    cm.CommandText = sql
                    cm.ExecuteNonQuery()

                    abmhoras.Show()
                    Me.Close()

            End Select







        End If
    End Sub

    Private Sub txtcodhora_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtcodhora.KeyPress
        If (e.KeyChar < "0" Or e.KeyChar > "9") And e.KeyChar <> Chr(Keys.Back) Then
            e.KeyChar = ""
        End If
    End Sub

    Private Sub txtcodhora_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtcodhora.TextChanged

    End Sub

    Private Sub txtnumero_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtnumero.KeyPress
        If (e.KeyChar < "0" Or e.KeyChar > "9") And e.KeyChar <> Chr(Keys.Back) Then
            e.KeyChar = ""
        End If
    End Sub

    Private Sub txtnumero_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtnumero.TextChanged

    End Sub

    Private Sub cmbdia_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cmbdia.KeyPress
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

    Private Sub cmbdia_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbdia.SelectedIndexChanged

    End Sub

    Private Sub txtnomturno_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf e.KeyChar = ":" Then
            e.Handled = False
        Else
            e.Handled = True
        End If

    End Sub

    Private Sub txtcodturno_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub txthoraini_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txthoraini.KeyPress
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf e.KeyChar = ":" Then
            e.Handled = False
        Else
            e.Handled = True
        End If

    End Sub

    Private Sub txthoraini_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txthoraini.TextChanged

    End Sub

    Private Sub txthorafin_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txthorafin.KeyPress
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf e.KeyChar = ":" Then
            e.Handled = False
        Else
            e.Handled = True
        End If

    End Sub

    Private Sub txthorafin_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txthorafin.TextChanged

    End Sub

    Private Sub cmbturno_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cmbturno.KeyPress
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

    Private Sub cmbturno_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbturno.SelectedIndexChanged

    End Sub

    Private Sub btnmenu_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnmenu.Click
        abmhoras.Show()
        Me.Close()

    End Sub
End Class