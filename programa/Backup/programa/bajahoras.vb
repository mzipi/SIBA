Public Class bajahoras

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnelim.Click
        If (ltvhoras.SelectedItems.Count = 0) Then
            MsgBox("Debe seleccionar una hora para eliminar")


        End If
        If (ltvhoras.SelectedItems.Count > 0) Then
            MsgBox("La hora seleccionada fue eliminada")
            ltvhoras.SelectedItems.Clear()
            abmhoras.Show()
            Me.Hide()


        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnatras.Click
        ltvhoras.SelectedItems.Clear()
        abmhoras.Show()
        Me.Hide()
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        Select Case MsgBox("Desea cerrar sesión?", MsgBoxStyle.YesNo)
            Case MsgBoxResult.Yes
                ltvhoras.SelectedItems.Clear()
                login.cmbpass.SelectedIndex = 0
                login.cmbnomu.SelectedIndex = 0
                login.Show()
                Me.Hide()
            Case MsgBoxResult.No
                Me.Hide()
                Me.Show()
        End Select
    End Sub

    Private Sub bajahoras_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class