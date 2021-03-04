Public Class consplanalum

    Private Sub Label10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label10.Click

    End Sub

    
    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btning.Click

        lbltursel.Text = cmbturno.SelectedItem
        lbldiasel.Text = cmbdia.SelectedItem

        If (cmbturno.SelectedIndex = 0) Then
            MsgBox("Debe seleccionar un turno")
        End If
        If (cmbdia.SelectedIndex = 0) Then
            MsgBox("Debe seleccionar un día")
        End If
        
        If (cmbturno.SelectedIndex <> 0 And cmbdia.SelectedIndex <> 0) Then
            gbxsel.Visible = False
            pbxplancomp.Visible = True
            pbxplancomp.SetBounds(69, 98, 503, 344)


            btnatras.Visible = True
            gbxdatos.Visible = True
            gbxdatos.SetBounds(67, 66, 503, 45)
        End If

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnatras.Click
        If (lbltipou.Text = "Docente") Then

            btnatras.Visible = True
            gbxdatos.Visible = False
            cmbturno.SelectedIndex = 0
            cmbdia.SelectedIndex = 0
            pbxplancomp.Visible = False
            gbxopc.Visible = True
            gbxsel.Visible = False
            menupdoc.Show()
            Me.Hide()
        End If
        If (lbltipou.Text = "Alumno") Then
            menupalum.Show()
            Me.Hide()


            btnatras.Visible = False
            gbxdatos.Visible = False
            cmbturno.SelectedIndex = 0
            cmbdia.SelectedIndex = 0
            pbxplancomp.Visible = False
            gbxopc.Visible = True
            gbxsel.Visible = False

        End If

        If (lbltipou.Text = "Secretario Escolar") Then
            menureportse.Show()
            Me.Hide()


            btnatras.Visible = False
            gbxdatos.Visible = False
            cmbturno.SelectedIndex = 0
            cmbdia.SelectedIndex = 0
            pbxplancomp.Visible = False
            gbxopc.Visible = True
            gbxsel.Visible = False

        End If

    End Sub

    Private Sub GroupBox2_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles gbxsel.Enter

    End Sub

    
    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnmenu.Click
        If (lbltipou.Text = "Alumno") Then

            btnatras.Visible = True
            gbxdatos.Visible = False
            cmbturno.SelectedIndex = 0
            cmbdia.SelectedIndex = 0
            pbxplancomp.Visible = False
            gbxopc.Visible = True
            gbxsel.Visible = False
            menupalum.Show()
            Me.Hide()
        End If
        If (lbltipou.Text = "Secretario Escolar") Then

            btnatras.Visible = True
            gbxdatos.Visible = False
            cmbturno.SelectedIndex = 0
            cmbdia.SelectedIndex = 0
            pbxplancomp.Visible = False
            gbxopc.Visible = True
            gbxsel.Visible = False
            menureportse.Show()
            Me.Hide()
        End If
        If (lbltipou.Text = "Docente") Then

            btnatras.Visible = True
            gbxdatos.Visible = False
            cmbturno.SelectedIndex = 0
            cmbdia.SelectedIndex = 0
            pbxplancomp.Visible = False
            gbxopc.Visible = True
            gbxsel.Visible = False
            menupdoc.Show()
            Me.Hide()
        End If
    End Sub

    Private Sub consplanalum_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        gbxdatos.Visible = False
        btnatras.Visible = False

        cmbturno.SelectedIndex = 0
        cmbdia.SelectedIndex = 0
        gbxopc.Visible = True
        gbxsel.Visible = False
        pbxplancomp.Visible = False

    End Sub

    Private Sub Label5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lbltitulo.Click

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btngrupdia.Click
        gbxopc.Visible = False
        gbxsel.Visible = True
        gbxsel.SetBounds(12, 58, 280, 232)


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

    Private Sub cmbcarr_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
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

    Private Sub cmbcarr_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub btnclose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnclose.Click
        Select Case MsgBox("Desea cerrar sesión?", MsgBoxStyle.YesNo)
            Case MsgBoxResult.Yes

                btnatras.Visible = True
                gbxdatos.Visible = False
                cmbturno.SelectedIndex = 0
                cmbdia.SelectedIndex = 0
                pbxplancomp.Visible = False
                gbxopc.Visible = True
                gbxsel.Visible = False
                login.cmbpass.SelectedIndex = 0
                login.cmbnomu.SelectedIndex = 0
                login.Show()
                Me.Hide()
            Case MsgBoxResult.No
                Me.Hide()
                Me.Show()
        End Select
    End Sub

    Private Sub Label4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub btnhorcomp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnhorcomp.Click
        consplanalumdia.Show()
        Me.Hide()

    End Sub

    Private Sub gbxdatos_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles gbxdatos.Enter

    End Sub
End Class