Public Class altaMateria

    Private Sub Form29_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        txtcarga.Visible = False
        txtcodigo.Visible = False

        If (accion = acciones.ingresar) Then

            Dim cx As New Odbc.OdbcConnection
            Dim cm As New Odbc.OdbcCommand
            Dim da As New Odbc.OdbcDataAdapter
            Dim ds As New DataSet
            Dim dr As Odbc.OdbcDataReader
            cx.ConnectionString = "FileDSN=c:\itechplus_sec.dsn;UID=techplus_sec;pwd=1234"
            cx.Open()

            cm.CommandText = "SELECT nombre_carr from carreras"
            cm.Connection = cx

            dr = cm.ExecuteReader
            cmbcarr.Items.Add("(Seleccione)")
            While dr.Read
                cmbcarr.Items.Add(dr.GetString(0))
            End While
            cmbcarr.SelectedIndex = 0
            dr.Close()
            cx.Close()

        End If

        Select Case accion

            Case acciones.ingresar
                gbxdatos.Visible = True
                gbxedit.Visible = False
                cmbcarr.SelectedIndex = 0
                cmbtipo.SelectedIndex = 0
                cmbcargah.SelectedIndex = 0
                gbxmat.Visible = False
                btnatras.Visible = False
                btnaceptar.Visible = False

                cmbnomcarr.SelectedIndex = 0
                btnaceptar.Text = "Ingresar"
                lbltitulo.Text = "INGRESO DE MATERIA"

            Case acciones.modificar
                gbxdatos.Visible = False
                gbxedit.Visible = True
                btnatras.Visible = True
                btnaceptar.Visible = True
                gbxmat.SetBounds(15, 75, 346, 231)
                btnatras.SetBounds(366, 174, 101, 22)
                btnaceptar.SetBounds(366, 133, 101, 22)

                btnaceptar.Text = "Modificar"
                lbltitulo.Text = "MODIFICACIÓN DE MATERIA"
                With unamateria
                    txtcodigo.Text = .cod_materia
                    txtcod.Text = .cod_materia
                    txtaño.Text = .año_mat
                    txtnombre.Text = .nombre_mat
                    cmbtipo.SelectedItem = .tipo_mat
                    cmbcargah.SelectedItem = .carga_horaria
                    cmbnomcarr.SelectedItem = .nombre_carr
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

                btnaceptar.Text = "Eliminar"
                lbltitulo.Text = "BAJA DE MATERIA"

                With unamateria
                    txtcod.Text = .cod_materia
                    txtaño.Text = .año_mat
                    txtnombre.Text = .nombre_mat
                    cmbtipo.SelectedItem = .tipo_mat
                    cmbcargah.SelectedItem = .carga_horaria
                    cmbnomcarr.SelectedItem = .nombre_carr
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

    Private Sub Label14_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lbltitulo.Click

    End Sub

    Private Sub Label10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btncont.Click
        If (cmbcarr.SelectedIndex = 0) Then
            MsgBox("Debe seleccionar una carrera")
        End If
        If (cmbaño.SelectedIndex = 0) Then
            MsgBox("Debe ingresar el año de la carrera")

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
            cmbnomcarr.Enabled = False
            txtaño.text = cmbaño.SelectedItem
        End If

    End Sub

    Private Sub TextBox4_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub



    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnclose.Click
        Select Case MsgBox("Desea cerrar sesión?", MsgBoxStyle.YesNo)
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

                login.txtusuario.clear()
                login.txtpass.clear()
                login.Show()
                Me.Hide()
            Case MsgBoxResult.No

                Me.Show()
        End Select
    End Sub

    Private Sub Label8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblrol.Click

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnaceptar.Click

        Dim control As Integer
        control = 0

        Dim controla As Integer
        controla = 0


        If (txtcod.Text = "") Then
            MsgBox("Debe ingresar un código")
        End If
        If (txtnombre.Text = "") Then
            MsgBox("Debe ingresar un nombre")
        End If
        If (cmbtipo.SelectedIndex = 0) Then
            MsgBox("Debe seleccionar un tipo de materia")
        End If
        If (cmbcargah.SelectedIndex = 0) Then
            MsgBox("Debe seleccionar una carga horaria para la materia")
        End If


        'controla que no se repita el codigo de materia al ingresar
        If (accion = acciones.ingresar And txtcod.Text <> "" And txtnombre.Text <> "" And cmbtipo.SelectedIndex <> 0) Then
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
                MsgBox("Código de materia ya existente, debe ingresar un código distinto")
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
                MsgBox("Código de materia ya existente, debe ingresar un código distinto")
                control = 1
            End If
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
                sql += cmbnomcarr.SelectedItem + "'," + txtaño.Text + ")"
                cx.ConnectionString = "FileDSN=c:\itechplus_sec.dsn;UID=techplus_sec;pwd=1234"
                cx.Open()
                cm.Connection = cx
                cm.CommandText = sql
                cm.ExecuteNonQuery()
                MsgBox("Materia ingresada exitosamente")
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
                sql += "nombre_carr='" + cmbnomcarr.SelectedIndex + "',"
                sql += "anio_de_la_materia=" + txtaño.Text
                sql += " where cod_materia = '" + unamateria.cod_materia.ToString + "'"
                MsgBox("Materia modificada exitosamente")
                control = 0
                cx.ConnectionString = "FileDSN=c:\itechplus_sec.dsn;UID=techplus_sec;pwd=1234"
                cx.Open()
                cm.Connection = cx
                cm.CommandText = sql
                cm.ExecuteNonQuery()
                abmMateria.Show()
                Me.Close()

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
            cm.CommandText = "SELECT * FROM tienen where cod_materia ='" + txtcod.Text + "'"
            cm.ExecuteNonQuery()
            da.SelectCommand = cm
            da.Fill(ds, "tienen")

            If ds.Tables("tienen").Rows.Count > 0 Then
                MsgBox("Existen grupos asociados a esta materia. Debe eliminar los grupos asociados a la materia para luego eliminar la materia")
                controla = 1

            End If
        End If





        'elimina materia

        If (accion = acciones.eliminar And controla <> 1) Then

            Dim sql As String = ""
            Dim cx As New Odbc.OdbcConnection
            Dim cm As New Odbc.OdbcCommand
            Select Case MsgBox("Está seguro de eliminar la materia " + txtnombre.Text + "?", MsgBoxStyle.YesNo)
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
                    abmMateria.Show()
                    Me.Close()
            End Select
        End If





    End Sub

    Private Sub gbxmat_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles gbxmat.Enter

    End Sub

    Private Sub btnatras_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnatras.Click
        If (accion = acciones.ingresar) Then

            txtnombre.Clear()
            txtcod.Clear()
            cmbtipo.SelectedIndex = 0
            cmbcargah.SelectedIndex = 0
            abmMateria.Show()
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
            abmMateria.Show()
            Me.Close()

        End If



    End Sub

    Private Sub txtcod_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtcod.TextChanged
        
    End Sub

    Private Sub Label1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click

    End Sub

    Private Sub txtaño_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtaño.KeyPress
        If (e.KeyChar < "0" Or e.KeyChar > "9") And e.KeyChar <> Chr(Keys.Back) Then
            e.KeyChar = ""
        End If

    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtaño.TextChanged

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

    Private Sub cmbcarr_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbcarr.SelectedIndexChanged
        Dim i As Integer
        Dim f As Integer
        f = 1

        If cmbcarr.SelectedIndex <> 0 Then
            Dim cx2 As New Odbc.OdbcConnection
            Dim cm2 As New Odbc.OdbcCommand
            Dim lector As Odbc.OdbcDataReader
            cx2.ConnectionString = "FileDSN=c:\itechplus_sec.dsn;UID=techplus_sec;pwd=1234"
            cx2.Open()

            cm2.CommandText = "SELECT duracion from carreras where nombre_carr='" + cmbcarr.SelectedItem + "'"
            cm2.Connection = cx2
            lector = cm2.ExecuteReader()
            cmbaño.Items.Add("(Seleccione)")
            If lector.HasRows Then
                i = lector.GetString(0)

                While (f <= i)
                    cmbaño.Items.Add((f))
                    f += 1

                End While

                cx2.Close()
            End If


            cmbaño.SelectedIndex = 0
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

    Private Sub cmbaño_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbaño.SelectedIndexChanged

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

    Private Sub GroupBox1_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles gbxdatos.Enter

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

    Private Sub Label10_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label10.Click
        cmbnomcarr.Enabled = True
        

    End Sub

    Private Sub TextBox1_TextChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtcodigo.TextChanged

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        abmMateria.Show()
        Me.Close()

    End Sub

    Private Sub txtcarga_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtcarga.TextChanged

    End Sub
End Class