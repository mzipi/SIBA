Public Class repDoc

    Private Sub Form7_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Label4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblcoddoc.Click

    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnatras.Click
        conshordoc.cmbturno.SelectedIndex = 0
        conshordoc.Show()

        Me.Hide()

    End Sub

    Private Sub Label6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblidturno.Click

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnclose.Click
        Select Case MsgBox("Desea cerrar sesión?", MsgBoxStyle.YesNo)
            Case MsgBoxResult.Yes
                conshordoc.cmbturno.SelectedIndex = 0
                login.cmbpass.SelectedIndex = 0
                login.cmbnomu.SelectedIndex = 0

                login.Show()
                Me.Hide()
            Case MsgBoxResult.No
                Me.Hide()
                Me.Show()
        End Select
    End Sub

    Private Sub btnprint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnprint.Click
        MsgBox("Preparando archivo para imprimir")
        If (lbltipou.Text = "Docente") Then
            conshordoc.cmbturno.SelectedIndex = 0
            menupdoc.Show()
            Me.Hide()

        End If

        If (lbltipou.Text = "Secretario Escolar") Then
            conshordoc.cmbturno.SelectedIndex = 0
            menureportse.Show()
            Me.Hide()

        End If

    End Sub
End Class