Public Class repgrupsindoc

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        lblfecha.Text = DateTime.Now()

    End Sub

    Private Sub Form47_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        lblfecha.Text = DateTime.Now()
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnatras.Click
        sinDoc.Show()
        Me.Hide()

    End Sub

    Private Sub btnmenu_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnmenu.Click
        If (lbltipou.Text = "Administrativo") Then

            menupadm.Show()
            Me.Hide()
        End If
        If (lbltipou.Text = "Secretario Escolar") Then
            menureportse.Show()
            Me.Hide()
        End If


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

    Private Sub btnprint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnprint.Click
        MsgBox("Preparando documento para impresión")
        If (lbltipou.Text = "Administrativo") Then
            menupadm.Show()
            Me.Hide()

        End If
        If (lbltipou.Text = "Secretario Escolar") Then
            menureportse.Show()
            Me.Hide()

        End If

    End Sub
End Class