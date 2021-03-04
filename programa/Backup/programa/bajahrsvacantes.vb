Public Class bajahrsvacantes

    Private Sub lbltipou_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lbltipou.Click

    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnclose.Click
        Select Case MsgBox("Desea cerrar sesión?", MsgBoxStyle.YesNo)
            Case MsgBoxResult.Yes
                ltvhrsvac.SelectedItems.Clear()
                login.cmbpass.SelectedIndex = 0
                login.cmbnomu.SelectedIndex = 0

                login.Show()
                Me.Hide()
            Case MsgBoxResult.No
                ltvhrsvac.SelectedItems.Clear()
                Me.Hide()
                Me.Show()
        End Select
    End Sub

    Private Sub btnelim_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnelim.Click
        If (ltvhrsvac.SelectedItems.Count = 0) Then
            MsgBox("Debe seleccionar una hora vacante para eliminar")

        End If
        If (ltvhrsvac.SelectedItems.Count > 0) Then
            Select Case MsgBox("¿Está seguro de eliminar la hora vacante seleccionada?", MsgBoxStyle.YesNo)

                Case MsgBoxResult.Yes
                    MsgBox("Hora vacante eliminada")
                    ltvhrsvac.SelectedItems.Clear()

                    abmhrsvacantes.Show()
                    Me.Hide()
                Case MsgBoxResult.No
                    ltvhrsvac.SelectedItems.Clear()

                    Me.Show()
                    MsgBox("Seleccione otra hora vacante o presione atrás")
            End Select

        End If
        

    End Sub

    Private Sub btnatras_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnatras.Click
        abmhrsvacantes.Show()
        Me.Hide()

        ltvhrsvac.SelectedItems.Clear()
    End Sub
End Class