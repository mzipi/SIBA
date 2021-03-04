Public Class consplanalumdia

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        gbxsel.Visible = True

    End Sub

    Private Sub GroupBox3_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles gbxsel.Enter

    End Sub

    Private Sub consplanalumdia_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        gbxdatos.Visible = False
        cmbturno.SelectedIndex = 0
        cmbgrupo.SelectedIndex = 0
        cmbdia.SelectedIndex = 0
        pbxplanalum.Visible = False
        btnatras.Visible = False
        gbxsel.Visible = True

    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btning.Click

        lbltursel.Text = cmbturno.SelectedItem
        lbldiasel.Text = cmbdia.SelectedItem
        lblgrupsel.Text = cmbgrupo.SelectedItem

        If (cmbturno.SelectedIndex = 0) Then
            MsgBox("Debe seleccionar un turno")
        End If
        If (cmbdia.SelectedIndex = 0) Then
            MsgBox("Debe seleccionar un día")
        End If
        If (cmbgrupo.SelectedIndex = 0) Then
            MsgBox("Debe seleccionar el grupo")
        End If
        If (cmbturno.SelectedIndex <> 0 And cmbdia.SelectedIndex <> 0 And cmbgrupo.SelectedIndex <> 0) Then
            gbxsel.Visible = False
            pbxplanalum.Visible = True
            pbxplanalum.SetBounds(8, 107, 754, 104)
            btnatras.Visible = True
            gbxdatos.Visible = True
            gbxdatos.SetBounds(110, 60, 483, 45)
        End If
        
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnatras.Click
        If (lbltipou.Text = "Docente") Then
            cmbturno.SelectedIndex = 0
            cmbgrupo.SelectedIndex = 0
            cmbdia.SelectedIndex = 0
            pbxplanalum.Visible = False
            gbxsel.Visible = True
            gbxdatos.Visible = False
            consplanalum.Show()
            btnatras.Visible = False

            Me.Hide()
        End If
        If (lbltipou.Text = "Alumno") Then
            cmbturno.SelectedIndex = 0
            cmbgrupo.SelectedIndex = 0
            cmbdia.SelectedIndex = 0
            pbxplanalum.Visible = False
            gbxsel.Visible = True
            gbxdatos.Visible = False
            consplanalum.Show()
            btnatras.Visible = False

            Me.Hide()
        End If
        If (lbltipou.Text = "Secretario Escolar") Then
            cmbturno.SelectedIndex = 0
            cmbgrupo.SelectedIndex = 0
            cmbdia.SelectedIndex = 0
            pbxplanalum.Visible = False
            gbxsel.Visible = True
            gbxdatos.Visible = False
            consplanalum.Show()
            btnatras.Visible = False
            Me.Hide()
        End If
    End Sub

    Private Sub btnmenu_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnmenu.Click
        If (lbltipou.Text = "Docente") Then
            cmbturno.SelectedIndex = 0
            cmbgrupo.SelectedIndex = 0
            cmbdia.SelectedIndex = 0
            pbxplanalum.Visible = False
            gbxsel.Visible = True
            gbxdatos.Visible = False
            menupdoc.Show()
            Me.Hide()
        End If
        If (lbltipou.Text = "Alumno") Then
            cmbturno.SelectedIndex = 0
            cmbgrupo.SelectedIndex = 0
            cmbdia.SelectedIndex = 0
            pbxplanalum.Visible = False
            gbxsel.Visible = True
            gbxdatos.Visible = False
            menupalum.Show()
            Me.Hide()
        End If
        If (lbltipou.Text = "Secretario Escolar") Then
            cmbturno.SelectedIndex = 0
            cmbgrupo.SelectedIndex = 0
            cmbdia.SelectedIndex = 0
            pbxplanalum.Visible = False
            gbxsel.Visible = True
            gbxdatos.Visible = False
            menureportse.Show()
            Me.Hide()
        End If

    End Sub

    Private Sub lblturno_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblturno.Click

    End Sub

    Private Sub btnclose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnclose.Click
        Select Case MsgBox("Desea cerrar sesión?", MsgBoxStyle.YesNo)
            Case MsgBoxResult.Yes
                cmbturno.SelectedIndex = 0
                cmbgrupo.SelectedIndex = 0
                cmbdia.SelectedIndex = 0
                pbxplanalum.Visible = False
                gbxsel.Visible = True
                gbxdatos.Visible = False
                login.cmbpass.SelectedIndex = 0
                login.cmbnomu.SelectedIndex = 0

                login.Show()
                Me.Hide()
            Case MsgBoxResult.No
                Me.Hide()
                Me.Show()
        End Select
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

    Private Sub cmbgrupo_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cmbgrupo.KeyPress
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

    Private Sub cmbgrupo_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbgrupo.SelectedIndexChanged

    End Sub

    Private Sub cmbdia_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cmbdia.KeyPress
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

    Private Sub cmbdia_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbdia.SelectedIndexChanged

    End Sub

    Private Sub gbxdatos_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles gbxdatos.Enter

    End Sub

    Private Sub pbxplanalum_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pbxplanalum.Click

    End Sub
End Class