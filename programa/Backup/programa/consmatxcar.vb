Public Class consmatxcar

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click

        If (cmbcarr.SelectedIndex = 0) Then
            MsgBox("Debe seleccionar una carrera")
        End If
        If (cmbaño.SelectedIndex = 0) Then
            MsgBox("Debe seleccionar un año")
        End If
        If (cmbcarr.SelectedIndex <> 0 And cmbaño.SelectedIndex <> 0) Then
            lblcarsel.Text = cmbcarr.SelectedItem
            lblañosel.Text = cmbaño.SelectedItem
            gbxdatos.Visible = True
            gbxdatos.SetBounds(59, 50, 428, 45)

            gbxsel.Visible = False
            ltvmat.Visible = True
            ltvmat.SetBounds(59, 97, 428, 203)
            btnatras.Visible = True
        End If
        

    End Sub

    Private Sub Form44_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        gbxdatos.Visible = False
        cmbaño.SelectedIndex = 0
        cmbcarr.SelectedIndex = 0
        ltvmat.Visible = False
        btnatras.Visible = False

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnatras.Click
        If (lbltipou.Text = "Alumno") Then
            menupalum.Show()
            Me.Hide()
            gbxdatos.Visible = False
            ltvmat.Visible = False
            gbxsel.Visible = True
            cmbcarr.SelectedIndex = 0
            cmbaño.SelectedIndex = 0

        End If
        If (lbltipou.Text = "Secretario Escolar") Then
            menureportse.Show()
            Me.Hide()
            gbxdatos.Visible = False

            ltvmat.Visible = False
            gbxsel.Visible = True
            cmbcarr.SelectedIndex = 0
            cmbaño.SelectedIndex = 0
        End If

        
        
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Select Case MsgBox("Desea cerrar sesión?", MsgBoxStyle.YesNo)
            Case MsgBoxResult.Yes
                gbxdatos.Visible = False
                ltvmat.Visible = False
                gbxsel.Visible = True
                cmbcarr.SelectedIndex = 0
                cmbaño.SelectedIndex = 0
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

    Private Sub cmbaño_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cmbaño.KeyPress
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

    Private Sub cmbaño_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbaño.SelectedIndexChanged

    End Sub

    Private Sub gbxdatos_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles gbxdatos.Enter

    End Sub
End Class