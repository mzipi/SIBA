Public Class bajamat

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnatras.Click
        abmMateria.Show()
        Me.Hide()

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnelim.Click
        If ltvmat.SelectedItems.Count = 0 Then
            MsgBox("Primero debe seleccionar una materia")
        End If
        If ltvmat.SelectedItems.Count <> 0 Then
            Select Case MsgBox("¿Está seguro de eliminar la materia seleccionada?", MsgBoxStyle.YesNo)

                Case MsgBoxResult.Yes

                    MsgBox("Materia eliminada")

                    ltvmat.SelectedItems.Clear()
                    abmMateria.Show()
                    Me.Hide()
                Case MsgBoxResult.No
                    ltvmat.SelectedItems.Clear()

                    Me.Hide()
                    Me.Show()
                    MsgBox("Seleccione otra materia o presione atrás")
            End Select
        End If
    End Sub

    Private Sub Form32_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnclose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnclose.Click
        Select Case MsgBox("Desea cerrar sesión?", MsgBoxStyle.YesNo)
            Case MsgBoxResult.Yes
                ltvmat.SelectedItems.Clear()
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