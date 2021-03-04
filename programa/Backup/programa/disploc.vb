Public Class disploc



    Private Sub Form50_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Timer1.Start()
        lblhora.Text = DateTime.Now()
    End Sub

    Private Sub RadioButton1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbndefinir.CheckedChanged
        disponibil.Show()
        rbndefinir.Checked = False

        Me.Hide()

    End Sub

    Private Sub lblhora_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblhora.Click

    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick

        lblhora.Text = DateTime.Now()
    End Sub

    Private Sub lblclose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblclose.Click
        Select Case MsgBox("Desea cerrar sesión?", MsgBoxStyle.YesNo)
            Case MsgBoxResult.Yes
                login.Show()
                Me.Hide()
            Case MsgBoxResult.No
                Me.Hide()
                Me.Show()
        End Select
    End Sub

    Private Sub lbltipou_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lbltipou.Click

    End Sub

    Private Sub Label2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label2.Click

    End Sub

    Private Sub lblrol_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblrol.Click

    End Sub

    Private Sub lblnombreu_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblnombreu.Click

    End Sub

    Private Sub rbnmodificar_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbnmodificar.CheckedChanged
        abmSalon.Show()
        Me.Hide()
        rbnmodificar.Checked = False


    End Sub
End Class