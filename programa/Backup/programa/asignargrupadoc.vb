Public Class asignarGrupo
    Dim cont As Integer


    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnselec3.Click
        
        If (ltvdoc.SelectedItems.Count = 0) Then
            MsgBox("Debe seleccionar un docente")
        End If
        
        If (ltvdoc.SelectedItems.Count > 0) Then
            ltvdoc.Visible = False
            lbldocee.Visible = True
            lbldocee.SetBounds(88, 54, 157, 16)
            btnselec3.Visible = False
            ltvmat.Visible = False
            btnselec1.Visible = False
        End If
    End Sub

    Private Sub Form27_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Timer1.Start()
        lblfechaa.Visible = False
        lblfecha.Visible = False
        lbldocee.Visible = False
        lblgrupoe.Visible = False
        lblmat.Visible = False
        ltvmat.Visible = False
        btnselec1.Visible = False
        lblmate.Visible = False
        btnconf.Visible = False
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnselec2.Click
        If ltvdoc.SelectedItems.Count = 0 Then
            MsgBox("Primero debe seleccionar un docente")
        End If
        If (ltvdoc.SelectedItems.Count > 0 And ltvgrupo.SelectedItems.Count = 0) Then
            MsgBox("Debe seleccionar un grupo")

        End If

        If (ltvdoc.SelectedItems.Count > 0 And ltvgrupo.SelectedItems.Count > 0) Then

            lbldocee.Visible = True
            ltvgrupo.Visible = False
            lblgrupoe.Visible = True
            lblgrupo.SetBounds(12, 73, 54, 16)
            lblgrupoe.SetBounds(88, 73, 31, 16)
            btnselec2.Visible = False
            ltvmat.Visible = True
            btnselec1.Visible = True
            lblmat.Visible = True
            ltvmat.SetBounds(15, 117, 451, 184)
            btnselec1.SetBounds(197, 317, 121, 28)
            lblmat.SetBounds(12, 98, 64, 16)

        End If
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnselec1.Click
        If ltvmat.SelectedItems.Count = 0 Then
            MsgBox("Debe seleccionar una materia")
        End If
        If ltvmat.SelectedItems.Count > 0 Then
            lblfecha.Visible = True
            lblfecha.SetBounds(12, 123, 55, 16)
            lblfechaa.Visible = True
            lblfechaa.SetBounds(88, 123, 82, 16)
            lblfechaa.Text = DateTime.Now()
            lblmate.Visible = True
            lblmate.SetBounds(88, 98, 207, 16)
            ltvmat.Visible = False
            btnconf.Visible = True
            btnselec1.Visible = False
            MsgBox("Ha ingresado la información correctamente")
        End If
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnconf.Click
        ltvgrupo.SelectedItems.Clear()
        ltvdoc.SelectedItems.Clear()
        ltvmat.SelectedItems.Clear()
        btnselec2.Visible = True
        btnselec3.Visible = True
        lbldocee.Text = ""
        lbldocee.Visible = False
        ltvdoc.Visible = True
        ltvgrupo.Visible = True
        lblgrupo.SetBounds(279, 54, 54, 16)
        lblmat.Visible = False
        lblmate.Visible = False
        lblfecha.Visible = False
        lblfechaa.Visible = False
        btnconf.Visible = False
        ltvmat.Visible = False
        lblgrupoe.Visible = False
        
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnatras.Click
        ltvgrupo.SelectedItems.Clear()
        ltvdoc.SelectedItems.Clear()
        ltvmat.SelectedItems.Clear()

       
        btnselec2.Visible = True
        btnselec3.Visible = True
        lbldocee.Text = ""
        lbldocee.Visible = False
        ltvdoc.Visible = True
        ltvgrupo.Visible = True
        lblgrupo.SetBounds(279, 54, 54, 16)
        lblmat.Visible = False
        lblmate.Visible = False
        lblfecha.Visible = False
        lblfechaa.Visible = False
        btnconf.Visible = False
        ltvmat.Visible = False
        lblgrupoe.Visible = False
        abmdocentes.Show()


        Me.Hide()
    End Sub

    Private Sub ListView3_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ltvmat.SelectedIndexChanged
        If ltvmat.SelectedItems.Count > 0 Then lblmate.Text = ltvmat.SelectedItems.Item(0).Text
    End Sub

    Private Sub Label9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lbltipou.Click

    End Sub

    Public Sub lblmate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblmate.Click
        

    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bnclose.Click
        Select Case MsgBox("Desea cerrar sesión?", MsgBoxStyle.YesNo)
            Case MsgBoxResult.Yes
                ltvgrupo.SelectedItems.Clear()
                ltvdoc.SelectedItems.Clear()
                ltvmat.SelectedItems.Clear()


                btnselec2.Visible = True
                btnselec3.Visible = True
                lbldocee.Text = ""
                lbldocee.Visible = False
                ltvdoc.Visible = True
                ltvgrupo.Visible = True
                lblgrupo.SetBounds(279, 54, 54, 16)
                lblmat.Visible = False
                lblmate.Visible = False
                lblfecha.Visible = False
                lblfechaa.Visible = False
                btnconf.Visible = False
                ltvmat.Visible = False
                lblgrupoe.Visible = False
                login.cmbpass.SelectedIndex = 0
                login.cmbnomu.SelectedIndex = 0

                login.Show()
                Me.Hide()
            Case MsgBoxResult.No
                Me.Hide()
                Me.Show()
        End Select
    End Sub

    Private Sub lblfecha_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblfecha.Click

    End Sub

    Private Sub ltvgrupo_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ltvgrupo.SelectedIndexChanged
        If ltvgrupo.SelectedItems.Count > 0 Then lblgrupoe.Text = ltvgrupo.SelectedItems.Item(0).Text
    End Sub

    Private Sub lblfechaa_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblfechaa.Click

    End Sub

    Private Sub ltvdoc_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ltvdoc.SelectedIndexChanged
        

        If ltvdoc.SelectedItems.Count > 0 Then lbldocee.Text = ltvdoc.SelectedItems.Item(0).Text

    End Sub
End Class