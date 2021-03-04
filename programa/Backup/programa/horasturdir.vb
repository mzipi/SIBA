Public Class horasturdir

    Private Sub horasturdir_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        gbxhorarios.Visible = False
        ltvhorasvesp.Visible = False
        ltvhorasmat.Visible = False
        gbxval.Visible = False
        btnenv.Visible = False
        btnmenu.Visible = False
        ltvhorasnoc.Visible = False
        gbxobs.Visible = False
        cmbturno.SelectedIndex = 0
    End Sub

    Private Sub btncons_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btncons.Click
        Select Case cmbturno.SelectedIndex
            Case 0
                MsgBox("Debe seleccionar un turno")

            Case 1
                lblini.Text = "07:30"
                lblfin.Text = "13:00"

                gbxhorarios.Text = cmbturno.SelectedItem
                gbxsel.Visible = False
                gbxhorarios.Visible = True
                gbxhorarios.SetBounds(12, 60, 356, 96)
            Case 2
                lblini.Text = "13:15"
                lblfin.Text = "18:45"

                gbxhorarios.Text = cmbturno.SelectedItem
                gbxsel.Visible = False
                gbxhorarios.Visible = True
                gbxhorarios.SetBounds(12, 60, 356, 96)
            Case 3
                lblini.Text = "19:15"
                lblfin.Text = "23:55"
                gbxhorarios.Text = cmbturno.SelectedItem
                gbxsel.Visible = False
                gbxhorarios.Visible = True
                gbxhorarios.SetBounds(12, 60, 356, 96)
        End Select

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        Select Case cmbturno.SelectedIndex
            Case 1

                gbxval.Visible = True

                btnenv.Visible = True
                btnmenu.Visible = True

                ltvhorasmat.Visible = True
                ltvhorasmat.SetBounds(16, 160, 326, 268)

            Case 2
                gbxval.Visible = True

                btnenv.Visible = True
                btnmenu.Visible = True

                ltvhorasvesp.Visible = True
                ltvhorasvesp.SetBounds(16, 160, 326, 268)

            Case 3
                gbxval.Visible = True

                btnenv.Visible = True
                btnmenu.Visible = True

                ltvhorasnoc.Visible = True
                ltvhorasnoc.SetBounds(16, 160, 326, 268)


        End Select
       
    End Sub

    Private Sub btnno_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnno.Click
        btnenv.Enabled = True
        gbxobs.Visible = True

    End Sub

    Private Sub ltvhorasnoc_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ltvhorasnoc.SelectedIndexChanged

    End Sub

    Private Sub btnmenu_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnmenu.Click
        menupdir.Show()
        Me.Hide()
        gbxsel.Visible = True
        gbxhorarios.Visible = False
        gbxval.Visible = False
        btnenv.Visible = False
        btnmenu.Visible = False
        ltvhorasnoc.Visible = False
        ltvhorasmat.Visible = False
        ltvhorasvesp.Visible = False
        gbxobs.Visible = False
        cmbturno.SelectedIndex = 0
        btnenv.Enabled = False
        txtobs.Text = ""
    End Sub

    Private Sub btnenv_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnenv.Click
        If (txtobs.Text = "") Then
            MsgBox("Debe ingresar observaciones antes de enviar")
        Else
            MsgBox("Sus observaciones serán enviadas al secretario escolar para su corrección")
            menupdir.Show()
            Me.Hide()
            gbxsel.Visible = True
            gbxhorarios.Visible = False
            gbxval.Visible = False
            btnenv.Visible = False
            btnmenu.Visible = False
            ltvhorasnoc.Visible = False
            ltvhorasvesp.Visible = False
            ltvhorasmat.Visible = False
            gbxobs.Visible = False
            cmbturno.SelectedIndex = 0
            btnenv.Enabled = False
            txtobs.Text = ""
        End If
    End Sub

    Private Sub btnsi_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsi.Click
        MsgBox("Se informará al secretario escolar que los datos fueron validados")
        menupdir.Show()
        Me.Hide()
        gbxsel.Visible = True
        gbxhorarios.Visible = False
        gbxval.Visible = False
        btnenv.Visible = False
        btnmenu.Visible = False
        ltvhorasnoc.Visible = False
        ltvhorasmat.Visible = False
        ltvhorasvesp.Visible = False


        gbxobs.Visible = False
        cmbturno.SelectedIndex = 0
        btnenv.Enabled = False
        txtobs.Text = ""
    End Sub

    Private Sub btnclose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnclose.Click

        Select Case MsgBox("Desea cerrar sesión?", MsgBoxStyle.YesNo)
            Case MsgBoxResult.Yes
                btnenv.Enabled = False
                txtobs.Text = ""
                gbxsel.Visible = True
                gbxhorarios.Visible = False
                gbxobs.Visible = False
                gbxval.Visible = False
                btnenv.Visible = False
                btnmenu.Visible = False
                ltvhorasnoc.Visible = False
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
End Class