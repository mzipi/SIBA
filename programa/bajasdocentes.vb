Public Class bajasdocentes
    Dim control As Integer


    Private Sub txtnombredoc_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
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

    Private Sub txtnombredoc_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub txtci_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If (e.KeyChar < "0" Or e.KeyChar > "9") And e.KeyChar <> Chr(Keys.Back) Then
            e.KeyChar = ""
        End If
    End Sub

    Private Sub txtci_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub dtpdesde_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
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

    Private Sub dtpdesde_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs)

    End Sub

    Private Sub dtpdesde_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub DateTimePicker1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
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


    Private Sub cmbestfunc_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
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

    Private Sub cmbestfunc_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

        If (cmbmotivo.SelectedIndex = 2) Then

            Select Case MsgBox("Renuncia a todas las horas asignadas al docente ?", MsgBoxStyle.YesNo)
                Case MsgBoxResult.Yes

                    MsgBox("Seleccione la fecha en la que se efectuará la renuncia")

                    control = 1
                Case MsgBoxResult.No
                    control = 2
                    MsgBox("A continuación seleccione el grupo al cual renunciará el docente ?")

            End Select


        End If

    End Sub

    Private Sub altahrsvacantes_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        txtnombre.Enabled = False
        With bajadoc
            txtci.Text = .ci
            txtnombre.Text = .nombre_docente
            txtest_fun.Text = .estado_funcional
            txtgrupo.Text = .grupo
            txtmat.Text = .nombre_mat

            txtcod_mat.Text = .cod_materia
            txtidg.Text = .idg

        End With



    End Sub

    Private Sub btning_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btning.Click

        If (cmbmotivo.SelectedIndex = 1 Or cmbmotivo.SelectedIndex <> 0) Then
            Dim sql As String = ""
            Dim cx As New Odbc.OdbcConnection
            Dim cm As New Odbc.OdbcCommand

            Select Case MsgBox("Se eliminarán todos los grupos que tiene asignados el docente ?", MsgBoxStyle.YesNo)
                Case MsgBoxResult.Yes
                    sql = "DELETE FROM asignados where ci= '" + txtci.Text + "'"

                    cx.ConnectionString = "FileDSN=c:\itechplus_sec.dsn;UID=techplus_sec;pwd=1234"
                    cx.Open()
                    cm.Connection = cx
                    cm.CommandText = sql
                    cm.ExecuteNonQuery()
                    MsgBox("Asignacíones eliminadas")
                    cx.Close()
                    abmbajasdoc.Show()
                    Me.Close()

                Case MsgBoxResult.No
                    abmbajasdoc.Show()
                    Me.Close()
            End Select
        End If


        'ingresa en  la tabla bajas y al mismo tiempo elimina de la tabla asignados
        If (cmbmotivo.SelectedIndex = 2 And control = 2 And dtpdesde.Value.ToString <> "" And txtcod_mat.Text <> "" And txtci.Text <> "" And txtidg.Text <> "") Then

            Dim sql As String = ""
            Dim cx4 As New Odbc.OdbcConnection
            Dim cm4 As New Odbc.OdbcCommand


            sql = "update asignados set  (ci, idg,cod_materia,vac_desde, estado_funcional) VALUES (" + txtci.Text + ","
            sql += txtidg.Text + ",'"
            sql += txtcod_mat.Text + "','"
            sql += dtpdesde.Value.ToString(" MM/dd/yyyy") + "','"
            sql += cmbmotivo.SelectedItem + "')"

            cx4.ConnectionString = "FileDSN=c:\itechplus_adm.dsn;UID=techplus_adm;pwd=1234"
            cx4.Open()
            cm4.Connection = cx4
            cm4.CommandText = sql
            cm4.ExecuteNonQuery()
            MsgBox("Vacante ingresada exitosamente")

            cx4.Close()


            Dim sql5 As String = ""
            Dim cx5 As New Odbc.OdbcConnection
            Dim cm5 As New Odbc.OdbcCommand
            sql5 = "DELETE FROM asignados where ci = " + txtci.Text + " and idg=" + txtidg.Text + " and cod_materia= '" + txtcod_mat.Text + "'"
            cx5.ConnectionString = "FileDSN=c:\itechplus_adm.dsn;UID=techplus_adm;pwd=1234"
            cx5.Open()
            cm5.Connection = cx5
            cm5.CommandText = sql5
            cm5.ExecuteNonQuery()
            cx5.Close()


            abmbajasdoc.Show()
            Me.Close()

        End If

    End Sub

    Private Sub btncancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btncancel.Click
        dtpdesde.ResetText()

    End Sub

    Private Sub btnclose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnclose.Click
        Select Case MsgBox("Desea cerrar sesión?", MsgBoxStyle.YesNo)

            Case MsgBoxResult.Yes
                dtpdesde.ResetText()
                dtpdesde.ResetText()

                login.txtusuario.clear()
                login.txtpass.clear()
                login.Show()
                Me.Close()
            Case MsgBoxResult.No
                dtpdesde.ResetText()


                Me.Hide()
                Me.Show()
        End Select

    End Sub

    Private Sub btnfin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnfin.Click
        dtpdesde.ResetText()
        abmbajasdoc.Show()
        Me.Close()

    End Sub


    Private Sub gbxhrsvac_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles gbxhrsvac.Enter

    End Sub

    Private Sub cmbmatgrupo_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub TextBox4_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtmat.TextChanged

    End Sub
End Class