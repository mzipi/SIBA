Public Class altasalon

    Private Sub TextBox2_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Form10_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        cmbtipo.SelectedIndex = 0
        txttipo.Visible = False
        txtcnum.Visible = False

        Select Case accion

            Case acciones.ingresar

                btnaceptar.Text = "Ingresar"
                lbltitulo.Text = "INGRESO DE SALON"

            Case acciones.modificar


                btnaceptar.Text = "Modificar"
                lbltitulo.Text = "MODIFICACIÓN DE SALON"
                txtcodigo.Enabled = False


                With unsalon

                    txttipo.Text = .tipo_salon
                    txtcodigo.Text = .cod_salon
                    cmbtipo.SelectedItem = .tipo_salon
                    txtnumero.Text = .num_salon
                    txtcnum.Text = .num_salon

                End With
            Case acciones.eliminar

                btnaceptar.Text = "Eliminar"
                lbltitulo.Text = "BAJA DE SALÓN"


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

    Private Sub TextBox6_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Label13_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Label12_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Label11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub TextBox5_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub TextBox4_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Label7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Label8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btncancelar.Click
        txtnumero.Clear()
        cmbtipo.SelectedIndex = 0
        txtcodigo.Clear()


    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnaceptar.Click

        Dim control As Integer
        control = 0
        Dim controlcomb As Integer
        controlcomb = 0
        Dim controlmod As Integer
        controlmod = 0


        'controla que no existan campos vacios

        If (txtcodigo.Text = "") Then
            MsgBox("Debe ingresar un código de salón")
        End If
        If (cmbtipo.SelectedIndex = 0) Then
            MsgBox("Debe seleccionar un tipo de salón")
        End If
        If (txtnumero.Text = "") Then
            MsgBox("Debe ingresar un número de salón")

        End If


        ''''

        'controla que no se repita el codigo de salón al ingresar
        If (accion = acciones.ingresar And txtcodigo.Text <> "" And cmbtipo.SelectedIndex <> 0 And txtnumero.Text <> "") Then
            Dim cx2 As New Odbc.OdbcConnection
            Dim cm2 As New Odbc.OdbcCommand
            Dim da2 As New Odbc.OdbcDataAdapter
            Dim ds2 As New Data.DataSet

            cx2.ConnectionString = "FileDSN=c:\itechplus_sec.dsn;UID=techplus_sec;pwd=1234"
            cx2.Open()
            cm2.Connection = cx2
            cm2.CommandText = "SELECT cod_salon FROM salon where cod_salon=" + txtcodigo.Text
            cm2.ExecuteNonQuery()
            da2.SelectCommand = cm2
            da2.Fill(ds2, "salon")

            If ds2.Tables("salon").Rows.Count > 0 Then
                MsgBox("Código de salón ya existente, debe ingresar un código distinto")
                control = 1
            End If
            cx2.Close()
        End If

        '''''

        'controla no se repita combinacion al modificar

        If (accion = acciones.modificar) Then

            If (cmbtipo.SelectedItem <> txttipo.Text Or txtnumero.Text <> txtcnum.Text And txtnumero.Text <> "" And cmbtipo.SelectedIndex <> 0) Then



                Dim cx As New Odbc.OdbcConnection
                Dim cm As New Odbc.OdbcCommand
                Dim da As New Odbc.OdbcDataAdapter
                Dim ds As New Data.DataSet

                cx.ConnectionString = "FileDSN=c:\itechplus_sec.dsn;UID=techplus_sec;pwd=1234"
                cx.Open()
                cm.Connection = cx
                cm.CommandText = "SELECT tipo_salon, num_salon FROM salon where tipo_salon='" + cmbtipo.SelectedItem + "' and num_salon=" + txtnumero.Text
                cm.ExecuteNonQuery()
                da.SelectCommand = cm
                da.Fill(ds, "combmod")


                If ds.Tables("combmod").Rows.Count > 0 Then
                    MsgBox("Combinación tipo de salón, número ya existente. Seleccione otra combinación")
                    controlmod = 1
                End If
                cx.Close()

            End If
        End If

        ''''''''

        'controla que no se repita la combinación tipo salon numero al ingresar.

        If (accion = acciones.ingresar And txtcodigo.Text <> "" And cmbtipo.SelectedIndex <> 0 And txtnumero.Text <> "") Then
            Dim cx3 As New Odbc.OdbcConnection
            Dim cm3 As New Odbc.OdbcCommand
            Dim da3 As New Odbc.OdbcDataAdapter
            Dim ds3 As New Data.DataSet

            cx3.ConnectionString = "FileDSN=c:\itechplus_sec.dsn;UID=techplus_sec;pwd=1234"
            cx3.Open()
            cm3.Connection = cx3
            cm3.CommandText = "SELECT tipo_salon, num_salon FROM salon where tipo_salon='" + cmbtipo.SelectedItem + "' and num_salon=" + txtnumero.Text


            cm3.ExecuteNonQuery()
            da3.SelectCommand = cm3
            da3.Fill(ds3, "comb")

            If ds3.Tables("comb").Rows.Count > 0 Then
                MsgBox("Combinación tipo de salón, número ya existente. Seleccione otra combinación")
                controlcomb = 1
            End If

            cx3.Close()
        End If

        ''''''''

        'realiza el ingreso

        If (accion = acciones.ingresar) Then

            If (txtcodigo.Text <> "" And cmbtipo.SelectedIndex <> 0 And txtnumero.Text <> "" And control <> 1 And controlcomb <> 1) Then

                Dim sql As String = ""
                Dim cx As New Odbc.OdbcConnection
                Dim cm As New Odbc.OdbcCommand



                sql = "INSERT INTO salon VALUES (" + txtcodigo.Text + ",'"
                sql += cmbtipo.SelectedItem + "'," + txtnumero.Text + ")"
                MsgBox("Usted ha ingresado un salon de tipo " + cmbtipo.SelectedItem.ToString)

                cx.ConnectionString = "FileDSN=c:\itechplus_sec.dsn;UID=techplus_sec;pwd=1234"
                cx.Open()
                cm.Connection = cx
                cm.CommandText = sql
                cm.ExecuteNonQuery()

                txtnumero.Clear()
                cmbtipo.SelectedIndex = 0
                txtcodigo.Clear()

            End If
        End If

        If (accion = acciones.modificar) Then
            If (txtcodigo.Text <> "" And cmbtipo.SelectedIndex <> 0 And txtnumero.Text <> "" And controlmod <> 1) Then


                Dim sql As String = ""
                Dim cx As New Odbc.OdbcConnection
                Dim cm As New Odbc.OdbcCommand

                sql = "UPDATE salon SET "
                sql += "cod_salon = " + txtcodigo.Text + ","
                sql += "tipo_salon='" + cmbtipo.SelectedItem + "',"
                sql += "num_salon=" + txtnumero.Text + ""
                sql += " WHERE cod_salon = " + unsalon.cod_salon.ToString + ""

                cx.ConnectionString = "FileDSN=c:\itechplus_sec.dsn;UID=techplus_sec;pwd=1234"
                cx.Open()
                cm.Connection = cx
                cm.CommandText = sql
                cm.ExecuteNonQuery()
                MsgBox("Salón modificado exitosamente")
                abmSalon.Show()
                Me.Close()

            End If
        End If


        'realiza la baja de salón

        If (accion = acciones.eliminar) Then

            Dim sql As String = ""
            Dim cx As New Odbc.OdbcConnection
            Dim cm As New Odbc.OdbcCommand

            sql = "DELETE FROM salon WHERE cod_salon= " + txtcodigo.Text + ""
            cx.ConnectionString = "FileDSN=c:\itechplus_sec.dsn;UID=techplus_sec;pwd=1234"
            cx.Open()
            cm.Connection = cx
            cm.CommandText = sql
            cm.ExecuteNonQuery()
            MsgBox("Salón eliminado exitosamente")
            abmSalon.Show()
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
        Select Case MsgBox("Desea cerrar sesión?", MsgBoxStyle.YesNo)
            Case MsgBoxResult.Yes
                txtnumero.Clear()
                cmbtipo.SelectedIndex = 0
                txtcodigo.Clear()
                login.txtusuario.clear()
                login.txtpass.clear()

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

        abmSalon.Show()
        Me.Close()
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

    Private Sub lblcod_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblcod.Click

    End Sub

    Private Sub TextBox2_TextChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtcnum.TextChanged

    End Sub
End Class




