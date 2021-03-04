Public Class ialtasalon

    Private Sub ialtasalon_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Select Case accion

            Case acciones.ingresar
                gbxsalon.SetBounds(279, 58, 271, 214)
                btnaceptar.Text = "Insert"
                lbltitulo.Text = "ENTRY CLASSROOM"

            Case acciones.modificar

                gbxsalon.SetBounds(15, 58, 271, 214)
                btnaceptar.Text = "ModifY"
                lbltitulo.Text = "CHANGE CLASSROOM"


                With unsalon

                    txtcodigo.Text = .cod_salon
                    cmbtipo.SelectedItem = .tipo_salon
                    txtnumero.Text = .num_salon
                End With
            Case acciones.eliminar

                gbxsalon.SetBounds(15, 58, 271, 214)

                btnaceptar.Text = "Delete"
                lbltitulo.Text = "LOW CLASSROOM"


                With unsalon
                    txtcodigo.Text = .cod_salon
                    cmbtipo.SelectedItem = .tipo_salon
                    txtnumero.Text = .num_salon
                End With
                txtcodigo.ReadOnly = True
                cmbtipo.Enabled = False
                txtnumero.ReadOnly = True

        End Select
    End Sub
    Private Sub TextBox2_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub


    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btncancelar.Click
        txtnumero.Clear()
        cmbtipo.SelectedIndex = 0
        txtcodigo.Clear()


    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnaceptar.Click
        If (txtcodigo.Text = "") Then
            MsgBox("You must enter a code for the classroom")
        End If
        If (cmbtipo.SelectedIndex = 0) Then
            MsgBox("You must select a type for the classroom")
        End If
        If (txtnumero.Text = "") Then
            MsgBox("You must enter a number for the classroom")

        End If

        If (accion = acciones.ingresar And txtnumero.Text <> "" And cmbtipo.SelectedIndex <> 0 And txtcodigo.Text <> "") Then

            Dim sql As String = ""
            Dim cx As New Odbc.OdbcConnection
            Dim cm As New Odbc.OdbcCommand


            sql = "INSERT INTO salon VALUES (" + txtcodigo.Text + ",'"
            sql += cmbtipo.SelectedItem + "'," + txtnumero.Text + ")"
            MsgBox("You must enter a classroom type " + cmbtipo.SelectedItem.ToString)
            txtnumero.Clear()
            cmbtipo.SelectedIndex = 0
            txtcodigo.Clear()

            cx.ConnectionString = "FileDsn=c:\itechplus_sec.dsn;UID=techplus_sec;PWD=1234"
            cx.Open()
            cm.Connection = cx
            cm.CommandText = sql
            cm.ExecuteNonQuery()
            cx.Close()

        End If

        If accion = acciones.modificar Then
            Dim sql As String = ""
            Dim cx As New Odbc.OdbcConnection
            Dim cm As New Odbc.OdbcCommand

            Sql = "UPDATE salon SET "
            Sql += "cod_salon = " + txtcodigo.Text + ","
            Sql += "tipo_salon='" + cmbtipo.SelectedItem + "',"
            Sql += "num_salon=" + txtnumero.Text + ""
            Sql += " WHERE cod_salon = " + unsalon.cod_salon.ToString + ""

            cx.ConnectionString = "FileDsn=c:\itechplus_sec.dsn;UID=techplus_sec;PWD=1234"
            cx.Open()
            cm.Connection = cx
            cm.CommandText = Sql
            cm.ExecuteNonQuery()
            MsgBox("Classroom modified")
            iabmsalon.Show()
            Me.Close()
        End If


        If accion = acciones.ingresar Then

            Dim sql As String = ""
            Dim cx As New Odbc.OdbcConnection
            Dim cm As New Odbc.OdbcCommand

            sql = "DELETE FROM salon WHERE cod_salon= " + txtcodigo.Text
            cx.ConnectionString = "FileDsn=c:\itechplus_sec.dsn;UID=techplus_sec;PWD=1234"
            cx.Open()
            cm.Connection = cx
            cm.CommandText = Sql
            cm.ExecuteNonQuery()
            MsgBox("Classroom deleted")
            iabmsalon.Show()
            Me.Close()

        End If
      








    End Sub

    Private Sub txtnumero_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtnumero.KeyPress
        If (e.KeyChar < "0" Or e.KeyChar > "9") And e.KeyChar <> Chr(Keys.Back) Then
            e.KeyChar = ""
        End If
    End Sub

    Private Sub txtnumero_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtnumero.TextChanged

    End Sub

    Private Sub txtcodigo_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtcodigo.KeyPress
        If (e.KeyChar < "0" Or e.KeyChar > "9") And e.KeyChar <> Chr(Keys.Back) Then
            e.KeyChar = ""
        End If
    End Sub

    Private Sub txtcodigo_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtcodigo.TextChanged

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Select Case MsgBox("Do you want close this session?", MsgBoxStyle.YesNo)
            Case MsgBoxResult.Yes
                txtnumero.Clear()
                cmbtipo.SelectedIndex = 0
                txtcodigo.Clear()
                login.txtusuario.Clear()
                login.txtpass.Clear()

                login.Show()
                Me.Hide()
            Case MsgBoxResult.No
                Me.Hide()
                Me.Show()
        End Select



    End Sub

    Private Sub btnfinalizar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnfinalizar.Click
        txtnumero.Clear()
        cmbtipo.SelectedIndex = 0
        txtcodigo.Clear()

        iabmsalon.Show()
        Me.Hide()
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
End Class
