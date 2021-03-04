Public Class horasvacantes

    Private Sub ListView1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnatras.Click
        cmbcar.SelectedIndex = 0
        cmbdia.SelectedIndex = 0
        cmbturno.SelectedIndex = 0
        pbxhorasvacantes.Visible = False
        gbxsel.Visible = True
        btngenrep.Visible = False
        btnatras.Visible = False
        btnprint.Visible = False
        menureportse.Show()
        Me.Hide()

    End Sub

    Private Sub horasvacantes_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        cmbcar.SelectedIndex = 0
        cmbdia.SelectedIndex = 0
        cmbturno.SelectedIndex = 0
        pbxhorasvacantes.Visible = False
        gbxsel.Visible = True
        btngenrep.Visible = False
        btnatras.Visible = False
        btnprint.Visible = False
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

        btngenrep.Visible = True
        btnatras.Visible = True
        btnprint.Visible = True
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btngenrep.Click
        cmbcar.SelectedIndex = 0
        cmbdia.SelectedIndex = 0
        cmbturno.SelectedIndex = 0
        pbxhorasvacantes.Visible = False
        gbxsel.Visible = True
        btngenrep.Visible = False
        btnatras.Visible = False
        btnprint.Visible = False

        rephorasvac.Show()
        Me.Hide()

    End Sub

    Private Sub PrintDocument1_PrintPage(ByVal sender As System.Object, ByVal e As System.Drawing.Printing.PrintPageEventArgs)

    End Sub

    Private Sub Label7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label7.Click

    End Sub

    Private Sub cmbcar_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cmbcar.KeyPress
        If (e.KeyChar < "0" Or e.KeyChar > "9") And e.KeyChar <> Chr(Keys.Back) Then
            e.KeyChar = ""
        End If
        If Char.IsLetter(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub cmbcar_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbcar.SelectedIndexChanged

    End Sub

    Private Sub cmturno_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cmbturno.KeyPress
        If (e.KeyChar < "0" Or e.KeyChar > "9") And e.KeyChar <> Chr(Keys.Back) Then
            e.KeyChar = ""
        End If
        If Char.IsLetter(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub cmturno_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbturno.SelectedIndexChanged

    End Sub

    Private Sub cmbaño_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cmbdia.KeyPress
        If (e.KeyChar < "0" Or e.KeyChar > "9") And e.KeyChar <> Chr(Keys.Back) Then
            e.KeyChar = ""
        End If
        If Char.IsLetter(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub cmbaño_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbdia.SelectedIndexChanged

    End Sub

    Private Sub btning_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btning.Click

        If (cmbturno.SelectedIndex = 0) Then
            MsgBox("Debe seleccionar el turno")
        End If
        If (cmbdia.SelectedIndex = 0) Then
            MsgBox("Debe seleccionar el año")
        End If
        If (cmbcar.SelectedIndex = 0) Then
            MsgBox("Debe seleccionar una carrera")
        End If
        If (cmbcar.SelectedIndex <> 0 And cmbdia.SelectedIndex <> 0 And cmbturno.SelectedIndex <> 0) Then
            gbxsel.Visible = False
            btnprint.Visible = True
            btngenrep.Visible = True
            btnatras.Visible = True

            pbxhorasvacantes.Visible = True
            pbxhorasvacantes.SetBounds(45, 76, 464, 308)

        End If
    End Sub

    Private Sub btnprint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnprint.Click
        MsgBox("Preparando archivo para imprimir")
        cmbcar.SelectedIndex = 0
        cmbdia.SelectedIndex = 0
        cmbturno.SelectedIndex = 0
        pbxhorasvacantes.Visible = False
        gbxsel.Visible = True
        btngenrep.Visible = False
        btnatras.Visible = False
        btnprint.Visible = False


        menureportse.Show()
        Me.Hide()

    End Sub

    Private Sub btnclose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnclose.Click
        Select Case MsgBox("Desea cerrar sesión?", MsgBoxStyle.YesNo)
            Case MsgBoxResult.Yes
                cmbcar.SelectedIndex = 0
                cmbdia.SelectedIndex = 0
                cmbturno.SelectedIndex = 0
                pbxhorasvacantes.Visible = False
                gbxsel.Visible = True
                btngenrep.Visible = False
                btnatras.Visible = False
                btnprint.Visible = False
                login.cmbpass.SelectedIndex = 0
                login.cmbnomu.SelectedIndex = 0

                login.Show()
                Me.Hide()
            Case MsgBoxResult.No
                Me.Hide()
                Me.Show()
        End Select
    End Sub
End Class