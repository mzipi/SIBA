Public Class bajausuario

    Private Sub ltvdocentes_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub btnclose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnclose.Click
        Select Case MsgBox("Desea cerrar sesión?", MsgBoxStyle.YesNo)

            Case MsgBoxResult.Yes
                ltvusuarios.SelectedItems.Clear()
                login.cmbpass.SelectedIndex = 0
                login.cmbnomu.SelectedIndex = 0

                login.Show()
                Me.Hide()
            Case MsgBoxResult.No
                Me.Hide()
                Me.Show()
        End Select
    End Sub

    Private Sub btnelim_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnelim.Click
        If ltvusuarios.SelectedItems.Count = 0 Then
            MsgBox("Primero debe seleccionar un usuario")
        End If
        If ltvusuarios.SelectedItems.Count <> 0 Then
            Select Case MsgBox("¿Está seguro de eliminar el usuario seleccionado?", MsgBoxStyle.YesNo)

                Case MsgBoxResult.Yes
                    MsgBox("Usuario eliminado")
                    ltvusuarios.SelectedItems.Clear()
                    abmusuario.Show()
                    Me.Hide()
                Case MsgBoxResult.No
                    ltvusuarios.SelectedItems.Clear()
                    Me.Hide()
                    Me.Show()
                    MsgBox("Seleccione otro usuario o presione atrás")
            End Select
        End If
    End Sub

    Private Sub btnatras_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnatras.Click
        ltvusuarios.SelectedItems.Clear()
        abmusuario.Show()
        Me.Hide()

    End Sub
End Class