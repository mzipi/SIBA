Public Class imenureportse

    Private Sub btnclose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnclose.Click
        Select Case MsgBox("Do you want to close this session?", MsgBoxStyle.YesNo)
            Case MsgBoxResult.Yes
                login.txtpass.Clear()
                login.txtusuario.Clear()

                login.Show()
                Me.Hide()
            Case MsgBoxResult.No
                Me.Hide()
                Me.Show()
        End Select
    End Sub

    Private Sub imenureportse_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnhorasdoc_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnhorasdoc.Click
        iconshordoc.Show()
        iconshordoc.lbltipou.Text = imenupse.lbltipou.Text

        Me.Hide()
    End Sub

    Private Sub btnplanhoras_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub btnmatcar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnmatcar.Click
        iconsultademateria.Show()
    End Sub

    Private Sub btnhorvac_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnhorvac.Click
        iReporte3.Show()
    End Sub

    Private Sub btngrupsindoc_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btngrupsindoc.Click
        iReporte1.Show()

    End Sub

    Private Sub btnatras_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnatras.Click
        imenupse.Show()
        Me.Close()
    End Sub
End Class