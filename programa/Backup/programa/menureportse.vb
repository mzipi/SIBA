Public Class menureportse

    Private Sub btnclose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnclose.Click
        Select Case MsgBox("Desea cerrar sesión?", MsgBoxStyle.YesNo)
            Case MsgBoxResult.Yes
                login.cmbpass.SelectedIndex = 0
                login.cmbnomu.SelectedIndex = 0

                login.Show()
                Me.Hide()
            Case MsgBoxResult.No
                Me.Hide()
                Me.Show()
        End Select
    End Sub

    Private Sub menureportse_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnhorasdoc_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnhorasdoc.Click
        conshordoc.Show()
        Me.Hide()
    End Sub

    Private Sub btnplanhoras_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnplanhoras.Click
        consplanalum.btnatras.Visible = False

        consplanalum.Show()
        Me.Hide()

    End Sub

    Private Sub btnmatcar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnmatcar.Click
        consmatxcar.Show()
        Me.Hide()

    End Sub

    Private Sub btnhorvac_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnhorvac.Click
        horasvacantes.Show()
        Me.Hide()
    End Sub

    Private Sub btngrupsindoc_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btngrupsindoc.Click
        sinDoc.Show()
        Me.Hide()
    End Sub

    Private Sub btnatras_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnatras.Click
        menupse.Show()
        Me.Hide()

    End Sub
End Class