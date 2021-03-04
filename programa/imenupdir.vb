Public Class imenupdir

    Private Sub btnusuarios_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        planilladodir.Show()
        Me.Hide()

    End Sub

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

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        ihorasturdir.Show()
        Me.Hide()

    End Sub


    Private Sub imenupdir_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class