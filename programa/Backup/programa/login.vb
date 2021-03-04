Public Class login
    Dim TEXTBOX6 As TextBox



    Private Sub Label3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.BackgroundImageChanged, Label4.ForeColorChanged

    End Sub

    Private Sub Label5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label5.Click

    End Sub

    Private Sub Label4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label4.Click

    End Sub

    Private Sub SIBA_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        cmbnomu.SelectedIndex = 0
        cmbpass.SelectedIndex = 0
        GroupBox1.Visible = False
        GroupBox5.Visible = False

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim usuario As String
        usuario = cmbnomu.SelectedIndex
        If (cmbnomu.SelectedIndex <> cmbpass.SelectedIndex) Then
            MsgBox("Deben coincidir el usuario y la contraseña seleccionadas")
        End If


        If (cmbnomu.SelectedIndex = cmbpass.SelectedIndex) Then
            Select Case usuario
                Case 1
                    menupadm.Show()
                    Me.Hide()
                    menupadm.lblnombreu.Text = cmbnomu.SelectedItem
                    sinDoc.lbltipou.Text = cmbnomu.SelectedItem
                    repgrupsindoc.lbltipou.Text = cmbnomu.SelectedItem
                Case 2
                    menupalum.Show()
                    Me.Hide()
                    consmatxcar.lbltipou.Text = cmbnomu.SelectedItem
                    consplanalum.lbltipou.Text = cmbnomu.SelectedItem
                    consplanalumdia.lbltipou.Text = cmbnomu.SelectedItem
                    menupalum.lbltipou.Text = cmbnomu.SelectedItem
                    menupalum.lblnombreu.Text = cmbnomu.SelectedItem
                Case 3
                    menupdir.Show()
                    menupdir.lblnombreu.Text = cmbnomu.SelectedItem
                    Me.Hide()

                Case 4
                    menupdoc.Show()
                    Me.Hide()
                    menupdoc.lblnombreu.Text = cmbnomu.SelectedItem
                    conshordoc.lbltipou.Text = cmbnomu.SelectedItem
                    consplanalum.lbltipou.Text = cmbnomu.SelectedItem
                    consplanalumdia.lbltipou.Text = cmbnomu.SelectedItem
                    conshordoc.lbltipou.Text = cmbnomu.SelectedItem

                    repDoc.lbltipou.Text = cmbnomu.SelectedItem
                    repgrupsindoc.lbltipou.Text = cmbnomu.SelectedItem
                Case 5

                    menurepei.Show()
                    menurepei.lblnombreu.Text = cmbnomu.SelectedItem

                Case 0
                    MsgBox("Debe seleccionar un usuario?")
                Case 6
                    menupse.Show()
                    Me.Hide()
                    consmatxcar.lbltipou.Text = cmbnomu.SelectedItem
                    consplanalum.lbltipou.Text = cmbnomu.SelectedItem
                    consplanalumdia.lbltipou.Text = cmbnomu.SelectedItem
                    menupse.lbltipou.Text = cmbnomu.SelectedItem
                    conshordoc.lbltipou.Text = cmbnomu.SelectedItem
                    sinDoc.lbltipou.Text = cmbnomu.SelectedItem
                    repDoc.lbltipou.Text = cmbnomu.SelectedItem
                    repgrupsindoc.lbltipou.Text = cmbnomu.SelectedItem

            End Select
        End If
        disponibil.lblnombreu.Text = cmbnomu.SelectedItem


        menupse.lblnombreu.Text = cmbnomu.SelectedItem

        disploc.lblnombreu.Text = cmbnomu.SelectedItem



    End Sub

    Private Sub PictureBox2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox2.Click
        GroupBox2.Visible = False
        GroupBox1.Visible = True
        GroupBox1.SetBounds(165, 60, 300, 250)
        Label1.Visible = False
        GroupBox4.Visible = False
        GroupBox3.SetBounds(25, 60, 95, 95)
    End Sub

    Private Sub Label7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label7.Click

    End Sub

    Private Sub Label8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label8.Click

    End Sub

    Private Sub GroupBox3_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox3.Enter

    End Sub

    Private Sub GroupBox1_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.Click
        GroupBox5.Visible = True

        GroupBox5.SetBounds(165, 60, 300, 250)
        GroupBox3.Visible = False
        GroupBox2.Visible = False
        GroupBox4.SetBounds(25, 60, 95, 95)
        Label2.Visible = False
        Label1.SetBounds(88, 6, 385, 46)

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbnomu.SelectedIndexChanged

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        MsgBox("En construcción, en breve estará disponible dicha opción.")
    End Sub
End Class
