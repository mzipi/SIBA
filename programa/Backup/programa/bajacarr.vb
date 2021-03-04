Public Class bajaCarrera

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnelim.Click
        If (ltvcarr.SelectedItems.Count = 0) Then
            MsgBox("Debe seleccionar una carrera")
        End If
        If (ltvcarr.SelectedItems.Count > 0) Then

            Select Case MsgBox("¿Está seguro de eliminar la carrera seleccionada?", MsgBoxStyle.YesNo)

                Case MsgBoxResult.Yes
                    MsgBox("Carrera eliminada")
                    abmcarreras.Show()
                    ltvcarr.SelectedItems.Clear()
                    Me.Hide()
                Case MsgBoxResult.No
                    ltvcarr.SelectedItems.Clear()

                    Me.Hide()
                    Me.Show()
                    MsgBox("Seleccione otra carrera o presione atrás")
            End Select

        End If


        
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnatras.Click
        ltvcarr.SelectedItems.Clear()
        abmcarreras.Show()
        Me.Hide()
    End Sub

    Private Sub btnclose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnclose.Click
        Select Case MsgBox("Desea cerrar sesión?", MsgBoxStyle.YesNo)
            Case MsgBoxResult.Yes
                ltvcarr.SelectedItems.Clear()
                login.cmbnomu.SelectedIndex = 0
                login.cmbpass.SelectedIndex = 0
                login.Show()
                Me.Hide()
            Case MsgBoxResult.No
                Me.Hide()
                Me.Show()
        End Select
    End Sub
End Class