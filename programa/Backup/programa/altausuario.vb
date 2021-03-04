Public Class altausuario

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

    Private Sub txtnomusua_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtnomusua.TextChanged

    End Sub

    Private Sub btnclose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnclose.Click
        Select Case MsgBox("Desea cerrar sesi�n?", MsgBoxStyle.YesNo)
            Case MsgBoxResult.Yes
                login.cmbnomu.SelectedIndex = 0
                login.cmbpass.SelectedIndex = 0

                login.Show()
                Me.Hide()
            Case MsgBoxResult.No
                Me.Hide()
                Me.Show()
        End Select
    End Sub

    Private Sub btning_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btning.Click
        If (txtnombre.Text = "") Then
            MsgBox("Debe ingresar el nombre y apellido del usuario")
        End If
        If (txtci.Text = "") Then
            MsgBox("Debe ingresar la c�dula de identidad del usuario")
        End If
        If (cmbperfil.SelectedIndex = 0) Then
            MsgBox("Debe seleccionar un perfil para el usuario")
        End If
        If (txtnomusua.Text = "") Then
            MsgBox("Debe ingresar un nombre de usuario")
        End If

        If (txtpass.Text = "") Then
            MsgBox("Debe ingresar una contrase�a para el usuario")

        End If
        If (txtreppass.Text = "") Then
            MsgBox("Debe repetir la contrase�a para el usuario")

        End If
        If (txtpass.Text <> txtreppass.Text) Then
            MsgBox("No coinciden las contrase�as ingresadas")

        End If
        If (txtnombre.Text <> "" And txtci.Text <> "" And cmbperfil.SelectedIndex <> 0 And txtnomusua.Text <> "" And txtpass.Text <> "" And txtreppass.Text <> "" And txtpass.Text = txtreppass.Text) Then
            MsgBox("Usuario ingresado con perfil " + cmbperfil.SelectedItem)

            txtnombre.Clear()
            txtci.Clear()
            cmbperfil.SelectedIndex = 0
            txtnomusua.Clear()
            txtpass.Clear()
            txtreppass.Clear()
            txtemail.Clear()

        End If
    End Sub

    Private Sub btncancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btncancel.Click
        txtnombre.Clear()
        txtci.Clear()
        cmbperfil.SelectedIndex = 0
        txtnomusua.Clear()
        txtpass.Clear()
        txtreppass.Clear()
        txtemail.clear()

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
        Me.Hide()
    End Sub

    Private Sub altausuario_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        cmbperfil.SelectedIndex = 0
    End Sub

    Private Sub txtemail_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtemail.KeyPress
        txtemail.Text.Contains("@")

    End Sub

    Private Sub txtemail_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles txtemail.MouseUp

    End Sub

    Private Sub txtemail_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtemail.TextChanged

    End Sub

End Class
