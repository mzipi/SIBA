Public Class altagrupo



    Private Sub Label15_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If (cmbcarrera.SelectedIndex = 0) Then
            MsgBox("Debe seleccionar una carrera")
        End If
        If (txtcodgrupo.Text = "") Then
            MsgBox("Debe ingresar un código de grupo")
        End If
        If (cmbturno.SelectedIndex = 0) Then
            MsgBox("Debe seleccionar un turno")

        End If

        If (cmbaño.SelectedIndex = 0) Then
            MsgBox("Debe seleccionar el año al que pertenecerá el grupo")

        End If

        If (txtcurso.Text = "") Then
            MsgBox("Debe ingresar el curso al que pertenece el grupo")

        End If

        If (txtletra.Text = "") Then
            MsgBox("Debe ingresar una letra para identificar al grupo")

        End If

        If (txtletra.Text <> "" And txtcurso.Text <> "" And cmbaño.SelectedIndex <> 0 And cmbturno.SelectedIndex <> 0 And txtcodgrupo.Text <> "" And cmbcarrera.SelectedIndex <> 0) Then
            MsgBox("Se continuará validando disponibilidad")


            gbxgrup.Visible = False

            lblsalon.Visible = True
            lblsalon.Text = cmbaño.SelectedItem + txtcurso.Text + txtletra.Text


        End If


    End Sub

    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        

    End Sub

    Private Sub Form18_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        cmbturno.SelectedIndex = 0
        cmbcarrera.SelectedIndex = 0
        cmbaño.SelectedIndex = 0



        
        
    End Sub

    Private Sub GroupBox1_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Label11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub TextBox14_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

        gbxgrup.Visible = False

    End Sub

    Private Sub Button5_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)
        btnabmgrup.Visible = True
        btnsiba.Visible = True

    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsiba.Click

        txtcodgrupo.Clear()
        cmbturno.SelectedIndex = 0
        txtcurso.Clear()
        txtletra.Clear()
        gbxgrup.Visible = False

        
        cmbcarrera.Visible = True
        cmbcarrera.SelectedIndex = 0
        cmbaño.Visible = False
        cmbaño.SelectedIndex = 0


        menupse.Show()
        Me.Hide()

    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnabmgrup.Click


        txtcodgrupo.Clear()
        cmbturno.SelectedIndex = 0

        txtcurso.Clear()
        txtletra.Clear()
        gbxgrup.Visible = False



        cmbcarrera.Visible = True
        cmbcarrera.SelectedIndex = 0
        cmbaño.Visible = True
        cmbaño.SelectedIndex = 0

        abmGrupo.Show()
        Me.Hide()

    End Sub

    Private Sub txtcodgrupo_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub btncancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

        txtcodgrupo.Clear()
        cmbturno.SelectedIndex = 0

        txtcurso.Clear()
        txtletra.Clear()
    End Sub

    Private Sub lblingreso_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub txtaño_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)

        If (e.KeyChar < "0" Or e.KeyChar > "9") And e.KeyChar <> Chr(Keys.Back) Then
            e.KeyChar = ""
        End If
    End Sub

    Private Sub txtaño_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub txtcurso_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If Char.IsLetter(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub txtcurso_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub txtletra_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If Char.IsLetter(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub txtletra_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub gbxgrup_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub cmbcarrera_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cmbcarrera.KeyPress
        If (e.KeyChar < "0" Or e.KeyChar > "9") And e.KeyChar <> Chr(Keys.Back) Then
            e.KeyChar = ""
        End If
        If Char.IsLetter(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsSeparator(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub cmbcarrera_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbcarrera.SelectedIndexChanged

    End Sub

    Private Sub txtcodgrupo_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtcodgrupo.KeyPress
        If (e.KeyChar < "0" Or e.KeyChar > "9") And e.KeyChar <> Chr(Keys.Back) Then
            e.KeyChar = ""
        End If
    End Sub

    Private Sub txtcodgrupo_TextChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtcodgrupo.TextChanged

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

    Private Sub txtaño_KeyPress1(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If (e.KeyChar < "0" Or e.KeyChar > "9") And e.KeyChar <> Chr(Keys.Back) Then
            e.KeyChar = ""
        End If
    End Sub

    Private Sub txtaño_TextChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub txtletra_KeyPress1(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtletra.KeyPress
        If Char.IsLetter(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub txtletra_TextChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtletra.TextChanged

    End Sub

    Private Sub txtcurso_KeyPress1(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtcurso.KeyPress
        
        If Char.IsLetter(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub txtcurso_TextChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtcurso.TextChanged

    End Sub

    Private Sub btncancel_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btncancel.Click
        cmbcarrera.SelectedIndex = 0
        txtcodgrupo.Clear()
        cmbturno.SelectedIndex = 0
        cmbaño.SelectedIndex = 0
        txtcurso.Clear()
        txtletra.Clear()

    End Sub

    Private Sub btnaceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnaceptar.Click
        If (cmbturno.SelectedIndex = 0) Then
            MsgBox("Debe seleccionar un turno")

        End If
        If (txtcodgrupo.Text = "") Then
            MsgBox("Debe ingresar un código de grupo")
        End If
        If (txtcurso.Text = "") Then
            MsgBox("Debe ingresar una letra para identificar la carrera")

        End If
        If (txtletra.Text = "") Then
            MsgBox("Debe ingresar una letra para identificar el grupo")

        End If
        If (txtletra.Text <> "" And txtcurso.Text <> "" And txtcodgrupo.Text <> "" And cmbturno.SelectedIndex <> 0) Then

            ingresogrupo2.Show()
            Me.Hide()

            txtcodgrupo.Clear()
            cmbturno.SelectedIndex = 0
            gbxgrup.Visible = False

            

            cmbcarrera.SelectedIndex = 0
            cmbaño.Visible = True
            cmbaño.SelectedIndex = 0

            ingresogrupo2.lblgrupaing.Text = cmbaño.SelectedItem + txtcurso.Text + txtletra.Text

            txtcurso.Clear()
            txtletra.Clear()
        End If
    End Sub

    Private Sub cmbaño_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cmbaño.KeyPress
        If (e.KeyChar < "0" Or e.KeyChar > "9") And e.KeyChar <> Chr(Keys.Back) Then
            e.KeyChar = ""
        End If
        If Char.IsLetter(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsSeparator(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub cmbaño_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbaño.SelectedIndexChanged

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnclose.Click
        Select Case MsgBox("Desea cerrar sesión?", MsgBoxStyle.YesNo)
            Case MsgBoxResult.Yes

                txtcodgrupo.Clear()
                cmbturno.SelectedIndex = 0

                txtcurso.Clear()
                txtletra.Clear()
                gbxgrup.Visible = False
                

                cmbcarrera.Visible = True
                cmbcarrera.SelectedIndex = 0
                cmbaño.Visible = False
                cmbaño.SelectedIndex = 0

                login.cmbnomu.SelectedIndex = 0
                login.cmbpass.SelectedIndex = 0
                login.Show()
                Me.Hide()
            Case MsgBoxResult.No
                Me.Hide()
                Me.Show()
        End Select

    End Sub

    Private Sub lbltipou_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lbltipou.Click

    End Sub

    Private Sub lblrol_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblrol.Click

    End Sub
End Class