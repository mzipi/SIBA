Public Class bajagrupo

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnelim.Click
        If ltvgrupos.SelectedItems.Count = 0 Then
            MsgBox("Primero debe seleccionar un grupo")
        End If

        If ltvgrupos.SelectedItems.Count > 0 Then
            Select Case MsgBox("¿Está seguro de eliminar el grupo seleccionado?", MsgBoxStyle.YesNo)

                Case MsgBoxResult.Yes
                    MsgBox("Grupo eliminado")
                    ltvgrupos.SelectedItems.Clear()

                    abmGrupo.Show()
                    Me.Hide()
                Case MsgBoxResult.No
                    ltvgrupos.SelectedItems.Clear()

                    Me.Hide()
                    Me.Show()
                    MsgBox("Seleccione otro grupo o presione atrás")
            End Select
        End If

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnatras.Click
        ltvgrupos.SelectedItems.Clear()

        abmGrupo.Show()
        Me.Hide()
    End Sub

    Private Sub bajagrupo_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnclose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnclose.Click
        Select Case MsgBox("Desea cerrar sesión?", MsgBoxStyle.YesNo)
            Case MsgBoxResult.Yes
                ltvgrupos.SelectedItems.Clear()
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