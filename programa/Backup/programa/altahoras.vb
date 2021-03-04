Public Class altahoras

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        If (cmbturno.SelectedIndex = 0) Then
            MsgBox("Debe seleccionar un turno")

        End If

        If (cmbturno.SelectedIndex > 0) Then
            txtnomturno.Text = cmbturno.SelectedItem
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

        Select Case accion

            Case acciones.ingresar
                gbxselturno.Visible = True
                gbxhoras.Visible = False
                btnaceptar.Text = "Ingresar"
                lbltitulo.Text = "INGRESO DE HORA"
                txtnomturno.ReadOnly = True


            Case acciones.modificar
                btnaceptar.Visible = True
                btnatras.Visible = True
                gbxselturno.Visible = False
                gbxhoras.Visible = True
                gbxhoras.SetBounds(15, 47, 271, 255)
                txtnomturno.ReadOnly = False
                btnaceptar.Text = "Modificar"
                lbltitulo.Text = "MODIFICACIÓN DE HORA"

                With asighora
                    cmbturno.SelectedItem = .id_turno
                    txtcodhora.Text = .id_horas


                End With

                With unahora
                    txtcodhora.Text = .id_horas
                    txtnumero.Text = .num_horas
                    cmbdia.SelectedItem = .dia
                    txthoraini.Text = .inicio
                    txthorafin.Text = .fin

                End With
            Case acciones.eliminar
                gbxselturno.Visible = False
                gbxhoras.Visible = True
                gbxhoras.SetBounds(15, 47, 271, 255)
                btnaceptar.Visible = True
                btnatras.Visible = True
                btnaceptar.Text = "Eliminar"
                lbltitulo.Text = "BAJA DE HORA"

                With asighora
                    cmbturno.SelectedItem = .id_turno
                    txtcodhora.Text = .id_horas


                End With

                With unahora
                    txtcodhora.Text = .id_horas
                    txtnumero.Text = .num_horas
                    cmbdia.SelectedItem = .dia
                    txthoraini.Text = .inicio
                    txthorafin.Text = .fin

                End With

        End Select

        
    End Sub

    Private Sub gbxdoc_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles gbxhoras.Enter

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnatras.Click
        Select Case accion
            Case acciones.ingresar
                abmhoras.Show()
                Me.Close()
            Case acciones.modificar
                abmhoras.Show()
                Me.Close()
            Case acciones.eliminar
                abmhoras.Show()
                Me.Close()

        End Select

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
                txtnomturno.Clear()
                txtcodhora.Clear()
                login.cmbnomu.SelectedIndex = 0
                login.cmbpass.SelectedIndex = 0
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
        If (txtnomturno.Text = "") Then
            MsgBox("Debe ingresar un código de turno")
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
        If (txthorafin.Text <> "" And txthoraini.Text <> "" And cmbdia.SelectedIndex <> 0 And txtnumero.Text <> "" And txtnomturno.Text <> "" And txtcodhora.Text <> "") Then

            Dim sql As String = ""
            Dim cx As New Odbc.OdbcConnection
            Dim cm As New Odbc.OdbcCommand


            Select Case accion
                Case acciones.ingresar
                    sql = "INSERT INTO horas VALUES (" + txtcodhora.Text + ","
                    sql += txtnumero.Text + ",'" + cmbdia.SelectedItem + " ','"
                    sql += txthoraini.Text + "','" + txthorafin.Text + "')"

                    MsgBox("Hora exitosamente")
                Case acciones.modificar
                    sql = "UPDATE horas SET "
                    sql += "id_horas = " + txtcodhora.Text + ","
                    sql += "num_horas=" + txtnumero.Text + ","
                    sql += "dia='" + cmbdia.SelectedItem + "',"
                    sql += "inicio='" + txthoraini.Text + "',"
                    sql += "fin='" + txthorafin.Text + "'"
                    sql += " WHERE id_horas = " + unahora.id_horas.ToString
                    MsgBox("Hora  modificada exitosamente")
                Case acciones.eliminar
                    sql = "DELETE FROM horas WHERE id_horas= " + txtcodhora.Text
                    MsgBox("Hora eliminada exitosamente")
            End Select
            cx.ConnectionString = "FileDsn=c:\sibapro.dsn;UID=developer;PWD=developer"
            cx.Open()
            cm.Connection = cx
            cm.CommandText = Sql
            cm.ExecuteNonQuery()
            abmcarreras.Show()
            Me.Close()





            MsgBox("Hora ingresada")
            btnatras.Visible = False
            btnaceptar.Visible = False

            Label10.Visible = True
            Label14.Visible = True
            cmbturno.Visible = True
            Button4.Visible = True
            cmbturno.SelectedIndex = 0
            gbxhoras.Visible = False
            txthorafin.Clear()
            txthoraini.Clear()
            cmbdia.SelectedIndex = 0
            txtnumero.Clear()
            txtnomturno.Clear()
            txtcodhora.Clear()
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

    Private Sub txtcodturno_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtnomturno.KeyPress
        If (e.KeyChar < "0" Or e.KeyChar > "9") And e.KeyChar <> Chr(Keys.Back) Then
            e.KeyChar = ""
        End If
    End Sub

    Private Sub txtcodturno_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtnomturno.TextChanged

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
End Class