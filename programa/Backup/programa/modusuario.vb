Public Class modusuario

    Private Sub btnatras_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnatras.Click
        abmusuario.Show()
        Me.Hide()
        txtnombre.Clear()
        txtci.Clear()
        cmbperfil.SelectedIndex = 0
        txtnomusua.Clear()
        txtpass.Clear()
        txtreppass.Clear()
        txtemail.Clear()
    End Sub

    Private Sub btnclose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnclose.Click
        Select Case MsgBox("Desea cerrar sesión?", MsgBoxStyle.YesNo)
            Case MsgBoxResult.Yes
                txtnombre.Clear()
                txtci.Clear()
                cmbperfil.SelectedIndex = 0
                txtnomusua.Clear()
                txtpass.Clear()
                txtreppass.Clear()
                txtemail.Clear()
                login.cmbpass.SelectedIndex = 0
                login.cmbnomu.SelectedIndex = 0

                login.Show()
                Me.Hide()
            Case MsgBoxResult.No
                Me.Hide()
                Me.Show()
        End Select
    End Sub

    Private Sub btnmod_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnmod.Click
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
        If (txtreppass.Text = "") Then
            MsgBox("Debe repetir la contraseña para el usuario")

        End If
        If (txtpass.Text <> txtreppass.Text) Then
            MsgBox("No coinciden las contraseñas ingresadas")

        End If
        If (txtnombre.Text <> "" And txtci.Text <> "" And cmbperfil.SelectedIndex <> 0 And txtnomusua.Text <> "" And txtpass.Text <> "" And txtreppass.Text <> "" And txtpass.Text = txtreppass.Text) Then
            MsgBox("Usuario modificado")

            txtnombre.Clear()
            txtci.Clear()
            cmbperfil.SelectedIndex = 0
            txtnomusua.Clear()
            txtpass.Clear()
            txtreppass.Clear()
            txtemail.Clear()

        End If
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

    Private Sub txtci_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtci.KeyPress
        If (e.KeyChar < "0" Or e.KeyChar > "9") And e.KeyChar <> Chr(Keys.Back) Then
            e.KeyChar = ""
        End If
    End Sub

    Private Sub txtci_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtci.TextChanged

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

    Private Sub cmbperfil_ParentChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbperfil.ParentChanged

    End Sub

    Private Sub cmbperfil_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbperfil.SelectedIndexChanged

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
End Class