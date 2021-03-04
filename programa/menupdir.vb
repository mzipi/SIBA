Public Class menupdir

    Private Sub btnusuarios_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        planilladodir.Show()
        Me.Hide()

    End Sub

    Private Sub btnclose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnclose.Click
        Select Case MsgBox("Desea cerrar sesión?", MsgBoxStyle.YesNo)
            Case MsgBoxResult.Yes
                login.txtpass.clear()
                login.txtusuario.clear()

                login.Show()
                Me.Hide()
            Case MsgBoxResult.No
                Me.Hide()
                Me.Show()
        End Select
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        horasturdir.Show()
        Me.Hide()

    End Sub

    Private Sub menupdir_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class