Public Class abmusuario

    Private Sub lbltipou_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lbltipou.Click

    End Sub

    Private Sub btnclose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnclose.Click
        Select Case MsgBox("Desea cerrar sesión?", MsgBoxStyle.YesNo)
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

    Private Sub btnalta_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnalta.Click
        altausuario.Show()
        Me.Hide()

    End Sub

    Private Sub btnmod_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnmod.Click

        MsgBox("Para modificar realice doble click sobre el usuario en la tabla")


    End Sub

    Private Sub btnbaja_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnbaja.Click
        bajausuario.Show()
        Me.Hide()

    End Sub

    Private Sub ltvusuarios_ItemSelectionChanged(ByVal sender As Object, ByVal e As System.Windows.Forms.ListViewItemSelectionChangedEventArgs)
        itmLV = e.ItemIndex
    End Sub
    Dim itmLV As Integer

    Private Sub ltvusuarios_MouseDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs)
        Debug.WriteLine(itmLV.ToString & " " & ltvusuarios.Items(itmLV).Text)
        Select Case itmLV
            Case 0
                modusuario.txtnombre.Text = ltvusuarios.Items(itmLV).Text
                modusuario.txtci.Text = 2222222
                modusuario.cmbperfil.SelectedIndex = 1
                modusuario.Show()
                Me.Hide()
            Case 1
                modusuario.txtnombre.Text = ltvusuarios.Items(itmLV).Text
                modusuario.txtci.Text = 1234566
                modusuario.cmbperfil.SelectedIndex = 4
                modusuario.Show()
                Me.Hide()

        End Select
    End Sub
    Private Sub ltvusuarios_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub btnatras_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnatras.Click
        menurepei.Show()
        Me.Hide()
    End Sub
End Class