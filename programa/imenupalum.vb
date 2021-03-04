Public Class imenupalum

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

    Private Sub menupalum_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnusuarios_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnusuarios.Click
        iReporte3.Show()

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        iconsultademateria.Show()


    End Sub
End Class