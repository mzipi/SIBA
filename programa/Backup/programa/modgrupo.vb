Public Class modgrupo

    Private Sub TextBox8_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtnomcarr.TextChanged

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnatras.Click
        txtnomcarr.Text = "EMT Inform�tica"
        txtcodgrup.Text = 1
        txta�o.Text = 3
        txtcurso.Text = "I"
        txtletra.Text = "F"
        abmGrupo.Show()
        Me.Hide()

    End Sub

    Private Sub Label6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lbltitulo.Click

    End Sub

    Private Sub btnclose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnclose.Click
        Select Case MsgBox("Desea cerrar sesi�n?", MsgBoxStyle.YesNo)
            Case MsgBoxResult.Yes
                txtnomcarr.Text = "EMT Inform�tica"
                txtcodgrup.Text = 1
                txta�o.Text = 3
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
            MsgBox("Debe ingresar un c�digo de carrera")
        End If
        If (txtcodgrup.Text = "") Then
            MsgBox("Debe ingresar un c�digo de grupo")
        End If
        If (txta�o.Text = "") Then
            MsgBox("Debe ingresar el a�o del grupo")

        End If

        If (txtcurso.Text = "") Then
            MsgBox("Debe ingresar el curso")
        End If

        If (txtletra.Text = "") Then
            MsgBox("Debe ingresar la letra que identificar� al grupo")

        End If
        If (txtletra.Text <> "" And txtcurso.Text <> "" And txta�o.Text <> "" And txtcodgrup.Text <> "" And txtnomcarr.Text <> "") Then
            MsgBox("Grupo modificado exitosamente")
            abmGrupo.Show()
            Me.Hide()
            txtnomcarr.Text = "EMT Inform�tica"
            txtcodgrup.Text = 1
            txta�o.Text = 3
            txtcurso.Text = "I"
            txtletra.Text = "F"

        End If


    End Sub

    Private Sub txta�o_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txta�o.KeyPress
        If (e.KeyChar < "0" Or e.KeyChar > "9") And e.KeyChar <> Chr(Keys.Back) Then
            e.KeyChar = ""
        End If
    End Sub

    Private Sub txta�o_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txta�o.TextChanged

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