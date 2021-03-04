Public Class imenupse

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        lblhora.Text = DateTime.Now()
    End Sub

    Private Sub Form4_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Timer1.Start()
        lblhora.Text = DateTime.Now()
    End Sub


    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnrrhh.Click
        iabmdoc.Show()
        Me.Hide()

    End Sub


    Private Sub Label4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnrepor.Click
        imenureportse.Show()
        Me.Hide()

    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        login.Show()
        Me.Hide()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btncarr.Click
        iabmcarr.Show()
        Me.Hide()
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btntyh.Click
        iabmturnos.Show()
        Me.Hide()

    End Sub

    Private Sub lblclose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnclose.Click
        Select Case MsgBox("Do you want to close session?", MsgBoxStyle.YesNo)
            Case MsgBoxResult.Yes
                login.txtpw.Clear()
                login.txtuser.Clear()

                login.Show()
                Me.Hide()
            Case MsgBoxResult.No
                Me.Hide()
                Me.Show()
        End Select
    End Sub

    Private Sub btnsalon_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsalon.Click
        iabmsalon.Show()
        Me.Hide()

    End Sub
End Class