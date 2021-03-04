Public Class planilladodir

    Private Sub planillladodir_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        gbxobs.Visible = False
        
    End Sub

    Private Sub btnmenu_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnmenu.Click, btnmenu.Click
        txtobs.Text = ""
        menupdir.Show()
        Me.Hide()
        gbxobs.Visible = False
        btnenv.Enabled = False


    End Sub

    

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnenv.Click
        If (txtobs.Text = "") Then
            MsgBox("Debe ingresar observaciones antes de enviar")
        Else
            MsgBox("Sus observaciones serán enviadas al secretario escolar para su corrección")
            txtobs.Text = ""

            menupdir.Show()
            Me.Hide()
            gbxobs.Visible = False
            btnenv.Enabled = False

        End If


    End Sub

    Private Sub btnclose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnclose.Click

        Select Case MsgBox("Desea cerrar sesión?", MsgBoxStyle.YesNo)
            Case MsgBoxResult.Yes
                btnenv.Enabled = False
                txtobs.Text = ""
                gbxobs.Visible = False
                login.txtpass.clear()
                login.txtusuario.clear()

                login.Show()
                Me.Hide()
            Case MsgBoxResult.No
                Me.Hide()
                Me.Show()
        End Select
        

    End Sub

    Private Sub btnno_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnno.Click
        gbxobs.Visible = True
        btnenv.Enabled = True

    End Sub

    Private Sub btnsi_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsi.Click
        MsgBox("Se informará al secretario escolar que el planillado fue validado")
        menupdir.Show()
        Me.Hide()
        txtobs.Text = ""
    End Sub
End Class