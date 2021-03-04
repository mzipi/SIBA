Public Class disponibil

    Private Sub Form2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        GroupBox1.Enabled = False

        Timer1.Start()
        lblhora.Text = DateTime.Now()
        GroupBox4.Visible = False

    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        lblhora.Text = DateTime.Now()
    End Sub

    Private Sub Label4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Label3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub GroupBox1_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub LinkLabel1_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs)

    End Sub

    Private Sub ToolTip1_Popup(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PopupEventArgs)

    End Sub

    Private Sub LinkLabel1_LinkClicked_1(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs)
        login.Show()
        Me.Hide()

    End Sub

    Private Sub RadioButton2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub RadioButton1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)



    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btndefinir.Click
        Dim total As Integer
        total = Val(txtdefcant.Text)
        If (total = 0) Then
            MsgBox("No ha ingresado ningun dato. Debe ingresar la cantidad de salones para continuar!!!")


        Else
            lblcantaulas.Text = Val(txtdefcant.Text)
            GroupBox1.Enabled = True
            GroupBox2.Enabled = False
        End If

    End Sub

    Private Sub GroupBox2_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox2.Enter

    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnaceptar.Click
        Dim suma As Integer
        suma = Val(txtteo.Text) + Val(txttall.Text) + Val(txtlab.Text)

        If (suma = 0) Then

            MsgBox("No ha ingresado ningun dato. Debe completar al menos un campo para continuar!!!!")

        ElseIf (suma > Val(lblcantaulas.Text)) Then

            MsgBox("El total de salones ingresados es mayor al numero de aulas definidas.Vuelva a ingresar los datos!!!!")


        Else
            ' altasalon.txtteorico.Text = Val(txtteo.Text)

            'altasalon.txtlaboratorio.Text = Val(txtlab.Text)

            'altasalon.txttaller.Text = Val(txttall.Text)



            'GroupBox4.Visible = True 

        End If
    End Sub

    Private Sub Button8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnvolver.Click
        menupse.Show()
        GroupBox4.Visible = False
        txtteo.Clear()
        txtlab.Clear()
        txttall.Clear()
        txtdefcant.Clear()
        lblcantaulas.Text = 0

        menupse.Show()
        Me.Hide()

    End Sub

    Private Sub TextBox5_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Button1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Label5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Label2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Label4_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Button9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btningresar.Click
        altasalon.Show()
        Me.Hide()
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnatras.Click
        menupse.Show()
        Me.Hide()
        GroupBox4.Visible = False
        txtteo.Clear()
        txtlab.Clear()
        txttall.Clear()
        txtdefcant.Clear()
        lblcantaulas.Text = 0
        GroupBox1.Enabled = False
        GroupBox2.Enabled = True
    End Sub

    Private Sub txtdefcant_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtdefcant.KeyPress
        If (e.KeyChar < "0" Or e.KeyChar > "9") And e.KeyChar <> Chr(Keys.Back) Then
            e.KeyChar = ""
        End If
    End Sub

    Private Sub TextBox4_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtdefcant.TextChanged

    End Sub

    Private Sub txtteo_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtteo.KeyPress
        If (e.KeyChar < "0" Or e.KeyChar > "9") And e.KeyChar <> Chr(Keys.Back) Then
            e.KeyChar = ""
        End If
    End Sub

    Private Sub txtteo_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtteo.TextChanged

    End Sub

    Private Sub txtlab_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtlab.KeyPress
        If (e.KeyChar < "0" Or e.KeyChar > "9") And e.KeyChar <> Chr(Keys.Back) Then
            e.KeyChar = ""
        End If
    End Sub

    Private Sub txtlab_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtlab.TextChanged

    End Sub

    Private Sub txttall_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txttall.KeyPress
        If (e.KeyChar < "0" Or e.KeyChar > "9") And e.KeyChar <> Chr(Keys.Back) Then
            e.KeyChar = ""
        End If
    End Sub

    Private Sub txttall_SizeChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txttall.SizeChanged

    End Sub

    Private Sub txttall_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txttall.TextChanged

    End Sub

    Private Sub lblclose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblclose.Click
        MsgBox("Desea cerrar sesión?", MsgBoxStyle.YesNo)
        If (MsgBoxResult.Yes) Then
            GroupBox4.Visible = False
            txtteo.Clear()
            txtlab.Clear()
            txttall.Clear()
            txtdefcant.Clear()
            lblcantaulas.Text = 0
            GroupBox1.Enabled = False
            GroupBox2.Enabled = True
            login.Show()
            Me.Hide()

        End If
    End Sub
End Class