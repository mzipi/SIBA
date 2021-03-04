Public Class modhrsvac

    Private Sub btnmod_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnmod.Click
        If (txtnombredoc.Text = "") Then
            MsgBox("Debe ingresar un mobre de docente")

        End If
        If (txtci.Text = "") Then
            MsgBox("Debe ingresar la cédula del docente")

        End If

        If (cmbestfunc.SelectedIndex = 0) Then
            MsgBox("Debe seleccionar el estado funcional")

        End If
        If (dtpdesde.Value > dtphasta.Value And dtpdesde.Text <> dtphasta.Text) Then
            MsgBox("Ha seleccionado una fecha hasta menor a la fecha desde")
        End If

        If (dtpdesde.Text = dtphasta.Text) Then
            Select Case MsgBox("Las fechas ingresadas son iguales. Desea continuar?", MsgBoxStyle.YesNo)
                Case MsgBoxResult.Yes
                    MsgBox("Se generará la vacante por un día")
                Case MsgBoxResult.No
                    MsgBox("Seleccione otra fecha")

            End Select
        End If

        If (txtnombredoc.Text <> "" And txtci.Text <> "" And cmbestfunc.SelectedIndex <> 0 And dtpdesde.Value <= dtphasta.Value) Then
            MsgBox("Horas vacantes modificadas exitosamente")
            abmhrsvacantes.ltvhrsvac.SelectedItems.Clear()
            txtnombredoc.Clear()
            txtci.Clear()
            cmbestfunc.SelectedIndex = 0
            dtpdesde.ResetText()
            dtphasta.ResetText()
            abmhrsvacantes.Show()
            Me.Hide()


        End If
    End Sub

    Private Sub btnatras_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnatras.Click
        abmhrsvacantes.ltvhrsvac.SelectedItems.Clear()
        txtnombredoc.Clear()
        txtci.Clear()
        cmbestfunc.SelectedIndex = 0
        dtpdesde.ResetText()
        dtphasta.ResetText()
        abmhrsvacantes.Show()
        Me.Hide()
    End Sub

    Private Sub btnclose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnclose.Click
        Select Case MsgBox("Desea cerrar sesión?", MsgBoxStyle.YesNo)
            Case MsgBoxResult.Yes
                abmhrsvacantes.ltvhrsvac.SelectedItems.Clear()
                txtnombredoc.Clear()
                txtci.Clear()
                cmbestfunc.SelectedIndex = 0
                dtpdesde.ResetText()
                dtphasta.ResetText()
                login.cmbpass.SelectedIndex = 0
                login.cmbnomu.SelectedIndex = 0
                login.Show()
                Me.Hide()
            Case MsgBoxResult.No
                Me.Hide()
                Me.Show()
        End Select
    End Sub

    Private Sub txtnombredoc_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtnombredoc.KeyPress
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

    Private Sub txtnombredoc_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtnombredoc.TextChanged

    End Sub

    Private Sub txtci_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtci.KeyPress
        If (e.KeyChar < "0" Or e.KeyChar > "9") And e.KeyChar <> Chr(Keys.Back) Then
            e.KeyChar = ""
        End If
    End Sub

    Private Sub txtci_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtci.TextChanged

    End Sub

    Private Sub dtpdesde_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles dtpdesde.KeyPress
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

    Private Sub dtpdesde_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtpdesde.ValueChanged

    End Sub

    Private Sub dtphasta_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles dtphasta.KeyPress
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

    Private Sub dtphasta_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtphasta.ValueChanged

    End Sub

    Private Sub cmbestfunc_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cmbestfunc.KeyPress
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

    Private Sub cmbestfunc_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbestfunc.SelectedIndexChanged

    End Sub

    Private Sub modhrsvac_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class