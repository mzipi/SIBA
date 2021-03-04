Public Class sinDoc

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        
    End Sub

    Private Sub Form46_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        cmbcarr.SelectedIndex = 0
        cmbturno.SelectedIndex = 0

        gbxsel.Visible = True
        pbxgrupsindoc.Visible = False
        btnprint.Visible = False
        btnatras.Visible = False
        btngenrep.Visible = False

    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btning.Click
        If (cmbcarr.SelectedIndex = 0) Then
            MsgBox("Debe seleccionar la carrera a consultar")
        End If
        If (cmbturno.SelectedIndex = 0) Then
            MsgBox("Debe seleccionar el turno a consultar")
        End If
        If (cmbcarr.SelectedIndex <> 0 And cmbturno.SelectedIndex <> 0) Then
            gbxsel.Visible = False
            pbxgrupsindoc.Visible = True
            pbxgrupsindoc.SetBounds(12, 82, 441, 327)
            btnprint.Visible = True
            btnatras.Visible = True
            btngenrep.Visible = True
        End If

    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btngenrep.Click
        pbxgrupsindoc.Visible = False
        gbxsel.Visible = True
        btnatras.Visible = False
        btnprint.Visible = False
        btngenrep.Visible = False
        cmbcarr.SelectedIndex = 0
        cmbturno.SelectedIndex = 0
        repgrupsindoc.Show()
        Me.Hide()

    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnatras.Click
        If (lbltipou.Text = "Administrativo") Then
            pbxgrupsindoc.Visible = False
            gbxsel.Visible = True
            btnatras.Visible = False
            btnprint.Visible = False
            btngenrep.Visible = False
            cmbcarr.SelectedIndex = 0
            cmbturno.SelectedIndex = 0
            menupadm.Show()
            Me.Hide()
        End If

        If (lbltipou.Text = "Secretario Escolar") Then
            pbxgrupsindoc.Visible = False
            gbxsel.Visible = True
            btnatras.Visible = False
            btnprint.Visible = False
            btngenrep.Visible = False
            cmbcarr.SelectedIndex = 0
            cmbturno.SelectedIndex = 0
            menureportse.Show()
            Me.Hide()

        End If


    End Sub

    Private Sub btnclose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnclose.Click
        Select Case MsgBox("Desea cerrar sesión?", MsgBoxStyle.YesNo)
            Case MsgBoxResult.Yes
                pbxgrupsindoc.Visible = False
                gbxsel.Visible = True
                btnatras.Visible = False
                btnprint.Visible = False
                btngenrep.Visible = False
                cmbcarr.SelectedIndex = 0
                cmbturno.SelectedIndex = 0
                login.cmbpass.SelectedIndex = 0
                login.cmbnomu.SelectedIndex = 0

                login.Show()
                Me.Hide()
            Case MsgBoxResult.No
                Me.Hide()
                Me.Show()
        End Select
    End Sub

    Private Sub cmbcarr_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cmbcarr.KeyPress
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

    Private Sub cmbcarr_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbcarr.SelectedIndexChanged

    End Sub

    Private Sub cmbturno_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cmbturno.KeyPress
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

    Private Sub cmbturno_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbturno.SelectedIndexChanged

    End Sub

    Private Sub btnprint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnprint.Click
        If (lbltipou.Text = "Administrativo") Then
            MsgBox("Preparando documento para impresión")
            pbxgrupsindoc.Visible = False
            gbxsel.Visible = True
            btnatras.Visible = False
            btnprint.Visible = False
            btngenrep.Visible = False
            cmbcarr.SelectedIndex = 0
            cmbturno.SelectedIndex = 0
            menupadm.Show()
            Me.Hide()
        End If
        If (lbltipou.Text = "Secretario Escolar") Then
            MsgBox("Preparando documento para impresión")
            pbxgrupsindoc.Visible = False
            gbxsel.Visible = True
            btnatras.Visible = False
            btnprint.Visible = False
            btngenrep.Visible = False
            cmbcarr.SelectedIndex = 0
            cmbturno.SelectedIndex = 0
            menureportse.Show()
            Me.Hide()
        End If
    End Sub

    Private Sub Button1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If (lbltipou.Text = "Administrativo") Then
            menupadm.Show()
            Me.Hide()
            pbxgrupsindoc.Visible = False
            gbxsel.Visible = True
            btnatras.Visible = False
            btnprint.Visible = False
            btngenrep.Visible = False
            cmbcarr.SelectedIndex = 0
            cmbturno.SelectedIndex = 0
        End If
        If (lbltipou.Text = "Secretario Escolar") Then
            menureportse.Show()
            Me.Hide()
            pbxgrupsindoc.Visible = False
            gbxsel.Visible = True
            btnatras.Visible = False
            btnprint.Visible = False
            btngenrep.Visible = False
            cmbcarr.SelectedIndex = 0
            cmbturno.SelectedIndex = 0
        End If
    End Sub
End Class