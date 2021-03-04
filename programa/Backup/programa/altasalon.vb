Public Class altasalon

    Private Sub TextBox2_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Form10_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Select Case accion

            Case acciones.ingresar
                gbxcant.Visible = True
                gbxsalon.SetBounds(279, 58, 271, 214)
                btnaceptar.Text = "Ingresar"
                lbltitulo.Text = "INGRESO DE SALON"

            Case acciones.modificar
                gbxcant.Visible = False
                gbxsalon.SetBounds(15, 58, 271, 214)
                btnaceptar.Text = "Modificar"
                lbltitulo.Text = "MODIFICACIÓN DE SALON"


                With unsalon

                    txtcodigo.Text = .cod_salon
                    cmbtipo.SelectedItem = .tipo_salon
                    txtnumero.Text = .num_salon
                End With
            Case acciones.eliminar
                gbxcant.Visible = False
                gbxsalon.SetBounds(15, 58, 271, 214)

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

    Private Sub TextBox6_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtteorico.TextChanged

    End Sub

    Private Sub Label13_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblteo.Click

    End Sub

    Private Sub Label12_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lbllab.Click

    End Sub

    Private Sub Label11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lbltall.Click

    End Sub

    Private Sub TextBox5_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txttaller.TextChanged

    End Sub

    Private Sub TextBox4_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtlaboratorio.TextChanged

    End Sub

    Private Sub Label7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label7.Click

    End Sub

    Private Sub Label8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label8.Click

    End Sub

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btncancelar.Click
        txtnumero.Clear()
        cmbtipo.SelectedIndex = 0
        txtcodigo.Clear()


    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnaceptar.Click
        Dim tipo_salon As New Integer
        tipo_salon = cmbtipo.SelectedIndex


        Dim sql As String = ""
        Dim cx As New Odbc.OdbcConnection
        Dim cm As New Odbc.OdbcCommand

        Select Case accion
            Case acciones.ingresar
                If (txtcodigo.Text = "") Then
                    MsgBox("Debe ingresar un código de salón")
                End If
                If (cmbtipo.SelectedIndex = 0) Then
                    MsgBox("Debe seleccionar un tipo de salón")
                End If
                If (txtnumero.Text = "") Then
                    MsgBox("Debe ingresar un número de salón")

                End If

                If (txtcodigo.Text <> "" And cmbtipo.SelectedIndex <> 0 And txtnumero.Text <> "") Then

                    Select Case tipo_salon
                        Case 1
                            If (Val(txtteorico.Text = 0)) Then
                                MsgBox("Error de ingreso, No cuenta con mas salones de ese tipo para ingresar")
                            Else

                                sql = "INSERT INTO salon VALUES (" + txtcodigo.Text + ",'"
                                sql += cmbtipo.SelectedItem + "'," + txtnumero.Text + ")"
                                MsgBox("Usted ha ingresado un salon de tipo " + cmbtipo.SelectedItem.ToString)
                                txtteorico.Text = Val(txtteorico.Text) - 1
                                txtnumero.Clear()
                                cmbtipo.SelectedIndex = 0
                                txtcodigo.Clear()

                            End If

                        Case 2
                            If (Val(txtlaboratorio.Text = 0)) Then
                                MsgBox("Error de ingreso, No cuenta con mas salones de ese tipo para ingresar")
                            Else
                                sql = "INSERT INTO salon VALUES (" + txtcodigo.Text + ",'"
                                sql += cmbtipo.SelectedItem + "'," + txtnumero.Text + ")"
                                MsgBox("Usted ha ingresado un salon de tipo " + cmbtipo.SelectedItem.ToString)
                                txtlaboratorio.Text = Val(txtlaboratorio.Text) - 1
                                txtnumero.Clear()
                                cmbtipo.SelectedIndex = 0
                                txtcodigo.Clear()
                            End If

                        Case 3
                            If (Val(txttaller.Text = 0)) Then
                                MsgBox("Error de ingreso, No cuenta con mas salones de ese tipo para ingresar")
                            Else
                                sql = "INSERT INTO salon VALUES (" + txtcodigo.Text + ",'"
                                sql += cmbtipo.SelectedItem + "'," + txtnumero.Text + ")"
                                MsgBox("Usted ha ingresado un salon de tipo " + cmbtipo.SelectedItem.ToString)
                                txttaller.Text = Val(txttaller.Text) - 1
                                txtnumero.Clear()
                                cmbtipo.SelectedIndex = 0
                                txtcodigo.Clear()

                            End If

                    End Select
                End If
                
            Case acciones.modificar
                sql = "UPDATE salon SET "
                sql += "cod_salon = " + txtcodigo.Text + ","
                sql += "tipo_salon='" + cmbtipo.SelectedItem + "',"
                sql += "num_salon=" + txtnumero.Text + ""
                sql += " WHERE cod_salon = " + unsalon.cod_salon.ToString + ""
                MsgBox("Salón modificado exitosamente")
            Case acciones.eliminar
                sql = "DELETE FROM salon WHERE cod_salon= " + txtcodigo.Text + ""
                MsgBox("Salón eliminado exitosamente")
        End Select
        cx.ConnectionString = "FileDsn=c:\sibapro.dsn;UID=developer;PWD=developer"
        cx.Open()
        cm.Connection = cx
        cm.CommandText = sql
        cm.ExecuteNonQuery()
        abmSalon.Show()
        Me.Close()




        



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
                login.cmbnomu.SelectedIndex = 0
                login.cmbpass.SelectedIndex = 0

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




