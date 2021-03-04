Public Class bajaturno

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnelim.Click
        If ltvturno.SelectedItems.Count = 0 Then
            MsgBox("Primero debe seleccionar un turno")
        End If
        If ltvturno.SelectedItems.Count <> 0 Then
            Select Case MsgBox("¿Está seguro de eliminar el turno seleccionado?", MsgBoxStyle.YesNo)

                Case MsgBoxResult.Yes
                    ltvturno.SelectedItems.Clear()
                    MsgBox("Turno eliminado")
                    abmturnos.Show()
                    Me.Hide()
                Case MsgBoxResult.No

                    Me.Hide()
                    Me.Show()
                    MsgBox("Seleccione otro turno o presione atrás")
            End Select
        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt.Click
        
    End Sub

    Private Sub btnclose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnclose.Click
        Select Case MsgBox("Desea cerrar sesión?", MsgBoxStyle.YesNo)
            Case MsgBoxResult.Yes
                ltvturno.SelectedItems.Clear()
                login.cmbpass.SelectedIndex = 0
                login.cmbnomu.SelectedIndex = 0
                login.Show()
                Me.Hide()
            Case MsgBoxResult.No
                Me.Hide()
                Me.Show()
        End Select
    End Sub
End Class