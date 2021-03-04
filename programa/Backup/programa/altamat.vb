Public Class altaMateria

    Private Sub Form29_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        cmbcarr.SelectedIndex = 0
        cmbaño.SelectedIndex = 0
        cmbtipo.SelectedIndex = 0
        cmbcargah.SelectedIndex = 0
        gbxmat.Visible = False
        btnatras.Visible = False
        btning.Visible = False
    End Sub

    Private Sub Label14_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lbldial2.Click

    End Sub

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lbltitulo.Click

    End Sub

    Private Sub Label10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lbldial1.Click

    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btncont.Click
        If (cmbcarr.SelectedIndex = 0) Then
            MsgBox("Debe seleccionar una carrera")
        End If
        If (cmbaño.SelectedIndex = 0) Then
            MsgBox("Debe ingresar el año de la carrera")

        End If
        If (cmbcarr.SelectedIndex <> 0 And cmbaño.SelectedIndex <> 0) Then
            lbldial2.Visible = False
            lbldial3.Visible = False
            lbldial1.Visible = False
            cmbcarr.Visible = False
            cmbaño.Visible = False
            gbxmat.Visible = True
            btnatras.Visible = True
            btning.Visible = True
            gbxmat.SetBounds(15, 75, 271, 226)
            btnatras.SetBounds(366, 174, 101, 22)
            btning.SetBounds(366, 133, 101, 22)
            txtnomcar.Text = cmbcarr.SelectedItem
            txtaño.text = cmbaño.SelectedItem
        End If

    End Sub

    Private Sub TextBox4_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtnomcar.TextChanged

    End Sub

    

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnclose.Click
        Select Case MsgBox("Desea cerrar sesión?", MsgBoxStyle.YesNo)
            Case MsgBoxResult.Yes
                txtnombre.Clear()
                txtcod.Clear()
                cmbtipo.SelectedIndex = 0
                cmbcargah.SelectedIndex = 0
                gbxmat.Visible = False
                lbldial2.Visible = True
                lbldial3.Visible = True

                lbldial1.Visible = True
                cmbcarr.Visible = True
                cmbaño.Visible = True

                btnatras.Visible = False

                btning.Visible = False
                cmbcarr.SelectedIndex = 0
                cmbaño.SelectedIndex = 0

                login.cmbnomu.SelectedIndex = 0
                login.cmbpass.SelectedIndex = 0
                login.Show()
                Me.Hide()
            Case MsgBoxResult.No

                Me.Show()
        End Select
    End Sub

    Private Sub Label8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblrol.Click

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btning.Click
        
        If (txtcod.Text = "") Then
            MsgBox("Debe ingresar un código")
        End If
        If (txtnombre.Text = "") Then
            MsgBox("Debe ingresar un nombre")
        End If
        If (cmbtipo.SelectedIndex = 0) Then
            MsgBox("Debe seleccionar un tipo de materia")
        End If
        If (cmbcargah.SelectedIndex = 0) Then
            MsgBox("Debe seleccionar una carga horaria para la materia")
        End If
        
        If txtcod.Text <> "" And txtnombre.Text <> "" And cmbtipo.SelectedIndex <> 0 And cmbcargah.SelectedIndex <> 0 Then
            MsgBox("Ingreso correcto")
            abmMateria.Show()
            txtnombre.Clear()
            txtcod.Clear()
            cmbtipo.SelectedIndex = 0
            cmbcargah.SelectedIndex = 0
            gbxmat.Visible = False
            lbldial2.Visible = True
            lbldial3.Visible = True

            lbldial1.Visible = True
            cmbcarr.Visible = True
            cmbaño.Visible = True

            btnatras.Visible = False

            btning.Visible = False
            cmbcarr.SelectedIndex = 0
            cmbaño.SelectedIndex = 0


            Me.Hide()
        End If


    End Sub

    Private Sub gbxmat_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles gbxmat.Enter

    End Sub

    Private Sub btnatras_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnatras.Click
        txtnombre.Clear()
        txtcod.Clear()
        cmbtipo.SelectedIndex = 0
        cmbcargah.SelectedIndex = 0
        abmMateria.Show()
        Me.Hide()
        gbxmat.Visible = False
        cmbcarr.SelectedIndex = 0
        cmbaño.SelectedIndex = 0
        cmbcarr.Visible = True
        cmbaño.Visible = True
        lbldial1.Visible = True
        lbldial2.Visible = True
        lbldial3.Visible = True
        btning.Visible = False
        btnatras.Visible = False
        txtcod.Clear()
        txtnombre.Clear()
        txtnomcar.Clear()
        cmbtipo.SelectedIndex = 0
        cmbcargah.SelectedIndex = 0




    End Sub

    Private Sub txtcod_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtcod.TextChanged
        
    End Sub

    Private Sub Label1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click

    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtaño.TextChanged

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

    Private Sub cmbtipo_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cmbtipo.KeyPress
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

    Private Sub cmbtipo_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbtipo.SelectedIndexChanged

    End Sub

    Private Sub cmbcargah_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cmbcargah.KeyPress
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

    Private Sub cmbcargah_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbcargah.SelectedIndexChanged

    End Sub
End Class