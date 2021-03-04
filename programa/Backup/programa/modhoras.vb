Public Class modhoras

    Private Sub Label7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label7.Click

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnatras.Click

        abmhoras.Show()
        txtcodhora.Text = "005"
        txtcodturno.Text = "3"
        txtnumero.Text = "4"
        cmbdia.SelectedIndex = 3
        txthoraini.Text = "15:35"
        txthorafin.Text = "16:15"


        Me.Hide()

    End Sub

    Private Sub btnclose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnclose.Click
        Select Case MsgBox("Desea cerrar sesión?", MsgBoxStyle.YesNo)
            Case MsgBoxResult.Yes

                txtcodhora.Text = "005"
                txtcodturno.Text = "3"
                txtnumero.Text = "4"
                cmbdia.SelectedIndex = 3
                txthoraini.Text = "15:35"
                txthorafin.Text = "16:15"

                login.cmbpass.SelectedIndex = 0
                login.cmbnomu.SelectedIndex = 0

                login.Show()
                Me.Hide()
            Case MsgBoxResult.No
                Me.Hide()
                Me.Show()
        End Select
    End Sub

    Private Sub txtcodhora_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtcodhora.KeyPress
        If (e.KeyChar < "0" Or e.KeyChar > "9") And e.KeyChar <> Chr(Keys.Back) Then
            e.KeyChar = ""
        End If
    End Sub

    Private Sub txtcodhora_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtcodhora.TextChanged

    End Sub

    Private Sub txtcodturno_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtcodturno.KeyPress
        If (e.KeyChar < "0" Or e.KeyChar > "9") And e.KeyChar <> Chr(Keys.Back) Then
            e.KeyChar = ""
        End If
    End Sub

    Private Sub txtcodturno_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtcodturno.TextChanged

    End Sub

    Private Sub txtnumero_DragOver(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles txtnumero.DragOver

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

    Private Sub txthoraini_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txthoraini.KeyPress
        If (e.KeyChar < "0" Or e.KeyChar > "9") And e.KeyChar <> Chr(Keys.Back) Then
            e.KeyChar = ""
        End If
    End Sub

    Private Sub txthoraini_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles txthoraini.MouseClick

    End Sub

    Private Sub txthoraini_Move(ByVal sender As Object, ByVal e As System.EventArgs) Handles txthoraini.Move

    End Sub

    Private Sub txthoraini_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txthoraini.TextChanged

    End Sub

    Private Sub txthorafin_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txthorafin.KeyPress
        If (e.KeyChar < "0" Or e.KeyChar > "9") And e.KeyChar <> Chr(Keys.Back) Then
            e.KeyChar = ""
        End If
    End Sub

    Private Sub txthorafin_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txthorafin.TextChanged

    End Sub

    Private Sub btnmod_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnmod.Click
        If (txtcodhora.Text = "") Then
            MsgBox("Debe ingresar un código de hora")
        End If
        If (txtcodturno.Text = "") Then
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
        If (txthorafin.Text <> "" And txthoraini.Text <> "" And cmbdia.SelectedIndex <> 0 And txtnumero.Text <> "" And txtcodturno.Text <> "" And txtcodhora.Text <> "") Then
            MsgBox("Hora modificada")

            abmhoras.Show()
            Me.Hide()

        End If
    End Sub
End Class