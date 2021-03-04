Public Class modgrupo

    Private Sub TextBox8_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtnomcarr.TextChanged

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnatras.Click
        txtnomcarr.Text = "EMT Informática"
        txtcodgrup.Text = 1
        txtaño.Text = 3
        txtcurso.Text = "I"
        txtletra.Text = "F"
        abmGrupo.Show()
        Me.Hide()

    End Sub

    Private Sub Label6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lbltitulo.Click

    End Sub

    Private Sub btnclose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnclose.Click
        Select Case MsgBox("Desea cerrar sesión?", MsgBoxStyle.YesNo)
            Case MsgBoxResult.Yes
                txtnomcarr.Text = "EMT Informática"
                txtcodgrup.Text = 1
                txtaño.Text = 3
                txtcurso.Text = "I"
                txtletra.Text = "F"
                login.cmbpass.SelectedIndex = 0
                login.cmbnomu.SelectedIndex = 0
                login.Show()
                Me.Hide()
            Case MsgBoxResult.No
                Me.Hide()
                Me.Show()
        End Select
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnmod.Click
        If (txtnomcarr.Text = "") Then
            MsgBox("Debe ingresar un código de carrera")
        End If
        If (txtcodgrup.Text = "") Then
            MsgBox("Debe ingresar un código de grupo")
        End If
        If (txtaño.Text = "") Then
            MsgBox("Debe ingresar el año del grupo")

        End If

        If (txtcurso.Text = "") Then
            MsgBox("Debe ingresar el curso")
        End If

        If (txtletra.Text = "") Then
            MsgBox("Debe ingresar la letra que identificará al grupo")

        End If
        If (txtletra.Text <> "" And txtcurso.Text <> "" And txtaño.Text <> "" And txtcodgrup.Text <> "" And txtnomcarr.Text <> "") Then
            MsgBox("Grupo modificado exitosamente")
            abmGrupo.Show()
            Me.Hide()
            txtnomcarr.Text = "EMT Informática"
            txtcodgrup.Text = 1
            txtaño.Text = 3
            txtcurso.Text = "I"
            txtletra.Text = "F"

        End If


    End Sub

    Private Sub txtaño_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtaño.KeyPress
        If (e.KeyChar < "0" Or e.KeyChar > "9") And e.KeyChar <> Chr(Keys.Back) Then
            e.KeyChar = ""
        End If
    End Sub

    Private Sub txtaño_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtaño.TextChanged

    End Sub

    Private Sub txtcurso_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtcurso.KeyPress
        If Char.IsLetter(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub txtcurso_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtcurso.TextChanged

    End Sub

    Private Sub txtletra_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtletra.KeyPress
        If Char.IsLetter(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub txtletra_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtletra.TextChanged

    End Sub

    Private Sub txtcodgrup_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtcodgrup.KeyPress
        If (e.KeyChar < "0" Or e.KeyChar > "9") And e.KeyChar <> Chr(Keys.Back) Then
            e.KeyChar = ""
        End If
    End Sub

    Private Sub txtcodgrup_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtcodgrup.TextChanged

    End Sub

    Private Sub modgrupo_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class