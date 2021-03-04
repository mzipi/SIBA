Public Class ialtaMat

    Private Sub ialtaMat_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        txtcarga.Visible = False
        txtcodigo.Visible = True

        Select Case accion

            Case acciones.ingresar
                gbxdatos.Visible = True
                gbxedit.Visible = False
                cmbcarr.SelectedIndex = 0
                cmbaño.SelectedIndex = 0
                cmbtipo.SelectedIndex = 0
                cmbcargah.SelectedIndex = 0
                gbxmat.Visible = False
                btnatras.Visible = False
                btnaceptar.Visible = False


                btnaceptar.Text = "Insert"
                lbltitulo.Text = "ENTRY SUBJECT"

            Case acciones.modificar
                gbxdatos.Visible = False
                gbxedit.Visible = True
                btnatras.Visible = True
                btnaceptar.Visible = True
                gbxmat.SetBounds(15, 75, 346, 231)
                btnatras.SetBounds(366, 174, 101, 22)
                btnaceptar.SetBounds(366, 133, 101, 22)

                btnaceptar.Text = "Modify"
                lbltitulo.Text = "CHANGE SUBJECT"
                With unamateria
                    txtcodigo.Text = .cod_materia
                    txtcod.Text = .cod_materia
                    txtaño.Text = .año_mat
                    txtnombre.Text = .nombre_mat
                    cmbtipo.SelectedItem = .tipo_mat
                    cmbcargah.SelectedItem = .carga_horaria
                    cmbnomcarr.SelectedIndex = .nombre_carr
                    txtcarga.Text = .carga_horaria
                    cmbcargah.SelectedItem = txtcarga.Text

                End With
                txtcod.Enabled = False
                txtnombre.Enabled = False
                txtnombre.Enabled = False
                cmbtipo.Enabled = False
                cmbcargah.Enabled = True
                cmbnomcarr.Enabled = False


            Case acciones.eliminar
                gbxdatos.Visible = False
                gbxedit.Visible = False
                btnatras.Visible = True
                btnaceptar.Visible = True
                gbxmat.SetBounds(15, 75, 271, 226)
                btnatras.SetBounds(366, 174, 101, 22)
                btnaceptar.SetBounds(366, 133, 101, 22)

                btnaceptar.Text = "Delete"
                lbltitulo.Text = "LOW SUBJECT"

                With unamateria
                    txtcod.Text = .cod_materia
                    txtaño.Text = .año_mat
                    txtnombre.Text = .nombre_mat
                    cmbtipo.SelectedItem = .tipo_mat
                    cmbcargah.SelectedItem = .carga_horaria
                    cmbnomcarr.SelectedIndex = .nombre_carr
                    txtcarga.Text = .carga_horaria
                    cmbcargah.SelectedItem = txtcarga.Text
                End With
                txtcod.Enabled = False
                txtnombre.Enabled = False
                txtnombre.Enabled = False
                cmbtipo.Enabled = False
                cmbcargah.Enabled = False
                cmbnomcarr.Enabled = False


        End Select
    End Sub

    Private Sub btnaceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnaceptar.Click
        Dim control As Integer
        control = 0

        'controla que no se repita el codigo de materia al ingresar
        If (accion = acciones.ingresar) Then
            Dim cx As New Odbc.OdbcConnection
            Dim cm As New Odbc.OdbcCommand
            Dim da As New Odbc.OdbcDataAdapter
            Dim ds As New Data.DataSet

            cx.ConnectionString = "FileDSN=c:\itechplus_sec.dsn;UID=techplus_sec;pwd=1234"
            cx.Open()
            cm.Connection = cx
            cm.CommandText = "SELECT cod_materia FROM materias where cod_materia ='" + txtcod.Text + "'"
            cm.ExecuteNonQuery()
            da.SelectCommand = cm
            da.Fill(ds, "materias")

            If ds.Tables("materias").Rows.Count > 0 Then
                MsgBox("Subject entered already exists with that code, you must enter a different code subject")
                control = 1
            End If
        End If

        'controla no se repita codigo turno al modificar

        If (accion = acciones.modificar And txtcodigo.Text <> txtcod.Text) Then
            Dim cx As New Odbc.OdbcConnection
            Dim cm As New Odbc.OdbcCommand
            Dim da As New Odbc.OdbcDataAdapter
            Dim ds As New Data.DataSet

            cx.ConnectionString = "FileDSN=c:\itechplus_sec.dsn;UID=techplus_sec;pwd=1234"
            cx.Open()
            cm.Connection = cx
            cm.CommandText = "SELECT cod_materia FROM materias where cod_materia ='" + txtcod.Text + "'"
            cm.ExecuteNonQuery()
            da.SelectCommand = cm
            da.Fill(ds, "materias")

            If ds.Tables("materias").Rows.Count > 0 Then
                MsgBox("Subject entered already exists with that code, you must enter a different code subject")
                control = 1
            End If
        End If


        If (txtcod.Text = "") Then
            MsgBox("You must enter a code")
        End If
        If (txtnombre.Text = "") Then
            MsgBox("You must enter a name")
        End If
        If (cmbtipo.SelectedIndex = 0) Then
            MsgBox("You must select a type")
        End If
        If (cmbcargah.SelectedIndex = 0) Then
            MsgBox("You must select a workload")
        End If

        'ingreso de materia

        If (accion = acciones.ingresar) Then

            If (txtcod.Text <> "" And txtnombre.Text <> "" And cmbtipo.SelectedIndex <> 0 And cmbcargah.SelectedIndex <> 0 And control <> 1) Then
                Dim sql As String = ""
                Dim cx As New Odbc.OdbcConnection
                Dim cm As New Odbc.OdbcCommand

                sql = "INSERT INTO materias VALUES ('" + txtcod.Text + "',"
                sql += cmbcargah.SelectedItem + ",'" + txtnombre.Text + "','"
                sql += cmbtipo.SelectedItem + "','"
                sql += cmbnomcarr.SelectedIndex + "'," + txtaño.Text + ")"
                cx.ConnectionString = "FileDSN=c:\itechplus_sec.dsn;UID=techplus_sec;pwd=1234"
                cx.Open()
                cm.Connection = cx
                cm.CommandText = sql
                cm.ExecuteNonQuery()

                cx.Close()
                MsgBox("Subject entered")
                control = 0
                txtnombre.Clear()
                txtcod.Clear()
                cmbtipo.SelectedIndex = 0
                cmbcargah.SelectedIndex = 0
                gbxmat.Visible = False
                gbxdatos.Visible = True
                cmbcarr.Visible = True
                cmbaño.Visible = True
                btnatras.Visible = False
                btnaceptar.Visible = False
                cmbcarr.SelectedIndex = 0
                cmbaño.SelectedIndex = 0

            End If

        End If

        'modificación de materia

        If (accion = acciones.modificar) Then
            If (txtcod.Text <> "" And txtnombre.Text <> "" And cmbtipo.SelectedIndex <> 0 And cmbcargah.SelectedIndex <> 0 And control <> 1) Then

                Dim sql As String = ""
                Dim cx As New Odbc.OdbcConnection
                Dim cm As New Odbc.OdbcCommand

                sql = "UPDATE materias SET "
                sql += "cod_materia = '" + txtcod.Text + "',"
                sql += "carga_horaria=" + cmbcargah.SelectedItem + ","
                sql += "nombre_mat='" + txtnombre.Text + "',"
                sql += "tipo_mat='" + cmbtipo.SelectedItem + "',"
                sql += "nombre_carr='" + cmbnomcarr.SelectedItem + "',"
                sql += "anio_de_la_materia=" + txtaño.Text
                sql += " where cod_materia = '" + unamateria.cod_materia.ToString + "'"
                MsgBox("Subject modified")
                control = 0
                cx.ConnectionString = "FileDSN=c:\itechplus_sec.dsn;UID=techplus_sec;pwd=1234"
                cx.Open()
                cm.Connection = cx
                cm.CommandText = sql
                cm.ExecuteNonQuery()
                cx.Close()
                iabmMat.Show()
                Me.Close()

            End If
        End If

        'elimina materia

        If (accion = acciones.eliminar) Then

            Dim sql As String = ""
            Dim cx As New Odbc.OdbcConnection
            Dim cm As New Odbc.OdbcCommand
            Select Case MsgBox("Are you sure to eliminate this subject" + txtnombre.Text + "?", MsgBoxStyle.YesNo)
                Case MsgBoxResult.Yes
                    sql = "DELETE FROM materias WHERE cod_materia = '" + txtcod.Text + "'"
                    cx.ConnectionString = "FileDSN=c:\itechplus_sec.dsn;UID=techplus_sec;pwd=1234"
                    cx.Open()
                    cm.Connection = cx
                    cm.CommandText = sql
                    cm.ExecuteNonQuery()
                    abmMateria.Show()
                    Me.Close()
                Case MsgBoxResult.No
                    iabmMat.Show()
                    Me.Close()
                    cx.Close()

            End Select
        End If

    End Sub

    Private Sub btnatras_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnatras.Click
        If (accion = acciones.ingresar) Then

            txtnombre.Clear()
            txtcod.Clear()
            cmbtipo.SelectedIndex = 0
            cmbcargah.SelectedIndex = 0
            iabmMat.Show()
            Me.Close()
            gbxmat.Visible = False
            cmbcarr.SelectedIndex = 0
            cmbaño.SelectedIndex = 0

            gbxdatos.Visible = True
            btnaceptar.Visible = False
            btnatras.Visible = False
            txtcod.Clear()
            txtnombre.Clear()
            cmbnomcarr.SelectedIndex = 0
            cmbtipo.SelectedIndex = 0
            cmbcargah.SelectedIndex = 0

        End If

        If (accion = acciones.modificar Or accion = acciones.eliminar) Then
            iabmMat.Show()
            Me.Close()

        End If

    End Sub

    Private Sub btncont_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btncont.Click
        If (cmbcarr.SelectedIndex = 0) Then
            MsgBox("You must select a career")
        End If
        If (cmbaño.SelectedIndex = 0) Then
            MsgBox("You must select the year of the career")

        End If
        If (cmbcarr.SelectedIndex <> 0 And cmbaño.SelectedIndex <> 0) Then
            gbxdatos.Visible = False
            gbxmat.Visible = True
            btnatras.Visible = True
            btnaceptar.Visible = True
            gbxmat.SetBounds(15, 75, 271, 226)
            btnatras.SetBounds(366, 174, 101, 22)
            btnaceptar.SetBounds(366, 133, 101, 22)
            cmbnomcarr.SelectedItem = cmbcarr.SelectedItem
            txtaño.Text = cmbaño.SelectedItem
        End If

    End Sub

    Private Sub cmbcarr_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cmbcarr.KeyPress
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

   

    Private Sub cmbaño_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cmbaño.KeyPress
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

    Private Sub Label6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label6.Click
        txtcod.Enabled = True
        txtaño.Enabled = True
        txtaño.ReadOnly = False
    End Sub

    Private Sub Label12_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label12.Click
        txtnombre.Enabled = True
    End Sub

    Private Sub Label11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label11.Click
        cmbtipo.Enabled = True
        cmbcargah.Enabled = True
    End Sub

    Private Sub Label10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label10.Click
        cmbnomcarr.Enabled = True

    End Sub

    Private Sub gbxedit_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles gbxedit.Enter
        
    End Sub

    Private Sub cmbtipo_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cmbtipo.KeyPress
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

    Private Sub cmbtipo_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbtipo.SelectedIndexChanged

    End Sub

    Private Sub cmbcargah_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cmbcargah.KeyPress
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

    Private Sub cmbcargah_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbcargah.SelectedIndexChanged

    End Sub

    Private Sub txtnomcar_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub btnclose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnclose.Click
        Select Case MsgBox("Do you want close this session?", MsgBoxStyle.YesNo)
            Case MsgBoxResult.Yes
                txtnombre.Clear()
                txtcod.Clear()
                cmbtipo.SelectedIndex = 0
                cmbcargah.SelectedIndex = 0
                gbxmat.Visible = False
                lbldial2.Visible = True
                lbldial3.Visible = True

                lbldial1.Visible = True
                cmbcarr.Visible = True
                cmbaño.Visible = True

                btnatras.Visible = False

                btnaceptar.Visible = False
                cmbcarr.SelectedIndex = 0
                cmbaño.SelectedIndex = 0

                login.txtusuario.Clear()
                login.txtpass.Clear()
                login.Show()
                Me.Hide()
            Case MsgBoxResult.No

                Me.Show()
        End Select
    End Sub

    Private Sub txtaño_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtaño.KeyPress
        If (e.KeyChar < "0" Or e.KeyChar > "9") And e.KeyChar <> Chr(Keys.Back) Then
            e.KeyChar = ""
        End If

    End Sub

    Private Sub txtaño_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtaño.MouseEnter

    End Sub

    Private Sub txtaño_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtaño.TextChanged

    End Sub
End Class