Public Class ingdatosusuarios
    Dim a As Integer = 0


    Public Sub New()
        InitializeComponent()
        Dim ttDatos_ci As New ToolTip
        Dim ttdisp As New ToolTip
        ttdisp.SetToolTip(btndisponibilidadonibilidad, "Verifique disponibilidad de usuario")
        ttDatos_ci.SetToolTip(lbldatos_Ci, "Debe ingresar sólo números. Ej: 1.111.111-8. El ingreso será 11111118")
    End Sub

    Private Sub txtci_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtci.KeyPress
        If (e.KeyChar < "0" Or e.KeyChar > "9") And e.KeyChar <> Chr(Keys.Back) Then
            e.KeyChar = ""
        End If
    End Sub

    Private Sub txtci_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtci.TextChanged

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

    Private Sub cmbperfil_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cmbperfil.KeyPress
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

    Private Sub cmbgrado_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbperfil.SelectedIndexChanged

    End Sub

    Private Sub txttel_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtpass.TextChanged

    End Sub

    Private Sub lblformac_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblnomusu.Click

    End Sub

    Private Sub txtnomusua_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtnomusua.KeyPress
        If Char.IsLetter(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If

    End Sub

    Private Sub btnclose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnclose.Click
        Select Case MsgBox("Desea cerrar sesión?", MsgBoxStyle.YesNo)
            Case MsgBoxResult.Yes
                login.txtusuario.clear()
                login.txtpass.clear()

                login.Show()
                Me.Close()
            Case MsgBoxResult.No
                Me.Hide()
                Me.Show()
        End Select
    End Sub

    Private Sub btning_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnaceptar.Click

        Dim control As Integer
        Dim mailvalido As Integer
        mailvalido = 0
        control = 0

        If (txtnombre.Text = "") Then
            MsgBox("Debe ingresar el nombre y apellido del usuario")
        End If
        If (txtci.Text = "") Then
            MsgBox("Debe ingresar la cédula de identidad del usuario")
        End If
        If (cmbperfil.SelectedIndex = 0) Then
            MsgBox("Debe seleccionar un perfil para el usuario")
        End If
        If (txtnomusua.Text = "") Then
            MsgBox("Debe ingresar un nombre de usuario")
        End If

        If (txtpass.Text = "") Then
            MsgBox("Debe ingresar una contraseña para el usuario")

        End If
        If (accion = acciones.ingresar) Then
            If (txtreppass.Text = "") Then
                MsgBox("Debe repetir la contraseña para el usuario")

            End If
        End If

        If (txtemail.Text <> "") Then
            If (txtemail.Text.Contains("@") And txtemail.Text.Contains(".")) Then
                mailvalido = 1
            Else
                mailvalido = 2
            End If
        End If

        If (accion = acciones.ingresar) Then
            If (txtpass.Text <> txtreppass.Text) Then
                MsgBox("No coinciden las contraseñas ingresadas")

            End If
        End If

        If (mailvalido > 1) Then
            MsgBox("email invalido")
        End If

        'controla que no se repita el usuario al ingresar
        If (accion = acciones.ingresar And txtnomusua.Text <> "") Then
            Dim cx As New Odbc.OdbcConnection
            Dim cm As New Odbc.OdbcCommand
            Dim da As New Odbc.OdbcDataAdapter
            Dim ds As New Data.DataSet

            cx.ConnectionString = "FileDSN=c:\itechplus_enc.dsn;UID=techplus_enc;pwd=1234"
            cx.Open()
            cm.Connection = cx
            cm.CommandText = "SELECT nombre_usuario FROM usuarios where nombre_usuario ='" + txtnomusua.Text + "'"
            cm.ExecuteNonQuery()
            da.SelectCommand = cm
            da.Fill(ds, "usuarios")

            If ds.Tables("usuarios").Rows.Count > 0 Then
                MsgBox("Usuario ya existe, debe ingresar un nombre de usuario distinto")
                control = 1
            End If
            cx.Close()

        End If
        
        


        If (accion = acciones.ingresar) Then

            If (txtnombre.Text <> "" And txtci.Text <> "" And cmbperfil.SelectedIndex <> 0 And txtnomusua.Text <> "" And txtpass.Text <> "" And txtpass.Text = txtreppass.Text And control = 0 And mailvalido < 2) Then

                Dim sql As String = ""
                Dim con As New Odbc.OdbcConnection
                Dim com As New Odbc.OdbcCommand

                sql = "INSERT INTO usuarios VALUES ('" + txtnomusua.Text + "','"
                sql += txtpass.Text + "',"
                sql += txtci.Text + ",'"
                sql += cmbperfil.SelectedItem + "','"
                sql += txtemail.Text + "','"
                sql += txtnombre.Text + "')"

                'MsgBox("Usuario ingresado con perfil " + cmbperfil.SelectedItem)
                control = 0
                btnver.Enabled = True
                mailvalido = 0

                con.ConnectionString = "FileDSN=c:\itechplus_enc.dsn;UID=techplus_enc;pwd=1234"
                con.Open()
                com.Connection = con
                com.CommandText = sql
                com.ExecuteNonQuery()
                MsgBox("Usuario ingresado exitosamente")
                con.Close()
            End If


        End If
        If (accion = acciones.modificar) Then
            If (txtnombre.Text <> "" And txtci.Text <> "" And cmbperfil.SelectedIndex <> 0 And txtnomusua.Text <> "" And txtpass.Text <> "" And control = 0 And mailvalido < 2) Then
                Dim sql As String = ""
                Dim con As New Odbc.OdbcConnection
                Dim com As New Odbc.OdbcCommand

                sql = "UPDATE usuarios SET "
                sql += "nombre_usuario ='" + txtnomusua.Text + "',"
                sql += "contrasenia='" + txtpass.Text + "',"
                sql += "ced_id= " + txtci.Text + ","
                sql += "perfil_usuario='" + cmbperfil.SelectedItem + "',"
                sql += "email='" + txtemail.Text + "',"
                sql += "nombre_apellido='" + txtnombre.Text + "'"
                sql += " WHERE nombre_usuario = '" + unusuario.nombre_usuario.ToString + "'"
                MsgBox("Usuario modificado exitosamente")

                con.ConnectionString = "FileDSN=c:\itechplus_enc.dsn;UID=techplus_enc;pwd=1234"
                con.Open()
                com.Connection = con
                com.CommandText = sql
                com.ExecuteNonQuery()
                con.Close()

                abmusuario.Show()
                Me.Close()

            End If

        End If

        If (accion = acciones.eliminar) Then
            Dim sql As String = ""
            Dim con As New Odbc.OdbcConnection
            Dim com As New Odbc.OdbcCommand

            Select Case MsgBox("Está seguro de eliminar al usuario " + txtnomusua.Text + "?", MsgBoxStyle.YesNo)
                Case MsgBoxResult.Yes

                    sql = "DELETE FROM usuarios WHERE nombre_usuario= '" + txtnomusua.Text + "'"
                    MsgBox("Usuario eliminado exitosamente")

                    con.ConnectionString = "FileDSN=c:\itechplus_enc.dsn;UID=techplus_enc;pwd=1234"
                    con.Open()
                    com.Connection = con
                    com.CommandText = sql
                    com.ExecuteNonQuery()
                    con.Close()
                    abmusuario.Show()

                    Me.Close()
                Case MsgBoxResult.No
                    abmusuario.Show()
                    Me.Close()
            End Select



        End If



    End Sub

    Private Sub btncancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btncancel.Click
        txtnombre.Clear()
        txtci.Clear()
        cmbperfil.SelectedIndex = 0
        txtnomusua.Clear()
        txtpass.Clear()
        txtreppass.Clear()
        txtemail.Clear()

    End Sub

    Private Sub btnfin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnfin.Click
        txtnombre.Clear()
        txtci.Clear()
        cmbperfil.SelectedIndex = 0
        txtnomusua.Clear()
        txtpass.Clear()
        txtreppass.Clear()
        txtemail.Clear()
        abmusuario.Show()
        Me.Close()
    End Sub

    Private Sub altausuario_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        txtnombreusuario.Visible = False
        gbxedit.Visible = False

        If (accion = acciones.ingresar) Then
            lbldatos_Ci.Visible = True

            btndisponibilidadonibilidad.Enabled = False


        End If

        If (accion = acciones.modificar) Then
            txtnombre.Enabled = False
            txtnomusua.Enabled = False
            txtpass.Enabled = False
            txtreppass.Enabled = False
            txtemail.Enabled = False
            cmbperfil.Enabled = False
            txtci.Enabled = False
            gbxedit.Visible = True
            btndisponibilidadonibilidad.Visible = False


        End If


        If (accion = acciones.eliminar) Then
            txtnombre.Enabled = False
            txtnomusua.Enabled = False
            txtpass.Enabled = False
            txtreppass.Enabled = False
            txtemail.Enabled = False
            cmbperfil.Enabled = False
            txtci.Enabled = False
            gbxedit.Visible = False

            lbldatos_Ci.Visible = False
            btndisponibilidadonibilidad.Visible = False



        End If

        btnreset.Visible = False

        gbxver.Visible = False
        dgvusuarios.Visible = False
        btncont.Visible = False

        Select Case accion
            Case acciones.ingresar
                
                cmbperfil.SelectedIndex = 0
                btnaceptar.Text = "Ingresar"
                lbltitulo.Text = "INGRESO DE USUARIO"
                btnver.Enabled = False


            Case acciones.modificar

                txtreppass.Text = txtpass.Text
                btnaceptar.Text = "Modificar"
                lbltitulo.Text = "MODIFICACIÓN DE USUARIO"
                btnreset.Visible = True
                btnver.Visible = False
                txtpass.Enabled = False
                txtreppass.Enabled = False

                With unusuario
                    txtnombre.Text = .nombre_apellido
                    txtci.Text = .ced_id
                    cmbperfil.SelectedItem = .perfil_usuario
                    txtnomusua.Text = .nombre_usuario
                    txtpass.Text = .contraseña
                    txtemail.Text = .email
                    txtnombreusuario.Text = .nombre_usuario
                End With
            Case acciones.eliminar
                btnaceptar.Text = "Eliminar"
                lbltitulo.Text = "BAJA DE USUARIO"
                btnver.Visible = False
                txtpass.Enabled = False
                txtreppass.Enabled = False

                With unusuario
                    txtnombre.Text = .nombre_apellido
                    txtci.Text = .ced_id
                    cmbperfil.SelectedItem = .perfil_usuario
                    txtnomusua.Text = .nombre_usuario
                    txtpass.Text = .contraseña
                    txtemail.Text = .email
                    txtnombreusuario.Text = txtnomusua.Text
                End With

        End Select

    End Sub

    Private Sub txtemail_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtemail.KeyPress
        txtemail.Text.Contains("@")

    End Sub

    Private Sub txtemail_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles txtemail.MouseUp

    End Sub

    Private Sub txtemail_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtemail.TextChanged

    End Sub

    Private Sub btnver_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnver.Click



        Dim cx As New Odbc.OdbcConnection
        Dim cm As New Odbc.OdbcCommand
        Dim da As New Odbc.OdbcDataAdapter
        Dim ds As New Data.DataSet

        gbxver.Visible = True
        gbxver.SetBounds(15, 55, 480, 305)

        cx.ConnectionString = "FileDSN=c:\itechplus_enc.dsn;UID=techplus_enc;pwd=1234"
        cx.Open()
        cm.Connection = cx
        cm.CommandText = "SELECT * FROM usuarios"
        cm.ExecuteNonQuery()
        da.SelectCommand = cm
        da.Fill(ds, "usuarios")
        dgvusuarios.DataSource = ds.Tables("usuarios")
        dgvusuarios.Visible = True
        dgvusuarios.SetBounds(25, 68, 445, 225)
        dgvusuarios.RowHeadersVisible = False
        dgvusuarios.Columns("contrasenia").Visible = False
        dgvusuarios.Columns(0).HeaderText = "Usuario"
        dgvusuarios.Columns(2).HeaderText = "Cédula Id"
        dgvusuarios.Columns(3).HeaderText = "Perfil"
        dgvusuarios.Columns(4).HeaderText = "Email"
        dgvusuarios.Columns(5).HeaderText = "Nombre Apellido"
        cx.Close()

        btnver.Visible = False
        btncont.Visible = True
        dgvusuarios.CurrentCell = dgvusuarios.Rows(dgvusuarios.Rows.Count - 2).Cells(0)
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btncont.Click
        gbxver.Visible = False
        dgvusuarios.Visible = False
        btnver.Visible = True
        btnver.Enabled = False
        btncont.Visible = False
        txtnombre.Clear()
        txtci.Clear()
        cmbperfil.SelectedIndex = 0
        txtnomusua.Clear()
        txtpass.Clear()
        txtreppass.Clear()
        txtemail.Clear()

    End Sub

    Private Sub GroupBox1_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles gbxver.Enter

    End Sub

    Private Sub Button1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)


    End Sub



    Private Sub ToolTip1_Popup(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PopupEventArgs) Handles ttdisp.Popup

    End Sub

    Private Sub txtnomusua_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtnomusua.TextChanged
        If (accion = acciones.modificar) Then
            a = 1
            btndisponibilidadonibilidad.Visible = True
            btndisponibilidadonibilidad.Enabled = True
        End If
        If (accion = acciones.ingresar) Then
            btndisponibilidadonibilidad.Enabled = True
        End If
    End Sub

    Private Sub btnreset_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnreset.Click
        txtpass.Text = 1234
        txtreppass.Text = 1234

    End Sub



    Private Sub Label1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)
        txtnombre.Enabled = True
    End Sub

    Private Sub Label2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        txtci.Enabled = True
    End Sub

    Private Sub Label3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label3.Click
        cmbperfil.Enabled = True

    End Sub

    Private Sub Label4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label4.Click
        Label4.Visible = False
        txtnomusua.Enabled = True
        btndisponibilidadonibilidad.Visible = True



        

    End Sub

    Private Sub Label5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label5.Click
        txtemail.Enabled = True
    End Sub

    Private Sub gbxedit_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles gbxedit.Enter

    End Sub

    Private Sub btndisponibilidadonibilidad_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btndisponibilidadonibilidad.Click
        Dim control As Integer
        control = 0
        If (accion = acciones.ingresar) Then
            Dim cx As New Odbc.OdbcConnection
            Dim cm As New Odbc.OdbcCommand
            Dim da As New Odbc.OdbcDataAdapter
            Dim ds As New Data.DataSet


            cx.ConnectionString = "FileDSN=c:\itechplus_enc.dsn;UID=techplus_enc;pwd=1234"
            cx.Open()
            cm.Connection = cx
            cm.CommandText = "SELECT nombre_usuario FROM usuarios where nombre_usuario ='" + txtnomusua.Text + "'"
            cm.ExecuteNonQuery()
            da.SelectCommand = cm
            da.Fill(ds, "usuarios")

            If ds.Tables("usuarios").Rows.Count > 0 Then
                MsgBox("Usuario ya existe, debe ingresar un nombre de usuario distinto")
                control = 1
            Else
                MsgBox("Usuario valido")
            End If
            cx.Close()

        End If

        If (accion = acciones.modificar And txtnombreusuario.Text = txtnomusua.Text) Then
            MsgBox("Aún no ha modificado el usuario, usuario válido")
        End If

        If (accion = acciones.modificar And txtnombreusuario.Text <> txtnomusua.Text) Then

            Dim cx As New Odbc.OdbcConnection
            Dim cm As New Odbc.OdbcCommand
            Dim da As New Odbc.OdbcDataAdapter
            Dim ds As New Data.DataSet

            cx.ConnectionString = "FileDSN=c:\itechplus_enc.dsn;UID=techplus_enc;pwd=1234"
            cx.Open()
            cm.Connection = cx
            cm.CommandText = "SELECT nombre_usuario FROM usuarios where nombre_usuario ='" + txtnomusua.Text + "'"
            cm.ExecuteNonQuery()
            da.SelectCommand = cm
            da.Fill(ds, "usuarios")

            If ds.Tables("usuarios").Rows.Count > 0 Then
                MsgBox("Usuario ya existe, debe ingresar un nombre de usuario distinto")
                control = 1
            Else
                MsgBox("Usuario válido")
            End If
            cx.Close()
        End If

    End Sub
End Class
