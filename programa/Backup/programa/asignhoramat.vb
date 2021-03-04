Public Class asignhoramat

    Private Sub Form49_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        cmbcarrera.SelectedIndex = 0
        cmbdia.SelectedIndex = 0
        cmbgrupoele.SelectedIndex = 0
        Label3.Visible = False
        Label2.Visible = False
        lbldiasel.Visible = False
        Label1.Visible = False

        btnconf.Visible = False
        btnatras.Visible = False
        gbxsel.Visible = False

        btnsel.SetBounds(12, 273, 121, 28)
        lblmatsel.Visible = False
        lbldia.Visible = False
        lblgrupsel.Visible = False
        lblhora.Visible = False
        lblhorassel.Visible = False
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsel.Click
        If (ltvmat.SelectedItems.Count = 0) Then
            MsgBox("Debe seleccionar una materia")

        End If
        If (ltvmat.SelectedItems.Count > 0) Then
            gbxsel.Visible = True
            gbxsel.SetBounds(14, 76, 275, 253)

            Label1.Visible = True
            ltvmat.Visible = False

            lblmatsel.Visible = True
            lblmatsel.SetBounds(82, 57, 207, 16)
            btnsel.Visible = False

        End If


    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Label1.SetBounds(12, 73, 54, 16)
        lblgrupsel.Visible = True

        gbxsel.Visible = True
        gbxsel.SetBounds(15, 92, 275, 209)



    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        If (cmbcarrera.SelectedIndex = 0) Then
            MsgBox("Debe seleccionar una carrera")
        End If
        If (cmbgrupoele.SelectedIndex = 0) Then
            MsgBox("Debe seleccionar un grupo")
        End If
        If (cmbdia.SelectedIndex = 0) Then
            MsgBox("Debe seleccionar un día")
        End If
        If (txtnum.Text = "") Then
            MsgBox("Debe ingresar el/los numero/s de hora/s")
        End If
        If (cmbcarrera.SelectedIndex <> 0 And cmbdia.SelectedIndex <> 0 And cmbgrupoele.SelectedIndex <> 0 And txtnum.Text <> "") Then

            lbldia.Visible = True
            lbldiasel.Visible = True
            gbxsel.Visible = False
            lblhora.Visible = True
            btnatras.Visible = True
            lblgrupsel.Visible = True

            lblhorassel.Visible = True
            btnconf.Visible = True
            lblgrupsel.Text = cmbgrupoele.SelectedItem
            lbldiasel.Text = cmbdia.SelectedItem
            lblhorassel.Text = txtnum.Text

        End If



    End Sub

    Private Sub Label16_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblhorassel.Click

    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnconf.Click

        MsgBox("Ha ingresado la información correctamente")
        gbxsel.Visible = False
        ltvmat.Visible = True
        ltvmat.SelectedItems.Clear()
        cmbgrupoele.SelectedIndex = 0
        cmbdia.SelectedIndex = 0
        cmbcarrera.SelectedIndex = 0
        lbldia.Visible = False
        lblmatsel.Visible = False
        lblhora.Visible = False
        lblhorassel.Visible = False
        lblgrupsel.Visible = False
        btnconf.Visible = False
        btnatras.Visible = False
        btnsel.Visible = True
        txtnum.Clear()

    End Sub
    Private Sub Label12_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label12.Click

    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnatras.Click
        gbxsel.Visible = False
        ltvmat.Visible = True
        ltvmat.SelectedItems.Clear()
        cmbgrupoele.SelectedIndex = 0
        cmbdia.SelectedIndex = 0
        cmbcarrera.SelectedIndex = 0
        lblmatsel.Visible = False
        lbldia.Visible = False
        lblhora.Visible = False
        lblhorassel.Visible = False
        lblgrupsel.Visible = False
        btnconf.Visible = False
        btnatras.Visible = False
        btnsel.Visible = True
        txtnum.Clear()
        abmMateria.Show()
        Me.Hide()
    End Sub

    Private Sub ListView3_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ltvmat.SelectedIndexChanged
        If ltvmat.SelectedItems.Count > 0 Then lblmatsel.Text = ltvmat.SelectedItems.Item(0).Text

    End Sub

    Private Sub Label7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblmatsel.Click

    End Sub

    Private Sub ComboBox4_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cmbcarrera.KeyPress
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

    Private Sub ComboBox4_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbcarrera.SelectedIndexChanged

    End Sub

    Private Sub ComboBox1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cmbdia.KeyPress

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

    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbdia.SelectedIndexChanged

    End Sub

    Private Sub TextBox1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtnum.KeyPress
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf e.KeyChar = "," Then
            e.Handled = False
        ElseIf e.KeyChar = ":" Then
            e.Handled = False
        ElseIf e.KeyChar = " " Then
            e.Handled = False

        Else
            e.Handled = True
        End If
    End Sub


    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtnum.TextChanged



    End Sub

    Private Sub Label7_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label7.Click

    End Sub

    Private Sub cmbgrupoele_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cmbgrupoele.KeyPress
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

    Private Sub ComboBox1_SelectedIndexChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbgrupoele.SelectedIndexChanged

    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        Select Case MsgBox("Desea cerrar sesión?", MsgBoxStyle.YesNo)
            Case MsgBoxResult.Yes
                gbxsel.Visible = False
                ltvmat.Visible = True
                ltvmat.SelectedItems.Clear()
                cmbgrupoele.SelectedIndex = 0
                cmbdia.SelectedIndex = 0
                cmbcarrera.SelectedIndex = 0
                lbldia.Visible = False
                lblhora.Visible = False
                lblhorassel.Visible = False
                lblgrupsel.Visible = False
                btnconf.Visible = False
                btnatras.Visible = False
                btnsel.Visible = True
                txtnum.Clear()
                login.cmbpass.SelectedIndex = 0

                login.cmbnomu.SelectedIndex = 0
                login.Show()
                Me.Hide()
            Case MsgBoxResult.No
                Me.Hide()
                Me.Show()
        End Select
    End Sub

    Private Sub Label8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label8.Click

    End Sub
End Class