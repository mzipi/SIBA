Public Class imenupadm

    Private Sub btnclose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnclose.Click
        Select Case MsgBox("Do you want to close session?", MsgBoxStyle.YesNo)
            Case MsgBoxResult.Yes
                login.txtpw.Clear()
                login.txtuser.Clear()

                login.Show()
                Me.Close()
            Case MsgBoxResult.No
                Me.Hide()
                Me.Show()
        End Select

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        iReporte1.Show()


    End Sub

   
    Private Sub imenupadm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class