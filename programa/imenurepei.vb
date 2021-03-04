Public Class imenurepei
    Private Sub btnusuarios_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnusuarios.Click
        iabmusuarios.Show()
        Me.Hide()
    End Sub

    Private Sub btnclose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnclose.Click
        Select Case MsgBox("Do you want close this session?", MsgBoxStyle.YesNo)
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

    Private Sub imenurepei_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class