Public Class rephorasvac

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        lblfecha.Text = DateTime.Now()

    End Sub

    Private Sub Form48_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        lblfecha.Text = DateTime.Now()
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnatras.Click
        horasvacantes.Show()
        Me.Hide()

    End Sub

    Private Sub Form48_QueryContinueDrag(ByVal sender As Object, ByVal e As System.Windows.Forms.QueryContinueDragEventArgs) Handles Me.QueryContinueDrag

    End Sub

    Private Sub Label6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lbltipou.Click

    End Sub

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

    Private Sub btnenvrep_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        MsgBox("Reporte enviado a la secretaria escolar")
        menureportse.Show()
        Me.Hide()

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnmenu.Click
        menureportse.Show()
        Me.Hide()

    End Sub
End Class